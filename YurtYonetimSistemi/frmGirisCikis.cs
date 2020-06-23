using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class frmGirisCikis : Form
    {
        public frmGirisCikis()
        {
            InitializeComponent();

        }
        public static string secilenUye = "0";
   
        public void Yenile() //tüm değişkenleri yeniler veritabanından yeniden sorgu yapar
        {
           
            GirisCikisVeriYenile("Select Ogrenciler.OgrenciID,Ogrenciler.OgrenciAdi, Ogrenciler.OgrenciSoyadi,Ogrenciler.OgrenimTuru,Ogrenciler.OgrenciTelefon, GirisCikis.TarihSaat, GirisCikis.islemTuru, Ogrenciler.Fotograf FROM Ogrenciler Inner JOIN GirisCikis ON Ogrenciler.OgrenciID = GirisCikis.OgrenciID ORDER BY GirisCikis.TarihSaat DESC");
            txtAdi.Clear();
            txtSoyadi.Clear();
            secilenUye = "0";
            lblAdSoyad.Text = "";
        }
        public void OgrenciVeriYenile(string sqlcumle)//ögrencileri veritabanından çekmek için kullandığımız fonksiyondur
        {
            datagOgrenci.ClearSelection();
            datagOgrenci.DataSource = Baglanti.DataTableGetir(sqlcumle); //veritabanından çekilen veriler datagOgrenci isimli datagridviewe aktarıyoruz

            datagOgrenci.Columns[0].HeaderText = "ID";// datagridviewdeki Sütunlara anlayaçağımız şekilde isimler veriyoruz
            datagOgrenci.Columns[1].HeaderText = "Adı";
            datagOgrenci.Columns[2].HeaderText = "Soyadı";
            datagOgrenci.Columns[3].HeaderText = "Öğrenim Türü";
            datagOgrenci.Columns[4].HeaderText = "Kayıt Tarihi";
            datagOgrenci.Columns[5].HeaderText = "Öğrenci Telefon";
            datagOgrenci.Columns[6].HeaderText = "Veli Telefon";
            datagOgrenci.Columns[7].Visible = false; //datagridviewdeki gözükmesini istemediğimiz sütunları gizliyoruz
            datagOgrenci.Columns[8].Visible = false;
            datagOgrenci.AllowUserToAddRows = false;//datagridviewde son satıra gelen boş satırı gizleme kodu


        }
        public void GirisCikisVeriYenile(string sqlcumle) //giriş-çıkış bilgilerini veritabanından çekmek için kullandığımız fonksiyondur
        {
            datagGirisCikis.ClearSelection();
            datagGirisCikis.DataSource = Baglanti.DataTableGetir(sqlcumle);//veritabanından çekilen veriler datagGirisCikis isimli datagridviewe aktarıyoruz

            datagGirisCikis.Columns[0].HeaderText = "Öğrenci ID";// datagridviewdeki Sütunlara anlayaçağımız şekilde isimler veriyoruz
            datagGirisCikis.Columns[1].HeaderText = "Adı";
            datagGirisCikis.Columns[2].HeaderText = "Soyadı";
            datagGirisCikis.Columns[3].HeaderText = "Öğrenim Türü";
            datagGirisCikis.Columns[4].HeaderText = "Telefon";
            datagGirisCikis.Columns[5].HeaderText = "Tarih-Saat";
            datagGirisCikis.Columns[6].HeaderText = "islem Türü";
            datagGirisCikis.Columns[7].Visible = false;//datagridviewdeki gözükmesini istemediğimiz sütunları gizliyoruz
            datagGirisCikis.AllowUserToAddRows = false;//datagridviewde son satıra gelen boş satırı gizleme kodu


        }
        private void frmGirisCikis_Load(object sender, EventArgs e)
        {
            lblTarihSaat.Text = DateTime.Now.ToString("MM.dd.yyyy HH:mm"); //labele tarih saat yazdırma
           
            timer1.Start();//labele saniyede bir tarih saat yazması için timer'ı aktif ediyoruz
            OgrenciVeriYenile("Select OgrenciID,OgrenciAdi,OgrenciSoyadi,OgrenimTuru,KayitTarihi,OgrenciTelefon,VeliTelefon,Durum,Fotograf from Ogrenciler");//veritabanında ögrenci verilerini çekiyoruz
            Yenile();//tüm verileri ve değişkenleri yenileme fonksiyonunu çağırıyoruz

        }



    

        private void datagOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenUye = Convert.ToString(datagOgrenci.CurrentRow.Cells[0].Value);//datagOgrenci isimli datagridview'de tıklanan satırdaki seçilen ögrencinin ıd değerini değişkene aktarıyoruz
         
            lblAdSoyad.Text = datagOgrenci.CurrentRow.Cells[1].Value.ToString() + " " + datagOgrenci.CurrentRow.Cells[2].Value.ToString();// labele seçilen ögrencinin ad soyadını yazdırıyoruz
           pbOgrenci.ImageLocation = Application.StartupPath + @"\Resimler\" + datagOgrenci.CurrentRow.Cells[8].Value.ToString();// seçilen öğrencinin resminin gösterilmesi
        }

        private void timer1_Tick(object sender, EventArgs e)//bu timer1 saniyede bir kez çalışır 
        {
            lblTarihSaat.Text = DateTime.Now.ToString("MM.dd.yyyy HH:mm");//tarih saat değerinin gösterilmesi
        }

        private void btnKaydetCikis_Click(object sender, EventArgs e)
        {
            if (secilenUye != "0")//seçilen üye var mı diye kontrol ediyoruz. İlk değerini 0 atamıştık. 0 değil ise öğrenci seçilmiştir
            {
                if (Baglanti.idu("insert into GirisCikis(OgrenciID,islemTuru,TarihSaat) values ('" + secilenUye + "','" + "Cikis" + "','" + DateTime.Now.ToString("MM.dd.yyyy HH:mm") + "')") > 0)//veritabanına kayıt gerçekleşirse çalışır
                {

                    MessageBox.Show("Çıkış yapıldı");//kullanıcıya mesaj gösterme

                    Yenile();

                }
             
            }
            else
            {
                MessageBox.Show("Önce öğrenci seçmelisiniz");//kullanıcıya mesaj gösterme
            }
        }

        private void btnKaydetGiris_Click(object sender, EventArgs e)
        {

            if (secilenUye != "0")
            {
                if (Baglanti.idu("insert into GirisCikis(OgrenciID,islemTuru,TarihSaat) values ('" + secilenUye + "','" + "Giris" + "','" + DateTime.Now.ToString("MM.dd.yyyy HH:mm") + "')") > 0)//veritabanına kayıt gerçekleşirse çalışır
                {

                    MessageBox.Show("Giris yapıldı");//kullanıcıya mesaj gösterme

                    Yenile();//tüm verileri ve değişkenleri yeniler

                }
              
            }
            else
            {
                MessageBox.Show("Önce öğrenci seçmelisiniz");//kullanıcıya mesaj gösterme
            }
        }

     

        private void btnListele_Click(object sender, EventArgs e)
        {

            string sqlcumle = "Select OgrenciID,OgrenciAdi,OgrenciSoyadi,OgrenimTuru,KayitTarihi,OgrenciTelefon,VeliTelefon,Durum,Fotograf from Ogrenciler where ";//arama yapmak için kullanıyoruz
            bool listelemeSecim = false;
            if (!string.IsNullOrEmpty(txtAdi.Text))//txtAdi textbox'ına değer girildiyse aramada adi değeride yer alır
            {
                sqlcumle += " OgrenciAdi = '" + txtAdi.Text + "'";//sqlcumleye aramada OgrenciAdi da eklendi
                listelemeSecim = true;
            }
            if (!string.IsNullOrEmpty(txtSoyadi.Text))//txtSoyadi textbox'ına değer girildiyse aramada adi değeride yer alır
            {
                if (listelemeSecim == false)//eğer yukarıda ögrenciAdi boş ise
                {
                    sqlcumle += " OgrenciSoyadi = '" + txtSoyadi.Text + "'";//sqlcumleye aramada OgrenciSoyadi da eklendi
                    listelemeSecim = true;
                }
                else//eğer yukarıda ögrenciAdi dolu ise
                {
                    sqlcumle += " and OgrenciSoyadi = '" + txtSoyadi.Text + "'";//sqlcumleye aramada OgrenciSoyadi da eklendi

                }
            }
            

            if (listelemeSecim == false)//hiçbir şey yazılmadan arama yapıldıysa
            {
                sqlcumle = "Select OgrenciID,OgrenciAdi,OgrenciSoyadi,OgrenimTuru,KayitTarihi,OgrenciTelefon,VeliTelefon,Durum,Fotograf from Ogrenciler";
            }

            OgrenciVeriYenile(sqlcumle);//sqlcumleye göre verileri yeniler
        }

        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            frmAna frm = new frmAna();//ana formu açar
            frm.Show();
            this.Hide();
        }

        private void btnPdfAktar_Click(object sender, EventArgs e)
        {
            try
            {
                //pdf kaydetme kodları

                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "Pdf'in kaydedileceği yeri aşağıdan seçiniz";
                dialog.RootFolder = Environment.SpecialFolder.Desktop;

                if (dialog.ShowDialog() == DialogResult.OK)
                {

                  
                    PdfPTable pdfTable = new PdfPTable(datagGirisCikis.ColumnCount);
                    pdfTable.DefaultCell.Padding = 3;
                    pdfTable.WidthPercentage = 100;//genişligini ayarlıyoruz
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                    pdfTable.DefaultCell.BorderWidth = 1;

                    //header rowlarını ekleme
                    foreach (DataGridViewColumn column in datagGirisCikis.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                        pdfTable.AddCell(cell);
                    }

                    //datarowlarını ekler
                    foreach (DataGridViewRow row in datagGirisCikis.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                    }

                    //pdf kaydeder
                    string folderPath = dialog.SelectedPath.ToString() + "\\";
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    using (FileStream stream = new FileStream(folderPath + "Giris-Cikis.pdf", FileMode.Create))//pdf adını belirtiyoruz
                    {
                        Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                    }
                    MessageBox.Show("Pdf Kaydedildi");
                }
            }
            catch (Exception)
            {


            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Yenile();//tüm verileri ve değişkenleri yenileme fonksiyonunu çağırıyoruz
            OgrenciVeriYenile("Select OgrenciID,OgrenciAdi,OgrenciSoyadi,OgrenimTuru,KayitTarihi,OgrenciTelefon,VeliTelefon,Durum,Fotograf from Ogrenciler");//veritabanında ögrenci verilerini çekiyoruz
        }
    }
}
