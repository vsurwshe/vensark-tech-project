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

namespace gst
{
    public partial class PurchaseOrder : Form
    {
        public PurchaseOrder()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox4.Text = "#PO-" + dataGridView1.Rows.Count.ToString();
            textBox3.Text = "0";
        }

        private void back_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            showed();
            cle();
        }
       Double tot = 0;
        private void add_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (string.IsNullOrEmpty(itde1.Text) || string.IsNullOrEmpty(qua1.Text) || string.IsNullOrEmpty(rat1.Text))
                {

                    return;
                }
                else
                {
                    ListViewItem item = new ListViewItem(itde1.Text);
                    item.SubItems.Add(qua1.Text);
                    item.SubItems.Add(rat1.Text);
                    Double val1 = Convert.ToDouble(qua1.Text);
                    //upp(val1, itde1.Text);
                    Double val2 = Convert.ToDouble(rat1.Text);
                    Double val3 = val1 * val2;
                    tot = tot + val3;
                    string val4 = val3.ToString();
                    item.SubItems.Add(val4);
                    listView.Items.Add(item);
                    textBox8.Text = tot.ToString();
                    itde1.Text = "";
                    qua1.Text = "";
                    rat1.Text = "";
                   // paglo();
                }
            //}
            //catch(Exception ab5)
            //{
            //    MessageBox.Show("" + ab5);
            //}
        }

        public void upp(int x, string s)
        {
            try
            {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeCommand cmd = new SqlCeCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT  [Qty] FROM [goods] ";
            SqlCeDataReader read = cmd.ExecuteReader();
            String pr = null;
            while (read.Read())
            {
                pr = (read["Qty"].ToString());
            }
            conn.Close();
            conn.Open();
            Double st = Convert.ToDouble(pr);
            Double nes = st - x;
            cmd.CommandText = "UPDATE  goods SET [Qty]='" + Convert.ToString(nes) + "' where [Prod_name]='" + s + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Stock Limt Will Be Reduced");
            }
            catch (Exception ab5)
            {
                MessageBox.Show("" + ab5);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
             try
            {
            int x = dataGridView1.Rows.Count;
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeCommand cmd = new SqlCeCommand();
            conn.Open();
            cmd.Connection = conn;
            foreach (ListViewItem li in listView.Items)
            {
                string it = li.SubItems[0].Text;
                string qt = li.SubItems[1].Text;
                string rat = li.SubItems[2].Text;
                string amt = li.SubItems[3].Text;
                string q1 = "INSERT INTO  pur_detail ([Vendor_name],[Ref],[Date],[Del_date],[Items],[Qty],[Rate],[Total]) VALUES('" + salution.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + it + "','" + qt + "','" + rat + "','" + amt + "')";
                SqlCeCommand cmd2 = new SqlCeCommand(q1, conn);
                cmd2.ExecuteNonQuery();
            }
           Double val1 = Convert.ToDouble(textBox3.Text);
            Double val2 = Convert.ToDouble(textBox8.Text);
            Double val3 = val2 - val1;
            cmd.CommandText = "INSERT INTO purchase_order([Date],[Vendor_name],[Ref],[Del_date],[Amt],[Paid],[Bal],[Pay_detail]) VALUES ('" + dateTimePicker1.Text + "','" + salution.Text + "','" + textBox2.Text + "','" + dateTimePicker2.Text + "','" + textBox8.Text + "','" + textBox3.Text + "','" + val3 + "','" + textBox9.Text + "')";
            cmd.ExecuteNonQuery();
            string type = "Purchase Order";
            //if (textBox3.Text != "0")
            //{
                cmd.CommandText = " INSERT INTO Payment_made([Date],[Type],[Ref],[Vendor_name],[Mode],[Amt],[Desp]) VALUES('" + dateTimePicker1.Text + "','" + type + "','" + textBox4.Text + "','" + salution.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox9.Text + "')";
                cmd.ExecuteNonQuery();
            //}
            MessageBox.Show("Inserted Successfully");
            conn.Close();
            showed();
            textBox4.Text = dataGridView1.Rows.Count.ToString();
            listView.Items.Clear();
            itde1.Text = "";
            qua1.Text = "";
            rat1.Text = "";
            salution.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            textBox8.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "0";
            textBox9.Text = "";
            comboBox1.Text = "";
            panel1.Visible = false;
            }
             catch (Exception ab5)
             {
                 MessageBox.Show("" + ab5);
             }
        }

        public void paglo()
        {
            try
            {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeDataAdapter ad19 = new SqlCeDataAdapter("select Shop_name from [vendor] ", conn);
            DataSet ds19 = new DataSet();
            ad19.Fill(ds19);
            salution.DataSource = ds19.Tables[0];
            salution.DisplayMember = "Shop_name";
            conn.Close();
            conn.Open();
            SqlCeDataAdapter ad18 = new SqlCeDataAdapter("select [Prod_name],[Qty],[Salesp]from [goods] ", conn);
            DataSet ds18 = new DataSet();
            ad18.Fill(ds18);
            itde1.DataSource = ds18.Tables[0];
            itde1.DisplayMember = "Prod_name";
            qua1.DataSource = ds18.Tables[0];
            qua1.DisplayMember = "Qty";
            rat1.DataSource = ds18.Tables[0];
            rat1.DisplayMember = "Salesp";
            conn.Close();
            }
            catch (Exception ab5)
            {
                MessageBox.Show("" + ab5);
            }
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            showed();
            paglo();
           
        }

       void showed()
       {
           SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
           conn.Open();
           SqlCeCommand cmd1 = new SqlCeCommand(" SELECT * from purchase_order order by [purchase_orderID] desc  ", conn);
           SqlCeDataAdapter da = new SqlCeDataAdapter(cmd1);
           DataTable dt = new DataTable();
           da.Fill(dt);
           dataGridView1.DataSource = dt;
           conn.Close();
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
                   string query = "SELECT [Vendor_name],[Date],[Ref],[Del_date],[Amt],[Paid],[Bal],[Pay_detail] from purchase_order where [" + comboBox2.Text + "] LIKE '%" + textBox1.Text + "%'";
                   using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, con))
                   {
                       DataSet ds1 = new DataSet();
                       adapter.Fill(ds1);
                       dataGridView1.DataSource = ds1.Tables[0];
                   }
                   con.Close();
                   textBox1.Text = "";
               }
               catch(Exception ab6)
               {
                   MessageBox.Show("Please select a Value from the Combobox" + ab6);
               }
           }
           else
           {
               showed();
           }
       }

       private void PurchaseOrder_Deactivate(object sender, EventArgs e)
       {
           if (textBox3.Text != "0" ||  textBox8.Text != "" || textBox9.Text != "" || textBox2.Text != "")
           {
               DialogResult result = MessageBox.Show("Do you want to save the record ?", "caption", MessageBoxButtons.YesNo);
               if (result == DialogResult.Yes)
               {
                  try
                  {
                   int x = dataGridView1.Rows.Count;
                   SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
                   SqlCeCommand cmd = new SqlCeCommand();
                  // conn.ConnectionString = "Data Source=DELL-PC;Initial Catalog=GST;Integrated Security=True";
                   conn.Open();
                   cmd.Connection = conn;
                   foreach (ListViewItem li in listView.Items)
                   {
                       string it = li.SubItems[0].Text;
                       string qt = li.SubItems[1].Text;
                       string rat = li.SubItems[2].Text;
                       string amt = li.SubItems[3].Text;
                       string q1 = "INSERT INTO  pur_detail ([Vendor_name],[Ref],[Date],[Del_date],[Items],[Qty],[Rate],[Total]) VALUES('" +  salution.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + it + "','" + qt + "','" + rat + "','" + amt + "')";
                       SqlCeCommand cmd2 = new SqlCeCommand(q1, conn);
                       cmd2.ExecuteNonQuery();
                   }

                   Double val1 = Convert.ToDouble(textBox3.Text);
                   Double val2 = Convert.ToDouble(textBox8.Text);
                   Double val3 = val2 - val1;
                   cmd.CommandText = "INSERT INTO purchase_order([Date],[Vendor_name],[Ref],[Del_date],[Amt],[Paid],[Bal],[Pay_detail]) VALUES ('" + dateTimePicker1.Text + "','" + salution.Text + "','" + textBox2.Text + "','" + dateTimePicker2.Text + "','" + textBox8.Text + "','" + textBox3.Text + "','" + val3  + "','" + textBox9.Text + "')";
                   cmd.ExecuteNonQuery();
                   MessageBox.Show("Inserted Successfully");
                   listView.Items.Clear();
                   itde1.Text = "";
                   qua1.Text = "";
                   rat1.Text = "";
                   salution.Text = "";
                   dateTimePicker1.Text = "";
                   dateTimePicker2.Text = "";
                   textBox8.Text = "";
                   textBox2.Text = "";
                   textBox4.Text = "";
                   textBox3.Text = "0";
                   textBox9.Text = "";
                   comboBox1.Text = "";
                   panel1.Visible = false;
                  }
                  catch (Exception ab4)
                  {
                      MessageBox.Show("Error :" + ab4);
                  }


               }
               else if (result == DialogResult.No)
               {
                   Expensemain ep = new Expensemain();
                   ep.Close();
               }

           }
       }
       public void cle()
       {
           listView.Items.Clear();
           itde1.Text = "";
           qua1.Text = "";
           rat1.Text = "";
           salution.Text = "";
           dateTimePicker1.Text = "";
           dateTimePicker2.Text = "";
           textBox8.Text = "";
           textBox8.Text = "";
           textBox2.Text = "";
           textBox4.Text = "";
           textBox3.Text = "";
           textBox9.Text = "";
       }
       public static string abdef;
       private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
       {
           abdef = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           pur1 ob10 = new pur1();
           ob10.ShowDialog();
       }

    }
}
