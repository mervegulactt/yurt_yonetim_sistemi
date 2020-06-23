namespace YurtYonetimSistemi
{
    partial class frmOgrenciYatir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenciYatir));
            this.pbOgrenci = new System.Windows.Forms.PictureBox();
            this.btnAnaForm = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPdfAktar = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dataGVeri = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbOgretimTuru = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbOgrenci)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbOgrenci
            // 
            this.pbOgrenci.Location = new System.Drawing.Point(1008, 106);
            this.pbOgrenci.Name = "pbOgrenci";
            this.pbOgrenci.Size = new System.Drawing.Size(195, 168);
            this.pbOgrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOgrenci.TabIndex = 37;
            this.pbOgrenci.TabStop = false;
            // 
            // btnAnaForm
            // 
            this.btnAnaForm.FlatAppearance.BorderSize = 0;
            this.btnAnaForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnaForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnaForm.ImageIndex = 1;
            this.btnAnaForm.ImageList = this.ımageList1;
            this.btnAnaForm.Location = new System.Drawing.Point(1109, 10);
            this.btnAnaForm.Name = "btnAnaForm";
            this.btnAnaForm.Size = new System.Drawing.Size(150, 75);
            this.btnAnaForm.TabIndex = 0;
            this.btnAnaForm.Text = "Ana Ekran";
            this.btnAnaForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnaForm.UseVisualStyleBackColor = true;
            this.btnAnaForm.Click += new System.EventHandler(this.btnAnaForm_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "yeniogrenci.png");
            this.ımageList1.Images.SetKeyName(1, "anaformadon.png");
            this.ımageList1.Images.SetKeyName(2, "kaydet.png");
            this.ımageList1.Images.SetKeyName(3, "back.png");
            this.ımageList1.Images.SetKeyName(4, "pdf.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnPdfAktar);
            this.panel2.Controls.Add(this.btnAnaForm);
            this.panel2.Controls.Add(this.btnGeri);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 88);
            this.panel2.TabIndex = 36;
            // 
            // btnPdfAktar
            // 
            this.btnPdfAktar.FlatAppearance.BorderSize = 0;
            this.btnPdfAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPdfAktar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPdfAktar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPdfAktar.ImageIndex = 4;
            this.btnPdfAktar.ImageList = this.ımageList1;
            this.btnPdfAktar.Location = new System.Drawing.Point(678, 3);
            this.btnPdfAktar.Name = "btnPdfAktar";
            this.btnPdfAktar.Size = new System.Drawing.Size(266, 75);
            this.btnPdfAktar.TabIndex = 40;
            this.btnPdfAktar.Text = "Pdf\'e Aktar";
            this.btnPdfAktar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPdfAktar.UseVisualStyleBackColor = true;
            this.btnPdfAktar.Click += new System.EventHandler(this.btnPdfAktar_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGeri.ImageIndex = 3;
            this.btnGeri.ImageList = this.ımageList1;
            this.btnGeri.Location = new System.Drawing.Point(12, 10);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(150, 75);
            this.btnGeri.TabIndex = 0;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dataGVeri
            // 
            this.dataGVeri.AllowUserToDeleteRows = false;
            this.dataGVeri.BackgroundColor = System.Drawing.Color.White;
            this.dataGVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVeri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVeri.Location = new System.Drawing.Point(0, 0);
            this.dataGVeri.Name = "dataGVeri";
            this.dataGVeri.ReadOnly = true;
            this.dataGVeri.RowHeadersVisible = false;
            this.dataGVeri.RowHeadersWidth = 10;
            this.dataGVeri.RowTemplate.Height = 24;
            this.dataGVeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVeri.Size = new System.Drawing.Size(944, 546);
            this.dataGVeri.TabIndex = 2;
            this.dataGVeri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVeri_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGVeri);
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 546);
            this.panel1.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.btnKaydet);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 633);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1262, 88);
            this.panel3.TabIndex = 38;
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.ImageIndex = 2;
            this.btnKaydet.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(794, 7);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 75);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.btnYenile);
            this.groupBox1.Location = new System.Drawing.Point(962, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 340);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listeleme Seçenekleri";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbOgretimTuru);
            this.groupBox4.Location = new System.Drawing.Point(22, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 72);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Öğretim Türü";
            // 
            // cbOgretimTuru
            // 
            this.cbOgretimTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOgretimTuru.FormattingEnabled = true;
            this.cbOgretimTuru.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbOgretimTuru.Location = new System.Drawing.Point(6, 30);
            this.cbOgretimTuru.Name = "cbOgretimTuru";
            this.cbOgretimTuru.Size = new System.Drawing.Size(260, 24);
            this.cbOgretimTuru.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtSoyadi);
            this.groupBox5.Location = new System.Drawing.Point(161, 35);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(133, 72);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Soyad";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(6, 28);
            this.txtSoyadi.Multiline = true;
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(121, 30);
            this.txtSoyadi.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdi);
            this.groupBox2.Location = new System.Drawing.Point(22, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 72);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ad";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(6, 28);
            this.txtAdi.Multiline = true;
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(121, 30);
            this.txtAdi.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(155, 191);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(127, 55);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(22, 191);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(127, 55);
            this.btnYenile.TabIndex = 7;
            this.btnYenile.Text = "Temizle";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // frmOgrenciYatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pbOgrenci);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmOgrenciYatir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Yatır";
            this.Load += new System.EventHandler(this.frmOgrenciYatir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOgrenci)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOgrenci;
        private System.Windows.Forms.Button btnAnaForm;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dataGVeri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnPdfAktar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbOgretimTuru;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnYenile;
    }
}