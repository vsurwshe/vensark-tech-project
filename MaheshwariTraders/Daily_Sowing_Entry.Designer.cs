namespace MaheshwariTraders
{
    partial class Daily_Sowing_Entry
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.abillno = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.sowing = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.krushikendrabillno = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lotno = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.totalseeds = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.traysize = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.shorting = new MetroFramework.Controls.MetroDateTime();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.totalplants = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.adv = new MetroFramework.Controls.MetroCheckBox();
            this.advancebillno = new System.Windows.Forms.ComboBox();
            this.row = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.variety = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(149, 125);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Sowing ID:";
            this.metroLabel1.Visible = false;
           // this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // abillno
            // 
            this.abillno.Location = new System.Drawing.Point(235, 125);
            this.abillno.Name = "abillno";
            this.abillno.Size = new System.Drawing.Size(120, 23);
            this.abillno.TabIndex = 1;
           // this.abillno.Click += new System.EventHandler(this.abillno_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(132, 170);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Sowing Date:";
          //  this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // sowing
            // 
            this.sowing.CustomFormat = "dd-MM-yyyy";
            this.sowing.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sowing.Location = new System.Drawing.Point(235, 168);
            this.sowing.MinimumSize = new System.Drawing.Size(0, 29);
            this.sowing.Name = "sowing";
            this.sowing.Size = new System.Drawing.Size(200, 29);
            this.sowing.TabIndex = 5;
            this.sowing.ValueChanged += new System.EventHandler(this.sowing_ValueChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(23, 219);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(207, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Krushi Kendra && Bill Number:";
            //this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // krushikendrabillno
            // 
            // 
            // 
            // 
            this.krushikendrabillno.CustomButton.Image = null;
            this.krushikendrabillno.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.krushikendrabillno.CustomButton.Name = "";
            this.krushikendrabillno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.krushikendrabillno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.krushikendrabillno.CustomButton.TabIndex = 1;
            this.krushikendrabillno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.krushikendrabillno.CustomButton.UseSelectable = true;
            this.krushikendrabillno.CustomButton.Visible = false;
            this.krushikendrabillno.Lines = new string[0];
            this.krushikendrabillno.Location = new System.Drawing.Point(235, 219);
            this.krushikendrabillno.MaxLength = 32767;
            this.krushikendrabillno.Name = "krushikendrabillno";
            this.krushikendrabillno.PasswordChar = '\0';
            this.krushikendrabillno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.krushikendrabillno.SelectedText = "";
            this.krushikendrabillno.SelectionLength = 0;
            this.krushikendrabillno.SelectionStart = 0;
            this.krushikendrabillno.Size = new System.Drawing.Size(201, 23);
            this.krushikendrabillno.TabIndex = 7;
            this.krushikendrabillno.UseSelectable = true;
            this.krushikendrabillno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.krushikendrabillno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
           // this.krushikendrabillno.Click += new System.EventHandler(this.krushikendrabillno_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(168, 264);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Variety:";
           // this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(167, 314);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(62, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Lot No.:";
           // this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // lotno
            // 
            // 
            // 
            // 
            this.lotno.CustomButton.Image = null;
            this.lotno.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.lotno.CustomButton.Name = "";
            this.lotno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lotno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lotno.CustomButton.TabIndex = 1;
            this.lotno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lotno.CustomButton.UseSelectable = true;
            this.lotno.CustomButton.Visible = false;
            this.lotno.Lines = new string[0];
            this.lotno.Location = new System.Drawing.Point(235, 313);
            this.lotno.MaxLength = 32767;
            this.lotno.Name = "lotno";
            this.lotno.PasswordChar = '\0';
            this.lotno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lotno.SelectedText = "";
            this.lotno.SelectionLength = 0;
            this.lotno.SelectionStart = 0;
            this.lotno.Size = new System.Drawing.Size(200, 23);
            this.lotno.TabIndex = 11;
            this.lotno.UseSelectable = true;
            this.lotno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lotno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            //this.lotno.Click += new System.EventHandler(this.lotno_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(142, 359);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(89, 19);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "Total Seeds:";
            //this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // totalseeds
            // 
            // 
            // 
            // 
            this.totalseeds.CustomButton.Image = null;
            this.totalseeds.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.totalseeds.CustomButton.Name = "";
            this.totalseeds.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.totalseeds.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalseeds.CustomButton.TabIndex = 1;
            this.totalseeds.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalseeds.CustomButton.UseSelectable = true;
            this.totalseeds.CustomButton.Visible = false;
            this.totalseeds.Lines = new string[0];
            this.totalseeds.Location = new System.Drawing.Point(235, 359);
            this.totalseeds.MaxLength = 32767;
            this.totalseeds.Name = "totalseeds";
            this.totalseeds.PasswordChar = '\0';
            this.totalseeds.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalseeds.SelectedText = "";
            this.totalseeds.SelectionLength = 0;
            this.totalseeds.SelectionStart = 0;
            this.totalseeds.Size = new System.Drawing.Size(83, 23);
            this.totalseeds.TabIndex = 13;
            this.totalseeds.UseSelectable = true;
            this.totalseeds.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalseeds.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
           // this.totalseeds.Click += new System.EventHandler(this.totalseeds_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(155, 405);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(73, 19);
            this.metroLabel9.TabIndex = 14;
            this.metroLabel9.Text = "Tray Size:";
            this.metroLabel9.Visible = false;
            //this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // traysize
            // 
            // 
            // 
            // 
            this.traysize.CustomButton.Image = null;
            this.traysize.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.traysize.CustomButton.Name = "";
            this.traysize.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.traysize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.traysize.CustomButton.TabIndex = 1;
            this.traysize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.traysize.CustomButton.UseSelectable = true;
            this.traysize.CustomButton.Visible = false;
            this.traysize.Enabled = false;
            this.traysize.Lines = new string[0];
            this.traysize.Location = new System.Drawing.Point(235, 405);
            this.traysize.MaxLength = 32767;
            this.traysize.Name = "traysize";
            this.traysize.PasswordChar = '\0';
            this.traysize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.traysize.SelectedText = "";
            this.traysize.SelectionLength = 0;
            this.traysize.SelectionStart = 0;
            this.traysize.Size = new System.Drawing.Size(200, 23);
            this.traysize.TabIndex = 15;
            this.traysize.UseSelectable = true;
            this.traysize.Visible = false;
            this.traysize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.traysize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
           // this.traysize.Click += new System.EventHandler(this.traysize_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(124, 451);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(105, 19);
            this.metroLabel10.TabIndex = 16;
            this.metroLabel10.Text = "Shorting Date:";
            this.metroLabel10.Visible = false;
           // this.metroLabel10.Click += new System.EventHandler(this.metroLabel10_Click);
            // 
            // shorting
            // 
            this.shorting.CustomFormat = "dd-MM-yyyy";
            this.shorting.Enabled = false;
            this.shorting.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.shorting.Location = new System.Drawing.Point(235, 447);
            this.shorting.MinimumSize = new System.Drawing.Size(0, 29);
            this.shorting.Name = "shorting";
            this.shorting.Size = new System.Drawing.Size(200, 29);
            this.shorting.TabIndex = 17;
            this.shorting.Visible = false;
           // this.shorting.ValueChanged += new System.EventHandler(this.shorting_ValueChanged);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.Red;
            this.metroButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.Location = new System.Drawing.Point(322, 545);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(112, 36);
            this.metroButton3.TabIndex = 20;
            this.metroButton3.Text = "CLOSE";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Salmon;
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Location = new System.Drawing.Point(168, 545);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(112, 36);
            this.metroButton2.TabIndex = 19;
            this.metroButton2.Text = "RESET";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(15, 545);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(112, 36);
            this.metroButton1.TabIndex = 18;
            this.metroButton1.Text = "SAVE";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // totalplants
            // 
            // 
            // 
            // 
            this.totalplants.CustomButton.Image = null;
            this.totalplants.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.totalplants.CustomButton.Name = "";
            this.totalplants.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.totalplants.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalplants.CustomButton.TabIndex = 1;
            this.totalplants.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalplants.CustomButton.UseSelectable = true;
            this.totalplants.CustomButton.Visible = false;
            this.totalplants.Enabled = false;
            this.totalplants.Lines = new string[0];
            this.totalplants.Location = new System.Drawing.Point(235, 494);
            this.totalplants.MaxLength = 32767;
            this.totalplants.Name = "totalplants";
            this.totalplants.PasswordChar = '\0';
            this.totalplants.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalplants.SelectedText = "";
            this.totalplants.SelectionLength = 0;
            this.totalplants.SelectionStart = 0;
            this.totalplants.Size = new System.Drawing.Size(201, 23);
            this.totalplants.TabIndex = 22;
            this.totalplants.UseSelectable = true;
            this.totalplants.Visible = false;
            this.totalplants.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalplants.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            //this.totalplants.Click += new System.EventHandler(this.totalplants_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(138, 495);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "Total Plants:";
            this.metroLabel2.Visible = false;
            //this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(462, 80);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(868, 240);
            this.dataGridView1.TabIndex = 23;
           // this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(129, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 19);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Sowing Plant:";
           // this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(235, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 24);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(462, 341);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(615, 240);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.Visible = false;
           // this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // adv
            // 
            this.adv.AutoSize = true;
            this.adv.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.adv.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.adv.Location = new System.Drawing.Point(91, 54);
            this.adv.Name = "adv";
            this.adv.Size = new System.Drawing.Size(140, 19);
            this.adv.TabIndex = 28;
            this.adv.Text = "Advance Bill No.:";
            this.adv.UseSelectable = true;
            this.adv.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // advancebillno
            // 
            this.advancebillno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.advancebillno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancebillno.FormattingEnabled = true;
            this.advancebillno.Location = new System.Drawing.Point(236, 54);
            this.advancebillno.Name = "advancebillno";
            this.advancebillno.Size = new System.Drawing.Size(199, 24);
            this.advancebillno.TabIndex = 29;
            this.advancebillno.Visible = false;
           // this.advancebillno.SelectedIndexChanged += new System.EventHandler(this.advancebillno_SelectedIndexChanged);
            // 
            // row
            // 
            // 
            // 
            // 
            this.row.CustomButton.Image = null;
            this.row.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.row.CustomButton.Name = "";
            this.row.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.row.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.row.CustomButton.TabIndex = 1;
            this.row.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.row.CustomButton.UseSelectable = true;
            this.row.CustomButton.Visible = false;
            this.row.Lines = new string[0];
            this.row.Location = new System.Drawing.Point(350, 359);
            this.row.MaxLength = 32767;
            this.row.Name = "row";
            this.row.PasswordChar = '\0';
            this.row.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.row.SelectedText = "";
            this.row.SelectionLength = 0;
            this.row.SelectionStart = 0;
            this.row.Size = new System.Drawing.Size(84, 23);
            this.row.TabIndex = 31;
            this.row.UseSelectable = true;
            this.row.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.row.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(322, 358);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(24, 25);
            this.metroLabel11.TabIndex = 32;
            this.metroLabel11.Text = "X";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(236, 125);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(201, 23);
            this.metroTextBox1.TabIndex = 33;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.Visible = false;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // variety
            // 
            // 
            // 
            // 
            this.variety.CustomButton.Image = null;
            this.variety.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.variety.CustomButton.Name = "";
            this.variety.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.variety.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.variety.CustomButton.TabIndex = 1;
            this.variety.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.variety.CustomButton.UseSelectable = true;
            this.variety.CustomButton.Visible = false;
            this.variety.Lines = new string[0];
            this.variety.Location = new System.Drawing.Point(234, 260);
            this.variety.MaxLength = 32767;
            this.variety.Name = "variety";
            this.variety.PasswordChar = '\0';
            this.variety.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.variety.SelectedText = "";
            this.variety.SelectionLength = 0;
            this.variety.SelectionStart = 0;
            this.variety.Size = new System.Drawing.Size(200, 23);
            this.variety.TabIndex = 34;
            this.variety.UseSelectable = true;
            this.variety.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.variety.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Daily_Sowing_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 607);
            this.Controls.Add(this.variety);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.row);
            this.Controls.Add(this.advancebillno);
            this.Controls.Add(this.adv);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.totalplants);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.shorting);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.traysize);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.totalseeds);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.lotno);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.krushikendrabillno);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.sowing);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.abillno);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Daily_Sowing_Entry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Add_Advance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel abillno;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime sowing;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox krushikendrabillno;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox lotno;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox totalseeds;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox traysize;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroDateTime shorting;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox totalplants;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroCheckBox adv;
        private System.Windows.Forms.ComboBox advancebillno;
        private MetroFramework.Controls.MetroTextBox row;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox variety;
    }
}