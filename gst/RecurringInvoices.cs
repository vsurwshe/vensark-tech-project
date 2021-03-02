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
    public partial class RecurringInvoices : Form
    {
        public RecurringInvoices()
        {
            InitializeComponent();
        }

        private void New_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            reload();
            panel1.Visible = false;
        }
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
        public void upp(int x, string s)
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
            Int32 st = Convert.ToInt32(pr);
            Int32 nes = st - x;
            cmd.CommandText = "UPDATE  goods SET [Qty]='" + Convert.ToString(nes) + "' where [Prod_name]='" + s + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Stock Limt Will Be Reduse");
        }
        int tot = 0;
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
                upp(val1, itde1.Text);
                Int32 val2 = Convert.ToInt32(rat1.Text);
                Int32 val3 = val1 * val2;
                tot = tot + val3;
                string val4 = val3.ToString();
                item.SubItems.Add(val4);
                listView.Items.Add(item);
                itde1.Text="";
                qua1.Text="";
                rat1.Text="";
                paglo();
                textBox11.Text = Convert.ToString(tot);
                textBox8.Text = Convert.ToString(tot);
            }

        }
        public void save1()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeCommand cmd = new SqlCeCommand();
            SqlCeCommand cmd1 = new SqlCeCommand();

            //conn.ConnectionString = @"Data Source=VISHVA-PC\VISHVANTH;Initial Catalog=GST;Integrated Security=True";
            conn.Open();
            if (checkBox1.Checked)
            {
                string s = "Continuos";
                cmd1.Connection = conn;
                cmd1.CommandText = "INSERT INTO  Recuring_Invoice ([Cust_name],[Pro_name],[Freq],[Last_date],[Next_date],[Status],[Amt]) VALUES('" + salution.Text + "','" + textBox3.Text + "','" + comboBox2.Text + "','" + s + "','" + dateTimePicker2.Text + "','" + comboBox3.Text + "','" + textBox8.Text + "')";
                cmd1.ExecuteNonQuery();
            }
            else
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO  Recuring_Invoice ([Cust_name],[Pro_name],[Freq],[Last_date],[Next_date],[Status],[Amt]) VALUES('" + salution.Text + "','" + textBox3.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + comboBox3.Text + "','" + textBox8.Text + "')";
                cmd.ExecuteNonQuery();
            }
            
            
            
            foreach (ListViewItem li in listView.Items)
            {
                string it = li.SubItems[0].Text;
                string qt = li.SubItems[1].Text;
                string rat = li.SubItems[2].Text;
                string amt = li.SubItems[3].Text;

                if (checkBox1.Checked)
                {
                    string q1 = "INSERT INTO  Recuring_Invoice_De ([Cust_name],[Pro_name],[Rept_evry],[Start_d],[End_d],[Pay_term],[Items],[Qty],[Rate],[Amt],[Sub_total],[Dis],[Adj],[Total]) VALUES('" + salution.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + comboBox3.Text + "','" + it + "','" + qt + "','" + rat + "','" + amt + "','" + textBox11.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
                    SqlCeCommand cmd2 = new SqlCeCommand(q1, conn);
                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    string q2 = "INSERT INTO  Recuring_Invoice_De ([Cust_name],[Pro_name],[Rept_evry],[Start_d],[End_d],[Pay_term],[Items],[Qty],[Rate],[Amt],[Sub_total],[Dis],[Adj],[Total]) VALUES('" + salution.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + comboBox3.Text + "','" + it + "','" + qt + "','" + rat + "','" + amt + "','" + textBox11.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
                    SqlCeCommand cmd3 = new SqlCeCommand(q2, conn);
                    cmd3.ExecuteNonQuery();
                }
            }
            conn.Close();
            MessageBox.Show("Inserted Data Successfully");
            reload();
            cle();
            inno();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            save1();

        }
        void cle()
        {
            textBox2.Clear();
            salution.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox11.Clear();
            listView.Clear();
        }
        void inno()
        {
            Int32 so = dataGridView1.RowCount;
            //textBox2.Text = "REC.INV" + Convert.ToString(so);
        }
        public void reload()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd1 = new SqlCeCommand("select * from Recuring_Invoice ", conn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd3 = new SqlCeCommand();
            if (e.KeyChar == (char)13 && textBox1.Text != null)
            {
                string query = "SELECT * FROM  Recuring_Invoice where  [" + comboBox4.Text + "] LIKE '%" + textBox1.Text + "%'";
                using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                conn.Close();
                textBox1.Text = "";
            }
            else
                reload();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Int32 val1 = Convert.ToInt32(textBox4.Text);
                float fi = (tot * val1) / 100;
                textBox5.Text = Convert.ToString(fi);
                textBox8.Text = Convert.ToString(tot - fi);

            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Int32 val1 = Convert.ToInt32(textBox8.Text);
                Int32 val2 = Convert.ToInt32(textBox6.Text);
                float fi = val1 + val2;
                MessageBox.Show("val2" + val2 + "val1" + val1);
                textBox8.Text = Convert.ToString(fi);
                textBox7.Text = Convert.ToString(val2);

            }
        }

        private void RecurringInvoices_Load(object sender, EventArgs e)
        {
            reload();
            paglo();
        }

        private void RecurringInvoices_Deactivate(object sender, EventArgs e)
        {
            if (textBox2.Text != "" || textBox3.Text != "" || textBox5.Text != "" || textBox7.Text != "" || textBox8.Text != "" || textBox11.Text != "" || comboBox2.Text != "" || comboBox2.Text != "")
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

            id = dataGridView1.Rows[e.RowIndex].Cells["Recuring_InvoiceID"].Value.ToString();
            if (id == "")
            {
                id1 = 0;
            }
            else
            {
                id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Recuring_InvoiceID"].Value.ToString());
            }

            if (id1 == 0)
            {
                MessageBox.Show("Please Selected Proper Index For Update Status");
            }
            else
            {
                SqlCeCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " UPDATE [Recuring_Invoice] set [Status]='" + dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString() + "' where [Recuring_InvoiceID]=" + id1 + "";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Status Updated");
                reload();
            }



            con.Close();
        }
    }
}
