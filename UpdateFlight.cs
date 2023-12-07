﻿using System;
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
    public partial class UpdateFlight : Form
    {
        public UpdateFlight()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=ROG-531GT\SQLEXPRESS;Initial Catalog=AirTickting;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from FlightTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UpdateTicketShow.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void UpdateFlight_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            new AllTicket().Show();
            this.Hide();
        }
        private void AvaibleTicketShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Flight.Text = UpdateTicketShow.SelectedRows[0].Cells[0].Value.ToString();
            From.Text = UpdateTicketShow.SelectedRows[0].Cells[1].Value.ToString();
            To.Text = UpdateTicketShow.SelectedRows[0].Cells[2].Value.ToString();
            Date.Text = UpdateTicketShow.SelectedRows[0].Cells[3].Value.ToString();
           // Seat.Text = AvaibleTicketShow.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}