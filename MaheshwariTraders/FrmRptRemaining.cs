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
    public partial class FrmRptRemaining : Form
    {
        public FrmRptRemaining()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);

        private void FrmRptRemaining_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd4 = new SqlCommand("delete Sales_View_Customer", con);
            cmd4.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Sales_View_Customer(Sales_OrderID,Distributor_Name,Sales_Date,Total_Products,Total_Quantity,Total,Paid,Remaining) select Sales_OrderID,Distributor_Name,Sales_Date,Total_Products,Total_Quantity,Total,Paid,Remaining from Sales where Distributor_Name='" + textBox1.Text + "' and Remaining>0", con);
            cmd.ExecuteNonQuery();

            con.Close();

            crystalReportViewer1.RefreshReport();
            crystalReportViewer1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmdf = new SqlCommand("SELECT Distributor_Name FROM Sales group by Distributor_Name", con);
            con.Open();
            SqlDataReader reader = cmdf.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
            }
            textBox1.AutoCompleteCustomSource = MyCollection;
            con.Close();
        }
    }
}
