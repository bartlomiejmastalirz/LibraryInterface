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
            btnlogout = new Button();
            btnNotif = new Button();
            btnRenewable = new Button();
            btnRequested = new Button();
            btnBorrowed = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(296, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(567, 370);
            dataGridView1.TabIndex = 0;
            // 
            // TxtSearch
            // 
            TxtSearch.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtSearch.ForeColor = Color.DarkGray;
            TxtSearch.Location = new Point(296, 60);
            TxtSearch.Multiline = true;
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(500, 48);
            TxtSearch.TabIndex = 1;
            TxtSearch.Text = "Search resources";
            // 
            // BtnSearch
            // 
            BtnSearch.BackColor = Color.FromArgb(41, 128, 185);
            BtnSearch.FlatAppearance.BorderSize = 0;
            BtnSearch.FlatStyle = FlatStyle.Flat;
            BtnSearch.Image = (Image)resources.GetObject("BtnSearch.Image");
            BtnSearch.Location = new Point(816, 60);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(47, 49);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btnNotif);
            panel1.Controls.Add(btnRenewable);
            panel1.Controls.Add(btnRequested);
            panel1.Controls.Add(btnBorrowed);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 610);
            panel1.TabIndex = 3;
            // 
            // btnlogout
            // 
            btnlogout.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnlogout.Location = new Point(59, 450);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(147, 48);
            btnlogout.TabIndex = 6;
            btnlogout.Text = "Log out";
            btnlogout.UseVisualStyleBackColor = true;
            // 
            // btnNotif
            // 
            btnNotif.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnNotif.Location = new Point(33, 378);
            btnNotif.Name = "btnNotif";
            btnNotif.Size = new Size(196, 48);
            btnNotif.TabIndex = 5;
            btnNotif.Text = "Notifications";
            btnNotif.UseVisualStyleBackColor = true;
            // 
            // btnRenewable
            // 
            btnRenewable.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnRenewable.Location = new Point(33, 305);
            btnRenewable.Name = "btnRenewable";
            btnRenewable.Size = new Size(196, 48);
            btnRenewable.TabIndex = 4;
            btnRenewable.Text = "Renewable items";
            btnRenewable.UseVisualStyleBackColor = true;
            // 
            // btnRequested
            // 
            btnRequested.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnRequested.Location = new Point(33, 226);
            btnRequested.Name = "btnRequested";
            btnRequested.Size = new Size(196, 48);
            btnRequested.TabIndex = 3;
            btnRequested.Text = "Requested items";
            btnRequested.UseVisualStyleBackColor = true;
            // 
            // btnBorrowed
            // 
            btnBorrowed.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnBorrowed.Location = new Point(33, 150);
            btnBorrowed.Name = "btnBorrowed";
            btnBorrowed.Size = new Size(196, 48);
            btnBorrowed.TabIndex = 2;
            btnBorrowed.Text = "Borrowed items";
            btnBorrowed.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.noun_library_71245;
            pictureBox1.Location = new Point(85, 27);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ActualInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(BtnSearch);
            Controls.Add(TxtSearch);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ActualInterface";
            Text = "ActualInterface";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox TxtSearch;
        private Button BtnSearch;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnBorrowed;
        private Button btnlogout;
        private Button btnNotif;
        private Button btnRenewable;
        private Button btnRequested;
    }
}