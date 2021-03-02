using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;
namespace MaheshwariTraders
{
    public partial class FrmDashBoard : Form
    {
        public FrmDashBoard()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);

        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hirkaniDataSet1.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter1.Fill(this.hirkaniDataSet1.Stock);
            // TODO: This line of code loads data into the 'rawStockDataset.Inlet_Inventery' table. You can move, or remove it, as needed.
            this.inlet_InventeryTableAdapter.Fill(this.rawStockDataset.Inlet_Inventery);
            // TODO: This line of code loads data into the 'stockDataset.Stock' table. You can move, or remove it, as needed.
            //this.Fill(this.stockDataset.Stock);
            SqlCommand cmd = new SqlCommand("select SUM(Remaining) from Sales",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            balance.Text = dr[0].ToString();
            con.Close();


            SqlCommand cmd1 = new SqlCommand("select SUM(Paid) from Sales", con);
            con.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            dr1.Read();
            //received.Text = dr1[0].ToString();
            con.Close();

            SqlCommand cmd2 = new SqlCommand("select SUM(Total) from Sales", con);
            con.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            dr2.Read();
            //total.Text = dr2[0].ToString();
            con.Close();

            SqlCommand cmd3 = new SqlCommand("select * from Inlet_Inventery",con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd3;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
            con.Close();

            con.Open();
            SqlCommand cmd4 = new SqlCommand("select * from Stock", con);
            SqlDataAdapter adp1 = new SqlDataAdapter();
            adp1.SelectCommand = cmd4;
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1);
            metroGrid2.DataSource = ds1.Tables[0];
            con.Close();

            SqlCommand cmd5 = new SqlCommand("select * from Advance_Sowing where status='"+"Booked"+"'", con);
            con.Open();
            SqlDataAdapter adp5 = new SqlDataAdapter();
            adp5.SelectCommand = cmd5;
            DataSet ds5 = new DataSet();
            adp5.Fill(ds5);
            metroGrid3.DataSource = ds5.Tables[0];
            con.Close();
        }

        private void received_Click(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void balance_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.stockTableAdapter.FillBy(this.stockDataset.Stock);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }
    }
}
