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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.noun_library_71245;
            pictureBox1.Location = new Point(112, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.OliveDrab;
            label1.Location = new Point(41, 128);
            label1.MinimumSize = new Size(110, 40);
            label1.Name = "label1";
            label1.Size = new Size(228, 40);
            label1.TabIndex = 1;
            label1.Text = "NAMELESS LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OliveDrab;
            panel1.Location = new Point(17, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 10);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OliveDrab;
            panel2.Location = new Point(17, 302);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 11);
            panel2.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.OliveDrab;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LoginButton.ForeColor = Color.SeaShell;
            LoginButton.Location = new Point(22, 362);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(265, 32);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Log in";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ExitLabel.ForeColor = Color.ForestGreen;
            ExitLabel.Location = new Point(141, 416);
            ExitLabel.Name = "ExitLabel";
            ExitLabel.Size = new Size(28, 16);
            ExitLabel.TabIndex = 5;
            ExitLabel.Text = "Exit";
            ExitLabel.Click += ExitLabel_Click;
            // 
            // TxtUsername
            // 
            TxtUsername.BackColor = Color.SeaShell;
            TxtUsername.BorderStyle = BorderStyle.None;
            TxtUsername.Font = new Font("Calibri", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtUsername.ForeColor = Color.DarkGray;
            TxtUsername.Location = new Point(66, 181);
            TxtUsername.Multiline = true;
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(212, 28);
            TxtUsername.TabIndex = 6;
            TxtUsername.Text = "Login";
            TxtUsername.Enter += TxtUsername_Enter;
            TxtUsername.Leave += TxtUsername_Leave;
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.SeaShell;
            TxtPassword.BorderStyle = BorderStyle.None;
            TxtPassword.Font = new Font("Calibri", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TxtPassword.ForeColor = Color.DarkGray;
            TxtPassword.Location = new Point(66, 267);
            TxtPassword.Multiline = true;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(212, 31);
            TxtPassword.TabIndex = 6;
            TxtPassword.Text = "Password";
            TxtPassword.Enter += TxtPassword_Enter;
            TxtPassword.Leave += TxtPassword_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_padlock_24;
            pictureBox2.Location = new Point(20, 267);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_user_35;
            pictureBox3.Location = new Point(20, 181);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AcceptButton = LoginButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(308, 486);
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

        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
