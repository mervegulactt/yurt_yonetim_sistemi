
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
    public partial class frmOda : Form
    {
        public frmOda()
        {
            InitializeComponent();
        }
        public static int OdaID = 0;
        public static int YatakID = 0;
        public static bool YatakDurum = false;

        public void OdaVeriYenile(string sqlcumle)//oda veirlerini veritabanından çekmek için kullandığımız fonksiyondur
        {
            datagOda.ClearSelection();//datagVerideki önceki verileri temizleme
            datagOda.DataSource = Baglanti.DataTableGetir(sqlcumle);//veritabanından çekilen veriler datagOda isimli datagridviewe aktarıyoruz

            datagOda.Columns[0].HeaderText = "ID";// datagridviewdeki Sütunlara anlayaçağımız şekilde isimler veriyoruz
            datagOda.Columns[1].HeaderText = "Kat";
            datagOda.Columns[2].HeaderText = "Yatak Sayısı";
            datagOda.Columns[0].Width = 232;// datagridviewdeki Sütunlara genişlik değeri atıyoruz
            datagOda.Columns[1].Width = 232;
            datagOda.Columns[2].Width = 232;
            datagOda.AllowUserToAddRows = false;//datagridviewde son satıra gelen boş satırı gizleme kodu


        }
        public void YatakVeriYenile(string sqlcumle)
        {
            datagYatak.ClearSelection();//datagVerideki önceki verileri temizleme
            datagYatak.DataSource = Baglanti.DataTableGetir(sqlcumle);//veritabanından çekilen yatak verileri datagYatak isimli datagridviewe aktarıyoruz

            datagYatak.Columns[0].HeaderText = "ID";// datagridviewdeki Sütunlara anlayaçağımız şekilde isimler veriyoruz
            datagYatak.Columns[1].HeaderText = "Oda";
            datagYatak.Columns[2].HeaderText = "Fiyat";

            datagYatak.Columns[0].Width = 232;// datagridviewdeki Sütunlara genişlik değeri atıyoruz
            datagYatak.Columns[1].Width = 232;
            datagYatak.Columns[2].Width = 232;
            datagYatak.AllowUserToAddRows = false;//datagridviewde son satıra gelen boş satırı gizleme kodu

            for (int a = 0; a < datagYatak.Rows.Count; a++)//tüm datagridviewdeki satırları yeşilin bir tonuna boyuyoruz
            {
                datagYatak.Rows[a].DefaultCellStyle.BackColor = Color.MediumAquamarine;
            }

            dt.DataSource = Baglanti.DataTableGetir("select * from YatakHareket");//yatakhareketler tablosunun verilerini veritabanından çekiyoruz
            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                if ((bool)dt.Rows[i].Cells[3].Value == true)//eğer YatakHareket tablosunda bir yatak için true alan var ise o yatak doludur 
                {
                    for (int j = 0; j < datagYatak.Rows.Count; j++)
                    {
                        if (dt.Rows[i].Cells[1].Value.ToString() == datagYatak.Rows[j].Cells[0].Value.ToString())
                        {
                            datagYatak.Rows[j].DefaultCellStyle.BackColor = Color.Gainsboro;// dolun olan yatağın olduğu satırı grinin bir tonuna boyuyoruz
                        }
                    }
                }
            }

        }

        private void frmOda_Load(object sender, EventArgs e)
        {
            OdaVeriYenile("Select * from Odalar");//tüm odaları datagridviewe çeker
            YatakVeriYenile("SELECT * from Yataklar");//tüm yatakları datagridviewe çeker
        }
        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            frmAna frm2 = new frmAna();//frmAna formunu açar
            this.Hide();
            frm2.Show();
        }

        private void btnYeniOda_Click(object sender, EventArgs e)
        {
            frmYeniOda frm2 = new frmYeniOda();//frmYeniOda formunu açar

            frm2.Show();
        }

        private void btnOdaYenile_Click(object sender, EventArgs e)
        {
            OdaVeriYenile("Select * from Odalar");//tüm odaları datagridviewe çeker
            txtOdaKat.Clear();
        }
        private void btnYatakYenile_Click(object sender, EventArgs e)
        {
            YatakVeriYenile("SELECT * from Yataklar");//tüm yatakları datagridviewe çeker
            txtYatakOda.Clear();
        }

        private void btnYeniYatak_Click(object sender, EventArgs e)
        {
            if (frmOda.OdaID != 0)//eğer bir yatak seçildiyse
            {
                frmYeniYatak frm2 = new frmYeniYatak();//frmYeniYatak formunu açar

                frm2.Show();
            }
            else
            {
                MessageBox.Show("Önce oda seçiniz");//kullanıcıya mesaj gösterme
            }
        }

        private void datagOda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OdaID = Convert.ToInt32(datagOda.CurrentRow.Cells[0].Value);//seçilen satırdaki OdaID değerini alma

            YatakVeriYenile("Select * from Yataklar where OdaID = " + OdaID);//seçilen odadaki yatakları listeleme

        }

        private void datagYatak_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                YatakID = Convert.ToInt32(datagYatak.CurrentRow.Cells[0].Value);//seçilen satırdaki YatakID değerini alma
                if (datagYatak.CurrentRow.DefaultCellStyle.BackColor == Color.MediumAquamarine)//yatagın dolu mu boş mu oldugunu anlama
                {

                    YatakDurum = false;
                }
                else if (datagYatak.CurrentRow.DefaultCellStyle.BackColor == Color.Gainsboro)//yatagın dolu mu boş mu oldugunu anlama
                {

                    YatakDurum = true;
                }
            }
            catch (Exception)
            {

              
            }
           
        }

        private void btnOgrenciYatır_Click(object sender, EventArgs e)
        {
            if(YatakID==0)//yatak seçilmemişse çalışır 
            {
                MessageBox.Show("Önce boş bir yatak şeçiniz.");//kullanıcıya mesaj gösterme
            }
            else if(YatakDurum==true)// yatak boş mu diye kontrol eder
            {
                MessageBox.Show("Seçilen yatak boş değildir.");//kullanıcıya mesaj gösterme
            }
            else
            {
                frmOgrenciYatir frm2 = new frmOgrenciYatir();// frmOgrenciYatir formunu açar

                frm2.Show();
                this.Hide();
            }
        }

        private void btnYatakHareket_Click(object sender, EventArgs e)
        {
            if (YatakID != 0)//yatak seçilmiş ise çalışır 
            {
                frmYatakHareket frm2 = new frmYatakHareket();// frmYatakHareket formunu açar

                frm2.Show();
               
            }
           else
            {
                MessageBox.Show("Önce yatak şeçiniz.");//kullanıcıya mesaj gösterme
            }
              
         
        }

        private void btnYatakListele_Click(object sender, EventArgs e)
        {

            string sqlcumle = "SELECT* from Yataklar where ";//yatak arama için kullanılır
            bool listelemeSecim = false;
            if (!string.IsNullOrEmpty(txtYatakOda.Text))//txtOda değeri doluysa aramda kullanılır
            {
                sqlcumle += " OdaID = '" + txtYatakOda.Text + "'";//aramada txtOda dahil olur
                listelemeSecim = true;
            }
           
         
            if (listelemeSecim == false)// hicbir aranacak deger girilmediyse bütün veriler çekilir
            {
                sqlcumle = "SELECT* from Yataklar";
            }

            YatakVeriYenile(sqlcumle);//verileri çekme

        }

        private void btnOdaListele_Click(object sender, EventArgs e)
        {
            string sqlcumle = "Select* from Odalar where ";//Odalar arama için kullanılır
            bool listelemeSecim = false;
            if (!string.IsNullOrEmpty(txtOdaKat.Text))//txtOdaKat değeri doluysa aramda kullanılır
            {
                sqlcumle += " Kat = '" + txtOdaKat.Text + "'";//txtOdaKat txtOda dahil olur
                listelemeSecim = true;
            }


            if (listelemeSecim == false)// hicbir aranacak deger girilmediyse bütün veriler çekilir
            {
                sqlcumle = "SELECT* from Odalar";
            }

            OdaVeriYenile(sqlcumle);//verileri çekme
        }

        private void btnPdfAktar_Click(object sender, EventArgs e)
        {
          
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Kat", typeof(string));
            table.Columns.Add("Yatak Fiyat", typeof(string));
           
            for (int i = 0; i< datagYatak.Rows.Count; i++)
            {
               if(datagYatak.Rows[i].DefaultCellStyle.BackColor == Color.MediumAquamarine)
                {
                    table.Rows.Add(datagYatak.Rows[i].Cells[0].Value.ToString(), datagYatak.Rows[i].Cells[1].Value.ToString(), datagYatak.Rows[i].Cells[2].Value.ToString());
                }
            }
        
            datagBosYatak.DataSource = table;
            datagBosYatak.AllowUserToAddRows = false;
            //pdf kaydetme kodları

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Pdf'in kaydedileceği yeri aşağıdan seçiniz";
            dialog.RootFolder = Environment.SpecialFolder.Desktop;

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                //Creating iTextSharp Table from the DataTable data
                PdfPTable pdfTable = new PdfPTable(datagBosYatak.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 30;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;

                //header rowlarını ekleme
                foreach (DataGridViewColumn column in datagBosYatak.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                //datarowlarını ekler
                foreach (DataGridViewRow row in datagBosYatak.Rows)
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
                using (FileStream stream = new FileStream(folderPath + "bos_yataklar.pdf", FileMode.Create))
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
    }
}
