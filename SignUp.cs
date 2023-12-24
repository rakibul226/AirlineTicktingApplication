using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace TicktingApplication
{
    public partial class SignUp : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=ROG-531GT\SQLEXPRESS;Initial Catalog=AirTickting;Integrated Security=True");

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
                if (!IsValidPassword(password))
                {
                    MessageBox.Show("Password must be at least 8 characters long and contain a special character and a number");
                    return;
                }

                try
                {
                    Con.Open();

                    string query = "INSERT INTO PassengerTbl VALUES('" + passName + "','" + password + "','" + passTb + "','" + passAd + "','" + PassNat.SelectedItem.ToString() + "','" + PassGend.SelectedItem.ToString() + "','" + phoneTb + "')";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
                    Reset();
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
            Reset();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        public void Reset()
        {
            Password.Text = "";
            PassAd.Text = "";
            PassName.Text = "";
            PassNat.SelectedItem = null;
            PassGend.SelectedItem = null;
            PassportTb.Text = "";
            PhoneTb.Text = "";
        }

        private bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;

            if (!password.Contains('@'))
                return false;

            if (!password.Any(char.IsDigit))
                return false;

            return true;
        }
    }
}
