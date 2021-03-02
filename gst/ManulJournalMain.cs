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
    public partial class ManulJournalMain : Form
    {
        public ManulJournalMain()
        {
            InitializeComponent();
        }

        private void newbtn7_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnsave7_Click(object sender, EventArgs e)
        {

        }

        private void btnback7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
