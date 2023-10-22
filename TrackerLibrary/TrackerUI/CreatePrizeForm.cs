using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Mdels;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValueTextBox.Text,
                    placeNumberValueTextBox.Text,
                    prizeAmountValueTextBox.Text,
                    prizePercentageValueTextBox.Text);

                foreach (IDataConnection db in GlobalConfig.connections)
                {
                    db.createPrize(model);
                }
                MessageBox.Show($"Created prize:\n \tPosition:{placeNameValueTextBox.Text}\n \tName:{placeNameValueTextBox.Text}\n \tAmount (if 0, considered price percentage):{prizeAmountValueTextBox.Text}\n \tPrice percentage:{prizePercentageValueTextBox.Text}%.");
                placeNameValueTextBox.Text = "";
                placeNumberValueTextBox.Text = "";
                prizeAmountValueTextBox.Text = 0.ToString();
                prizePercentageValueTextBox.Text = 0.ToString();
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool validateForm()
        {
            int placeNumber = 0;
            double prizePercentage = 0;
            decimal prizeAmount = 0;

            bool output = true;
            bool placeNumberValidNumber = int.TryParse(placeNumberValueTextBox.Text, out placeNumber);
            bool prizeAmountValid = decimal.TryParse(prizeAmountValueTextBox.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValueTextBox.Text, out prizePercentage);

            output = !placeNumberValidNumber ? output = false : output; // if placeNumberValidNumber is false, then output = false, else output = output
            output = placeNumber < 1 ? output = false : output; // if placeNumber is less than 1, then output = false, else output = output
            output = placeNameValueTextBox.Text.Length == 0 ? output = false : output; // if placeNameValueTextBox is empty, then output = false, else output = output

            output = (!prizeAmountValid || !prizePercentageValid) || (prizeAmount <= 0 && prizePercentage <= 0) || ((prizePercentage < 0 || prizePercentage > 100)) ? output = false : output; //If prizeAmountValid or prizePercentageValid is false, or if prizeAmount is less than or equal to 0 and prizePercentage is less than or equal to 0, or if prizePercentage is less than 0 or greater than 100, then output = false, else output = output

            return output;
        }
    }
}
