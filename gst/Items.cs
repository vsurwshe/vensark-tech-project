using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using System.Data.OleDb;
using Microsoft.VisualBasic;

namespace gst
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        private void New_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            //groupBox2.Visible = false;
            radioButton1.Checked = false;
            //radioButton2.Checked = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            d();
            cle();
            panel1.Visible = false;
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            ef();
            panel1.Visible = false;
        }

        private void Items_Load(object sender, EventArgs e)
        {
            d();
            ef();       
            update.Visible = false;
            update.Visible = false;
            delete.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            groupBox2.Visible = false;

          //  delete1.Visible = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
            con.Open();
            SqlCeCommand cmd3 = new SqlCeCommand();
           
            
            if (e.KeyChar == (char)13 && textBox1.Text != null)
            {
                try
                {
                    string query = " SELECT [goodsID] AS ID ,[Prod_name] AS PRODUCT  ,[Unit] AS UNIT ,[Qty] AS QTY,[Salesp] AS Rate ,[MRP] AS MRP_PRICE,[GST] AS GST,[Stockl] AS STK_LIMIT,[Desp] AS DESCRIPTION,[Barcode] AS BARCODE ,[HSN] AS HSN_CODE,[Bar_desp] AS BAR_DESP from goods where [" + comboBox6.Text + "] LIKE '%" + textBox1.Text + "%'";
                    using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, con))
                    {
                        DataSet ds1 = new DataSet();
                        adapter.Fill(ds1);
                        dataGridView1.DataSource = ds1.Tables[0];
                    }
                    con.Close();
                    textBox1.Text = "";
                }
                catch (Exception o)
                {
                    MessageBox.Show("Please Choose Your Column Form Combo Box");
                }
            }
            else
            {
                d();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
            con.Open();
            SqlCeCommand cmd3 = new SqlCeCommand();
            if (e.KeyChar == (char)13 && textBox2.Text != null)
            {
                try
                {
                    string query = "SELECT  [servicesID],[Ser_name],[Unit],[Rate],[GST],[Desp],[final],[SAC] FROM [service] where [" + comboBox2.Text + "] LIKE '%" + textBox2.Text + "%'";
                    using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, con))
                    {
                        DataSet ds1 = new DataSet();
                        adapter.Fill(ds1);
                        dataGridView2.DataSource = ds1.Tables[0];
                    }
                    con.Close();
                    textBox2.Text = "";
                }
                catch (Exception o)
                {
                    MessageBox.Show("Please Choose Your Column Form Combo Box");
                }
            }
            else
            {
                ef();
            }
        }
        void d()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd1 = new SqlCeCommand(" SELECT [goodsID] AS ID ,[Prod_name] AS PRODUCT  ,[Unit] AS UNIT ,[Qty] AS QTY,[Salesp] AS Rate ,[MRP] AS MRP_PRICE,[GST] AS GST,[Stockl] AS STK_LIMIT,[Desp] AS DESCRIPTION,[Barcode] AS BARCODE ,[HSN] AS HSN_CODE,[Bar_desp] AS BAR_DESP from goods order by [goodsID] desc  ", conn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        void ef()
        {
            SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
            con.Open();
            SqlCeCommand cmd = new SqlCeCommand(" SELECT [servicesID] AS ID,[Ser_name] AS SERVICE,[Desp] AS DESCRIPTION,[Unit] AS UNIT,[Rate] AS BASE_RATE,[GST] AS GST,[final] AS FINAL_RATE,[SAC] AS SAC_CODE from service order by [servicesID] Desc  ", con);
            SqlCeDataAdapter ada = new SqlCeDataAdapter(cmd);
            DataTable s = new DataTable();
            ada.Fill(s);
            dataGridView2.DataSource = s;
            con.Close();
        }

        private void back1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            ef();
        }

        private void back_Click_2(object sender, EventArgs e)
        {
            panel1.Visible = false;
            d();
        }
        public void cle()
        {
           
            textBox3.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            textBox5.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";
            textBox12.Text = "";
            textBox6.Text = "";
            textBox11.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
        }
        public void save2()
        {
                SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
                SqlCeCommand cmd = new SqlCeCommand();
                try {
                    if (string.IsNullOrEmpty(textBox4.Text) && string.IsNullOrEmpty(textBox12.Text) && string.IsNullOrEmpty(textBox7.Text))
                    {
                        MessageBox.Show("Please Enter:\n 1.Product Name \n 2.Quantity \n 3.Purchase Price \n 4. Sales Price ");
                    }
                    else
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO  goods([Prod_name],[Qty],[Unit],[Salesp],[Stockl],[GST],[Desp],[Barcode],[HSN],[Bar_desp],[MRP]) VALUES('" + textBox4.Text + "','" + textBox12.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox5.Text + "','" + textBox15.Text + "','" + textBox6.Text + "','" + textBox13.Text + "','" + textBox14.Text + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" Product Inserted Successfully");
                        conn.Close();
                        cle();
                        d();
                        cle();
                        textBox3.Text = "#PRO-NO-" + (dataGridView1.Rows.Count).ToString();
                        //panel1.Visible = false;
                    }

                }
                catch (Exception o) {
                    MessageBox.Show("Erorr "+o);
                }
                        }
        private void save_Click_1(object sender, EventArgs e)
        {
            save2();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox1.Visible = true;
                textBox3.Text = "#PRO-NO-" +dataGridView1.Rows.Count.ToString();
                update.Visible = false;
                delete.Visible = false;
                button3.Visible = false;
                save.Visible = true;
                groupBox2.Visible = false;
             }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

            //if (radioButton2.Checked)
            //{
            //    groupBox2.Visible = true;
            //    pro_NoTextBox.Text = "#SER-NO-" + dataGridView2.Rows.Count.ToString();
            //}
            //else
            //{
            //    groupBox2.Visible = false;
            //}
        }

       

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            groupBox1.Visible = true;
          //  groupBox2.Visible = false;
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox12.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox14.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textBox15.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            textBox13.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            
            panel1.Visible = true;
            update.Visible = true;
            button3.Visible = true;
            button1.Visible = true;
            groupBox2.Visible = true;
            delete.Visible = true;
            save.Visible = false;

        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
                SqlCeCommand cmd = new SqlCeCommand();
                try {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE from goods where [goodsID]='" + textBox3.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                    conn.Close();
                    cle();
                    d();
                    panel1.Visible = false;
            
                }
                catch (Exception o) {
                    MessageBox.Show("Erorr " + o);
                }    
                
        }

        private void delete1_Click(object sender, EventArgs e)
        {

        }

        private void update_Click_1(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeCommand cmd = new SqlCeCommand();
           // conn.ConnectionString = "Data Source=DELL-PC;Initial Catalog=GST;Integrated Security=True";
            conn.Open();
            try {
                cmd.Connection = conn;
                string n = textBox3.Text;
                cmd.CommandText = "UPDATE  goods SET [Prod_name]='" + textBox4.Text + "',[Qty]='" + textBox12.Text + "',[Unit]='" + textBox8.Text + "',[Salesp]='" + textBox7.Text + "',[Stockl]='" + textBox9.Text + "',[GST]='" + textBox10.Text + "',[Desp]='" + textBox5.Text + "',[Barcode]='" + textBox15.Text + "',[HSN]='" + textBox6.Text + "',[Bar_desp]='" + textBox13.Text + "',[MRP]='" + textBox14.Text + "' where [goodsID]='" + n + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
                conn.Close();
                cle();
                d();
                panel1.Visible = false;
               }
            catch (Exception o)
            {
                MessageBox.Show("Erorr"+o);
            }
            
       }

        private void update1_Click(object sender, EventArgs e)
        {
            //SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            //SqlCeCommand cmd = new SqlCeCommand();
            //conn.Open();
            //try
            //{
            //    cmd.Connection = conn;
            //    string n = pro_NoTextBox.Text;
            //    cmd.CommandText = "UPDATE  service SET [Ser_name]='" + pro_NameTextBox.Text + "',[Unit]='" + Unit.Text + "',[Rate]='" + rateTextBox.Text + "',[GST]='" + textBox13.Text + "',[Desp]='" + despTextBox.Text + "',[SAC]='" +textBox11.Text + "' where [servicesID]='" + n + "'";
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Updated Successfully");
            //    conn.Close();
            //    cle();
            //    ef();
            //    panel1.Visible = false;

            //}
            //catch (Exception o)
            //{
            //    MessageBox.Show("Erorr" + o);
            //}

        }

       
       
        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (e.KeyChar == (char)13)
            //{
            //    Double so = Convert.ToDouble(rateTextBox.Text);
            //    Double gs = Convert.ToDouble(textBox13.Text);
            //    Double pur = so + (so * (gs / 100));
            //    textBox14.Text = Convert.ToString(pur);
            //}
        }

        private void Items_Deactivate(object sender, EventArgs e)
        {

            if (textBox4.Text != "" || textBox12.Text != "" || textBox8.Text != "" || textBox10.Text != "" || textBox7.Text != "" || textBox9.Text != "" || textBox5.Text != "")
            {
                DialogResult result = MessageBox.Show("Do you want to save the record ?", "caption", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    save2();
                }
                else if (result == DialogResult.No)
                {
                    Items ep = new Items();
                    ep.Close();
                }
            }
            else
            {
                //if (pro_NameTextBox.Text != "" || Unit.Text != "" || rateTextBox.Text != "" || textBox13.Text != "" || textBox14.Text != "" || despTextBox.Text != "")
                //{
                //    DialogResult result = MessageBox.Show("Do you want to save the record ?", "caption", MessageBoxButtons.YesNo);
                //    if (result == DialogResult.Yes)
                //    {
                //        save3();
                //    }
                //    else if (result == DialogResult.No)
                //    {
                //        Items ep = new Items();
                //        ep.Close();
                //    }
                //}

            }
        }

       
        private void dataGridView2_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
           

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton2.Checked)
            //{
            //    groupBox2.Visible = true;
            //    pro_NoTextBox.Text = "#SER-NO-" + dataGridView1.Rows.Count.ToString();
            //    update1.Visible = false;
            //    delete1.Visible = false;
            //    save1.Visible = true;


            //}
            //else
            //{
            //    groupBox2.Visible = false;
            //}
        }


        private void back1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            ef();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeCommand cmd = new SqlCeCommand();
            // conn.ConnectionString = "Data Source=DELL-PC;Initial Catalog=GST;Integrated Security=True";
            conn.Open();
            try
            {
                cmd.Connection = conn;
                string n = textBox3.Text;
                int qt = Convert.ToInt32(textBox12.Text);
                int new1=Convert.ToInt32(textBox11.Text);
                cmd.CommandText = "UPDATE  goods SET [Qty]='" +Convert.ToString(qt+new1)+"' where [goodsID]='" + n + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Qty Successfully");
                conn.Close();
                cle();
                d();
                panel1.Visible = false;
            }
            catch (Exception o)
            {
                MessageBox.Show("Erorr" + o);
            }
            
        }
  String filename;
  DataTable ta;
        private void button2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel (*.xls)|*.xls|All files (*.*)|*.*";
            DialogResult ofd = openFileDialog1.ShowDialog();
            if (ofd == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                MessageBox.Show(" Your Excel File :- " + filename);
                SqlCeConnection sqlconn = new SqlCeConnection(Properties.Settings.Default.conne);
                //SqlCeCommand sqlcmd = new SqlCeCommand("DELETE from goods ", sqlconn);
                //sqlconn.Open();
                //sqlcmd.ExecuteNonQuery();
                //SqlCeCommand sqlcmd1 = new SqlCeCommand("ALTER TABLE [goods] ALTER COLUMN [goodsID] IDENTITY(1,1)", sqlconn);
                //sqlcmd1.ExecuteNonQuery();
                //sqlconn.Close();
                SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String connstr = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + filename + "';Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;'");
                OleDbConnection conn = new OleDbConnection(connstr);
                string strSQL = ("SELECT * FROM [Goods Sheet$]");
                ta = new DataTable();
                OleDbCommand cmd = new OleDbCommand(strSQL, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ta);
                con.Open();
                cmd1.Connection = con;
                try
                {
                   
                    SqlCeConnection sqlConnection = new SqlCeConnection(Properties.Settings.Default.conne);
               
                 
                    foreach (DataRow d in ta.Rows)
                    {
                        i++;
                        String pn = d["Prod_name"].ToString();
                        String qt = d["Qty"].ToString();
                        String un = d["Unit"].ToString();
                        String sa = d["Salesp"].ToString();
                        if (sa.Equals(""))
                            sa = "0";
                        String mrp = d["MRP"].ToString();
                        String st = d["Stockl"].ToString();
                        String gst = d["GST"].ToString();
                        String de = d["Desp"].ToString();
                        String br = d["Barcode"].ToString();
                        String hsn = d["HSN"].ToString();
                        String bd = d["Bar_Desp"].ToString();

                        sqlConnection.Open();
                        SqlCeCommand check_User_Name = new SqlCeCommand("Select * FROM goods", sqlConnection);
                        SqlCeDataReader dr = check_User_Name.ExecuteReader();
                        String flag = "false";
                        while (dr.Read())
                        {
                            if (dr[1].ToString() == pn)
                            {
                                flag = "true";
                                break;
                            }
                            else flag = "false";

                        }
                        if (flag.Equals("true"))
                        {
                            //User Exists
                            //MessageBox.Show("Record have");
                            cmd1.CommandText = "UPDATE  goods SET [Qty]='" + qt + "',[Unit]='" + un + "',[Salesp]='" + sa + "',[Stockl]='" + st + "',[GST]='" + gst + "',[Desp]='" + de + "',[Barcode]='" + br + "',[HSN]='" + hsn + "',[Bar_desp]='" + bd + "',[MRP]='" + mrp + "' where [Prod_name]='" + pn + "'";
                            cmd1.ExecuteNonQuery();
                        }
                        else
                        {
                            //User NOT Exists
                            cmd1.CommandText = "INSERT INTO  goods([Prod_name],[Qty],[Unit],[Salesp],[Stockl],[GST],[Desp],[Barcode],[HSN],[Bar_desp],[MRP]) VALUES('" + pn + "','" + qt + "','" + un + "','" + sa + "','" + st + "','" + gst + "','" + de + "','" + br + "','" + hsn + "','" + bd + "','" + mrp + "')";
                            cmd1.ExecuteNonQuery();
                        }

                        sqlConnection.Close();


                        //DoHeavyWork();
                        //backgroundWorker1.ReportProgress(i);
                    }
                    con.Close();
                    //MessageBox.Show("Your Excle Sheet Successfully  Imported..");
                }
                catch (SqlCeException ex)
                {
                    MessageBox.Show("Error :" + ex);
                }
            }
             
        }
        public static string barco,noof;

        private void button3_Click(object sender, EventArgs e)
        {
            barco = textBox15.Text;
            noof = Interaction.InputBox("Enter no Of barcode Sticker Are Genration", "No of Barcode Generate");
            BARGEN b = new BARGEN();
            b.ShowDialog();

        }
        int i = 0;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
                SqlCeConnection sqlConnection = new SqlCeConnection(Properties.Settings.Default.conne);
                SqlCeCommand cmd1 = new SqlCeCommand();
                cmd1.Connection = con;
                con.Open();
                foreach (DataRow d in ta.Rows)
                {
                    i++;
                    String pn = d["Prod_name"].ToString();
                    String qt = d["Qty"].ToString();
                    String un = d["Unit"].ToString();
                    String sa = d["Salesp"].ToString();
                    if (sa.Equals(""))
                        sa = "0";
                    String mrp = d["MRP"].ToString();
                    String st = d["Stockl"].ToString();
                    String gst = d["GST"].ToString();
                    String de = d["Desp"].ToString();
                    String br = d["Barcode"].ToString();
                    String hsn = d["HSN"].ToString();
                    String bd = d["Bar_Desp"].ToString();
                    
                    sqlConnection.Open();
                    SqlCeCommand check_User_Name = new SqlCeCommand("Select * FROM goods", sqlConnection);
                    SqlCeDataReader dr = check_User_Name.ExecuteReader();
                    String flag="false";
                    while (dr.Read())
                    {
                        if (dr[1].ToString() == pn)
                        {
                            flag = "true";
                            break;
                        }
                        else flag = "false";

                    }
                    if (flag.Equals("true"))
                    {
                        //User Exists
                        //MessageBox.Show("Record have");
                        cmd1.CommandText = "UPDATE  goods SET [Qty]='" + qt + "',[Unit]='" + un + "',[Salesp]='" + sa + "',[Stockl]='" + st + "',[GST]='" + gst + "',[Desp]='" + de + "',[Barcode]='" + br + "',[HSN]='" + hsn + "',[Bar_desp]='" + bd + "',[MRP]='" + mrp + "' where [Prod_name]='" + pn + "'";
                        cmd1.ExecuteNonQuery();
                    }
                    else
                    {
                        //User NOT Exists
                        cmd1.CommandText = "INSERT INTO  goods([Prod_name],[Qty],[Unit],[Salesp],[Stockl],[GST],[Desp],[Barcode],[HSN],[Bar_desp],[MRP]) VALUES('" + pn + "','" + qt + "','" + un + "','" + sa + "','" + st + "','" + gst + "','" + de + "','" + br + "','" + hsn + "','" + bd + "','" + mrp + "')";
                        cmd1.ExecuteNonQuery();
                    }
                   
                    sqlConnection.Close();
                    MessageBox.Show("Your Product Will Upload SuccessFully");
                    
                    //DoHeavyWork();
                    //backgroundWorker1.ReportProgress(i);
                }
                con.Close();
                //MessageBox.Show("Your Excle Sheet Successfully  Imported..");
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }

      
    
    }
}
