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
    public partial class frmIzinler : Form
    {
        public frmIzinler()
        {
            InitializeComponent();
        }
        public void VeriYenile(string sqlcumle)//ögrencileri veritabanından çekmek için kullandığımız fonksiyondur
        {
            dataGVeri.ClearSelection();//datagVerideki önceki verileri temizleme
            dataGVeri.DataSource = Baglanti.DataTableGetir(sqlcumle);//veritabanından çekilen veriler dataGVeri isimli datagridviewe aktarıyoruz

            dataGVeri.Columns[0].HeaderText = "Ögrenci ID";// datagridviewdeki Sütunlara anlayaçağımız şekilde isimler veriyoruz
            dataGVeri.Columns[1].HeaderText = "Adı";
            dataGVeri.Columns[2].HeaderText = "Soyadı";
            dataGVeri.Columns[3].Visible = false; //datagridviewdeki gözükmesini istemediğimiz sütunları gizliyoruz
            dataGVeri.Columns[4].HeaderText = "Baslanğıç Tarihi";
            dataGVeri.Columns[5].HeaderText = "Bitis Tarihi";
            dataGVeri.Columns[6].HeaderText = "Gidilen Adres"; 
           dataGVeri.Columns[7].HeaderText = "Sorumlu Telefon";
           
            dataGVeri.AllowUserToAddRows = false;//datagridviewde son satıra gelen boş satırı gizleme kodu


        }
        private void frmIzinler_Load(object sender, EventArgs e)
        {
            pbOgrenci.ImageLocation = Application.StartupPath + @"\Resimler\ogrenci.png";
            VeriYenile("Select Ogrenciler.OgrenciID,Ogrenciler.OgrenciAdi, Ogrenciler.OgrenciSoyadi, Ogrenciler.Fotograf, Izinler.BaslangicTarihi, Izinler.BitisTarihi,Izinler.GidilenAdres,Izinler.SorumluTelefon FROM Ogrenciler Inner JOIN Izinler ON Ogrenciler.OgrenciID = Izinler.OgrenciID");
        }

        private void dataGVeri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pbOgrenci.ImageLocation = Application.StartupPath + @"\Resimler\" + dataGVeri.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string sqlcumle = "Select Ogrenciler.OgrenciID,Ogrenciler.OgrenciAdi, Ogrenciler.OgrenciSoyadi, Ogrenciler.Fotograf, Izinler.BaslangicTarihi, Izinler.BitisTarihi,Izinler.GidilenAdres,Izinler.SorumluTelefon FROM Ogrenciler Inner JOIN Izinler ON Ogrenciler.OgrenciID = Izinler.OgrenciID where ";//arama yapmak için kullanıyoruz
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
                    sqlcumle += " Ogrenciler.OgrenciSoyadi = '" + txtSoyadi.Text + "'";//sqlcumleye aramada OgrenciSoyadi da eklendi
                    listelemeSecim = true;
                }
                else//eğer yukarıda ögrenciAdi dolu ise
                {
                    sqlcumle += " and Ogrenciler.OgrenciSoyadi = '" + txtSoyadi.Text + "'";

                }
            }
           

            if (listelemeSecim == false)//hiçbir şey yazılmadan arama yapıldıysa
            {
                sqlcumle = "Select Ogrenciler.OgrenciID,Ogrenciler.OgrenciAdi, Ogrenciler.OgrenciSoyadi, Ogrenciler.Fotograf, Izinler.BaslangicTarihi, Izinler.BitisTarihi,Izinler.GidilenAdres,Izinler.SorumluTelefon FROM Ogrenciler Inner JOIN Izinler ON Ogrenciler.OgrenciID = Izinler.OgrenciID";
            }

            VeriYenile(sqlcumle);//sqlcumleye göre verileri yeniler

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmAna frm = new frmAna();//ana formu açar
            frm.Show();
            this.Hide();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();//textboxı temizler
            txtSoyadi.Clear();
            pbOgrenci.ImageLocation = Application.StartupPath + @"\Resimler\ogrenci.png";
            VeriYenile("Select Ogrenciler.OgrenciID,Ogrenciler.OgrenciAdi, Ogrenciler.OgrenciSoyadi, Ogrenciler.Fotograf, Izinler.BaslangicTarihi, Izinler.BitisTarihi,Izinler.GidilenAdres,Izinler.SorumluTelefon FROM Ogrenciler Inner JOIN Izinler ON Ogrenciler.OgrenciID = Izinler.OgrenciID");
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
                    using (FileStream stream = new FileStream(folderPath + "izinler.pdf", FileMode.Create))
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
