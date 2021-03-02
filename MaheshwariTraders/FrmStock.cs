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
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);

        private void FrmStock_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select product,quantity from Inlet_Inventery",con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds, "Inlet_Inventery");
            metroGrid1.DataSource = ds.Tables[0];
            con.Close();

            metroGrid1.Columns[0].HeaderText = "Product Name";
            metroGrid1.Columns[0].Width = 200;
            metroGrid1.Columns[1].HeaderText = "Quantity";
            metroGrid1.Columns[1].Width = 100;

            SqlCommand cm = new SqlCommand("select Product_Name from Products", con);
            con.Open();
            SqlDataReader sdr = cm.ExecuteReader();

            while (sdr.Read())
            {
                cmbproduct.Items.Add(sdr["Product_Name"]);
            }

            con.Close();


            SqlCommand cmd1 = new SqlCommand("select Plant_Name,Variety,Lot_No,Total_Stock,Available,Reserved,Rate from stock",con);
            con.Open();
            SqlDataAdapter adp1 = new SqlDataAdapter();
            adp1.SelectCommand = cmd1;
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1,"Stock");
            metroGrid2.DataSource = ds1.Tables[0];
            con.Close();

            metroGrid2.Columns[0].HeaderText = "Plant Name";
            metroGrid2.Columns[0].Width = 100;
            metroGrid2.Columns[1].HeaderText = "Variety";
            metroGrid2.Columns[1].Width = 200;
            metroGrid2.Columns[2].HeaderText = "Lot_No";
            metroGrid2.Columns[2].Width = 100;
            metroGrid2.Columns[3].HeaderText = "Total Stock";
            metroGrid2.Columns[3].Width = 100;
            metroGrid2.Columns[5].HeaderText = "Advance";
            metroGrid2.Columns[5].Width = 100;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd11 = new SqlCommand("insert into Stock(Plant_Name,Variety,Lot_No,Total_Stock,Available,Reserved,Rate,limit) values ('" + cmbproduct.Text + "', '" + txtvarierty.Text + "', '" + TxtLot.Text + "', '" + txtTotalStock.Text  + "','" + TxtAvail.Text  + "', '" + TxtReserved.Text  + "' , '" + TxtRate.Text  + "', '" + "0" + "')", con);
            cmd11.ExecuteNonQuery();
            MessageBox.Show("Saved ");
            con.Close();
            //==========================
           
        }

        private void TxtDetails_Click(object sender, EventArgs e)
        {

        }

       
    }
}
