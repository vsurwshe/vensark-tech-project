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
    public partial class INV_REF : Form
    {
        public INV_REF()
        {
            InitializeComponent();
        }

        private void INV_REF_Load(object sender, EventArgs e)
        {
           7try {
                String no = "#LAX-" + Payments.com;
                String nam = Invoice.nam;
                MessageBox.Show("Inoice No:-"+no+"\n Name:-"+nam);
                String q1 = "SELECT * from Invoice_Dei where So_no='" + no + "'";
                String q2 = "SELECT * from Inv_Tax where Inv_Id='" + no + "'";
                String q3 = "SELECT * from customer  where [First_name]='" + nam+ "'";
                // String q1 = "SELECT  Est_Details.Date,Estimates.Cust_name, Est_Details.Expire_date, Est_Details.Items, Est_Details.Qty, Est_Details.Rate, Est_Details.Amt, Est_Details.Sub_Total, Est_Details.Discount,Est_Details.Adjustment, Est_Details.Total, Estimates.Cust_name, Est_Details.Ref FROM Est_Details INNER JOIN Estimates ON Est_Details.Total = Estimates.Amount where  Est_Details.[Ref]=" + no + "";
                SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
                SqlCeCommand cmd = new SqlCeCommand();
                SqlCeDataAdapter sad = new SqlCeDataAdapter();
                DataSet dt = new DataSet();
                con.Open();
                sad.SelectCommand = cmd;
                cmd.Connection = con;
                cmd.CommandText = q1;
                sad.Fill(dt,"Table[0]");
                cmd.CommandText = q2;
                sad.Fill(dt,"Table[1]");
                cmd.CommandText = q3;
                sad.Fill(dt, "Table[2]");
                sad.Dispose();
                cmd.Dispose();

                inv i = new inv();
                //inv1b2 i = new inv1b2();
                i.Database.Tables["Invoice_Dei"].SetDataSource(dt.Tables[0]);
                i.Database.Tables["Inv_Tax"].SetDataSource(dt.Tables[1]);
                i.Database.Tables["customer"].SetDataSource(dt.Tables[2]);
                //ReportDocument crystal = new ReportDocument();
                rptviewer.ReportSource = null;
                rptviewer.ReportSource = i;
               // rptviewer.Refresh();
               
               
               //dt.Tables[0].Merge(dt.Tables[1]);
               // dt.Tables[0].Merge(dt.Tables[1]);
             
              //  string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                // MessageBox.Show(path);
               //string path = Application.StartupPath;
              // string path = System.Windows.Forms.Application.StartupPath.Substring(0, System.Windows.Forms.Application.StartupPath.Substring(0, System.Windows.Forms.Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
               //path += @"\inv.rpt"; 
                //MessageBox.Show(path);
              // path = System.IO.Directory.GetParent(System.IO.Directory.GetParent(path).ToString()).ToString();
                //MessageBox.Show(path);
               //path=@"C:\VensarkBill\";
              //  path = System.IO.Path.Combine(path, "inv.rpt");
                //MessageBox.Show(path);
               // crystal.Load("C:\\VensarkBilling\\rest\\inv.rpt");
               //crystal.Load(path);

               //crystal.Database.Tables[0].SetDataSource(dt.Tables[0]);
               //crystal.Database.Tables[1].SetDataSource(dt.Tables[1]);
              // crystal.SetDataSource(dt.Tables[0]);
               
                      
            }
            catch (Exception o) {
                MessageBox.Show("Erorr "+o);
            }
           

        }

        private void rptviewer_Load(object sender, EventArgs e)
        {

        }
    }
}
