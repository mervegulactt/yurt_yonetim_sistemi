namespace YurtYonetimSistemi
{
    partial class frmOda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOda));
            this.btnAnaForm = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtOdaKat = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOdaListele = new System.Windows.Forms.Button();
            this.btnYatakYenile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOdaYenile = new System.Windows.Forms.Button();
            this.btnYeniOda = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtYatakOda = new System.Windows.Forms.TextBox();
            this.btnYatakListele = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnOgrenciYatır = new System.Windows.Forms.Button();
            this.btnYatakHareket = new System.Windows.Forms.Button();
            this.btnYeniYatak = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.datagOda = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.datagYatak = new System.Windows.Forms.DataGridView();
            this.dt = new System.Windows.Forms.DataGridView();
            this.btnPdfAktar = new System.Windows.Forms.Button();
            this.datagBosYatak = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagOda)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagYatak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagBosYatak)).BeginInit();
            this.SuspendLayout();
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
            this.ımageList1.Images.SetKeyName(4, "liste.png");
            this.ımageList1.Images.SetKeyName(5, "bed.png");
            this.ımageList1.Images.SetKeyName(6, "ogrenciyatir.png");
            this.ımageList1.Images.SetKeyName(7, "pdf.png");
            // 
            // txtOdaKat
            // 
            this.txtOdaKat.Location = new System.Drawing.Point(6, 28);
            this.txtOdaKat.Multiline = true;
            this.txtOdaKat.Name = "txtOdaKat";
            this.txtOdaKat.Size = new System.Drawing.Size(260, 30);
            this.txtOdaKat.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOdaKat);
            this.groupBox2.Location = new System.Drawing.Point(22, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 72);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kat";
            // 
            // btnOdaListele
            // 
            this.btnOdaListele.Location = new System.Drawing.Point(155, 180);
            this.btnOdaListele.Name = "btnOdaListele";
            this.btnOdaListele.Size = new System.Drawing.Size(127, 55);
            this.btnOdaListele.TabIndex = 7;
            this.btnOdaListele.Text = "Listele";
            this.btnOdaListele.UseVisualStyleBackColor = true;
            this.btnOdaListele.Click += new System.EventHandler(this.btnOdaListele_Click);
            // 
            // btnYatakYenile
            // 
            this.btnYatakYenile.Location = new System.Drawing.Point(22, 196);
            this.btnYatakYenile.Name = "btnYatakYenile";
            this.btnYatakYenile.Size = new System.Drawing.Size(127, 55);
            this.btnYatakYenile.TabIndex = 7;
            this.btnYatakYenile.Text = "Yenile";
            this.btnYatakYenile.UseVisualStyleBackColor = true;
            this.btnYatakYenile.Click += new System.EventHandler(this.btnYatakYenile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnOdaListele);
            this.groupBox1.Controls.Add(this.btnOdaYenile);
            this.groupBox1.Location = new System.Drawing.Point(947, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 260);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oda Listeleme Seçenekleri";
            // 
            // btnOdaYenile
            // 
            this.btnOdaYenile.Location = new System.Drawing.Point(22, 180);
            this.btnOdaYenile.Name = "btnOdaYenile";
            this.btnOdaYenile.Size = new System.Drawing.Size(127, 55);
            this.btnOdaYenile.TabIndex = 7;
            this.btnOdaYenile.Text = "Yenile";
            this.btnOdaYenile.UseVisualStyleBackColor = true;
            this.btnOdaYenile.Click += new System.EventHandler(this.btnOdaYenile_Click);
            // 
            // btnYeniOda
            // 
            this.btnYeniOda.FlatAppearance.BorderSize = 0;
            this.btnYeniOda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniOda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnYeniOda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYeniOda.ImageIndex = 0;
            this.btnYeniOda.ImageList = this.ımageList1;
            this.btnYeniOda.Location = new System.Drawing.Point(12, 10);
            this.btnYeniOda.Name = "btnYeniOda";
            this.btnYeniOda.Size = new System.Drawing.Size(150, 75);
            this.btnYeniOda.TabIndex = 0;
            this.btnYeniOda.Text = "Yeni Oda";
            this.btnYeniOda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeniOda.UseVisualStyleBackColor = true;
            this.btnYeniOda.Click += new System.EventHandler(this.btnYeniOda_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnAnaForm);
            this.panel2.Controls.Add(this.btnYeniOda);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 88);
            this.panel2.TabIndex = 36;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.btnYatakListele);
            this.groupBox3.Controls.Add(this.btnYatakYenile);
            this.groupBox3.Location = new System.Drawing.Point(950, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 267);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yatak Listeleme Seçenekleri";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtYatakOda);
            this.groupBox7.Location = new System.Drawing.Point(25, 58);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(266, 72);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Oda";
            // 
            // txtYatakOda
            // 
            this.txtYatakOda.Location = new System.Drawing.Point(6, 28);
            this.txtYatakOda.Multiline = true;
            this.txtYatakOda.Name = "txtYatakOda";
            this.txtYatakOda.Size = new System.Drawing.Size(248, 30);
            this.txtYatakOda.TabIndex = 0;
            // 
            // btnYatakListele
            // 
            this.btnYatakListele.Location = new System.Drawing.Point(155, 196);
            this.btnYatakListele.Name = "btnYatakListele";
            this.btnYatakListele.Size = new System.Drawing.Size(127, 55);
            this.btnYatakListele.TabIndex = 7;
            this.btnYatakListele.Text = "Listele";
            this.btnYatakListele.UseVisualStyleBackColor = true;
            this.btnYatakListele.Click += new System.EventHandler(this.btnYatakListele_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.btnOgrenciYatır);
            this.panel4.Controls.Add(this.btnPdfAktar);
            this.panel4.Controls.Add(this.btnYatakHareket);
            this.panel4.Controls.Add(this.btnYeniYatak);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 633);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1262, 88);
            this.panel4.TabIndex = 37;
            // 
            // btnOgrenciYatır
            // 
            this.btnOgrenciYatır.FlatAppearance.BorderSize = 0;
            this.btnOgrenciYatır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciYatır.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciYatır.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOgrenciYatır.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOgrenciYatır.ImageIndex = 6;
            this.btnOgrenciYatır.ImageList = this.ımageList1;
            this.btnOgrenciYatır.Location = new System.Drawing.Point(168, 10);
            this.btnOgrenciYatır.Name = "btnOgrenciYatır";
            this.btnOgrenciYatır.Size = new System.Drawing.Size(150, 75);
            this.btnOgrenciYatır.TabIndex = 0;
            this.btnOgrenciYatır.Text = "Öğrenci Yatır";
            this.btnOgrenciYatır.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOgrenciYatır.UseVisualStyleBackColor = true;
            this.btnOgrenciYatır.Click += new System.EventHandler(this.btnOgrenciYatır_Click);
            // 
            // btnYatakHareket
            // 
            this.btnYatakHareket.FlatAppearance.BorderSize = 0;
            this.btnYatakHareket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYatakHareket.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYatakHareket.ForeColor = System.Drawing.SystemColors.Control;
            this.btnYatakHareket.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYatakHareket.ImageIndex = 4;
            this.btnYatakHareket.ImageList = this.ımageList1;
            this.btnYatakHareket.Location = new System.Drawing.Point(324, 10);
            this.btnYatakHareket.Name = "btnYatakHareket";
            this.btnYatakHareket.Size = new System.Drawing.Size(150, 75);
            this.btnYatakHareket.TabIndex = 0;
            this.btnYatakHareket.Text = "Yatak Hareket";
            this.btnYatakHareket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYatakHareket.UseVisualStyleBackColor = true;
            this.btnYatakHareket.Click += new System.EventHandler(this.btnYatakHareket_Click);
            // 
            // btnYeniYatak
            // 
            this.btnYeniYatak.FlatAppearance.BorderSize = 0;
            this.btnYeniYatak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniYatak.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniYatak.ForeColor = System.Drawing.SystemColors.Control;
            this.btnYeniYatak.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYeniYatak.ImageKey = "bed.png";
            this.btnYeniYatak.ImageList = this.ımageList1;
            this.btnYeniYatak.Location = new System.Drawing.Point(12, 10);
            this.btnYeniYatak.Name = "btnYeniYatak";
            this.btnYeniYatak.Size = new System.Drawing.Size(150, 75);
            this.btnYeniYatak.TabIndex = 0;
            this.btnYeniYatak.Text = "Yeni Yatak";
            this.btnYeniYatak.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeniYatak.UseVisualStyleBackColor = true;
            this.btnYeniYatak.Click += new System.EventHandler(this.btnYeniYatak_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.datagOda);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox5.Location = new System.Drawing.Point(0, 94);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(944, 265);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Odalar";
            // 
            // datagOda
            // 
            this.datagOda.AllowUserToDeleteRows = false;
            this.datagOda.BackgroundColor = System.Drawing.Color.White;
            this.datagOda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagOda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagOda.Location = new System.Drawing.Point(3, 18);
            this.datagOda.Name = "datagOda";
            this.datagOda.ReadOnly = true;
            this.datagOda.RowHeadersVisible = false;
            this.datagOda.RowHeadersWidth = 10;
            this.datagOda.RowTemplate.Height = 24;
            this.datagOda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagOda.Size = new System.Drawing.Size(938, 244);
            this.datagOda.TabIndex = 3;
            this.datagOda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagOda_CellClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.datagYatak);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox6.Location = new System.Drawing.Point(0, 365);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(944, 265);
            this.groupBox6.TabIndex = 38;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Yataklar";
            // 
            // datagYatak
            // 
            this.datagYatak.AllowUserToDeleteRows = false;
            this.datagYatak.BackgroundColor = System.Drawing.Color.White;
            this.datagYatak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagYatak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagYatak.Location = new System.Drawing.Point(3, 18);
            this.datagYatak.Name = "datagYatak";
            this.datagYatak.ReadOnly = true;
            this.datagYatak.RowHeadersVisible = false;
            this.datagYatak.RowHeadersWidth = 10;
            this.datagYatak.RowTemplate.Height = 24;
            this.datagYatak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagYatak.Size = new System.Drawing.Size(938, 244);
            this.datagYatak.TabIndex = 3;
            this.datagYatak.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagYatak_CellClick);
            // 
            // dt
            // 
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.Location = new System.Drawing.Point(1329, 204);
            this.dt.Name = "dt";
            this.dt.RowTemplate.Height = 24;
            this.dt.Size = new System.Drawing.Size(281, 246);
            this.dt.TabIndex = 39;
            this.dt.Visible = false;
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
            this.btnPdfAktar.Location = new System.Drawing.Point(678, 10);
            this.btnPdfAktar.Name = "btnPdfAktar";
            this.btnPdfAktar.Size = new System.Drawing.Size(266, 75);
            this.btnPdfAktar.TabIndex = 0;
            this.btnPdfAktar.Text = "Boş Yatakları Pdf\'e Aktar";
            this.btnPdfAktar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPdfAktar.UseVisualStyleBackColor = true;
            this.btnPdfAktar.Click += new System.EventHandler(this.btnPdfAktar_Click);
            // 
            // datagBosYatak
            // 
            this.datagBosYatak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagBosYatak.Location = new System.Drawing.Point(1329, 159);
            this.datagBosYatak.Name = "datagBosYatak";
            this.datagBosYatak.RowTemplate.Height = 24;
            this.datagBosYatak.Size = new System.Drawing.Size(10, 14);
            this.datagBosYatak.TabIndex = 4;
            this.datagBosYatak.Visible = false;
            // 
            // frmOda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.datagBosYatak);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Name = "frmOda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Yatak İşlemleri";
            this.Load += new System.EventHandler(this.frmOda_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagOda)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagYatak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagBosYatak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAnaForm;
        private System.Windows.Forms.TextBox txtOdaKat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOdaListele;
        private System.Windows.Forms.Button btnYatakYenile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnYeniOda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnYatakListele;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnOgrenciYatır;
        private System.Windows.Forms.Button btnYatakHareket;
        private System.Windows.Forms.Button btnYeniYatak;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnOdaYenile;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView datagOda;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView datagYatak;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtYatakOda;
        private System.Windows.Forms.Button btnPdfAktar;
        private System.Windows.Forms.DataGridView datagBosYatak;
    }
}