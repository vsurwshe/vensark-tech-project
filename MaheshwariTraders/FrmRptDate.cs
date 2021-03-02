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
    public partial class FrmRptDate : Form
    {
        public FrmRptDate()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmDate_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd4 = new SqlCommand("delete Sales_View_Customer", con);
            cmd4.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Sales_View_Customer(Sales_OrderID,Distributor_Name,Sales_Date,Total_Products,Total_Quantity,Total,Paid,Remaining) select Sales_OrderID,Distributor_Name,Sales_Date,Total_Products,Total_Quantity,Total,Paid,Remaining from Sales where Sales_Date Between convert(date,'" + from.Text + "',105) and convert(date,'" + to.Text + "',105) ", con);
           //cmd.Parameters.AddWithValue("@StartDate", from.Value);
           //cmd.Parameters.AddWithValue("@EndpDate", to.Value);
            //convert(date,'" + from.Text + "',105)
            
            cmd.ExecuteNonQuery();

            con.Close();

            crystalReportViewer1.RefreshReport();
            crystalReportViewer1.Visible = true;
        }
    }
}
