using System.Diagnostics.Eventing.Reader;
using System.Data;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
namespace WinFormsSart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             //SqlConnection con=new SqlConnection("Data Source = LAPTOP - M3CDGNSA\SQLEXPRESS; Initial Catalog = userregis; Integrated Security = True; Trust Server Certificate = True");

            ///* if (txtName.Text == "Kshankar" && txtAddress.Text == "@shankar")
            // {
            //     MessageBox.Show("Login succesfull");
            // }
            // else
            // {5
            //     MessageBox.Show("user name or pasword not match");
            // }
            try
            {
                //1.Address of SQL server and database(Connection String)
                //string connectionString = "Data Source = LAPTOP - M3CDGNSA\\SQLEXPRESS; Initial Catalog = userregis; Integrated Security = True; Trust Server Certificate = True";
                string connectionString = "Data Source=LAPTOP-M3CDGNSA\\SQLEXPRESS;Initial Catalog=userregis;Integrated " +
                   "Security=True;Trust Server Certificate=True";
                //2.Establish connection(c# sqlconnection class)
                SqlConnection sq = new SqlConnection(connectionString);
                //3.Open connection(c# sqlconnection open)
                sq.Open();
                //4.Prepare SQL query
                string query = "insert into register (firstname,lastname,address,gender,email,phone,username,password) values('" + txtName.Text + "','" + txtLname.Text + "','" + txtAddress.Text + "','" + comboGender.Text + "','" + txtEmail.Text + "','" + txtph.Text + "','"+txtUname+ "','"+txtpassword.Text+"')";

                //5.Execute query(c# sqlcommand class)
                SqlCommand cmd = new SqlCommand(query, sq);
                cmd.ExecuteNonQuery();
                //6.Close connection(c# sqlconnection close)
                sq.Close();
                MessageBox.Show("Added Data Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
