using Microsoft.Data.SqlClient;
using System.Data;
namespace ADOConnectedModeTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillEmployeesToGridView();
        }

        private void FillEmployeesToGridView()
        {
            SqlConnection con =
                new SqlConnection("Server=DESKTOP-6H9B8GJ\\SQLEXPRESS;Database=Company;Trusted_connection=true;TrustServerCertificate=true");

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from employee";

            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                gridEmployees.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //close connection
                con.Close();
            }


        }
    }
}
