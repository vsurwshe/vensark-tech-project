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
    public partial class billrp : Form
    {
        public billrp()
        {
            InitializeComponent();
        }

        private void billrp_Load(object sender, EventArgs e)
        {
            try
            {
                string s = "#BILLNO-" + PaymentMain.com;
                String nam = BillsMain.nam;
                MessageBox.Show(s);
                string q1 = "SELECT * FROM bill_detail where Ref='" + s + "'";
                String q2 = "SELECT * from Bill_Tax where ref='" + s + "'";
                String q3 = "SELECT * from vendor  where [Shop_name]='" + nam + "'";
                SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
                SqlCeCommand cmd1 = new SqlCeCommand();
                SqlCeDataAdapter sad = new SqlCeDataAdapter();
                DataSet dt = new DataSet();
                con.Open();
                cmd1.Connection = con;
                cmd1.CommandText = q1;
                sad.SelectCommand = cmd1;
                sad.Fill(dt,"Table[0]");
                cmd1.CommandText = q2;
                sad.SelectCommand = cmd1;
                sad.Fill(dt, "Table[1]");
                cmd1.CommandText = q3;
                sad.SelectCommand = cmd1;
                sad.Fill(dt, "Table[2]");
                sad.Dispose();
                cmd1.Dispose();
                billrpt b = new billrpt();
               // billrpt1 b = new billrpt1();
                b.Database.Tables["bill_detail"].SetDataSource(dt.Tables[0]);
                b.Database.Tables["Bill_Tax"].SetDataSource(dt.Tables[1]);
                b.Database.Tables["vendor"].SetDataSource(dt.Tables[2]);
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = b;




                //ReportDocument crystal = new ReportDocument();
                //string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                //path = System.IO.Directory.GetParent(System.IO.Directory.GetParent(path).ToString()).ToString();
                //path = System.IO.Path.Combine(path, "billrpt.rpt");
                //crystal.Load("C:\\VensarkBilling\\rest\\billrpt.rpt");
                //crystal.SetDataSource(dt);
                //crystalReportViewer1.ReportSource = crystal;
                //crystalReportViewer1.Refresh();
            }
            catch(Exception exc1)
            {
                MessageBox.Show("" + exc1);
            }
        }
    }
}
