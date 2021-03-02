using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;
namespace MaheshwariTraders
{
    public partial class FrmAdvance1 : Form
    {
        public FrmAdvance1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);

        private void FrmAdvance1_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Booking", con);
            DataSet viewproducts = new DataSet();
            sda.Fill(viewproducts, "Booking");
            metroGrid1.DataSource = viewproducts.Tables[0];
            con.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FrmAdvance f = new FrmAdvance();
            f.ShowDialog();

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Booking", con);
            DataSet viewproducts = new DataSet();
            sda.Fill(viewproducts, "Booking");
            metroGrid1.DataSource = viewproducts.Tables[0];
            con.Close();
        }
        public static String no="";
        public static String name="";

        private void metroGrid1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FrmRptAdvBill fab = new FrmRptAdvBill();
            no = metroGrid1.SelectedRows[0].Cells[3].Value.ToString();
            name = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
            fab.ShowDialog();
        }

       

    }
}
