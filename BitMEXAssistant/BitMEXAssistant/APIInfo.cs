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
    public partial class APIInfo : Form
    {

        BitMEXApi bitmex;
        bool APIValid = false;

        public APIInfo()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                bitmex = new BitMEXApi(txtKey.Text.Trim(), txtSecret.Text.Trim());
                GetAPIValidity();
                if(APIValid)
                {
                    this.Close();
                    // TODO: API is valid, open the form with assistant tools at that point.
                }
        }
            catch(Exception ex)
            {
                // If it shoots an error, API is invalid.
                APIValid = false;
                lblAPIStatus.Text = "API info is invalid!";
            }



}

        // Check account balance/validity
        private void GetAPIValidity()
        {
            decimal WalletBalance = 0;
            try // Code is simple, if we get our account balance without an error the API is valid, if not, it will throw an error and API will be marked not valid.
            {

                WalletBalance = bitmex.GetAccountBalance();
                if (WalletBalance >= 0)
                {
                    APIValid = true;
                    lblAPIStatus.Text = "API info valid.";
                }
                else
                {
                    APIValid = false;
                    lblAPIStatus.Text = "API info is invalid!";
                }
            }
            catch (Exception ex)
            {
                APIValid = false;
                lblAPIStatus.Text = "API info is invalid!";
            }
        }

    }
}
