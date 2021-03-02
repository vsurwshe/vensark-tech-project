using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace MaheshwariTraders
{
    public partial class Daily_Sowing : Form
    {
        public Daily_Sowing()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);
        private void Advance_Booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hirkani_Advance_Booking.Advance_Booking' table. You can move, or remove it, as needed.
            //this.advance_BookingTableAdapter.Fill(this.hirkani_Advance_Booking.Advance_Booking);

            SqlCommand cmd = new SqlCommand("select * from Daily_Sowing where Germination='" + "No" + "'", con);
            con.Open();
            //cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds, "Daily_Sowing");
            dataGridView1.DataSource = ds.Tables[0];

            con.Close();

            dataGridView1.Columns[1].HeaderText = "Plant";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[8].HeaderText = "Shorting Date";
            dataGridView1.Columns[8].Width = 100;
            dataGridView1.Columns[9].HeaderText = "Total Plants";
            dataGridView1.Columns[9].Width = 100;
            dataGridView1.Columns[10].HeaderText = "Germination";
            dataGridView1.Columns[10].Width = 110;
            dataGridView1.Columns[11].HeaderText = "Advance Bill No.";
            dataGridView1.Columns[11].Width = 100;



        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Daily_Sowing_Entry aa = new Daily_Sowing_Entry();
            aa.ShowDialog();
            //this.advance_BookingTableAdapter.Fill(this.hirkani_Advance_Booking.Advance_Booking);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Daily_Sowing_Entry aa = new Daily_Sowing_Entry();
            aa.ShowDialog();
            SqlCommand cmd = new SqlCommand("select * from Daily_Sowing where Germination='" + "No" + "'", con);
            con.Open();
            //cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds, "Daily_Sowing");
            dataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Germination g = new Germination();
            g.ShowDialog();
            SqlCommand cmd = new SqlCommand("select * from Daily_Sowing where Germination='" + "No" + "'", con);
            con.Open();
            //cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds, "Daily_Sowing");
            dataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }
    }
}
