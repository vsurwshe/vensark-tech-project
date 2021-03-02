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
using Microsoft.VisualBasic;
using System.Data.SqlServerCe;

namespace gst
{
    public partial class BillsMain : Form
    {
        public BillsMain()
        {
            InitializeComponent();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            cle();
            textBox4.Text = "#BILLNO-" + dataGridView1.Rows.Count.ToString();
            listView.Items.Clear();
            listView1.Items.Clear();
        }
        Double tot = 0;
        public Double totgst = 0;
        private void btnadd4_Click(object sender, EventArgs e)
        {

            Int32 qt1 = 0;
          if (string.IsNullOrEmpty(itde1.Text) || string.IsNullOrEmpty(qua1.Text) || string.IsNullOrEmpty(rat1.Text))
                {
                    MessageBox.Show("Please Fill Proper Data");
                }
                else
                {
                    SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
                    SqlCeCommand cmd = new SqlCeCommand();
                    //try
                    //{
                  
                          Double amt;
                    String gstha = "";
                    Double val3 = 0.0;
                    ListViewItem index = listView.FindItemWithText(itde1.Text);
                    if (index != null)
                    {
                        // MessageBox.Show("Item found." +index.SubItems[1].ToString());
                        String sub = index.SubItems[2].Text;
                        //MessageBox.Show(sub);
                        Double co = Convert.ToDouble(sub);
                        //MessageBox.Show(Convert.ToString(co));
                        ListViewItem item = new ListViewItem(itde1.Text);
                        item.SubItems.Add(comboBox5.Text);
                        gstha = comboBox4.Text;
                        item.SubItems.Add(comboBox4.Text);
                        item.SubItems.Add(qua1.Text);
                        item.SubItems.Add(comboBox1.Text);
                        item.SubItems.Add(rat1.Text);
                        Double val1 = Convert.ToDouble(qua1.Text);
                        upp(Convert.ToInt32(val1), itde1.Text);
                        Double val2 = Convert.ToDouble(rat1.Text);
                        val3 = (co + 1) * val2;
                        string val4 = val3.ToString();
                        item.SubItems.Add(val4);
                        //MessageBox.Show("taxable amt"+Convert.ToString(val3));
                        Double gstval = Convert.ToDouble(comboBox4.Text);
                        amt = val3 + (val3 * gstval / 100);
                        item.SubItems.Add(Convert.ToString(amt));
                        //MessageBox.Show("amt"+Convert.ToString(amt));
                        //MessageBox.Show("tot" + Convert.ToString(tot));

                        //MessageBox.Show(Convert.ToString(tot));
                        //Double hgst = (Convert.ToDouble(comboBox4.Text) / 2);
                        //item.SubItems.Add(Convert.ToString(hgst));
                        //Double cgst = (val3 * hgst) / 100;
                        //item.SubItems.Add(Convert.ToString(cgst));
                        //item.SubItems.Add(Convert.ToString(hgst));
                        //Double sgst = (val3 * hgst) / 100;
                        //item.SubItems.Add(Convert.ToString(sgst));
                        //item.SubItems.Add(Convert.ToString(amt));
                        //item.SubItems.Add(Convert.ToString(amt));
                        listView.Items.Remove(index);
                        listView.Items.Add(item);
                        Double v3 = 1 * val2;
                        amt = v3 + (v3 * gstval / 100);
                     
                        //textBox3.Text = Convert.ToString(tot);
                        //textBox16.Text = Convert.ToString(tot);
                    }

                    else
                    {
                        //  MessageBox.Show("Item not found.");
                        // listView.SelectedIndex = index;
                        ListViewItem item = new ListViewItem(itde1.Text);
                        item.SubItems.Add(comboBox5.Text);
                        gstha = comboBox4.Text;
                        item.SubItems.Add(comboBox4.Text);
                        item.SubItems.Add(qua1.Text);
                        item.SubItems.Add(comboBox3.Text);
                        item.SubItems.Add(rat1.Text);

                        Double val1 = Convert.ToDouble(qua1.Text);
                        upp(Convert.ToInt32(val1), itde1.Text);
                        Double val2 = Convert.ToDouble(rat1.Text);
                        val3 = val1 * val2;
                        string val4 = val3.ToString();
                        item.SubItems.Add(val4);
                        Double gstval = Convert.ToDouble(comboBox4.Text);
                        amt = val3 + (val3 * gstval / 100);
                        //item.SubItems.Add(Convert.ToString(amt));
                        Double hgst = (Convert.ToDouble(comboBox4.Text) / 2);
                        //item.SubItems.Add(Convert.ToString(hgst));
                        Double cgst = (val3 * hgst) / 100;
                        //item.SubItems.Add(Convert.ToString(cgst));
                        //item.SubItems.Add(Convert.ToString(hgst));
                        Double sgst = (val3 * hgst) / 100;

                        //item.SubItems.Add(Convert.ToString(sgst));
                        item.SubItems.Add(Convert.ToString(amt));
                       
                        listView.Items.Add(item);
                      

                    }
                    tot = tot + val3;
                    textBox8.Text = Convert.ToString(tot);

                        ListViewItem index1 = listView1.FindItemWithText(comboBox4.Text);
                        ListViewItem index2 = listView1.FindItemWithText(Convert.ToString(val3));

                        if (index1 != null)
                        {
                            Double val4 = 0.0;
                            //MessageBox.Show("Start-val4:"+Convert.ToString(val4));
                            foreach (ListViewItem li in listView.Items)
                            {
                                string it = li.SubItems[2].Text;
                                //MessageBox.Show(comboBox4.Text);
                                //MessageBox.Show(li +"if="+ Convert.ToString(val4));
                                if (it.Equals(comboBox4.Text))
                                {
                                    Double qt = Convert.ToDouble(li.SubItems[6].Text);
                                    val4 = val4 + qt;
                                    //MessageBox.Show(li +"="+ Convert.ToString(val4));

                                }
                            }
                            ListViewItem item = new ListViewItem(comboBox4.Text);
                            item.SubItems.Add(Convert.ToString(val4));
                            Double cgsttax = Convert.ToDouble(comboBox4.Text) / 2;
                            Double cgst = (val4 * cgsttax) / 100;
                            item.SubItems.Add(Convert.ToString(cgst));
                            item.SubItems.Add(Convert.ToString(val4));
                            Double sgsttax = Convert.ToDouble(comboBox4.Text) / 2;
                            Double sgst = (val4 * sgsttax) / 100;
                            item.SubItems.Add(Convert.ToString(cgst));
                            listView1.Items.Remove(index1);
                            listView1.Items.Add(item);
                            Double cst = 0.0, sst = 0.0;
                            foreach (ListViewItem li in listView1.Items)
                            {
                                Double it = Convert.ToDouble(li.SubItems[2].Text);
                                Double it1 = Convert.ToDouble(li.SubItems[4].Text);
                                cst = cst + it;
                                sst = sst + it1;
                            }
                            textBox18.Text = Convert.ToString(cst);
                            textBox17.Text = Convert.ToString(sst);
                            totgst = cst + sst;
                            textBox5.Text = Convert.ToString(totgst + tot);
                        }
                        else
                        {
                            // MessageBox.Show("Item not found" + index1);
                            ListViewItem item = new ListViewItem(comboBox4.Text);
                            item.SubItems.Add(Convert.ToString(val3));
                            Double cgsttax = Convert.ToDouble(comboBox4.Text) / 2;
                            Double cgst = (val3 * cgsttax) / 100;
                            //cst = cst + cgst;
                            item.SubItems.Add(Convert.ToString(cgst));
                            item.SubItems.Add(Convert.ToString(val3));
                            Double sgsttax = Convert.ToDouble(comboBox4.Text) / 2;
                            Double sgst = (val3 * sgsttax) / 100;
                            //sst = sst + sgst;
                            item.SubItems.Add(Convert.ToString(cgst));
                            listView1.Items.Add(item);
                            Double cst = 0.0, sst = 0.0;
                            foreach (ListViewItem li in listView1.Items)
                            {
                                Double it = Convert.ToDouble(li.SubItems[2].Text);
                                Double it1 = Convert.ToDouble(li.SubItems[4].Text);
                                cst = cst + it;
                                sst = sst + it1;
                            }
                            textBox18.Text = Convert.ToString(cst);
                            textBox17.Text = Convert.ToString(sst);
                            totgst = cst + sst;
                            textBox5.Text = Convert.ToString(totgst + tot);

                        }
                        cle1();
            }
               
        }
    

