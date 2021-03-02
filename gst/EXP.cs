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
    public partial class EXP : Form
    {
        public EXP()
        {
            InitializeComponent();
        }

        private void EXP_Load(object sender, EventArgs e)
        {
            try
            {
                string s1 = PaymentMain.com;
                MessageBox.Show(s1);
                string q2 = "SELECT * FROM [expenses] where expensesID='" + s1 + "'";
                SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
                SqlCeCommand cmd11 = new SqlCeCommand();
                SqlCeDataAdapter sad = new SqlCeDataAdapter();
                DataSet dt = new DataSet();
                con.Open();
                cmd11.Connection = con;
                cmd11.CommandText = q2;
                sad.SelectCommand = cmd11;
                sad.Fill(dt);
                Exprpt ex = new Exprpt();
               // inv1b2 i = new inv1b2();
                ex.Database.Tables["expenses"].SetDataSource(dt.Tables[0]);
                //ReportDocument crystal = new ReportDocument();
                //string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                //path = System.IO.Directory.GetParent(System.IO.Directory.GetParent(path).ToString()).ToString();
                //path = System.IO.Path.Combine(path, "Exprpt.rpt");
                //crystal.Load("C:\\VensarkBill\\Rest\\Exprpt.rpt");
                //crystal.SetDataSource(dt);
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = ex;
                //crystalReportViewer1.Refresh();
            }
            catch (Exception exc1)
            {
                MessageBox.Show("" + exc1);
            }
        }
    }
}
