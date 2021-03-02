using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using CrystalDecisions.CrystalReports.Engine;

namespace gst
{
    public partial class BARGEN : Form
    {
        public BARGEN()
        {
            InitializeComponent();
        }

        private void BARGEN_Load(object sender, EventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string ma = Items.barco;
            string noof = Items.noof;
            MessageBox.Show("Ma"+ma+" noof"+noof);
            String q2 = "SELECT * from goods where [Barcode]='" + ma + "'";
            for (int i = 1; i < int.Parse(noof);i++ )
            {
               q2 = q2 + "Union all SELECT * from goods where [Barcode]='" + ma + "'";
               
            }
            SqlCeDataAdapter sad = new SqlCeDataAdapter(q2, con);
            DataSet dt = new DataSet();
            sad.Fill(dt, "goods");
            Barcode b = new Barcode();
            //  ReportDocument crystal = new ReportDocument();
            b.Database.Tables["goods"].SetDataSource(dt.Tables[0]);
            //crystal.SetDataSource(dt);
            // crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = b;
        

        }
    }
}