        public void upp(int x, string s)
        {
            try
            {
                if(checkBox1.Checked){
                // MessageBox.Show("S="+s);
                // MessageBox.Show("Prod_name='" + s + "'");
                DataRow[] dr = ds18.Tables[0].Select("Prod_name='" + s + "'");
                if (dr.Length != 0)
                {
                    Double st1 = Convert.ToDouble(dr[0]["Qty"]);
                    Double nes = st1 +x;
                    dr[0]["Qty"] = nes.ToString();
                    MessageBox.Show("Product Updated Sucessfully");
                }
                else
                {
                    DataRow dr1 = ds18.Tables[0].NewRow();
                    dr1["Prod_name"] = itde1.Text;
                    dr1["Qty"] = qua1.Text;
                    dr1["GST"] = comboBox4.Text;
                    dr1["HSN"] = comboBox5.Text;
                    dr1["MRP"] = comboBox3.Text;
                    dr1["Salesp"] = rat1.Text;
                    ds18.Tables[0].Rows.Add(dr1);
                    MessageBox.Show("Product Saved Sucessfully");
                }
                // MessageBox.Show("ST1="+Convert.ToString(st1));
                // MessageBox.Show("NES" + nes.ToString());
                
                // MessageBox.Show("Stock Limt Will Be Reduse");
                }
                checkBox1.Checked = false;
            }
            catch (Exception ob)
            {
                MessageBox.Show("Erorr " + ob);
            }
        }
        private void btnsave4_Click(object sender, EventArgs e)
        {
            save1();
        }
        public void cle()
        {
            textBox3.Text = "0";
            itde1.Text = "";
            qua1.Text = "";
            rat1.Text = "";
            salution.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            textBox8.Text = "0";
            textBox5.Text = "0";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox9.Text = "";
            comboBox5.Text = "";
            comboBox4.Text = "";
            comboBox3.Text = "";
            comboBox1.Text = "";
        }
        public void cle1()
        {
            itde1.Text = "";
            qua1.Text = "";
            rat1.Text = "";
            comboBox5.Text = "";
            comboBox4.Text = "";
            comboBox3.Text = "";
        }
        private void btnback4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            here();
            cle();
        }
        DataSet ds18;
        public void paglo()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeDataAdapter ad19 = new SqlCeDataAdapter("select [Shop_name] AS NAME from [vendor] ", conn);
            DataSet ds19 = new DataSet();
            ad19.Fill(ds19);
            salution.DataSource = ds19.Tables[0];
            salution.DisplayMember = "Name";
            conn.Close();
            conn.Open();
            SqlCeDataAdapter ad18 = new SqlCeDataAdapter("select [Prod_name],[Qty],[Salesp],[GST],[MRP],[HSN] from [goods] ", conn);
            ds18 = new DataSet();
            ad18.Fill(ds18);
            
