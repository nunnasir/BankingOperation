using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankOperation.Models;

namespace BankOperation
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            IndexForm indexForm = new IndexForm();
            indexForm.Show();
        }
        Transaction transaction = new Transaction();

        string conString = @"server=DESKTOP-E1SJ59O; database=BankOperation; integrated security=true;";
        
        //Deposit Account
        private void DepusitButton_Click(object sender, EventArgs e)
        {
            transaction.AcNumber = acNumberTextBox.Text;
            
            if (string.IsNullOrEmpty(transaction.AcNumber) || string.IsNullOrEmpty(ammountTextBox.Text))
            {
                MessageBox.Show("All Fields are Mendatory!!");
                return;
            }

            transaction.Balance = Convert.ToDouble(ammountTextBox.Text);

            if (!(string.IsNullOrEmpty(accountLabel.Text)))
            {
                MessageBox.Show("Please Resolve all error!!");
                return;
            }

            bool isAdded = AddDeposit(transaction);
            if (isAdded)
            {
                MessageBox.Show("Update Account Successfully by Deposit!!");
                acNumberTextBox.Clear();
                ammountTextBox.Clear();
                return;
            }

            MessageBox.Show("There Is An Error For updating account!!");

        }

        public bool AddDeposit(Transaction transaction)
        {
            SqlConnection conn = new SqlConnection(conString);
            string updateQuery = @"UPDATE Customers SET Balance = (SELECT Balance FROM Customers WHERE AcNumber = '"+transaction.AcNumber+"') + "+transaction.Balance+" WHERE AcNumber = '"+transaction.AcNumber+"' ";
            string depQuery = @"INSERT INTO Transactions VALUES((SELECT Id FROM Customers WHERE AcNumber = '"+transaction.AcNumber+"'), "+transaction.Balance+", "+transaction.depositNum+" , GETDATE())";
            SqlCommand upcommand = new SqlCommand(updateQuery, conn);
            SqlCommand depcommand = new SqlCommand(depQuery, conn);

            conn.Open();
            bool isRowAffected = upcommand.ExecuteNonQuery() > 0 && depcommand.ExecuteNonQuery() > 0;
            conn.Close();
            return isRowAffected;
        }

        //Withdraw Account
        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            transaction.AcNumber = acNumberTextBox.Text;

            if (string.IsNullOrEmpty(transaction.AcNumber) || string.IsNullOrEmpty(ammountTextBox.Text))
            {
                MessageBox.Show("All Fields are Mendatory!!");
                return;
            }
            
            transaction.Balance = Convert.ToDouble(ammountTextBox.Text);

            if (!(string.IsNullOrEmpty(accountLabel.Text)) || !(string.IsNullOrEmpty(ammountLabel.Text)))
            {
                MessageBox.Show("Please Resolve all error!!");
                return;
            }


            bool isAdded = AddWithdraw(transaction);
            if (isAdded)
            {
                MessageBox.Show("Update Account Successfully by Withdraw!!");
                acNumberTextBox.Clear();
                ammountTextBox.Clear();
                return;
            }

            MessageBox.Show("There Is An Error For updating account!!");
        }

        public bool AddWithdraw(Transaction transaction)
        {
            SqlConnection conn = new SqlConnection(conString);
            string updateQuery = @"UPDATE Customers SET Balance = (SELECT Balance FROM Customers WHERE AcNumber = '" + transaction.AcNumber + "') - " + transaction.Balance + " WHERE AcNumber = '" + transaction.AcNumber + "' ";
            string depQuery = @"INSERT INTO Transactions VALUES((SELECT Id FROM Customers WHERE AcNumber = '" + transaction.AcNumber + "'), " + transaction.Balance + ", " + transaction.withdrawNum + " , GETDATE())";
            SqlCommand upcommand = new SqlCommand(updateQuery, conn);
            SqlCommand depcommand = new SqlCommand(depQuery, conn);

            conn.Open();
            bool isRowAffected = upcommand.ExecuteNonQuery() > 0 && depcommand.ExecuteNonQuery() > 0;
            conn.Close();
            return isRowAffected;
        }

        //Check Account Number
        private void acNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            transaction.AcNumber = acNumberTextBox.Text;
            SqlConnection conn = new SqlConnection(conString);
            string query = @"SELECT Name, Balance FROM Customers WHERE AcNumber = '" + transaction.AcNumber + "' ";
            SqlCommand command = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                userNameLabel.Text = dr.GetValue(0).ToString();
                accountLabel.Text = "";
            }
            else
            {
                accountLabel.Text = "* Invalid Account Number!!!";
                userNameLabel.Text = "";
            }

            conn.Close();
        }

        //Check valid Ammount
        private void ammountTextBox_TextChanged(object sender, EventArgs e)
        {
            transaction.AcNumber = acNumberTextBox.Text;
            string temp = ammountTextBox.Text;
            foreach (char c in temp)
            {
                if (char.IsDigit(c) == false && c!='.')
                {
                    ammountLabel.Text = "* Invalid Input Ammount";
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(temp))
            {
                ammountLabel.Text = "* Invalid Input Ammount";
                return;
            }
            
            double balance = Convert.ToDouble(temp);

            SqlConnection conn = new SqlConnection(conString);
            string query = @"SELECT Balance FROM Customers WHERE AcNumber = '" + transaction.AcNumber + "' ";
            SqlCommand command = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                double ammount = Convert.ToDouble(dr.GetValue(0).ToString());
                if (ammount < balance )
                {
                    ammountLabel.Text = "* Not enough Balance for Withdraw!!!";
                    return;
                }
                ammountLabel.Text = "";
            }

            conn.Close();
        }
    }
}
