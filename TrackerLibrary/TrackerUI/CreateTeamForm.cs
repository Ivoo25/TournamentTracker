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
        private List<PersonModel> availableTeamMembers = GlobalConfig.connections.getPerson_All();
        private List<PersonModel> selectedTeamMember = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();
            //createSampleData();
            wireUpLists();
        }

        private void wireUpLists()
        {

            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "fullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMember;
            teamMembersListBox.DisplayMember = "fullName";
        }


        /*
        private void createSampleData()
        {
            availableTeamMembers.Add(new PersonModel { firstName = "Tim", lastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { firstName = "Sue", lastName = "Storm" });

            selectedTeamMember.Add(new PersonModel { firstName = "Jane", lastName = "Smith" });
            selectedTeamMember.Add(new PersonModel { firstName = "Bill", lastName = "Jones" });
        }
        */

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                PersonModel p = new PersonModel();
                p.firstName = firstNameValueTextBox.Text;
                p.lastName = lastNameValueTextBox.Text;
                p.emailAddress = emailValueTextBox.Text;
                p.cellphoneNumber = cellphoneValueTextBox.Text;

                p = GlobalConfig.connections.createPerson(p);
                selectedTeamMember.Add(p);
                wireUpLists();
                // After creating a person, add it to the list of selected team members

                MessageBox.Show($"Created person:\n \tFirst name: {firstNameValueTextBox.Text}\n \tLast name: {lastNameValueTextBox.Text}\n \tEmail address: {emailValueTextBox.Text}\n \tCellphone number: {cellphoneValueTextBox.Text}.");
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

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMember.Add(p);
                wireUpLists();
            }
        }

        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;
            if (p != null)
            {
                selectedTeamMember.Remove(p);
                availableTeamMembers.Add(p);
                wireUpLists();
            }
        }
    }
}