            itde1.DataSource = ds18.Tables[0];
            itde1.DisplayMember = "Prod_name";
            //qua1.DataSource = ds18.Tables[0];
            //qua1.DisplayMember = "Qty";
            //rat1.DataSource = ds18.Tables[0];
            //rat1.DisplayMember = "Salesp";
            //comboBox3.DataSource = ds18.Tables[0];
            //comboBox3.DisplayMember = "MRP";
            comboBox5.DataSource = ds18.Tables[0];
            comboBox5.DisplayMember = "HSN";
            comboBox4.DataSource = ds18.Tables[0];
            comboBox4.DisplayMember = "GST";
            conn.Close();
        }

        private void BillsMain_Load(object sender, EventArgs e)
        {
            here();
            paglo();
        }

        void here()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd1 = new SqlCeCommand(" SELECT * from Bills order by [BillsID] desc ", conn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
            con.Open();
            SqlCeCommand cmd3 = new SqlCeCommand();
            if (e.KeyChar == (char)13 && textBox1.Text != null)
            {
                try
                {
                string query = "SELECT  [BillsID],[Date],[Vendor_name],[Due_date],[Amt],[Paid],[Bal] FROM Bills where [" + comboBox2.Text + "] LIKE '%" + textBox1.Text + "%'";
                using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, con))
                {
                    DataSet ds1 = new DataSet();
                    adapter.Fill(ds1);
                    dataGridView1.DataSource = ds1.Tables[0];
                }
                con.Close();
                textBox1.Text = "";
                }
                catch (Exception ab7)
                {
                    MessageBox.Show("Please  Select a Value from the Combobox");
                }
            }
            else
            {
                here();
            }
        }
        public void save1()
        {
            try
            {
                SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
                SqlCeCommand cmd = new SqlCeCommand();
                //  conn.ConnectionString = "Data Source=DELL-PC;Initial Catalog=GST;Integrated Security=True";
                conn.Open();
                cmd.Connection = conn;
                foreach (ListViewItem li in listView.Items)
                {
                    string it = li.SubItems[0].Text;
                    string hsn = li.SubItems[1].Text;
                    string gst = li.SubItems[2].Text;
                    string qt = li.SubItems[3].Text;
                    string mrp = li.SubItems[4].Text;
                    string rat = li.SubItems[5].Text;
                    string tamt = li.SubItems[6].Text;
                    string fiamt = li.SubItems[7].Text;
                    string q1 = "INSERT INTO bill_detail([Vendor_name],[Pur_ord],[Bill_date],[Due_date],[Items],[Qty],[Rate],[Total],[Ref],[GST],[Fin_amt],[HSN],[MRP],[Amt])  VALUES('" + salution.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + it + "','" + qt + "','" + rat + "','" + textBox5.Text + "','" + textBox4.Text + "','" + gst + "','" + fiamt + "','" + hsn + "','" + mrp + "','" + tamt + "')";
                    SqlCeCommand cmd2 = new SqlCeCommand(q1, conn);
                    cmd2.ExecuteNonQuery();
                }
                Double val1 = Convert.ToDouble(textBox3.Text);
                Double val2 = Convert.ToDouble(textBox5.Text);
                Double val3 = val2 - val1;
                cmd.CommandText = "insert into Bills([Date],[Vendor_name],[Due_date],[Amt],[Paid],[Bal]) VALUES ('" + dateTimePicker1.Text + "','" + salution.Text + "','" + dateTimePicker2.Text + "','" + textBox5.Text + "','" + textBox3.Text + "','" + val3 + "')";
                cmd.ExecuteNonQuery();
                string type = "Bills";
                cmd.CommandText = " INSERT INTO Payment_made([Date],[Type],[Ref],[Vendor_name],[Mode],[Amt],[Desp]) VALUES('" + dateTimePicker1.Text + "','" + type + "','" + textBox4.Text + "','" + salution.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')";
                cmd.ExecuteNonQuery();

                foreach (ListViewItem li in listView1.Items)
                {
                    string ta = li.SubItems[0].Text;
                    string cgta = li.SubItems[1].Text;
                    string cgamt = li.SubItems[2].Text;
                    string sgta = li.SubItems[3].Text;
                    string sgamt = li.SubItems[4].Text;
                    string q1 = "INSERT INTO  Bill_Tax ([Date_I],[B_ID],[Tax],[CTA],[CAmt],[STA],[SAmt],[CGST_t],[SGST_t],[ref]) VALUES('" + dateTimePicker1.Text + "','" + textBox2.Text + "','" + ta + "','" + cgta + "','" + cgamt + "','" + sgta + "','" + sgamt + "','" + textBox18.Text + "','" + textBox17.Text + "','" + textBox4.Text + "')";
                    SqlCeCommand cmd2 = new SqlCeCommand(q1, conn);
                    cmd2.ExecuteNonQuery();
                }
                //DataRow[] dr = ds18.Tables[0].Select("COMPLEATED_ON IS NOT NULL AND COMPLEATED_ON <> ''");
                Int32 j1 = ds18.Tables[0].Rows.Count;
                DataRow[] dr = ds18.Tables[0].Select();
                //MessageBox.Show("Length Of Record " + j1);
               
                for (int j = 0; j <j1; j++)
                {
                    String s = Convert.ToString(dr[j]["Prod_name"]);
                    //MessageBox.Show("Prodcut name "+ s);
                    SqlCeConnection sqlConnection = new SqlCeConnection(Properties.Settings.Default.conne);
                    sqlConnection.Open();
                    SqlCeCommand check_User_Name = new SqlCeCommand("Select * FROM goods", sqlConnection);
                    SqlCeDataReader dr12 = check_User_Name.ExecuteReader();
                    String flag = "fasle";
                    while (dr12.Read())
                    {
                        //MessageBox.Show("Prodcut name in goods " + dr12[1].ToString());
                        if (dr12[1].ToString() == s)
                        {
                            flag = "true";
                            break;
                        }
                        else flag = "false";

                    }
                    if (flag.Equals("true"))
                    {
                        //User Exists
                  //      MessageBox.Show("Record have");
                        String qt = Convert.ToString(dr[j]["Qty"]);
                        cmd.CommandText = "UPDATE  goods SET [Qty]='" + qt + "' where [Prod_name]='" + s + "'";
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        //User NOT Exists
                        //dr1["Prod_name"] = itde1.Text;
                        //dr1["Qty"] = qua1.Text;
                        //dr1["GST"] = comboBox4.Text;
                        //dr1["HSN"] = comboBox5.Text;
                        //dr1["MRP"] = comboBox3.Text;
                        //dr1["Salesp"] = rat1.Text;
                        String pro = Convert.ToString(dr[j]["Prod_name"]);
                        String qty = Convert.ToString(dr[j]["Qty"]);
                        String gst = Convert.ToString(dr[j]["GST"]);
                        String hsn = Convert.ToString(dr[j]["HSN"]);
                        String mrp = Convert.ToString(dr[j]["MRP"]);
                        String sal = "0";
                        cmd.CommandText = "INSERT INTO  goods([Prod_name],[Qty],[Salesp],[GST],[HSN],[MRP]) VALUES('" + pro + "','" + qty + "','" +sal + "','" + gst + "','" + hsn + "','" + mrp + "')";
                        cmd.ExecuteNonQuery();
                    }
                    checkBox1.Checked = false;
                    sqlConnection.Close();
                    //MessageBox.Show(s);
                    //MessageBox.Show("" + st1);
                }
                
                MessageBox.Show("Inserted Successfully");
                conn.Close();
                here();
                listView.Items.Clear();
                cle();
                panel1.Visible = false;
            }
            catch (Exception ab7)
            {
                MessageBox.Show("Error :" + ab7);
            }
        }
        private void BillsMain_Deactivate(object sender, EventArgs e)
        {
            if (textBox2.Text != "" || textBox8.Text != "" || textBox9.Text != "")
            {
                DialogResult result = MessageBox.Show("Do you want to save the record ?", "caption", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    save1();
                }

                else if (result == DialogResult.No)
                {
                    Expensemain ep = new Expensemain();
                    ep.Close();
                }

            }
        }
        public static String nam;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PaymentMain.com = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nam = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            billrp ob1 = new billrp();
            ob1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String olp = Interaction.InputBox("Enter Your Old Bill No", "Update Your Old Bill Balnce");
            String newp = Interaction.InputBox("Enter Your New Paid Blance", "Update Your Old Bill Balnce");
            String pay=null, paid=null;
            if (string.IsNullOrEmpty(olp) || string.IsNullOrEmpty(pay))
            {
                try
                {
                    SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
                    SqlCeCommand com = new SqlCeCommand();
                    com.CommandText = "SELECT [Bal],[Paid] FROM [Bills] WHERE [BillsID]=@Search";
                    com.Parameters.AddWithValue("@Search", olp);
                    com.Connection = con;

                    con.Open();
                    using (SqlCeDataReader sdr = com.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            pay = (sdr["Bal"].ToString());
                            paid = (sdr["Paid"].ToString());
                        }
                    }
                    con.Close();
                    con.Open();
                    Double np = Convert.ToDouble(newp);
                    Double op = Convert.ToDouble(pay);
                    String pai = paid + "+" + Convert.ToString(newp);
                    com.Connection = con;
                    com.CommandText = "UPDATE  Bills SET [Bal]='" + Convert.ToString(op - np) + "',[Paid]='" + pai + "' where [BillsID]='" + olp + "'";
                    com.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    com.CommandText = " INSERT INTO Payment_made([Date],[Type],[Ref],[Vendor_name],[Mode],[Amt],[Desp]) VALUES('" + DateTime.Now.ToShortDateString() + "','" + "OLD BILL" + "','" + ("BILL NO" + olp) + "','" + ("BILL NO" + olp) + "','" + "CASH" + "','" + newp + "','" + "Piad By Cash" + "')";
                    com.ExecuteNonQuery();
                    con.Close();
                    here();
                    MessageBox.Show("Your Balance will Updated");

                }
                catch (Exception o)
                {
                    MessageBox.Show("Erorr " + o);    
                    here();
                }

            }
                        
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listView.SelectedItems.ToString();
            MessageBox.Show(curItem);
        }

      
        

      
    
    }
}
