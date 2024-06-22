namespace WFInterface
{
    partial class AdminPanel
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
            btnAddUser = new Button();
            btnRemoveUser = new Button();
            btnAddBook = new Button();
            btnBackToMenu = new Button();
            btnRemoveBook = new Button();
            panel1 = new Panel();
            labelNameless = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(217, 189, 165);
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnAddUser.Location = new Point(191, 133);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(249, 73);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Add user";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // btnRemoveUser
            // 
            btnRemoveUser.BackColor = Color.FromArgb(217, 189, 165);
            btnRemoveUser.FlatAppearance.BorderSize = 0;
            btnRemoveUser.FlatStyle = FlatStyle.Flat;
            btnRemoveUser.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnRemoveUser.Location = new Point(465, 133);
            btnRemoveUser.Name = "btnRemoveUser";
            btnRemoveUser.Size = new Size(262, 73);
            btnRemoveUser.TabIndex = 1;
            btnRemoveUser.Text = "Remove user";
            btnRemoveUser.UseVisualStyleBackColor = false;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.FromArgb(217, 189, 165);
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnAddBook.Location = new Point(191, 234);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(249, 73);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add book";
            btnAddBook.UseVisualStyleBackColor = false;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.BackColor = Color.FromArgb(217, 189, 165);
            btnBackToMenu.FlatAppearance.BorderSize = 0;
            btnBackToMenu.FlatStyle = FlatStyle.Flat;
            btnBackToMenu.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnBackToMenu.Location = new Point(697, 15);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(220, 73);
            btnBackToMenu.TabIndex = 3;
            btnBackToMenu.Text = "Back to menu";
            btnBackToMenu.UseVisualStyleBackColor = false;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // btnRemoveBook
            // 
            btnRemoveBook.BackColor = Color.FromArgb(217, 189, 165);
            btnRemoveBook.FlatAppearance.BorderSize = 0;
            btnRemoveBook.FlatStyle = FlatStyle.Flat;
            btnRemoveBook.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnRemoveBook.Location = new Point(465, 234);
            btnRemoveBook.Name = "btnRemoveBook";
            btnRemoveBook.Size = new Size(262, 73);
            btnRemoveBook.TabIndex = 4;
            btnRemoveBook.Text = "Remove book";
            btnRemoveBook.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 203, 186);
            panel1.Controls.Add(labelNameless);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnBackToMenu);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 101);
            panel1.TabIndex = 5;
            // 
            // labelNameless
            // 
            labelNameless.AutoSize = true;
            labelNameless.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelNameless.Location = new Point(115, 24);
            labelNameless.Name = "labelNameless";
            labelNameless.Size = new Size(325, 49);
            labelNameless.TabIndex = 18;
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
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 621);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 21;
            label1.Text = "Nie usuwać, przybornik";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(217, 189, 165);
            panel7.Location = new Point(225, 645);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(32, 33);
            panel7.TabIndex = 20;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(229, 203, 186);
            panel6.Location = new Point(186, 645);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(32, 33);
            panel6.TabIndex = 17;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(229, 222, 207);
            panel5.Location = new Point(147, 645);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(32, 33);
            panel5.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(238, 231, 215);
            panel4.Location = new Point(108, 645);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(32, 33);
            panel4.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(246, 238, 227);
            panel3.Location = new Point(69, 645);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(32, 33);
            panel3.TabIndex = 16;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 238, 227);
            ClientSize = new Size(943, 748);
            Controls.Add(label1);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(btnRemoveBook);
            Controls.Add(btnAddBook);
            Controls.Add(btnRemoveUser);
            Controls.Add(btnAddUser);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddUser;
        private Button btnRemoveUser;
        private Button btnAddBook;
        private Button btnBackToMenu;
        private Button btnRemoveBook;
        private Panel panel1;
        private Label labelNameless;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
    }
}