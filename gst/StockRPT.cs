using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace gst
{
    public partial class StockRPT : Form
    {
        public StockRPT()
        {
            InitializeComponent();
        }

        private void StockRPT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTOCK.goods' table. You can move, or remove it, as needed.
            this.goodsTableAdapter6.Fill(this.sTOCK.goods);
            // TODO: This line of code loads data into the 'gSTDataSet6.goods' table. You can move, or remove it, as needed.
            Double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {

                sum += (Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value)*Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value));
               
            }
            textBox3.Text = Convert.ToString(sum);
            
        }

        private void Add_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Goods Sheet";

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Stock Report " + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            saveFileDialoge.DefaultExt = ".xls";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageBox.Show("Excel Report Saved ");
            }
            app.Quit();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Sales Report";
            printer.SubTitle = String.Format("Date :" + DateTime.Now.Date.ToShortDateString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageSettings.Landscape = true;
            printer.PageNumberInHeader = false;
            printer.PrintColumnHeaders = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Shri Laxmi Enterprises Stock Report";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }
    }
}
