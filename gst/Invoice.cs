using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace gst
{
    public partial class Invoice : Form
    {
        Double tot = 0.0;
        public Invoice()
        {
            InitializeComponent();
            tot = 0.0;
            totgst = 0;
        }

        private void New_Click(object sender, EventArgs e)
        {
            inno();
          //  radioButton1.Checked = false;
            panel1.Visible = true;
            cle();
        }

        public Double totgst = 0;
        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(itde1.Text) || string.IsNullOrEmpty(qua1.Text) || string.IsNullOrEmpty(rat1.Text))
            {
                return;
            }
            else
            {
                try
                {
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
                    upp(val1, itde1.Text);
                    Double val2 = Convert.ToDouble(rat1.Text);
                    val3 = (co+1)  * val2;
                    string val4 = val3.ToString();
                    
                    //MessageBox.Show("taxable amt"+Convert.ToString(val3));
                    Double gstval = Convert.ToDouble(comboBox4.Text);
                    amt = val3 + (val3 * gstval / 100);
                    //MessageBox.Show("amt"+Convert.ToString(amt));
                    //MessageBox.Show("tot" + Convert.ToString(tot));

                     //MessageBox.Show(Convert.ToString(tot));
                    Double hgst = (Convert.ToDouble(comboBox4.Text) / 2);
                    item.SubItems.Add(Convert.ToString(hgst));
                    Double cgst = (val3 * hgst) / 100;
                    item.SubItems.Add(Convert.ToString(cgst));
                    item.SubItems.Add(Convert.ToString(hgst));
                    Double sgst = (val3 * hgst) / 100;
                    item.SubItems.Add(Convert.ToString(sgst));
                    item.SubItems.Add(val4);
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
                    item.SubItems.Add(comboBox1.Text);
                    item.SubItems.Add(rat1.Text);
                    Double val1 = Convert.ToDouble(qua1.Text);
                    upp(val1, itde1.Text);
                    Double val2 = Convert.ToDouble(rat1.Text);
                    val3 = val1 * val2;
                    string val4 = val3.ToString();
                   
                    Double gstval = Convert.ToDouble(comboBox4.Text);
                    amt = val3 + (val3 * gstval / 100);
                    Double hgst = (Convert.ToDouble(comboBox4.Text) / 2);
                    item.SubItems.Add(Convert.ToString(hgst));
                    Double cgst = (val3 * hgst) / 100;
                    item.SubItems.Add(Convert.ToString(cgst));
                    item.SubItems.Add(Convert.ToString(hgst));
                    Double sgst = (val3 * hgst) / 100;
                     item.SubItems.Add(Convert.ToString(sgst));
                   // item.SubItems.Add(Convert.ToString(amt));
                    item.SubItems.Add(val4);
                    listView.Items.Add(item);
                   
                   
                }
                tot = tot + val3;
                textBox3.Text = Convert.ToString(tot);
                textBox16.Text = Convert.ToString(Convert.ToInt32(tot));
               // MessageBox.Show(gstha);
                ListViewItem index1 = null;
                     foreach (ListViewItem item in listView1.Items)
                    {
                       // MessageBox.Show("h1");
                        if (item.SubItems[0].Text ==gstha)
                        {
                         //   MessageBox.Show("h2");
                            index1 = item;
                        }
                    }

              // MessageBox.Show(index1.Text);
                if(index1 !=null)
                {
                        Double val4=0.0;
                        // MessageBox.Show("Start-val4:"+Convert.ToString(val4));
                        foreach (ListViewItem li in listView.Items)
                        {
                            string it = li.SubItems[2].Text;
                           //MessageBox.Show(comboBox4.Text);
                            //MessageBox.Show(li +"if="+ Convert.ToString(val4));
                            if (it.Equals(comboBox4.Text))
                            { 
                                 Double qt =Convert.ToDouble(li.SubItems[10].Text);
                                 val4 = val4 + qt;
                                // MessageBox.Show(li +"="+ Convert.ToString(val4));
                          
                            }
                        }
                        ListViewItem item = new ListViewItem(comboBox4.Text);
                        item.SubItems.Add(Convert.ToString(val4));
                        Double cgsttax = Convert.ToDouble(comboBox4.Text) / 2;
                        Double cgst = (val4 * cgsttax )/ 100;
                        item.SubItems.Add(Convert.ToString(Math.Round(cgst,2)));
                        item.SubItems.Add(Convert.ToString(val4));
                        Double sgsttax = Convert.ToDouble(comboBox4.Text) / 2;
                        Double sgst = (val4 * sgsttax )/ 100;
                        item.SubItems.Add(Convert.ToString(Math.Round(cgst,2)));
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
                        textBox8.Text = Convert.ToString(Math.Round(totgst + tot,2));
                }
                else
                {
                    //MessageBox.Show("Item not found" + index1);
                    ListViewItem item = new ListViewItem(comboBox4.Text);
                    item.SubItems.Add(Convert.ToString(val3));
                    Double cgsttax=(Convert.ToDouble(comboBox4.Text)/2);
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
                        Double it =Convert.ToDouble(li.SubItems[2].Text);
                        Double it1 = Convert.ToDouble(li.SubItems[4].Text);
                        cst = cst + it;
                        sst = sst + it1;
                    }
                    textBox18.Text = Convert.ToString(Math.Round(cst,2));
                    textBox17.Text = Convert.ToString(Math.Round(sst,2));
                    totgst = cst + sst;
                    textBox8.Text = Convert.ToString(Math.Round(totgst + tot,2));
                   }
                }
                catch (Exception o)
                {
                    //   MessageBox.Show("Please Choose Proper Column Name Form ComboBox ");
                }

                //cle2();  
            }
            cle2();
        }
       

        public void upp(Double x, string s)
        {
            try
            {
                // MessageBox.Show("S="+s);
                // MessageBox.Show("Prod_name='" + s + "'");
                DataRow[] dr = ds18.Tables[0].Select("Prod_name='" + s + "'");
                Double st1 = Convert.ToDouble(dr[0]["Qty"]);
                Double nes = st1 - x;
                // MessageBox.Show("ST1="+Convert.ToString(st1));
                // MessageBox.Show("NES" + nes.ToString());
                dr[0]["Qty"] = nes.ToString();
                //qua1.DataSource = ds18.Tables[0];
                //qua1.DisplayMember = "Qty";
                // MessageBox.Show("Stock Limt Will Be Reduse");
            }
            catch (Exception ob)
            {
                MessageBox.Show("Erorr " + ob);
            }

        }
       
        
        private void back_Click(object sender, EventArgs e)
        {
            reload();
            cle();
            panel1.Visible = false;
        }
        public void reload()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd1 = new SqlCeCommand("select [InvoiceID] AS ID,[I_date] AS Date,[Cust_name] AS CUST_NAME,[Satus] AS STATUS,[Due_date] AS DUE_DATE,[Amt] AS AMOUNT,[Paid] AS PAID,[Bal_due]AS BALANCE_DUE  from Invoice order by [InvoiceId] Desc ", conn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        DataSet ds18,ds17;
        public void paglo()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            try {
                conn.Open();
                SqlCeDataAdapter ad19 = new SqlCeDataAdapter("select ([First_name]) AS NAME from [customer] ", conn);
                DataSet ds19 = new DataSet();
                ad19.Fill(ds19);
                salution.DataSource = ds19.Tables[0];
                salution.DisplayMember = "Name";
                conn.Close();
                conn.Open();
                SqlCeDataAdapter ad18 = new SqlCeDataAdapter("select [Prod_name],[Qty],[Salesp],[GST],[HSN],[MRP]from [goods] ", conn);
                ds18 = new DataSet();
                ad18.Fill(ds18);
                itde1.DataSource = ds18.Tables[0];
                itde1.DisplayMember = "Prod_name";
             
                //comboBox1.DataSource = ds18.Tables[0];
                //comboBox1.DisplayMember = "MRP";               
                //rat1.DataSource = ds18.Tables[0];
                //rat1.DisplayMember = "Salesp";
                conn.Close();
                conn.Open();
                SqlCeDataAdapter ad17 = new SqlCeDataAdapter("SELECT Ser_name FROM   service  ", conn);
                ds17 = new DataSet();
                ad17.Fill(ds17);
                //comboBox6.DataSource = ds17.Tables[0];
                //comboBox6.DisplayMember = "Ser_name";
                conn.Close();
            }
            catch (Exception o) {
                MessageBox.Show("Erorr" + o);
            }
            

        }

        
        private void Invoice_Load(object sender, EventArgs e)
        {
            reload();
            paglo();
            cle();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd3 = new SqlCeCommand();
            if (e.KeyChar == (char)13 && textBox1.Text != null)
            {
                try {
                    string query = "SELECT * FROM  Invoice where  [" + comboBox3.Text + "] LIKE '%" + textBox1.Text + "%'";
                    using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    conn.Close();
                    textBox1.Text = "";
                }
                catch (Exception o) {
                    MessageBox.Show("Please Choose Proper Column Name Form ComboBox");
                }
                
            }
            else
                reload();
        }
       // public static string ino;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           Payments.com = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            INV_REF s = new INV_REF();
            nam = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            s.ShowDialog();
            
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && textBox6.Text != "")
            {
               
                    Double val1 = Convert.ToDouble(textBox16.Text);
                    Double val2 = Convert.ToDouble(textBox6.Text);
                    Double fi = val1 + val2;
                    //MessageBox.Show("val2" + val2 + "val1" + val1);
                    textBox16.Text = Convert.ToString(Math.Round(fi,2));
                    textBox7.Text = Convert.ToString(val2);
                    textBox8.Text = Convert.ToString(Math.Round(Convert.ToDouble(textBox16.Text) + totgst,2));
               

            }
            

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && textBox4.Text != "")
            {
                Double val1 = Convert.ToDouble(textBox4.Text);
                Double fi = (tot * val1) / 100;
                textBox5.Text = Convert.ToString(fi);
                textBox16.Text = Convert.ToString(Convert.ToInt32(tot - fi));
                textBox8.Text=Convert.ToString(Math.Round(Convert.ToDouble(textBox16.Text)+totgst,2));
            }
           
        }

        private void save_Click(object sender, EventArgs e)
        {
            save1();
         //   radioButton1.Checked = false;
            panel1.Visible = false;

        }
        void inno()
        {
            Double so = dataGridView1.RowCount;
            textBox11.Text ="#REN-"+Convert.ToString(so);
        }
        public void cle2()
        {
            comboBox4.Text = "";
            comboBox5.Text = "";
            rat1.Text = "";
            comboBox1.Text = "";
            itde1.Text = "";
            qua1.Text = "";
            rat1.Text = "";
        }
        void cle()
        {
            textBox2.Text="#";
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            dateTimePicker2.Text = DateTime.Now.ToShortDateString();
            textBox3.Text = "0";
            textBox5.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox16.Text = "0";
            textBox13.Text = "0";
            textBox17.Text = "0";
            comboBox1.Text = "0";
            totgst = 0;
            tot = 0.0;
            comboBox4.Text = "";
            rat1.Text = "";
            comboBox1.Text = "";

           
            itde1.Text = "";
            qua1.Text = "";
            rat1.Text = "";
            textBox9.Text = "";
            listView1.Items.Clear();
            listView.Items.Clear();
          }

      
        public String nam1;
        public Double so1;

