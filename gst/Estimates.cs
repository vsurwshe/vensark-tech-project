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
    public partial class Estimates : Form
    {
        public Estimates()
        {
            InitializeComponent();
        }

        private void New_Click(object sender, EventArgs e)
        {
            inno();
            cle();
            panel1.Visible = true;
        }
        Double tot = 0;
         public Double totgst = 0;
        int qtyn;
        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(itde1.Text) || string.IsNullOrEmpty(qua1.Text) || string.IsNullOrEmpty(rat1.Text))
            {
                return;
            }
            else
            {
                Double amt = 0;
              
                ListViewItem index = listView.FindItemWithText(itde1.Text);
                if (index != null)
                {

                    String sub = index.SubItems[2].Text;
                    //MessageBox.Show(sub);
                    Int32 co = Convert.ToInt32(sub);
                   // MessageBox.Show("co " + co);
                    ListViewItem item = new ListViewItem(itde1.Text);
                    item.SubItems.Add(comboBox5.Text);
                    Int32 te = Convert.ToInt32(qua1.Text);
                    co = co + te;
                   // MessageBox.Show("te " + te);
                    item.SubItems.Add(Convert.ToString(co));
                    item.SubItems.Add(rat1.Text);
                    item.SubItems.Add(comboBox3.Text);
                    Int32 val1 = Convert.ToInt32(qua1.Text);
                    upp(co, itde1.Text);
                    Double val2 = Convert.ToDouble(rat1.Text);
                    Double val3 = co * val2;
       
                    string val4 = val3.ToString();
                    item.SubItems.Add(comboBox4.Text);
                    item.SubItems.Add(Convert.ToString(val3));
                    Double gstval = Convert.ToDouble(comboBox4.Text);

                    amt = val3 + (val3 * gstval / 100);
                    item.SubItems.Add(Convert.ToString(amt));
                    Double v3 = te * val2;
                    amt = v3;
                    listView.Items.Remove(index);
                    listView.Items.Add(item);
                   
                    itde1.Text = "";
                    qua1.Text = "";
                    rat1.Text = "";
                    // paglo();
                    //textBox3.Text = Convert.ToString(tot);
                    //textBox8.Text = Convert.ToString(tot);
                }
                else
                {
                    ListViewItem item = new ListViewItem(itde1.Text);
                    item.SubItems.Add(comboBox5.Text);
                    item.SubItems.Add(qua1.Text);
                    item.SubItems.Add(rat1.Text);
                    item.SubItems.Add(comboBox3.Text);
                    Int32 val1 = Convert.ToInt32(qua1.Text);
                    upp(val1, itde1.Text);
                    Double val2 = Convert.ToDouble(rat1.Text);
                    Double val3 = val1 * val2;

         
                    string val4 = val3.ToString();
                    item.SubItems.Add(comboBox4.Text);
                    item.SubItems.Add( Convert.ToString(val3));
                   
                    Double gstval = Convert.ToDouble(comboBox4.Text);
                   
                    amt = val3+(val3* gstval/100);
                    item.SubItems.Add(Convert.ToString(amt));
                    listView.Items.Add(item);
                    itde1.Text = "";
                    qua1.Text = "";
                    rat1.Text = "";
                    // paglo();
                   
                }
                tot = tot + amt;
                textBox3.Text = Convert.ToString(tot);
                textBox8.Text = Convert.ToString(tot);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("fill proprer data");
            }
            else
            {
                ListViewItem item = new ListViewItem("Services." + comboBox2.Text);
                item.SubItems.Add("");
                item.SubItems.Add(textBox9.Text);
                Int32 val1 = Convert.ToInt32(textBox9.Text);
                tot = tot + val1;
                string val4 = val1.ToString();
                item.SubItems.Add(val4);
                listView.Items.Add(item);
                comboBox2.Text = "";
                textBox9.Text = "";
                //    paglo();
                textBox3.Text = Convert.ToString(tot);
                textBox8.Text = Convert.ToString(tot);
            }
        }
        public void upp(Int32 x ,string s)
        {
            try
            {
                // MessageBox.Show("S="+s);
                // MessageBox.Show("Prod_name='" + s + "'");
                DataRow[] dr = ds18.Tables[0].Select("Prod_name='" + s + "'");
                Int32 st1 = Convert.ToInt32(dr[0]["Qty"]);
               Int32 nes = st1 - x;
                // MessageBox.Show("ST1="+Convert.ToString(st1));
                // MessageBox.Show("NES" + nes.ToString());
                dr[0]["Qty"] = nes.ToString();
                // MessageBox.Show("Stock Limt Will Be Reduse");
            }
            catch (Exception ob)
            {
                MessageBox.Show("Erorr " + ob);
            }

        }
        public String son;
        public void save1(){

            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeCommand cmd = new SqlCeCommand();
            Double r = dataGridView1.RowCount;
            conn.Open();
            try {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO  Estimates ([Cust_name],[Ref],[Date],[Amount]) VALUES('" + salution.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text +"','" + textBox8.Text + "')";
                cmd.ExecuteNonQuery();
                foreach (ListViewItem li in listView.Items)
                {
                    string it = li.SubItems[0].Text;
                    string hsn = li.SubItems[1].Text;
                    string qt = li.SubItems[2].Text;
                    string rat = li.SubItems[3].Text;
                    string mrp = li.SubItems[4].Text;
                    string gst = li.SubItems[5].Text;
                    string tamt = li.SubItems[6].Text;
                    string amt = li.SubItems[7].Text;
                    string q1 = "INSERT INTO Est_Details ([Cust_name],[Ref],[Date],[Expire_date],[Items],[Qty],[Rate],[Amt],[Sub_Total],[Discount],[Adjustment],[Total],[GST],[HSN],[MRP],[tamt])VALUES ('" + salution.Text + "','" + r + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + it + "','" + qt + "','" + rat + "','" + amt + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + gst + "','" + hsn + "','" + mrp + "','" + tamt + "')";
                    SqlCeCommand cmd2 = new SqlCeCommand(q1, conn);
                    cmd2.ExecuteNonQuery();
                }
                if (checkBox1.Checked)
                {
                    cmd.CommandText = "select DISTINCT count([Prod_name]) from goods";
                    int t = (int)cmd.ExecuteScalar();
                    //  MessageBox.Show("" + t);

                    DataRow[] dr = ds18.Tables[0].Select();
                    for (int j = 0; j < t; j++)
                    {
                        Int32 st1 = Convert.ToInt32(dr[j]["Qty"]);
                        String s = Convert.ToString(dr[j]["Prod_name"]);
                        cmd.CommandText = "UPDATE  goods SET [Qty]='" + st1 + "' where [Prod_name]='" + s + "'";
                        cmd.ExecuteNonQuery();
                        //    MessageBox.Show(s);
                        //  MessageBox.Show("" + st1);
                    }

                }

                conn.Close();
                MessageBox.Show("Inserted Data Successfully");
                son = textBox11.Text;
                reload();
                cle();
                inno();
                panel1.Visible = false;

            }
            catch (Exception o) {
                MessageBox.Show("Erorr " + o);
            }
    }

        private void save_Click(object sender, EventArgs e)
        {
           save1();
        }
        void inno()
        {
            Int32 so = dataGridView1.RowCount;
            textBox11.Text = "#EST-" + Convert.ToString(so);
        }
        void cle()
        {
            salution.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            textBox3.Text = "";
            listView.Items.Clear();
            textBox2.Text = "#";
            textBox3.Text = "0";
            textBox5.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
        }

        private void back_Click(object sender, EventArgs e)
        {
            reload();
            panel1.Visible=false;

        }
         public void reload()
         {
             SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd1 = new SqlCeCommand("select * from Estimates order by [EstimatesID] Desc ", conn);
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
             try
             {
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
                 qua1.DataSource = ds18.Tables[0];
                 qua1.DisplayMember = "Qty";
                 comboBox5.DataSource = ds18.Tables[0];
                 comboBox5.DisplayMember = "HSN";
                 comboBox3.DataSource = ds18.Tables[0];
                 comboBox3.DisplayMember = "MRP";
                 comboBox4.DataSource = ds18.Tables[0];
                 comboBox4.DisplayMember = "GST";
                 rat1.DataSource = ds18.Tables[0];
                 rat1.DisplayMember = "Salesp";
                 conn.Close();
                 conn.Open();
                 SqlCeDataAdapter ad17 = new SqlCeDataAdapter("SELECT Ser_name FROM   service  ", conn);
                 ds17 = new DataSet();
                 ad17.Fill(ds17);
                 comboBox6.DataSource = ds17.Tables[0];
                 comboBox6.DisplayMember = "Ser_name";
                 conn.Close();
             }
             catch (Exception o)
             {
                 MessageBox.Show("Erorr" + o);
             }
            
             
         }
        private void Estimates_Load(object sender, EventArgs e)
        {
            paglo();
            
            reload();
            }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd3 = new SqlCeCommand();
            if (e.KeyChar == (char)13)
            {
                try {

                    string query = "SELECT * FROM  Estimates where  [" + comboBox6.Text + "] LIKE '%" + textBox1.Text + "%'";
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
                    MessageBox.Show("Please Choose And Enter Proper Value");
                }
                
            }
            else
                reload();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13 && textBox4.Text != "")
                {
                    Int32 val1 = Convert.ToInt32(textBox4.Text);
                    Double fi = (tot * val1) / 100;
                    textBox5.Text = Convert.ToString(fi);
                    textBox8.Text = Convert.ToString(tot - fi);


                }
            }
            catch (Exception o)
            {
                MessageBox.Show("Please Choose Combobox value");
            }
           
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            try {
                if (e.KeyChar == (char)13 && textBox4.Text != "")
                {
                Int32 val1 = Convert.ToInt32(textBox8.Text);
                Int32 val2 = Convert.ToInt32(textBox6.Text);
                float fi = val1 + val2;
                textBox8.Text = Convert.ToString(fi);
                textBox7.Text = Convert.ToString(val2);
                 
                }
            
            }
            catch (Exception o) { 
            MessageBox.Show("Enter Proper Values In Text Box");
            }
            
            
               
        }

         private void Estimates_Deactivate(object sender, EventArgs e)
        {

            if (textBox2.Text != "#" || textBox3.Text != "0" || textBox5.Text != "0" || textBox7.Text != "0" || textBox8.Text != "0" )
            {
                DialogResult result = MessageBox.Show("Do you want to save the record ?", "caption", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    save1();
                }
                else if (result == DialogResult.No)
                {
                    Estimates ep = new Estimates();
                    ep.Close();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          

        }
        String id;
        int id1;
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
              con.Open();
              
             id=dataGridView1.Rows[e.RowIndex].Cells["EstimatesID"].Value.ToString();
             if (id == "")
             {
                 id1 = 0;
             }
             else
             {
                 id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["EstimatesID"].Value.ToString());
             }

             if (id1 == 0)
             {
                 MessageBox.Show("Please Selected Proper Index For Update Status");
             }
             else
             {
                 SqlCeCommand cmd = con.CreateCommand();
                 cmd.CommandType = CommandType.Text;
                 cmd.CommandText = " UPDATE [Estimates] set [Status]='"+dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString()+ "' where [EstimatesID]="+id1+"";
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Your Status Updated");
                 reload();
             }
            
            
            
            con.Close();
        }
        public static String Sr;
        public static String nam ;
       public  void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Sr = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nam = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            MessageBox.Show("No :"+Sr+"\nName: "+nam);
            EST_CRF f1 = new EST_CRF();
            f1.ShowDialog();
        }

       private void button2_Click(object sender, EventArgs e)
       {
           save1();
           string[] strArr = null;
           int count = 0;
           char[] splitchar = { '-' };
           strArr = son.Split(splitchar);
           string tem = null;
           for (count = 0; count <= strArr.Length - 1; count++)
           {
               if (count == strArr.Length - 1)
                   tem = strArr[count];

               //MessageBox.Show(strArr[count]);
           }
           Estimates.Sr = tem;
           EST_CRF ec = new EST_CRF();
           ec.ShowDialog();
       }

     

      
    }
}
