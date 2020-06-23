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
    public partial class frmOgrenciGuncelle : Form
    {
        public frmOgrenciGuncelle()
        {
            InitializeComponent();
        }
        string DosyaYolu;
        string secimID = frmOgrenci.secilenUye;

        public void VeriYenile(string sqlcumle)//ögrenciyi veritabanından çekmek için kullandığımız fonksiyondur
        {
            dataGVeri.ClearSelection();
            dataGVeri.DataSource = Baglanti.DataTableGetir(sqlcumle);

           
            dataGVeri.AllowUserToAddRows = false;

           
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            frmOgrenci frm2 = new frmOgrenci();//frmOgrenci formunu açar
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
                pbOgrenci.ImageLocation = DosyaYolu; //resmin ekranda gösterilmesi




                MessageBox.Show("Bitti");//kullanıcıya mesaj verme
            }
            else
            {

                MessageBox.Show("Herhangi bir Kayıt Girilmedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);//kullanıcıya mesaj verme
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtAdi.Text)) && !(string.IsNullOrEmpty(txtSoyadi.Text)) && !(string.IsNullOrEmpty(txtTelefon.Text)) && !(string.IsNullOrEmpty(txtVeliTelefon.Text)) &&  !(string.IsNullOrEmpty(cbOgrenimTuru.SelectedItem.ToString())))
            {
                if (!(string.IsNullOrEmpty(DosyaYolu)))//resimde güncelleniyorsa
                {

                    string kaynak = DosyaYolu;
                    string hedef = Application.StartupPath + @"\Resimler\";
                    string yeniad = Guid.NewGuid() + ".jpg"; //Benzersiz isim verme
                    File.Copy(kaynak, hedef + yeniad);

                    if (Baglanti.idu("update Ogrenciler set OgrenciAdi = '" + txtAdi + "',OgrenciSoyadi='" + txtSoyadi.Text + "',OgrenciTelefon='" + txtTelefon.Text + "',KayitTarihi='" + dtKayitTarihi.Value.ToString("MM.dd.yyyy HH:mm") + "',OgrenimTuru='" + cbOgrenimTuru.SelectedItem.ToString() + "',Fotograf='" + yeniad + "',VeliTelefon='" + txtVeliTelefon.Text + "' where OgrenciID = " + secimID + "") > 0)//güncelleme işlemi
                    {
                        MessageBox.Show("Güncelleme Başarılı");//kullanıcıya mesaj verme


                        frmOgrenci frm2 = new frmOgrenci();//frmOgrenci formunu açar
                        this.Hide();
                        frm2.Show();

                    }
                }
                else//resim güncellenmiyorsa
                {

                    if (Baglanti.idu("update Ogrenciler set OgrenciAdi = '" + txtAdi.Text + "',OgrenciSoyadi='" + txtSoyadi.Text + "',OgrenciTelefon='" + txtTelefon.Text + "',KayitTarihi='" + dtKayitTarihi.Value.ToString("MM.dd.yyyy HH:mm") + "',OgrenimTuru='" + cbOgrenimTuru.SelectedItem.ToString() + "',VeliTelefon='" + txtVeliTelefon.Text + "' where OgrenciID = " + secimID + "") > 0)
                    {
                        MessageBox.Show("Güncelleme Başarılı");//kullanıcıya mesaj verme


                        frmOgrenci frm2 = new frmOgrenci();//frmOgrenci formunu açar
                        this.Hide();
                        frm2.Show();

                    }
                }
            }
            else
            {
                MessageBox.Show("Tüm alanlar dolu olmalıdır");//kullanıcıya mesaj verme
            }
        }

        private void frmOgrenciGuncelle_Load(object sender, EventArgs e)
        {
            //seçilen güncellenecek  ögrencinin eski verilerinin çekilip alanlarda gösterilme işlemleri
            VeriYenile("Select OgrenciID,OgrenciAdi,OgrenciSoyadi,OgrenimTuru,KayitTarihi,OgrenciTelefon,VeliTelefon,Durum,Fotograf from Ogrenciler where OgrenciID= " + secimID);

            txtAdi.Text = dataGVeri.Rows[0].Cells[1].Value.ToString();
            txtSoyadi.Text = dataGVeri.Rows[0].Cells[2].Value.ToString();
            cbOgrenimTuru.SelectedItem = dataGVeri.Rows[0].Cells[3].Value.ToString();
            dtKayitTarihi.Value = Convert.ToDateTime(dataGVeri.Rows[0].Cells[4].Value);
            txtTelefon.Text = dataGVeri.Rows[0].Cells[5].Value.ToString();
            txtVeliTelefon.Text = dataGVeri.Rows[0].Cells[6].Value.ToString();
            pbOgrenci.ImageLocation = Application.StartupPath + @"\Resimler\" + dataGVeri.Rows[0].Cells[8].Value.ToString();
           
        }

        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            frmAna frm2 = new frmAna();//ana formu açar
            this.Hide();
            frm2.Show();
        }
    }
}
