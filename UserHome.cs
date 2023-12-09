using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicktingApplication
{
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserBuyTicket newTicket = new UserBuyTicket();
            newTicket.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new UserAvaliableFlight().Show();
            this.Hide();
        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            SUser.Text =  GlobalVariablesClass.VariableOne ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserBookedTickert newUserBTbl = new UserBookedTickert();
            newUserBTbl.Show();
            this.Hide();
        }
    }
}
