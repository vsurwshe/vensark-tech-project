using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DGVPrinterHelper;
using System.Data.SqlServerCe;

namespace gst
{
    public partial class taxpaid : Form
    {
        public taxpaid()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
             Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Tax Paid Sheet";

            for (int i = 1; i < dataGridView1.Columns.Count + 1;i++ )
            {
                worksheet.Cells[ 1 , i ] = dataGridView1.Columns[ i - 1 ].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[ i + 2, j + 1 ] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Tax Paid Report " + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            saveFileDialoge.DefaultExt = ".xls";
            if(saveFileDialoge.ShowDialog()==DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing);
                MessageBox.Show("Excel Report Saved ");
            }
            app.Quit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Tax Paid Report";
            printer.SubTitle = String.Format("Date :" + DateTime.Now.Date.ToString("dd/mm/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageSettings.Landscape = true;
            printer.PageNumberInHeader = false;
            printer.PrintColumnHeaders = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Renuka Cometics Tax Paid Report";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }

        private void taxpaid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gSTDataSet2.Bill_Tax' table. You can move, or remove it, as needed.
            this.bill_TaxTableAdapter.Fill(this.gSTDataSet2.Bill_Tax);
            Double sum = 0;
            Double sum2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                sum2 += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
            }
            textBox2.Text = Convert.ToString(sum);
            textBox3.Text = Convert.ToString(sum2);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.conne);

            SqlCeCommand cmd3 = new SqlCeCommand();
            if (e.KeyChar == (char)13 && textBox1.Text != null)
            {
                try
                {
                    con.Open();
                    string query = "SELECT  * FROM [Bill_Tax] where [" + comboBox6.Text + "] LIKE '%" + textBox1.Text + "%'";
                    using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, con))
                    {
                        DataSet ds1 = new DataSet();
                        adapter.Fill(ds1);
                        dataGridView1.DataSource = ds1.Tables[0];
                    }
                    Double sum = 0;
                    Double sum2 = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {

                        sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                        sum2 += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                    }
                    textBox2.Text = Convert.ToString(sum);
                    textBox3.Text = Convert.ToString(sum2);
                    con.Close();
                    textBox1.Text = "";
                }
                catch (Exception o)
                {
                    MessageBox.Show("Please Choose Your Column Form Combo Box");
                }
            }
            else
            {
                con.Open();
                string query = "SELECT  * FROM [Bill_Tax]";
                using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, con))
                {
                    DataSet ds1 = new DataSet();
                    adapter.Fill(ds1);
                    dataGridView1.DataSource = ds1.Tables[0];
                }
                con.Close();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.conne);
            conn.Open();
            SqlCeCommand cmd2 = new SqlCeCommand();
           // MessageBox.Show(dateTimePicker1.Value.ToString());
           // MessageBox.Show(dateTimePicker2.Value.ToString());
            string query = "SELECT * FROM Bill_Tax where Date_I BETWEEN '" + dateTimePicker1.Value.ToString() + " 'AND '" + dateTimePicker2.Value.ToString() + "'";
            using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            Double sum = 0;
            Double sum2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                sum2 += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
            }
            textBox2.Text = Convert.ToString(sum);
            textBox3.Text = Convert.ToString(sum2);
            conn.Close();
        }
    }
}
