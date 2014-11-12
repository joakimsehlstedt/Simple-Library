namespace Library {
    partial class MemberForm {
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPersId = new System.Windows.Forms.TextBox();
            this.lblLoans = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPersId = new System.Windows.Forms.Label();
            this.lblIdData = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lbLoans = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(93, 226);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 24;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 20;
            // 
            // txtPersId
            // 
            this.txtPersId.Location = new System.Drawing.Point(81, 25);
            this.txtPersId.Name = "txtPersId";
            this.txtPersId.Size = new System.Drawing.Size(180, 20);
            this.txtPersId.TabIndex = 19;
            // 
            // lblLoans
            // 
            this.lblLoans.AutoSize = true;
            this.lblLoans.Location = new System.Drawing.Point(37, 78);
            this.lblLoans.Name = "lblLoans";
            this.lblLoans.Size = new System.Drawing.Size(39, 13);
            this.lblLoans.TabIndex = 17;
            this.lblLoans.Text = "Loans:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name:";
            // 
            // lblPersId
            // 
            this.lblPersId.AutoSize = true;
            this.lblPersId.Location = new System.Drawing.Point(12, 28);
            this.lblPersId.Name = "lblPersId";
            this.lblPersId.Size = new System.Drawing.Size(63, 13);
            this.lblPersId.TabIndex = 15;
            this.lblPersId.Text = "Personal Id:";
            // 
            // lblIdData
            // 
            this.lblIdData.AutoSize = true;
            this.lblIdData.Location = new System.Drawing.Point(78, 9);
            this.lblIdData.Name = "lblIdData";
            this.lblIdData.Size = new System.Drawing.Size(27, 13);
            this.lblIdData.TabIndex = 14;
            this.lblIdData.Text = "N/A";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(56, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "Id:";
            // 
            // lbLoans
            // 
            this.lbLoans.FormattingEnabled = true;
            this.lbLoans.Location = new System.Drawing.Point(81, 78);
            this.lbLoans.Name = "lbLoans";
            this.lbLoans.Size = new System.Drawing.Size(180, 69);
            this.lbLoans.TabIndex = 25;
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 261);
            this.Controls.Add(this.lbLoans);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPersId);
            this.Controls.Add(this.lblLoans);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPersId);
            this.Controls.Add(this.lblIdData);
            this.Controls.Add(this.lblId);
            this.Name = "MemberForm";
            this.Text = "Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPersId;
        private System.Windows.Forms.Label lblLoans;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPersId;
        private System.Windows.Forms.Label lblIdData;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ListBox lbLoans;
    }
}