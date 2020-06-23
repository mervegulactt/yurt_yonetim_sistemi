namespace YurtYonetimSistemi
{
    partial class frmAlacaklar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlacaklar));
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTarih = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGVeri = new System.Windows.Forms.DataGridView();
            this.datagYapilmis = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnAnaForm = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnPdfAktar = new System.Windows.Forms.Button();
            this.pbOgrenci = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTarih.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagYapilmis)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOgrenci)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtBitis
            // 
            this.dtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBitis.Location = new System.Drawing.Point(8, 90);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(263, 22);
            this.dtBitis.TabIndex = 4;
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaslangic.Location = new System.Drawing.Point(8, 38);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(263, 22);
            this.dtBaslangic.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Baslangıç Tarihi";
            // 
            // panelTarih
            // 
            this.panelTarih.Controls.Add(this.dtBitis);
            this.panelTarih.Controls.Add(this.dtBaslangic);
            this.panelTarih.Controls.Add(this.label2);
            this.panelTarih.Controls.Add(this.label1);
            this.panelTarih.Location = new System.Drawing.Point(10, 45);
            this.panelTarih.Name = "panelTarih";
            this.panelTarih.Size = new System.Drawing.Size(284, 121);
            this.panelTarih.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGVeri);
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 629);
            this.panel1.TabIndex = 42;
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
            // datagYapilmis
            // 
            this.datagYapilmis.AllowUserToDeleteRows = false;
            this.datagYapilmis.BackgroundColor = System.Drawing.Color.White;
            this.datagYapilmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagYapilmis.Location = new System.Drawing.Point(1353, 208);
            this.datagYapilmis.Name = "datagYapilmis";
            this.datagYapilmis.ReadOnly = true;
            this.datagYapilmis.RowHeadersVisible = false;
            this.datagYapilmis.RowHeadersWidth = 10;
            this.datagYapilmis.RowTemplate.Height = 24;
            this.datagYapilmis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagYapilmis.Size = new System.Drawing.Size(26, 22);
            this.datagYapilmis.TabIndex = 47;
            this.datagYapilmis.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelTarih);
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.btnYenile);
            this.groupBox1.Location = new System.Drawing.Point(950, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 303);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listeleme Seçenekleri";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(154, 172);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(127, 55);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(6, 172);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(127, 55);
            this.btnYenile.TabIndex = 7;
            this.btnYenile.Text = "Temizle";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
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
            this.ımageList1.Images.SetKeyName(6, "back.png");
            this.ımageList1.Images.SetKeyName(7, "pdf.png");
            // 
            // btnGeri
            // 
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGeri.ImageIndex = 6;
            this.btnGeri.ImageList = this.ımageList1;
            this.btnGeri.Location = new System.Drawing.Point(12, 7);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(150, 75);
            this.btnGeri.TabIndex = 0;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnPdfAktar
            // 
            this.btnPdfAktar.FlatAppearance.BorderSize = 0;
            this.btnPdfAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPdfAktar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPdfAktar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPdfAktar.ImageIndex = 7;
            this.btnPdfAktar.ImageList = this.ımageList1;
            this.btnPdfAktar.Location = new System.Drawing.Point(678, 7);
            this.btnPdfAktar.Name = "btnPdfAktar";
            this.btnPdfAktar.Size = new System.Drawing.Size(266, 75);
            this.btnPdfAktar.TabIndex = 39;
            this.btnPdfAktar.Text = "Pdf\'e Aktar";
            this.btnPdfAktar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPdfAktar.UseVisualStyleBackColor = true;
            this.btnPdfAktar.Click += new System.EventHandler(this.btnPdfAktar_Click);
            // 
            // pbOgrenci
            // 
            this.pbOgrenci.Location = new System.Drawing.Point(1008, 106);
            this.pbOgrenci.Name = "pbOgrenci";
            this.pbOgrenci.Size = new System.Drawing.Size(195, 168);
            this.pbOgrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOgrenci.TabIndex = 45;
            this.pbOgrenci.TabStop = false;
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
            this.panel2.TabIndex = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1446, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(22, 22);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.Visible = false;
            // 
            // frmAlacaklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.datagYapilmis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbOgrenci);
            this.Controls.Add(this.panel2);
            this.Name = "frmAlacaklar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlacaklar";
            this.Load += new System.EventHandler(this.frmAlacaklar_Load);
            this.panelTarih.ResumeLayout(false);
            this.panelTarih.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagYapilmis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOgrenci)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnAnaForm;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnPdfAktar;
        private System.Windows.Forms.PictureBox pbOgrenci;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGVeri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView datagYapilmis;
    }
}