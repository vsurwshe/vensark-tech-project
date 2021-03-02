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
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);
        private void Master_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select Product_Name from Products",con);
            con.Open();
            SqlDataReader sdr = cm.ExecuteReader();

            while (sdr.Read())
            {
                mtxtproduct1.Items.Add(sdr["Product_Name"]);
            }

            con.Close();


            SqlCommand cm1 = new SqlCommand("select product, quantity from Inlet_Inventery", con);
            con.Open();
            SqlDataReader sdr1 = cm1.ExecuteReader();

            while (sdr1.Read())
            {
                mcmbproduct.Items.Add(sdr1["Product"]);
            }

            con.Close();
            

            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select product, quantity from Inlet_Inventery", con);
            DataSet viewproducts = new DataSet();
            sda1.Fill(viewproducts);
            metroGrid3.DataSource = viewproducts.Tables[0];
            con.Close();
            metroGrid3.Columns[1].Width = 150;



            con.Open();
            SqlDataAdapter sda12 = new SqlDataAdapter("select ProductID,Product_Name from Products", con);
            DataSet viewproducts22 = new DataSet();
            sda12.Fill(viewproducts22);
            metroGrid2.DataSource = viewproducts22.Tables[0];
            con.Close();
            metroGrid2.Columns[1].Width = 150;



        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(products.Text != ""){
                SqlCommand cmd = new SqlCommand("insert into Products(Product_Name) values('" + products.Text + "') ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Product Saved Successfully");
                id.Text = "";
                products.Text = "";
                this.Close();
                Master mm = new Master();
                mm.Show();
                SqlDataAdapter sda1 = new SqlDataAdapter("select ProductID,Product_Name from Products", con);
                DataSet viewproducts = new DataSet();
                sda1.Fill(viewproducts);
                metroGrid2.DataSource = viewproducts.Tables[0];
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Proper Values in Above Text Box");
            }
            

        }

        private void mcmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (mtxtproduct1.Text != "" && mcmbid.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Delete from Products where Product_Name='" + mtxtproduct1.Text + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete Successful");
                mtxtproduct1.SelectedIndex = 0;
                mcmbid.Text = "";
                this.Close();
                Master mm = new Master();
                mm.Show();
            }
            else {
                MessageBox.Show("Please Enter Proper Values in Above Text Box");
            }

           
        }

        private void mtxtproduct1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select ProductID from Products where Product_Name='" + mtxtproduct1.Text + "'", con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            mcmbid.Text = ds.Tables[0].Rows[0][0].ToString();
            con.Close();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if(mtxtPName.Text !=""){
                SqlCommand cmd = new SqlCommand("insert into Inlet_Inventery(product,quantity) values('" + mtxtPName.Text + "','" + 0 + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Save Sucessfully");
                mtxtPID.Text = "";
                mtxtPName.Text = "";
                this.Close();
                Master mm = new Master();
                mm.Show();

                con.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter("select product,quantity from Inlet_Inventery", con);
                DataSet viewproducts = new DataSet();
                sda1.Fill(viewproducts);
                metroGrid3.DataSource = viewproducts.Tables[0];
                con.Close();

            }else{
            MessageBox.Show("Please Enter Proper Values In Above Text");
            }
            
           
           
           
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if( mcmbproduct.Text !="" && mtxtid1.Text !=""){
                SqlCommand cmd = new SqlCommand("delete from Inlet_Inventery where Product='" + mcmbproduct.Text + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete operation Successfully");
                mcmbproduct.SelectedIndex = 0;
                mtxtid1.Text = "";
                this.Close();
                Master mm = new Master();
                mm.Show();
            }
            else {
                MessageBox.Show("Please Enter Proper Values in Above Text Box");
            }
            
            
        }

        private void mcmbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select id from Inlet_Inventery where Product='" + mcmbproduct.Text + "'", con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            mtxtid1.Text = ds.Tables[0].Rows[0]["id"].ToString();
            con.Close();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Add_Customer ac = new Add_Customer();
            ac.ShowDialog();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            FrmMasterShop frm = new FrmMasterShop();
            frm.ShowDialog();
        }
    }
}
