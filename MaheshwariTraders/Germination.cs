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
    public partial class Germination : Form
    {
        public Germination()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Properties.Settings.Default.MTConnection);

        private void Germination_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Id,Plant,Date,BillNo,Variety,LotNo,TotalSeed,AdvBillNo from Daily_Sowing where Germination='" + "No" + "'", con);
            con.Open();
            //cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds, "Advance_Booking");
            dataGridView1.DataSource = ds.Tables[0];

            con.Close();
            ////
            SqlCommand cmd11 = new SqlCommand("select product from Inlet_Inventery WHERE SUBSTRING(product,1,4)='Tray'", con);
            con.Open();
            traysize.Items.Clear();
            SqlDataReader dr2 = cmd11.ExecuteReader();
            while (dr2.Read())
            {
                traysize.Items.Add(dr2["product"]);

            }

            con.Close();

            ////////////////

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string A = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                string b = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                string c = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                string d = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                string h = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                string f = dataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
                string g = dataGridView1.SelectedRows[0].Cells[6].Value + string.Empty;
                string i = dataGridView1.SelectedRows[0].Cells[7].Value + string.Empty;
                abillno.Text = A;
                comboBox1.Text = b;
                sowing.Text = c;
                krushikendrabillno.Text = d;
                variety.Text = h;
                lotno.Text = f;
                totalseeds.Text = g;

                if (i != "")
                {
                    advbillno.Visible = true;
                    metroLabel12.Visible = true;
                    advbillno.Text = i;
                }
                else
                {
                    metroLabel12.Visible = false;
                    advbillno.Visible = false;
                    advbillno.Text = i;
                }
                
            }
        }
        int a1, b1,a2,b2,ans1,ans2,a3,b3,ans3;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("update Daily_Sowing set TraySize='" + traysize.Text + "',ShortingDate=convert(date,'" + shorting.Text + "',105),TotalPlants='" + totalplants.Text + "',Germination='" + "Yes"+ "' where Id='" + abillno.Text + "' ", con);
            SqlCommand cmd11 = new SqlCommand("update Advance_Sowing set Status='" + "Done" + "' where Advance_Bill_No='" + advbillno.Text + "' and Plant_Name='" + comboBox1.Text + "' and Variety='" + variety.Text + "' and Lot_No='" + lotno.Text + "'", con);
            cmd.ExecuteNonQuery();
            cmd11.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update successfully");
            try
            {
                SqlCommand cmd1 = new SqlCommand("select Total_Stock from Stock where Plant_Name='" + comboBox1.Text + "' and Variety='" + variety.Text + "'and Lot_No='" + lotno.Text + "'", con);

                //SqlCommand cmd1 = new SqlCommand("select Total_Stock from Stock where Plant_Name='" + comboBox1.Text + "'", con);
                con.Open();
                a1 = (int)cmd1.ExecuteScalar();
                con.Close();
                b1 = Convert.ToInt32(totalplants.Text);
                ans1 = a1 + b1;
                con.Open();
                SqlCommand cmd3 = new SqlCommand("update Stock set Total_Stock='" + ans1.ToString() + "' where Plant_Name='" + comboBox1.Text + "' and Variety='" + variety.Text + "'and Lot_No='" + lotno.Text + "' ", con);
                cmd3.ExecuteNonQuery();
                con.Close();

                SqlCommand cmd2 = new SqlCommand("select Available from Stock where Plant_Name='" + comboBox1.Text + "' and Variety='" + variety.Text + "'and Lot_No='" + lotno.Text + "'", con);
                con.Open();
                a2 = (int)cmd2.ExecuteScalar();
                con.Close();
                b2 = Convert.ToInt32(totalplants.Text);
                ans2 = a2 + b2;
                //////////////////
                SqlCommand cmd5 = new SqlCommand("select Reserved from Stock where Plant_Name='" + comboBox1.Text + "' and Variety='" + variety.Text + "'and Lot_No='" + lotno.Text + "'", con);
                con.Open();
                a3 = (int)cmd5.ExecuteScalar();
                con.Close();
                b3 = Convert.ToInt32(totalplants.Text);
                ans3 = a3 + b3;
                //////////////////
                con.Open();
                if (advbillno.Text == "")
                {
                    SqlCommand cmd4 = new SqlCommand("update Stock set Available='" + ans2.ToString() + "' where Plant_Name='" + comboBox1.Text + "' and Variety='" + variety.Text + "'and Lot_No='" + lotno.Text + "'", con);
                    cmd4.ExecuteNonQuery();
                    MessageBox.Show("update available in stock");
                }
                else
                {
                    SqlCommand cmd41 = new SqlCommand("update Stock set Reserved='" + ans3.ToString() + "' where Plant_Name='" + comboBox1.Text + "' and Variety='" + variety.Text + "'and Lot_No='" + lotno.Text + "'", con);
                    cmd41.ExecuteNonQuery();
                    MessageBox.Show("update reserved in stock");
                }
                con.Close();
                
            }
            catch
            {
                //con.Open();
                string s = "0";
                SqlCommand cmd5 = new SqlCommand("insert into Stock(Plant_Name,Variety,Lot_No,Total_Stock,Available,Reserved,Rate,limit) values('" + comboBox1.Text + "','" + variety.Text + "','" + lotno.Text + "','" + totalplants.Text + "','" + totalplants.Text + "','" + s + "','" + s + "','" + s + "')", con);
               
                cmd5.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Save data in to Stock Table");
            }

            SqlCommand cmd6 = new SqlCommand("select * from Daily_Sowing where Germination='" + "No" + "'", con);
            con.Open();
            //cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd6;
            DataSet ds = new DataSet();
            adp.Fill(ds, "Advance_Booking");
            dataGridView1.DataSource = ds.Tables[0];

            con.Close();


            //==========Stock minus===========
            SqlCommand cmd13 = new SqlCommand("Select quantity from Inlet_Inventery Where product='" + traysize.Text + "'", con);
            SqlCommand cmd15 = new SqlCommand("Select quantity from Inlet_Inventery Where SUBSTRING(product,1,4)='Coco' OR SUBSTRING(product,1,4)='coco'", con);
            
            con.Open();
            int ttl1 = (int)cmd13.ExecuteScalar();
            int tr = Convert.ToInt32(tray.Text);
            int ttl2 = (int)cmd15.ExecuteScalar();
            int cc = Convert.ToInt32(coco.Text);

            int a = ttl1 - tr;
            int b = ttl2 - cc;
            //a = Convert.ToInt32(remaining.Text) - Convert.ToInt32(payamt.Text);
            SqlCommand cmd14 = new SqlCommand("update Inlet_Inventery set quantity='" + a + "' where product='" + traysize.Text + "'", con);
            //con.Open();
            cmd14.ExecuteNonQuery();
            SqlCommand cmd16 = new SqlCommand("update Inlet_Inventery set quantity='" + b + "' where SUBSTRING(product,1,4)='Coco' OR SUBSTRING(product,1,4)='coco'", con);
            //con.Open();
            cmd16.ExecuteNonQuery();
            con.Close();
            //====================

            traysize.Text = "";
            totalplants.Text = "";
        
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            traysize.Text = "";
            totalplants.Text = "";
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
