namespace YurtYonetimSistemi
{
    partial class frmIzinTalep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzinTalep));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGeri = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnaForm = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSorumluTelefon = new System.Windows.Forms.TextBox();
            this.txtGidilenAdres = new System.Windows.Forms.TextBox();
            this.dtBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGVeri = new System.Windows.Forms.DataGridView();
            this.pbOgrenci = new System.Windows.Forms.PictureBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.ImageIndex = 4;
            this.btnKaydet.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(1100, 8);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 75);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "yeniogrenci.png");
            this.ımageList1.Images.SetKeyName(1, "guncelle.png");
            this.ımageList1.Images.SetKeyName(2, "aktifpasif.png");
            this.ımageList1.Images.SetKeyName(3, "anaformadon.png");
            this.ımageList1.Images.SetKeyName(4, "kaydet.png");
            this.ımageList1.Images.SetKeyName(5, "back.png");
            // 
            // btnGeri
            // 
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGeri.ImageIndex = 5;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnAnaForm);
            this.panel2.Controls.Add(this.btnGeri);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 88);
            this.panel2.TabIndex = 41;
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
            this.btnAnaForm.Location = new System.Drawing.Point(1100, 10);
            this.btnAnaForm.Name = "btnAnaForm";
            this.btnAnaForm.Size = new System.Drawing.Size(150, 75);
            this.btnAnaForm.TabIndex = 0;
            this.btnAnaForm.Text = "Ana Ekran";
            this.btnAnaForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnaForm.UseVisualStyleBackColor = true;
            this.btnAnaForm.Click += new System.EventHandler(this.btnAnaForm_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.btnKaydet);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 633);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1262, 88);
            this.panel3.TabIndex = 43;
            // 
            // dtBitisTarihi
            // 
            this.dtBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtBitisTarihi.Location = new System.Drawing.Point(584, 481);
            this.dtBitisTarihi.Name = "dtBitisTarihi";
            this.dtBitisTarihi.Size = new System.Drawing.Size(406, 30);
            this.dtBitisTarihi.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(425, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Gidilen Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(452, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Bitiş Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(398, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 25);
            this.label8.TabIndex = 48;
            this.label8.Text = "Sorumlu Telefon";
            // 
            // txtSorumluTelefon
            // 
            this.txtSorumluTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSorumluTelefon.Location = new System.Drawing.Point(584, 393);
            this.txtSorumluTelefon.Margin = new System.Windows.Forms.Padding(5);
            this.txtSorumluTelefon.Multiline = true;
            this.txtSorumluTelefon.Name = "txtSorumluTelefon";
            this.txtSorumluTelefon.Size = new System.Drawing.Size(406, 35);
            this.txtSorumluTelefon.TabIndex = 53;
            // 
            // txtGidilenAdres
            // 
            this.txtGidilenAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGidilenAdres.Location = new System.Drawing.Point(584, 164);
            this.txtGidilenAdres.Margin = new System.Windows.Forms.Padding(5);
            this.txtGidilenAdres.Multiline = true;
            this.txtGidilenAdres.Name = "txtGidilenAdres";
            this.txtGidilenAdres.Size = new System.Drawing.Size(406, 219);
            this.txtGidilenAdres.TabIndex = 52;
            // 
            // dtBaslangicTarihi
            // 
            this.dtBaslangicTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtBaslangicTarihi.Location = new System.Drawing.Point(584, 437);
            this.dtBaslangicTarihi.Name = "dtBaslangicTarihi";
            this.dtBaslangicTarihi.Size = new System.Drawing.Size(406, 30);
            this.dtBaslangicTarihi.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(403, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Başlanğıç Tarihi";
            // 
            // dataGVeri
            // 
            this.dataGVeri.AllowUserToDeleteRows = false;
            this.dataGVeri.BackgroundColor = System.Drawing.Color.White;
            this.dataGVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVeri.Location = new System.Drawing.Point(120, 481);
            this.dataGVeri.Name = "dataGVeri";
            this.dataGVeri.ReadOnly = true;
            this.dataGVeri.RowHeadersVisible = false;
            this.dataGVeri.RowHeadersWidth = 10;
            this.dataGVeri.RowTemplate.Height = 24;
            this.dataGVeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVeri.Size = new System.Drawing.Size(88, 70);
            this.dataGVeri.TabIndex = 61;
            this.dataGVeri.Visible = false;
            // 
            // pbOgrenci
            // 
            this.pbOgrenci.Location = new System.Drawing.Point(120, 147);
            this.pbOgrenci.Name = "pbOgrenci";
            this.pbOgrenci.Size = new System.Drawing.Size(195, 168);
            this.pbOgrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOgrenci.TabIndex = 60;
            this.pbOgrenci.TabStop = false;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAdSoyad.Location = new System.Drawing.Point(115, 339);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(48, 25);
            this.lblAdSoyad.TabIndex = 62;
            this.lblAdSoyad.Text = "ada";
            // 
            // frmIzinTalep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.dataGVeri);
            this.Controls.Add(this.pbOgrenci);
            this.Controls.Add(this.dtBaslangicTarihi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtBitisTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSorumluTelefon);
            this.Controls.Add(this.txtGidilenAdres);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "frmIzinTalep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin Talep";
            this.Load += new System.EventHandler(this.frmIzinTalep_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAnaForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtBitisTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSorumluTelefon;
        private System.Windows.Forms.TextBox txtGidilenAdres;
        private System.Windows.Forms.DateTimePicker dtBaslangicTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGVeri;
        private System.Windows.Forms.PictureBox pbOgrenci;
        private System.Windows.Forms.Label lblAdSoyad;
    }
}