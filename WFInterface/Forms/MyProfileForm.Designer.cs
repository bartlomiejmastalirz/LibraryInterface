namespace WFInterface
{
    partial class MyProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DataGridView rentedBooksGridView;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Button btnGoBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUsername = new Label();
            rentedBooksGridView = new DataGridView();
            lblName = new Label();
            lblSurname = new Label();
            lblLogin = new Label();
            lblBooks = new Label();
            btnGoBack = new Button();
            panel1 = new Panel();
            labelNameless = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)rentedBooksGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblUsername.Location = new Point(18, 187);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(112, 26);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Your details";
            // 
            // rentedBooksGridView
            // 
            rentedBooksGridView.BackgroundColor = Color.FromArgb(238, 231, 215);
            rentedBooksGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rentedBooksGridView.Location = new Point(309, 225);
            rentedBooksGridView.Margin = new Padding(4, 3, 4, 3);
            rentedBooksGridView.Name = "rentedBooksGridView";
            rentedBooksGridView.RowHeadersWidth = 51;
            rentedBooksGridView.Size = new Size(613, 461);
            rentedBooksGridView.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblName.Location = new Point(18, 281);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 26);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblSurname.Location = new Point(18, 331);
            lblSurname.Margin = new Padding(4, 0, 4, 0);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(88, 26);
            lblSurname.TabIndex = 3;
            lblSurname.Text = "Surname";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblLogin.Location = new Point(18, 231);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(58, 26);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Login";
            // 
            // lblBooks
            // 
            lblBooks.AutoSize = true;
            lblBooks.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblBooks.Location = new Point(309, 187);
            lblBooks.Margin = new Padding(4, 0, 4, 0);
            lblBooks.Name = "lblBooks";
            lblBooks.Size = new Size(170, 26);
            lblBooks.TabIndex = 5;
            lblBooks.Text = "Your Rented Books";
            // 
            // btnGoBack
            // 
            btnGoBack.BackColor = Color.FromArgb(217, 189, 165);
            btnGoBack.FlatAppearance.BorderSize = 0;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnGoBack.ForeColor = Color.FromArgb(246, 238, 227);
            btnGoBack.Location = new Point(816, 24);
            btnGoBack.Margin = new Padding(4, 3, 4, 3);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(154, 48);
            btnGoBack.TabIndex = 6;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 203, 186);
            panel1.Controls.Add(labelNameless);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 101);
            panel1.TabIndex = 7;
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(229, 203, 186);
            panel2.Location = new Point(18, 261);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 10);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(229, 203, 186);
            panel3.Location = new Point(18, 311);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 10);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(229, 203, 186);
            panel4.Location = new Point(18, 361);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(273, 10);
            panel4.TabIndex = 10;
            // 
            // MyProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 238, 227);
            ClientSize = new Size(1000, 787);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnGoBack);
            Controls.Add(lblBooks);
            Controls.Add(lblLogin);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Controls.Add(rentedBooksGridView);
            Controls.Add(lblUsername);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MyProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyProfileForm";
            Load += MyProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)rentedBooksGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void MyProfileForm_Load(object sender, EventArgs e)
        {
            ApplyDataGridViewStyle(); // Change method name here
        }

        private Panel panel1;
        private Label labelNameless;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}
