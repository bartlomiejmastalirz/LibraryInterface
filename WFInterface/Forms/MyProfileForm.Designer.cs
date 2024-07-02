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
            this.lblUsername = new System.Windows.Forms.Label();
            this.rentedBooksGridView = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rentedBooksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsername.Location = new System.Drawing.Point(12, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 19);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // rentedBooksGridView
            // 
            this.rentedBooksGridView.BackgroundColor = System.Drawing.Color.FromArgb(238, 231, 215);
            this.rentedBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentedBooksGridView.Location = new System.Drawing.Point(12, 150);
            this.rentedBooksGridView.Name = "rentedBooksGridView";
            this.rentedBooksGridView.RowHeadersWidth = 51;
            this.rentedBooksGridView.Size = new System.Drawing.Size(760, 250);
            this.rentedBooksGridView.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(12, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSurname.Location = new System.Drawing.Point(12, 70);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 19);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogin.Location = new System.Drawing.Point(12, 100);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(44, 19);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login";
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBooks.Location = new System.Drawing.Point(12, 130);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(51, 19);
            this.lblBooks.TabIndex = 5;
            this.lblBooks.Text = "Books";
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(217, 189, 165);
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGoBack.ForeColor = System.Drawing.Color.FromArgb(246, 238, 227);
            this.btnGoBack.Location = new System.Drawing.Point(12, 420);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(130, 48);
            this.btnGoBack.TabIndex = 6;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // MyProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 238, 227);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.rentedBooksGridView);
            this.Controls.Add(this.lblUsername);
            this.Name = "MyProfileForm";
            this.Text = "MyProfileForm";
            ((System.ComponentModel.ISupportInitialize)(this.rentedBooksGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}