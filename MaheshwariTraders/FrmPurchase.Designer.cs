namespace MaheshwariTraders
{
    partial class FrmPurchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.dt = new MetroFramework.Controls.MetroDateTime();
            this.unpaid = new MetroFramework.Controls.MetroTextBox();
            this.uu = new MetroFramework.Controls.MetroLabel();
            this.paid = new MetroFramework.Controls.MetroTextBox();
            this.pp = new MetroFramework.Controls.MetroLabel();
            this.gtotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.total = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.rate = new MetroFramework.Controls.MetroTextBox();
            this.rrt = new MetroFramework.Controls.MetroLabel();
            this.bill = new MetroFramework.Controls.MetroTextBox();
            this.bb = new MetroFramework.Controls.MetroLabel();
            this.mob = new MetroFramework.Controls.MetroTextBox();
            this.amn = new MetroFramework.Controls.MetroLabel();
            this.shopname = new MetroFramework.Controls.MetroLabel();
            this.date = new MetroFramework.Controls.MetroLabel();
            this.cmbproduct = new MetroFramework.Controls.MetroComboBox();
            this.txtqty = new MetroFramework.Controls.MetroTextBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.shop = new MetroFramework.Controls.MetroComboBox();
            this.TxtDetails = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.metroPanel3.Controls.Add(this.TxtDetails);
            this.metroPanel3.Controls.Add(this.metroLabel1);
            this.metroPanel3.Controls.Add(this.shop);
            this.metroPanel3.Controls.Add(this.dt);
            this.metroPanel3.Controls.Add(this.unpaid);
            this.metroPanel3.Controls.Add(this.uu);
            this.metroPanel3.Controls.Add(this.paid);
            this.metroPanel3.Controls.Add(this.pp);
            this.metroPanel3.Controls.Add(this.gtotal);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.total);
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.Controls.Add(this.rate);
            this.metroPanel3.Controls.Add(this.rrt);
            this.metroPanel3.Controls.Add(this.bill);
            this.metroPanel3.Controls.Add(this.bb);
            this.metroPanel3.Controls.Add(this.mob);
            this.metroPanel3.Controls.Add(this.amn);
            this.metroPanel3.Controls.Add(this.shopname);
            this.metroPanel3.Controls.Add(this.date);
            this.metroPanel3.Controls.Add(this.cmbproduct);
            this.metroPanel3.Controls.Add(this.txtqty);
            this.metroPanel3.Controls.Add(this.metroButton3);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Controls.Add(this.metroLabel5);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(36, 48);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(414, 528);
            this.metroPanel3.TabIndex = 56;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            this.metroPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel3_Paint);
            // 
            // dt
            // 
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt.Location = new System.Drawing.Point(169, 139);
            this.dt.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(141, 29);
            this.dt.TabIndex = 70;
            // 
            // unpaid
            // 
            // 
            // 
            // 
            this.unpaid.CustomButton.Image = null;
            this.unpaid.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.unpaid.CustomButton.Name = "";
            this.unpaid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.unpaid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.unpaid.CustomButton.TabIndex = 1;
            this.unpaid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.unpaid.CustomButton.UseSelectable = true;
            this.unpaid.CustomButton.Visible = false;
            this.unpaid.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.unpaid.Lines = new string[0];
            this.unpaid.Location = new System.Drawing.Point(169, 420);
            this.unpaid.MaxLength = 32767;
            this.unpaid.Name = "unpaid";
            this.unpaid.PasswordChar = '\0';
            this.unpaid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.unpaid.SelectedText = "";
            this.unpaid.SelectionLength = 0;
            this.unpaid.SelectionStart = 0;
            this.unpaid.Size = new System.Drawing.Size(141, 23);
            this.unpaid.TabIndex = 69;
            this.unpaid.UseSelectable = true;
            this.unpaid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.unpaid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.unpaid.Click += new System.EventHandler(this.unpaid_Click);
            // 
            // uu
            // 
            this.uu.AutoSize = true;
            this.uu.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.uu.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.uu.Location = new System.Drawing.Point(85, 418);
            this.uu.Name = "uu";
            this.uu.Size = new System.Drawing.Size(78, 25);
            this.uu.TabIndex = 68;
            this.uu.Text = "Unpaid:";
            // 
            // paid
            // 
            // 
            // 
            // 
            this.paid.CustomButton.Image = null;
            this.paid.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.paid.CustomButton.Name = "";
            this.paid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.paid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.paid.CustomButton.TabIndex = 1;
            this.paid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.paid.CustomButton.UseSelectable = true;
            this.paid.CustomButton.Visible = false;
            this.paid.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.paid.Lines = new string[0];
            this.paid.Location = new System.Drawing.Point(169, 389);
            this.paid.MaxLength = 32767;
            this.paid.Name = "paid";
            this.paid.PasswordChar = '\0';
            this.paid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.paid.SelectedText = "";
            this.paid.SelectionLength = 0;
            this.paid.SelectionStart = 0;
            this.paid.Size = new System.Drawing.Size(141, 23);
            this.paid.TabIndex = 67;
            this.paid.UseSelectable = true;
            this.paid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.paid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.paid.Click += new System.EventHandler(this.metroTextBox8_Click);
            // 
            // pp
            // 
            this.pp.AutoSize = true;
            this.pp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.pp.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.pp.Location = new System.Drawing.Point(110, 388);
            this.pp.Name = "pp";
            this.pp.Size = new System.Drawing.Size(54, 25);
            this.pp.TabIndex = 66;
            this.pp.Text = "Paid:";
            this.pp.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // gtotal
            // 
            // 
            // 
            // 
            this.gtotal.CustomButton.Image = null;
            this.gtotal.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.gtotal.CustomButton.Name = "";
            this.gtotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gtotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gtotal.CustomButton.TabIndex = 1;
            this.gtotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gtotal.CustomButton.UseSelectable = true;
            this.gtotal.CustomButton.Visible = false;
            this.gtotal.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.gtotal.Lines = new string[0];
            this.gtotal.Location = new System.Drawing.Point(169, 354);
            this.gtotal.MaxLength = 32767;
            this.gtotal.Name = "gtotal";
            this.gtotal.PasswordChar = '\0';
            this.gtotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gtotal.SelectedText = "";
            this.gtotal.SelectionLength = 0;
            this.gtotal.SelectionStart = 0;
            this.gtotal.Size = new System.Drawing.Size(141, 23);
            this.gtotal.TabIndex = 65;
            this.gtotal.UseSelectable = true;
            this.gtotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gtotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(48, 352);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(116, 25);
            this.metroLabel4.TabIndex = 64;
            this.metroLabel4.Text = "Grand Total:";
            // 
            // total
            // 
            // 
            // 
            // 
            this.total.CustomButton.Image = null;
            this.total.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.total.CustomButton.Name = "";
            this.total.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.total.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.total.CustomButton.TabIndex = 1;
            this.total.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.total.CustomButton.UseSelectable = true;
            this.total.CustomButton.Visible = false;
            this.total.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.total.Lines = new string[0];
            this.total.Location = new System.Drawing.Point(169, 320);
            this.total.MaxLength = 32767;
            this.total.Name = "total";
            this.total.PasswordChar = '\0';
            this.total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.total.SelectedText = "";
            this.total.SelectionLength = 0;
            this.total.SelectionStart = 0;
            this.total.Size = new System.Drawing.Size(141, 23);
            this.total.TabIndex = 63;
            this.total.UseSelectable = true;
            this.total.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.total.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(104, 320);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 25);
            this.metroLabel2.TabIndex = 62;
            this.metroLabel2.Text = "Total:";
            // 
            // rate
            // 
            // 
            // 
            // 
            this.rate.CustomButton.Image = null;
            this.rate.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.rate.CustomButton.Name = "";
            this.rate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.rate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rate.CustomButton.TabIndex = 1;
            this.rate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rate.CustomButton.UseSelectable = true;
            this.rate.CustomButton.Visible = false;
            this.rate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.rate.Lines = new string[0];
            this.rate.Location = new System.Drawing.Point(169, 287);
            this.rate.MaxLength = 32767;
            this.rate.Name = "rate";
            this.rate.PasswordChar = '\0';
            this.rate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rate.SelectedText = "";
            this.rate.SelectionLength = 0;
            this.rate.SelectionStart = 0;
            this.rate.Size = new System.Drawing.Size(141, 23);
            this.rate.TabIndex = 61;
            this.rate.UseSelectable = true;
            this.rate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rrt
            // 
            this.rrt.AutoSize = true;
            this.rrt.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.rrt.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.rrt.Location = new System.Drawing.Point(107, 287);
            this.rrt.Name = "rrt";
            this.rrt.Size = new System.Drawing.Size(56, 25);
            this.rrt.TabIndex = 60;
            this.rrt.Text = "Rate:";
            // 
            // bill
            // 
            // 
            // 
            // 
            this.bill.CustomButton.Image = null;
            this.bill.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.bill.CustomButton.Name = "";
            this.bill.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.bill.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bill.CustomButton.TabIndex = 1;
            this.bill.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bill.CustomButton.UseSelectable = true;
            this.bill.CustomButton.Visible = false;
            this.bill.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.bill.Lines = new string[0];
            this.bill.Location = new System.Drawing.Point(169, 253);
            this.bill.MaxLength = 32767;
            this.bill.Name = "bill";
            this.bill.PasswordChar = '\0';
            this.bill.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bill.SelectedText = "";
            this.bill.SelectionLength = 0;
            this.bill.SelectionStart = 0;
            this.bill.Size = new System.Drawing.Size(141, 23);
            this.bill.TabIndex = 59;
            this.bill.UseSelectable = true;
            this.bill.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bill.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bb
            // 
            this.bb.AutoSize = true;
            this.bb.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.bb.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.bb.Location = new System.Drawing.Point(89, 253);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(74, 25);
            this.bb.TabIndex = 58;
            this.bb.Text = "Bill No:";
            // 
            // mob
            // 
            // 
            // 
            // 
            this.mob.CustomButton.Image = null;
            this.mob.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.mob.CustomButton.Name = "";
            this.mob.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mob.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mob.CustomButton.TabIndex = 1;
            this.mob.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mob.CustomButton.UseSelectable = true;
            this.mob.CustomButton.Visible = false;
            this.mob.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mob.Lines = new string[0];
            this.mob.Location = new System.Drawing.Point(169, 219);
            this.mob.MaxLength = 32767;
            this.mob.Name = "mob";
            this.mob.PasswordChar = '\0';
            this.mob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mob.SelectedText = "";
            this.mob.SelectionLength = 0;
            this.mob.SelectionStart = 0;
            this.mob.Size = new System.Drawing.Size(141, 23);
            this.mob.TabIndex = 57;
            this.mob.UseSelectable = true;
            this.mob.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mob.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // amn
            // 
            this.amn.AutoSize = true;
            this.amn.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.amn.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.amn.Location = new System.Drawing.Point(9, 219);
            this.amn.Name = "amn";
            this.amn.Size = new System.Drawing.Size(154, 25);
            this.amn.TabIndex = 56;
            this.amn.Text = "Shop Mobile No:";
            // 
            // shopname
            // 
            this.shopname.AutoSize = true;
            this.shopname.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.shopname.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.shopname.Location = new System.Drawing.Point(48, 179);
            this.shopname.Name = "shopname";
            this.shopname.Size = new System.Drawing.Size(115, 25);
            this.shopname.TabIndex = 54;
            this.shopname.Text = "Shop Name:";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.date.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.date.Location = new System.Drawing.Point(24, 139);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(139, 25);
            this.date.TabIndex = 52;
            this.date.Text = "Purchase Date:";
            // 
            // cmbproduct
            // 
            this.cmbproduct.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbproduct.FormattingEnabled = true;
            this.cmbproduct.ItemHeight = 29;
            this.cmbproduct.Location = new System.Drawing.Point(169, 38);
            this.cmbproduct.Name = "cmbproduct";
            this.cmbproduct.Size = new System.Drawing.Size(222, 35);
            this.cmbproduct.TabIndex = 51;
            this.cmbproduct.UseSelectable = true;
            this.cmbproduct.SelectedIndexChanged += new System.EventHandler(this.cmbproduct_SelectedIndexChanged);
            // 
            // txtqty
            // 
            // 
            // 
            // 
            this.txtqty.CustomButton.Image = null;
            this.txtqty.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtqty.CustomButton.Name = "";
            this.txtqty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtqty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtqty.CustomButton.TabIndex = 1;
            this.txtqty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtqty.CustomButton.UseSelectable = true;
            this.txtqty.CustomButton.Visible = false;
            this.txtqty.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtqty.Lines = new string[0];
            this.txtqty.Location = new System.Drawing.Point(169, 81);
            this.txtqty.MaxLength = 32767;
            this.txtqty.Name = "txtqty";
            this.txtqty.PasswordChar = '\0';
            this.txtqty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtqty.SelectedText = "";
            this.txtqty.SelectionLength = 0;
            this.txtqty.SelectionStart = 0;
            this.txtqty.Size = new System.Drawing.Size(141, 23);
            this.txtqty.TabIndex = 50;
            this.txtqty.UseSelectable = true;
            this.txtqty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtqty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.White;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton3.Location = new System.Drawing.Point(110, 463);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(195, 44);
            this.metroButton3.TabIndex = 49;
            this.metroButton3.Text = "Update";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(24, 42);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(139, 25);
            this.metroLabel3.TabIndex = 47;
            this.metroLabel3.Text = "Product Name:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(71, 79);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 25);
            this.metroLabel5.TabIndex = 45;
            this.metroLabel5.Text = "Quantity:";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(492, 48);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(545, 501);
            this.metroGrid1.TabIndex = 57;
            // 
            // shop
            // 
            this.shop.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.shop.FormattingEnabled = true;
            this.shop.ItemHeight = 29;
            this.shop.Location = new System.Drawing.Point(169, 174);
            this.shop.Name = "shop";
            this.shop.Size = new System.Drawing.Size(222, 35);
            this.shop.TabIndex = 71;
            this.shop.UseSelectable = true;
            this.shop.TextChanged += new System.EventHandler(this.shop_TextChanged);
            // 
            // TxtDetails
            // 
            // 
            // 
            // 
            this.TxtDetails.CustomButton.Image = null;
            this.TxtDetails.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.TxtDetails.CustomButton.Name = "";
            this.TxtDetails.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtDetails.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDetails.CustomButton.TabIndex = 1;
            this.TxtDetails.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDetails.CustomButton.UseSelectable = true;
            this.TxtDetails.CustomButton.Visible = false;
            this.TxtDetails.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtDetails.Lines = new string[0];
            this.TxtDetails.Location = new System.Drawing.Point(170, 111);
            this.TxtDetails.MaxLength = 32767;
            this.TxtDetails.Name = "TxtDetails";
            this.TxtDetails.PasswordChar = '\0';
            this.TxtDetails.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDetails.SelectedText = "";
            this.TxtDetails.SelectionLength = 0;
            this.TxtDetails.SelectionStart = 0;
            this.TxtDetails.Size = new System.Drawing.Size(214, 23);
            this.TxtDetails.TabIndex = 73;
            this.TxtDetails.UseSelectable = true;
            this.TxtDetails.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDetails.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDetails.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(72, 110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 25);
            this.metroLabel1.TabIndex = 72;
            this.metroLabel1.Text = "Details:";
            // 
            // FrmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 700);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmPurchase";
            this.Load += new System.EventHandler(this.FrmPurchase_Load);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroComboBox cmbproduct;
        private MetroFramework.Controls.MetroTextBox txtqty;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox paid;
        private MetroFramework.Controls.MetroLabel pp;
        private MetroFramework.Controls.MetroTextBox gtotal;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox total;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox rate;
        private MetroFramework.Controls.MetroLabel rrt;
        private MetroFramework.Controls.MetroTextBox bill;
        private MetroFramework.Controls.MetroLabel bb;
        private MetroFramework.Controls.MetroTextBox mob;
        private MetroFramework.Controls.MetroLabel amn;
        private MetroFramework.Controls.MetroLabel shopname;
        private MetroFramework.Controls.MetroLabel date;
        private MetroFramework.Controls.MetroTextBox unpaid;
        private MetroFramework.Controls.MetroLabel uu;
        private MetroFramework.Controls.MetroDateTime dt;
        private MetroFramework.Controls.MetroComboBox shop;
        private MetroFramework.Controls.MetroTextBox TxtDetails;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}