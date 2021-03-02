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
    public partial class HomePage : MetroForm
    {
        public HomePage()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Sales_Bill sb = new Sales_Bill();
            //sb.Location = new Point((Screen.PrimaryScreen.Bounds.Width/2)-(964/2), 130);
            sb.Location = new Point(143,0);
            sb.ShowDialog();
           
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Stock_Status ss = new Stock_Status();
            ss.Location = new Point(143,0);
            ss.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            s.Location = new Point(143,0);
            s.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            Daily_Sowing ab = new Daily_Sowing();
            ab.Location = new Point(143, 0);
            ab.ShowDialog();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
