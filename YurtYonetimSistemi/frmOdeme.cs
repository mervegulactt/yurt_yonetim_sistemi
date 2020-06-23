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
    public partial class frmOdeme : Form
    {
        public frmOdeme()
        {
            InitializeComponent();
        }
        string secilenUye = frmOgrenci.secilenUye;
        DateTime kayitTarihi = frmOgrenci.KayitTarihi;
        List<DateTime> BorcluAylar;
        DateTime KaydedilecekOdemeAyi;
        bool secim = false;
        public void VeriYenile()//Yapılmış ödemelerin  listelenmesi için kullanılan fonksiyondur
        {
            datagYapilmis.ClearSelection();//datagVerideki önceki verileri temizleme
            datagYapilmis.DataSource = Baglanti.DataTableGetir("Select YatakHareket.HareketID,YatakHareket.YatakID,Odemeler.OdenenAy,Odemeler.OdemeTutari,Odemeler.OdemeTuru FROM Odemeler Left JOIN YatakHareket ON Odemeler.HareketID = YatakHareket.HareketID where YatakHareket.OgrenciID=" + secilenUye);//veritabanından çekilen verileri datagYapilmis isimli datagridviewe aktarıyoruz


            datagYapilmis.AllowUserToAddRows = false;//datagridviewde son satıra gelen boş satırı gizleme kodu

            dataGridView1.DataSource = Baglanti.DataTableGetir("Select YatakHareket.OgrenciID, Yataklar.Fiyat,YatakHareket.HareketID FROM Yataklar Left JOIN YatakHareket ON Yataklar.YatakID = YatakHareket.YatakID where YatakHareket.Durum=1 and  YatakHareket.OgrenciID = " + secilenUye);//veritabanından çekilen verileri dataGridView1 isimli datagridviewe aktarıyoruz
            dataGridView1.AllowUserToAddRows = false;//datagridviewde son satıra gelen boş satırı gizleme kodu
        }
        public void BorcTespit()//Borc tespit fonksiyonu
        {
            try
            {
                DateTime tarih = kayitTarihi;
                tarih = Convert.ToDateTime("01." + tarih.Month + "." + tarih.Year);

                BorcluAylar = new List<DateTime>();
                BorcluAylar.Clear();
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


                DataTable table = new DataTable();//sanal bir tablo oluşturma
                table.Columns.Add("Yatak", typeof(string));
                table.Columns.Add("Ay", typeof(string));
                table.Columns.Add("Yıl", typeof(string));
                table.Columns.Add("Tutar", typeof(string));


                foreach (DateTime item in BorcluAylar)
                {
                    table.Rows.Add(dataGridView1.Rows[0].Cells[0].Value.ToString(), item.Month, item.Year, dataGridView1.Rows[0].Cells[1].Value.ToString());

                }
                datagBorc.DataSource = table;
                datagBorc.AllowUserToAddRows = false;
            }
            catch (Exception)
            {

                MessageBox.Show("Ögrenciye önce yatak atamalısınız");//Kullanıcıya mesaj gösterme
                frmOgrenci frm2 = new frmOgrenci();
             
                frm2.Show();
                this.Close();
            }
           

        }
        private void frmOdeme_Load(object sender, EventArgs e)
        {
            VeriYenile();//tüm verileri yenileme
            BorcTespit();//borc tespitinin yapılması
            
        }

        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            frmAna frm2 = new frmAna();//ana formun açılması
            this.Hide();
            frm2.Show();
        }

        private void datagBorc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KaydedilecekOdemeAyi = Convert.ToDateTime("01." + datagBorc.CurrentRow.Cells[1].Value.ToString() + "." + datagBorc.CurrentRow.Cells[2].Value.ToString());//Datagriviewden seçilen borcun tarihini alma
            secim = true;
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (secim == true)
            {
                if(cbOdemeTuru.SelectedItem!=null)
                { 
                if (Baglanti.idu("insert into Odemeler(HareketID,OdenenAy,OdemeTutari,OdemeTuru) values ('" + dataGridView1.Rows[0].Cells[2].Value.ToString() + "','" + KaydedilecekOdemeAyi.ToString("MM.dd.yyyy HH:mm") + "','" + dataGridView1.Rows[0].Cells[1].Value.ToString() + "','" + cbOdemeTuru.SelectedItem.ToString() + "')") > 0)//ödemeyi gerçekleştirme
                {
                    MessageBox.Show("Ödeme Başarılı");//kullanıcıya mesaj gösterme

                    VeriYenile();//tüm verilerin yenilenmesi
                    BorcTespit();//borcun tespiti
                        secim = false;
                        cbOdemeTuru.SelectedItem = null;
                }
                }
                else
                { MessageBox.Show("Ödeme Türü giriniz");}//kullanıcıya mesaj gösterme
            }
            else
            {
                MessageBox.Show("Ödenecek borcu seçiniz");//kullanıcıya mesaj gösterme
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmOgrenci frm2 = new frmOgrenci();//frmOda formunu açma
            this.Hide();
            frm2.Show();
        }
    }
}
