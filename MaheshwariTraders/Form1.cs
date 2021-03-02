using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MaheshwariTraders
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage hmp = new HomePage();
            //hmp.Location = new Point((Screen.PrimaryScreen.Bounds.Width/2)-(773/2),0);
            hmp.Location = new Point(0, 0);
            hmp.Show();
            
        }


    }
}
