using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankOperation
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void saveCustomerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveCustomerForm saveCustomerForm = new SaveCustomerForm();
            saveCustomerForm.Show();
            this.Hide();
        }

        private void transactionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Show();
            this.Hide();
        }

        private void searchCustomerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchCustomerForm searchCustomerForm = new SearchCustomerForm();
            searchCustomerForm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TransactionHistoryForm transactionHistory = new TransactionHistoryForm();
            transactionHistory.Show();
            this.Hide();
        }
    }
}
