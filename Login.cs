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

namespace TicktingApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserId.Text = "";
            UserPass.Text = "";
        }

        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=ROG-531GT\SQLEXPRESS;Initial Catalog=AirTickting;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = UserId.Text.Trim();
            string password = UserPass.Text.Trim();
            string adminUsername = "admin";
            string adminPassword = "admin";


            try
            {
                String query = "SELECT * FROM PassengerTbl WHERE PassName = '" + username + "' AND Password = '" + password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    UserHome newLogin = new UserHome();
                    GlobalVariablesClass.VariableOne = UserId.Text;
                    newLogin.Show();
                    this.Hide();

                }
                else if (username == adminUsername && password == adminPassword)
                {

                    GlobalVariablesClass.VariableOne = UserId.Text;
                    new AdminHome().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid user");
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                Con.Close();
            }



           
            
            
            


        }

        


        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool IsValidUser(string username, string password)
        {
            // Replace this with your actual authentication logic (e.g., database check)
            // For simplicity, using hardcoded values here
            return username == "demo" && password == "password";
        }
    }
}
