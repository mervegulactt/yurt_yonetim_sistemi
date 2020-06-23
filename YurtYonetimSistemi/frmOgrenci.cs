using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtYonetimSistemi
{
    public partial class frmOgrenci : Form
    {
        public frmOgrenci()
        {
            InitializeComponent();
        }
        public static string secilenUye = "0";
        bool durum = false;
        public static DateTime KayitTarihi;
        public void VeriYenile(string sqlcumle)//ögrencileri veritabanından çekmek için kullandığımız fonksiyondur
        {
            dataGVeri.ClearSelection();//datagVerideki önceki verileri temizleme
            dataGVeri.DataSource = Baglanti.DataTableGetir(sqlcumle);//veritabanından çekilen veriler dataGVeri isimli datagridviewe aktarıyoruz

            dataGVeri.Columns[0].HeaderText = "ID";// datagridviewdeki Sütunlara anlayaçağımız şekilde isimler veriyoruz
            dataGVeri.Columns[1].HeaderText = "Adı";
            dataGVeri.Columns[2].HeaderText = "Soyadı";
            dataGVeri.Columns[3].HeaderText = "Öğrenim Türü";
            dataGVeri.Columns[4].HeaderText = "Kayıt Tarihi";
            dataGVeri.Columns[5].HeaderText = "Öğrenci Telefon";
            dataGVeri.Columns[6].HeaderText =  "Veli Telefon";;
            dataGVeri.Columns[7].Visible = false;//datagridviewdeki gözükmesini istemediğimiz sütunları gizliyoruz
            dataGVeri.Columns[8].Visible = false;
            dataGVeri.Columns[9].HeaderText = "Oda";
            dataGVeri.Columns[10].HeaderText = "Yatak";
            dataGVeri.AllowUserToAddRows = false;//datagridviewde son satıra gelen boş satırı gizleme kodu

            for (int i = 0; i < dataGVeri.Rows.Count; i++)
            {
                if ((bool)dataGVeri.Rows[i].Cells[7].Value == true)//ögrenci aktifse yeşilin tonuna boyama
                {

                    dataGVeri.Rows[i].DefaultCellStyle.BackColor = Color.MediumAquamarine;
                }
                else//ögrenci pasifse yeşilin tonuna boyama
                {
                    dataGVeri.Rows[i].DefaultCellStyle.BackColor = Color.Gainsboro;
                }

            }
        }
        private void frmOgrenci_Load(object sender, EventArgs e)
        {
            pbOgrenci.ImageLocation = Application.StartupPath + @"\Resimler\ogrenci.png";
            VeriYenile("Select Ogrenciler.OgrenciID,Ogrenciler.OgrenciAdi,Ogrenciler.OgrenciSoyadi,Ogrenciler.OgrenimTuru,Ogrenciler.KayitTarihi,Ogrenciler.OgrenciTelefon,Ogrenciler.VeliTelefon,Ogrenciler.Durum,Ogrenciler.Fotograf,Yataklar.OdaID,YatakHareket.YatakID, Yataklar.Fiyat  FROM Ogrenciler Left JOIN YatakHareket ON Ogrenciler.OgrenciID = YatakHareket.OgrenciID and  YatakHareket.Durum=1 Left JOIN Yataklar ON Yataklar.YatakID = YatakHareket.YatakID");//verileri çekme
            



        }

        private void dataGVeri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenUye = Convert.ToString(dataGVeri.CurrentRow.Cells[0].Value);//datagridviewde seçilen satırdaki ögrencinin ıd değerini alma
            KayitTarihi = Convert.ToDateTime(dataGVeri.CurrentRow.Cells[4].Value);//datagridviewde seçilen satırdaki ögrencinin kayitTarihi değerini alma

            pbOgrenci.ImageLocation = Application.StartupPath + @"\Resimler\"+ dataGVeri.CurrentRow.Cells[8].Value.ToString();//datagridviewde seçilen satırdaki ögrencinin resmini gösterme

            if ((bool)dataGVeri.CurrentRow.Cells[7].Value == true)// aktif pasif butonu işlemleri
            {
                btnAktifPasif.BackColor = Color.Gainsboro;//btnAktifPasif butonunun rengini değiştirme
                btnAktifPasif.Text = "Pasif Yap"; //btnAktifPasif yazısını değiştirme 
                btnAktifPasif.ForeColor = Color.Black; //btnAktifPasif butonunun  yazı rengini değiştirme
                durum = false;
            }
            else
            {
                btnAktifPasif.BackColor = Color.MediumAquamarine;//btnAktifPasif butonunun rengini değiştirme
                btnAktifPasif.Text = "Aktif Yap";//btnAktifPasif yazısını değiştirme 
                btnAktifPasif.ForeColor = Color.White;//btnAktifPasif butonunun  yazı rengini değiştirme
                durum = true;
            }
        }

        private void btnAktifPasif_Click(object sender, EventArgs e)
        {
            if (secilenUye != "0")
            {
                Baglanti.idu("update Ogrenciler set Durum='" + (Convert.ToInt32(durum)).ToString() + "' where OgrenciID= '" + secilenUye + "'");//seçilen ögrencinin durumunun aktif-pasif yapılması
                Baglanti.idu("update YatakHareket set Durum=0 where OgrenciID= '" + secilenUye + "'");//seçilen ögrencinin yatağının boşaltılması
                VeriYenile("Select Ogrenciler.OgrenciID,Ogrenciler.OgrenciAdi,Ogrenciler.OgrenciSoyadi,Ogrenciler.OgrenimTuru,Ogrenciler.KayitTarihi,Ogrenciler.OgrenciTelefon,Ogrenciler.VeliTelefon,Ogrenciler.Durum,Ogrenciler.Fotograf,Yataklar.OdaID,YatakHareket.YatakID, Yataklar.Fiyat  FROM Ogrenciler Left JOIN YatakHareket ON Ogrenciler.OgrenciID = YatakHareket.OgrenciID and  YatakHareket.Durum=1 Left JOIN Yataklar ON Yataklar.YatakID = YatakHareket.YatakID");//verilerin yeniden veritabanından çekilmesi
                //üye aktif pasif yapma

            }
            else
            {
                MessageBox.Show("Önce üye seçiniz");//kullanıcıya mesaj gösterme
            }
        }

        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            frmAna frm2 = new frmAna();//frmYeniOgrenci formunu açar
            this.Hide();
            frm2.Show();
        }

        private void btnYeniOgrenci_Click(object sender, EventArgs e)
        {
            frmYeniOgrenci frm2 = new frmYeniOgrenci();//frmYeniOgrenci formunu açar
            this.Hide();
            frm2.Show();
        }

        private void btnIzinTalep_Click(object sender, EventArgs e)
        {
            if (secilenUye != "0")
            {
                frmIzinTalep frm2= new frmIzinTalep();//frmIzinTalep formunu açar
                this.Hide();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Önce öğrenci seçmelisiniz");//kullanıcıya mesaj gösterme
            }
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (secilenUye != "0")
            {
                frmOdeme frm2 = new frmOdeme();//frmOdeme formunu açar
                this.Hide();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Önce öğrenci seçmelisiniz");//kullanıcıya mesaj gösterme
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
          

            string sqlcumle = " Select Ogrenciler.OgrenciID,Ogrenciler.OgrenciAdi,Ogrenciler.OgrenciSoyadi,Ogrenciler.OgrenimTuru,Ogrenciler.KayitTarihi,Ogrenciler.OgrenciTelefon,Ogrenciler.VeliTelefon,Ogrenciler.Durum,Ogrenciler.Fotograf,Yataklar.OdaID,YatakHareket.YatakID, Yataklar.Fiyat  FROM Ogrenciler Left JOIN YatakHareket ON Ogrenciler.OgrenciID = YatakHareket.OgrenciID and  YatakHareket.Durum=1 Left JOIN Yataklar ON Yataklar.YatakID = YatakHareket.YatakID where ";//arama yapmak için kullanıyoruz
            bool listelemeSecim = false;
                if (!string.IsNullOrEmpty(txtAdi.Text))//txtAdi textbox'ına değer girildiyse aramada adi değeride yer alır
            {
                    sqlcumle += " Ogrenciler.OgrenciAdi = '" + txtAdi.Text + "'";//sqlcumleye aramada OgrenciAdi da eklendi
                listelemeSecim = true;
                }
            if (!string.IsNullOrEmpty(txtSoyadi.Text))//txtSoyadi textbox'ına değer girildiyse aramada adi değeride yer alır
            {
                if (listelemeSecim == false)//eğer yukarıda ögrenciAdi boş ise
                {
                    sqlcumle += " Ogrenciler.OgrenciSoyadi = '" + txtSoyadi.Text + "'";
                    listelemeSecim = true;
                }
                else//eğer yukarıda ögrenciAdi dolu ise
                {
                    sqlcumle += " and Ogrenciler.OgrenciSoyadi = '" + txtSoyadi.Text + "'";

                }
            }
            if (!string.IsNullOrEmpty(txtOda.Text))//txtOda textbox'ına değer girildiyse aramada adi değeride yer alır
            {
                if (listelemeSecim == false)//eğer yukarıda boş ise
                {
                    sqlcumle += " Yataklar.OdaId = '" + txtOda.Text + "'";
                    listelemeSecim = true;
                }
                else
                {
                    sqlcumle += " and Yataklar.OdaId = '" + txtOda.Text + "'";

                }
            }
            if (!string.IsNullOrEmpty(txtYatak.Text))//txtYatak textbox'ına değer girildiyse aramada adi değeride yer alır
            {
                if (listelemeSecim == false)//eğer yukarıda  boş ise
                {
                    sqlcumle += " YatakHareket.YatakID = '" + txtYatak.Text + "'";
                    listelemeSecim = true;
                }
                else//eğer yukarıda ögrenciAdi dolu ise
                {
                    sqlcumle += " and YatakHareket.YatakID = '" + txtYatak.Text + "'";

                }
            }


            if (cbOgretimTuru.SelectedItem != null)
                {
                    if (listelemeSecim == false)
                    {
                        sqlcumle += " Ogrenciler.OgrenimTuru = '" + cbOgretimTuru.SelectedItem.ToString() + "'";
                        listelemeSecim = true;
                    }
                    else
                    {
                        sqlcumle += " and Ogrenciler.OgrenimTuru = '" + cbOgretimTuru.SelectedItem.ToString() + "'";

                    }
                }
                if (cbDurum.SelectedItem != null)
                {
                    bool durumdeger;
                    if (cbDurum.SelectedItem.ToString() == "Aktif")
                    {
                        durumdeger = true;
                    }
                    else
                    {
                        durumdeger = false;
                    }



                    if (listelemeSecim == false)
                    {
                        sqlcumle += " Ogrenciler.Durum=" + Convert.ToInt32( durumdeger);
                        listelemeSecim = true;
                    }
                    else
                    {
                        sqlcumle += " and Ogrenciler.Durum=" + Convert.ToInt32(durumdeger);

                    }
                }

                if (listelemeSecim == false)//hiçbir şey yazılmadan arama yapıldıysa
            {
                    sqlcumle = "Select Ogrenciler.OgrenciID,Ogrenciler.OgrenciAdi,Ogrenciler.OgrenciSoyadi,Ogrenciler.OgrenimTuru,Ogrenciler.KayitTarihi,Ogrenciler.OgrenciTelefon,Ogrenciler.VeliTelefon,Ogrenciler.Durum,Ogrenciler.Fotograf,Yataklar.OdaID,YatakHareket.YatakID, Yataklar.Fiyat  FROM Ogrenciler Left JOIN YatakHareket ON Ogrenciler.OgrenciID = YatakHareket.OgrenciID and  YatakHareket.Durum=1 Left JOIN Yataklar ON Yataklar.YatakID = YatakHareket.YatakID";//arama yapmak için kullanıyoruz
            }

                VeriYenile(sqlcumle);//sqlcumleye göre verileri yeniler


        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            //Bütün işlemleri yenileme temizleme işlemleri
         secilenUye = "0";
       durum = false;
        txtAdi.Clear();
            txtOda.Clear();
            txtYatak.Clear();
            txtSoyadi.Clear();
            cbDurum.SelectedItem= null;
            cbOgretimTuru.SelectedItem = null;
            pbOgrenci.ImageLocation = Application.StartupPath + @"\Resimler\ogrenci.png";
            VeriYenile("Select Ogrenciler.OgrenciID,Ogrenciler.OgrenciAdi,Ogrenciler.OgrenciSoyadi,Ogrenciler.OgrenimTuru,Ogrenciler.KayitTarihi,Ogrenciler.OgrenciTelefon,Ogrenciler.VeliTelefon,Ogrenciler.Durum,Ogrenciler.Fotograf,Yataklar.OdaID,YatakHareket.YatakID, Yataklar.Fiyat  FROM Ogrenciler Left JOIN YatakHareket ON Ogrenciler.OgrenciID = YatakHareket.OgrenciID and  YatakHareket.Durum=1 Left JOIN Yataklar ON Yataklar.YatakID = YatakHareket.YatakID");//verileri çekme
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenUye != "0")//seçilen bir üye var ise
            {
                frmOgrenciGuncelle frm2 = new frmOgrenciGuncelle();//frmOgrenciGuncelle formunu açar
                this.Hide();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Önce öğrenci seçmelisiniz");//kullanıcıya mesaj gösterme
            }
        }
    }
}
