using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace TicktingApplication
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void AddPassenger_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=ROG-531GT\SQLEXPRESS;Initial Catalog=AirTickting;Integrated Security=True");




        private void button1_Click(object sender, EventArgs e)
        {
            string passName = PassName.Text.Trim();
            string password = Password.Text.Trim();
            string passTb = PassportTb.Text.Trim();
            string passAd = PassAd.Text.Trim();
            string phoneTb = PhoneTb.Text.Trim();

            if (password == "" || passAd == "" || passName == "" || passTb == "" || phoneTb == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "INSERT INTO PassengerTbl VALUES('" + passName + "','" + password + "','" + passTb + "','" + passAd + "','" + PassNat.SelectedItem.ToString() + "','" + PassGend.SelectedItem.ToString() + "','" + phoneTb + "')";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
                    reset();
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
        public void reset()
        {
            Password.Text = "";
            PassAd.Text = "";
            PassName.Text = "";
            PassNat.Text = "";
            PassGend.Text = "";
            PassportTb.Text = "";
            PhoneTb.Text = "";
        }
    }
}
