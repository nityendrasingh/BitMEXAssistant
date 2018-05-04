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
        }

        private void ddlSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveInstrument = bitmex.GetInstrument(((Instrument)ddlSymbol.SelectedItem).Symbol)[0];
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
            }
            
        }
    }
}
