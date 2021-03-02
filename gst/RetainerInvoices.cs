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
    public partial class RetainerInvoices : Form
    {
        public RetainerInvoices()
        {
            InitializeComponent();
        }

        private void New_Click(object sender, EventArgs e)
        {
            cle();
            panel1.Visible = true;
            radioButton1.Checked = false;
            inno();
            paglo();
        }
        int tot = 0;
        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(itde1.Text) || string.IsNullOrEmpty(rat1.Text))
            {
                return;
            }
            else
            {
                ListViewItem item = new ListViewItem(itde1.Text);
                Int32 ra = Convert.ToInt32(rat1.Text);
                tot = tot + ra;
                item.SubItems.Add(rat1.Text);
                listView.Items.Add(item);
                itde1.Clear();
                rat1.Clear();
                textBox11.Text = Convert.ToString(tot);
                textBox8.Text = textBox11.Text;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            reload();
            panel1.Visible = false;
        }
        public String name2;
        public String sno;
        public void save1()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeCommand cmd = new SqlCeCommand();
            Int32 so = dataGridView1.RowCount;
            try {
                conn.Open();
                string q1 = "INSERT INTO  Retainer_Invoice ([Cust_name],[Ref],[Date],[Desp],[Amt],[Invoice_no]) VALUES('" + salution.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox14.Text + "','" + textBox8.Text + "','" + textBox4.Text + "')";
                SqlCeCommand cmd2 = new SqlCeCommand(q1, conn);
                cmd2.ExecuteNonQuery();
                foreach (ListViewItem li in listView.Items)
                {
                    string desc = li.SubItems[0].Text;
                    string rat = li.SubItems[1].Text;
                    string q2 = "INSERT INTO Retainer_Invoice_De ([Cust_name],[Ref],[Date_d],[Desp],[Amt],[Sub_total],[Total])VALUES('" + salution.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + desc + "','" + rat + "','" + textBox11.Text + "','" + textBox8.Text + "')";
                    SqlCeCommand cmd3 = new SqlCeCommand(q2, conn);
                    cmd3.ExecuteNonQuery();
                }
                name2 = salution.Text;
                sno = Convert.ToString(dataGridView1.RowCount);

                string s = "Retainer Invoice Order Pay";
                Int32 so1 = dataGridView1.RowCount;
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO  Payment_recive ([Date_p],[Type],[Ref],[Cust_name],[Mode],[Amt],[Desp]) VALUES('" + dateTimePicker1.Text + "','" + s + "','" + textBox1.Text + "','" + salution.Text + "','" + comboBox2.Text + "','" + textBox8.Text + "','" + textBox14.Text + "')";
                cmd.ExecuteNonQuery();
                if(textBox4.Text !="")
                {
                    //try {
                    using (SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne))
                    {
                        using (SqlCeCommand com = new SqlCeCommand())
                        {
                            com.CommandText = "SELECT [Bal_due],[Paid] FROM [Invoice] WHERE [InvoiceId]=@Search";

                            com.Parameters.AddWithValue("@Search", textBox4.Text);
                            com.Connection = con;
                            con.Open();
                            String pay = null;
                            String paid = null;
                            using (SqlCeDataReader sdr = com.ExecuteReader())
                            {
                                while (sdr.Read())
                                {
                                    pay=(sdr["Bal_due"].ToString());
                                    paid = (sdr["Paid"].ToString());
                                }
                            }
                            con.Close();
                           // MessageBox.Show("Your Pay" + pay);
                            if (pay.Equals(""))
                                pay = "0";
                            Double pa = Convert.ToDouble(pay);
                            Double pan1 = Convert.ToDouble(textBox8.Text);
                            String NewBalDue = Convert.ToString(pa-pan1);
                            //Double olPaid = Convert.ToDouble(paid);
                            String NePaid =paid+"+"+Convert.ToString(pan1);
                            con.Open();
                            com.CommandText = "UPDATE  Invoice SET [Bal_due]='" + NewBalDue + "',[Paid]='"+NePaid+"' where [InvoiceId]='" + textBox4.Text + "'";
                            com.ExecuteNonQuery();
                            con.Close();
                            paglo();

                        }
                    }
                    
                    //}
                    //catch (Exception o) {
                    //    MessageBox.Show("Erorr "+o);
                    //}
              }


               
                conn.Close();
                MessageBox.Show("Inserted Data Successfully");
                conn.Close();
                reload();
                cle();
                inno();
                panel1.Visible = false;
            }
            catch (Exception o)
            {
                MessageBox.Show("Erorr " + o);
            }
           
           
        }
        private void Save_Click(object sender, EventArgs e)
        {
            save1();
        }
        void inno()
        {
            Int32 so = dataGridView1.RowCount;
            textBox1.Text = "#RET-INV-" + Convert.ToString(so);
        }
        public void reload()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd1 = new SqlCeCommand("select [Retainer_Invoice] AS ID,[Date] AS DATE,[Cust_name] AS CUST_NAME,[Ref] AS REFERENCE,[Desp] AS PAY_DESC,[Amt] AS AMT,[Invoice_no] AS INV_NO  from Retainer_Invoice order by [Retainer_Invoice] Desc ", conn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
           public void paglo()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeDataAdapter ad19 = new SqlCeDataAdapter("select [First_name] AS NAME from [customer] ", conn);
            DataSet ds19 = new DataSet();
            ad19.Fill(ds19);
            salution.DataSource = ds19.Tables[0];
            salution.DisplayMember = "Name";
            conn.Close();
            conn.Open();
      }
        void cle()
        {
            textBox2.Text="#";
            textBox4.Text = "";
            salution.Text = "";
            dateTimePicker1.Text =DateTime.Now.ToShortDateString();
            textBox11.Text = "0";
            textBox14.Text = "#";
            comboBox2.Text = "";
            textBox8.Text = "0";
            listView.Items.Clear();
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd3 = new SqlCeCommand();
            if (e.KeyChar == (char)13 && textBox3.Text != null)
            {
                try {
                    string query = "SELECT * FROM  Retainer_Invoice where  [" + comboBox1.Text + "] LIKE '%" + textBox3.Text + "%'";
                    using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    conn.Close();
                    textBox3.Text = "";
                
                }catch(Exception o){
                    MessageBox.Show("Please Choose Combobox Value");
                }
                
            }
            else
                reload();
        }
        private void RetainerInvoices_Load(object sender, EventArgs e)
        {
            reload();
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd = new SqlCeCommand("select [First_name] from [customer] ", conn);
            SqlCeDataAdapter ad19 = new SqlCeDataAdapter("select ([First_name]+' '+[Last_name])AS NAME from [customer] ", conn);
            DataSet ds19 = new DataSet();
            ad19.Fill(ds19);
            salution.DataSource = ds19.Tables[0];
            salution.DisplayMember = "NAME";
            conn.Close();
        }
        private void RetainerInvoices_Deactivate(object sender, EventArgs e)
        {
            if (textBox2.Text != "#" || textBox11.Text != "0"|| textBox8.Text != "0" )
            {
                DialogResult result = MessageBox.Show("Do you want to save the record ?", "caption", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    save1();
                }
                else if (result == DialogResult.No)
                {
                    RetainerInvoices ep = new RetainerInvoices();
                    ep.Close();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox1.Visible = true;
            }
            else
                groupBox1.Visible = false;
        }
       // public static String ret;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Payments.com = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            RCF r = new RCF();
            r.ShowDialog();

        }
        public static string nam;
        public static string number;
        private void button1_Click(object sender, EventArgs e)
        {
            save1();
            number = sno;
            nam = name2;
            RCF rf = new RCF();
            rf.ShowDialog();
        }

       

      
    }
}
