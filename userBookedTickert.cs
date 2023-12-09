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
    public partial class UserBookedTickert : Form
    {
        public UserBookedTickert()
        {
            InitializeComponent();
        }
        //public string S_customer = "asus";
        public string S_customer =  GlobalVariablesClass.VariableOne ;

        private void userBookedTickert_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            using (SqlConnection Con = new SqlConnection(@"Data Source=ROG-531GT\SQLEXPRESS;Initial Catalog=AirTickting;Integrated Security=True"))
            {
                Con.Open();

                string query = "select * from BookedTicket WHERE Customer like @customer";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@customer", "%" + S_customer + "%");

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    userBookedTicket.DataSource = ds.Tables[0];
                }

                Con.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            UserHome newHome = new UserHome();
            newHome.Show();
            this.Hide();
        }

        private void userBookedTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Flight.Text = userBookedTicket.SelectedRows[0].Cells[0].Value.ToString();
            Flight.ReadOnly = true;

            From.Text = userBookedTicket.SelectedRows[0].Cells[1].Value.ToString();
            From.ReadOnly = true;

            To.Text = userBookedTicket.SelectedRows[0].Cells[2].Value.ToString();
            To.ReadOnly = true;

            Date.Text = userBookedTicket.SelectedRows[0].Cells[3].Value.ToString();
            Date.ReadOnly = true;

            Seat.Text = userBookedTicket.SelectedRows[0].Cells[4].Value.ToString();
            Seat.ReadOnly = true;
        }

        private void resetField()
        {
            Flight.Text = "";
            From.Text = "";
            To.Text = "";
            Date.Text = "";
            Seat.Text = "";
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
                resetField();

            }
        }


        SqlConnection Con = new SqlConnection(@"Data Source=ROG-531GT\SQLEXPRESS;Initial Catalog=AirTickting;Integrated Security=True");
        public string SUser = GlobalVariablesClass.VariableOne;

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
                string query = "DELETE FROM BookedTicket WHERE Flight = '" + flight + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ticked Canceled Successfully");
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
