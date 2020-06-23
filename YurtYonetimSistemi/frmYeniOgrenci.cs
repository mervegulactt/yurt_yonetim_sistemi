using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtYonetimSistemi
{
    public partial class frmYeniOgrenci : Form
    {
        public frmYeniOgrenci()
        {
            InitializeComponent();
        }
        string DosyaYolu;
       
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtAdi.Text)) && !(string.IsNullOrEmpty(txtSoyadi.Text)) && !(string.IsNullOrEmpty(txtTelefon.Text)) && !(string.IsNullOrEmpty(txtVeliTelefon.Text)) && !(string.IsNullOrEmpty(cbOgrenimTuru.Text)))
            {
                if (!(string.IsNullOrEmpty(DosyaYolu)))//resim seçilmiş mi kontrol etme
                {

                    string kaynak = DosyaYolu;
                    string hedef = Application.StartupPath + @"\Resimler\";
                    string yeniad = Guid.NewGuid() + ".jpg"; //Benzersiz isim verme
                    File.Copy(kaynak, hedef + yeniad);

                    if (Baglanti.idu("insert into Ogrenciler(OgrenciAdi,OgrenciSoyadi,OgrenciTelefon,KayitTarihi,OgrenimTuru,Fotograf,VeliTelefon,Durum) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + txtTelefon.Text + "','" + dtKayitTarihi.Value.ToString("MM.dd.yyyy HH:mm") + "','" + cbOgrenimTuru.SelectedItem.ToString() + "','" + yeniad + "','" + txtVeliTelefon.Text + "','" + "1" + "')") > 0)//veritabanına öğrenciyi kaydetme
                    {
                        MessageBox.Show("Kayit Başarılı");//kullanıcıya mesaj verme


                        frmOgrenci frm2 = new frmOgrenci();//frmOgrenci formunu açar
                        this.Hide();
                        frm2.Show();

                    }
                }
                else
                {

                    MessageBox.Show("Önce resim seçiniz");//kullanıcıya mesaj verme
                }
            }
            else
            {
                MessageBox.Show("Tüm alanlar dolu olmalıdır");//kullanıcıya mesaj verme
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            frmOgrenci frm2 = new frmOgrenci();//frmOgrenci formunu açar
            this.Hide();
            frm2.Show();
        }

        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            frmAna frm2 = new frmAna();//frmAna formunu açar
            this.Hide();
            frm2.Show();
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();//kullanıcıya resim seçme ekranını açma


            if (dosya.ShowDialog() == DialogResult.OK)
            {
                dosya.Filter = "Resim Dosyası |*.jpg;*.png |  Tüm Dosyalar |*.*";
                DosyaYolu = dosya.FileName;//seçilen resmin dosya yolunu alma
                pbOgrenci.ImageLocation = DosyaYolu;//resmin ekranda gösterilmesi





            }
            else
            {

                MessageBox.Show("Herhangi bir Kayıt Girilmedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);//kullanıcıya mesaj verme
            }
        }

        private void frmYeniOgrenci_Load(object sender, EventArgs e)
        {
            pbOgrenci.ImageLocation = Application.StartupPath + @"\Resimler\ogrenci.png";
        }

       
    }
}
