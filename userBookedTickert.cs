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
    public partial class userBookedTickert : Form
    {
        public userBookedTickert()
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
    }
}
