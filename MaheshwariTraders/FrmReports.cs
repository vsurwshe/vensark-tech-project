using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaheshwariTraders
{
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FrmRptCustomer frc = new FrmRptCustomer();
            frc.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            FrmRptStock frs = new FrmRptStock();
            frs.ShowDialog();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            FrmRptVarietywise frmv = new FrmRptVarietywise();
            frmv.ShowDialog();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            FrmRptplantVariety f = new FrmRptplantVariety();
            f.ShowDialog();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            FrmRptLotNo f = new FrmRptLotNo();
            f.ShowDialog();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            FrmRptRowMaterial fr = new FrmRptRowMaterial();
            fr.ShowDialog();

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            FrmRptAdvanceBook ad = new FrmRptAdvanceBook();
            ad.ShowDialog();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            FrmRptDailyshowing d = new FrmRptDailyshowing();
            d.ShowDialog();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            FrmRptDate rt = new FrmRptDate();
            rt.ShowDialog();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            FrmRptRemaining r = new FrmRptRemaining();
            r.ShowDialog();
        }
    }
}
