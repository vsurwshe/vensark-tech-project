namespace gst
{
    partial class SO_CRF
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
            this.rptviwer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptviwer
            // 
            this.rptviwer.ActiveViewIndex = -1;
            this.rptviwer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptviwer.CachedPageNumberPerDoc = 10;
            this.rptviwer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptviwer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptviwer.Location = new System.Drawing.Point(0, 0);
            this.rptviwer.Name = "rptviwer";
            this.rptviwer.Size = new System.Drawing.Size(1006, 564);
            this.rptviwer.TabIndex = 0;
            this.rptviwer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // SO_CRF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 564);
            this.Controls.Add(this.rptviwer);
            this.Name = "SO_CRF";
            this.Text = "SO_CRF";
            this.Load += new System.EventHandler(this.SO_CRF_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptviwer;
    }
}