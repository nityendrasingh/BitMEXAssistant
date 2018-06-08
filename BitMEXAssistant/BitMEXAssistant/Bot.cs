using BitMEX;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

            // Spread Settings
            nudSpreadBuyOrderCount.Value = Properties.Settings.Default.SpreadBuyOrders;
            nudSpreadSellOrderCount.Value = Properties.Settings.Default.SpreadSellOrders;
            nudSpreadBuyValueApart.Value = Properties.Settings.Default.SpreadBuyValueApart;
            nudSpreadSellValueApart.Value = Properties.Settings.Default.SpreadSellValueApart;
            nudSpreadBuyContractsEach.Value = Properties.Settings.Default.SpreadBuyContractsEach;
            nudSpreadSellContractsEach.Value = Properties.Settings.Default.SpreadSellContractsEach;
            chkSpreadBuyReduceOnly.Checked = Properties.Settings.Default.SpreadBuyReduceOnly;
            chkSpreadSellReduceOnly.Checked = Properties.Settings.Default.SpreadSellReduceOnly;
            chkSpreadyBuyPostOnly.Checked = Properties.Settings.Default.SpreadBuyPostOnly;
            chkSpreadSellPostOnly.Checked = Properties.Settings.Default.SpreadSellPostOnly;
            chkSpreadBuyExecute.Checked = Properties.Settings.Default.SpreadBuyExecute;
            chkSpreadSellExecute.Checked = Properties.Settings.Default.SpreadSellExecute;
            chkSpreadCancelWhileOrdering.Checked = Properties.Settings.Default.SpreadCancelBeforeOrdering;


            // DCA Settings
            nudDCAContracts.Value = Properties.Settings.Default.DCAContracts;
            nudDCAHours.Value = Properties.Settings.Default.DCAHours;
            nudDCAMinutes.Value = Properties.Settings.Default.DCAMinutes;
            nudDCASeconds.Value = Properties.Settings.Default.DCASeconds;
            nudDCATimes.Value = Properties.Settings.Default.DCATimes;
            chkDCAReduceOnly.Checked = Properties.Settings.Default.DCAReduceOnly;

            // Setting Tab Settings
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
            int DecimalPlacesInTickSize = BitConverter.GetBytes(decimal.GetBits(ActiveInstrument.TickSize)[3])[2];
            UpdateFormsForTickSize(ActiveInstrument.TickSize, DecimalPlacesInTickSize);

        }

        private void UpdateFormsForTickSize(decimal TickSize, int Decimals)
        {
            nudPositionLimitPrice.DecimalPlaces = Decimals;
            nudPositionLimitPrice.Increment = TickSize;

            nudSpreadBuyValueApart.DecimalPlaces = Decimals;
            nudSpreadBuyValueApart.Increment = TickSize;

            nudSpreadSellValueApart.DecimalPlaces = Decimals;
            nudSpreadSellValueApart.Increment = TickSize;
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

        private void nudSpreadBuyOrderCount_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SpreadBuyOrders = (int)nudSpreadBuyOrderCount.Value;
            SaveSettings();
        }

        private void nudSpreadSellOrderCount_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SpreadSellOrders = (int)nudSpreadSellOrderCount.Value;
            SaveSettings();
        }

        private void nudSpreadBuyValueApart_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SpreadBuyValueApart = nudSpreadBuyValueApart.Value;
            SaveSettings();
        }

        private void nudSpreadSellValueApart_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SpreadSellValueApart = nudSpreadSellValueApart.Value;
            SaveSettings();
        }

        private void nudSpreadBuyContractsEach_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SpreadBuyContractsEach = (int)nudSpreadBuyContractsEach.Value;
            SaveSettings();
        }

        private void nudSpreadSellContractsEach_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SpreadSellContractsEach = (int)nudSpreadSellContractsEach.Value;
            SaveSettings();
        }

        private void chkSpreadBuyReduceOnly_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SpreadBuyReduceOnly = chkSpreadBuyReduceOnly.Checked;
            SaveSettings();
        }

        private void chkSpreadSellReduceOnly_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SpreadSellReduceOnly = chkSpreadSellReduceOnly.Checked;
            SaveSettings();
        }

        private void chkSpreadyBuyPostOnly_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SpreadBuyPostOnly = chkSpreadyBuyPostOnly.Checked;
            SaveSettings();
        }

        private void chkSpreadSellPostOnly_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SpreadSellPostOnly = chkSpreadSellPostOnly.Checked;
            SaveSettings();
        }

        private void chkSpreadBuyExecute_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SpreadBuyExecute = chkSpreadBuyExecute.Checked;
            SaveSettings();
        }

        private void chkSpreadSellExecute_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SpreadSellExecute = chkSpreadSellExecute.Checked;
            SaveSettings();
        }

        private void chkSpreadCancelWhileOrdering_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SpreadCancelBeforeOrdering = chkSpreadCancelWhileOrdering.Checked;
            SaveSettings();
        }

        private void btnSpreadCloseAllOpenOrders_Click(object sender, EventArgs e)
        {
            bitmex.CancelAllOpenOrders(ActiveInstrument.Symbol);
        }

        private void btnSpreadPlaceOrders_Click(object sender, EventArgs e)
        {
            // do our logic for creating a bulk order to submit
            List<Order> BulkOrders = new List<Order>();

            // Step 1, see if we need to cancel all open orders and do it if so
            if (chkSpreadCancelWhileOrdering.Checked)
            {
                // Cancel all open orders
                bitmex.CancelAllOpenOrders(ActiveInstrument.Symbol);
            }

            // Step 2, check to see if we even need to bother building buy or sell orders
            // Step 3, if we do, respectively create each individual order necessary based on settings logic
            decimal CurrentPrice = bitmex.GetCurrentPrice(ActiveInstrument.Symbol);

            if(chkSpreadBuyExecute.Checked)
            {
                // build our buy orders
                for(int i = 1; i <= (int)nudSpreadBuyOrderCount.Value; i++)
                {
                    Order o = new Order();
                    o.Side = "Buy";
                    o.OrderQty = (int?)nudSpreadBuyContractsEach.Value;
                    o.Symbol = ActiveInstrument.Symbol;
                    o.Price = (double?)(CurrentPrice - (nudSpreadBuyValueApart.Value * i));
                    if(chkSpreadBuyReduceOnly.Checked && chkSpreadyBuyPostOnly.Checked)
                    {
                        o.ExecInst = "ReduceOnly,ParticipateDoNotInitiate";
                    }
                    else if(!chkSpreadBuyReduceOnly.Checked && chkSpreadyBuyPostOnly.Checked)
                    {
                        o.ExecInst = "ParticipateDoNotInitiate";
                    }
                    else if(chkSpreadBuyReduceOnly.Checked && !chkSpreadyBuyPostOnly.Checked)
                    {
                        o.ExecInst = "ReduceOnly";
                    }
                    BulkOrders.Add(o);
                }
            }
            if(chkSpreadSellExecute.Checked)
            {
                // build our sell orders
                for (int i = 1; i <= (int)nudSpreadSellOrderCount.Value; i++)
                {
                    Order o = new Order();
                    o.Side = "Sell";
                    o.OrderQty = (int?)nudSpreadSellContractsEach.Value;
                    o.Symbol = ActiveInstrument.Symbol;
                    o.Price = (double?)(CurrentPrice + (nudSpreadSellValueApart.Value * i));
                    if (chkSpreadSellReduceOnly.Checked && chkSpreadSellPostOnly.Checked)
                    {
                        o.ExecInst = "ReduceOnly,ParticipateDoNotInitiate";
                    }
                    else if (!chkSpreadSellReduceOnly.Checked && chkSpreadSellPostOnly.Checked)
                    {
                        o.ExecInst = "ParticipateDoNotInitiate";
                    }
                    else if (chkSpreadSellReduceOnly.Checked && !chkSpreadSellPostOnly.Checked)
                    {
                        o.ExecInst = "ReduceOnly";
                    }
                    BulkOrders.Add(o);
                }
            }

            // Step 4, call the bulk order submit button
            string BulkOrderString = BuildBulkOrder(BulkOrders);
            bitmex.BulkOrder(BulkOrderString);

        }

        private string BuildBulkOrder(List<Order> Orders, bool Amend = false)
        {
            StringBuilder str = new StringBuilder();

            str.Append("[");

            int i = 1;
            foreach (Order o in Orders)
            {
                if (i > 1)
                {
                    str.Append(", ");
                }
                str.Append("{");
                if (Amend == true)
                {
                    str.Append("\"orderID\": \"" + o.OrderId.ToString() + "\", ");
                }
                str.Append("\"orderQty\": " + o.OrderQty.ToString() + ", \"price\": " + o.Price.ToString() + ", \"side\": \"" + o.Side + "\", \"symbol\": \"" + o.Symbol + "\"");
                if(o.ExecInst.Trim() != "")
                {
                    str.Append(", \"execInst\": \"" + o.ExecInst + "\"");
                }
                str.Append("}");
                i++;
            }

            str.Append("]");

            return str.ToString();
        }

        private void ExportCandleData()
        {
            // First see if we have the file we want where we want it. To do that, we need to get the filepath to our app folder in my documents
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // We are working in My Documents.
            if (!Directory.Exists(path + "\\BitMEXAssistant"))
            {
                // If our Kizashi Logs folder doesn't exist, create it.
                Directory.CreateDirectory(path + "\\BitMEXAssistant");
            }

            // Optionally, you could loop through all symbols and timeframes to get all files at once here
            string ourfilepath = Path.Combine(path, "BitMEXAssistant", "Assistant" + ActiveInstrument.Symbol + Timeframe + "CandleHistory.csv");
            // Get candle info, and Account balance
            if (!File.Exists(ourfilepath))
            {
                // If our files doesn't exist, we'll creat it now with the stream writer
                using (StreamWriter write = new StreamWriter(ourfilepath))
                {
                    CsvWriter csw = new CsvWriter(write);

                    csw.WriteHeader<SimpleCandle>(); // writes the csv header for this class
                    csw.NextRecord();

                    // loop through all candles, add those items to the csv while we are getting 500 candles (full datasets)
                    List<SimpleCandle> Candles = GetSimpleCandles(ActiveInstrument.Symbol, Timeframe);
                    while(Candles.Count > 0)
                    {

                        csw.WriteRecords(Candles);

                        // Get candles with a start time of the last candle plus 1 min
                        switch(Timeframe)
                        {
                            case "1m":
                                Candles = GetSimpleCandles(ActiveInstrument.Symbol, Timeframe, Candles.OrderByDescending(a => a.TimeStamp).FirstOrDefault().TimeStamp.AddMinutes(1));
                                break;
                            case "5m":
                                Candles = GetSimpleCandles(ActiveInstrument.Symbol, Timeframe, Candles.OrderByDescending(a => a.TimeStamp).FirstOrDefault().TimeStamp.AddMinutes(5));
                                break;
                            case "1h":
                                Candles = GetSimpleCandles(ActiveInstrument.Symbol, Timeframe, Candles.OrderByDescending(a => a.TimeStamp).FirstOrDefault().TimeStamp.AddHours(1));
                                break;
                            case "1d":
                                Candles = GetSimpleCandles(ActiveInstrument.Symbol, Timeframe, Candles.OrderByDescending(a => a.TimeStamp).FirstOrDefault().TimeStamp.AddDays(1));
                                break;
                            default:
                                Candles = GetSimpleCandles(ActiveInstrument.Symbol, Timeframe, Candles.OrderByDescending(a => a.TimeStamp).FirstOrDefault().TimeStamp.AddMinutes(1));
                                break;
                        }

                        // Lets sleep for a bit, 5 seconds, don't want to get rate limited
                        Thread.Sleep(2500);
                    }
                        
                }
            }
            else
            {
                // our file exists, let read existing contents, add them back in, with the new candles.
                string ourtemppath = Path.Combine(path, "BitMEXAssistant", "Assistant" + ActiveInstrument.Symbol + Timeframe + "CandleHistory.csv");
                // Open our file, and append data to it.
                using (StreamReader reader = new StreamReader(ourfilepath))
                {
                    using (StreamWriter write = new StreamWriter(ourtemppath))
                    {
                        CsvWriter csw = new CsvWriter(write);
                        CsvReader csr = new CsvReader(reader);

                        // Recreate existing records, then add new ones.
                        List<SimpleCandle> records = csr.GetRecords<SimpleCandle>().ToList();

                        csw.WriteRecords(records);

                        // Now to any new since the most recent record
                        List<SimpleCandle> Candles = new List<SimpleCandle>();
                        // Get candles with a start time of the last candle plus 1 min
                        switch (Timeframe)
                        {
                            case "1m":
                                Candles = GetSimpleCandles(ActiveInstrument.Symbol, Timeframe, records.OrderByDescending(a => a.TimeStamp).FirstOrDefault().TimeStamp.AddMinutes(1));
                                break;
                            case "5m":
                                Candles = GetSimpleCandles(ActiveInstrument.Symbol, Timeframe, records.OrderByDescending(a => a.TimeStamp).FirstOrDefault().TimeStamp.AddMinutes(5));
                                break;
                            case "1h":
                                Candles = GetSimpleCandles(ActiveInstrument.Symbol, Timeframe, records.OrderByDescending(a => a.TimeStamp).FirstOrDefault().TimeStamp.AddHours(1));
                                break;
                            case "1d":
                                Candles = GetSimpleCandles(ActiveInstrument.Symbol, Timeframe, records.OrderByDescending(a => a.TimeStamp).FirstOrDefault().TimeStamp.AddDays(1));
                                break;
                            default:
                                Candles = GetSimpleCandles(ActiveInstrument.Symbol, Timeframe, records.OrderByDescending(a => a.TimeStamp).FirstOrDefault().TimeStamp.AddMinutes(1));
                                break;
                        }

                        // loop through all candles, add those items to the csv while we are getting 500 candles (full datasets)
                        
                        while (Candles.Count > 0)
                        {

                            csw.WriteRecords(Candles);

                            // Get candles with a start time of the last candle plus 1 min
                            switch (Timeframe)
                            {
                                case "1m":
                                    Candles = GetSimpleCandles(ActiveInstrument.Symbol, Timeframe, Candles.OrderByDescending(a => a.TimeStamp).FirstOrDefault().TimeStamp.AddMinutes(1));
                                    break;
                                case "5m":
                                    Candles = GetSimpleCandles(ActiveInstrument.Symbol, Timeframe, Candles.OrderByDescending(a => a.TimeStamp).FirstOrDefault().TimeStamp.AddMinutes(5));
                                    break;
                                case "1h":
                                    Candles = GetSimpleCandles(ActiveInstrument.Symbol, Timeframe, Candles.OrderByDescending(a => a.TimeStamp).FirstOrDefault().TimeStamp.AddHours(1));
                                    break;
                                case "1d":
                                    Candles = GetSimpleCandles(ActiveInstrument.Symbol, Timeframe, Candles.OrderByDescending(a => a.TimeStamp).FirstOrDefault().TimeStamp.AddDays(1));
                                    break;
                                default:
                                    Candles = GetSimpleCandles(ActiveInstrument.Symbol, Timeframe, Candles.OrderByDescending(a => a.TimeStamp).FirstOrDefault().TimeStamp.AddMinutes(1));
                                    break;
                            }

                            // Lets sleep for a bit, 5 seconds, don't want to get rate limited
                            Thread.Sleep(2500);
                        }

                    }
                }

                File.Delete(ourfilepath);
                File.Copy(ourtemppath, ourfilepath);
                File.Delete(ourtemppath);
            }
            
            
        }

        private List<SimpleCandle> GetSimpleCandles(string Symbol, string Timeframe, DateTime Start = new DateTime())
        {
            List<SimpleCandle> Candles = new List<SimpleCandle>();
            if(Start != new DateTime())
            {
                Candles = bitmex.GetCandleHistory(Symbol, Timeframe, Start);
            }
            else
            {
                Candles = bitmex.GetCandleHistory(Symbol, Timeframe);
            }

            return Candles;
        }

        private void btnExportCandles_Click(object sender, EventArgs e)
        {
            ExportCandleData();
        }
    }
}
