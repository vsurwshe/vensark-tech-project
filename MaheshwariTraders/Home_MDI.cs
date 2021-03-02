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
    public partial class Home_MDI : Form
    {
        public Home_MDI()
        {
            InitializeComponent();
        }

        private void Home_MDI_Load(object sender, EventArgs e)
        {
            
        }
        Sales sal;
        private void sALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Home_MDI" && Application.OpenForms[i].Name != "Sales")
                    Application.OpenForms[i].Close();
                else
                {
                    if (Application.OpenForms[i].Name == "Sales")
                    {
                        sal.Close();
                        sal = new Sales();
                        sal.Location = new Point(2, 95);
                        sal.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
                        sal.Show();
                    }
                    else
                    {
                        sal = new Sales();
                        sal.Location = new Point(2, 95);
                        sal.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
                        sal.Show();
                    }
                }
            }
           ///* Sales s = new Sales();
           // s.MdiParent = this;
           // s.Show();*/
           // if (sal == null)
           // {
           //     sal = new Sales();
           //     sal.MdiParent = this;
           //     sal.Dock = DockStyle.Fill;
           //     sal.FormClosed += new FormClosedEventHandler(sal_FormClosed);
           //     sal.Show();
           // }
           // else
           //     sal.Activate();
        }
        void sal_FormClosed(object sender, FormClosedEventArgs e)
        {
            sal = null;
        }

