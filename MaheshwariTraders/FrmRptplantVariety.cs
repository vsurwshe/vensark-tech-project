using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
namespace MaheshwariTraders
{
    public partial class FrmRptplantVariety : Form
    {
        public FrmRptplantVariety()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);

        private void FrmplantVariety_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Product_Name from Sales_Products group by Product_Name",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                plant.Items.Add(dr[0]);
            }
            con.Close();

            

            crystalReportViewer1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd4 = new SqlCommand("delete Sales_Products_View", con);
            cmd4.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Sales_Products_View(Sales_OrderID,Product_Name,Variety,Lot_No,Rate,Quantity,Total) select Sales_OrderID,Product_Name,Variety,Lot_No,Rate,Quantity,Total from Sales_Products where Variety='" + variety.Text + "' and Product_Name='"+plant.Text+"'", con);
            cmd.ExecuteNonQuery();

            con.Close();

            crystalReportViewer1.RefreshReport();
            crystalReportViewer1.Visible = true;
        }

        private void plant_SelectedIndexChanged(object sender, EventArgs e)
        {
            variety.SelectedItem = null;
            variety.Items.Clear();
            SqlCommand cmd1 = new SqlCommand("select Variety from Sales_Products where Product_Name='" + plant.Text + "' group by Variety", con);
            con.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                variety.Items.Add(dr1[0]);
            }
            con.Close();
        }
    }
}
