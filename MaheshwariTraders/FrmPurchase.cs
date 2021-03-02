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
    public partial class FrmPurchase : Form
    {
        public FrmPurchase()
        {
         
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);
        int a, b, ans;
        private void metroButton3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("select quantity from  Inlet_Inventery where product='" + cmbproduct.Text + "'", con);
            con.Open();
            // SqlDataReader dr = cmd.ExecuteReader();
            a = (int)cmd3.ExecuteScalar();
            con.Close();
            //MessageBox.Show(a + "");
            b = Convert.ToInt32(txtqty.Text);
            ans = a + b;
            SqlCommand cmd = new SqlCommand("update Inlet_Inventery set quantity='"+ans.ToString()+"' where product='"+cmbproduct.Text+"'",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved Success");
            txtqty.Text = "";
            cmbproduct.SelectedIndex = 0;

            //==========================
            con.Open();

            SqlCommand cmd11 = new SqlCommand("insert into Purchase_Products(Product_Name, Quantity,Details,Purchase_Date,Shop_Name, Mobile_No,Bill_No,Rate,Total,Grand_Total,Paid,Unpaid) values ('" + cmbproduct.Text + "', '" + txtqty.Text + "', '" + TxtDetails.Text + "' ,convert(date,'" + dt.Text + "',105),'" + shop.Text + "','" + mob.Text + "', '" + bill.Text + "' , '" + rate.Text + "', '" + total.Text + "', '" + gtotal.Text + "' , '" + paid.Text + "', '" + unpaid.Text + "')", con);
            cmd11.ExecuteNonQuery();

            con.Close();
            //==========================
            


            this.Close();
            FrmPurchase ff = new FrmPurchase();
            ff.MdiParent = new Home_MDI();
            ff.Dock = DockStyle.Fill;
            ff.Show();
        }

        private void FrmPurchase_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select product from Inlet_Inventery", con);
            con.Open();
            SqlDataReader sdr = cm.ExecuteReader();

            while (sdr.Read())
            {
                cmbproduct.Items.Add(sdr["product"]);
            }

            con.Close();

            SqlCommand cm2 = new SqlCommand("select Shop_Name from Shops", con);
            con.Open();
            SqlDataReader sdr2 = cm2.ExecuteReader();

            while (sdr2.Read())
            {
                shop.Items.Add(sdr2["Shop_Name"]);
            }

            con.Close();



            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select id,product,quantity from Inlet_Inventery", con);
            DataSet viewproducts = new DataSet();
            sda.Fill(viewproducts);
            metroGrid1.DataSource = viewproducts.Tables[0];
            con.Close();


            metroGrid1.Columns[0].HeaderText = "ID";
            metroGrid1.Columns[0].Width = 100;
            metroGrid1.Columns[1].HeaderText = "Product Name";
            metroGrid1.Columns[1].Width = 200;
            metroGrid1.Columns[2].HeaderText = "Quantity";
            metroGrid1.Columns[2].Width = 100;

            

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void shop_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Mobile  from Shops where Shop_Name='" + shop.Text + "'", con);
            SqlDataReader sdr3 = cmd.ExecuteReader();

            while (sdr3.Read())
            {
                mob.Text = sdr3["Mobile"].ToString();
               
            }
            sdr3.Close();
            con.Close();

        }

        private void total_Click(object sender, EventArgs e)
        {
            double rat = 0, qty = 0,tot;
            rat = double.Parse(rate.Text);
            qty = double.Parse(txtqty.Text);
            tot = rat * qty;
            total.Text = tot.ToString();
            gtotal.Text  = tot.ToString();
        }

        private void unpaid_Click(object sender, EventArgs e)
        {
            double tot = 0, paid2 = 0, tot2;
            tot = double.Parse(gtotal.Text);
            paid2 = double.Parse(paid.Text);
            tot2 = tot - paid2;
            unpaid.Text  = tot2.ToString();
            
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

     
    }
}
