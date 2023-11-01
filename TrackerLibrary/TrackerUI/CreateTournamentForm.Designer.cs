namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            headerLabel = new System.Windows.Forms.Label();
            tournamentNameValueTextBox = new System.Windows.Forms.TextBox();
            tournamentNameLabel = new System.Windows.Forms.Label();
            entryFeeValueTextBox = new System.Windows.Forms.TextBox();
            entryFeeLabel = new System.Windows.Forms.Label();
            selectTeamDropDown = new System.Windows.Forms.ComboBox();
            selectTeamLabel = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            deleteSelectedPlayersButton = new System.Windows.Forms.Button();
            deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            prizesLabel = new System.Windows.Forms.Label();
            prizesListBox = new System.Windows.Forms.ListBox();
            createTournamentButton = new System.Windows.Forms.Button();
            addTeamButton = new System.Windows.Forms.Button();
            createPrizeButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            headerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            headerLabel.Location = new System.Drawing.Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new System.Drawing.Size(394, 63);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameValueTextBox
            // 
            tournamentNameValueTextBox.Location = new System.Drawing.Point(12, 119);
            tournamentNameValueTextBox.Name = "tournamentNameValueTextBox";
            tournamentNameValueTextBox.Size = new System.Drawing.Size(394, 43);
            tournamentNameValueTextBox.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            tournamentNameLabel.Location = new System.Drawing.Point(12, 72);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new System.Drawing.Size(284, 44);
            tournamentNameLabel.TabIndex = 9;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValueTextBox
            // 
            entryFeeValueTextBox.Location = new System.Drawing.Point(168, 163);
            entryFeeValueTextBox.Name = "entryFeeValueTextBox";
            entryFeeValueTextBox.Size = new System.Drawing.Size(238, 43);
            entryFeeValueTextBox.TabIndex = 12;
            entryFeeValueTextBox.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            entryFeeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            entryFeeLabel.Location = new System.Drawing.Point(12, 162);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new System.Drawing.Size(146, 44);
            entryFeeLabel.TabIndex = 11;
            entryFeeLabel.Text = "Entry fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new System.Drawing.Point(12, 458);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new System.Drawing.Size(394, 44);
            selectTeamDropDown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            selectTeamLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            selectTeamLabel.Location = new System.Drawing.Point(12, 410);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new System.Drawing.Size(189, 44);
            selectTeamLabel.TabIndex = 13;
            selectTeamLabel.Text = "Select team";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            linkLabel1.LinkColor = System.Drawing.SystemColors.Highlight;
            linkLabel1.Location = new System.Drawing.Point(253, 427);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(106, 27);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "create new";
            linkLabel1.VisitedLinkColor = System.Drawing.Color.DarkRed;
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.ItemHeight = 36;
            tournamentTeamsListBox.Location = new System.Drawing.Point(489, 119);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new System.Drawing.Size(349, 182);
            tournamentTeamsListBox.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.Highlight;
            label1.Location = new System.Drawing.Point(489, 72);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(234, 44);
            label1.TabIndex = 19;
            label1.Text = "Teams/ Players";
            // 
            // deleteSelectedPlayersButton
            // 
            deleteSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            deleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            deleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            deleteSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            deleteSelectedPlayersButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            deleteSelectedPlayersButton.Location = new System.Drawing.Point(571, 307);
            deleteSelectedPlayersButton.Name = "deleteSelectedPlayersButton";
            deleteSelectedPlayersButton.Size = new System.Drawing.Size(267, 61);
            deleteSelectedPlayersButton.TabIndex = 20;
            deleteSelectedPlayersButton.Text = "Delete selected";
            deleteSelectedPlayersButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            deleteSelectedPrizeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            deleteSelectedPrizeButton.Location = new System.Drawing.Point(571, 646);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new System.Drawing.Size(267, 61);
            deleteSelectedPrizeButton.TabIndex = 23;
            deleteSelectedPrizeButton.Text = "Delete selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            prizesLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            prizesLabel.Location = new System.Drawing.Point(489, 410);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new System.Drawing.Size(103, 44);
            prizesLabel.TabIndex = 22;
            prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 36;
            prizesListBox.Location = new System.Drawing.Point(489, 458);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new System.Drawing.Size(349, 182);
            prizesListBox.TabIndex = 21;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            createTournamentButton.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            createTournamentButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            createTournamentButton.Location = new System.Drawing.Point(588, 9);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new System.Drawing.Size(362, 63);
            createTournamentButton.TabIndex = 24;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addTeamButton.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            addTeamButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            addTeamButton.Location = new System.Drawing.Point(117, 507);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new System.Drawing.Size(185, 61);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            createPrizeButton.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            createPrizeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            createPrizeButton.Location = new System.Drawing.Point(117, 573);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new System.Drawing.Size(185, 61);
            createPrizeButton.TabIndex = 17;
            createPrizeButton.Text = "Create prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 36F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(962, 733);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(deleteSelectedPlayersButton);
            Controls.Add(label1);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(linkLabel1);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValueTextBox);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValueTextBox);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox tournamentNameValueTextBox;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeValueTextBox;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListBox tournamentTeamsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteSelectedPlayersButton;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
    }
}