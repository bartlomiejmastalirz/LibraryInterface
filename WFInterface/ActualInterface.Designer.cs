namespace WFInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualInterface));
            dataGridView1 = new DataGridView();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            panel1 = new Panel();
            btnAdminPanel = new Button();
            btnLogout = new Button();
            btnMyProfil = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            newItems = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(229, 222, 207);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(308, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(613, 461);
            dataGridView1.TabIndex = 0;
            // 
            // TxtSearch
            // 
            TxtSearch.BackColor = Color.SeaShell;
            TxtSearch.BorderStyle = BorderStyle.None;
            TxtSearch.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtSearch.ForeColor = Color.DarkGray;
            TxtSearch.Location = new Point(308, 130);
            TxtSearch.Multiline = true;
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(550, 44);
            TxtSearch.TabIndex = 1;
            TxtSearch.Text = "Search resources";
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            TxtSearch.Enter += TxtSearch_Enter;
            TxtSearch.Leave += TxtSearch_Leave;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.None;
            BtnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnSearch.BackColor = Color.Silver;
            BtnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearch.FlatAppearance.BorderSize = 0;
            BtnSearch.FlatStyle = FlatStyle.Flat;
            BtnSearch.ForeColor = Color.Black;
            BtnSearch.Image = (Image)resources.GetObject("BtnSearch.Image");
            BtnSearch.Location = new Point(864, 130);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(57, 67);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 189, 165);
            panel1.Controls.Add(btnAdminPanel);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnMyProfil);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 101);
            panel1.TabIndex = 3;
            // 
            // btnAdminPanel
            // 
            btnAdminPanel.BackColor = Color.DimGray;
            btnAdminPanel.FlatAppearance.BorderSize = 0;
            btnAdminPanel.FlatStyle = FlatStyle.Flat;
            btnAdminPanel.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnAdminPanel.ForeColor = Color.White;
            btnAdminPanel.Location = new Point(593, 27);
            btnAdminPanel.Name = "btnAdminPanel";
            btnAdminPanel.Size = new Size(130, 48);
            btnAdminPanel.TabIndex = 7;
            btnAdminPanel.Text = "Admin";
            btnAdminPanel.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DimGray;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(865, 27);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 48);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnlogout_Click;
            // 
            // btnMyProfil
            // 
            btnMyProfil.BackColor = Color.DimGray;
            btnMyProfil.FlatAppearance.BorderSize = 0;
            btnMyProfil.FlatStyle = FlatStyle.Flat;
            btnMyProfil.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnMyProfil.ForeColor = Color.White;
            btnMyProfil.Location = new Point(729, 27);
            btnMyProfil.Name = "btnMyProfil";
            btnMyProfil.Size = new Size(130, 48);
            btnMyProfil.TabIndex = 5;
            btnMyProfil.Text = "My profil";
            btnMyProfil.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.noun_library_71245;
            pictureBox1.Location = new Point(13, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(308, 184);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 13);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(246, 238, 227);
            panel3.Location = new Point(5, 711);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(32, 33);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(238, 231, 215);
            panel4.Location = new Point(44, 711);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(32, 33);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(229, 222, 207);
            panel5.Location = new Point(82, 711);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(32, 33);
            panel5.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(229, 203, 186);
            panel6.Location = new Point(121, 711);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(32, 33);
            panel6.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(217, 189, 165);
            panel7.Location = new Point(160, 711);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(32, 33);
            panel7.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 687);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 9;
            label1.Text = "Nie usuwać, przybornik";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(229, 222, 207);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(31, 175);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(247, 513);
            dataGridView2.TabIndex = 10;
            // 
            // newItems
            // 
            newItems.AutoSize = true;
            newItems.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            newItems.Location = new Point(31, 130);
            newItems.Name = "newItems";
            newItems.Size = new Size(148, 37);
            newItems.TabIndex = 11;
            newItems.Text = "New Items";
            // 
            // ActualInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.SeaShell;
            ClientSize = new Size(984, 748);
            ControlBox = false;
            Controls.Add(newItems);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(BtnSearch);
            Controls.Add(TxtSearch);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ActualInterface";
            Text = "Nameless Library";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox TxtSearch;
        private Button BtnSearch;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private Button btnMyProfil;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label label1;
        private Button btnAdminPanel;
        private DataGridView dataGridView2;
        private Label newItems;
    }
}