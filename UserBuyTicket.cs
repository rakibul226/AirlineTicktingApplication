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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace TicktingApplication
{
    public partial class UserBuyTicket : Form
    {
        public UserBuyTicket()
        {
            InitializeComponent();
        }

        private void SUser_Click(object sender, EventArgs e)
        {
            
        }

        string TDate = DateTime.Today.ToString("dd-MM-yyyy");

        SqlConnection Con = new SqlConnection(@"Data Source=ROG-531GT\SQLEXPRESS;Initial Catalog=AirTickting;Integrated Security=True");
        public string Customer = GlobalVariablesClass.VariableOne;
        private void populate()
        {
            Con.Open();
            string query = "select * from FlightTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AvaibleTicketShow.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void BuyTicket_Load(object sender, EventArgs e)
        {
             
            populate();
            

           


        }

        private void label8_Click(object sender, EventArgs e)
        {
            UserHome newUserHome = new UserHome();
            newUserHome.Show();
            this.Hide();
        }

        private void AvaibleTicketShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Flight.Text = AvaibleTicketShow.SelectedRows[0].Cells[0].Value.ToString();
            From.Text = AvaibleTicketShow.SelectedRows[0].Cells[1].Value.ToString();
            To.Text = AvaibleTicketShow.SelectedRows[0].Cells[2].Value.ToString();
            Date.Text = AvaibleTicketShow.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            reset();
        }

        public void reset()
        {
            Flight.Text = "";
            From.Text = "";
            To.Text = "";
            Date.Text = "";
            Seat.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Flight.Text) || string.IsNullOrEmpty(From.Text) || string.IsNullOrEmpty(To.Text) || string.IsNullOrEmpty(Date.Text))
            {
                MessageBox.Show("Missing Information");
            }
            else if(string.IsNullOrEmpty(Flight.Text) || string.IsNullOrEmpty(From.Text) || string.IsNullOrEmpty(To.Text) || string.IsNullOrEmpty(Date.Text) || !int.TryParse(Seat.Text, out int seatValue))
            {

                MessageBox.Show("Enter seat number");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BookedTicket values('" + Flight.Text + "','" + From.Text + "','" + To.Text + "','" + Date.Text + "','" + Seat.Text + "','"+ Customer + "','"+ TDate + "')";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succeful");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
    }
}
