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

        private void userBookedTickert_Load(object sender, EventArgs e)
        {
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ROG-531GT\SQLEXPRESS;Initial Catalog=AirTickting;Integrated Security=True");
        //public string S_customer =  GlobalVariablesClass.VariableOne ;
        public string S_customer =  "user";
        private void populate()
        {
            Con.Open();

            string query = "select * from BookedTicket WHERE Customer =" + S_customer + "";

            //string query = "select * from BookedTicket WHERE Customer = '" + S_customer + "'";
            //string query = "select * from BookedTicket";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            userBookedTicket.DataSource = ds.Tables[0];
            Con.Close();
        }
    }
}
