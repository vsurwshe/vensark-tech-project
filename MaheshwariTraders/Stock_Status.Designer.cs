namespace MaheshwariTraders
{
    partial class Stock_Status
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
            this.components = new System.ComponentModel.Container();
            this.brandname = new MetroFramework.Controls.MetroComboBox();
            this.brandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandDataSet1 = new MaheshwariTraders.BrandDataSet1();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.brandsTableAdapter = new MaheshwariTraders.BrandDataSet1TableAdapters.BrandsTableAdapter();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Stocks2 = new MaheshwariTraders.Stocks();
            this.Stocks1 = new MaheshwariTraders.Stocks();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // brandname
            // 
            this.brandname.DataSource = this.brandsBindingSource;
            this.brandname.DisplayMember = "Brand_Name";
            this.brandname.FormattingEnabled = true;
            this.brandname.ItemHeight = 23;
            this.brandname.Location = new System.Drawing.Point(235, 33);
            this.brandname.Name = "brandname";
            this.brandname.Size = new System.Drawing.Size(247, 29);
            this.brandname.TabIndex = 0;
            this.brandname.UseSelectable = true;
            this.brandname.ValueMember = "Brand_Name";
            this.brandname.SelectedIndexChanged += new System.EventHandler(this.brandname_SelectedIndexChanged);
            // 
            // brandsBindingSource
            // 
            this.brandsBindingSource.DataMember = "Brands";
            this.brandsBindingSource.DataSource = this.brandDataSet1;
            // 
            // brandDataSet1
            // 
            this.brandDataSet1.DataSetName = "BrandDataSet1";
            this.brandDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(172, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Brand :";
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(549, 33);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(150, 29);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "SHOW STOCK";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // brandsTableAdapter
            // 
            this.brandsTableAdapter.ClearBeforeFill = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 79);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Stocks2;
            this.crystalReportViewer1.Size = new System.Drawing.Size(878, 435);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Stock_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 552);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.brandname);
            this.Name = "Stock_Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Stock_Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox brandname;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private BrandDataSet1 brandDataSet1;
        private System.Windows.Forms.BindingSource brandsBindingSource;
        private BrandDataSet1TableAdapters.BrandsTableAdapter brandsTableAdapter;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Stocks Stocks1;
        private Stocks Stocks2;
    }
}