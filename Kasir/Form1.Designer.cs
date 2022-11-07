
namespace Kasir
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblBarang = new System.Windows.Forms.Label();
            this.numSebanyak = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbBarang = new System.Windows.Forms.ComboBox();
            this.lblSebanyak = new System.Windows.Forms.Label();
            this.lblTambahB = new System.Windows.Forms.Label();
            this.txtTambahBarang = new System.Windows.Forms.TextBox();
            this.lblGambar = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.cmbHarga = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnBeli = new System.Windows.Forms.Button();
            this.btnBayar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.picSepatu = new System.Windows.Forms.PictureBox();
            this.picBaju = new System.Windows.Forms.PictureBox();
            this.picTas = new System.Windows.Forms.PictureBox();
            this.txtTotalHarga = new System.Windows.Forms.TextBox();
            this.picTasbih = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSebanyak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSepatu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBaju)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTasbih)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(235, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA PENJUALAN";
            // 
            // lblBarang
            // 
            this.lblBarang.AutoSize = true;
            this.lblBarang.Location = new System.Drawing.Point(66, 101);
            this.lblBarang.Name = "lblBarang";
            this.lblBarang.Size = new System.Drawing.Size(71, 15);
            this.lblBarang.TabIndex = 1;
            this.lblBarang.Text = "Item Barang";
            this.lblBarang.Click += new System.EventHandler(this.lblBarang_Click);
            // 
            // numSebanyak
            // 
            this.numSebanyak.Location = new System.Drawing.Point(161, 148);
            this.numSebanyak.Name = "numSebanyak";
            this.numSebanyak.Size = new System.Drawing.Size(120, 23);
            this.numSebanyak.TabIndex = 2;
            this.numSebanyak.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(60, 396);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 154);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cmbBarang
            // 
            this.cmbBarang.FormattingEnabled = true;
            this.cmbBarang.Items.AddRange(new object[] {
            "Tas",
            "Sepatu",
            "Baju"});
            this.cmbBarang.Location = new System.Drawing.Point(161, 98);
            this.cmbBarang.Name = "cmbBarang";
            this.cmbBarang.Size = new System.Drawing.Size(121, 23);
            this.cmbBarang.TabIndex = 4;
            this.cmbBarang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSebanyak
            // 
            this.lblSebanyak.AutoSize = true;
            this.lblSebanyak.Location = new System.Drawing.Point(63, 153);
            this.lblSebanyak.Name = "lblSebanyak";
            this.lblSebanyak.Size = new System.Drawing.Size(57, 15);
            this.lblSebanyak.TabIndex = 5;
            this.lblSebanyak.Text = "Sebanyak";
            // 
            // lblTambahB
            // 
            this.lblTambahB.AutoSize = true;
            this.lblTambahB.Location = new System.Drawing.Point(60, 203);
            this.lblTambahB.Name = "lblTambahB";
            this.lblTambahB.Size = new System.Drawing.Size(89, 15);
            this.lblTambahB.TabIndex = 6;
            this.lblTambahB.Text = "Tambah Barang";
            // 
            // txtTambahBarang
            // 
            this.txtTambahBarang.Location = new System.Drawing.Point(161, 200);
            this.txtTambahBarang.Name = "txtTambahBarang";
            this.txtTambahBarang.Size = new System.Drawing.Size(120, 23);
            this.txtTambahBarang.TabIndex = 7;
            // 
            // lblGambar
            // 
            this.lblGambar.AutoSize = true;
            this.lblGambar.Location = new System.Drawing.Point(60, 255);
            this.lblGambar.Name = "lblGambar";
            this.lblGambar.Size = new System.Drawing.Size(89, 15);
            this.lblGambar.TabIndex = 8;
            this.lblGambar.Text = "Gambar Barang";
            this.lblGambar.Click += new System.EventHandler(this.lblGambar_Click);
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(355, 101);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(39, 15);
            this.lblHarga.TabIndex = 9;
            this.lblHarga.Text = "Harga";
            this.lblHarga.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbHarga
            // 
            this.cmbHarga.FormattingEnabled = true;
            this.cmbHarga.Items.AddRange(new object[] {
            "125.000",
            "150.000",
            "170.000"});
            this.cmbHarga.Location = new System.Drawing.Point(428, 98);
            this.cmbHarga.Name = "cmbHarga";
            this.cmbHarga.Size = new System.Drawing.Size(121, 23);
            this.cmbHarga.TabIndex = 10;
            this.cmbHarga.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(355, 150);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 15);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total Harga";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(347, 199);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 13;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnBeli
            // 
            this.btnBeli.Location = new System.Drawing.Point(337, 408);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(75, 23);
            this.btnBeli.TabIndex = 14;
            this.btnBeli.Text = "Beli";
            this.btnBeli.UseVisualStyleBackColor = true;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // btnBayar
            // 
            this.btnBayar.Location = new System.Drawing.Point(337, 461);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(75, 23);
            this.btnBayar.TabIndex = 15;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(337, 517);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(428, 200);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // picSepatu
            // 
            this.picSepatu.Image = global::Kasir.Properties.Resources.sepatu;
            this.picSepatu.Location = new System.Drawing.Point(161, 255);
            this.picSepatu.Name = "picSepatu";
            this.picSepatu.Size = new System.Drawing.Size(127, 128);
            this.picSepatu.TabIndex = 19;
            this.picSepatu.TabStop = false;
            this.picSepatu.Visible = false;
            this.picSepatu.Click += new System.EventHandler(this.picSepatu_Click);
            // 
            // picBaju
            // 
            this.picBaju.Image = global::Kasir.Properties.Resources.baju;
            this.picBaju.Location = new System.Drawing.Point(161, 255);
            this.picBaju.Name = "picBaju";
            this.picBaju.Size = new System.Drawing.Size(127, 128);
            this.picBaju.TabIndex = 20;
            this.picBaju.TabStop = false;
            this.picBaju.Visible = false;
            this.picBaju.Click += new System.EventHandler(this.picBaju_Click);
            // 
            // picTas
            // 
            this.picTas.Image = global::Kasir.Properties.Resources.tas;
            this.picTas.Location = new System.Drawing.Point(161, 255);
            this.picTas.Name = "picTas";
            this.picTas.Size = new System.Drawing.Size(127, 120);
            this.picTas.TabIndex = 21;
            this.picTas.TabStop = false;
            this.picTas.Visible = false;
            // 
            // txtTotalHarga
            // 
            this.txtTotalHarga.Location = new System.Drawing.Point(428, 145);
            this.txtTotalHarga.Name = "txtTotalHarga";
            this.txtTotalHarga.Size = new System.Drawing.Size(120, 23);
            this.txtTotalHarga.TabIndex = 22;
            // 
            // picTasbih
            // 
            this.picTasbih.Image = global::Kasir.Properties.Resources.tasbih;
            this.picTasbih.Location = new System.Drawing.Point(161, 255);
            this.picTasbih.Name = "picTasbih";
            this.picTasbih.Size = new System.Drawing.Size(126, 128);
            this.picTasbih.TabIndex = 23;
            this.picTasbih.TabStop = false;
            this.picTasbih.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 615);
            this.Controls.Add(this.picTasbih);
            this.Controls.Add(this.txtTotalHarga);
            this.Controls.Add(this.picTas);
            this.Controls.Add(this.picBaju);
            this.Controls.Add(this.picSepatu);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cmbHarga);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblGambar);
            this.Controls.Add(this.txtTambahBarang);
            this.Controls.Add(this.lblTambahB);
            this.Controls.Add(this.lblSebanyak);
            this.Controls.Add(this.cmbBarang);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numSebanyak);
            this.Controls.Add(this.lblBarang);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSebanyak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSepatu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBaju)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTasbih)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBarang;
        private System.Windows.Forms.NumericUpDown numSebanyak;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbBarang;
        private System.Windows.Forms.Label lblSebanyak;
        private System.Windows.Forms.Label lblTambahB;
        private System.Windows.Forms.TextBox txtTambahBarang;
        private System.Windows.Forms.Label lblGambar;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.ComboBox cmbHarga;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox picSepatu;
        private System.Windows.Forms.PictureBox picBaju;
        private System.Windows.Forms.PictureBox picTas;
        private System.Windows.Forms.TextBox txtTotalHarga;
        private System.Windows.Forms.PictureBox picTasbih;
    }
}

