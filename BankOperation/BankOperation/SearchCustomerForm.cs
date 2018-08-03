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
    public partial class SearchCustomerForm : Form
    {
        public SearchCustomerForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            IndexForm indexForm = new IndexForm();
            indexForm.Show();
        }

        Search search = new Search();
        private void SearchButton_Click(object sender, EventArgs e)
        {
            search.AcNumber = acNumberTextBox.Text;
            if (string.IsNullOrEmpty(search.AcNumber))
            {
                MessageBox.Show("Please Input Account Number!!!");
                return;
            }

            string conString = @"server=DESKTOP-E1SJ59O; database=BankOperation; integrated security=true;";
            SqlConnection conn = new SqlConnection(conString);
            string query = @"SELECT AcNumber, Name, OpeningDate, Balance FROM Customers WHERE AcNumber = '"+search.AcNumber+"'";
            SqlCommand command = new SqlCommand(query, conn);

            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            acInfoDataGridView.DataSource = dt;
            conn.Close();
        }

        private void acNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string conString = @"server=DESKTOP-E1SJ59O; database=BankOperation; integrated security=true;";
            SqlConnection conn = new SqlConnection(conString);
            string query = @"SELECT AcNumber, Name, OpeningDate, Balance FROM Customers WHERE AcNumber LIKE '%" + search.AcNumber + "%'";
            SqlCommand command = new SqlCommand(query, conn);

            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            acInfoDataGridView.DataSource = dt;
            conn.Close();
        }
    }
}
