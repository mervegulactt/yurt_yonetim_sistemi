namespace YurtYonetimSistemi
{
    partial class frmAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAna));
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGirisCikis = new System.Windows.Forms.Button();
            this.btnIzinler = new System.Windows.Forms.Button();
            this.btnOda = new System.Windows.Forms.Button();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.panelResimAlani = new System.Windows.Forms.Panel();
            this.pbArkaplan = new System.Windows.Forms.PictureBox();
            this.btnAlacaklar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelResimAlani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArkaplan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.FlatAppearance.BorderSize = 0;
            this.btnOgrenci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOgrenci.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOgrenci.ImageIndex = 0;
            this.btnOgrenci.ImageList = this.ımageList1;
            this.btnOgrenci.Location = new System.Drawing.Point(12, 10);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(150, 75);
            this.btnOgrenci.TabIndex = 0;
            this.btnOgrenci.Text = "Öğrenci İşlemleri";
            this.btnOgrenci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ogr.png");
            this.ımageList1.Images.SetKeyName(1, "odeme.png");
            this.ımageList1.Images.SetKeyName(2, "oda.png");
            this.ımageList1.Images.SetKeyName(3, "izinTalep.png");
            this.ımageList1.Images.SetKeyName(4, "login.png");
            this.ımageList1.Images.SetKeyName(5, "para.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnGirisCikis);
            this.panel1.Controls.Add(this.btnIzinler);
            this.panel1.Controls.Add(this.btnOda);
            this.panel1.Controls.Add(this.btnAlacaklar);
            this.panel1.Controls.Add(this.btnOdeme);
            this.panel1.Controls.Add(this.btnOgrenci);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 88);
            this.panel1.TabIndex = 1;
            // 
            // btnGirisCikis
            // 
            this.btnGirisCikis.FlatAppearance.BorderSize = 0;
            this.btnGirisCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisCikis.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGirisCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGirisCikis.ImageIndex = 4;
            this.btnGirisCikis.ImageList = this.ımageList1;
            this.btnGirisCikis.Location = new System.Drawing.Point(792, 10);
            this.btnGirisCikis.Name = "btnGirisCikis";
            this.btnGirisCikis.Size = new System.Drawing.Size(150, 75);
            this.btnGirisCikis.TabIndex = 1;
            this.btnGirisCikis.Text = "Giriş Çıkış";
            this.btnGirisCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGirisCikis.UseVisualStyleBackColor = true;
            this.btnGirisCikis.Click += new System.EventHandler(this.btnGirisCikis_Click);
            // 
            // btnIzinler
            // 
            this.btnIzinler.FlatAppearance.BorderSize = 0;
            this.btnIzinler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzinler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzinler.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIzinler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIzinler.ImageIndex = 3;
            this.btnIzinler.ImageList = this.ımageList1;
            this.btnIzinler.Location = new System.Drawing.Point(636, 10);
            this.btnIzinler.Name = "btnIzinler";
            this.btnIzinler.Size = new System.Drawing.Size(150, 75);
            this.btnIzinler.TabIndex = 1;
            this.btnIzinler.Text = "İzinler";
            this.btnIzinler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIzinler.UseVisualStyleBackColor = true;
            this.btnIzinler.Click += new System.EventHandler(this.btnIzinler_Click);
            // 
            // btnOda
            // 
            this.btnOda.FlatAppearance.BorderSize = 0;
            this.btnOda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOda.ImageIndex = 2;
            this.btnOda.ImageList = this.ımageList1;
            this.btnOda.Location = new System.Drawing.Point(480, 10);
            this.btnOda.Name = "btnOda";
            this.btnOda.Size = new System.Drawing.Size(150, 75);
            this.btnOda.TabIndex = 0;
            this.btnOda.Text = "Oda İşlemleri";
            this.btnOda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOda.UseVisualStyleBackColor = true;
            this.btnOda.Click += new System.EventHandler(this.btnOda_Click);
            // 
            // btnOdeme
            // 
            this.btnOdeme.FlatAppearance.BorderSize = 0;
            this.btnOdeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdeme.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOdeme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOdeme.ImageIndex = 1;
            this.btnOdeme.ImageList = this.ımageList1;
            this.btnOdeme.Location = new System.Drawing.Point(168, 10);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(150, 75);
            this.btnOdeme.TabIndex = 0;
            this.btnOdeme.Text = "Ödemeler";
            this.btnOdeme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // panelResimAlani
            // 
            this.panelResimAlani.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelResimAlani.Controls.Add(this.pbArkaplan);
            this.panelResimAlani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResimAlani.Location = new System.Drawing.Point(0, 88);
            this.panelResimAlani.Name = "panelResimAlani";
            this.panelResimAlani.Size = new System.Drawing.Size(1262, 633);
            this.panelResimAlani.TabIndex = 2;
            // 
            // pbArkaplan
            // 
            this.pbArkaplan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbArkaplan.Location = new System.Drawing.Point(0, 0);
            this.pbArkaplan.Name = "pbArkaplan";
            this.pbArkaplan.Size = new System.Drawing.Size(1262, 633);
            this.pbArkaplan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArkaplan.TabIndex = 0;
            this.pbArkaplan.TabStop = false;
            // 
            // btnAlacaklar
            // 
            this.btnAlacaklar.FlatAppearance.BorderSize = 0;
            this.btnAlacaklar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlacaklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlacaklar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAlacaklar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlacaklar.ImageIndex = 5;
            this.btnAlacaklar.ImageList = this.ımageList1;
            this.btnAlacaklar.Location = new System.Drawing.Point(324, 10);
            this.btnAlacaklar.Name = "btnAlacaklar";
            this.btnAlacaklar.Size = new System.Drawing.Size(150, 75);
            this.btnAlacaklar.TabIndex = 0;
            this.btnAlacaklar.Text = "Alacaklar";
            this.btnAlacaklar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlacaklar.UseVisualStyleBackColor = true;
            this.btnAlacaklar.Click += new System.EventHandler(this.btnAlacaklar_Click);
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.panelResimAlani);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yurt Yönetim Sistemi";
            this.Load += new System.EventHandler(this.frmAna_Load);
            this.panel1.ResumeLayout(false);
            this.panelResimAlani.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbArkaplan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Button btnOda;
        private System.Windows.Forms.Button btnIzinler;
        private System.Windows.Forms.Panel panelResimAlani;
        private System.Windows.Forms.PictureBox pbArkaplan;
        private System.Windows.Forms.Button btnGirisCikis;
        private System.Windows.Forms.Button btnAlacaklar;
    }
}

