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
    public partial class FrmRptVarietywise : Form
    {
        public FrmRptVarietywise()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);

        private void FrmRptVarietywise_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Variety from Sales_Products group by Variety ",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                variety.Items.Add(dr[0]);
            }
            con.Close();

            crystalReportViewer1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            //con.Open();
            //SqlCommand cmd4 = new SqlCommand("delete Sales_Products_View", con);
            //cmd4.ExecuteNonQuery();
            //con.Close();

            //con.Open();
            //SqlCommand cmd = new SqlCommand("insert into Sales_Products_View(Sales_OrderID,Product_Name,Variety,Lot_No,Rate,Quantity,Total) select Sales_OrderID,Product_Name,Variety,Lot_No,Rate,Quantity,Total from Sales_Products where Variety='" + variety.Text+ "'", con);
            //cmd.ExecuteNonQuery();

            //con.Close();

            //crystalReportViewer1.RefreshReport();
            //crystalReportViewer1.Visible = true;
        }

        private void RptVariety1_InitReport(object sender, EventArgs e)
        {

        }

        private void variety_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd4 = new SqlCommand("delete Sales_Products_View", con);
            cmd4.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Sales_Products_View(Sales_OrderID,Product_Name,Variety,Lot_No,Rate,Quantity,Total) select Sales_OrderID,Product_Name,Variety,Lot_No,Rate,Quantity,Total from Sales_Products where Variety='" + variety.Text + "'", con);
            cmd.ExecuteNonQuery();

            con.Close();

            crystalReportViewer1.RefreshReport();
            crystalReportViewer1.Visible = true;
        }
    }
}
