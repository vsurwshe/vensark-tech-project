namespace gst
{
    partial class INV_REF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rptviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptviewer
            // 
            this.rptviewer.ActiveViewIndex = -1;
            this.rptviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptviewer.CachedPageNumberPerDoc = 10;
            this.rptviewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptviewer.Location = new System.Drawing.Point(0, 0);
            this.rptviewer.Name = "rptviewer";
            this.rptviewer.Size = new System.Drawing.Size(1055, 484);
            this.rptviewer.TabIndex = 0;
            this.rptviewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.rptviewer.Load += new System.EventHandler(this.rptviewer_Load);
            // 
            // INV_REF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 484);
            this.Controls.Add(this.rptviewer);
            this.Name = "INV_REF";
            this.Text = "INV_REF";
            this.Load += new System.EventHandler(this.INV_REF_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptviewer;
    }
}