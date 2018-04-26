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
            InitializeAPI();
        }

        private void InitializeAPI()
        {
            try
            {
                bitmex = new BitMEXApi(APIKey, APISecret);
                label1.Text = bitmex.GetAccountBalance().ToString();
            }
            catch(Exception ex)
            {
            }
}
    }
}
