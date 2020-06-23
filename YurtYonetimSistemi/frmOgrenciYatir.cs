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
    public partial class frmOgrenciYatir : Form
    {
        public frmOgrenciYatir()
        {
            InitializeComponent();
        }
        public static int secilenOgrenci = 0;
        bool yatakSahip = false;
        int eskiYatakID = 0;
        int yatakID = frmOda.YatakID;
        public void VeriYenile(string sqlcumle)//ögrencileri veritabanından çekmek için kullandığımız fonksiyondur
        {
            dataGVeri.ClearSelection();//datagVerideki önceki verileri temizleme

            dataGVeri.DataSource = Baglanti.DataTableGetir(sqlcumle);
            dataGVeri.AllowUserToAddRows = false;
            for (int i = 0; i < dataGVeri.RowCount; i++)
            {
                if ((bool)dataGVeri.Rows[i].Cells[6].Value == false)
                {
                    dataGVeri.Rows.RemoveAt(i);
                    dataGVeri.Refresh();
                }
            }

            dataGVeri.Columns[0].HeaderText = "ID";// datagridviewdeki Sütunlara anlayaçağımız şekilde isimler veriyoruz
            dataGVeri.Columns[1].HeaderText = "Adı";
            dataGVeri.Columns[2].HeaderText = "Soyadı";
            dataGVeri.Columns[3].HeaderText = "Öğrenim Türü";
            dataGVeri.Columns[4].HeaderText = "Yatak";
            dataGVeri.Columns[5].HeaderText = "Kayıt Tarihi";

            dataGVeri.Columns[0].Width = 115;
            dataGVeri.Columns[1].Width = 115;//genişlik ayarı
            dataGVeri.Columns[2].Width = 115;
            dataGVeri.Columns[3].Width = 115;
            dataGVeri.Columns[4].Width = 115;
            dataGVeri.Columns[5].Width = 115;

            dataGVeri.Columns[6].HeaderText = "Ögrenci Durum";// datagridviewdeki Sütunlara anlayaçağımız şekilde isimler veriyoruz
            dataGVeri.Columns[7].HeaderText = "Yatak Hareket Durum";
            dataGVeri.Columns[8].HeaderText = "Fotograf";
            dataGVeri.Columns[6].Visible = false;
            dataGVeri.Columns[7].Visible = false;
            dataGVeri.Columns[8].Visible = false; //datagridviewdeki gözükmesini istemediğimiz sütunları gizliyoruz

        }
        private void frmOgrenciYatir_Load(object sender, EventArgs e)
        {
            pbOgrenci.ImageLocation = Application.StartupPath + @"\Resimler\ogrenci.png";
            VeriYenile("Select Ogrenciler.OgrenciID,Ogrenciler.OgrenciAdi,Ogrenciler.OgrenciSoyadi,Ogrenciler.OgrenimTuru,YatakHareket.YatakID,Ogrenciler.KayitTarihi,Ogrenciler.Durum,YatakHareket.Durum,Ogrenciler.Fotograf FROM Ogrenciler Left JOIN YatakHareket ON Ogrenciler.OgrenciID = YatakHareket.OgrenciID and YatakHareket.Durum=1 where Ogrenciler.Durum=1");//veritabanından çekilen veriler dataGVeri isimli datagridviewe aktarıyoruz);//verileri yenileme işlemi
        }

        private void dataGVeri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgrenci = Convert.ToInt32(dataGVeri.CurrentRow.Cells[0].Value);//datagridviewdeki seçilen satırdaki öğrencinin ıd değerini alma
            pbOgrenci.ImageLocation = Application.StartupPath + @"\Resimler\" + dataGVeri.CurrentRow.Cells[8].Value.ToString();//datagridviewdeki seçilen satırdaki öğrencinin resmini gösterme
            if (string.IsNullOrEmpty(dataGVeri.CurrentRow.Cells[4].Value.ToString()))//öğrencinin yatagının olup olmadığının tespiti
            {

                yatakSahip = true;

            }
            else
            {

                yatakSahip = false;
                eskiYatakID = Convert.ToInt32(dataGVeri.CurrentRow.Cells[4].Value);
            }
        }

        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            frmAna frm2 = new frmAna();//ana formu açar
            this.Hide();
            frm2.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Baglanti.idu("update YatakHareket set Durum=0 where YatakID = " + yatakID + " and Durum=1");

            if (yatakSahip == true && secilenOgrenci != 0)
            {
                if (Baglanti.idu("insert into YatakHareket(YatakID,OgrenciID,Durum) values ('" + yatakID + "','" + secilenOgrenci + "','" + "1" + "')") > 0)//seçilen öğrencinin yatağa yatırılması
                {
                    MessageBox.Show("Kayit Başarılı");


                    VeriYenile("Select Ogrenciler.OgrenciID,Ogrenciler.OgrenciAdi,Ogrenciler.OgrenciSoyadi,Ogrenciler.OgrenimTuru,YatakHareket.YatakID,Ogrenciler.KayitTarihi,Ogrenciler.Durum,YatakHareket.Durum,Ogrenciler.Fotograf FROM Ogrenciler Left JOIN YatakHareket ON Ogrenciler.OgrenciID = YatakHareket.OgrenciID and YatakHareket.Durum=1 where Ogrenciler.Durum=1");//veritabanından çekilen veriler dataGVeri isimli datagridviewe aktarıyoruz);//verileri yenileme işlemi

                }

            }
            else if (yatakSahip == false && secilenOgrenci != 0)
            {
                if (Baglanti.idu("update YatakHareket set Durum=0 where OgrenciID = " + secilenOgrenci + " and Durum=1") > 0)//öğrencinin eski yatagının boşaltılması

                {
                    if (Baglanti.idu("insert into YatakHareket(YatakID,OgrenciID,Durum) values ('" + yatakID + "','" + secilenOgrenci + "','" + "1" + "')") > 0)//öğrencinin yeni yatagına yatırılması
                    {
                        MessageBox.Show("Kayit Başarılı");//kullanıcıya mesaj gösterme


                        VeriYenile("Select Ogrenciler.OgrenciID,Ogrenciler.OgrenciAdi,Ogrenciler.OgrenciSoyadi,Ogrenciler.OgrenimTuru,YatakHareket.YatakID,Ogrenciler.KayitTarihi,Ogrenciler.Durum,YatakHareket.Durum,Ogrenciler.Fotograf FROM Ogrenciler Left JOIN YatakHareket ON Ogrenciler.OgrenciID = YatakHareket.OgrenciID and YatakHareket.Durum=1 where Ogrenciler.Durum=1");//veritabanından çekilen veriler dataGVeri isimli datagridviewe aktarıyoruz);//verileri yenileme işlemi
                    }
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmOda frm2 = new frmOda();//frmOda formunu açar
            this.Hide();
            frm2.Show();
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

                    //Creating iTextSharp Table from the DataTable data
                    PdfPTable pdfTable = new PdfPTable(dataGVeri.ColumnCount);
                    pdfTable.DefaultCell.Padding = 3;
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                    pdfTable.DefaultCell.BorderWidth = 1;

                    //header rowlarını ekleme
                    foreach (DataGridViewColumn column in dataGVeri.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                        pdfTable.AddCell(cell);
                    }

                    //datarowlarını ekler
                    foreach (DataGridViewRow row in dataGVeri.Rows)
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
                    using (FileStream stream = new FileStream(folderPath + "Ogrenci-Yatak.pdf", FileMode.Create))
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

        private void btnListele_Click(object sender, EventArgs e)
        {
            string sqlcumle = " Select Ogrenciler.OgrenciID,Ogrenciler.OgrenciAdi,Ogrenciler.OgrenciSoyadi,Ogrenciler.OgrenimTuru,YatakHareket.YatakID,Ogrenciler.KayitTarihi,Ogrenciler.Durum,YatakHareket.Durum,Ogrenciler.Fotograf FROM Ogrenciler Left JOIN YatakHareket ON Ogrenciler.OgrenciID = YatakHareket.OgrenciID and YatakHareket.Durum=1 where Ogrenciler.Durum=1  ";//veritabanından çekilen veriler dataGVeri isimli datagridviewe aktarıyoruz
            bool listelemeSecim = false;
            if (!string.IsNullOrEmpty(txtAdi.Text))//txtAdi textbox'ına değer girildiyse aramada adi değeride yer alır
            {
                sqlcumle += " and Ogrenciler.OgrenciAdi = '" + txtAdi.Text + "'";//sqlcumleye aramada OgrenciAdi da eklendi
                listelemeSecim = true;
            }
            if (!string.IsNullOrEmpty(txtSoyadi.Text))//txtSoyadi textbox'ına değer girildiyse aramada adi değeride yer alır
            {
                sqlcumle += " and Ogrenciler.OgrenciSoyadi = '" + txtSoyadi.Text + "'";
                listelemeSecim = true;

            }



            if (cbOgretimTuru.SelectedItem != null)
            {

                listelemeSecim = true;

                sqlcumle += " and Ogrenciler.OgrenimTuru = '" + cbOgretimTuru.SelectedItem.ToString() + "'";


            }


            if (listelemeSecim == false)//hiçbir şey yazılmadan arama yapıldıysa
            {
                sqlcumle = "Select Ogrenciler.OgrenciID,Ogrenciler.OgrenciAdi,Ogrenciler.OgrenciSoyadi,Ogrenciler.OgrenimTuru,YatakHareket.YatakID,Ogrenciler.KayitTarihi,Ogrenciler.Durum,YatakHareket.Durum,Ogrenciler.Fotograf FROM Ogrenciler Left JOIN YatakHareket ON Ogrenciler.OgrenciID = YatakHareket.OgrenciID and YatakHareket.Durum = 1 where Ogrenciler.Durum = 1";//veritabanından çekilen veriler dataGVeri isimli datagridviewe aktarıyoruz
            }

            VeriYenile(sqlcumle);//sqlcumleye göre verileri yeniler
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            VeriYenile("Select Ogrenciler.OgrenciID,Ogrenciler.OgrenciAdi,Ogrenciler.OgrenciSoyadi,Ogrenciler.OgrenimTuru,YatakHareket.YatakID,Ogrenciler.KayitTarihi,Ogrenciler.Durum,YatakHareket.Durum,Ogrenciler.Fotograf FROM Ogrenciler Left JOIN YatakHareket ON Ogrenciler.OgrenciID = YatakHareket.OgrenciID and YatakHareket.Durum=1 where Ogrenciler.Durum=1");//veritabanından çekilen veriler dataGVeri isimli datagridviewe aktarıyoruz);//verileri yenileme işlemi
            secilenOgrenci = 0;
            yatakSahip = false;
            eskiYatakID = 0;
            pbOgrenci.ImageLocation = Application.StartupPath + @"\Resimler\ogrenci.png";
        }
    }
}
