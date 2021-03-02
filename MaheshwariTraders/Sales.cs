using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace MaheshwariTraders
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);

        private void Sales_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Sales  order by [Sales_OrderID] Asc", con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
            con.Close();

            metroGrid1.Columns[0].Width = 100;
            metroGrid1.Columns[1].Width = 250;
            metroGrid1.Columns[2].Width = 100;
            metroGrid1.Columns[3].Width = 100;
            metroGrid1.Columns[4].Width = 100;
            metroGrid1.Columns[5].Width = 100;
        }

        private void metroGrid1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Product_Name, Variety,Lot_No,Rate, Quantity, Total FROM Sales_Products where Sales_OrderID='" + metroGrid1.CurrentRow.Cells[0].Value.ToString() + "'", con);
            DataTable productallocation = new DataTable();
            sda.Fill(productallocation);
            metroGrid2.DataSource = productallocation;

            metroGrid2.Columns[0].HeaderText = "Product Name";
            metroGrid2.Columns[1].HeaderText = "Variety";
            metroGrid2.Columns[2].HeaderText = "Lot_No";
            metroGrid2.Columns[3].HeaderText = "Rate";
            metroGrid2.Columns[4].HeaderText = "Quanity";
            metroGrid2.Columns[5].HeaderText = "Total";
            //metroGrid2.Columns[6].HeaderText = "VAT";
            //metroGrid2.Columns[7].HeaderText = "VAT_Amount";
           // metroGrid2.Columns[4].HeaderText = "Total";

            metroGrid2.Columns[0].Width = 100;
            metroGrid2.Columns[1].Width = 100;
            metroGrid2.Columns[2].Width = 100;
            metroGrid2.Columns[3].Width = 100;
            metroGrid2.Columns[4].Width = 100;
            metroGrid2.Columns[5].Width = 100;
            //metroGrid2.Columns[6].Width = 50;
            //metroGrid2.Columns[7].Width = 50;
           // metroGrid2.Columns[4].Width = 100;
            con.Close();
        }




    }
}
