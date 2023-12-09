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
    public partial class AdminViewCancledTicket : Form
    {
        public AdminViewCancledTicket()
        {
            InitializeComponent();
        }

        private void AdminViewCancledTicket_Load(object sender, EventArgs e)
        {
            AdminCancle();
            UserCancle();
        }

        public string S_User = "admin";

        private void AdminCancle()
        {
            using (SqlConnection Con = new SqlConnection(@"Data Source=ROG-531GT\SQLEXPRESS;Initial Catalog=AirTickting;Integrated Security=True"))
            {
                Con.Open();

                string query = "select * from CanceledFlight WHERE Canceled_By like @customer";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@customer", "%" + S_User + "%");

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    RemoveByAdmin.DataSource = ds.Tables[0];
                }

                Con.Close();
            }
        }

        //public string S_Admin = "admin";
        private void UserCancle()
        {
            using (SqlConnection Con = new SqlConnection(@"Data Source=ROG-531GT\SQLEXPRESS;Initial Catalog=AirTickting;Integrated Security=True"))
            {
                Con.Open();

                string query = "select * from CanceledFlight WHERE Canceled_By Not like @customer";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@customer", "%" + S_User + "%");

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    CancleByUser.DataSource = ds.Tables[0];
                }

                Con.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            AdminViewOfferedTicket soldTicket = new AdminViewOfferedTicket();
            soldTicket.Show();
            this.Hide();
        }
    }
}
