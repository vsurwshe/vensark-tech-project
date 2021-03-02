using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.SqlServerCe;

namespace gst
{
    public partial class salesOrder : Form
    {
        
        public salesOrder()
        {
            InitializeComponent();
        }
        void reload()
        {

            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd1 = new SqlCeCommand("select * from Sales_orders order by [Sales_ordersId] Desc", conn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void New_Click(object sender, EventArgs e)
        {
            inno();
            cle();
            panel1.Visible = true;
        }

        int tot=0;
        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(itde1.Text) || string.IsNullOrEmpty(qua1.Text) || string.IsNullOrEmpty(rat1.Text))
            {
                return;
            }
            else
            {
                ListViewItem item = new ListViewItem(itde1.Text);
                item.SubItems.Add(qua1.Text);
                item.SubItems.Add(rat1.Text);
                Int32 val1 = Convert.ToInt32(qua1.Text);
                Int32 val2 = Convert.ToInt32(rat1.Text);
                Int32 val3 = val1 * val2;
                upp(val1, itde1.Text);
                tot = tot + val3;
                string val4 = val3.ToString();
                item.SubItems.Add(val4);
                listView.Items.Add(item);
                itde1.Text = "" ;
                qua1.Text="";
                rat1.Text="";
               // paglo();
                textBox3.Text = Convert.ToString(tot);
                textBox8.Text = Convert.ToString(tot);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox6.Text) || string.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("fill proprer data");
            }
            else
            {
                ListViewItem item = new ListViewItem("Services." + comboBox6.Text);
                item.SubItems.Add("");
                item.SubItems.Add(textBox9.Text);
                Int32 val1 = Convert.ToInt32(textBox9.Text);
                tot = tot + val1;
                string val4 = val1.ToString();
                item.SubItems.Add(val4);
                listView.Items.Add(item);
                comboBox6.Text = "";
                textBox9.Text = "";
                //    paglo();
                textBox3.Text = Convert.ToString(tot);
                textBox8.Text = Convert.ToString(tot);
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            reload();
            panel1.Visible = false;
            
        }
        public String sno; 
        public void save1()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeCommand cmd = new SqlCeCommand();
            try {
                Int32 val1 = Convert.ToInt32(textBox13.Text);
                Int32 val2 = Convert.ToInt32(textBox8.Text);
                Int32 val3 = val2 - val1;
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO  Sales_orders ([Date_s],[Cust_name],[Ref],[Del_date],[Amt],[Paid],[Balance]) VALUES('" + dateTimePicker1.Text + "','" + salution.Text + "','" + textBox2.Text + "','" + dateTimePicker2.Text + "','" + textBox8.Text + "','" + textBox13.Text + "','" + val3 + "')";
                cmd.ExecuteNonQuery();
                foreach (ListViewItem li in listView.Items)
                {
                    string it = li.SubItems[0].Text;
                    string qt = li.SubItems[1].Text;
                    string rat = li.SubItems[2].Text;
                    string amt = li.SubItems[3].Text;
                    string q1 = "INSERT INTO Sales_orders_De ([Date_s],[Cust_name],[Ref],[Del_date],[Amt],[Items],[Qty],[Rate],[Sub_total],[Dis],[Adj],[Total])VALUES ('" + dateTimePicker1.Text + "','" + salution.Text + "','" + textBox11.Text + "','" + dateTimePicker2.Text + "','" + amt + "','" + it + "','" + qt + "','" + rat + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
                    SqlCeCommand cmd2 = new SqlCeCommand(q1, conn);
                    cmd2.ExecuteNonQuery();
                }
                if (textBox13.Text != "0")
                {
                    string s = "Sales Order Pay";
                    Int32 so1 = dataGridView1.RowCount;
                    cmd.CommandText = "INSERT INTO  Payment_recive ([Date_p],[Type],[Ref],[Cust_name],[Mode],[Amt],[Desp]) VALUES('" + dateTimePicker1.Text + "','" + s + "','" + textBox11.Text + "','" + salution.Text + "','" + comboBox2.Text + "','" + textBox13.Text + "','" + textBox14.Text + "')";
                    cmd.ExecuteNonQuery();
                }

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

                sno = dataGridView1.RowCount.ToString();
                conn.Close();
                MessageBox.Show("Inserted Data Successfully");
                reload();
                inno();
                cle();
                panel1.Visible = false;
            }
            catch (Exception o) {
                MessageBox.Show("Erorr "+o);
            }
            

        }
        DataSet ds18,ds17;
        public void paglo()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeDataAdapter ad19 = new SqlCeDataAdapter("select ([First_name]+' '+[Last_name]) AS NAME from [customer] ", conn);
            DataSet ds19 = new DataSet();
            ad19.Fill(ds19);
            salution.DataSource = ds19.Tables[0];
            salution.DisplayMember = "Name";
            conn.Close();
            conn.Open();
            SqlCeDataAdapter ad18 = new SqlCeDataAdapter("select [Prod_name],[Qty],[Salesp]from [goods] ", conn);
            ds18 = new DataSet();
            ad18.Fill(ds18);
            itde1.DataSource = ds18.Tables[0];
            itde1.DisplayMember = "Prod_name";
            qua1.DataSource = ds18.Tables[0];
            qua1.DisplayMember = "Qty";
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
        public void upp(int x, string s)
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
        
