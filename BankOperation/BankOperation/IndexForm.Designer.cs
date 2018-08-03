namespace BankOperation
{
    partial class IndexForm
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
            this.saveCustomerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.transactionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.searchCustomerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // saveCustomerLinkLabel
            // 
            this.saveCustomerLinkLabel.AutoSize = true;
            this.saveCustomerLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCustomerLinkLabel.Location = new System.Drawing.Point(173, 87);
            this.saveCustomerLinkLabel.Name = "saveCustomerLinkLabel";
            this.saveCustomerLinkLabel.Size = new System.Drawing.Size(214, 17);
            this.saveCustomerLinkLabel.TabIndex = 0;
            this.saveCustomerLinkLabel.TabStop = true;
            this.saveCustomerLinkLabel.Text = "Save Customer and Account Info";
            this.saveCustomerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.saveCustomerLinkLabel_LinkClicked);
            // 
            // transactionLinkLabel
            // 
            this.transactionLinkLabel.AutoSize = true;
            this.transactionLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionLinkLabel.Location = new System.Drawing.Point(234, 122);
            this.transactionLinkLabel.Name = "transactionLinkLabel";
            this.transactionLinkLabel.Size = new System.Drawing.Size(83, 17);
            this.transactionLinkLabel.TabIndex = 0;
            this.transactionLinkLabel.TabStop = true;
            this.transactionLinkLabel.Text = "Transaction";
            this.transactionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.transactionLinkLabel_LinkClicked);
            // 
            // searchCustomerLinkLabel
            // 
            this.searchCustomerLinkLabel.AutoSize = true;
            this.searchCustomerLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerLinkLabel.Location = new System.Drawing.Point(167, 153);
            this.searchCustomerLinkLabel.Name = "searchCustomerLinkLabel";
            this.searchCustomerLinkLabel.Size = new System.Drawing.Size(227, 17);
            this.searchCustomerLinkLabel.TabIndex = 0;
            this.searchCustomerLinkLabel.TabStop = true;
            this.searchCustomerLinkLabel.Text = "Search Customer and Account Info";
            this.searchCustomerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.searchCustomerLinkLabel_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(207, 187);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 17);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Transaction History";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 311);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.searchCustomerLinkLabel);
            this.Controls.Add(this.transactionLinkLabel);
            this.Controls.Add(this.saveCustomerLinkLabel);
            this.Name = "IndexForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel saveCustomerLinkLabel;
        private System.Windows.Forms.LinkLabel transactionLinkLabel;
        private System.Windows.Forms.LinkLabel searchCustomerLinkLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

