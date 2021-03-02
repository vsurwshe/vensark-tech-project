using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MaheshwariTraders
{
    public partial class FrmMasterShop : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);
       
        public FrmMasterShop()
        {
            InitializeComponent();
        }

        private void FrmMasterShop_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select Shop_Name,Mobile from Shops", con);
            DataSet viewproducts = new DataSet();
            sda1.Fill(viewproducts);
            metroGrid2.DataSource = viewproducts.Tables[0];
            con.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Shops(Shop_Name,Mobile) values('" + TxtShop.Text + "','" + TxtMob.Text  + "') ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Shop Saved Successfully");

            TxtMob.Text = "";
            TxtShop.Text = "";

          //  this.Close();
            //Master mm = new Master();
            //mm.MdiParent = new Home_MDI();
            //mm.Dock = DockStyle.Fill;
            //mm.FormClosed += new FormClosedEventHandler(mm_FormClosed);
           // mm.Show();
            //SqlCommand cm = new SqlCommand("select Product_Name from Products", con);
            //con.Open();
            //SqlDataReader sdr = cm.ExecuteReader();

            //while (sdr.Read())
            //{
            //    mtxtproduct1.Items.Add(sdr["Product_Name"]);
            //}

            //con.Close();

            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select Shop_Name,Mobile from Shops", con);
            DataSet viewproducts = new DataSet();
            sda1.Fill(viewproducts);
            metroGrid2.DataSource = viewproducts.Tables[0];
            con.Close();

        }
    }
}
