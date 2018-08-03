namespace BankOperation
{
    partial class TransactionForm
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
            this.acNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ammountTextBox = new System.Windows.Forms.TextBox();
            this.DepusitButton = new System.Windows.Forms.Button();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.accountLabel = new System.Windows.Forms.Label();
            this.ammountLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // acNumberTextBox
            // 
            this.acNumberTextBox.Location = new System.Drawing.Point(175, 95);
            this.acNumberTextBox.Name = "acNumberTextBox";
            this.acNumberTextBox.Size = new System.Drawing.Size(208, 20);
            this.acNumberTextBox.TabIndex = 3;
            this.acNumberTextBox.TextChanged += new System.EventHandler(this.acNumberTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ammount";
            // 
            // ammountTextBox
            // 
            this.ammountTextBox.Location = new System.Drawing.Point(175, 130);
            this.ammountTextBox.Name = "ammountTextBox";
            this.ammountTextBox.Size = new System.Drawing.Size(208, 20);
            this.ammountTextBox.TabIndex = 3;
            this.ammountTextBox.TextChanged += new System.EventHandler(this.ammountTextBox_TextChanged);
            // 
            // DepusitButton
            // 
            this.DepusitButton.Location = new System.Drawing.Point(175, 169);
            this.DepusitButton.Name = "DepusitButton";
            this.DepusitButton.Size = new System.Drawing.Size(94, 23);
            this.DepusitButton.TabIndex = 4;
            this.DepusitButton.Text = "Deposit";
            this.DepusitButton.UseVisualStyleBackColor = true;
            this.DepusitButton.Click += new System.EventHandler(this.DepusitButton_Click);
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(289, 169);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(94, 23);
            this.WithdrawButton.TabIndex = 4;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(546, 276);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(29, 23);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.ForeColor = System.Drawing.Color.Red;
            this.accountLabel.Location = new System.Drawing.Point(389, 98);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(0, 13);
            this.accountLabel.TabIndex = 9;
            // 
            // ammountLabel
            // 
            this.ammountLabel.AutoSize = true;
            this.ammountLabel.ForeColor = System.Drawing.Color.Red;
            this.ammountLabel.Location = new System.Drawing.Point(389, 133);
            this.ammountLabel.Name = "ammountLabel";
            this.ammountLabel.Size = new System.Drawing.Size(0, 13);
            this.ammountLabel.TabIndex = 9;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.ForeColor = System.Drawing.Color.Green;
            this.userNameLabel.Location = new System.Drawing.Point(389, 98);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(0, 13);
            this.userNameLabel.TabIndex = 10;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 311);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.ammountLabel);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.DepusitButton);
            this.Controls.Add(this.ammountTextBox);
            this.Controls.Add(this.acNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "TransactionForm";
            this.Text = "Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox acNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ammountTextBox;
        private System.Windows.Forms.Button DepusitButton;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Label ammountLabel;
        private System.Windows.Forms.Label userNameLabel;
    }
}