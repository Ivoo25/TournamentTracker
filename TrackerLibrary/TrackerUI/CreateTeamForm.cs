using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Mdels;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                PersonModel p = new PersonModel();
                p.firstName = firstNameValueTextBox.Text;
                p.lastName = lastNameValueTextBox.Text;
                p.emailAddress = emailValueTextBox.Text;
                p.cellphoneNumber = cellphoneValueTextBox.Text;

                GlobalConfig.connections.createPerson(p);

                MessageBox.Show($"Created person:\n \tFirst name: {firstNameValueTextBox.Text}\n \tLast name: {lastNameValueTextBox.Text}\n \tEmail address: {emailValueTextBox.Text}\n \tCellphone number: {cellphoneValueTextBox.Text}%.");
                firstNameValueTextBox.Text = "";
                lastNameValueTextBox.Text = "";
                emailValueTextBox.Text = "";
                cellphoneValueTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }

        }

        private bool validateForm()
        {
            if (firstNameValueTextBox.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValueTextBox.Text.Length == 0)
            {
                return false;
            }
            if (emailValueTextBox.Text.Length == 0)
            {
                return false;
            }
            if (cellphoneValueTextBox.Text.Length == 0)
            {
                return false;
            }
            try
            {
                MailAddress m = new MailAddress(emailValueTextBox.Text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }

        }
    }
}
