using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOConnectedModeTask1
{
    public partial class frmUpdateAndDelete : Form
    {
        public frmUpdateAndDelete()
        {
            InitializeComponent();
            FillEmployeesToComboBox();
        }

        private void FillEmployeesToComboBox()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6H9B8GJ\\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand command = new SqlCommand();
            command.CommandText = "select concat(fname,' ',lname) as FullName,ssn as SSN from employee";

            //REMEMBER
            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                comboEmployees.DataSource = dt;
                comboEmployees.DisplayMember = "FullName";
                comboEmployees.ValueMember = "SSN";
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void comboEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6H9B8GJ\\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True;Trust Server Certificate=True");

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from employee where ssn=@ssn";
            command.Parameters.AddWithValue("@ssn", comboEmployees.SelectedValue.ToString());

            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                txtId.Text = dt.Rows[0]["ssn"].ToString();
                txtFName.Text = dt.Rows[0]["fname"].ToString();
                txtLName.Text = dt.Rows[0]["lname"].ToString();
                txtAddress.Text = dt.Rows[0]["address"].ToString();
                txtId.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6H9B8GJ\\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True;Trust Server Certificate=True");

            SqlCommand command = new SqlCommand();
            command.CommandText = "update employee set fname=@fn,lname=@ln,address=@address where ssn=@ssn";
            command.Parameters.AddWithValue("@ssn", txtId.Text);
            command.Parameters.AddWithValue("@fn", txtFName.Text);
            command.Parameters.AddWithValue("@ln", txtLName.Text);
            command.Parameters.AddWithValue("@address", txtAddress.Text);

            command.Connection = con;
            try
            {
                con.Open();
                lblResult.Text = $"{command.ExecuteNonQuery()} Rows Affected";
                FillEmployeesToComboBox();
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure delete {txtFName.Text.ToString()}", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-6H9B8GJ\\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True;Trust Server Certificate=True");

                SqlCommand command = new SqlCommand();
                command.CommandText = "delete from employee where ssn=@ssn";
                command.Parameters.AddWithValue("@ssn", comboEmployees.SelectedValue.ToString());

                command.Connection = con;
                try
                {
                    con.Open();
                    lblResult.Text = $"{command.ExecuteNonQuery()} Rows Deleted";
                    FillEmployeesToComboBox(); //refresh
                }
                catch (Exception)
                {

                    throw;
                }
                finally { con.Close(); }
            }
        }
    }
}

