using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankOperation.Models;

namespace BankOperation
{
    public partial class SaveCustomerForm : Form
    {
        public SaveCustomerForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            IndexForm indexForm = new IndexForm();
            indexForm.Show();
        }

        Customer customer = new Customer();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            customer.Name = nameTextBox.Text;
            customer.Email = emailTextBox.Text;
            customer.AcNumber = acNumberTextBox.Text;
            customer.OpeningDate = Convert.ToDateTime(openingDateTimePicker.Text);
            customer.balance = 0;

            if (string.IsNullOrEmpty(customer.Name) || string.IsNullOrEmpty(customer.Email) || string.IsNullOrEmpty(customer.AcNumber) || string.IsNullOrEmpty(customer.OpeningDate.ToString()))
            {
                MessageBox.Show("All Field Are Mendatory!!!");
                return;
            }

            if (!(string.IsNullOrEmpty(acNumberLabel.Text)) || !(string.IsNullOrEmpty(emailLabel.Text)))
            {
                MessageBox.Show("Please Resolve all error!!");
                return;
            }

           

            bool isAdded = AddCustomer(customer);
            if (isAdded)
            {
                MessageBox.Show("One Customer Successfully Added!!");
                nameTextBox.Clear();
                emailTextBox.Clear();
                acNumberTextBox.Clear();
                return;
            }

            MessageBox.Show("There Is An Error For Adding New Customer!!");
        }
        
        string conString = @"server=DESKTOP-E1SJ59O; database=BankOperation; integrated security=true;";
        public bool AddCustomer(Customer customer)
        {
            SqlConnection conn = new SqlConnection(conString);
            string query = @"INSERT INTO Customers VALUES ('" + customer.Name + "', '" + customer.Email + "', '" + customer.AcNumber + "', '" + customer.OpeningDate + "', "+customer.balance+")";
            SqlCommand command = new SqlCommand(query,conn);

            conn.Open();
            bool isRowAffected = command.ExecuteNonQuery() > 0;
            conn.Close();
            return isRowAffected;
        }

        private void acNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            customer.AcNumber = acNumberTextBox.Text;
            if (acNumberTextBox.TextLength != 8)
            {
                acNumberLabel.Text = "* Account Number Will be 8 digit!!";
                return;
            }

            if (acNumberTextBox.TextLength == 8)
            {
                acNumberLabel.Text = "";
            }

            SqlConnection conn = new SqlConnection(conString);
            string query = @"SELECT * FROM Customers WHERE AcNumber = '" + customer.AcNumber + "' ";
            SqlCommand command = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                acNumberLabel.Text = "* Account Number Already Exist!!";
                return;
            }
            conn.Close();

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

            customer.Email = emailTextBox.Text;

            string pattern =
                @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            if (Regex.IsMatch(customer.Email,pattern))
            {
                emailLabel.Text = "";
            }
            else
            {
                emailLabel.Text = "* Select a Valid Email!!";
                return;
            }
            
            SqlConnection conn = new SqlConnection(conString);
            string query = @"SELECT * FROM Customers WHERE Email = '" + customer.Email + "' ";
            SqlCommand command = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                emailLabel.Text = "* This Email Already Exist!!";
            }
            else
            {
                emailLabel.Text = "";
            }
            conn.Close();
        }

    }
}
