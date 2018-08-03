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
    public partial class TransactionHistoryForm : Form
    {
        public TransactionHistoryForm()
        {
            InitializeComponent();
        }

        History history = new History();
        private void SearchButton_Click(object sender, EventArgs e)
        {
            history.AcNumber = accountTextBox.Text;
            history.FromDate = Convert.ToDateTime(fromDateTimePicker.Text);
            history.ToDate = Convert.ToDateTime(toDateTimePicker.Text);

            if (string.IsNullOrEmpty(history.AcNumber))
            {
                MessageBox.Show("Please Select Account Number!!!");
                return;
            }

            if (!(string.IsNullOrEmpty(acerrorlabel.Text)))
            {
                MessageBox.Show("Please Resolve Error First!!");
                return;
            }

            string conString = @"server=DESKTOP-E1SJ59O; database=BankOperation; integrated security=true;";
            SqlConnection conn = new SqlConnection(conString);
            string query = @"SELECT OpenDate, Balance, MediumName FROM v_transactionHistory WHERE AccountNumber = '"+history.AcNumber+"' AND (OpenDate BETWEEN '"+history.FromDate+"' AND '"+history.ToDate+"')";
            SqlCommand command = new SqlCommand(query, conn);

            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            historyDataGridView.DataSource = dt;
            conn.Close();
        }

        private void accountTextBox_TextChanged(object sender, EventArgs e)
        {
            history.AcNumber = accountTextBox.Text;

            string conString = @"server=DESKTOP-E1SJ59O; database=BankOperation; integrated security=true;";
            SqlConnection conn = new SqlConnection(conString);
            string query = @"SELECT AcNumber, Name FROM Customers WHERE AcNumber = '"+history.AcNumber+"'";
            SqlCommand command = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                acNameLabel.Text = dr.GetValue(1).ToString();
                acNumberLabel.Text = dr.GetValue(0).ToString();
                acerrorlabel.Text = "";
            }
            else
            {
                acerrorlabel.Text = "* Invalid Account Number!!!";
                acNumberLabel.Text = "";
                acNameLabel.Text = "";
            }
            
            conn.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            IndexForm indexForm = new IndexForm();
            indexForm.Show();
        }

    }
}
