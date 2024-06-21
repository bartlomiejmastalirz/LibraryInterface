﻿namespace WFInterface
{
    partial class MyProfileForm
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
            lblUserName = new Label();
            panel1 = new Panel();
            labelNameless = new Label();
            pictureBox1 = new PictureBox();
            btnGoBack = new Button();
            label1 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblUserName.Location = new Point(42, 138);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(44, 26);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "null";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 203, 186);
            panel1.Controls.Add(labelNameless);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 76);
            panel1.TabIndex = 1;
            // 
            // labelNameless
            // 
            labelNameless.AutoSize = true;
            labelNameless.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelNameless.Location = new Point(84, 20);
            labelNameless.Name = "labelNameless";
            labelNameless.Size = new Size(259, 39);
            labelNameless.TabIndex = 18;
            labelNameless.Text = "NAMELESS Library";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.noun_library_71245;
            pictureBox1.Location = new Point(13, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // btnGoBack
            // 
            btnGoBack.BackColor = Color.FromArgb(217, 189, 165);
            btnGoBack.FlatAppearance.BorderSize = 0;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnGoBack.ForeColor = Color.FromArgb(246, 238, 227);
            btnGoBack.Location = new Point(755, 18);
            btnGoBack.Margin = new Padding(3, 2, 3, 2);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(94, 36);
            btnGoBack.TabIndex = 17;
            btnGoBack.Text = "Go back";
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 503);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 15;
            label1.Text = "Nie usuwać, przybornik";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(217, 189, 165);
            panel7.Location = new Point(144, 521);
            panel7.Name = "panel7";
            panel7.Size = new Size(28, 25);
            panel7.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(229, 203, 186);
            panel6.Location = new Point(110, 521);
            panel6.Name = "panel6";
            panel6.Size = new Size(28, 25);
            panel6.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(229, 222, 207);
            panel5.Location = new Point(76, 521);
            panel5.Name = "panel5";
            panel5.Size = new Size(28, 25);
            panel5.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(238, 231, 215);
            panel4.Location = new Point(42, 521);
            panel4.Name = "panel4";
            panel4.Size = new Size(28, 25);
            panel4.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(246, 238, 227);
            panel3.Location = new Point(8, 521);
            panel3.Name = "panel3";
            panel3.Size = new Size(28, 25);
            panel3.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(26, 112);
            label2.Name = "label2";
            label2.Size = new Size(196, 26);
            label2.TabIndex = 18;
            label2.Text = "Your user information";
            // 
            // MyProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 238, 227);
            ClientSize = new Size(861, 561);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(btnGoBack);
            Controls.Add(lblUserName);
            Controls.Add(label1);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MyProfileForm";
            Text = "My User Profile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Panel panel1;
        private Label label1;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button btnGoBack;
        private Label labelNameless;
        private Label label2;
    }
}