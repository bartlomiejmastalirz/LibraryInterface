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
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(259, 94);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(496, 278);
            dataGridView1.TabIndex = 0;
            // 
            // TxtSearch
            // 
            TxtSearch.BorderStyle = BorderStyle.None;
            TxtSearch.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtSearch.ForeColor = Color.DarkGray;
            TxtSearch.Location = new Point(259, 46);
            TxtSearch.Margin = new Padding(3, 2, 3, 2);
            TxtSearch.Multiline = true;
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(438, 33);
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
            BtnSearch.Location = new Point(705, 39);
            BtnSearch.Margin = new Padding(3, 2, 3, 2);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(50, 50);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btnNotif);
            panel1.Controls.Add(btnRenewable);
            panel1.Controls.Add(btnRequested);
            panel1.Controls.Add(btnBorrowed);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 458);
            panel1.TabIndex = 3;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.DimGray;
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnlogout.ForeColor = Color.White;
            btnlogout.Location = new Point(52, 338);
            btnlogout.Margin = new Padding(3, 2, 3, 2);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(129, 36);
            btnlogout.TabIndex = 6;
            btnlogout.Text = "Log out";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnNotif
            // 
            btnNotif.BackColor = Color.DimGray;
            btnNotif.FlatAppearance.BorderSize = 0;
            btnNotif.FlatStyle = FlatStyle.Flat;
            btnNotif.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnNotif.ForeColor = Color.White;
            btnNotif.Location = new Point(29, 284);
            btnNotif.Margin = new Padding(3, 2, 3, 2);
            btnNotif.Name = "btnNotif";
            btnNotif.Size = new Size(172, 36);
            btnNotif.TabIndex = 5;
            btnNotif.Text = "Notifications";
            btnNotif.UseVisualStyleBackColor = false;
            // 
            // btnRenewable
            // 
            btnRenewable.BackColor = Color.DimGray;
            btnRenewable.FlatAppearance.BorderSize = 0;
            btnRenewable.FlatStyle = FlatStyle.Flat;
            btnRenewable.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnRenewable.ForeColor = Color.White;
            btnRenewable.Location = new Point(29, 229);
            btnRenewable.Margin = new Padding(3, 2, 3, 2);
            btnRenewable.Name = "btnRenewable";
            btnRenewable.Size = new Size(172, 36);
            btnRenewable.TabIndex = 4;
            btnRenewable.Text = "Renewable items";
            btnRenewable.UseVisualStyleBackColor = false;
            // 
            // btnRequested
            // 
            btnRequested.BackColor = Color.DimGray;
            btnRequested.FlatAppearance.BorderSize = 0;
            btnRequested.FlatStyle = FlatStyle.Flat;
            btnRequested.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnRequested.ForeColor = Color.White;
            btnRequested.Location = new Point(29, 170);
            btnRequested.Margin = new Padding(3, 2, 3, 2);
            btnRequested.Name = "btnRequested";
            btnRequested.Size = new Size(172, 36);
            btnRequested.TabIndex = 3;
            btnRequested.Text = "Requested items";
            btnRequested.UseVisualStyleBackColor = false;
            // 
            // btnBorrowed
            // 
            btnBorrowed.BackColor = Color.DimGray;
            btnBorrowed.FlatAppearance.BorderSize = 0;
            btnBorrowed.FlatStyle = FlatStyle.Flat;
            btnBorrowed.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnBorrowed.ForeColor = Color.White;
            btnBorrowed.Location = new Point(29, 112);
            btnBorrowed.Margin = new Padding(3, 2, 3, 2);
            btnBorrowed.Name = "btnBorrowed";
            btnBorrowed.Size = new Size(172, 36);
            btnBorrowed.TabIndex = 2;
            btnBorrowed.Text = "Borrowed items";
            btnBorrowed.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.noun_library_71245;
            pictureBox1.Location = new Point(74, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(259, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(441, 10);
            panel2.TabIndex = 4;
            // 
            // ActualInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(BtnSearch);
            Controls.Add(TxtSearch);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ActualInterface";
            Text = "Nameless Library";
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
        private Panel panel2;
    }
}