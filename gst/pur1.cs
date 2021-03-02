using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlServerCe;
namespace gst
{
    public partial class pur1 : Form
    {
        public pur1()
        {
            InitializeComponent();
        }

        private void pur1_Load(object sender, EventArgs e)
        {
            try
            {
                string s =PurchaseOrder.abdef;
                MessageBox.Show(s);
                string q1 = "SELECT * FROM [pur_detail] where Purchase_orderID='" + s + "'";
                SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
                SqlCeCommand cmd1 = new SqlCeCommand();
                SqlCeDataAdapter sad = new SqlCeDataAdapter();
                DataSet dt = new DataSet();
                con.Open();
                cmd1.Connection = con;
                cmd1.CommandText = q1;
                sad.SelectCommand = cmd1;
                sad.Fill(dt,"Table[0]");
                POR p = new POR();
                p.Database.Tables["pur_detail"].SetDataSource(dt.Tables[0]);
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = p;

              
            }
            catch (Exception exc1)
            {
                MessageBox.Show("" + exc1);
            }
        }
    }
}
