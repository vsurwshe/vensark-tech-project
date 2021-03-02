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
    public partial class Daily_Sowing_Entry : MetroForm
    {
        public Daily_Sowing_Entry()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);

        private void Add_Advance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hirkaniStock.Stock' table. You can move, or remove it, as needed.
            //this.stockTableAdapter.Fill(this.hirkaniStock.Stock);
            createid();
            SqlCommand cmd = new SqlCommand("select Id,Plant,Date,BillNo,Variety,LotNo,TotalSeed,AdvBillNo from Daily_Sowing where Germination='" + "No" + "'", con);
            con.Open();
            //cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds,"Advance_Booking");
            dataGridView1.DataSource = ds.Tables[0];
            
            con.Close();

            SqlCommand cmd1 = new SqlCommand("select Product_Name from Products", con);
            con.Open();
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Product_Name"]);
               
            }
           
            con.Close();

            ////
            SqlCommand cmd11 = new SqlCommand("select product from Inlet_Inventery", con);
            con.Open();
            //metroTextBox1.Items.Clear();
            SqlDataReader dr2 = cmd11.ExecuteReader();
            while (dr2.Read())
            {
                //variety.Items.Add(dr2["product"]);

            }

            con.Close();

            ////////////////

            SqlCommand cmd5 = new SqlCommand("select * from Advance_Sowing where Status='" + "Booked" + "'", con);
            con.Open();
            SqlDataAdapter adp5 = new SqlDataAdapter();
            adp5.SelectCommand = cmd5;
            DataSet ds5 = new DataSet();
            adp5.Fill(ds5);
            dataGridView2.DataSource = ds5.Tables[0];
            con.Close();

            

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Daily_Sowing ab,ab1;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            string ttl;
            ttl = totalseeds.Text + " X " + row.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Daily_Sowing(Plant,Date, BillNo, Variety, LotNo, TotalSeed, TraySize, ShortingDate,TotalPlants,Germination,AdvBillNo) values ('" + comboBox1.Text + "',convert(date,'" + sowing.Text + "',105), '" + krushikendrabillno.Text + "' , '" +variety.Text  + "', '" + lotno.Text + "', '" + ttl + "', '" + traysize.Text + "', convert(date,'" + shorting.Text + "',105),'" + totalplants.Text + "','"+"No"+"','"+advancebillno.Text+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sowing Booking Done!");

            SqlCommand cmd1 = new SqlCommand("select * from Daily_Sowing ", con);
            con.Open();
            //cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd1;
            DataSet ds = new DataSet();
            adp.Fill(ds, "Advance_Booking");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

            this.Close();

            SqlCommand cmd2 = new SqlCommand("select * from Daily_Sowing where Germination='" + "No" + "'", con);
            con.Open();
            //cmd.ExecuteNonQuery();
            SqlDataAdapter adp2 = new SqlDataAdapter();
            adp2.SelectCommand = cmd2;
            DataSet ds2 = new DataSet();
            adp2.Fill(ds2, "Daily_Sowing");
            dataGridView1.DataSource = ds2.Tables[0];

            con.Close();

            //==========Stock minus===========
            //SqlCommand cmd13 = new SqlCommand("Select quantity from Inlet_Inventery Where product='" + metroTextBox1.Text + "'", con);
            //con.Open();
            //int ttl1 = (int)cmd13.ExecuteScalar();
            //int ans = Convert.ToInt32(row.Text);

            //int a = ttl1 - ans;
            ////a = Convert.ToInt32(remaining.Text) - Convert.ToInt32(payamt.Text);
            //SqlCommand cmd4 = new SqlCommand("update Inlet_Inventery set quantity='" + a + "' where product='" + metroTextBox1.Text + "'", con);
            ////con.Open();
            //cmd4.ExecuteNonQuery();
            //con.Close();
            ////====================

            if (adv.Checked == true && advancebillno.Text != "")
            {
                con.Open();
                SqlCommand cmd3 = new SqlCommand("update Advance_Sowing set Status='"+"Sowed"+"' where Advance_Bill_No='"+advancebillno.Text+"'", con);
                cmd3.ExecuteNonQuery();
                con.Close();
            }
        }
     
    
        private void createid()
        {
            //string dt = DateTime.Now.ToString("yy");
            //string year = dt+"/";
            //con.Open();
            //SqlCommand inq = new SqlCommand("SELECT COUNT(*) AS count FROM Advance_Booking WHERE SUBSTRING(ABill_No,1,3)='" + year + "'", con);
            //string count1 = inq.ExecuteScalar().ToString();
            //int cnt = 0;
            //cnt = int.Parse(count1) + 1;

            //Console.WriteLine(count1);
            //con.Close();

            //abillno.Text = dt+ "/" + cnt;

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Add_Customer ac = new Add_Customer();
            ac.ShowDialog();
        }

        private void sowing_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select ProductId from Products where Product_Name='"+comboBox1.Text+"'",con);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            abillno.Text = ds.Tables[0].Rows[0][0].ToString();
            con.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            krushikendrabillno.Text = "";
            metroTextBox1.Text = "";
            lotno.Text = "";
            totalplants.Text = "";
            totalseeds.Text = "";
            traysize.Text = "";
        }

        
        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            


            if (adv.Checked == true)
            {
                SqlCommand cmd1 = new SqlCommand("select Advance_Bill_No from Advance_Sowing", con);
                con.Open();
                advancebillno.Items.Clear();
                SqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    advancebillno.Items.Add(dr["Advance_Bill_No"]);

                }

                con.Close();

                SqlCommand cmd5 = new SqlCommand("select * from Advance_Sowing where Status='" + "Booked" + "'", con);
                con.Open();
                SqlDataAdapter adp5 = new SqlDataAdapter();
                adp5.SelectCommand = cmd5;
                DataSet ds5 = new DataSet();
                adp5.Fill(ds5);
                dataGridView2.DataSource = ds5.Tables[0];
                con.Close();

                advancebillno.Visible = true;
                dataGridView2.Visible = true;
            }
            else
            {
                advancebillno.Visible = false;
                dataGridView2.Visible = false;
            }
        }

        
        private void dataGridView2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string A = dataGridView2.SelectedRows[0].Cells[0].Value + string.Empty;
                string b = dataGridView2.SelectedRows[0].Cells[1].Value + string.Empty;
                string c = dataGridView2.SelectedRows[0].Cells[2].Value + string.Empty;
                string d = dataGridView2.SelectedRows[0].Cells[3].Value + string.Empty;
                string e1 = dataGridView2.SelectedRows[0].Cells[4].Value + string.Empty;
                
                advancebillno.Text = A;
                comboBox1.Text = b;
                metroTextBox1.Text = c;
                lotno.Text = d;
                totalseeds.Text = e1;

            }
        }

        
    }
}
