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
    public partial class Expensemain : Form
    {
        public Expensemain()
        {
            InitializeComponent();
        }
        private void New_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            textBox3.Text = "#EXP-" + dataGridView1.Rows.Count.ToString();
            textBox2.Text = "0";
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                int x = dataGridView1.Rows.Count;
                SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
                SqlCeCommand cmd = new SqlCeCommand();
                //conn.ConnectionString = "Data Source=DELL-PC;Initial Catalog=GST;Integrated Security=True";
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = " INSERT INTO expenses ([Date],[Amount],[Paidby],[Vendor],[Billno],[Notes],[Cust_name],[Pay_details],[Expense_acc]) VALUES('" + dateTimePicker1.Text + "','" + textBox2.Text + "','" + comboBox3.Text + "','" + salution.Text + "','" + itde1.Text + "','" + qua1.Text + "','" + rat1.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "')";
                cmd.ExecuteNonQuery();
                string type = "Expenses";
                if (textBox2.Text != "0")
                {
                    cmd.CommandText = " INSERT INTO Payment_made([Date],[Type],[Ref],[Vendor_name],[Bill_no],[Mode],[Amt],[Desp]) VALUES('" + dateTimePicker1.Text + "','" + type + "','" + textBox3.Text + "','" + salution.Text + "','" + itde1.Text + "','" + comboBox3.Text + "','" + textBox2.Text + "','" + qua1.Text + "')";
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Inserted Successfully");
                showit();
                conn.Close();
                dateTimePicker1.Text = "";
                textBox2.Text = "";
                comboBox3.Text = "";
                salution.Text = "";
                itde1.Text = "";
                qua1.Text = "";
                rat1.Text = "";
                textBox4.Text = "";
                comboBox2.Text = "";
                panel1.Visible = false;
            }
            catch (Exception o)
            {
                MessageBox.Show("Error :" + o);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            showit();
        }

        private void Expensemain_Load(object sender, EventArgs e)
        {
            showit();
            SqlCeConnection con5 = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeDataAdapter ad19 = new SqlCeDataAdapter("SELECT Shop_name  from [vendor]", con5);
            DataSet ds19 = new DataSet();
            ad19.Fill(ds19);
            salution.DataSource = ds19.Tables[0];
            salution.DisplayMember = "Shop_name";
            salution.ValueMember = "Shop_name";

            SqlCeConnection con7 = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeDataAdapter ad10 = new SqlCeDataAdapter("SELECT Expense_acc from [expenses]", con7);
            DataSet ds10 = new DataSet();
            ad10.Fill(ds10);
            comboBox2.DataSource = ds10.Tables[0];
            comboBox2.DisplayMember = "Expense_acc";
            comboBox2.ValueMember = "Expense_acc";
        }


        void showit()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd1 = new SqlCeCommand("select [expensesID],[Date],[Amount],[Vendor],[Paidby],[Cust_name],[Billno],[Notes],[Pay_details],[Expense_acc]  from expenses order by [expensesID] desc ", conn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            textBox2.Text = "0";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
            con.Open();
            SqlCeCommand cmd3 = new SqlCeCommand();
            if (e.KeyChar == (char)13) //&& textBox1.Text != null)
            {
                try
                {
                    string query = "SELECT [expensesID],[Date],[Amount],[Vendor],[Paidby],[Cust_name],[Billno],[Notes],[Pay_details],[Expense_acc] from expenses where [" + comboBox1.Text + "] LIKE '%" + textBox1.Text + "%'";
                    using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, con))
                    {
                        DataSet ds1 = new DataSet();
                        adapter.Fill(ds1);
                        dataGridView1.DataSource = ds1.Tables[0];
                    }
                    con.Close();
                    textBox1.Text = "";
                }
                catch(Exception ab)
                {
                    MessageBox.Show("Please Select a Value from the Combobox");
                }
            }

            else
            {
                showit();
            }
        }

        private void Expensemain_Deactivate(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != "0" && textBox2.Text != "" || comboBox3.Text != "" || rat1.Text != "" || itde1.Text != "" || qua1.Text != "" || textBox4.Text != "" || comboBox2.Text != "")
                {
                    DialogResult result = MessageBox.Show("Do you want to save the record ?", "caption", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                        int x = dataGridView1.Rows.Count;
                        SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
                        SqlCeCommand cmd = new SqlCeCommand();
                        //conn.ConnectionString = "Data Source=DELL-PC;Initial Catalog=GST;Integrated Security=True";
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = " INSERT INTO expenses ([Date],[Amount],[Paidby],[Vendor],[Billno],[Notes],[Cust_name],[Pay_details]) VALUES('" + dateTimePicker1.Text + "','" + textBox2.Text + "','" + comboBox3.Text + "','" + salution.Text + "','" + itde1.Text + "','" + qua1.Text + "','" + rat1.Text + "','" + textBox4.Text + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Inserted Successfully");
                        showit();
                        textBox3.Text = "Exp" + dataGridView1.Rows.Count.ToString();
                        conn.Close();
                        dateTimePicker1.Text = "";
                        textBox2.Text = "";
                        comboBox3.Text = "";
                        salution.Text = "";
                        itde1.Text = "";
                        qua1.Text = "";
                        rat1.Text = "";
                        textBox4.Text = "";
                        comboBox2.Text = "";
                    }
                    else if (result == DialogResult.No)
                    {
                        Expensemain ep = new Expensemain();
                        ep.Close();
                    }
                }
            }
            catch(Exception ab1)
            {
                MessageBox.Show("Error :" + ab1);
            }


            //   private void Autocomplete()
            //{
            //    try
            //    {
            //        SqlCeConnection con6 = new SqlCeConnection("Data Source=DELL-PC;Initial Catalog=GST;Integrated Security=True");
            //        SqlCeCommand cmd9 = new SqlCeCommand("SELECT [Cust_name] from [expenses]", con6);
            //        DataSet ds = new DataSet();
            //        SqlCeDataAdapter ad9 = new SqlCeDataAdapter("SELECT [Cust_name] from [expenses]", con6);
            //        ad9.Fill(ds, "expenses");
            //        AutoCompleteStringCollection col = new   
            //        AutoCompleteStringCollection();
            //        int i = 0;
            //        for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            //        {
            //            col.Add(ds.Tables[0].Rows[i]["Cust_name"].ToString());

            //        }
            //        textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //        textBox1.AutoCompleteCustomSource = col;
            //        textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;

            //        con6.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //}


        }
      
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PaymentMain.com = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            EXP ob2 = new EXP();
            ob2.ShowDialog();
        }

    }
}
