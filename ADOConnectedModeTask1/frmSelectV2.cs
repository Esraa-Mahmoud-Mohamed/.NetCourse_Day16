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
    public partial class frmSelectV2 : Form
    {
        public frmSelectV2()
        {
            InitializeComponent();
            FillAuthorsToComboBox();
        }

        private void FillAuthorsToComboBox()
        {
            string constr = "Server=DESKTOP-6H9B8GJ\\SQLEXPRESS;Database=Company;Trusted_connection=true;TrustServerCertificate=true";
            SqlConnection con = new SqlConnection(constr);

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from employee";

            //REMEMBER
            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                comboEmployees.DataSource = dt;
                //
                comboEmployees.DisplayMember = "fname";
                comboEmployees.ValueMember = "ssn";
                //
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

        //eventHandler
        //start without debugging [runtime purpose]
        private void comboAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-6H9B8GJ\\SQLEXPRESS;Database=Company;Trusted_connection=true;TrustServerCertificate=true");

            SqlCommand command = new SqlCommand();
            var ssn = comboEmployees.SelectedValue.ToString();
            //command.CommandText = $"select t.* from authors a,titles t,titleauthor ta where a.au_id=ta.au_id and ta.title_id=t.title_id and a.au_id='{id}'";
            command.CommandText = $"SELECT CONCAT(EMPLOYEE.FNAME, ' ', EMPLOYEE.LNAME) AS Employee_Name,PROJECT.PNAME AS Project_Name FROM WORKS_ON JOIN EMPLOYEE ON WORKS_ON.ESSN = EMPLOYEE.SSN JOIN PROJECT ON WORKS_ON.PNO = PROJECT.PNUMBER where EMPLOYEE.SSN=@ssn";
            command.Parameters.AddWithValue("@ssn", ssn);
            command.Connection = con;
            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                gridTitles.DataSource = dt;
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
    }
}
