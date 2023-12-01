using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TicktingApplication
{
    public partial class AddNewTicket : Form
    {
        public AddNewTicket()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=ROG-531GT\SQLEXPRESS;Initial Catalog=AirTickting;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (Fcode.Text == "" || Ffrom.Text == "" || Fto.Text == "" || FDate.Text == "" || Fseat.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into FlightTbl values('" + Fcode.Text + "','" + Ffrom.SelectedItem.ToString() + "','" + Fto.SelectedItem.ToString() + "','" + FDate.Value.ToString() + "','" + Fseat.Text + "')";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New flight added");
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