/*frmPurchase_DashBoard pdb;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            hrmToolStrip.Visible = false;
            purchaseToolStrip.Visible = true;
            productionToolStrip.Visible = false;
            salesToolStrip.Visible = false;
            financeToolStrip.Visible = false;
            inventoryToolStrip.Visible = false;

            if (pdb == null)
            {
                pdb = new frmPurchase_DashBoard();
                pdb.MdiParent = this;
                pdb.Dock = DockStyle.Fill;
                pdb.FormClosed += new FormClosedEventHandler(pdb_FormClosed);
                pdb.Show();
            }
            else
                pdb.Activate();
        }
        void pdb_FormClosed(object sender, FormClosedEventArgs e)
        {
            pdb = null;
        }*/





        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        FrmAdvance1 ad;
        private void aDVANCEBOOKINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Home_MDI" && Application.OpenForms[i].Name != "FrmAdvance1")
                    Application.OpenForms[i].Close();
                else
                {
                    if (Application.OpenForms[i].Name == "FrmAdvance1")
                    {
                        ad.Close();
                        ad = new FrmAdvance1();
                        ad.Location = new Point(2, 95);
                        ad.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
                        ad.Show();
                    }
                    else
                    {
                        ad = new FrmAdvance1();
                        ad.Location = new Point(2, 95);
                        ad.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
                        ad.Show();
                    }
                }
            }

            //if (ad == null)
            //{
            //    ad = new FrmAdvance();
            //    ad.MdiParent = this;
            //    ad.Dock = DockStyle.Fill;
            //    ad.FormClosed += new FormClosedEventHandler(ad_FormClosed);
            //    ad.Show();
            //}
            //else
            //    ad.Activate();
        }
        void ad_FormClosed(object sender, FormClosedEventArgs e)
        {
            ad = null;
        }


        Daily_Sowing ds;
        private void dAILYSOWINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Home_MDI" && Application.OpenForms[i].Name != "Daily_Sowing")
                    Application.OpenForms[i].Close();
                else
                {
                    if (Application.OpenForms[i].Name == "Daily_Sowing")
                    {
                        ds.Close();
                        ds = new Daily_Sowing();
                        ds.Location = new Point(2, 95);
                        ds.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
                        ds.Show();
                    }
                    else
                    {
                        ds = new Daily_Sowing();
                        ds.Location = new Point(2, 95);
                        ds.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
                        ds.Show();
                    }
                }
            }

            //if (ab == null)
            //{
            //    ab = new Daily_Sowing();
            //    ab.MdiParent = this;
            //    ab.Dock = DockStyle.Fill;
            //    ab.FormClosed += new FormClosedEventHandler(ab_FormClosed);
            //    ab.Show();
            //}
            //else
            //{
            //    ab.Close();
            //    ab1 = new Daily_Sowing();
            //    ab1.MdiParent = this;
            //    ab1.Dock = DockStyle.Fill;
            //    ab1.FormClosed += new FormClosedEventHandler(ab_FormClosed);
            //    ab1.Show();
            //}
        }
        //void ab_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    ab = null;
        //    ab1 = null;
        //}

        Sales_Bill bp;
        private void bILLINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Home_MDI" && Application.OpenForms[i].Name != "Sales_Bill")
                    Application.OpenForms[i].Close();
                else
                {
                    if (Application.OpenForms[i].Name == "Sales_Bill")
                    {
                        bp.Close();
                        bp = new Sales_Bill();
                        bp.Location = new Point(2, 95);
                        bp.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
                        bp.Show();
                    }
                    else
                    {
                        bp = new Sales_Bill();
                        bp.Location = new Point(2, 95);
                        bp.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
                        bp.Show();
                    }
                }
            }

            //if (bp == null)
            //{
            //    bp = new Sales_Bill();
            //    bp.MdiParent = this;
            //    bp.Dock = DockStyle.Fill;
            //    bp.FormClosed += new FormClosedEventHandler(bp_FormClosed);
            //    bp.Show();
            //}
            //else
            //    bp.Activate();
        }
        void bp_FormClosed(object sender, FormClosedEventArgs e)
        {
            bp = null;
        }

        Master mm;
        private void mASTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Home_MDI" && Application.OpenForms[i].Name != "Master")
                    Application.OpenForms[i].Close();
                else
                {
                    if (Application.OpenForms[i].Name == "Master")
                    {
                        mm.Close();
                        mm = new Master();
                        mm.Location = new Point(2, 95);
                        mm.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
                        mm.Show();
                    }
                    else
                    {
                        mm = new Master();
                        mm.Location = new Point(2, 95);
                        mm.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
                        mm.Show();
                    }
                }
            }
            //if (mm == null)
            //{
            //    mm = new Master();
            //    mm.MdiParent = this;
            //    mm.Dock = DockStyle.Fill;
            //    mm.FormClosed += new FormClosedEventHandler(mm_FormClosed);
            //    mm.Show();
            //}
            //else
            //    mm.Activate();
            
        }

        void mm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mm = null;
        }
        FrmPurchase f;
        private void pURCHASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Home_MDI" && Application.OpenForms[i].Name != "FrmPurchase")
                    Application.OpenForms[i].Close();
                else
                {
                    if (Application.OpenForms[i].Name == "FrmPurchase")
                    {
                        f.Close();
                        f = new FrmPurchase();
                        f.Location = new Point(2, 95);
                        f.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
                        f.Show();
                    }
                    else
                    {
                        f = new FrmPurchase();
                        f.Location = new Point(2, 95);
                        f.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
                        f.Show();
                    }
                }
            }

            //if (f == null)
            //{
            //  f = new FrmPurchase();
            //    f.MdiParent = this;
            //    f.Dock = DockStyle.Fill;
            //    f.FormClosed += new FormClosedEventHandler(f_FormClosed);
            //    f.Show();
            //}
            //else
            //    f.Activate();
        }
        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            f = null;
        }

        FrmStock fs;
        private void sTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Home_MDI" && Application.OpenForms[i].Name != "FrmStock")
                    Application.OpenForms[i].Close();
                else
                {
                    if (Application.OpenForms[i].Name == "FrmStock")
                    {
                        fs.Close();
                        fs = new FrmStock();
                        fs.Location = new Point(2, 95);
                        fs.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
                        fs.Show();
                    }
                    else
                    {
                        fs = new FrmStock();
                        fs.Location = new Point(2, 95);
                        fs.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
                        fs.Show();
                    }
                }
            }

            //if (fs == null)
            //{
            //    fs = new FrmStock();
            //    fs.MdiParent = this;
            //    fs.Dock = DockStyle.Fill;
            //    fs.FormClosed += new FormClosedEventHandler(fs_FormClosed);
            //    fs.Show();
            //}
            //else
            //    fs.Activate();
        }
        void fs_FormClosed(object sender, FormClosedEventArgs e)
        {
            fs = null;
        }

        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmbalance f = new Frmbalance();
            f.ShowDialog();
        }

        private void dailyUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDailyuse d = new FrmDailyuse();
            d.ShowDialog();
 
        }

        FrmReports fr;
        private void rEPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Home_MDI" && Application.OpenForms[i].Name != "FrmReports")
                    Application.OpenForms[i].Close();
                else
                {
                    if (Application.OpenForms[i].Name == "FrmReports")
                    {
                        fr.Close();
                        fr = new FrmReports();
                        fr.Location = new Point(2, 95);
                        fr.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
                        fr.Show();
                    }
                    else
                    {
                        fr = new FrmReports();
                        fr.Location = new Point(2, 95);
                        fr.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
                        fr.Show();
                    }
                }
            }
            
            //fr.Location = new Point(2, 95);
            //fr.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
            //fr.Show();
        }

        FrmDashBoard d;
        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Home_MDI" && Application.OpenForms[i].Name != "FrmDashboard")
                    Application.OpenForms[i].Close();
                else 
                {
                    if (Application.OpenForms[i].Name == "FrmDashboard")
                    {
                        d.Close();
                        d = new FrmDashBoard();
                        d.Location = new Point(2, 95);
                        d.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
                        d.Show();
                    }
                    else
                    {
                        d = new FrmDashBoard();
                        d.Location = new Point(2, 95);
                        d.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 4, Screen.PrimaryScreen.Bounds.Height - 50);
                        d.Show();
                    }
                }
            }
            //fr.Close();
            
            //d.Location = new Point(2, 95);
            //d.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 2, Screen.PrimaryScreen.Bounds.Height - 95);
            //d.Show();
        }

        
    }
    
}