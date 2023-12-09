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
    public partial class AdminViewOfferedTicket : Form
    {
        public AdminViewOfferedTicket()
        {
            InitializeComponent();
        }

        private void ViewTicket_Load(object sender, EventArgs e)
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
            AvaibleTicketShow.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            new AdminHome().Show();
            this.Hide();
        }

        private void AvaibleTicketShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSoldTicketView viewTicket = new AdminSoldTicketView();
            viewTicket.Show();
            this.Hide();
        }

        private void ViewCanceledTicket_Click(object sender, EventArgs e)
        {
            new AdminViewCancledTicket().Show();
            this.Hide();
        }
    }
}