        void inno()
        {
            Int32 so = dataGridView1.RowCount;
            textBox11.Text = "#SAO-" + Convert.ToString(so);
        }
        void cle()
        {
            textBox2.Text="#";
            salution.Text = "";
            dateTimePicker1.Text =DateTime.Now.ToShortDateString();
            dateTimePicker2.Text =DateTime.Now.ToShortDateString();
            textBox3.Text = "0";
            textBox5.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox13.Text = "0";
            comboBox2.Text = "";
            textBox14.Text = "#";
            listView.Items.Clear();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            save1();
        }

        private void salesOrder_Load(object sender, EventArgs e)
        {
            paglo();
            reload();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd3 = new SqlCeCommand();
            if (e.KeyChar == (char)13 && textBox1.Text != null)
            {
                try {
              
                string query = "SELECT * FROM  Sales_orders where  ["+comboBox3.Text+"] LIKE '%" + textBox1.Text + "%'";
                using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                conn.Close();
                textBox1.Text = "";
                
                } catch (Exception o){
                      MessageBox.Show("Choose Your Combo Box Vlaue");
                }
                
            }  else
                reload();
        }
        //public static String sal;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          Payments.com=dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SO_CRF s = new SO_CRF();
            s.Show();


        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && textBox4.Text != "")
            {
                Int32 val1 = Convert.ToInt32(textBox4.Text);
                float fi = (tot * val1) / 100;
                textBox5.Text = Convert.ToString(fi);
                textBox8.Text = Convert.ToString(tot - fi);

            }
            else
                MessageBox.Show("Enetr Proper Value In Text Box");
            

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && textBox6.Text != "")
            {
                Int32 val1 = Convert.ToInt32(textBox8.Text);
                Int32 val2 = Convert.ToInt32(textBox6.Text);
                float fi = val1 + val2;
                //MessageBox.Show("val2" + val2 + "val1" + val1);
                textBox8.Text = Convert.ToString(fi);
                textBox7.Text = Convert.ToString(val2);

            }
            else
                MessageBox.Show("Enter Proper Value In Text Box");
        }

      

        private void salesOrder_Deactivate(object sender, EventArgs e)
        {
            if (textBox2.Text != "#" || textBox3.Text != "0" || textBox5.Text != "0" || textBox7.Text != "0" || textBox8.Text != "0" || textBox13.Text != "0" || textBox14.Text != "#" )
            {
                DialogResult result = MessageBox.Show("Do you want to save the record ?", "caption", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    save1();
                }
                else if (result == DialogResult.No)
                {
                    salesOrder ep = new salesOrder();
                    ep.Close();
                }
            }
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            save1();
            Payments.com = sno;
            SO_CRF s = new SO_CRF();
            s.ShowDialog();
        }

        

   
    }
}
