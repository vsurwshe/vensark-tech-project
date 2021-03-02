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
    public partial class FrmDailyuse : MetroForm
    {
        public FrmDailyuse()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);
        private void FrmDailyuse_Load(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("select * from Inlet_Inventery",con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd1;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
            con.Close();

            SqlCommand cmd = new SqlCommand(" Select product from Inlet_Inventery",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            //dr.Read();
            while (dr.Read())
            {
                row.Items.Add(dr["product"]);
            }
            con.Close();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (use.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select quantity from Inlet_Inventery Where product='" + row.Text + "'", con);
               
                int ttl = (int)cmd.ExecuteScalar();
                
                con.Close();
                if (Convert.ToInt32(use.Text) > ttl)
                {
                    MessageBox.Show("Remaining Material = " + ttl);
                    use.Text = "0";
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select quantity from Inlet_Inventery Where product='" + row.Text + "'", con);
            con.Open();
            int ttl = (int)cmd.ExecuteScalar();
            int ans = Convert.ToInt32(use.Text);

            int a = ttl - ans;
            //a = Convert.ToInt32(remaining.Text) - Convert.ToInt32(payamt.Text);
            SqlCommand cmd4 = new SqlCommand("update Inlet_Inventery set quantity='" + a + "' where product='"+row.Text+"'", con);
            //con.Open();
            cmd4.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Material Used");
            use.Text = "0";

            SqlCommand cmd1 = new SqlCommand("select * from Inlet_Inventery", con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd1;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            metroGrid1.DataSource = ds.Tables[0];
            con.Close();

        }
    }
}
