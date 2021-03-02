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
    public partial class RecurringExpMain : Form
    {
        public RecurringExpMain()
        {
            InitializeComponent();
        }

        private void New_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox4.Text = "#REC-EXP-" + dataGridView1.Rows.Count.ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int x = dataGridView1.Rows.Count;
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeCommand cmd = new SqlCeCommand();
            SqlCeCommand cmd1 = new SqlCeCommand();
           // conn.ConnectionString = "Data Source=DELL-PC;Initial Catalog=GST;Integrated Security=True";
            conn.Open();
            cmd.Connection = conn;
            if (checkBox1.Checked)
            {
                string s = "Continuous";
                cmd.CommandText = "INSERT INTO  reccuring_exp([Prof_name],[Billno],[Repeat],[Start_date],[End_date],[Amount],[Paidby],[Vendor],[Notes],[Cust_name]) VALUES('" + textBox2.Text + "','" + textBox6.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Text + "','" + s + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox3.Text + "','" + qua1.Text + "','" + textBox5.Text + "')";
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd1.Connection = conn;
                cmd1.CommandText = "INSERT INTO  reccuring_exp([Prof_name],[Billno],[Repeat],[Start_date],[End_date],[Amount],[Paidby],[Vendor],[Notes],[Cust_name]) VALUES('" +  textBox2.Text + "','" + textBox6.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox3.Text + "','" + qua1.Text + "','" + textBox5.Text + "')";
                cmd1.ExecuteNonQuery();
            }
            string type = " Reccuring Expenses";
            if (textBox3.Text != "0")
            {
                cmd.CommandText = " INSERT INTO Payment_made([Date],[Type],[Ref],[Vendor_name],[Bill_no],[Mode],[Amt],[Desp]) VALUES('" + dateTimePicker1.Text + "','" + type + "','" + textBox4.Text + "','" + comboBox3.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + qua1.Text + "')";
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Inserted Successfully");
            displayit();
            textBox3.Text = "";
            conn.Close();
            textBox4.Text = dataGridView1.Rows.Count.ToString();
            textBox2.Text = "";
            comboBox2.Text = "";
            textBox6.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox3.Text = "";
            qua1.Text = "";
            textBox5.Text = "";
            panel1.Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            displayit();
        }

        private void RecurringExpMain_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            displayit();
            SqlCeConnection con5 = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeCommand cmd19 = new SqlCeCommand("SELECT ([First_Name] + ' ' + [Last_name] )  AS Name  from [vendor]", con5);
            SqlCeDataAdapter ad19 = new SqlCeDataAdapter("SELECT ([First_Name] + ' ' + [Last_name] )  AS Name  from [vendor]", con5);
            DataSet ds19 = new DataSet();
            ad19.Fill(ds19);

            comboBox3.DataSource = ds19.Tables[0];
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "Name";
        }

        void displayit()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd1 = new SqlCeCommand(" SELECT [reccuring_expID],[Prof_name],[Billno],[Repeat],[Start_date],[End_date],[Amount],[Paidby],[Vendor],[Notes],[Cust_name] from reccuring_exp order by  [reccuring_expID] desc ", conn);
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
            if (e.KeyChar == (char)13 && textBox1.Text!=null)
            {
                string query = "SELECT [reccuring_expID],[Prof_name],[Repeat],[Start_date],[End_date],[Amount],[Paidby],[Vendor],[Notes],[Cust_name] from reccuring_exp where [" + comboBox4.Text + "] LIKE '%" + textBox1.Text + "%'";
                using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, con))
                {
                    DataSet ds1 = new DataSet();
                    adapter.Fill(ds1);
                    dataGridView1.DataSource = ds1.Tables[0];
                }
                con.Close();
                textBox1.Text = "";
            }
            else
            {
                displayit();
            }
        }

        private void RecurringExpMain_Deactivate(object sender, EventArgs e)
        {
             if (textBox3.Text != "" ||  qua1.Text != "" || textBox5.Text != "" || textBox2.Text != "")
            {
                DialogResult result = MessageBox.Show("Do you want to save the record ?", "caption", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int x = dataGridView1.Rows.Count;
                    SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
                    SqlCeCommand cmd = new SqlCeCommand();
                   // conn.ConnectionString = "Data Source=DELL-PC;Initial Catalog=GST;Integrated Security=True";
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO  reccuring_exp([Prof_name],[Bill_no],[Repeat],[Start_date],[End_date],[Amount],[Paidby],[Vendor],[Notes],[Cust_name]) VALUES('" +  textBox2.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox3.Text + "','" + qua1.Text + "','" + textBox5.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted Successfully");
                    displayit();
                    textBox3.Text = "";
                    conn.Close();
                    textBox2.Text = "";
                    comboBox2.Text = "";
                    dateTimePicker1.Text = "";
                    dateTimePicker2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                    textBox6.Text = "";
                    comboBox3.Text = "";
                    qua1.Text = "";
                    textBox5.Text = "";
                }

                else if (result == DialogResult.No)
                {
                    Expensemain ep = new Expensemain();
                    ep.Close();
                }

            }
        }

       
    }
}
