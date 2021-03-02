using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gst
{
    public partial class RecurringBillsMain : Form
    {
        public RecurringBillsMain()
        {
            InitializeComponent();
        }

        private void btnnew1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnadd1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(itde1.Text) || string.IsNullOrEmpty(qua1.Text) || string.IsNullOrEmpty(rat1.Text))
            {
                return;
            }
            else
            {
                ListViewItem item = new ListViewItem(itde1.Text);
                item.SubItems.Add(qua1.Text);
                item.SubItems.Add(rat1.Text);
                Int32 val1 = Convert.ToInt32(qua1.Text);
                Int32 val2 = Convert.ToInt32(rat1.Text);
                Int32 val3 = val1 * val2;
                string val4 = val3.ToString();
                item.SubItems.Add(val4);
                listView.Items.Add(item);
                itde1.Clear();
                qua1.Clear();
                rat1.Clear();
            }
        }

        private void btnback1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
