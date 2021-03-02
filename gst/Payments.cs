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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            reload();
        }
        public void reload()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd1 = new SqlCeCommand("select * from Payment_recive order by [Payment_reciveID] desc ", conn);
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
                string query = "SELECT * FROM  Payment_recive where  ["+comboBox1.Text+"] LIKE '%" + textBox1.Text + "%'";
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
        public static String com; 
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            com = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string[] strArr = null;
            int count = 0;
            char[] splitchar = { '-' };
            strArr = com.Split(splitchar);
            string tem = null;
            for (count = 0; count <= strArr.Length - 1; count++)
            {
                if (count == strArr.Length - 1)
                    tem = strArr[count];

                //MessageBox.Show(strArr[count]);
            }
           // MessageBox.Show("Your Var"+tem);
            if (com.Equals("#RET-INV-"+tem))
            {
                com = tem;
                RCF r = new RCF();
                r.ShowDialog();
            }
            else
            {
                if (com.Equals("#SAO-"+tem))
                {
                    com = tem;
                    SO_CRF s = new SO_CRF();
                    s.Show();
                }
                else {
                    if (com.Equals("#REN-" + tem))
                    {
                        com = tem;
                        Invoice.nam = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        INV_REF s = new INV_REF();
                        s.ShowDialog();
            
                    }

                }
            }

        }

      

        

       
    }
}
