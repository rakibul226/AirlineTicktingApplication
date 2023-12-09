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
    public partial class AllTicket : Form
    {
        public AllTicket()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            new RemoveTicket().Show();
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
            new AddNewTicket().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UpdateFlight2().Show();
            this.Hide();
        }
    }
}
