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
    public partial class UserViewCancledTicket : Form
    {
        public UserViewCancledTicket()
        {
            InitializeComponent();
        }

        private void UserViewCancledTicket_Load(object sender, EventArgs e)
        {
            UserCancle();
        }
        string S_User =  GlobalVariablesClass.VariableOne ;


        private void UserCancle()
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
                    CancleByUser.DataSource = ds.Tables[0];
                }

                Con.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            new UserAllTicket().Show();
            this.Show();

        }
    }
}
