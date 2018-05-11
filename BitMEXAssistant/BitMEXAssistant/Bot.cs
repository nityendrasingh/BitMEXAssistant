using BitMEX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitMEXAssistant
{
    public partial class Bot : Form
    {

        string APIKey = "";
        string APISecret = "";
        BitMEXApi bitmex;
        List<Instrument> ActiveInstruments = new List<Instrument>();
        Instrument ActiveInstrument = new Instrument();
        string Timeframe = "1m";

        int DCACounter = 0;
        int DCAContractsPer = 0;
        int DCAHours = 0;
        int DCAMinutes = 0;
        int DCASeconds = 0;
        int DCATimes = 0;
        string DCASide = "Buy";

        public Bot()
        {
            InitializeComponent();
            InitializeSettings();
        }

        private void InitializeSettings()
        {
            APIKey = Properties.Settings.Default.APIKey;
            APISecret = Properties.Settings.Default.APISecret;
        }

        private void Bot_Load(object sender, EventArgs e)
        {
            InitializeDropdownsAndSettings();
            InitializeAPI();
            InitializeSymbolInformation();
            
            
        }

        private void InitializeDropdownsAndSettings()
        {
            ddlCandleTimes.SelectedIndex = 0;
            nudDCAContracts.Value = Properties.Settings.Default.DCAContracts;
            nudDCAHours.Value = Properties.Settings.Default.DCAHours;
            nudDCAMinutes.Value = Properties.Settings.Default.DCAMinutes;
            nudDCASeconds.Value = Properties.Settings.Default.DCASeconds;
            nudDCATimes.Value = Properties.Settings.Default.DCATimes;
            chkDCAReduceOnly.Checked = Properties.Settings.Default.DCAReduceOnly;

            //Setting Tab
            chkSettingOverloadRetry.Checked = Properties.Settings.Default.OverloadRetry;
            nudSettingsOverloadRetryAttempts.Value = Properties.Settings.Default.OverloadRetryAttempts;
            nudSettingsRetryWaitTime.Value = Properties.Settings.Default.RetryAttemptWaitTime;

            UpdateDateAndTime();
        }

        private void InitializeAPI()
        {
            try
            {
                bitmex = new BitMEXApi(APIKey, APISecret);
                UpdateBalance();

                // Start our HeartBeat
                Heartbeat.Start();
            }
            catch (Exception ex)
            {
            }
        }

        private void InitializeSymbolInformation()
        {
            ActiveInstruments = bitmex.GetActiveInstruments().OrderByDescending(a => a.Volume24H).ToList();
            ddlSymbol.DataSource = ActiveInstruments;
            ddlSymbol.DisplayMember = "Symbol";
            ddlSymbol.SelectedIndex = 0;
            ActiveInstrument = ActiveInstruments[0];

            UpdatePositionInfo();
        }

        private void ddlSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveInstrument = bitmex.GetInstrument(((Instrument)ddlSymbol.SelectedItem).Symbol)[0];
            UpdatePositionInfo();
        }

        private void ddlCandleTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Timeframe = ddlCandleTimes.SelectedItem.ToString();
        }

        private void UpdateBalance()
        {
            lblBalance.Text = "Balance: " + bitmex.GetAccountBalance().ToString();
        }

        private void Heartbeat_Tick(object sender, EventArgs e)
        {
            if(DateTime.UtcNow.Second == 0)
            {
                //Update our balance each minute
                UpdateBalance();
                UpdatePositionInfo();
            }

            // Update the time every second.
            UpdateDateAndTime();


        }

        private void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }

        private void UpdateDCASummary()
        {
            DCAContractsPer = Convert.ToInt32(nudDCAContracts.Value);
            DCAHours = Convert.ToInt32(nudDCAHours.Value);
            DCAMinutes = Convert.ToInt32(nudDCAMinutes.Value);
            DCASeconds = Convert.ToInt32(nudDCASeconds.Value);
            DCATimes = Convert.ToInt32(nudDCATimes.Value);

            DateTime Start = DateTime.UtcNow;
            DateTime End = new DateTime();
            if(chkDCAExecuteImmediately.Checked)
            {
               End = DateTime.UtcNow.AddHours(DCAHours * (DCATimes - 1)).AddMinutes(DCAMinutes * (DCATimes - 1)).AddSeconds(DCASeconds * (DCATimes - 1));
            }
            else
            {
               End = DateTime.UtcNow.AddHours(DCAHours * DCATimes).AddMinutes(DCAMinutes * DCATimes).AddSeconds(DCASeconds * DCATimes);
            }
            TimeSpan Duration = End - Start;
            
            if(Duration.TotalMinutes < 1.0)
            {
                lblDCASummary.Text = (DCAContractsPer * DCATimes).ToString() + " Contracts over " + DCATimes.ToString() + " orders during a total of " + Duration.Seconds.ToString() + " seconds.";
            }
            else if(Duration.TotalHours < 1.0)
            {
                lblDCASummary.Text = (DCAContractsPer * DCATimes).ToString() + " Contracts over " + DCATimes.ToString() + " orders during a total of " + Duration.Minutes.ToString() + " minutes " + Duration.Seconds.ToString() + " seconds.";
            }
            else
            {
                lblDCASummary.Text = (DCAContractsPer * DCATimes).ToString() + " Contracts over " + DCATimes.ToString() + " orders during a total of " + ((int)Math.Floor(Duration.TotalHours)).ToString() + " hours " + Duration.Minutes.ToString() + " minutes " + Duration.Seconds.ToString() + " seconds.";
            }



        }

        private void nudDCAContracts_ValueChanged(object sender, EventArgs e)
        {
            DCAContractsPer = Convert.ToInt32(nudDCAContracts.Value);
            Properties.Settings.Default.DCAContracts = DCAContractsPer;
            SaveSettings();
            UpdateDCASummary();
        }

        private void nudDCAHours_ValueChanged(object sender, EventArgs e)
        {
            DCAHours = Convert.ToInt32(nudDCAHours.Value);
            Properties.Settings.Default.DCAHours = DCAHours;
            SaveSettings();
            UpdateDCASummary();
        }

        private void nudDCAMinutes_ValueChanged(object sender, EventArgs e)
        {
            DCAMinutes = Convert.ToInt32(nudDCAMinutes.Value);
            Properties.Settings.Default.DCAMinutes = DCAMinutes;
            SaveSettings();
            UpdateDCASummary();
        }

        private void nudDCASeconds_ValueChanged(object sender, EventArgs e)
        {
            DCASeconds = Convert.ToInt32(nudDCASeconds.Value);
            Properties.Settings.Default.DCASeconds = DCASeconds;
            SaveSettings();
            UpdateDCASummary();
        }

        private void nudDCATimes_ValueChanged(object sender, EventArgs e)
        {
            DCATimes = Convert.ToInt32(nudDCATimes.Value);
            Properties.Settings.Default.DCATimes = DCATimes;
            SaveSettings();
            UpdateDCASummary();
        }

        private void chkDCAReduceOnly_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DCAReduceOnly = chkDCAReduceOnly.Checked;
            SaveSettings();
        }

        private void chkDCAExecuteImmediately_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DCAExecuteImmediately = chkDCAExecuteImmediately.Checked;
            SaveSettings();
            UpdateDCASummary();
        }

        private void btnDCABuy_Click(object sender, EventArgs e)
        {
            UpdateDCASummary(); // Makes sure our variables are current.

            DCASide = "Buy";

            tmrDCA.Interval = (DCASeconds * 1000) + (DCAMinutes * 60 * 1000) + (DCAHours * 60 * 60 * 1000); // Must multiply by 1000, because timers operate in milliseconds.
            tmrDCA.Start(); // Start the timer.
            pgbDCA.Value = 0;
            LockDCA();
            if(chkDCAExecuteImmediately.Checked)
            {
                DCAAction();
            }
        }

        private void btnDCASell_Click(object sender, EventArgs e)
        {
            UpdateDCASummary(); // Makes sure our variables are current.

            DCASide = "Sell";

            tmrDCA.Interval = (DCASeconds * 1000) + (DCAMinutes * 60 * 1000) + (DCAHours * 60 * 60 * 1000); // Must multiply by 1000, because timers operate in milliseconds.
            tmrDCA.Start(); // Start the timer.
            pgbDCA.Value = 0;
            LockDCA();
            if (chkDCAExecuteImmediately.Checked)
            {
                DCAAction();
            }
        }

        private void btnDCAStop_Click(object sender, EventArgs e)
        {
            DCACounter = 0;
            pgbDCA.Value = 0;
            tmrDCA.Stop();
            LockDCA(false);
        }

        private void tmrDCA_Tick(object sender, EventArgs e)
        {
            DCAAction();
        }

        private void DCAAction()
        {
            DCACounter++;
            bitmex.MarketOrder(ActiveInstrument.Symbol, DCASide, DCAContractsPer, chkDCAReduceOnly.Checked);

            double Percent = ((double)DCACounter / (double)DCATimes) * 100;
            pgbDCA.Value = Convert.ToInt32(Math.Round(Percent));

            if (DCACounter == DCATimes)
            {
                DCACounter = 0;
                tmrDCA.Stop();
                pgbDCA.Value = 0;
                LockDCA(false);

            }
        }

        private void LockDCA(bool Lock = true)
        {
            nudDCAContracts.Enabled = !Lock;
            nudDCAHours.Enabled = !Lock;
            nudDCAMinutes.Enabled = !Lock;
            nudDCASeconds.Enabled = !Lock;
            nudDCATimes.Enabled = !Lock;
            pgbDCA.Visible = Lock;
            btnDCABuy.Visible = !Lock;
            btnDCASell.Visible = !Lock;
            btnDCAStop.Visible = Lock;
            chkDCAReduceOnly.Enabled = !Lock;
            chkDCAExecuteImmediately.Enabled = !Lock;
        }

        private void UpdateDateAndTime()
        {
            lblTimeUTC.Text = DateTime.UtcNow.ToShortDateString() + " " + DateTime.UtcNow.ToLongTimeString();
        }

        private void UpdatePositionInfo()
        {
            nudPositionLimitPrice.Increment = ActiveInstrument.TickSize;
            List<Position> Positions = bitmex.GetOpenPositions(ActiveInstrument.Symbol);
            if(Positions.Any())
            {
                gbxPosition.Visible = true;
                txtPositionSize.Text = Positions[0].CurrentQty.ToString();
                txtPositionEntryPrice.Text = Positions[0].AvgEntryPrice.ToString();
                txtPositionMarkPrice.Text = Positions[0].MarkPrice.ToString();
                txtPositionLiquidation.Text = Positions[0].LiquidationPrice.ToString();
                txtPositionMargin.Text = Positions[0].Leverage.ToString();
                txtPositionUnrealizedPnL.Text = Positions[0].UsefulUnrealisedPnl.ToString();
                txtPositionUnrealizedPnLPercent.Text = Positions[0].UnrealisedPnlPcnt.ToString() + "%";
                if(nudPositionLimitPrice.Value == 0m) // Only updates when default value is present
                {
                    nudPositionLimitPrice.Value = Convert.ToDecimal(((int)Math.Floor((double)Positions[0].MarkPrice)).ToString() + ".0");
                }
                
            }
            else
            {
                gbxPosition.Visible = false;
            }
            
        }

        private void btnPositionMarketClose_Click(object sender, EventArgs e)
        {
            UpdatePositionInfo(); // Make sure info is up to date as possible.

            int Size = Convert.ToInt32(txtPositionSize.Text);
            string Side = "Buy";

            if(Size < 0) // We are short
            {
                Side = "Buy";
                Size = (int)Math.Abs((decimal)Size); // Makes sure size is positive number
            }
            else if(Size > 0)
            {
                Side = "Sell";
                Size = (int)Math.Abs((decimal)Size); // Makes sure size is positive number
            }
            bitmex.MarketOrder(ActiveInstrument.Symbol, Side, Size, true);
            UpdatePositionInfo(); // Update our position information again.
        }

        private void btnPositionLimitClose_Click(object sender, EventArgs e)
        {
            try
            {
                decimal Price = nudPositionLimitPrice.Value;

                    // We have entered a valid price
                    int Size = Convert.ToInt32(txtPositionSize.Text);
                    string Side = "Buy";

                    if (Size < 0) // We are short
                    {
                        Side = "Buy";
                        Size = (int)Math.Abs((decimal)Size); // Makes sure size is positive number
                    }
                    else if (Size > 0)
                    {
                        Side = "Sell";
                        Size = (int)Math.Abs((decimal)Size); // Makes sure size is positive number
                    }
                    bitmex.LimitOrder(ActiveInstrument.Symbol, Side, Size, Price, true);

                    UpdatePositionInfo(); // Make sure info is up to date as possible.


                
            }
            catch(Exception ex)
            {

            }
            
        }

        private void chkSettingOverloadRetry_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.OverloadRetry = chkSettingOverloadRetry.Checked;
            SaveSettings();
        }

        private void nudSettingsOverloadRetryAttempts_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.OverloadRetryAttempts = (int)nudSettingsOverloadRetryAttempts.Value;
            SaveSettings();
        }

        private void nudSettingsRetryWaitTime_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RetryAttemptWaitTime = (int)nudSettingsRetryWaitTime.Value;
            SaveSettings();
        }
    }
}
