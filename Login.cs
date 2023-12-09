using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            const string adminUsername = "admin";
            const string adminPassword = "admin";
            string username = UserId.Text.Trim();
            string password = UserPass.Text.Trim();

            //OUser oUser = new OUser();
            //  DataTable dt = new DataTable();
            // dt = oUser.UserAuthentication(username, password);


            if (username == adminUsername && password == adminPassword)
            {
                
                GlobalVariablesClass.VariableOne = UserId.Text;
                new AdminHome().Show();
                this.Hide();
            }
            
            else if(username == "user" && password == "user")
            {
               
                GlobalVariablesClass.VariableOne = UserId.Text;
                new UserHome().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid user");
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
