namespace sql_HomeWork
{
    partial class FrmUrunler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstKategori = new System.Windows.Forms.ListBox();
            this.lstTedarikci = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.btnUrunlerKaydet = new System.Windows.Forms.Button();
            this.btnUrunlerGuncelle = new System.Windows.Forms.Button();
            this.btnUrunlerSil = new System.Windows.Forms.Button();
            this.btnUrunlerTemizle = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.cmbDiscounted = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tedarikçi Seç";
            // 
            // lstKategori
            // 
            this.lstKategori.FormattingEnabled = true;
            this.lstKategori.ItemHeight = 37;
            this.lstKategori.Location = new System.Drawing.Point(2, 70);
            this.lstKategori.Name = "lstKategori";
            this.lstKategori.Size = new System.Drawing.Size(205, 411);
            this.lstKategori.TabIndex = 2;
            this.lstKategori.SelectedIndexChanged += new System.EventHandler(this.lstKategori_SelectedIndexChanged);
            // 
            // lstTedarikci
            // 
            this.lstTedarikci.FormattingEnabled = true;
            this.lstTedarikci.ItemHeight = 37;
            this.lstTedarikci.Location = new System.Drawing.Point(252, 70);
            this.lstTedarikci.Name = "lstTedarikci";
            this.lstTedarikci.Size = new System.Drawing.Size(213, 411);
            this.lstTedarikci.TabIndex = 3;
            this.lstTedarikci.SelectedIndexChanged += new System.EventHandler(this.lstTedarikci_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(514, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(518, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Unit on order";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(518, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "Reorder level";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(518, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 31);
            this.label8.TabIndex = 9;
            this.label8.Text = "Unit Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(514, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 31);
            this.label9.TabIndex = 10;
            this.label9.Text = "Quantity per. unit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(514, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 31);
            this.label10.TabIndex = 11;
            this.label10.Text = "Unit in Stock";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(514, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 31);
            this.label11.TabIndex = 12;
            this.label11.Text = "Discounted";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(986, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 38);
            this.label12.TabIndex = 13;
            this.label12.Text = "Ürünler";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUrunAdi.Location = new System.Drawing.Point(720, 70);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(163, 34);
            this.txtUrunAdi.TabIndex = 14;
            // 
            // txtLevel
            // 
            this.txtLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLevel.Location = new System.Drawing.Point(720, 325);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(163, 34);
            this.txtLevel.TabIndex = 15;
            // 
            // txtOrder
            // 
            this.txtOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrder.Location = new System.Drawing.Point(720, 273);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(163, 34);
            this.txtOrder.TabIndex = 16;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStock.Location = new System.Drawing.Point(720, 221);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(163, 34);
            this.txtStock.TabIndex = 17;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(720, 166);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(163, 34);
            this.txtPrice.TabIndex = 18;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.Location = new System.Drawing.Point(720, 117);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(163, 34);
            this.txtQuantity.TabIndex = 19;
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 37;
            this.lstUrunler.Location = new System.Drawing.Point(935, 72);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(231, 411);
            this.lstUrunler.TabIndex = 21;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // btnUrunlerKaydet
            // 
            this.btnUrunlerKaydet.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUrunlerKaydet.Location = new System.Drawing.Point(514, 439);
            this.btnUrunlerKaydet.Name = "btnUrunlerKaydet";
            this.btnUrunlerKaydet.Size = new System.Drawing.Size(130, 42);
            this.btnUrunlerKaydet.TabIndex = 22;
            this.btnUrunlerKaydet.Text = "Kaydet";
            this.btnUrunlerKaydet.UseVisualStyleBackColor = true;
            this.btnUrunlerKaydet.Click += new System.EventHandler(this.btnUrunlerKaydet_Click);
            // 
            // btnUrunlerGuncelle
            // 
            this.btnUrunlerGuncelle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUrunlerGuncelle.Location = new System.Drawing.Point(650, 439);
            this.btnUrunlerGuncelle.Name = "btnUrunlerGuncelle";
            this.btnUrunlerGuncelle.Size = new System.Drawing.Size(130, 42);
            this.btnUrunlerGuncelle.TabIndex = 23;
            this.btnUrunlerGuncelle.Text = "Güncelle";
            this.btnUrunlerGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunlerGuncelle.Click += new System.EventHandler(this.btnUrunlerGuncelle_Click);
            // 
            // btnUrunlerSil
            // 
            this.btnUrunlerSil.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUrunlerSil.Location = new System.Drawing.Point(786, 439);
            this.btnUrunlerSil.Name = "btnUrunlerSil";
            this.btnUrunlerSil.Size = new System.Drawing.Size(130, 42);
            this.btnUrunlerSil.TabIndex = 24;
            this.btnUrunlerSil.Text = "Sil";
            this.btnUrunlerSil.UseVisualStyleBackColor = true;
            this.btnUrunlerSil.Click += new System.EventHandler(this.btnUrunlerSil_Click);
            // 
            // btnUrunlerTemizle
            // 
            this.btnUrunlerTemizle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUrunlerTemizle.Location = new System.Drawing.Point(650, 523);
            this.btnUrunlerTemizle.Name = "btnUrunlerTemizle";
            this.btnUrunlerTemizle.Size = new System.Drawing.Size(130, 36);
            this.btnUrunlerTemizle.TabIndex = 25;
            this.btnUrunlerTemizle.Text = "Temizle";
            this.btnUrunlerTemizle.UseVisualStyleBackColor = true;
            this.btnUrunlerTemizle.Click += new System.EventHandler(this.btnUrunlerTemizle_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(935, 523);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(231, 43);
            this.txtAra.TabIndex = 26;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // cmbDiscounted
            // 
            this.cmbDiscounted.FormattingEnabled = true;
            this.cmbDiscounted.Location = new System.Drawing.Point(720, 372);
            this.cmbDiscounted.Name = "cmbDiscounted";
            this.cmbDiscounted.Size = new System.Drawing.Size(163, 45);
            this.cmbDiscounted.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(870, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 38);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ara";
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 644);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDiscounted);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnUrunlerTemizle);
            this.Controls.Add(this.btnUrunlerSil);
            this.Controls.Add(this.btnUrunlerGuncelle);
            this.Controls.Add(this.btnUrunlerKaydet);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstTedarikci);
            this.Controls.Add(this.lstKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmUrunler";
            this.Text = "FrmUrunler";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstKategori;
        private System.Windows.Forms.ListBox lstTedarikci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Button btnUrunlerKaydet;
        private System.Windows.Forms.Button btnUrunlerGuncelle;
        private System.Windows.Forms.Button btnUrunlerSil;
        private System.Windows.Forms.Button btnUrunlerTemizle;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ComboBox cmbDiscounted;
        private System.Windows.Forms.Label label4;
    }
}