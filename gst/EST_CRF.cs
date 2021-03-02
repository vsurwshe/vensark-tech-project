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
    public partial class EST_CRF : Form
    {
        public EST_CRF()
        {
            InitializeComponent();
        }

        private void EST_CRF_Load(object sender, EventArgs e)
        {
            //try {

                String no = Estimates.Sr;
                String nam = Estimates.nam;
                MessageBox.Show(no);
                String q1 = "SELECT * from Est_Details where [Ref]=" + no + "";
                String q3 = "SELECT * from customer  where [First_name]='" + nam + "'";
                // String q1 = "SELECT  Est_Details.Date,Estimates.Cust_name, Est_Details.Expire_date, Est_Details.Items, Est_Details.Qty, Est_Details.Rate, Est_Details.Amt, Est_Details.Sub_Total, Est_Details.Discount,Est_Details.Adjustment, Est_Details.Total, Estimates.Cust_name, Est_Details.Ref FROM Est_Details INNER JOIN Estimates ON Est_Details.Total = Estimates.Amount where  Est_Details.[Ref]=" + no + "";
                SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
                SqlCeCommand cmd = new SqlCeCommand();
                SqlCeDataAdapter sad = new SqlCeDataAdapter();
                DataSet dt= new DataSet();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = q1;
                sad.SelectCommand = cmd;
                sad.Fill(dt,"Table[0]");
                cmd.CommandText = q3;
                sad.Fill(dt, "Table[1]");
                est es = new est();
                es.Database.Tables["Est_Details"].SetDataSource(dt.Tables[0]);
                es.Database.Tables["customer"].SetDataSource(dt.Tables[1]);
                rptviewer.ReportSource = null;
                rptviewer.ReportSource = es;

                //ReportDocument crystal = new ReportDocument();
                ////string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                ////// MessageBox.Show(path);
                ////path = System.IO.Directory.GetParent(System.IO.Directory.GetParent(path).ToString()).ToString();
                //////MessageBox.Show(path);
                ////path = System.IO.Path.Combine(path, "est.rpt");
                ////MessageBox.Show(path);
                //crystal.Load("C:\\VensarkBill\\Rest\\est.rpt");
                //crystal.SetDataSource(dt);
                //rptviewer.ReportSource = crystal;
                //rptviewer.Refresh();
            
            //}catch(Exception o){
            //    MessageBox.Show("Erorr " + o);
            //}
            

        }
    }
}
