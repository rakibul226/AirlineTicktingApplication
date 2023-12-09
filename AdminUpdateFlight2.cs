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
    public partial class AdminUpdateFlight2 : Form
    {
        public AdminUpdateFlight2()
        {
            InitializeComponent();
        }

        private void UpdateFlight2_Load(object sender, EventArgs e)
        {
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=ROG-531GT\SQLEXPRESS;Initial Catalog=AirTickting;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from FlightTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AvaibleTicketShow2.DataSource = ds.Tables[0];
            Con.Close();
        }

        

        private void AvaibleTicketShow2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Flight2.Text = AvaibleTicketShow2.SelectedRows[0].Cells[0].Value.ToString();
            From2.Text = AvaibleTicketShow2.SelectedRows[0].Cells[1].Value.ToString();
            To2.Text = AvaibleTicketShow2.SelectedRows[0].Cells[2].Value.ToString();
            Date2.Text = AvaibleTicketShow2.SelectedRows[0].Cells[3].Value.ToString();
            Seat2.Text = AvaibleTicketShow2.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Flight2.Text = "";
            From2.Text = "";
            To2.Text = "";
            Date2.Text = "";
            Seat2.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string flight = Flight2.Text;

            if (flight == "")
            {
                MessageBox.Show("Missing Flight information");
            }
            else
            {
                try
                {
                    Con.Open();
                     
                    string query = "update FlightTbl set Flight='" + Flight2.Text + "', [From]='" + From2.Text + "', [To]='" + To2.Text + "', Date='" + Date2.Value.ToString("yyyy-MM-dd") + "', Seat='" + Seat2.Text + "' where Flight='" + flight + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Update Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            new AdminViewAllTicket().Show();
            this.Hide();
        }

        private void Seat2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
