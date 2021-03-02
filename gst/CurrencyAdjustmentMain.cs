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
    public partial class CurrencyAdjustmentMain : Form
    {
        public CurrencyAdjustmentMain()
        {
            InitializeComponent();
        }

        private void newbtn9_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnsave9_Click(object sender, EventArgs e)
        {

        }

        private void btnback9_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

       

    }
}
