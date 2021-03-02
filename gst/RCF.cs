using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlServerCe;

namespace gst
{
    public partial class RCF : Form
    {
        public RCF()
        {
            InitializeComponent();
        }

        private void RCF_Load(object sender, EventArgs e)
        {

            try
            {
                String no = "#RET-INV-" + Payments.com;
                MessageBox.Show(no);
                String q1 = "SELECT * FROM [Retainer_Invoice_De] where [Ref]='" + no + "'";
                // String q1 = "SELECT  Est_Details.Date,Estimates.Cust_name, Est_Details.Expire_date, Est_Details.Items, Est_Details.Qty, Est_Details.Rate, Est_Details.Amt, Est_Details.Sub_Total, Est_Details.Discount,Est_Details.Adjustment, Est_Details.Total, Estimates.Cust_name, Est_Details.Ref FROM Est_Details INNER JOIN Estimates ON Est_Details.Total = Estimates.Amount where  Est_Details.[Ref]=" + no + "";
                SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
                SqlCeCommand cmd = new SqlCeCommand();
                SqlCeDataAdapter sad = new SqlCeDataAdapter();
                DataSet dt = new DataSet();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = q1;
                sad.SelectCommand = cmd;
                sad.Fill(dt,"Table[0]");
                RET r = new RET();
                r.Database.Tables["Retainer_Invoice_De"].SetDataSource(dt.Tables[0]);
                rptviwer.ReportSource = null;
                rptviwer.ReportSource = r;


                //ReportDocument crystal = new ReportDocument();
                ////string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                ////// MessageBox.Show(path);
                ////path = System.IO.Directory.GetParent(System.IO.Directory.GetParent(path).ToString()).ToString();
                //////MessageBox.Show(path);
                ////path = System.IO.Path.Combine(path, "RET.rpt");
                //////MessageBox.Show(path);
                //crystal.Load("C:\\VensarkBill\\Rest\\RET.rpt");
                //crystal.SetDataSource(dt);
                //rptviwer.ReportSource = crystal;
                //rptviwer.Refresh();

            }
            catch (Exception o)
            {
                MessageBox.Show("Erorr " + o);
            }
           
        }
    }
}
