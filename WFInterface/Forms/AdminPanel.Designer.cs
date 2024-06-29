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
            panel1 = new Panel();
            labelNameless = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            tbYearAdd = new TextBox();
            tbTitleAdd = new TextBox();
            tbAuthorAdd = new TextBox();
            btnAddBook = new Button();
            lblTitleAdd = new Label();
            lblYearAdd = new Label();
            lblAuthorAdd = new Label();
            panel8 = new Panel();
            tbTitleRm = new TextBox();
            tbYearRm = new TextBox();
            tbAuthorRm = new TextBox();
            button1 = new Button();
            lblTitleRm = new Label();
            lblYearRm = new Label();
            lblAuthorRm = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 203, 186);
            panel1.Controls.Add(labelNameless);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 101);
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
            label1.Location = new Point(25, 686);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 21;
            label1.Text = "Nie usuwać, przybornik";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(217, 189, 165);
            panel7.Location = new Point(160, 710);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(32, 33);
            panel7.TabIndex = 20;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(229, 203, 186);
            panel6.Location = new Point(121, 710);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(32, 33);
            panel6.TabIndex = 17;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(229, 222, 207);
            panel5.Location = new Point(82, 710);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(32, 33);
            panel5.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(238, 231, 215);
            panel4.Location = new Point(43, 710);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(32, 33);
            panel4.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(246, 238, 227);
            panel3.Location = new Point(4, 710);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(32, 33);
            panel3.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(229, 203, 186);
            panel2.Controls.Add(tbYearAdd);
            panel2.Controls.Add(tbTitleAdd);
            panel2.Controls.Add(tbAuthorAdd);
            panel2.Controls.Add(btnAddBook);
            panel2.Controls.Add(lblTitleAdd);
            panel2.Controls.Add(lblYearAdd);
            panel2.Controls.Add(lblAuthorAdd);
            panel2.Location = new Point(101, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 233);
            panel2.TabIndex = 22;
            // 
            // tbYearAdd
            // 
            tbYearAdd.Location = new Point(109, 67);
            tbYearAdd.Name = "tbYearAdd";
            tbYearAdd.Size = new Size(204, 27);
            tbYearAdd.TabIndex = 7;
            tbYearAdd.TextChanged += tbYearAdd_TextChanged;
            // 
            // tbTitleAdd
            // 
            tbTitleAdd.Location = new Point(109, 109);
            tbTitleAdd.Name = "tbTitleAdd";
            tbTitleAdd.Size = new Size(204, 27);
            tbTitleAdd.TabIndex = 6;
            tbTitleAdd.TextChanged += tbTitleAdd_TextChanged;
            // 
            // tbAuthorAdd
            // 
            tbAuthorAdd.Location = new Point(109, 22);
            tbAuthorAdd.Name = "tbAuthorAdd";
            tbAuthorAdd.Size = new Size(204, 27);
            tbAuthorAdd.TabIndex = 5;
            tbAuthorAdd.TextChanged += tbAuthorAdd_TextChanged;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.FromArgb(217, 189, 165);
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            btnAddBook.ForeColor = Color.FromArgb(246, 238, 227);
            btnAddBook.Location = new Point(83, 162);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(189, 48);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "Add book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // lblTitleAdd
            // 
            lblTitleAdd.AutoSize = true;
            lblTitleAdd.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblTitleAdd.Location = new Point(20, 109);
            lblTitleAdd.Name = "lblTitleAdd";
            lblTitleAdd.Size = new Size(58, 28);
            lblTitleAdd.TabIndex = 3;
            lblTitleAdd.Text = "Title:";
            // 
            // lblYearAdd
            // 
            lblYearAdd.AutoSize = true;
            lblYearAdd.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblYearAdd.Location = new Point(20, 66);
            lblYearAdd.Name = "lblYearAdd";
            lblYearAdd.Size = new Size(57, 28);
            lblYearAdd.TabIndex = 1;
            lblYearAdd.Text = "Year:";
            // 
            // lblAuthorAdd
            // 
            lblAuthorAdd.AutoSize = true;
            lblAuthorAdd.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblAuthorAdd.Location = new Point(20, 22);
            lblAuthorAdd.Name = "lblAuthorAdd";
            lblAuthorAdd.Size = new Size(83, 28);
            lblAuthorAdd.TabIndex = 0;
            lblAuthorAdd.Text = "Author:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(229, 203, 186);
            panel8.Controls.Add(tbTitleRm);
            panel8.Controls.Add(tbYearRm);
            panel8.Controls.Add(tbAuthorRm);
            panel8.Controls.Add(button1);
            panel8.Controls.Add(lblTitleRm);
            panel8.Controls.Add(lblYearRm);
            panel8.Controls.Add(lblAuthorRm);
            panel8.Location = new Point(486, 165);
            panel8.Name = "panel8";
            panel8.Size = new Size(339, 233);
            panel8.TabIndex = 23;
            // 
            // tbTitleRm
            // 
            tbTitleRm.Location = new Point(117, 112);
            tbTitleRm.Name = "tbTitleRm";
            tbTitleRm.Size = new Size(204, 27);
            tbTitleRm.TabIndex = 8;
            // 
            // tbYearRm
            // 
            tbYearRm.Location = new Point(117, 66);
            tbYearRm.Name = "tbYearRm";
            tbYearRm.Size = new Size(204, 27);
            tbYearRm.TabIndex = 9;
            // 
            // tbAuthorRm
            // 
            tbAuthorRm.Location = new Point(117, 22);
            tbAuthorRm.Name = "tbAuthorRm";
            tbAuthorRm.Size = new Size(204, 27);
            tbAuthorRm.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(217, 189, 165);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(246, 238, 227);
            button1.Location = new Point(90, 162);
            button1.Name = "button1";
            button1.Size = new Size(189, 48);
            button1.TabIndex = 5;
            button1.Text = "Remove book";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblTitleRm
            // 
            lblTitleRm.AutoSize = true;
            lblTitleRm.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblTitleRm.Location = new Point(28, 109);
            lblTitleRm.Name = "lblTitleRm";
            lblTitleRm.Size = new Size(58, 28);
            lblTitleRm.TabIndex = 4;
            lblTitleRm.Text = "Title:";
            // 
            // lblYearRm
            // 
            lblYearRm.AutoSize = true;
            lblYearRm.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblYearRm.Location = new Point(28, 66);
            lblYearRm.Name = "lblYearRm";
            lblYearRm.Size = new Size(57, 28);
            lblYearRm.TabIndex = 2;
            lblYearRm.Text = "Year:";
            // 
            // lblAuthorRm
            // 
            lblAuthorRm.AutoSize = true;
            lblAuthorRm.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblAuthorRm.Location = new Point(28, 22);
            lblAuthorRm.Name = "lblAuthorRm";
            lblAuthorRm.Size = new Size(83, 28);
            lblAuthorRm.TabIndex = 1;
            lblAuthorRm.Text = "Author:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(217, 189, 165);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(246, 238, 227);
            button2.Location = new Point(824, 29);
            button2.Name = "button2";
            button2.Size = new Size(130, 48);
            button2.TabIndex = 3;
            button2.Text = "Go Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnBackToMenu_Click;
            // 
            // AdminPanel
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(246, 238, 227);
            ClientSize = new Size(984, 748);
            Controls.Add(panel8);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label labelNameless;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel8;
        private Button btnAddBook;
        private Label lblTitleAdd;
        private Label lblYearAdd;
        private Label lblAuthorAdd;
        private Button button1;
        private Label lblTitleRm;
        private Label lblYearRm;
        private Label lblAuthorRm;
        private TextBox tbYearAdd;
        private TextBox tbTitleAdd;
        private TextBox tbAuthorAdd;
        private TextBox tbTitleRm;
        private TextBox tbYearRm;
        private TextBox tbAuthorRm;
        private Button button2;
    }
}