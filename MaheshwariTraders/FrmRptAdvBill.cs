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
    public partial class FrmRptAdvBill : Form
    {
        public FrmRptAdvBill()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
        }

        private void FrmRptAdvBill_Load(object sender, EventArgs e)
        {
            String b = FrmAdvance1.no;
            String na=FrmAdvance1.name;
            MessageBox.Show("Advance Bill No:- "+b+"\n Name:- "+na);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sad = new SqlDataAdapter();
            String sql1 = "Select * From Advance_Billing where Advance_Bill_No='" + b + "'";
            String sql2="Select * From Booking where FarmersName='"+na+"'";
            DataSet dt = new DataSet();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql1;
            sad.SelectCommand = cmd;
            sad.Fill(dt,"Table[0]");
            cmd.CommandText = sql2;
            sad.SelectCommand = cmd;
            sad.Fill(dt, "Table[1]");
            sad.Dispose();
            cmd.Dispose();
            CrystalReport3 c = new CrystalReport3();
            c.Database.Tables["Advance_Billing"].SetDataSource(dt.Tables[0]);
            c.Database.Tables["Booking"].SetDataSource(dt.Tables[1]);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = c;


        }
    }
}
