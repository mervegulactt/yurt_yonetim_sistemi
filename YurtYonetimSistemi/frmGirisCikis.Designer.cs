namespace YurtYonetimSistemi
{
    partial class frmGirisCikis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGirisCikis));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPdfAktar = new System.Windows.Forms.Button();
            this.btnAnaForm = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.datagGirisCikis = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.datagOgrenci = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTarihSaat = new System.Windows.Forms.Label();
            this.btnKaydetGiris = new System.Windows.Forms.Button();
            this.btnKaydetCikis = new System.Windows.Forms.Button();
            this.pbOgrenci = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagGirisCikis)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagOgrenci)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOgrenci)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "anaformadon.png");
            this.ımageList1.Images.SetKeyName(1, "cikis.png");
            this.ımageList1.Images.SetKeyName(2, "giris.png");
            this.ımageList1.Images.SetKeyName(3, "pdf.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnPdfAktar);
            this.panel2.Controls.Add(this.btnAnaForm);
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
            this.btnPdfAktar.ImageIndex = 3;
            this.btnPdfAktar.ImageList = this.ımageList1;
            this.btnPdfAktar.Location = new System.Drawing.Point(681, 7);
            this.btnPdfAktar.Name = "btnPdfAktar";
            this.btnPdfAktar.Size = new System.Drawing.Size(266, 75);
            this.btnPdfAktar.TabIndex = 41;
            this.btnPdfAktar.Text = "Pdf\'e Aktar";
            this.btnPdfAktar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPdfAktar.UseVisualStyleBackColor = true;
            this.btnPdfAktar.Click += new System.EventHandler(this.btnPdfAktar_Click);
            // 
            // btnAnaForm
            // 
            this.btnAnaForm.FlatAppearance.BorderSize = 0;
            this.btnAnaForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnaForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnaForm.ImageIndex = 0;
            this.btnAnaForm.ImageList = this.ımageList1;
            this.btnAnaForm.Location = new System.Drawing.Point(1106, 7);
            this.btnAnaForm.Name = "btnAnaForm";
            this.btnAnaForm.Size = new System.Drawing.Size(150, 75);
            this.btnAnaForm.TabIndex = 1;
            this.btnAnaForm.Text = "Ana Ekran";
            this.btnAnaForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnaForm.UseVisualStyleBackColor = true;
            this.btnAnaForm.Click += new System.EventHandler(this.btnAnaForm_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.datagGirisCikis);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox6.Location = new System.Drawing.Point(3, 401);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(944, 226);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Giriş Çıkışlar";
            // 
            // datagGirisCikis
            // 
            this.datagGirisCikis.AllowUserToDeleteRows = false;
            this.datagGirisCikis.BackgroundColor = System.Drawing.Color.White;
            this.datagGirisCikis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagGirisCikis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagGirisCikis.Location = new System.Drawing.Point(3, 18);
            this.datagGirisCikis.Name = "datagGirisCikis";
            this.datagGirisCikis.ReadOnly = true;
            this.datagGirisCikis.RowHeadersVisible = false;
            this.datagGirisCikis.RowHeadersWidth = 10;
            this.datagGirisCikis.RowTemplate.Height = 24;
            this.datagGirisCikis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagGirisCikis.Size = new System.Drawing.Size(938, 205);
            this.datagGirisCikis.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.datagOgrenci);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(0, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(944, 310);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğrenciler";
            // 
            // datagOgrenci
            // 
            this.datagOgrenci.AllowUserToDeleteRows = false;
            this.datagOgrenci.BackgroundColor = System.Drawing.Color.White;
            this.datagOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagOgrenci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagOgrenci.Location = new System.Drawing.Point(3, 18);
            this.datagOgrenci.Name = "datagOgrenci";
            this.datagOgrenci.ReadOnly = true;
            this.datagOgrenci.RowHeadersVisible = false;
            this.datagOgrenci.RowHeadersWidth = 10;
            this.datagOgrenci.RowTemplate.Height = 24;
            this.datagOgrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagOgrenci.Size = new System.Drawing.Size(938, 289);
            this.datagOgrenci.TabIndex = 3;
            this.datagOgrenci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagOgrenci_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblAdSoyad);
            this.panel1.Controls.Add(this.lblTarihSaat);
            this.panel1.Controls.Add(this.btnKaydetGiris);
            this.panel1.Controls.Add(this.btnKaydetCikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 633);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 88);
            this.panel1.TabIndex = 42;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdSoyad.Location = new System.Drawing.Point(88, 40);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(48, 25);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "ada";
            // 
            // lblTarihSaat
            // 
            this.lblTarihSaat.AutoSize = true;
            this.lblTarihSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarihSaat.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTarihSaat.Location = new System.Drawing.Point(380, 40);
            this.lblTarihSaat.Name = "lblTarihSaat";
            this.lblTarihSaat.Size = new System.Drawing.Size(0, 25);
            this.lblTarihSaat.TabIndex = 1;
            // 
            // btnKaydetGiris
            // 
            this.btnKaydetGiris.FlatAppearance.BorderSize = 0;
            this.btnKaydetGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydetGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydetGiris.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKaydetGiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydetGiris.ImageIndex = 2;
            this.btnKaydetGiris.ImageList = this.ımageList1;
            this.btnKaydetGiris.Location = new System.Drawing.Point(618, 10);
            this.btnKaydetGiris.Name = "btnKaydetGiris";
            this.btnKaydetGiris.Size = new System.Drawing.Size(150, 75);
            this.btnKaydetGiris.TabIndex = 0;
            this.btnKaydetGiris.Text = "Giriş Yap";
            this.btnKaydetGiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydetGiris.UseVisualStyleBackColor = true;
            this.btnKaydetGiris.Click += new System.EventHandler(this.btnKaydetGiris_Click);
            // 
            // btnKaydetCikis
            // 
            this.btnKaydetCikis.FlatAppearance.BorderSize = 0;
            this.btnKaydetCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydetCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydetCikis.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKaydetCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydetCikis.ImageIndex = 1;
            this.btnKaydetCikis.ImageList = this.ımageList1;
            this.btnKaydetCikis.Location = new System.Drawing.Point(791, 10);
            this.btnKaydetCikis.Name = "btnKaydetCikis";
            this.btnKaydetCikis.Size = new System.Drawing.Size(150, 75);
            this.btnKaydetCikis.TabIndex = 0;
            this.btnKaydetCikis.Text = "Çıkış Yap";
            this.btnKaydetCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydetCikis.UseVisualStyleBackColor = true;
            this.btnKaydetCikis.Click += new System.EventHandler(this.btnKaydetCikis_Click);
            // 
            // pbOgrenci
            // 
            this.pbOgrenci.Location = new System.Drawing.Point(1009, 112);
            this.pbOgrenci.Name = "pbOgrenci";
            this.pbOgrenci.Size = new System.Drawing.Size(195, 168);
            this.pbOgrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOgrenci.TabIndex = 44;
            this.pbOgrenci.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.btnYenile);
            this.groupBox1.Location = new System.Drawing.Point(951, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 281);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listeleme Seçenekleri";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtSoyadi);
            this.groupBox5.Location = new System.Drawing.Point(22, 113);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 72);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Soyad";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(6, 28);
            this.txtSoyadi.Multiline = true;
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(260, 30);
            this.txtSoyadi.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtAdi);
            this.groupBox8.Location = new System.Drawing.Point(22, 35);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(272, 72);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Ad";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(6, 28);
            this.txtAdi.Multiline = true;
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(260, 30);
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
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmGirisCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.pbOgrenci);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Name = "frmGirisCikis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGirisCikis";
            this.Load += new System.EventHandler(this.frmGirisCikis_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagGirisCikis)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagOgrenci)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOgrenci)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView datagGirisCikis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView datagOgrenci;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKaydetCikis;
        private System.Windows.Forms.PictureBox pbOgrenci;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label lblTarihSaat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Button btnKaydetGiris;
        private System.Windows.Forms.Button btnAnaForm;
        private System.Windows.Forms.Button btnPdfAktar;
    }
}