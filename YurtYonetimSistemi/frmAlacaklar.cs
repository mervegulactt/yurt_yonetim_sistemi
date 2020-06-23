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
    public partial class frmAlacaklar : Form
    {
        public frmAlacaklar()
        {
            InitializeComponent();
        }
    
        DateTime kayitTarihi = frmOgrenci.KayitTarihi;
        List<DateTime> BorcluAylar;

        public void VeriYenile(string secilenUye)//Yapılmış ödemelerin  listelenmesi için kullanılan fonksiyondur
        {
            datagYapilmis.ClearSelection();//datagVerideki önceki verileri temizleme
            datagYapilmis.DataSource = Baglanti.DataTableGetir("Select YatakHareket.HareketID,YatakHareket.YatakID,Odemeler.OdenenAy,Odemeler.OdemeTutari,Odemeler.OdemeTuru FROM Odemeler Left JOIN YatakHareket ON Odemeler.HareketID = YatakHareket.HareketID where YatakHareket.OgrenciID=" + secilenUye);//veritabanından çekilen verileri datagYapilmis isimli datagridviewe aktarıyoruz


            datagYapilmis.AllowUserToAddRows = false;//datagridviewde son satıra gelen boş satırı gizleme kodu


        }
        public void BorcTespit(string secilenUye, DateTime kayitTarihi)//Borc tespit fonksiyonu
        {
            try
            {
                VeriYenile(secilenUye);

                DateTime tarih = kayitTarihi;
                tarih = Convert.ToDateTime("01." + tarih.Month + "." + tarih.Year);



                while (tarih < DateTime.Now)
                {
                    bool OdenmisMi = false;
                    if (datagYapilmis.Rows.Count > 0)
                    {
                        for (int i = 0; i < datagYapilmis.Rows.Count; i++)
                        {
                            DateTime odenenTarih = Convert.ToDateTime(datagYapilmis.Rows[i].Cells[2].Value);
                            if (odenenTarih.Month == tarih.Month && odenenTarih.Year == tarih.Year)
                            {
                                OdenmisMi = true;

                            }
                        }
                        if (OdenmisMi == false)
                        {
                            BorcluAylar.Add(tarih);//boclu olan ayları listeye alma
                        }
                    }
                    else
                    {
                        BorcluAylar.Add(tarih);
                    }
                    tarih = tarih.AddMonths(1);
                }



            }
            catch (Exception)
            {

                //MessageBox.Show("Ögrenciye önce yatak atamalısınız");//Kullanıcıya mesaj gösterme
                //frmOgrenci frm2 = new frmOgrenci();

                //frm2.Show();
                //this.Close();
            }


        }
        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            frmAna frm2 = new frmAna();//ana formun açılması
            this.Hide();
            frm2.Show();
        }



        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmAna frm2 = new frmAna();//ana formun açılması
            this.Hide();
            frm2.Show();
        }
        public void BorcYenile()
        {
            DataTable table = new DataTable();//sanal bir tablo oluşturma
            table.Columns.Add("ÖğrenciID", typeof(string));
            table.Columns.Add("Adı", typeof(string));
            table.Columns.Add("Soyadı", typeof(string));
            table.Columns.Add("Ay-Yıl", typeof(string));

            table.Columns.Add("Tutar", typeof(string));
            table.Columns.Add("Telefon", typeof(string));
            table.Columns.Add("Yatak", typeof(string));
            table.Columns.Add("Fotograf", typeof(string));
          
            BorcluAylar = new List<DateTime>();

            dataGridView1.DataSource = Baglanti.DataTableGetir("Select Ogrenciler.OgrenciID, Yataklar.Fiyat, Ogrenciler.OgrenciAdi, Ogrenciler.OgrenciSoyadi,Ogrenciler.KayitTarihi,Ogrenciler.OgrenciTelefon,Yataklar.YatakID,Ogrenciler.Fotograf FROM Yataklar Left JOIN YatakHareket ON Yataklar.YatakID = YatakHareket.YatakID  LEFT JOIN Ogrenciler ON  YatakHareket.OgrenciID = Ogrenciler.OgrenciID WHERE YatakHareket.Durum=1");//veritabanından çekilen verileri dataGridView1 isimli datagridviewe aktarıyoruz
            dataGridView1.AllowUserToAddRows = false;//datagridviewde son satıra gelen boş satırı gizleme kodu
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                BorcTespit(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value));




                foreach (DateTime item in BorcluAylar)
                {
                    table.Rows.Add(dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(), item.ToString("MM.yyyy"), dataGridView1.Rows[i].Cells[1].Value.ToString(), dataGridView1.Rows[i].Cells[5].Value.ToString(), dataGridView1.Rows[i].Cells[6].Value.ToString(), dataGridView1.Rows[i].Cells[7].Value.ToString());

                }
                BorcluAylar.Clear();
            }

            dataGVeri.DataSource = table;
            dataGVeri.Columns[7].Visible = false;
            dataGVeri.AllowUserToAddRows = false;
        }


        private void frmAlacaklar_Load(object sender, EventArgs e)
        {
            pbOgrenci.ImageLocation = Application.StartupPath + @"\Resimler\ogrenci.png";

            BorcYenile();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();//sanal bir tablo oluşturma
            table.Columns.Add("ÖğrenciID", typeof(string));
            table.Columns.Add("Adı", typeof(string));
            table.Columns.Add("Soyadı", typeof(string));
            table.Columns.Add("Ay-Yıl", typeof(string));

            table.Columns.Add("Tutar", typeof(string));
            table.Columns.Add("Telefon", typeof(string));
            table.Columns.Add("Yatak", typeof(string));
            table.Columns.Add("Fotograf", typeof(string));
           


            BorcluAylar = new List<DateTime>();

            dataGridView1.DataSource = Baglanti.DataTableGetir("Select Ogrenciler.OgrenciID, Yataklar.Fiyat, Ogrenciler.OgrenciAdi, Ogrenciler.OgrenciSoyadi,Ogrenciler.KayitTarihi,Ogrenciler.OgrenciTelefon,Yataklar.YatakID,Ogrenciler.Fotograf FROM Yataklar Left JOIN YatakHareket ON Yataklar.YatakID = YatakHareket.YatakID  LEFT JOIN Ogrenciler ON  YatakHareket.OgrenciID = Ogrenciler.OgrenciID WHERE YatakHareket.Durum=1");//veritabanından çekilen verileri dataGridView1 isimli datagridviewe aktarıyoruz
            dataGridView1.AllowUserToAddRows = false;//datagridviewde son satıra gelen boş satırı gizleme kodu
     
            DateTime baslangicT = Convert.ToDateTime("01." + dtBaslangic.Value.Month + "." + dtBaslangic.Value.Year);
            DateTime bitisT = Convert.ToDateTime("01." + dtBitis.Value.Month + "." + dtBitis.Value.Year);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                BorcTespit(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value));




                foreach (DateTime item in BorcluAylar)
                {

                    if (item >= baslangicT && item <= bitisT)
                    {
                        table.Rows.Add(dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[2].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(), item.ToString("MM.yyyy"), dataGridView1.Rows[i].Cells[1].Value.ToString(), dataGridView1.Rows[i].Cells[5].Value.ToString(), dataGridView1.Rows[i].Cells[6].Value.ToString(), dataGridView1.Rows[i].Cells[7].Value.ToString());
                    }
                }
                BorcluAylar.Clear();
            }

            dataGVeri.DataSource = table;
            dataGVeri.Columns[7].Visible = false;
            dataGVeri.AllowUserToAddRows = false;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            pbOgrenci.ImageLocation = Application.StartupPath + @"\Resimler\ogrenci.png";
            BorcYenile();
        }

        private void dataGVeri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pbOgrenci.ImageLocation = Application.StartupPath + @"\Resimler\" + dataGVeri.CurrentRow.Cells[7].Value.ToString();//datagridviewde seçilen satırdaki ögrencinin resmini gösterme
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
                    using (FileStream stream = new FileStream(folderPath + "Ogrenci-Alacaklar.pdf", FileMode.Create))
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
    }
}
