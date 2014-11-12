namespace Library {
    partial class LibraryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.lbAuthors = new System.Windows.Forms.ListBox();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.chbAvailableOnly = new System.Windows.Forms.CheckBox();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblMembers = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnAddLoan = new System.Windows.Forms.Button();
            this.lblLoans = new System.Windows.Forms.Label();
            this.lbLoans = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(268, 25);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(250, 394);
            this.lbBooks.TabIndex = 0;
            // 
            // lbAuthors
            // 
            this.lbAuthors.FormattingEnabled = true;
            this.lbAuthors.Location = new System.Drawing.Point(12, 25);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(250, 394);
            this.lbAuthors.TabIndex = 1;
            // 
            // lbMembers
            // 
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.Location = new System.Drawing.Point(524, 25);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(250, 394);
            this.lbMembers.TabIndex = 2;
            // 
            // chbAvailableOnly
            // 
            this.chbAvailableOnly.AutoSize = true;
            this.chbAvailableOnly.Location = new System.Drawing.Point(268, 426);
            this.chbAvailableOnly.Name = "chbAvailableOnly";
            this.chbAvailableOnly.Size = new System.Drawing.Size(179, 17);
            this.chbAvailableOnly.TabIndex = 3;
            this.chbAvailableOnly.Text = "Only list copies available for loan";
            this.chbAvailableOnly.UseVisualStyleBackColor = true;
            this.chbAvailableOnly.CheckedChanged += new System.EventHandler(this.chbAvailableOnly_CheckedChanged);
            // 
            // lblAuthors
            // 
            this.lblAuthors.AutoSize = true;
            this.lblAuthors.Location = new System.Drawing.Point(9, 9);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(43, 13);
            this.lblAuthors.TabIndex = 4;
            this.lblAuthors.Text = "Authors";
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(265, 9);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(37, 13);
            this.lblBooks.TabIndex = 5;
            this.lblBooks.Text = "Books";
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Location = new System.Drawing.Point(521, 9);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(50, 13);
            this.lblMembers.TabIndex = 6;
            this.lblMembers.Text = "Members";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(479, 420);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(39, 23);
            this.btnAddBook.TabIndex = 7;
            this.btnAddBook.Text = "add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(735, 420);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(39, 23);
            this.btnAddMember.TabIndex = 8;
            this.btnAddMember.Text = "add";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.Location = new System.Drawing.Point(991, 420);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.Size = new System.Drawing.Size(39, 23);
            this.btnAddLoan.TabIndex = 11;
            this.btnAddLoan.Text = "add";
            this.btnAddLoan.UseVisualStyleBackColor = true;
            this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);
            // 
            // lblLoans
            // 
            this.lblLoans.AutoSize = true;
            this.lblLoans.Location = new System.Drawing.Point(777, 9);
            this.lblLoans.Name = "lblLoans";
            this.lblLoans.Size = new System.Drawing.Size(36, 13);
            this.lblLoans.TabIndex = 10;
            this.lblLoans.Text = "Loans";
            // 
            // lbLoans
            // 
            this.lbLoans.FormattingEnabled = true;
            this.lbLoans.Location = new System.Drawing.Point(780, 25);
            this.lbLoans.Name = "lbLoans";
            this.lbLoans.Size = new System.Drawing.Size(250, 394);
            this.lbLoans.TabIndex = 9;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 638);
            this.Controls.Add(this.btnAddLoan);
            this.Controls.Add(this.lblLoans);
            this.Controls.Add(this.lbLoans);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lblMembers);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.lblAuthors);
            this.Controls.Add(this.chbAvailableOnly);
            this.Controls.Add(this.lbMembers);
            this.Controls.Add(this.lbAuthors);
            this.Controls.Add(this.lbBooks);
            this.Name = "LibraryForm";
            this.Tag = " ";
            this.Text = "Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.ListBox lbAuthors;
        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.CheckBox chbAvailableOnly;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnAddLoan;
        private System.Windows.Forms.Label lblLoans;
        private System.Windows.Forms.ListBox lbLoans;
    }
}

