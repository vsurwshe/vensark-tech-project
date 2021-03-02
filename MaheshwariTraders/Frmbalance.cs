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
    public partial class Frmbalance : MetroForm
    {
        public Frmbalance()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);
        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Product_Name,Variety,Lot_No,Rate,Quantity,Total from Sales_Products where Sales_OrderID='"+billno.Text+"' ",con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
            con.Close();

            //if (customername.Text != "")
            //{
                SqlCommand cmd1 = new SqlCommand("select Distributor_Name,Total,Paid,Remaining from Sales where Sales_OrderID='" + billno.Text + "' ", con);
                con.Open();
                SqlDataReader dr = cmd1.ExecuteReader();
                dr.Read();
                customername.Text = dr[0].ToString();
                total.Text = dr[1].ToString();
                paid.Text = dr[2].ToString();
                remaining.Text = dr[3].ToString();
                con.Close();
                payamt.Enabled = true;
           // }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmbalance_Load(object sender, EventArgs e)
        {

        }

        private void payamt_TextChanged(object sender, EventArgs e)
        {
            if (payamt.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Total from Sales Where Sales_OrderID='" + billno.Text + "'", con);
                SqlCommand cmd1 = new SqlCommand("Select Paid from Sales Where Sales_OrderID='" + billno.Text + "'", con);
                SqlCommand cmd2 = new SqlCommand("Select Remaining from Sales Where Sales_OrderID='" + billno.Text + "'", con);
                int ttl = (int)cmd.ExecuteScalar();
                int pd = (int)cmd1.ExecuteScalar();
                int rm = (int)cmd2.ExecuteScalar();
                con.Close();
                if (Convert.ToInt32(payamt.Text) > rm)
                {
                    MessageBox.Show("Remaining amount = " + rm);
                    payamt.Text = "0";
                }
                
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            int a = 0;
            //a = Convert.ToInt32(remaining.Text) - Convert.ToInt32(payamt.Text);
            SqlCommand cmd4 = new SqlCommand("update Sales set Paid='" + total.Text + "',Remaining='" + a + "'", con);
            con.Open();
            cmd4.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Payement Will be Paid "+total.Text);
            payamt.Text = "0";
            payamt.Enabled = false;
            update.Enabled = false;
        }
    }
}
