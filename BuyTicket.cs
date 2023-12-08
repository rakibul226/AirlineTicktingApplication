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
    public partial class BuyTicket : Form
    {
        public BuyTicket()
        {
            InitializeComponent();
        }

        private void SUser_Click(object sender, EventArgs e)
        {
            
        }


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
            
                Flight.Text = "";
                From.Text = "";
                To.Text = "";
                Date.Text = "";     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Flight.Text == "" && From.Text == "" && To.Text == "" && Date.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if(Flight.Text == "" && From.Text == "" && To.Text == "" && Date.Text == "" && Seat.Text == "")
            {

                MessageBox.Show("Enter seat number");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BookedTicket values('" + Flight.Text + "','" + From.Text + "','" + To.Text + "','" + Date.Text + "','" + Seat.Text + "','"+ Customer + "')";

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
