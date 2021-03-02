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
using System.IO;
using System.Reflection;

namespace gst
{
    public partial class DashBorad : Form
    {
        public string backupPath;
        public DashBorad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
        }

        private void DashBorad_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
                conn.Open();
                SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT [Sales_ordersID] AS ID ,[Date_s] AS DATE,[Cust_name] AS NAME ,[Balance] AS BALANCE,[Del_date] AS DUE_DATE FROM Sales_orders where [Balance]>'1'", conn);
                SqlCeDataAdapter da2 = new SqlCeDataAdapter("SELECT [InvoiceID] AS ID ,[I_date] AS DATE,[Cust_name] AS NAME,[Bal_due] AS BALANCE,[Due_date] AS DUE_DATE FROM Invoice where [Bal_due]>'1'", conn);
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                da.Fill(dt);
                da2.Fill(dt2);
                DataTable dt3 = new DataTable();
                dt3 = dt.Copy();
                dt3.Merge(dt2, true);
               // dt3.NewRow(dt2);
                dataGridView3.DataSource = dt3;
                if (dataGridView3.Rows.Count != 0 && dataGridView3.Rows != null)
                {
                    Double sum = 0;
                    for (int i = 0; i < dataGridView3.Rows.Count; ++i)
                    {

                        sum += Convert.ToDouble(dataGridView3.Rows[i].Cells[3].Value);
                     
                    }
                    textBox2.Text = Convert.ToString(sum);
                }
                SqlCeDataAdapter da3 = new SqlCeDataAdapter("SELECT [BillsID] as ID,[Date] as DATE,[Vendor_name] as NAME,[Bal]as BALANCE,[Due_date] AS DUE_DATE FROM Bills where [Bal]>'1'", conn);
                SqlCeDataAdapter da4 = new SqlCeDataAdapter("SELECT [purchase_orderID] AS ID ,[Date] AS DATE,[Vendor_name] AS NAME ,[Bal] AS BALANCE,[Del_date] AS DUE_DATE FROM purchase_order where [Bal]>'1'", conn);
                DataTable dt4 = new DataTable();
                DataTable dt5 = new DataTable();
                da3.Fill(dt4);
                da4.Fill(dt5);
                DataTable dt6 = new DataTable();
                dt6 = dt4.Copy();
                dt6.Merge(dt5, true);
                // dt3.NewRow(dt2);
                dataGridView4.DataSource = dt6;
                if (dataGridView4.Rows.Count != 0 && dataGridView4.Rows != null)
                {
                    Double sum = 0;
                    for (int i = 0; i < dataGridView4.Rows.Count; ++i)
                    {

                        sum += Convert.ToDouble(dataGridView4.Rows[i].Cells[3].Value);

                    }
                    textBox3.Text = Convert.ToString(sum);
                }
                SqlCeDataAdapter da42 = new SqlCeDataAdapter("SELECT ('#PRO-'+cast([goodsID] as nvarchar(10))) AS ID, [Prod_name] AS PRODUCT , [Qty] As QUANTITY FROM GOODS where Qty<Stockl", conn);
                DataTable dt52 = new DataTable();
                da42.Fill(dt52);
                dataGridView1.DataSource = dt52;
                conn.Close();

            }
            catch (Exception o)
            {
                MessageBox.Show("Erorr " + o);
            }
        }

        private void restore_Click(object sender, EventArgs e)
        {
            try {
                string fileName = "GST.sdf";
                openFileDialog1.Filter = "SQL Server Compact (*.sdf)|*.sdf|All files (*.*)|*.*";
                openFileDialog1.FileName = fileName;
                DialogResult ofd = openFileDialog1.ShowDialog();
                if (ofd == DialogResult.OK)
                {
                    backupPath = openFileDialog1.FileName;
                    try
                    {
                        string restorePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        string destFile = System.IO.Path.Combine(restorePath, fileName);
                        //MessageBox.Show(backupPath);
                        //MessageBox.Show(destFile);
                        System.IO.File.Copy(backupPath, destFile, true);
                        MessageBox.Show("Backup will store Successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            
                }
                
            }
            catch (Exception o) {
                MessageBox.Show("Error: "+o);
            }

           
        }

        private void backup_Click(object sender, EventArgs e)
        {
            try {
                string fileName = "GST.sdf";
                saveFileDialog1.Filter = "SQL Server Compact (*.sdf)|*.sdf|All files (*.*)|*.*";
                saveFileDialog1.FileName = fileName;
                DialogResult ofd = saveFileDialog1.ShowDialog();
                if (ofd == DialogResult.OK)
                {
                    backupPath = saveFileDialog1.FileName;
                    string sourcePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                    string destFile = System.IO.Path.Combine(backupPath, "");
                    System.IO.File.Copy(sourceFile, destFile);
                    MessageBox.Show("Your Backup Has been Taken Successfully ");
                }
                
            }
            catch (Exception o) {
                MessageBox.Show("Error: "+o);
            } 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
