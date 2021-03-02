using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;

namespace MaheshwariTraders
{
    public partial class Bill_Print : Form
    {
        public Bill_Print()
        {
            InitializeComponent();
        }

        private void Bill_Print_Load(object sender, EventArgs e)
        {
            //crystalReportViewer1.RefreshReport();
            String s = Sales_Bill.sn;
            MessageBox.Show("Your Bill No Is:" + s);
            String q1 = "Select * from Billing where Sales_OrderID='"+s+"'";
            String q2 = "Select * from Sales_Products where Sales_OrderID='" + s + "'";
            String q3 = "Select * from Sales where Sales_OrderID='" + s + "'";
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sad = new SqlDataAdapter();
            DataSet dt = new DataSet();
            con.Open();
            sad.SelectCommand = cmd;
            cmd.Connection = con;
            cmd.CommandText = q1;
            sad.Fill(dt, "Table[0]");
            cmd.CommandText = q2;
            sad.Fill(dt, "Table[1]");
            cmd.CommandText = q3;
            sad.Fill(dt, "Table[2]");
            sad.Dispose();
            cmd.Dispose();
            CrystalReport2 cr = new CrystalReport2();
            cr.Database.Tables["Billing"].SetDataSource(dt.Tables[0]);
            cr.Database.Tables["Sales_Products"].SetDataSource(dt.Tables[1]);
            cr.Database.Tables["Sales"].SetDataSource(dt.Tables[2]);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = cr;






        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
        }
    }
}
