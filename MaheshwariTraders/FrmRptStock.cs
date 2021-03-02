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
    public partial class FrmRptStock : Form
    {
        public FrmRptStock()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //crystalReportViewer1.RefreshReport();
        }

        private void FrmRptStock_Load(object sender, EventArgs e)
        { 
            String q1 = "SELECT * FROM [Hirkani].[dbo].[Stock]  where [Total_Stock] > 0";
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sad = new SqlDataAdapter();
            DataSet dt = new DataSet();
            con.Open();
            sad.SelectCommand = cmd;
            cmd.Connection = con;
            cmd.CommandText = q1;
            sad.Fill(dt, "Tables[0]");
            sad.Dispose();
            cmd.Dispose();
            RptStock cr = new RptStock();
            cr.Database.Tables["Stock"].SetDataSource(dt.Tables[0]);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
