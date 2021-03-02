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
    public partial class itemadjustment : Form
    {
        public itemadjustment()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

        }
    }
}
