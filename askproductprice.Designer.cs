namespace cevhermobilya
{
    partial class askproductprice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(askproductprice));
            this.logo = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ask_productcode = new System.Windows.Forms.TextBox();
            this.ask_product = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(802, 40);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(315, 91);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label16.Location = new System.Drawing.Point(124, 232);
            this.label16.Margin = new System.Windows.Forms.Padding(20, 15, 10, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 27);
            this.label16.TabIndex = 17;
            this.label16.Text = "  URUN KODU:  ";
            // 
            // ask_productcode
            // 
            this.ask_productcode.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.ask_productcode.Location = new System.Drawing.Point(307, 232);
            this.ask_productcode.Multiline = true;
            this.ask_productcode.Name = "ask_productcode";
            this.ask_productcode.Size = new System.Drawing.Size(212, 27);
            this.ask_productcode.TabIndex = 1;
            this.ask_productcode.TextChanged += new System.EventHandler(this.ask_productcode_TextChanged);
            // 
            // ask_product
            // 
            this.ask_product.BackColor = System.Drawing.Color.Black;
            this.ask_product.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ask_product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.ask_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ask_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ask_product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.ask_product.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ask_product.Location = new System.Drawing.Point(124, 288);
            this.ask_product.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ask_product.Name = "ask_product";
            this.ask_product.Size = new System.Drawing.Size(226, 44);
            this.ask_product.TabIndex = 2;
            this.ask_product.Text = "URUN FIYATI SORGULA";
            this.ask_product.UseVisualStyleBackColor = false;
            this.ask_product.Click += new System.EventHandler(this.ask_product_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button8.Location = new System.Drawing.Point(1145, 288);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(226, 44);
            this.button8.TabIndex = 3;
            this.button8.Text = "ANA EKRANA DON";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productcode,
            this.productprice});
            this.dataGridView1.Location = new System.Drawing.Point(124, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 28;
            // 
            // productcode
            // 
            this.productcode.HeaderText = "urunkodu";
            this.productcode.Name = "productcode";
            this.productcode.ReadOnly = true;
            // 
            // productprice
            // 
            this.productprice.HeaderText = "urunfiyati";
            this.productprice.Name = "productprice";
            this.productprice.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "connection mysql test";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // askproductprice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.ask_product);
            this.Controls.Add(this.ask_productcode);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "askproductprice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cevher Mobilya - Fiyat Sorgula";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.askproductprice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ask_productcode;
        private System.Windows.Forms.Button ask_product;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productprice;
        private System.Windows.Forms.Button button1;
    }
}