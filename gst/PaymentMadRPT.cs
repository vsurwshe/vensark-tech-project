﻿using System;
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
    public partial class PaymentMadRPT : Form
    {
        public PaymentMadRPT()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Payment Made Sheet";

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
            saveFileDialoge.FileName = "Payment Made Report " + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            saveFileDialoge.DefaultExt = ".xls";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageBox.Show("Excel Report Saved ");
            }
            app.Quit();
            
        }

        private void PaymentMadRPT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paymentMadeRPTDATA.Payment_made' table. You can move, or remove it, as needed.
            this.payment_madeTableAdapter1.Fill(this.paymentMadeRPTDATA.Payment_made);
            // TODO: This line of code loads data into the 'paymentMadeData.Payment_made' table. You can move, or remove it, as needed.
           // this.payment_madeTableAdapter.Fill(this.paymentMadeData.Payment_made);

            if (dataGridView1.Rows.Count != 0 && dataGridView1.Rows != null)
            {
                Double sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {

                    sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);

                }
                textBox2.Text = Convert.ToString(sum);
            }

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
            printer.Footer = "Shri Laxmi Enterprises Payment Made Report";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }
    }
}
