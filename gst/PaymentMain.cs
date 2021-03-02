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
    public partial class PaymentMain : Form
    {
        public PaymentMain()
        {
            InitializeComponent();
        }

        private void PaymentMain_Load(object sender, EventArgs e)
        {
            dii();
        }

        void dii()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd1 = new SqlCeCommand(" SELECT * from [Payment_made] order by [Payment_madeID] desc  ", conn);
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
                string query = "SELECT * from Payment_made where [" + comboBox1.Text + "] LIKE '%" + textBox1.Text + "%'";
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
                dii();
            }
        }
        public static string com;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            com = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string[] strArr = null;
            int count = 0;
            char[] splitchar = { '-' ,'.'};
            strArr = com.Split(splitchar);
            string tem = null;
            for (count = 0; count <= strArr.Length - 1; count++)
            {
                if (count == strArr.Length - 1)
                    tem = strArr[count];

                MessageBox.Show(strArr[count]);
            }
           
            if (com.Equals("#EXP-" + tem))
            {
                
                com = tem;
                EXP ob2 = new EXP();
                ob2.ShowDialog();
            }
            else
            {
                if (com.Equals("#PO-" + tem))
                {
                  //  MessageBox.Show("hii");
                    com = tem;
                    pur1 ob10 = new pur1();
                    ob10.ShowDialog();
                }
                else
                {
                    if (com.Equals("#BILLNO-" + tem))
                    {
                        //MessageBox.Show("hii");
                        BillsMain.nam = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        com = tem;
                        billrp ob1 = new billrp();
                        ob1.ShowDialog();
                    }

                }
            }
        }

    }
}
