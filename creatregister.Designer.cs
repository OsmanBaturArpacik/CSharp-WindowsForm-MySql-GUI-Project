namespace cevhermobilya
{
    partial class createregister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createregister));
            this.logo = new System.Windows.Forms.PictureBox();
            this.input_citizenshipnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.input_branch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.input_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.input_companyname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.input_surname = new System.Windows.Forms.TextBox();
            this.dataGridViewPRODUCTS = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.input_deliveryaddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.input_phone2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.input_phone1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.add_product = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.input_color = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.input_numberofproduct = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.input_productcode = new System.Windows.Forms.TextBox();
            this.create_register = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.input_productdescription = new System.Windows.Forms.TextBox();
            this.input_orderdate = new System.Windows.Forms.DateTimePicker();
            this.input_shipdate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.extra_addtototalpayment = new System.Windows.Forms.TextBox();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.input_paymentplan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRODUCTS)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(802, 40);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(315, 91);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // input_citizenshipnumber
            // 
            this.input_citizenshipnumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.input_citizenshipnumber.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.input_citizenshipnumber.Location = new System.Drawing.Point(199, 278);
            this.input_citizenshipnumber.Multiline = true;
            this.input_citizenshipnumber.Name = "input_citizenshipnumber";
            this.input_citizenshipnumber.Size = new System.Drawing.Size(182, 26);
            this.input_citizenshipnumber.TabIndex = 4;
            this.input_citizenshipnumber.TextChanged += new System.EventHandler(this.input_citizenshipnumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(401, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 15, 10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "MUSTERI ADI:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(41, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 25, 10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Musteri Bilgileri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(41, 397);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 25, 10, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "SIPARIS TARIHI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(406, 398);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 35, 10, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "SEVK TARIHI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label5.Location = new System.Drawing.Point(758, 398);
            this.label5.Margin = new System.Windows.Forms.Padding(20, 35, 10, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "          SUBE:          ";
            // 
            // input_branch
            // 
            this.input_branch.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.input_branch.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.input_branch.Location = new System.Drawing.Point(938, 398);
            this.input_branch.Multiline = true;
            this.input_branch.Name = "input_branch";
            this.input_branch.Size = new System.Drawing.Size(179, 26);
            this.input_branch.TabIndex = 10;
            this.input_branch.TextChanged += new System.EventHandler(this.input_branch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label6.Location = new System.Drawing.Point(751, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(20, 15, 10, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "MUSTERI SOYADI:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // input_name
            // 
            this.input_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.input_name.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.input_name.Location = new System.Drawing.Point(546, 226);
            this.input_name.Multiline = true;
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(182, 26);
            this.input_name.TabIndex = 2;
            this.input_name.TextChanged += new System.EventHandler(this.input_name_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label7.Location = new System.Drawing.Point(41, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(20, 15, 10, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "    FIRMA ADI:   ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // input_companyname
            // 
            this.input_companyname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.input_companyname.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.input_companyname.Location = new System.Drawing.Point(199, 226);
            this.input_companyname.Multiline = true;
            this.input_companyname.Name = "input_companyname";
            this.input_companyname.Size = new System.Drawing.Size(182, 26);
            this.input_companyname.TabIndex = 1;
            this.input_companyname.TextChanged += new System.EventHandler(this.input_companyname_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label8.Location = new System.Drawing.Point(41, 278);
            this.label8.Margin = new System.Windows.Forms.Padding(20, 15, 10, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "T.C KIMLIK NO:";
            // 
            // input_surname
            // 
            this.input_surname.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.input_surname.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.input_surname.Location = new System.Drawing.Point(938, 226);
            this.input_surname.Multiline = true;
            this.input_surname.Name = "input_surname";
            this.input_surname.Size = new System.Drawing.Size(182, 26);
            this.input_surname.TabIndex = 3;
            this.input_surname.TextChanged += new System.EventHandler(this.input_surname_TextChanged);
            // 
            // dataGridViewPRODUCTS
            // 
            this.dataGridViewPRODUCTS.AllowUserToAddRows = false;
            this.dataGridViewPRODUCTS.AllowUserToDeleteRows = false;
            this.dataGridViewPRODUCTS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.dataGridViewPRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPRODUCTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.productcode,
            this.productdescription,
            this.numberofproduct,
            this.productcolor,
            this.productprice,
            this.extras,
            this.productsum});
            this.dataGridViewPRODUCTS.Location = new System.Drawing.Point(1202, 153);
            this.dataGridViewPRODUCTS.Name = "dataGridViewPRODUCTS";
            this.dataGridViewPRODUCTS.ReadOnly = true;
            this.dataGridViewPRODUCTS.Size = new System.Drawing.Size(642, 833);
            this.dataGridViewPRODUCTS.TabIndex = 1;
            this.dataGridViewPRODUCTS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label10.Location = new System.Drawing.Point(41, 331);
            this.label10.Margin = new System.Windows.Forms.Padding(20, 15, 10, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 26);
            this.label10.TabIndex = 22;
            this.label10.Text = " SEVK ADRESI:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // input_deliveryaddress
            // 
            this.input_deliveryaddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.input_deliveryaddress.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.input_deliveryaddress.Location = new System.Drawing.Point(199, 332);
            this.input_deliveryaddress.Multiline = true;
            this.input_deliveryaddress.Name = "input_deliveryaddress";
            this.input_deliveryaddress.Size = new System.Drawing.Size(529, 26);
            this.input_deliveryaddress.TabIndex = 7;
            this.input_deliveryaddress.TextChanged += new System.EventHandler(this.input_deliveryaddress_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label11.Location = new System.Drawing.Point(751, 278);
            this.label11.Margin = new System.Windows.Forms.Padding(20, 15, 10, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 26);
            this.label11.TabIndex = 20;
            this.label11.Text = "            GSM:           ";
            // 
            // input_phone2
            // 
            this.input_phone2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.input_phone2.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.input_phone2.Location = new System.Drawing.Point(938, 278);
            this.input_phone2.Multiline = true;
            this.input_phone2.Name = "input_phone2";
            this.input_phone2.Size = new System.Drawing.Size(182, 26);
            this.input_phone2.TabIndex = 6;
            this.input_phone2.TextChanged += new System.EventHandler(this.input_phone2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label12.Location = new System.Drawing.Point(401, 278);
            this.label12.Margin = new System.Windows.Forms.Padding(20, 15, 10, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 26);
            this.label12.TabIndex = 18;
            this.label12.Text = "         TEL:        ";
            // 
            // input_phone1
            // 
            this.input_phone1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.input_phone1.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.input_phone1.Location = new System.Drawing.Point(546, 278);
            this.input_phone1.Multiline = true;
            this.input_phone1.Name = "input_phone1";
            this.input_phone1.Size = new System.Drawing.Size(182, 26);
            this.input_phone1.TabIndex = 5;
            this.input_phone1.TextChanged += new System.EventHandler(this.input_phone1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label9.Location = new System.Drawing.Point(41, 537);
            this.label9.Margin = new System.Windows.Forms.Padding(20, 25, 10, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 33);
            this.label9.TabIndex = 23;
            this.label9.Text = "Urun Bilgileri:";
            // 
            // add_product
            // 
            this.add_product.BackColor = System.Drawing.Color.Black;
            this.add_product.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.add_product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.add_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.add_product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.add_product.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.add_product.Location = new System.Drawing.Point(41, 736);
            this.add_product.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.add_product.Name = "add_product";
            this.add_product.Size = new System.Drawing.Size(170, 44);
            this.add_product.TabIndex = 15;
            this.add_product.Text = "Urunu Ekle";
            this.add_product.UseVisualStyleBackColor = false;
            this.add_product.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(940, 805);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 44);
            this.button1.TabIndex = 17;
            this.button1.Text = "KAYIT IPTAL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label13.Location = new System.Drawing.Point(750, 610);
            this.label13.Margin = new System.Windows.Forms.Padding(20, 15, 10, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 26);
            this.label13.TabIndex = 32;
            this.label13.Text = "           Renk:           ";
            // 
            // input_color
            // 
            this.input_color.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.input_color.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.input_color.Location = new System.Drawing.Point(937, 610);
            this.input_color.Multiline = true;
            this.input_color.Name = "input_color";
            this.input_color.Size = new System.Drawing.Size(182, 26);
            this.input_color.TabIndex = 13;
            this.input_color.TextChanged += new System.EventHandler(this.input_color_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label14.Location = new System.Drawing.Point(401, 610);
            this.label14.Margin = new System.Windows.Forms.Padding(20, 15, 10, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 26);
            this.label14.TabIndex = 30;
            this.label14.Text = "        Adet:        ";
            // 
            // input_numberofproduct
            // 
            this.input_numberofproduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.input_numberofproduct.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.input_numberofproduct.Location = new System.Drawing.Point(546, 610);
            this.input_numberofproduct.Multiline = true;
            this.input_numberofproduct.Name = "input_numberofproduct";
            this.input_numberofproduct.Size = new System.Drawing.Size(182, 26);
            this.input_numberofproduct.TabIndex = 12;
            this.input_numberofproduct.TextChanged += new System.EventHandler(this.input_numberofproduct_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label15.Location = new System.Drawing.Point(41, 610);
            this.label15.Margin = new System.Windows.Forms.Padding(20, 15, 10, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 26);
            this.label15.TabIndex = 28;
            this.label15.Text = "   URUN KODU:  ";
            // 
            // input_productcode
            // 
            this.input_productcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.input_productcode.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.input_productcode.Location = new System.Drawing.Point(199, 610);
            this.input_productcode.Multiline = true;
            this.input_productcode.Name = "input_productcode";
            this.input_productcode.Size = new System.Drawing.Size(182, 26);
            this.input_productcode.TabIndex = 11;
            this.input_productcode.TextChanged += new System.EventHandler(this.input_productcode_TextChanged);
            // 
            // create_register
            // 
            this.create_register.BackColor = System.Drawing.Color.Black;
            this.create_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.create_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.create_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.create_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.create_register.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.create_register.Location = new System.Drawing.Point(940, 736);
            this.create_register.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.create_register.Name = "create_register";
            this.create_register.Size = new System.Drawing.Size(170, 44);
            this.create_register.TabIndex = 16;
            this.create_register.Text = "KAYITI OLUSTUR";
            this.create_register.UseVisualStyleBackColor = false;
            this.create_register.Click += new System.EventHandler(this.button3_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label16.Location = new System.Drawing.Point(41, 666);
            this.label16.Margin = new System.Windows.Forms.Padding(20, 15, 10, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 26);
            this.label16.TabIndex = 35;
            this.label16.Text = "Urun Aciklamasi:";
            // 
            // input_productdescription
            // 
            this.input_productdescription.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.input_productdescription.Location = new System.Drawing.Point(196, 666);
            this.input_productdescription.Multiline = true;
            this.input_productdescription.Name = "input_productdescription";
            this.input_productdescription.Size = new System.Drawing.Size(532, 26);
            this.input_productdescription.TabIndex = 14;
            this.input_productdescription.TextChanged += new System.EventHandler(this.input_productdescription_TextChanged);
            // 
            // input_orderdate
            // 
            this.input_orderdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.input_orderdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.input_orderdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_orderdate.Location = new System.Drawing.Point(199, 398);
            this.input_orderdate.Name = "input_orderdate";
            this.input_orderdate.Size = new System.Drawing.Size(182, 24);
            this.input_orderdate.TabIndex = 8;
            this.input_orderdate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // input_shipdate
            // 
            this.input_shipdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.input_shipdate.CustomFormat = "";
            this.input_shipdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.input_shipdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.input_shipdate.Location = new System.Drawing.Point(546, 399);
            this.input_shipdate.Name = "input_shipdate";
            this.input_shipdate.Size = new System.Drawing.Size(182, 24);
            this.input_shipdate.TabIndex = 9;
            this.input_shipdate.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label17.Location = new System.Drawing.Point(750, 666);
            this.label17.Margin = new System.Windows.Forms.Padding(20, 15, 10, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(225, 26);
            this.label17.TabIndex = 36;
            this.label17.Text = "EKSTRA (FIYAT ARTISI):";
            // 
            // extra_addtototalpayment
            // 
            this.extra_addtototalpayment.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.extra_addtototalpayment.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.extra_addtototalpayment.Location = new System.Drawing.Point(988, 666);
            this.extra_addtototalpayment.Multiline = true;
            this.extra_addtototalpayment.Name = "extra_addtototalpayment";
            this.extra_addtototalpayment.Size = new System.Drawing.Size(131, 26);
            this.extra_addtototalpayment.TabIndex = 15;
            this.extra_addtototalpayment.TextChanged += new System.EventHandler(this.extra_addtototalpayment_TextChanged);
            // 
            // no
            // 
            this.no.HeaderText = "no";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.no.Width = 27;
            // 
            // productcode
            // 
            this.productcode.HeaderText = "urunkodu";
            this.productcode.Name = "productcode";
            this.productcode.ReadOnly = true;
            this.productcode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productcode.Width = 60;
            // 
            // productdescription
            // 
            this.productdescription.FillWeight = 250F;
            this.productdescription.HeaderText = "urunaciklama";
            this.productdescription.Name = "productdescription";
            this.productdescription.ReadOnly = true;
            this.productdescription.Width = 200;
            // 
            // numberofproduct
            // 
            this.numberofproduct.HeaderText = "adet";
            this.numberofproduct.Name = "numberofproduct";
            this.numberofproduct.ReadOnly = true;
            this.numberofproduct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.numberofproduct.Width = 35;
            // 
            // productcolor
            // 
            this.productcolor.HeaderText = "renk";
            this.productcolor.Name = "productcolor";
            this.productcolor.ReadOnly = true;
            this.productcolor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productcolor.Width = 60;
            // 
            // productprice
            // 
            this.productprice.HeaderText = "birimfiyat";
            this.productprice.Name = "productprice";
            this.productprice.ReadOnly = true;
            this.productprice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productprice.Width = 73;
            // 
            // extras
            // 
            this.extras.HeaderText = "ekstralar";
            this.extras.Name = "extras";
            this.extras.ReadOnly = true;
            this.extras.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.extras.Width = 52;
            // 
            // productsum
            // 
            this.productsum.HeaderText = "toplamfiyat";
            this.productsum.Name = "productsum";
            this.productsum.ReadOnly = true;
            this.productsum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Black;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label18.Location = new System.Drawing.Point(751, 331);
            this.label18.Margin = new System.Windows.Forms.Padding(20, 15, 10, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(175, 26);
            this.label18.TabIndex = 37;
            this.label18.Text = "   ODEME PLANI:   ";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // input_paymentplan
            // 
            this.input_paymentplan.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.input_paymentplan.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.input_paymentplan.Location = new System.Drawing.Point(938, 331);
            this.input_paymentplan.Multiline = true;
            this.input_paymentplan.Name = "input_paymentplan";
            this.input_paymentplan.Size = new System.Drawing.Size(182, 26);
            this.input_paymentplan.TabIndex = 38;
            // 
            // createregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.input_paymentplan);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.extra_addtototalpayment);
            this.Controls.Add(this.input_shipdate);
            this.Controls.Add(this.input_orderdate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.input_productdescription);
            this.Controls.Add(this.create_register);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.input_color);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.input_numberofproduct);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.input_productcode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_product);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.input_deliveryaddress);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.input_phone2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.input_phone1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.input_companyname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.input_surname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_branch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_citizenshipnumber);
            this.Controls.Add(this.dataGridViewPRODUCTS);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "createregister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cevher Mobilya - Yeni Kayıt Oluştur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.newordercreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRODUCTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox input_citizenshipnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_branch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox input_companyname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox input_surname;
        private System.Windows.Forms.DataGridView dataGridViewPRODUCTS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox input_deliveryaddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox input_phone2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox input_phone1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button add_product;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox input_color;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox input_numberofproduct;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox input_productcode;
        private System.Windows.Forms.Button create_register;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox input_productdescription;
        private System.Windows.Forms.DateTimePicker input_orderdate;
        private System.Windows.Forms.DateTimePicker input_shipdate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox extra_addtototalpayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productdescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn productprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn extras;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsum;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox input_paymentplan;
    }
}