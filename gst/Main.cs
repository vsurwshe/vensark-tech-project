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
    public partial class Main : Form
    {
      

        public Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            toolStripStatusLabel1.Dock = DockStyle.Fill;
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Invoice ino;
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ino = new Invoice();
                ino.MdiParent = this;
                ino.Dock = DockStyle.Fill;
                ino.Show();
        }
        Payments pa;
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
                pa = new Payments();
                pa.MdiParent = this;
                pa.Dock = DockStyle.Fill;
                pa.Show();
        }
        RecurringInvoices ri;
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {




        }
        Expensemain exp;
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
                exp = new Expensemain();
                exp.MdiParent = this;
                exp.Dock = DockStyle.Fill;
                exp.Show();
        }
    
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void viewMenu_Click(object sender, EventArgs e)
        {

        }
        Estimates es;
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            es = new Estimates();
            es.MdiParent = this;
            es.Dock = DockStyle.Fill;
            es.Show();
        }
        void es_FormClosed(object sender, FormClosedEventArgs e)
        {
            es = null;
        }
        private void Main_Load(object sender, EventArgs e)
        {
                db = new DashBorad();
                db.MdiParent = this;
                db.Dock = DockStyle.Fill;
                db.Show();
                
        }
        PurchaseOrder pc1;
        private void purcahaseOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pc1 = new PurchaseOrder();
            pc1.MdiParent = this;
            pc1.Dock = DockStyle.Fill;
            pc1.Show();
        }
        BillsMain bill;
        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {
                bill = new BillsMain();
                bill.MdiParent = this;
                bill.Dock = DockStyle.Fill;
                bill.Show();
        }
        PaymentMain paid;
        private void paymentsMadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
                paid = new PaymentMain();
                paid.MdiParent = this;
                paid.Dock = DockStyle.Fill;
                paid.Show();
        }

        RecurringBillsMain rec2;
        private void recurringBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rec2 = new RecurringBillsMain();
            rec2.MdiParent = this;
            rec2.Dock = DockStyle.Fill;
            rec2.Show();
        }
        VendorCreditsMain ven;
        private void vendorCredditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        ManulJournalMain jrnl;
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
                jrnl = new ManulJournalMain();
                jrnl.MdiParent = this;
                jrnl.Dock = DockStyle.Fill;
                jrnl.Show();
        }
        CurrencyAdjustmentMain curr;
        private void currencyAdjustmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            curr = new CurrencyAdjustmentMain();
            curr.MdiParent = this;
            curr.Dock = DockStyle.Fill;
            curr.Show();
        }
        TransactionLocking trans;
        private void transactionLockingToolStripMenuItem_Click(object sender, EventArgs e)
        {
                trans = new TransactionLocking();
                trans.MdiParent = this;
                trans.Dock = DockStyle.Fill;
                trans.Show();
       }
                private void chartOfAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
           
        }
        Contacts co;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
                co = new Contacts();
                co.MdiParent = this;
                co.Dock = DockStyle.Fill;
                co.Show();
        }
        void co_FormClosed(object sender, FormClosedEventArgs e)
        {
            co= null;
        }

        Bank ba;
        private void Banking_Click(object sender, EventArgs e)
        {
                ba = new Bank();
                ba.MdiParent = this;
                ba.Dock = DockStyle.Fill;
                ba.Show();
        }
        salesOrder so;
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        CreditNotes cn;
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
        DashBorad db;
        private void fileMenu_Click(object sender, EventArgs e)
        {
            db = new DashBorad();
            db.MdiParent = this;
            db.Dock = DockStyle.Fill;
            db.Show();
        }
        
        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
               it = new Items();
                it.MdiParent = this;
                it.Dock = DockStyle.Fill;
                it.Show();
         }

        RetainerInvoices ric;
        private void retainerinvoice_Click_1(object sender, EventArgs e)
        {

        

        }
               itemadjustment itm;
        private void itemAdjustmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                itm = new itemadjustment();
                itm.MdiParent = this;
                itm.Dock = DockStyle.Fill;
                itm.Show();
            
        }
        Items it;
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            it = new Items();
            it.MdiParent = this;
            it.Dock = DockStyle.Fill;
            it.Show();
        }
        SalesRPT srp;
        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            srp = new SalesRPT();
            srp.MdiParent = this;
            srp.Dock = DockStyle.Fill;
            srp.Show();

        }
        PurchaseRPT purt;
        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purt = new PurchaseRPT();
            purt.MdiParent = this;
            purt.Dock = DockStyle.Fill;
            purt.Show();
        }
        PaymentMadRPT pam;
        private void paymentMadeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pam = new PaymentMadRPT ();
            pam.MdiParent = this;
            pam.Dock = DockStyle.Fill;
            pam.Show();

        }
        PaymentRecRPT prp;
        private void paymentReciveReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prp = new PaymentRecRPT();
            prp.MdiParent = this;
            prp.Dock = DockStyle.Fill;
            prp.Show();
        }
        StockRPT srpt;
        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            srpt = new StockRPT();
            srpt.MdiParent = this;
            srpt.Dock = DockStyle.Fill;
            srpt.Show();
        }
        RecurringExpMain rem;
        private void statusBarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        }
        taxpaid txp;
        private void taxInReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txp = new taxpaid();
            txp.MdiParent = this;
            txp.Dock = DockStyle.Fill;
            txp.Show();
        }
        taxreceived txrp;
        private void taxPaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txrp = new taxreceived();
            txrp.MdiParent = this;
            txrp.Dock = DockStyle.Fill;
            txrp.Show();
        }

        private void undoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            es = new Estimates();
            es.MdiParent = this;
            es.Dock = DockStyle.Fill;
            es.Show();
        }

        private void retainerinvoice_Click(object sender, EventArgs e)
        {
            ric = new RetainerInvoices();
            ric.MdiParent = this;
            ric.Dock = DockStyle.Fill;
            ric.Show();
        }

        private void redoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            so = new salesOrder();
            so.MdiParent = this;
            so.Dock = DockStyle.Fill;
            so.Show();
        }

        private void pasteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ri = new RecurringInvoices();
            ri.MdiParent = this;
            ri.Dock = DockStyle.Fill;
            ri.Show();
        }

        private void selectAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            cn = new CreditNotes();
            cn.MdiParent = this;
            cn.Dock = DockStyle.Fill;
            cn.Show();
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rem = new RecurringExpMain();
            rem.MdiParent = this;
            rem.Dock = DockStyle.Fill;
            rem.Show();
        }

        private void recurringBillsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rec2 = new RecurringBillsMain();
            rec2.MdiParent = this;
            rec2.Dock = DockStyle.Fill;
            rec2.Show();
        }

        private void vendorCredditsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ven = new VendorCreditsMain();
            ven.MdiParent = this;
            ven.Dock = DockStyle.Fill;
            ven.Show();
        }
        BankTran bt;
        private void bankTransactionReprotToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bt = new BankTran();
            bt.MdiParent = this;
            bt.Dock = DockStyle.Fill;
            bt.Show();
        }

   
        
    }

}
