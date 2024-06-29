namespace WFInterface.Forms
{
    partial class RegisterFormcs
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
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            TxtPassword = new TextBox();
            TxtUsername = new TextBox();
            LoginButton = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            txtConfirmPassword = new TextBox();
            panel3 = new Panel();
            txtName = new TextBox();
            panel4 = new Panel();
            txtSurname = new TextBox();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            lblExit = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_user_35;
            pictureBox3.Location = new Point(30, 169);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_padlock_24;
            pictureBox2.Location = new Point(30, 234);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.FromArgb(238, 231, 215);
            TxtPassword.BorderStyle = BorderStyle.None;
            TxtPassword.Font = new Font("Calibri", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtPassword.ForeColor = Color.DarkGray;
            TxtPassword.Location = new Point(82, 234);
            TxtPassword.Margin = new Padding(3, 4, 3, 4);
            TxtPassword.Multiline = true;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(242, 41);
            TxtPassword.TabIndex = 14;
            TxtPassword.Text = "Password";
            TxtPassword.Enter += TxtPassword_Enter;
            TxtPassword.Leave += TxtPassword_Leave;
            // 
            // TxtUsername
            // 
            TxtUsername.BackColor = Color.FromArgb(238, 231, 215);
            TxtUsername.BorderStyle = BorderStyle.None;
            TxtUsername.Font = new Font("Calibri", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtUsername.ForeColor = Color.DarkGray;
            TxtUsername.Location = new Point(82, 169);
            TxtUsername.Margin = new Padding(3, 4, 3, 4);
            TxtUsername.Multiline = true;
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(242, 37);
            TxtUsername.TabIndex = 15;
            TxtUsername.Text = "Login";
            TxtUsername.Enter += TxtUsername_Enter;
            TxtUsername.Leave += TxtUsername_Leave;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(217, 189, 165);
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LoginButton.ForeColor = Color.FromArgb(246, 238, 227);
            LoginButton.Location = new Point(21, 544);
            LoginButton.Margin = new Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(303, 43);
            LoginButton.TabIndex = 13;
            LoginButton.Text = "Register";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(229, 203, 186);
            panel2.Location = new Point(26, 281);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 10);
            panel2.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 203, 186);
            panel1.Location = new Point(26, 216);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 10);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(217, 189, 165);
            label1.Location = new Point(3, 112);
            label1.MinimumSize = new Size(126, 53);
            label1.Name = "label1";
            label1.Size = new Size(346, 53);
            label1.TabIndex = 10;
            label1.Text = " NAMELESS REGISTER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.noun_library_71245;
            pictureBox1.Location = new Point(126, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_padlock_24;
            pictureBox4.Location = new Point(30, 299);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(238, 231, 215);
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Calibri", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtConfirmPassword.ForeColor = Color.DarkGray;
            txtConfirmPassword.Location = new Point(82, 299);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(242, 41);
            txtConfirmPassword.TabIndex = 19;
            txtConfirmPassword.Text = "Confirm Password";
            txtConfirmPassword.Enter += txtConfirmPassword_Enter;
            txtConfirmPassword.Leave += txtConfirmPassword_Leave;


            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(229, 203, 186);
            panel3.Location = new Point(26, 346);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(319, 10);
            panel3.TabIndex = 18;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(238, 231, 215);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Calibri", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtName.ForeColor = Color.DarkGray;
            txtName.Location = new Point(82, 395);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 41);
            txtName.TabIndex = 22;
            txtName.Tag = "z";
            txtName.Text = "Your Name";
            txtName.Enter += txtName_Enter;
            txtName.Leave += txtName_Leave;

            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(229, 203, 186);
            panel4.Location = new Point(26, 442);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(319, 10);
            panel4.TabIndex = 21;
            panel4.Tag = "z";
            // 
            // txtSurname
            // 
            txtSurname.BackColor = Color.FromArgb(238, 231, 215);
            txtSurname.BorderStyle = BorderStyle.None;
            txtSurname.Font = new Font("Calibri", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtSurname.ForeColor = Color.DarkGray;
            txtSurname.Location = new Point(82, 460);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Multiline = true;
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(242, 41);
            txtSurname.TabIndex = 25;
            txtSurname.Tag = "z";
            txtSurname.Text = "Your Surname";
            txtSurname.Enter += txtSurname_Enter;
            txtSurname.Leave += txtSurname_Leave;

            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(229, 203, 186);
            panel5.Location = new Point(26, 507);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(319, 10);
            panel5.TabIndex = 24;
            panel5.Tag = "z";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_user_35;
            pictureBox5.Location = new Point(30, 395);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(46, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.icons8_user_35;
            pictureBox6.Location = new Point(30, 461);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(46, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 27;
            pictureBox6.TabStop = false;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Location = new Point(153, 603);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(33, 20);
            lblExit.TabIndex = 28;
            lblExit.Text = "Exit";
            lblExit.Click += lblExit_Click;
            // 
            // RegisterFormcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 231, 215);
            ClientSize = new Size(352, 648);
            Controls.Add(lblExit);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(txtSurname);
            Controls.Add(panel5);
            Controls.Add(txtName);
            Controls.Add(panel4);
            Controls.Add(pictureBox4);
            Controls.Add(txtConfirmPassword);
            Controls.Add(panel3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Controls.Add(LoginButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "RegisterFormcs";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox TxtPassword;
        public TextBox TxtUsername;
        private Button LoginButton;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private TextBox txtConfirmPassword;
        private Panel panel3;
        private TextBox txtName;
        private Panel panel4;
        private TextBox txtSurname;
        private Panel panel5;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label lblExit;
    }
}