namespace TrackerUI
{
    partial class CreateTeamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            teamNameValueTextBox = new System.Windows.Forms.TextBox();
            teamNameLabel = new System.Windows.Forms.Label();
            headerLabel = new System.Windows.Forms.Label();
            addMemberButton = new System.Windows.Forms.Button();
            selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            selectTeamMemberLabel = new System.Windows.Forms.Label();
            addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            createMemberButton = new System.Windows.Forms.Button();
            cellphoneValueTextBox = new System.Windows.Forms.TextBox();
            cellphoneLabel = new System.Windows.Forms.Label();
            emailValueTextBox = new System.Windows.Forms.TextBox();
            emailLabel = new System.Windows.Forms.Label();
            lastNameValueTextBox = new System.Windows.Forms.TextBox();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameValueTextBox = new System.Windows.Forms.TextBox();
            firstNameLabel = new System.Windows.Forms.Label();
            teamMembersListBox = new System.Windows.Forms.ListBox();
            removeSelectedPrizeButton = new System.Windows.Forms.Button();
            createTeamButton = new System.Windows.Forms.Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValueTextBox
            // 
            teamNameValueTextBox.Location = new System.Drawing.Point(12, 119);
            teamNameValueTextBox.Name = "teamNameValueTextBox";
            teamNameValueTextBox.Size = new System.Drawing.Size(347, 43);
            teamNameValueTextBox.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            teamNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            teamNameLabel.Location = new System.Drawing.Point(12, 72);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new System.Drawing.Size(187, 44);
            teamNameLabel.TabIndex = 12;
            teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            headerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            headerLabel.Location = new System.Drawing.Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new System.Drawing.Size(268, 63);
            headerLabel.TabIndex = 11;
            headerLabel.Text = "Create Team";
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addMemberButton.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            addMemberButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            addMemberButton.Location = new System.Drawing.Point(378, 219);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new System.Drawing.Size(249, 61);
            addMemberButton.TabIndex = 19;
            addMemberButton.Text = "Add member";
            addMemberButton.UseVisualStyleBackColor = true;
            addMemberButton.Click += addMemberButton_Click;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new System.Drawing.Point(378, 119);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new System.Drawing.Size(318, 44);
            selectTeamMemberDropDown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            selectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            selectTeamMemberLabel.Location = new System.Drawing.Point(378, 72);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new System.Drawing.Size(318, 44);
            selectTeamMemberLabel.TabIndex = 17;
            selectTeamMemberLabel.Text = "Select team member";
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(cellphoneValueTextBox);
            addNewMemberGroupBox.Controls.Add(cellphoneLabel);
            addNewMemberGroupBox.Controls.Add(emailValueTextBox);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValueTextBox);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValueTextBox);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            addNewMemberGroupBox.ForeColor = System.Drawing.SystemColors.Highlight;
            addNewMemberGroupBox.Location = new System.Drawing.Point(378, 286);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new System.Drawing.Size(572, 435);
            addNewMemberGroupBox.TabIndex = 20;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add new member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            createMemberButton.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            createMemberButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            createMemberButton.Location = new System.Drawing.Point(162, 368);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new System.Drawing.Size(249, 61);
            createMemberButton.TabIndex = 20;
            createMemberButton.Text = "Create member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // cellphoneValueTextBox
            // 
            cellphoneValueTextBox.Location = new System.Drawing.Point(181, 280);
            cellphoneValueTextBox.Name = "cellphoneValueTextBox";
            cellphoneValueTextBox.Size = new System.Drawing.Size(340, 51);
            cellphoneValueTextBox.TabIndex = 16;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cellphoneLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            cellphoneLabel.Location = new System.Drawing.Point(6, 287);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new System.Drawing.Size(166, 44);
            cellphoneLabel.TabIndex = 15;
            cellphoneLabel.Text = "Cellphone";
            // 
            // emailValueTextBox
            // 
            emailValueTextBox.Location = new System.Drawing.Point(181, 205);
            emailValueTextBox.Name = "emailValueTextBox";
            emailValueTextBox.Size = new System.Drawing.Size(340, 51);
            emailValueTextBox.TabIndex = 14;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            emailLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            emailLabel.Location = new System.Drawing.Point(6, 212);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(95, 44);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // lastNameValueTextBox
            // 
            lastNameValueTextBox.Location = new System.Drawing.Point(181, 130);
            lastNameValueTextBox.Name = "lastNameValueTextBox";
            lastNameValueTextBox.Size = new System.Drawing.Size(340, 51);
            lastNameValueTextBox.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lastNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            lastNameLabel.Location = new System.Drawing.Point(6, 137);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(164, 44);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last name";
            // 
            // firstNameValueTextBox
            // 
            firstNameValueTextBox.Location = new System.Drawing.Point(181, 55);
            firstNameValueTextBox.Name = "firstNameValueTextBox";
            firstNameValueTextBox.Size = new System.Drawing.Size(340, 51);
            firstNameValueTextBox.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            firstNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            firstNameLabel.Location = new System.Drawing.Point(6, 62);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(169, 44);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First name";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 36;
            teamMembersListBox.Location = new System.Drawing.Point(12, 178);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new System.Drawing.Size(347, 470);
            teamMembersListBox.TabIndex = 21;
            // 
            // removeSelectedPrizeButton
            // 
            removeSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            removeSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            removeSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            removeSelectedPrizeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            removeSelectedPrizeButton.Location = new System.Drawing.Point(52, 654);
            removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            removeSelectedPrizeButton.Size = new System.Drawing.Size(267, 61);
            removeSelectedPrizeButton.TabIndex = 24;
            removeSelectedPrizeButton.Text = "Remove selected";
            removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            removeSelectedPrizeButton.Click += removeSelectedPrizeButton_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            createTeamButton.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            createTeamButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            createTeamButton.Location = new System.Drawing.Point(739, 9);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new System.Drawing.Size(211, 63);
            createTeamButton.TabIndex = 25;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTeamButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 36F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(962, 733);
            Controls.Add(createTeamButton);
            Controls.Add(removeSelectedPrizeButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValueTextBox);
            Controls.Add(teamNameLabel);
            Controls.Add(headerLabel);
            Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValueTextBox;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox addNewMemberGroupBox;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox cellphoneValueTextBox;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.TextBox emailValueTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValueTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValueTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button removeSelectedPrizeButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}