namespace MaheshwariTraders
{
    partial class FrmAdd_Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.plant = new MetroFramework.Controls.MetroComboBox();
            this.variety = new MetroFramework.Controls.MetroTextBox();
            this.lotno = new MetroFramework.Controls.MetroTextBox();
            this.rate = new MetroFramework.Controls.MetroTextBox();
            this.limit = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(51, 53);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Plant_Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(84, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Variety";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(84, 138);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Lot_No";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(98, 178);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Rate";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(98, 221);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(42, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Limit";
            // 
            // plant
            // 
            this.plant.FormattingEnabled = true;
            this.plant.ItemHeight = 23;
            this.plant.Location = new System.Drawing.Point(157, 53);
            this.plant.Name = "plant";
            this.plant.Size = new System.Drawing.Size(170, 29);
            this.plant.TabIndex = 5;
            this.plant.UseSelectable = true;
            this.plant.SelectedIndexChanged += new System.EventHandler(this.plant_SelectedIndexChanged);
            // 
            // variety
            // 
            // 
            // 
            // 
            this.variety.CustomButton.Image = null;
            this.variety.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.variety.CustomButton.Name = "";
            this.variety.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.variety.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.variety.CustomButton.TabIndex = 1;
            this.variety.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.variety.CustomButton.UseSelectable = true;
            this.variety.CustomButton.Visible = false;
            this.variety.Lines = new string[0];
            this.variety.Location = new System.Drawing.Point(157, 95);
            this.variety.MaxLength = 32767;
            this.variety.Name = "variety";
            this.variety.PasswordChar = '\0';
            this.variety.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.variety.SelectedText = "";
            this.variety.SelectionLength = 0;
            this.variety.SelectionStart = 0;
            this.variety.Size = new System.Drawing.Size(170, 23);
            this.variety.TabIndex = 6;
            this.variety.UseSelectable = true;
            this.variety.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.variety.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lotno
            // 
            // 
            // 
            // 
            this.lotno.CustomButton.Image = null;
            this.lotno.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.lotno.CustomButton.Name = "";
            this.lotno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lotno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lotno.CustomButton.TabIndex = 1;
            this.lotno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lotno.CustomButton.UseSelectable = true;
            this.lotno.CustomButton.Visible = false;
            this.lotno.Lines = new string[0];
            this.lotno.Location = new System.Drawing.Point(157, 138);
            this.lotno.MaxLength = 32767;
            this.lotno.Name = "lotno";
            this.lotno.PasswordChar = '\0';
            this.lotno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lotno.SelectedText = "";
            this.lotno.SelectionLength = 0;
            this.lotno.SelectionStart = 0;
            this.lotno.Size = new System.Drawing.Size(170, 23);
            this.lotno.TabIndex = 7;
            this.lotno.UseSelectable = true;
            this.lotno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lotno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rate
            // 
            // 
            // 
            // 
            this.rate.CustomButton.Image = null;
            this.rate.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.rate.CustomButton.Name = "";
            this.rate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.rate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rate.CustomButton.TabIndex = 1;
            this.rate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rate.CustomButton.UseSelectable = true;
            this.rate.CustomButton.Visible = false;
            this.rate.Lines = new string[0];
            this.rate.Location = new System.Drawing.Point(157, 178);
            this.rate.MaxLength = 32767;
            this.rate.Name = "rate";
            this.rate.PasswordChar = '\0';
            this.rate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rate.SelectedText = "";
            this.rate.SelectionLength = 0;
            this.rate.SelectionStart = 0;
            this.rate.Size = new System.Drawing.Size(170, 23);
            this.rate.TabIndex = 8;
            this.rate.UseSelectable = true;
            this.rate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // limit
            // 
            // 
            // 
            // 
            this.limit.CustomButton.Image = null;
            this.limit.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.limit.CustomButton.Name = "";
            this.limit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.limit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.limit.CustomButton.TabIndex = 1;
            this.limit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.limit.CustomButton.UseSelectable = true;
            this.limit.CustomButton.Visible = false;
            this.limit.Lines = new string[0];
            this.limit.Location = new System.Drawing.Point(157, 221);
            this.limit.MaxLength = 32767;
            this.limit.Name = "limit";
            this.limit.PasswordChar = '\0';
            this.limit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.limit.SelectedText = "";
            this.limit.SelectionLength = 0;
            this.limit.SelectionStart = 0;
            this.limit.Size = new System.Drawing.Size(170, 23);
            this.limit.TabIndex = 9;
            this.limit.UseSelectable = true;
            this.limit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.limit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(157, 278);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(170, 36);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "SAVE";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(353, 53);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(485, 191);
            this.metroGrid1.TabIndex = 11;
            // 
            // FrmAdd_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 326);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.limit);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.lotno);
            this.Controls.Add(this.variety);
            this.Controls.Add(this.plant);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmAdd_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdd_Product";
            this.Load += new System.EventHandler(this.FrmAdd_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox plant;
        private MetroFramework.Controls.MetroTextBox variety;
        private MetroFramework.Controls.MetroTextBox lotno;
        private MetroFramework.Controls.MetroTextBox rate;
        private MetroFramework.Controls.MetroTextBox limit;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
    }
}