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
    public partial class Stock_Status : MetroForm
    {
        public Stock_Status()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);

        private void Stock_Status_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = false;
            
            // TODO: This line of code loads data into the 'brandDataSet1.Brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.brandDataSet1.Brands);

            brandname.SelectedIndex = brandname.FindStringExact("");

            

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Stock_View(Product_Name, Quantity, Free_Quantity, Total_Quantity,Brand) select Product_Name, Quantity, Free_Quantity, Total_Quantity,Brand from Products where Brand='"+brandname.Text+"'", con);
            cmd.ExecuteNonQuery();

            con.Close();

            crystalReportViewer1.RefreshReport();
            crystalReportViewer1.Visible = true;
        }

        private void brandname_SelectedIndexChanged(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = false;

            con.Open();
            SqlCommand cmd4 = new SqlCommand("delete Stock_View", con);
            cmd4.ExecuteNonQuery();
            con.Close();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
        }
    }
}