public void save1()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeCommand cmd = new SqlCeCommand();
            //try {
            Double val1 = Convert.ToDouble(textBox13.Text);
            Double val2 = Convert.ToDouble(textBox16.Text);
            Double val3 = val2 - val1;
            Double so = dataGridView1.RowCount;
                conn.Open();
                cmd.Connection = conn;
                //Int32 pa = Convert.ToInt32(textBox12.Text);
                //Int32 ne = Convert.ToInt32(textBox14.Text);
                if (textBox13.Text.Equals("0"))
                {
                    cmd.CommandText = "INSERT INTO  Invoice ([I_date],[Cust_name],[So_no],[Due_date],[Amt],[Paid],[Bal_due]) VALUES('" + dateTimePicker1.Text + "','" + salution.Text + "','" + textBox2.Text + "','" + dateTimePicker2.Text + "','" + textBox8.Text + "','" + textBox13.Text + "','" + Convert.ToString(val3+totgst) + "')";
                    cmd.ExecuteNonQuery();

                }
                else
                {
                    cmd.CommandText = "INSERT INTO  Invoice ([I_date],[Cust_name],[So_no],[Due_date],[Amt],[Paid],[Bal_due]) VALUES('" + dateTimePicker1.Text + "','" + salution.Text + "','" + textBox2.Text + "','" + dateTimePicker2.Text + "','" + textBox8.Text + "',' "+textBox13.Text+"','"+0+"')";
                    cmd.ExecuteNonQuery();
                }
                nam1 = salution.Text;
                
                foreach (ListViewItem li in listView.Items)
                {
                    string it = li.SubItems[0].Text;
                    string hsn = li.SubItems[1].Text;
                    string gst = li.SubItems[2].Text;
                    string qt = li.SubItems[3].Text;
                    string mrp = li.SubItems[4].Text;
                    string rat = li.SubItems[5].Text;
                    string crat = li.SubItems[6].Text;
                    string camt = li.SubItems[7].Text;
                    string srat = li.SubItems[8].Text;
                    string samt = li.SubItems[9].Text;
                    string amt = li.SubItems[10].Text;
                    string q1 = "INSERT INTO  Invoice_Dei ([I_date],[Cust_name],[So_no],[Due_date],[Items],[Qty],[Rate],[Amt],[GST],[Sub_total],[Disc],[Adj],[Total],[MRP],[HSN],[crate],[camt],[srate],[samt]) VALUES('" + dateTimePicker1.Text + "','" + salution.Text + "','" + textBox11.Text + "','" + dateTimePicker2.Text + "','" + it + "','" + qt + "','" + rat + "','" + amt + "','" + totgst + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + Convert.ToString(Convert.ToDouble(textBox16.Text) + totgst) + "','" + mrp + "','" + hsn + "','" + crat + "','" + camt + "','" + srat + "','" + samt + "')";
                    SqlCeCommand cmd2 = new SqlCeCommand(q1, conn);
                    cmd2.ExecuteNonQuery();
                }
               
                string s2 = "invoice order pay";
                String s12 = "Credit";
                so1 = dataGridView1.RowCount;
                cmd.CommandText = "insert into  payment_recive ([date_p],[type],[ref],[cust_name],[mode],[amt],[Desp]) values('" + dateTimePicker1.Text + "','" + s2 + "','" + textBox11.Text + "','" + salution.Text + "','" + s12 + "','" + textBox13.Text + "','" + s12 + "')";
                cmd.ExecuteNonQuery();
                
                //if (radioButton1.Checked) {
                //    Double p = Convert.ToDouble(textBox12.Text);
                //    Double ne = Convert.ToDouble(textBox14.Text);
                //    p= p + ne;
               // cmd.CommandText = "insert into  payment_recive ([date_p],[type],[ref],[cust_name],[mode],[amt],[Desp]) values('" + dateTimePicker1.Text + "','" + "Old Payment Form Invoice" + "','" + textBox11.Text + "','" + salution.Text + "','" + "Cash" + "','" + p + "','" + "Invoice Payment" + "')";
               // cmd.ExecuteNonQuery();
                //    Double pa1 = Convert.ToDouble(textBox12.Text);
                //    Double ne1 = Convert.ToDouble(textBox14.Text);
                //    pa1 = pa1 - ne1;
                //    cmd.CommandText = "INSERT INTO  Invoice ([I_date],[Cust_name],[So_no],[Due_date],[Amt],[Paid],[Bal_due],[Ret_invoice]) VALUES('" + dateTimePicker1.Text + "','" + salution.Text + "','" + textBox2.Text + "','" + dateTimePicker2.Text + "','" + textBox16.Text + "','" + p + "','" + pa1 + "','" + textBox13.Text + "')";
                //    cmd.ExecuteNonQuery();
                //}

                cmd.CommandText = "select DISTINCT count([Prod_name]) from goods";
                int t = (int)cmd.ExecuteScalar();
              //MessageBox.Show("" + t);

                DataRow[] dr = ds18.Tables[0].Select();
                for (int j = 0; j < t; j++)
                {
                    Double st1 = Convert.ToDouble(dr[j]["Qty"]);
                    String s = Convert.ToString(dr[j]["Prod_name"]);
                    cmd.CommandText = "UPDATE  goods SET [Qty]='" + st1 + "' where [Prod_name]='" + s + "'";
                    cmd.ExecuteNonQuery();
                //MessageBox.Show(s);
                  //MessageBox.Show("" + st1);
                }
                foreach (ListViewItem li in listView1.Items)
                {
                    string ta = li.SubItems[0].Text;
                    string hat =Convert.ToString(Convert.ToDouble(li.SubItems[0].Text)/2);
                    string cgta = li.SubItems[1].Text;
                    string cgamt = li.SubItems[2].Text;
                    string sgta = li.SubItems[3].Text;
                    string sgamt = li.SubItems[4].Text;
                    string q1 = "INSERT INTO  Inv_Tax ([Date_I],[Inv_Id],[Tax],[CTA],[CAmt],[STA],[SAmt],[CGST_t],[SGST_t],[HINVTAX]) VALUES('" + dateTimePicker1.Text + "','" + textBox11.Text + "','" + ta + "','" + cgta + "','" + cgamt + "','" + sgta + "','" + sgamt + "','" + textBox18.Text + "','" + textBox17.Text + "','" + hat + "')";
                    SqlCeCommand cmd2 = new SqlCeCommand(q1, conn);
                    cmd2.ExecuteNonQuery();
                }


                reload();
                cle();
                inno();
                //sno=dataGridView1.RowCount.ToString();
                conn.Close();
                MessageBox.Show("Inserted Data Successfully");
                
                listView.Items.Clear();
                panel1.Visible = false;

            
            //}
            //catch (Exception o) {
            //    MessageBox.Show("Erorr " + o);
            //}
            
       }
      

        private void Invoice_Deactivate(object sender, EventArgs e)
        {
             if (textBox2.Text != "#" || textBox3.Text != "0" || textBox5.Text != "0" || textBox7.Text != "0" || textBox16.Text != "0" )
            {
                DialogResult result = MessageBox.Show("Do you want to save the record ?", "caption", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    save1(); 
                }
                else if (result == DialogResult.No)
                {
                    Invoice ep = new Invoice();
                    ep.Close();
                }
            }
      
        }
        String id;
        int id1;
        

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
            con.Open();
            try {
                id = dataGridView1.Rows[e.RowIndex].Cells["InvoiceID"].Value.ToString();
                if (id == "")
                {
                    id1 = 0;
                }
                else
                {
                    id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["InvoiceID"].Value.ToString());
                }

                if (id1 == 0)
                {
                    MessageBox.Show("Please Selected Proper Index For Update Status");
                }
                else
                {
                    SqlCeCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = " UPDATE Invoice set [Satus]='" + dataGridView1.Rows[e.RowIndex].Cells["Satus"].Value.ToString() + "' where [InvoiceID]=" + id1 + "";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Status Updated");
                    reload();
                }



                con.Close();
            }
            catch (Exception o) {
                MessageBox.Show("Error: " + o);
            }
           
        }
        public static string nam;
        private void button2_Click(object sender, EventArgs e)
        {
            save1();
           // radioButton1.Checked = false;
            panel1.Visible = false;
            Payments.com = Convert.ToString(so1);
            nam = nam1;
            INV_REF in1=new INV_REF();
            in1.ShowDialog();

        }
       
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
           //MessageBox.Show("h1");
            DataSet ds;
            String s = textBox9.Text;
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd3 = new SqlCeCommand();

            try
            {
                string query = "SELECT [Prod_name],[Salesp],[GST],[MRP],[HSN] FROM  goods where  [Barcode]='" + s + "'";
                using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, conn))
                {
                    ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                conn.Close();
                textBox1.Text = "";
                itde1.Text = ds.Tables[0].Rows[0].Field<String>("Prod_name");
                qua1.Text = "1";
                rat1.Text = ds.Tables[0].Rows[0].Field<String>("Salesp");
                comboBox4.Text = ds.Tables[0].Rows[0].Field<String>("GST");
                comboBox1.Text = ds.Tables[0].Rows[0].Field<String>("MRP");
                rat1.Text = ds.Tables[0].Rows[0].Field<String>("HSN");
                Double amt;
                //paglo();
                //listView.ClearSelected();
                Double val3 = 0.0;
                ListViewItem index = listView.FindItemWithText(itde1.Text);
                if (index != null)
                {
                   // MessageBox.Show("Item found." +index.SubItems[1].ToString());
                    String sub = index.SubItems[3].Text;
                     //MessageBox.Show(sub);
                    Double co = Convert.ToDouble(sub);
                    //MessageBox.Show(Convert.ToString(co));
                    ListViewItem item = new ListViewItem(itde1.Text);
                    item.SubItems.Add(rat1.Text);
                    item.SubItems.Add(comboBox4.Text);
                    item.SubItems.Add(Convert.ToString(co + 1));
                   //MessageBox.Show(Convert.ToString(co+1));
                    item.SubItems.Add(comboBox1.Text);
                    item.SubItems.Add(rat1.Text);
                    Double val1 = 1;
                    upp(val1, itde1.Text);
                    Double val2 = Convert.ToDouble(rat1.Text);
                    val3 = (co+1)  * val2;
                    string val4 = val3.ToString();
                   
                    //MessageBox.Show("taxable amt"+Convert.ToString(val3));
                    Double gstval = Convert.ToDouble(comboBox4.Text);
                    amt = val3 + (val3 * gstval / 100);
                    //MessageBox.Show("amt"+Convert.ToString(amt));
                    //MessageBox.Show("tot" + Convert.ToString(tot));

                     //MessageBox.Show(Convert.ToString(tot));
                    Double hgst = (Convert.ToDouble(comboBox4.Text) / 2);
                    item.SubItems.Add(Convert.ToString(hgst));
                    Double cgst = (val3 * hgst) / 100;
                    item.SubItems.Add(Convert.ToString(cgst));
                    item.SubItems.Add(Convert.ToString(hgst));
                    Double sgst = (val3 * hgst) / 100;
                    item.SubItems.Add(Convert.ToString(sgst));
                    //item.SubItems.Add(Convert.ToString(amt));
                    item.SubItems.Add(val4);
                    
                    
                    listView.Items.Remove(index);
                    
                    listView.Items.Add(item);
                    val3 = 1 * val2;
                    //amt = v3 + (v3 * gstval / 100);
                    itde1.Text = "";
                    qua1.Text = "";
                    rat1.Text = "";
                    textBox9.Text = "";
                    //textBox3.Text = Convert.ToString(tot);
                    //textBox16.Text = Convert.ToString(tot);
                }
                else
                {
                    //  MessageBox.Show("Item not found.");
                    // listView.SelectedIndex = index;
                    ListViewItem item = new ListViewItem(itde1.Text);
                    item.SubItems.Add(rat1.Text);
                    item.SubItems.Add(comboBox4.Text);
                    item.SubItems.Add("1");
                    item.SubItems.Add(comboBox1.Text);
                    item.SubItems.Add(rat1.Text);
                    Double val1 = 1;
                    upp(val1, itde1.Text);
                    Double val2 = Convert.ToDouble(rat1.Text);
                    val3 = val1 * val2;
                    string val4 = val3.ToString();
                   
                    Double gstval = Convert.ToDouble(comboBox4.Text);
                    amt = val3 + (val3 * gstval / 100);
                     Double hgst = (Convert.ToDouble(comboBox4.Text) / 2);
                     item.SubItems.Add(Convert.ToString(hgst));
                     Double cgst = (val3 * hgst) / 100;
                     item.SubItems.Add(Convert.ToString(cgst));
                     item.SubItems.Add(Convert.ToString(hgst));
                     Double sgst = (val3 * hgst) / 100;
                     item.SubItems.Add(Convert.ToString(sgst));
                   // item.SubItems.Add(Convert.ToString(val3));
                    item.SubItems.Add(val4);
                    listView.Items.Add(item);
                    itde1.Text = "";
                    qua1.Text = "";
                    rat1.Text = "";
                    textBox9.Text = "";
                   
                }
               // MessageBox.Show("Val3"+val3);
                tot = tot + val3;
                textBox3.Text = Convert.ToString(tot);
                textBox16.Text = Convert.ToString(Math.Round(tot,2));
                
                ListViewItem index1 = listView1.FindItemWithText(comboBox4.Text);
                ListViewItem index2 = listView1.FindItemWithText(Convert.ToString(val3));
               
                if(index1 != null)
                {
                        Double val4=0.0;
                         //MessageBox.Show("Start-val4:"+Convert.ToString(val4));
                        foreach (ListViewItem li in listView.Items)
                        {
                            string it = li.SubItems[2].Text;
                            //MessageBox.Show(comboBox4.Text);
                            //MessageBox.Show(li +"if="+ Convert.ToString(val4));
                            if (it.Equals(comboBox4.Text))
                            { 
                                 Double qt =Convert.ToDouble(li.SubItems[10].Text);
                                 val4 = val4 + qt;
                              //   MessageBox.Show(li +"="+ Convert.ToString(val4));
                          
                            }
                        }
                        ListViewItem item = new ListViewItem(comboBox4.Text);
                        item.SubItems.Add(Convert.ToString(val4));
                        Double cgsttax = Convert.ToDouble(comboBox4.Text) / 2;
                        Double cgst = (val4 * cgsttax / 100);
                        item.SubItems.Add(Convert.ToString(cgst));
                        item.SubItems.Add(Convert.ToString(val4));
                        Double sgsttax = Convert.ToDouble(comboBox4.Text) / 2;
                        Double sgst = (val4 * sgsttax / 100);
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
                        comboBox1.Text = Convert.ToString(cst);
                        textBox17.Text = Convert.ToString(sst);
                        totgst = cst + sst;
                     }
                else
                {
                  // MessageBox.Show("Item not found" + index1);
                    ListViewItem item = new ListViewItem(comboBox4.Text);
                    item.SubItems.Add(Convert.ToString(val3));
                    Double cgsttax=Convert.ToDouble(comboBox4.Text)/2;
                    Double cgst = (val3 * cgsttax / 100);
                    //cst = cst + cgst;
                    item.SubItems.Add(Convert.ToString(Math.Round(cgst,2)));
                    item.SubItems.Add(Convert.ToString(val3));
                    Double sgsttax = Convert.ToDouble(comboBox4.Text) / 2;
                    Double sgst = (val3 * sgsttax / 100);
                    //sst = sst + sgst;
                    item.SubItems.Add(Convert.ToString(Math.Round(cgst,2)));
                    listView1.Items.Add(item);
                    Double cst = 0.0, sst = 0.0;
                    foreach (ListViewItem li in listView1.Items)
                    {
                        Double it =Convert.ToDouble(li.SubItems[2].Text);
                        Double it1 = Convert.ToDouble(li.SubItems[4].Text);
                        cst = cst + it;
                        sst = sst + it1;
                    }
                    comboBox1.Text = Convert.ToString(cst);
                    textBox17.Text = Convert.ToString(sst);
                    totgst = cst + sst;
                   }
            }
            catch (Exception o)
            {
               // MessageBox.Show("Please Choose Proper Column Name Form ComboBox ");
            }
                
        }

         
           private void itde1_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //MessageBox.Show("Show1");
                    SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
                    conn.Open();
                    SqlCeDataAdapter ad18 = new SqlCeDataAdapter("select [Prod_name],[Qty],[Salesp],[GST],[HSN],[MRP]from [goods] where Prod_name='" + itde1.Text + "' ", conn);
                    DataSet ds19 = new DataSet();
                    ad18.Fill(ds19);
                    DataRow[] dr = ds18.Tables[0].Select("Prod_name='" + itde1.Text + "'");
                    qua1.Text = Convert.ToString(dr[0]["Qty"]);
                    comboBox5.Text = Convert.ToString(dr[0]["HSN"]);
                    comboBox4.Text = Convert.ToString(dr[0]["GST"]);
                    comboBox1.Text = Convert.ToString(dr[0]["MRP"]);
                    rat1.Text = Convert.ToString(dr[0]["Salesp"]);
                }
            }

          
           


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(comboBox6.Text) || string.IsNullOrEmpty(textBox9.Text))
        //    {
        //        MessageBox.Show("fill proprer data");
        //    }
        //    else
        //    {
        //        ListViewItem item = new ListViewItem("Services." + comboBox6.Text);
        //        item.SubItems.Add("");
        //        item.SubItems.Add(textBox9.Text);
        //        Double val1 = Convert.ToDouble(textBox9.Text);
        //        tot = tot + val1;
        //        string val4 = val1.ToString();
        //        item.SubItems.Add(val4);
        //        listView.Items.Add(item);
        //        comboBox6.Text = "";
        //        textBox9.Text = "";
        //        //    paglo();
        //        textBox3.Text = Convert.ToString(tot);
        //        textBox16.Text = Convert.ToString( Convert.ToInt32(tot));
        //    }
       // }

       

     
      

        
    }
}
