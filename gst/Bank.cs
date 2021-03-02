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
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
        }
        
        public void loaddat()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeDataAdapter ad19 = new SqlCeDataAdapter("select ([Bank_name]+' - '+[Acc_no])AS NAME from Banks", conn);
            DataSet ds19 = new DataSet();
            ad19.Fill(ds19);
            comboBox4.DataSource = ds19.Tables[0];
            comboBox4.DisplayMember = "NAME";
            comboBox5.DataSource = ds19.Tables[0];
            comboBox5.DisplayMember = "NAME";
            comboBox7.DataSource = ds19.Tables[0];
            comboBox7.DisplayMember = "NAME";
            conn.Close();
        }
        void reload()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd1 = new SqlCeCommand("select [Acc_id] AS ACC_ID,[Bank_name] AS BANK,[Acc_name] AS ACC_HOLDER,[Acc_no] AS ACC_NO,[Acc_type] AS ACC_TYPE ,[Ifsc] AS IFSC_CODE,[Bra_add] AS BRANCH_ADD ,[Opening_bal] AS OPENING_BAL from Banks order by [Acc_id] Desc ", conn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        void reload1()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd1 = new SqlCeCommand("select [TransactionId] AS TRANS_ID,[Date_t] AS DATE,[Acc_id] AS ACCOUNT,[Type] AS TRANS_TYPE,[Party] AS PARTY,[Amount] AS AMOUNT,[Cure] AS CURRENT_BAL,[Pay_mode] AS PAY_MODE,[Descp] AS DESCRIPTION from Trasaction order by [TransactionId] Desc ", conn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            conn.Close();
        }
        public void save1()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeCommand cmd = new SqlCeCommand();
            conn.Open();
            try {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO  Banks ([Bank_name],[Acc_name],[Acc_no],[Ifsc],[Bra_add],[Acc_type],[Opening_bal]) VALUES('" + textBox9.Text + "','" + textBox8.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "')";
                cmd.ExecuteNonQuery();
                string p = "Bank Account Owner";
                string pay = "Account Open";
                string t = "Owner";
                string bi = textBox9.Text + " - " + textBox10.Text;
                cmd.CommandText = "INSERT INTO  Trasaction ([Type],[Party],[Amount],[Cure],[Pay_mode],[Acc_id],[Date_t]) VALUES('" + t + "','" + p + "','" + textBox2.Text + "','" + textBox2.Text + "','" + pay + "','" + bi + "','" + DateTime.Now.ToShortDateString() + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Bank Account Add Successfully");
                loaddat();
                reload();
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                comboBox1.Text = "";
                textBox8.Text = "";
                textBox2.Text = "";
                textBox9.Text = "";

            }
            catch (Exception o)
            {
                MessageBox.Show("Erorr " + o);
            }
           
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            save1();
        }

        private void Bank_Load(object sender, EventArgs e)
        {
            reload();
            loaddat();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox5.Visible = true;
            }
            else

                groupBox5.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox4.Visible = true;
            }
            else

                groupBox4.Visible = false;
        }
        public void save2()
        {   SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeCommand cmd = new SqlCeCommand();
            conn.Open();
            cmd.Connection = conn;
            try {
                cmd.CommandText = "select count([Acc_id]) from [Trasaction] where [Acc_id]='" + comboBox4.Text + "'";
                int t = (int)cmd.ExecuteScalar();
                if (t == 1)
                {

                    if (radioButton2.Checked)
                    {
                        cmd.CommandText = "select [Cure]  from Trasaction  where [Acc_id]='" + comboBox5.Text + "'";
                        SqlCeDataReader read = cmd.ExecuteReader();
                        String pr = null;
                        while (read.Read())
                        {
                            pr = (read["Cure"].ToString());
                        }
                        conn.Close();
                        conn.Open();
                        String s = "Credit";
                        Int32 cu = Convert.ToInt32(pr);
                        Int32 am = Convert.ToInt32(textBox14.Text);
                        Int32 ch = cu + am;
                        cmd.CommandText = "INSERT INTO  Trasaction ([Type],[Party],[Amount],Cure,[Pay_mode],[Descp],[Purpose],[Acc_id],[Date_t]) VALUES('" + s + "','" + textBox13.Text + "','" + textBox14.Text + "','" + Convert.ToString(ch) + "','" + comboBox3.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + comboBox5.Text + "','" + dateTimePicker2.Text + "')";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Credit Trasaction Add Successfully");
                        reload1();
                        textBox14.Text = "";
                        textBox7.Text = "";
                        textBox6.Text = "";
                        textBox13.Text = "";
                        dateTimePicker2.Text = DateTime.Now.ToShortDateString();
                        textBox5.Text = "";
                        comboBox5.Text = "";
                        comboBox3.Text = "";
                        pr = "";
                    }
                    else
                    {
                        if (radioButton1.Checked)
                        {
                            cmd.CommandText = "select Cure  from Trasaction  where [Acc_id]='" + comboBox4.Text + "'";
                            SqlCeDataReader read = cmd.ExecuteReader();
                            String pr = null;
                            while (read.Read())
                            {
                                pr = (read["Cure"].ToString());
                            }
                            conn.Close();
                            conn.Open();
                            String s = "Debit";
                            Int32 cu = Convert.ToInt32(pr);
                            Int32 am = Convert.ToInt32(textBox3.Text);
                            Int32 ch = cu - am;
                            cmd.CommandText = "INSERT INTO  Trasaction ([Type],[Party],[Amount],Cure,[Pay_mode],[Descp],[Purpose],[Acc_id],[Date_t]) VALUES('" + s + "','" + textBox4.Text + "','" + textBox3.Text + "','" + Convert.ToString(ch) + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + textBox1.Text + "','" + comboBox4.Text + "','" + dateTimePicker1.Text + "')";
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Debit Trasaction Add Successfully");
                            reload1();
                            textBox9.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox10.Text = "";
                            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
                            textBox5.Text = "";
                            comboBox2.Text = "";
                            comboBox4.Text = "";
                            textBox1.Text = "";
                            pr = "";
                        }

                    }



                }
                else
                {
                    if (radioButton2.Checked)
                    {
                        cmd.CommandText = "SELECT top(1) Cure FROM [Trasaction]  where [Acc_id] ='" + comboBox5.Text + "' ORDER BY [TransactionId] DESC";
                        SqlCeDataReader read = cmd.ExecuteReader();
                        String pr = null;
                        while (read.Read())
                        {
                            pr = (read["Cure"].ToString());
                        }
                        conn.Close();
                        conn.Open();
                        String s = "Credit";
                        Int32 cu = Convert.ToInt32(pr);
                        Int32 am = Convert.ToInt32(textBox14.Text);
                        Int32 ch = cu + am;
                        cmd.CommandText = "INSERT INTO  Trasaction ([Type],[Party],[Amount],Cure,[Pay_mode],[Descp],[Purpose],[Acc_id],[Date_t]) VALUES('" + s + "','" + textBox13.Text + "','" + textBox14.Text + "','" + Convert.ToString(ch) + "','" + comboBox3.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + comboBox5.Text + "','" + dateTimePicker2.Text + "')";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Credit Trasaction Add Successfully");
                        reload1();
                        textBox14.Text = "";
                        textBox7.Text = "";
                        textBox6.Text = "";
                        textBox13.Text = "";
                        textBox5.Text = "";
                        dateTimePicker2.Text = DateTime.Now.ToShortDateString();
                        comboBox5.Text = "";
                        comboBox3.Text = "";
                        pr = "";
                    }
                    else
                    {
                        if (radioButton1.Checked)
                        {
                            cmd.CommandText = "SELECT top(1) Cure FROM [Trasaction]  where [Acc_id] ='" + comboBox4.Text + "' ORDER BY [TransactionId] DESC";
                            SqlCeDataReader read = cmd.ExecuteReader();
                            String pr = null;
                            while (read.Read())
                            {
                                pr = (read["Cure"].ToString());
                            }
                            conn.Close();
                            conn.Open();
                            String s = "Debit";
                            Int32 cu = Convert.ToInt32(pr);
                            Int32 am = Convert.ToInt32(textBox3.Text);
                            Int32 ch = cu - am;
                            cmd.CommandText = "INSERT INTO  Trasaction ([Type],[Party],[Amount],Cure,[Pay_mode],[Descp],[Purpose],[Acc_id],[Date_t]) VALUES('" + s + "','" + textBox4.Text + "','" + textBox3.Text + "','" + Convert.ToString(ch) + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + textBox1.Text + "','" + comboBox4.Text + "','" + dateTimePicker1.Text + "')";
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Debit Trasaction Add Successfully");
                            reload1();
                            textBox9.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox10.Text = "";
                            textBox5.Text = "";
                            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
                            comboBox2.Text = "";
                            comboBox4.Text = "";
                            textBox1.Text = "";
                            pr = "";
                        }

                    }
                    conn.Close();
                }
            
            
            }
            catch (Exception o) {
                MessageBox.Show("Error "+o);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            save2();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            reload1();
        }

        private void btnsave9_Click(object sender, EventArgs e)
        {
            save2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0; 
        }

        private void btnback9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0; 
        }

        private void Bank_Deactivate(object sender, EventArgs e)
        {
            if (textBox2.Text != "" || textBox3.Text != "" || textBox5.Text != "" || textBox7.Text != "" || textBox8.Text != "")
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

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
            con.Open();
            SqlCeCommand cmd3 = new SqlCeCommand();
            if (e.KeyChar == (char)13)
            {
                try {
                    string query = "SELECT [TransactionId],[Date_t],[Acc_id],[Type],[Party],[Amount],Cure,[Pay_mode],[Descp] FROM  Trasaction where  [" + comboBox6.Text + "] LIKE '%" + textBox15.Text + "%'";
                    using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, con))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView3.DataSource = ds.Tables[0];
                    }
                    con.Close();
                    textBox1.Text = "";
                }
                catch (Exception o) {
                    MessageBox.Show("Please choose Column Form Combo Box");
                }
               
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd2 = new SqlCeCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "SELECT top(1) [Acc_id]AS ACCOUNT_ID,[Cure]AS CURRENT_BALANCE FROM [Trasaction]  where [Acc_id] ='" + comboBox7.Text + "' ORDER BY [TransactionId] DESC";
            SqlCeDataAdapter da1 = new SqlCeDataAdapter(cmd2);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
        }

       
       
    
       
    }
}
