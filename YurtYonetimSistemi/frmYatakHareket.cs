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
    public partial class frmYatakHareket : Form
    {
        public frmYatakHareket()
        {
            InitializeComponent();
        }
        public void VeriYenile(string sqlcumle)//ögrencileri veritabanından çekmek için kullandığımız fonksiyondur
        {
            dataGVeri.ClearSelection();//datagVerideki önceki verileri temizleme
            dataGVeri.DataSource = Baglanti.DataTableGetir(sqlcumle);//veritabanından çekilen veriler dataGVeri isimli datagridviewe aktarıyoruz

            dataGVeri.Columns[0].HeaderText = "Öğrenci ID";// datagridviewdeki Sütunlara anlayaçağımız şekilde isimler veriyoruz
            dataGVeri.Columns[1].HeaderText = "Adı";
            dataGVeri.Columns[2].HeaderText = "Soyadı";
            dataGVeri.Columns[3].HeaderText = "Durum";
         

            dataGVeri.AllowUserToAddRows = false;//datagridviewde son satıra gelen boş satırı gizleme kodu


        }
        private void frmYatakHareket_Load(object sender, EventArgs e)
        {
            VeriYenile("Select Ogrenciler.OgrenciID,Ogrenciler.OgrenciAdi, Ogrenciler.OgrenciSoyadi, YatakHareket.Durum FROM Ogrenciler Inner JOIN YatakHareket ON Ogrenciler.OgrenciID = YatakHareket.OgrenciID where YatakHareket.YatakID="+frmOda.YatakID);
            //Verileri çekme
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();//formu kapatma
        }
    }
}
