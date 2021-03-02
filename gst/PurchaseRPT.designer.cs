namespace gst
{
    partial class PurchaseRPT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGSTtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGSTtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billTaxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gSTDataSet8 = new gst.GSTDataSet8();
            this.purchaseorderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pURCHASEORDER = new gst.PURCHASEORDER();
            this.purchaseorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseRptData = new gst.PurchaseRptData();
            this.purchase_orderTableAdapter = new gst.PurchaseRptDataTableAdapters.purchase_orderTableAdapter();
            this.purchase_orderTableAdapter1 = new gst.PURCHASEORDERTableAdapters.purchase_orderTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.bill_TaxTableAdapter = new gst.GSTDataSet8TableAdapters.Bill_TaxTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTaxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSTDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseorderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEORDER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRptData)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(853, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 16;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Add.Location = new System.Drawing.Point(678, 26);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(167, 26);
            this.Add.TabIndex = 15;
            this.Add.Text = "Export To Execl";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateIDataGridViewTextBoxColumn,
            this.taxDataGridViewTextBoxColumn,
            this.cTADataGridViewTextBoxColumn,
            this.cAmtDataGridViewTextBoxColumn,
            this.sTADataGridViewTextBoxColumn,
            this.sAmtDataGridViewTextBoxColumn,
            this.bIDDataGridViewTextBoxColumn,
            this.iTADataGridViewTextBoxColumn,
            this.iAmtDataGridViewTextBoxColumn,
            this.cGSTtDataGridViewTextBoxColumn,
            this.sGSTtDataGridViewTextBoxColumn,
            this.refDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.billTaxBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(943, 382);
            this.dataGridView1.TabIndex = 14;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateIDataGridViewTextBoxColumn
            // 
            this.dateIDataGridViewTextBoxColumn.DataPropertyName = "Date_I";
            this.dateIDataGridViewTextBoxColumn.HeaderText = "Date_I";
            this.dateIDataGridViewTextBoxColumn.Name = "dateIDataGridViewTextBoxColumn";
            // 
            // taxDataGridViewTextBoxColumn
            // 
            this.taxDataGridViewTextBoxColumn.DataPropertyName = "Tax";
            this.taxDataGridViewTextBoxColumn.HeaderText = "Tax";
            this.taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            // 
            // cTADataGridViewTextBoxColumn
            // 
            this.cTADataGridViewTextBoxColumn.DataPropertyName = "CTA";
            this.cTADataGridViewTextBoxColumn.HeaderText = "CTA";
            this.cTADataGridViewTextBoxColumn.Name = "cTADataGridViewTextBoxColumn";
            // 
            // cAmtDataGridViewTextBoxColumn
            // 
            this.cAmtDataGridViewTextBoxColumn.DataPropertyName = "CAmt";
            this.cAmtDataGridViewTextBoxColumn.HeaderText = "CAmt";
            this.cAmtDataGridViewTextBoxColumn.Name = "cAmtDataGridViewTextBoxColumn";
            // 
            // sTADataGridViewTextBoxColumn
            // 
            this.sTADataGridViewTextBoxColumn.DataPropertyName = "STA";
            this.sTADataGridViewTextBoxColumn.HeaderText = "STA";
            this.sTADataGridViewTextBoxColumn.Name = "sTADataGridViewTextBoxColumn";
            // 
            // sAmtDataGridViewTextBoxColumn
            // 
            this.sAmtDataGridViewTextBoxColumn.DataPropertyName = "SAmt";
            this.sAmtDataGridViewTextBoxColumn.HeaderText = "SAmt";
            this.sAmtDataGridViewTextBoxColumn.Name = "sAmtDataGridViewTextBoxColumn";
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "B_ID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "B_ID";
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            // 
            // iTADataGridViewTextBoxColumn
            // 
            this.iTADataGridViewTextBoxColumn.DataPropertyName = "ITA";
            this.iTADataGridViewTextBoxColumn.HeaderText = "ITA";
            this.iTADataGridViewTextBoxColumn.Name = "iTADataGridViewTextBoxColumn";
            // 
            // iAmtDataGridViewTextBoxColumn
            // 
            this.iAmtDataGridViewTextBoxColumn.DataPropertyName = "IAmt";
            this.iAmtDataGridViewTextBoxColumn.HeaderText = "IAmt";
            this.iAmtDataGridViewTextBoxColumn.Name = "iAmtDataGridViewTextBoxColumn";
            // 
            // cGSTtDataGridViewTextBoxColumn
            // 
            this.cGSTtDataGridViewTextBoxColumn.DataPropertyName = "CGST_t";
            this.cGSTtDataGridViewTextBoxColumn.HeaderText = "CGST_t";
            this.cGSTtDataGridViewTextBoxColumn.Name = "cGSTtDataGridViewTextBoxColumn";
            // 
            // sGSTtDataGridViewTextBoxColumn
            // 
            this.sGSTtDataGridViewTextBoxColumn.DataPropertyName = "SGST_t";
            this.sGSTtDataGridViewTextBoxColumn.HeaderText = "SGST_t";
            this.sGSTtDataGridViewTextBoxColumn.Name = "sGSTtDataGridViewTextBoxColumn";
            // 
            // refDataGridViewTextBoxColumn
            // 
            this.refDataGridViewTextBoxColumn.DataPropertyName = "ref";
            this.refDataGridViewTextBoxColumn.HeaderText = "ref";
            this.refDataGridViewTextBoxColumn.Name = "refDataGridViewTextBoxColumn";
            // 
            // billTaxBindingSource
            // 
            this.billTaxBindingSource.DataMember = "Bill_Tax";
            this.billTaxBindingSource.DataSource = this.gSTDataSet8;
            // 
            // gSTDataSet8
            // 
            this.gSTDataSet8.DataSetName = "GSTDataSet8";
            this.gSTDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseorderBindingSource1
            // 
            this.purchaseorderBindingSource1.DataMember = "purchase_order";
            this.purchaseorderBindingSource1.DataSource = this.pURCHASEORDER;
            // 
            // pURCHASEORDER
            // 
            this.pURCHASEORDER.DataSetName = "PURCHASEORDER";
            this.pURCHASEORDER.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseorderBindingSource
            // 
            this.purchaseorderBindingSource.DataMember = "purchase_order";
            this.purchaseorderBindingSource.DataSource = this.purchaseRptData;
            // 
            // purchaseRptData
            // 
            this.purchaseRptData.DataSetName = "PurchaseRptData";
            this.purchaseRptData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchase_orderTableAdapter
            // 
            this.purchase_orderTableAdapter.ClearBeforeFill = true;
            // 
            // purchase_orderTableAdapter1
            // 
            this.purchase_orderTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(583, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 26);
            this.button2.TabIndex = 39;
            this.button2.Text = "Find";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(453, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Till";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(333, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Search From";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(461, 31);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker2.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(339, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(153, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 21);
            this.textBox1.TabIndex = 32;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // comboBox6
            // 
            this.comboBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "purchase_orderID",
            "Date",
            "Vendor_name",
            "Ref",
            "Del_date",
            "Amt",
            "Paid",
            "Bal"});
            this.comboBox6.Location = new System.Drawing.Point(12, 31);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(133, 23);
            this.comboBox6.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label16.Location = new System.Drawing.Point(9, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Serach Purchase";
            // 
            // bill_TaxTableAdapter
            // 
            this.bill_TaxTableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(828, 442);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 22);
            this.textBox3.TabIndex = 41;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(743, 442);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 22);
            this.textBox2.TabIndex = 40;
            // 
            // PurchaseRPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(958, 533);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseRPT";
            this.Text = "PurchaseRPT";
            this.Load += new System.EventHandler(this.PurchaseRPT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTaxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSTDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseorderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEORDER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRptData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PurchaseRptData purchaseRptData;
        private System.Windows.Forms.BindingSource purchaseorderBindingSource;
        private PurchaseRptDataTableAdapters.purchase_orderTableAdapter purchase_orderTableAdapter;
        private PURCHASEORDER pURCHASEORDER;
        private System.Windows.Forms.BindingSource purchaseorderBindingSource1;
        private PURCHASEORDERTableAdapters.purchase_orderTableAdapter purchase_orderTableAdapter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label16;
        private GSTDataSet8 gSTDataSet8;
        private System.Windows.Forms.BindingSource billTaxBindingSource;
        private GSTDataSet8TableAdapters.Bill_TaxTableAdapter bill_TaxTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGSTtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGSTtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}