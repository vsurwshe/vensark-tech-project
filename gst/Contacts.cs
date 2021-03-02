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
    public partial class Contacts : Form
    {
        SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
        DataSet ds;
       
        public Contacts()
        {
            InitializeComponent();
        }

      
   

        private void New_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            save.Visible = false;
            back.Visible = false;

           
        }

      

        private void back_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }
        public void save1()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeCommand cmd = new SqlCeCommand();

            
            if (radioButton1.Checked)
            {
                conn.Open();
                
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO  vendor([Salut],[First_name],[Email],[Mob1],[Mob2],[Web],[Patta],[Shop_name],[Bank_name],[Acc_name],[Acc_no],[Ifsc],[Branch_add],[Acc_type],[GSTIN]) VALUES('" + salution.Text + "','" + textBox6.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox7.Text + "','" + textBox5.Text + "','" + con_addTextBox.Text + "','" + shp1.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox14.Text + "','" + textBox2.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted Successfully");
                conn.Close();
                salution.Text = "";
                textBox6.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox7.Text = "";
                textBox5.Text = "";
                textBox2.Text = "";
                con_addTextBox.Text = "";
                shp1.Text = "";
                textBox9.Text = "";
                textBox8.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox14.Text = "";
                reload();
            }
            else
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO  customer([Salut],[First_name],[Email],[Mob1],[Mob2],[Web],[Patta],[GSTIN]) VALUES('" + salution.Text + "','" + textBox6.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox7.Text + "','" + textBox5.Text + "','" + con_addTextBox.Text + "','" + textBox2.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted Successfully");
                conn.Close();
                salution.Text = "";
                textBox6.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox7.Text = "";
                textBox5.Text = "";
                textBox2.Text = "";
                con_addTextBox.Text = "";
                reload2();


            }
            panel1.Visible = false;
        }
        private void save_Click_1(object sender, EventArgs e)
        {
            save1();
            
            update.Enabled= false;
            delete.Enabled= false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int cr = dataGridView2.RowCount;
                textBox15.Text = "#VEN-" + Convert.ToString(cr);
                groupBox3.Visible = true;
                groupBox2.Visible = true;
                groupBox1.Visible = true;
                save.Visible = true;
                back.Visible = true;

            }
            else
            {
                groupBox3.Visible = false;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                save.Visible = false;
                back.Visible = false;
            }
        }
       
        private void Contacts_Load(object sender, EventArgs e)
        {
            reload2();
            reload();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            
        }
        private void dataGridView2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = dataGridView2.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = dataGridView2.SortedColumn;
            ListSortDirection direction;
            if (oldColumn != null)
            {
                if (oldColumn == newColumn &&
                    dataGridView2.SortOrder == System.Windows.Forms.SortOrder.Descending)
                {
                    direction = ListSortDirection.Ascending;
                }
                else
                {
                    direction = ListSortDirection.Descending;
                    oldColumn.HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.None;
                }
            }
                else
                {
                    direction = ListSortDirection.Descending;
                }

            dataGridView2.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
            direction == ListSortDirection.Descending ?
            System.Windows.Forms.SortOrder.Descending : System.Windows.Forms.SortOrder.Ascending;
        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox15.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            salution.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textBox6.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            textBox7.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            textBox5.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            con_addTextBox.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
            textBox2.Text = dataGridView2.SelectedRows[0].Cells[15].Value.ToString();
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            shp1.Text = dataGridView2.SelectedRows[0].Cells[8].Value.ToString();
            textBox9.Text = dataGridView2.SelectedRows[0].Cells[9].Value.ToString();
            textBox8.Text = dataGridView2.SelectedRows[0].Cells[10].Value.ToString();
            textBox10.Text = dataGridView2.SelectedRows[0].Cells[11].Value.ToString();
            textBox11.Text = dataGridView2.SelectedRows[0].Cells[12].Value.ToString();
            textBox12.Text = dataGridView2.SelectedRows[0].Cells[13].Value.ToString();
            textBox14.Text = dataGridView2.SelectedRows[0].Cells[14].Value.ToString();
            radioButton1.Checked=true;
            panel1.Visible = true;
            update.Visible = true;
            delete.Visible = true;
            save.Visible = false;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            groupBox2.Visible = true;
            textBox15.Text= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            salution.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            con_addTextBox.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            panel1.Visible = true;
            update.Visible = true;
            delete.Visible = true;
            save.Visible = false;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = dataGridView1.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = dataGridView1.SortedColumn;
            ListSortDirection direction;
            if (oldColumn != null)
            {
                if (oldColumn == newColumn &&
                    dataGridView1.SortOrder == System.Windows.Forms.SortOrder.Descending)
                {
                    direction = ListSortDirection.Ascending;
                }
                else
                {
                    direction = ListSortDirection.Descending;
                    oldColumn.HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Descending;
            }

            dataGridView1.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
            direction == ListSortDirection.Descending ?
            System.Windows.Forms.SortOrder.Descending : System.Windows.Forms.SortOrder.Ascending;
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
            con.Open();
            SqlCeCommand cmd3 = new SqlCeCommand();
            if (e.KeyChar == (char)13)
            {
                try
                {
                   string query = "SELECT [customerID],[Salut],[First_name],[Email],[Mob1],[Mob2],[Web],[Patta]AS Address FROM [customer] where[" + comboBox6.Text + "] LIKE '%" + textBox1.Text + "%'";
                    using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, con))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    con.Close();
                    textBox1.Text = "";
                }
                catch (Exception ob)
                {
                    MessageBox.Show("Please Choose Your Colume Form Combobox ");
                }

               
            }
            else
                reload2();
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);
            con.Open();
            SqlCeCommand cmd3 = new SqlCeCommand();
            if (e.KeyChar == (char)13)
            {
                try {
                    string query = "SELECT [vendorID],[Salut],[First_name],[Email],[Mob1],[Mob2],[Web],[Patta],[Shop_name],[Bank_name],[Acc_name],[Acc_no],[Ifsc],[Branch_add],[Acc_type] FROM [vendor] where [" + comboBox2.Text + "] LIKE '%" + textBox13.Text + "%'";
                    using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, con))
                    {
                        DataSet ds1 = new DataSet();
                        adapter.Fill(ds1);
                        dataGridView2.DataSource = ds1.Tables[0];
                    }
                    con.Close();
                    textBox13.Text = "";
                }
                catch (Exception ob) {
                    MessageBox.Show("Please Choose Your Colume Form Combobox ");
                }
                
            }
            else
                reload();
        }

        private void update_Click(object sender, EventArgs e)
        {

            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            SqlCeCommand cmd = new SqlCeCommand();
            

            if (radioButton1.Checked)
            {
               
               conn.Open();
                cmd.Connection = conn;
                string n = textBox6.Text;
                cmd.CommandText = "UPDATE  vendor SET [Salut]='" + salution.Text + "',[First_name]='" + textBox6.Text + "',[Email]='" + textBox3.Text + "',[Mob1]='" + textBox4.Text + "',[Mob2]='" + textBox7.Text + "',[Web]='" + textBox5.Text + "',[Patta]='" + con_addTextBox.Text + "',[Shop_name]='" + shp1.Text + "',[Bank_name]='" + textBox9.Text + "',[Acc_name]='" + textBox8.Text + "',[Acc_no]='" + textBox10.Text + "',[Ifsc]='" + textBox11.Text + "',[Branch_add]='" + textBox12.Text + "',[Acc_type]='" + textBox14.Text + "',[GSTIN]='" + textBox2.Text + "' where [vendorID]='" + textBox15.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
                conn.Close();
                salution.Text = "";
                textBox6.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox7.Text = "";
                textBox5.Text = "";
                con_addTextBox.Text = "";
                shp1.Text = "";
                textBox9.Text = "";
                textBox8.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox14.Text = "";
                reload();
            }
            else
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "update customer SET [Salut]='" + salution.Text + "',[First_name]='" + textBox6.Text + "',[Email]='" + textBox3.Text + "',[Mob1]='" + textBox4.Text + "',[Mob2]='" + textBox7.Text + "',[Web]='" + textBox5.Text + "',[Patta]='" + con_addTextBox.Text + "',[GSTIN]='" + textBox2.Text + "' where [customerID]='" + textBox15.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
                conn.Close();
               
                salution.Text = "";
                textBox6.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox7.Text = "";
                textBox5.Text = "";
                con_addTextBox.Text = "";
                reload2();

            }
            panel1.Visible = false;

        }

        void reload()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd1 = new SqlCeCommand("select [vendorID],[Salut],[First_name],[Email],[Mob1],[Mob2],[Web],[Patta],[Shop_name],[Bank_name],[Acc_name],[Acc_no],[Ifsc],[Branch_add],[Acc_type],[GSTIN] from vendor order by [vendorID] DESC ", conn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        void reload2()
        {
            conn.Open();
            SqlCeCommand cmd2 = new SqlCeCommand();
            string query = "SELECT [customerID],[Salut],[First_name],[Email],[Mob1],[Mob2],[Web],[Patta],[GSTIN] FROM  customer order by [customerID] Desc";

            using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, conn))
            {
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            conn.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlCeCommand cmd = new SqlCeCommand();
           
            if (radioButton1.Checked)
            {
                conn.Open();
                cmd.Connection = conn;
                string n = textBox6.Text;
                cmd.CommandText = "DELETE from vendor where [vendorID]='"+textBox15.Text+"'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                conn.Close();
                salution.Text = "";
                textBox6.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox7.Text = "";
                textBox5.Text = "";
                con_addTextBox.Text = "";
                shp1.Text = "";
                textBox9.Text = "";
                textBox8.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox14.Text = "";
                reload();
             
            }
            else
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE from customer where [customerID]='" + textBox15.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                conn.Close();
                salution.Text = "";
                textBox6.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox7.Text = "";
                textBox5.Text = "";
                con_addTextBox.Text = "";
                reload2();
             
            }
            panel1.Visible = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                int cr = dataGridView1.RowCount;
                textBox15.Text = "#CUST-" + Convert.ToString(cr);
                groupBox2.Visible = true;
                save.Visible = true;
                back.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
                save.Visible = false;
                back.Visible = false;
            }
        }

      

       
    }
}
