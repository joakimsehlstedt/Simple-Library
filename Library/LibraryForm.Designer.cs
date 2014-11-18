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
            this.lblAuthors = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblMembers = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnAddLoan = new System.Windows.Forms.Button();
            this.lblLoans = new System.Windows.Forms.Label();
            this.lbLoans = new System.Windows.Forms.ListBox();
            this.btnReturnLoan = new System.Windows.Forms.Button();
            this.btnClearSelectionAuthor = new System.Windows.Forms.Button();
            this.btnClearSelectionMembers = new System.Windows.Forms.Button();
            this.lbCopies = new System.Windows.Forms.ListBox();
            this.btnAddCopy = new System.Windows.Forms.Button();
            this.lblCopies = new System.Windows.Forms.Label();
            this.btnClearSelectionCopies = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(268, 25);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(250, 238);
            this.lbBooks.TabIndex = 0;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            // 
            // lbAuthors
            // 
            this.lbAuthors.FormattingEnabled = true;
            this.lbAuthors.Location = new System.Drawing.Point(12, 25);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(250, 238);
            this.lbAuthors.TabIndex = 1;
            this.lbAuthors.SelectedIndexChanged += new System.EventHandler(this.lbAuthors_SelectedIndexChanged);
            // 
            // lbMembers
            // 
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.Location = new System.Drawing.Point(268, 338);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(250, 238);
            this.lbMembers.TabIndex = 2;
            this.lbMembers.SelectedIndexChanged += new System.EventHandler(this.lbMembers_SelectedIndexChanged);
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
            this.lblMembers.Location = new System.Drawing.Point(265, 322);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(50, 13);
            this.lblMembers.TabIndex = 6;
            this.lblMembers.Text = "Members";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(479, 269);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(39, 23);
            this.btnAddBook.TabIndex = 7;
            this.btnAddBook.Text = "add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(479, 582);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(39, 23);
            this.btnAddMember.TabIndex = 8;
            this.btnAddMember.Text = "add";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.Location = new System.Drawing.Point(735, 582);
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
            this.lblLoans.Location = new System.Drawing.Point(521, 322);
            this.lblLoans.Name = "lblLoans";
            this.lblLoans.Size = new System.Drawing.Size(36, 13);
            this.lblLoans.TabIndex = 10;
            this.lblLoans.Text = "Loans";
            // 
            // lbLoans
            // 
            this.lbLoans.FormattingEnabled = true;
            this.lbLoans.Location = new System.Drawing.Point(524, 338);
            this.lbLoans.Name = "lbLoans";
            this.lbLoans.Size = new System.Drawing.Size(250, 238);
            this.lbLoans.TabIndex = 9;
            this.lbLoans.SelectedIndexChanged += new System.EventHandler(this.lbLoans_SelectedIndexChanged);
            // 
            // btnReturnLoan
            // 
            this.btnReturnLoan.Location = new System.Drawing.Point(665, 582);
            this.btnReturnLoan.Name = "btnReturnLoan";
            this.btnReturnLoan.Size = new System.Drawing.Size(64, 23);
            this.btnReturnLoan.TabIndex = 12;
            this.btnReturnLoan.Text = "return";
            this.btnReturnLoan.UseVisualStyleBackColor = true;
            this.btnReturnLoan.Click += new System.EventHandler(this.btnReturnLoan_Click);
            // 
            // btnClearSelectionAuthor
            // 
            this.btnClearSelectionAuthor.Location = new System.Drawing.Point(12, 269);
            this.btnClearSelectionAuthor.Name = "btnClearSelectionAuthor";
            this.btnClearSelectionAuthor.Size = new System.Drawing.Size(103, 23);
            this.btnClearSelectionAuthor.TabIndex = 13;
            this.btnClearSelectionAuthor.Text = "clear selection";
            this.btnClearSelectionAuthor.UseVisualStyleBackColor = true;
            this.btnClearSelectionAuthor.Click += new System.EventHandler(this.btnClearSelectionAuthor_Click);
            // 
            // btnClearSelectionMembers
            // 
            this.btnClearSelectionMembers.Location = new System.Drawing.Point(268, 582);
            this.btnClearSelectionMembers.Name = "btnClearSelectionMembers";
            this.btnClearSelectionMembers.Size = new System.Drawing.Size(103, 23);
            this.btnClearSelectionMembers.TabIndex = 14;
            this.btnClearSelectionMembers.Text = "clear selection";
            this.btnClearSelectionMembers.UseVisualStyleBackColor = true;
            this.btnClearSelectionMembers.Click += new System.EventHandler(this.btnClearSelectionMembers_Click);
            // 
            // lbCopies
            // 
            this.lbCopies.FormattingEnabled = true;
            this.lbCopies.Location = new System.Drawing.Point(12, 338);
            this.lbCopies.Name = "lbCopies";
            this.lbCopies.Size = new System.Drawing.Size(250, 238);
            this.lbCopies.TabIndex = 15;
            // 
            // btnAddCopy
            // 
            this.btnAddCopy.Location = new System.Drawing.Point(223, 582);
            this.btnAddCopy.Name = "btnAddCopy";
            this.btnAddCopy.Size = new System.Drawing.Size(39, 23);
            this.btnAddCopy.TabIndex = 16;
            this.btnAddCopy.Text = "add";
            this.btnAddCopy.UseVisualStyleBackColor = true;
            this.btnAddCopy.Click += new System.EventHandler(this.btnAddCopy_Click);
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(9, 322);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(122, 13);
            this.lblCopies.TabIndex = 17;
            this.lblCopies.Text = "Available copies for loan\r\n";
            // 
            // btnClearSelectionCopies
            // 
            this.btnClearSelectionCopies.Location = new System.Drawing.Point(12, 582);
            this.btnClearSelectionCopies.Name = "btnClearSelectionCopies";
            this.btnClearSelectionCopies.Size = new System.Drawing.Size(103, 23);
            this.btnClearSelectionCopies.TabIndex = 18;
            this.btnClearSelectionCopies.Text = "clear selection";
            this.btnClearSelectionCopies.UseVisualStyleBackColor = true;
            this.btnClearSelectionCopies.Click += new System.EventHandler(this.btnClearSelectionCopies_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(524, 9);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(39, 13);
            this.lblDetails.TabIndex = 19;
            this.lblDetails.Text = "Details";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(524, 26);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.Size = new System.Drawing.Size(250, 237);
            this.txtDetails.TabIndex = 20;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 638);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btnClearSelectionCopies);
            this.Controls.Add(this.lblCopies);
            this.Controls.Add(this.btnAddCopy);
            this.Controls.Add(this.lbCopies);
            this.Controls.Add(this.btnClearSelectionMembers);
            this.Controls.Add(this.btnClearSelectionAuthor);
            this.Controls.Add(this.btnReturnLoan);
            this.Controls.Add(this.btnAddLoan);
            this.Controls.Add(this.lblLoans);
            this.Controls.Add(this.lbLoans);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lblMembers);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.lblAuthors);
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
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnAddLoan;
        private System.Windows.Forms.Label lblLoans;
        private System.Windows.Forms.ListBox lbLoans;
        private System.Windows.Forms.Button btnReturnLoan;
        private System.Windows.Forms.Button btnClearSelectionAuthor;
        private System.Windows.Forms.Button btnClearSelectionMembers;
        private System.Windows.Forms.ListBox lbCopies;
        private System.Windows.Forms.Button btnAddCopy;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.Button btnClearSelectionCopies;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtDetails;
    }
}

