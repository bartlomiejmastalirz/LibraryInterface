namespace WFInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            LoginButton = new Button();
            ExitLabel = new Label();
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            registerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.noun_library_71245;
            pictureBox1.Location = new Point(128, 72);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(217, 189, 165);
            label1.Location = new Point(38, 171);
            label1.MinimumSize = new Size(126, 53);
            label1.Name = "label1";
            label1.Size = new Size(290, 53);
            label1.TabIndex = 1;
            label1.Text = "NAMELESS LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 203, 186);
            panel1.Location = new Point(19, 288);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 10);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(229, 203, 186);
            panel2.Location = new Point(19, 403);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 10);
            panel2.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(217, 189, 165);
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LoginButton.ForeColor = Color.FromArgb(246, 238, 227);
            LoginButton.Location = new Point(25, 483);
            LoginButton.Margin = new Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(303, 43);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Log in";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ExitLabel.ForeColor = Color.FromArgb(217, 189, 165);
            ExitLabel.Location = new Point(156, 590);
            ExitLabel.Name = "ExitLabel";
            ExitLabel.Size = new Size(37, 20);
            ExitLabel.TabIndex = 5;
            ExitLabel.Text = "Exit";
            ExitLabel.Click += ExitLabel_Click;
            // 
            // TxtUsername
            // 
            TxtUsername.BackColor = Color.FromArgb(238, 231, 215);
            TxtUsername.BorderStyle = BorderStyle.None;
            TxtUsername.Font = new Font("Calibri", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtUsername.ForeColor = Color.DarkGray;
            TxtUsername.Location = new Point(75, 241);
            TxtUsername.Margin = new Padding(3, 4, 3, 4);
            TxtUsername.Multiline = true;
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(242, 37);
            TxtUsername.TabIndex = 6;
            TxtUsername.Text = "Login";
            TxtUsername.Enter += TxtUsername_Enter;
            TxtUsername.Leave += TxtUsername_Leave;
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.FromArgb(238, 231, 215);
            TxtPassword.BorderStyle = BorderStyle.None;
            TxtPassword.Font = new Font("Calibri", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtPassword.ForeColor = Color.DarkGray;
            TxtPassword.Location = new Point(75, 356);
            TxtPassword.Margin = new Padding(3, 4, 3, 4);
            TxtPassword.Multiline = true;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(242, 41);
            TxtPassword.TabIndex = 6;
            TxtPassword.Text = "Password";
            TxtPassword.Enter += TxtPassword_Enter;
            TxtPassword.Leave += TxtPassword_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_padlock_24;
            pictureBox2.Location = new Point(23, 356);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_user_35;
            pictureBox3.Location = new Point(23, 241);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 238);
            registerLabel.ForeColor = Color.FromArgb(217, 189, 165);
            registerLabel.Location = new Point(100, 550);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(155, 20);
            registerLabel.TabIndex = 9;
            registerLabel.Text = "New to the Library?";
            registerLabel.Click += registerLabel_Click;
            // 
            // Form1
            // 
            AcceptButton = LoginButton;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(238, 231, 215);
            ClientSize = new Size(352, 648);
            Controls.Add(registerLabel);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Controls.Add(ExitLabel);
            Controls.Add(LoginButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nameless Library";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button LoginButton;
        private Label ExitLabel;

        public TextBox TxtUsername;
        private TextBox TxtPassword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label registerLabel;
    }
}
