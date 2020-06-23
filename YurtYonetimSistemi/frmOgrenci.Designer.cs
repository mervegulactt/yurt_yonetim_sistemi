namespace YurtYonetimSistemi
{
    partial class frmOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenci));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGVeri = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbOgretimTuru = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDurum = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnaForm = new System.Windows.Forms.Button();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.btnIzinTalep = new System.Windows.Forms.Button();
            this.btnAktifPasif = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnYeniOgrenci = new System.Windows.Forms.Button();
            this.pbOgrenci = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtYatak = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtOda = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOgrenci)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGVeri);
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 629);
            this.panel1.TabIndex = 24;
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
            this.dataGVeri.Size = new System.Drawing.Size(944, 629);
            this.dataGVeri.TabIndex = 2;
            this.dataGVeri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVeri_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.btnYenile);
            this.groupBox1.Location = new System.Drawing.Point(950, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 427);
            this.groupBox1.TabIndex = 30;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbDurum);
            this.groupBox3.Location = new System.Drawing.Point(22, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 72);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Durum";
            // 
            // cbDurum
            // 
            this.cbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDurum.FormattingEnabled = true;
            this.cbDurum.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cbDurum.Location = new System.Drawing.Point(6, 30);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(260, 24);
            this.cbDurum.TabIndex = 0;
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
            this.btnListele.Location = new System.Drawing.Point(167, 361);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(127, 55);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(28, 361);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(127, 55);
            this.btnYenile.TabIndex = 7;
            this.btnYenile.Text = "Temizle";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "yeniogrenci.png");
            this.ımageList1.Images.SetKeyName(1, "guncelle.png");
            this.ımageList1.Images.SetKeyName(2, "aktifpasif.png");
            this.ımageList1.Images.SetKeyName(3, "anaformadon.png");
            this.ımageList1.Images.SetKeyName(4, "odemeYap.png");
            this.ımageList1.Images.SetKeyName(5, "izinTalep.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnAnaForm);
            this.panel2.Controls.Add(this.btnOdemeYap);
            this.panel2.Controls.Add(this.btnIzinTalep);
            this.panel2.Controls.Add(this.btnAktifPasif);
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Controls.Add(this.btnYeniOgrenci);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 88);
            this.panel2.TabIndex = 32;
            // 
            // btnAnaForm
            // 
            this.btnAnaForm.FlatAppearance.BorderSize = 0;
            this.btnAnaForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnaForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnaForm.ImageIndex = 3;
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
            // btnOdemeYap
            // 
            this.btnOdemeYap.FlatAppearance.BorderSize = 0;
            this.btnOdemeYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdemeYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeYap.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOdemeYap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOdemeYap.ImageIndex = 4;
            this.btnOdemeYap.ImageList = this.ımageList1;
            this.btnOdemeYap.Location = new System.Drawing.Point(324, 7);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(150, 75);
            this.btnOdemeYap.TabIndex = 0;
            this.btnOdemeYap.Text = "Ödeme Yap";
            this.btnOdemeYap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // btnIzinTalep
            // 
            this.btnIzinTalep.FlatAppearance.BorderSize = 0;
            this.btnIzinTalep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzinTalep.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzinTalep.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIzinTalep.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIzinTalep.ImageIndex = 5;
            this.btnIzinTalep.ImageList = this.ımageList1;
            this.btnIzinTalep.Location = new System.Drawing.Point(467, 7);
            this.btnIzinTalep.Name = "btnIzinTalep";
            this.btnIzinTalep.Size = new System.Drawing.Size(150, 75);
            this.btnIzinTalep.TabIndex = 0;
            this.btnIzinTalep.Text = "İzin Talep";
            this.btnIzinTalep.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIzinTalep.UseVisualStyleBackColor = true;
            this.btnIzinTalep.Click += new System.EventHandler(this.btnIzinTalep_Click);
            // 
            // btnAktifPasif
            // 
            this.btnAktifPasif.FlatAppearance.BorderSize = 0;
            this.btnAktifPasif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktifPasif.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktifPasif.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAktifPasif.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAktifPasif.ImageIndex = 2;
            this.btnAktifPasif.ImageList = this.ımageList1;
            this.btnAktifPasif.Location = new System.Drawing.Point(623, 7);
            this.btnAktifPasif.Name = "btnAktifPasif";
            this.btnAktifPasif.Size = new System.Drawing.Size(150, 75);
            this.btnAktifPasif.TabIndex = 0;
            this.btnAktifPasif.Text = "Aktif-Pasif";
            this.btnAktifPasif.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAktifPasif.UseVisualStyleBackColor = true;
            this.btnAktifPasif.Click += new System.EventHandler(this.btnAktifPasif_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.ImageIndex = 1;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(168, 7);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(150, 75);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnYeniOgrenci
            // 
            this.btnYeniOgrenci.FlatAppearance.BorderSize = 0;
            this.btnYeniOgrenci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOgrenci.ForeColor = System.Drawing.SystemColors.Control;
            this.btnYeniOgrenci.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYeniOgrenci.ImageIndex = 0;
            this.btnYeniOgrenci.ImageList = this.ımageList1;
            this.btnYeniOgrenci.Location = new System.Drawing.Point(12, 7);
            this.btnYeniOgrenci.Name = "btnYeniOgrenci";
            this.btnYeniOgrenci.Size = new System.Drawing.Size(150, 75);
            this.btnYeniOgrenci.TabIndex = 0;
            this.btnYeniOgrenci.Text = "Yeni Öğrenci";
            this.btnYeniOgrenci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeniOgrenci.UseVisualStyleBackColor = true;
            this.btnYeniOgrenci.Click += new System.EventHandler(this.btnYeniOgrenci_Click);
            // 
            // pbOgrenci
            // 
            this.pbOgrenci.Location = new System.Drawing.Point(1008, 106);
            this.pbOgrenci.Name = "pbOgrenci";
            this.pbOgrenci.Size = new System.Drawing.Size(195, 168);
            this.pbOgrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOgrenci.TabIndex = 33;
            this.pbOgrenci.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtYatak);
            this.groupBox6.Location = new System.Drawing.Point(161, 269);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(133, 72);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Yatak";
            // 
            // txtYatak
            // 
            this.txtYatak.Location = new System.Drawing.Point(6, 28);
            this.txtYatak.Multiline = true;
            this.txtYatak.Name = "txtYatak";
            this.txtYatak.Size = new System.Drawing.Size(121, 30);
            this.txtYatak.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtOda);
            this.groupBox7.Location = new System.Drawing.Point(22, 269);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(133, 72);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Oda";
            // 
            // txtOda
            // 
            this.txtOda.Location = new System.Drawing.Point(6, 28);
            this.txtOda.Multiline = true;
            this.txtOda.Name = "txtOda";
            this.txtOda.Size = new System.Drawing.Size(121, 30);
            this.txtOda.TabIndex = 0;
            // 
            // frmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.pbOgrenci);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci İşlemleri";
            this.Load += new System.EventHandler(this.frmOgrenci_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOgrenci)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGVeri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbDurum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAktifPasif;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnYeniOgrenci;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbOgretimTuru;
        private System.Windows.Forms.Button btnAnaForm;
        private System.Windows.Forms.PictureBox pbOgrenci;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Button btnIzinTalep;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtYatak;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtOda;
    }
}