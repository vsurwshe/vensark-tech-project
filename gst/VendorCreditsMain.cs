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
    public partial class VendorCreditsMain : Form
    {
        public VendorCreditsMain()
        {
            InitializeComponent();
        }

        private void newbtn6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnadd6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(itde1.Text) || string.IsNullOrEmpty(qua1.Text) || string.IsNullOrEmpty(rat1.Text))
            {
                return;
            }
            else
            {
                ListViewItem item = new ListViewItem(itde1.Text);
                item.SubItems.Add(acc1.Text);
                item.SubItems.Add(qua1.Text);
                item.SubItems.Add(rat1.Text);
                Int32 val1 = Convert.ToInt32(qua1.Text);
                Int32 val2 = Convert.ToInt32(rat1.Text);
                Int32 val3 = val1 * val2;
                string val4 = val3.ToString();
                item.SubItems.Add(val4);
                listView.Items.Add(item);
                itde1.Clear();
                acc1.Clear();
                qua1.Clear();
                rat1.Clear();
            }
        }

        private void btnsave6_Click(object sender, EventArgs e)
        {

        }

        private void btnback6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
