﻿namespace WFInterface
{
    partial class ActualInterface
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
            bookListView = new DataGridView();
            TxtSearch = new TextBox();
            panel1 = new Panel();
            labelNameless = new Label();
            pictureBox1 = new PictureBox();
            welcomeLabel = new Label();
            lblUsername = new Label();
            btnAdminPanel = new Button();
            btnLogout = new Button();
            btnMyProfile = new Button();
            panel2 = new Panel();
            newsListView = new DataGridView();
            newItems = new Label();
            btnToggleView = new Button();
            ((System.ComponentModel.ISupportInitialize)bookListView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newsListView).BeginInit();
            SuspendLayout();
            // 
            // bookListView
            // 
            bookListView.BackgroundColor = Color.FromArgb(238, 231, 215);
            bookListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookListView.Location = new Point(309, 225);
            bookListView.Name = "bookListView";
            bookListView.RowHeadersWidth = 51;
            bookListView.Size = new Size(613, 461);
            bookListView.TabIndex = 0;
            // 
            // TxtSearch
            // 
            TxtSearch.BackColor = Color.FromArgb(246, 238, 227);
            TxtSearch.BorderStyle = BorderStyle.None;
            TxtSearch.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtSearch.ForeColor = Color.DarkGray;
            TxtSearch.Location = new Point(309, 159);
            TxtSearch.Multiline = true;
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(613, 44);
            TxtSearch.TabIndex = 1;
            TxtSearch.Text = "Search for books...";
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            TxtSearch.Enter += TxtSearch_Enter;
            TxtSearch.Leave += TxtSearch_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 203, 186);
            panel1.Controls.Add(labelNameless);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 101);
            panel1.TabIndex = 3;
            // 
            // labelNameless
            // 
            labelNameless.AutoSize = true;
            labelNameless.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelNameless.Location = new Point(96, 27);
            labelNameless.Name = "labelNameless";
            labelNameless.Size = new Size(259, 39);
            labelNameless.TabIndex = 2;
            labelNameless.Text = "NAMELESS Library";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.noun_library_71245;
            pictureBox1.Location = new Point(15, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            welcomeLabel.Location = new Point(31, 149);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(140, 19);
            welcomeLabel.TabIndex = 9;
            welcomeLabel.Text = "You are logged in as";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblUsername.Location = new Point(31, 184);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(39, 19);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "User";
            // 
            // btnAdminPanel
            // 
            btnAdminPanel.BackColor = Color.FromArgb(217, 189, 165);
            btnAdminPanel.FlatAppearance.BorderSize = 0;
            btnAdminPanel.FlatStyle = FlatStyle.Flat;
            btnAdminPanel.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnAdminPanel.ForeColor = Color.FromArgb(246, 238, 227);
            btnAdminPanel.Location = new Point(679, 24);
            btnAdminPanel.Name = "btnAdminPanel";
            btnAdminPanel.Size = new Size(130, 48);
            btnAdminPanel.TabIndex = 7;
            btnAdminPanel.Text = "Admin";
            btnAdminPanel.UseVisualStyleBackColor = false;
            btnAdminPanel.Click += btnAdminPanel_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(217, 189, 165);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnLogout.ForeColor = Color.FromArgb(246, 238, 227);
            btnLogout.Location = new Point(31, 225);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(247, 48);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnMyProfile
            // 
            btnMyProfile.BackColor = Color.FromArgb(217, 189, 165);
            btnMyProfile.FlatAppearance.BorderSize = 0;
            btnMyProfile.FlatStyle = FlatStyle.Flat;
            btnMyProfile.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnMyProfile.ForeColor = Color.FromArgb(246, 238, 227);
            btnMyProfile.Location = new Point(816, 24);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(154, 48);
            btnMyProfile.TabIndex = 5;
            btnMyProfile.Text = "My profile";
            btnMyProfile.UseVisualStyleBackColor = false;
            btnMyProfile.Click += btnMyProfile_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(229, 203, 186);
            panel2.Location = new Point(309, 200);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(613, 16);
            panel2.TabIndex = 4;
            // 
            // newsListView
            // 
            newsListView.BackgroundColor = Color.FromArgb(238, 231, 215);
            newsListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            newsListView.Location = new Point(31, 357);
            newsListView.Name = "newsListView";
            newsListView.RowHeadersWidth = 51;
            newsListView.Size = new Size(247, 329);
            newsListView.TabIndex = 10;
            // 
            // newItems
            // 
            newItems.AutoSize = true;
            newItems.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            newItems.Location = new Point(31, 300);
            newItems.Name = "newItems";
            newItems.Size = new Size(117, 29);
            newItems.TabIndex = 11;
            newItems.Text = "New Items";
            // 
            // btnToggleView
            // 
            btnToggleView.BackColor = Color.FromArgb(217, 189, 165);
            btnToggleView.FlatAppearance.BorderSize = 0;
            btnToggleView.FlatStyle = FlatStyle.Flat;
            btnToggleView.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnToggleView.ForeColor = Color.FromArgb(246, 238, 227);
            btnToggleView.Location = new Point(309, 114);
            btnToggleView.Name = "btnToggleView";
            btnToggleView.Size = new Size(613, 38);
            btnToggleView.TabIndex = 12;
            btnToggleView.Text = "Toggle between Books and Audiobooks";
            btnToggleView.UseVisualStyleBackColor = false;
            btnToggleView.Click += btnToggleView_Click;
            // 
            // ActualInterface
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(246, 238, 227);
            ClientSize = new Size(984, 748);
            ControlBox = false;
            Controls.Add(btnToggleView);
            Controls.Add(lblUsername);
            Controls.Add(welcomeLabel);
            Controls.Add(newItems);
            Controls.Add(newsListView);
            Controls.Add(btnAdminPanel);
            Controls.Add(btnMyProfile);
            Controls.Add(btnLogout);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(TxtSearch);
            Controls.Add(bookListView);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ActualInterface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nameless Library";
            Load += ActualInterface_Load;
            ((System.ComponentModel.ISupportInitialize)bookListView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)newsListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView bookListView;
        private TextBox TxtSearch;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private Button btnMyProfile;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label label1;
        private Button btnAdminPanel;
        private DataGridView newsListView;
        private Label newItems;
        private Label lblUsername;
        private Label welcomeLabel;
        private Label labelNameless;
        private Button btnToggleView;
    }
}