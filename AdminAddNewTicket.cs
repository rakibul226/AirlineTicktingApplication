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
using System.Xml.Linq;

namespace TicktingApplication
{
    public partial class AdminAddNewTicket : Form
    {
        public AdminAddNewTicket() 
        {

            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=ROG-531GT\SQLEXPRESS;Initial Catalog=AirTickting;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            //if(   Flight.Text == "" || From.Text =="" || To.Text == "" || Date.Text == "" || Seat.Text == "")

             if (string.IsNullOrEmpty(Flight.Text) || string.IsNullOrEmpty(From.Text) || string.IsNullOrEmpty(To.Text)|| string.IsNullOrEmpty(Date.Text) || !int.TryParse(Seat.Text, out int seatValue))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into FlightTbl values('" + Flight.Text + "','" + From.SelectedItem.ToString() + "','" + To.SelectedItem.ToString() + "','" + Date.Value.ToString() + "','" + Seat.Text + "')";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New flight added");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void AddNewTicket_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            new AdminViewAllTicket().Show();
            this.Hide();
        }
    }
}
