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
    public partial class RemoveTicket : Form
    {
        public RemoveTicket()
        {
            InitializeComponent();
        }

        private void RemoveTicket_Load(object sender, EventArgs e)
        {
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=ROG-531GT\SQLEXPRESS;Initial Catalog=AirTickting;Integrated Security=True");
        public string SUser = GlobalVariablesClass.VariableOne;

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
            new AllTicket().Show();
            this.Hide();
        }

        private void AvaibleTicketShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Flight.Text = AvaibleTicketShow.SelectedRows[0].Cells[0].Value.ToString();
            Flight.ReadOnly = true;

            From.Text = AvaibleTicketShow.SelectedRows[0].Cells[1].Value.ToString();
            From.ReadOnly = true;

            To.Text = AvaibleTicketShow.SelectedRows[0].Cells[2].Value.ToString();
            To.ReadOnly = true;

            Date.Text = AvaibleTicketShow.SelectedRows[0].Cells[3].Value.ToString();
            Date.ReadOnly = true;

            Seat.Text = AvaibleTicketShow.SelectedRows[0].Cells[4].Value.ToString();
            Seat.ReadOnly = true;
    }

        private void resetField()
        {
            Flight.Text = "";
            From.Text = "";
            To.Text = "";
            Date.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetField();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string flight = Flight.Text;

            if (flight == "")
            {
                MessageBox.Show("Missing Flight information");
            }
            else
            {
                AddToCancleTable();
                DeleteFlight();

            }
        }


        private void AddToCancleTable()
        {
            Con.Open();
            string query = "insert into CanceledFlight values('" + Flight.Text + "','" + From.Text + "','" + To.Text + "','" + Date.Text + "','" + Seat.Text + "','" + SUser + "')";

            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
           // MessageBox.Show("New flight added");
            Con.Close();
        }

        private void DeleteFlight()
        {
            string flight = Flight.Text;
            try
            {
                Con.Open();
                string query = "DELETE FROM FlightTbl WHERE Flight = '" + flight + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Flight Deleted Successfully");
                Con.Close();
                populate();
                resetField();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }


       
    }
}
