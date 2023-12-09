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
    public partial class AdminViewAllTicket : Form
    {
        public AdminViewAllTicket()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminRemoveFlight().Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            new AdminHome().Show();
            this.Hide();
        }

        private void AllTicket_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AdminAddNewTicket().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminUpdateFlight2().Show();
            this.Hide();
        }
    }
}
