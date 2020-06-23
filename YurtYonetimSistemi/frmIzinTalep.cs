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
    public partial class frmIzinTalep : Form
    {
        public frmIzinTalep()
        {
            InitializeComponent();
        }
        string secilenUye = frmOgrenci.secilenUye;
        public void VeriYenile(string sqlcumle)//ögrencileri veritabanından çekmek için kullandığımız fonksiyondur
        {
            dataGVeri.ClearSelection();//datagridview temizleme
            dataGVeri.DataSource = Baglanti.DataTableGetir(sqlcumle);//veritabanından çekilen veriler dataGVeri isimli datagridviewe aktarıyoruz


            dataGVeri.AllowUserToAddRows = false;//datagridviewde son satıra gelen boş satırı gizleme kodu


        }

        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            frmAna frm2 = new frmAna();//ana formu açar
            this.Hide();
            frm2.Show();
        }

        private void frmIzinTalep_Load(object sender, EventArgs e)
        {
            VeriYenile("Select OgrenciID,OgrenciAdi,OgrenciSoyadi,OgrenimTuru,KayitTarihi,OgrenciTelefon,VeliTelefon,Durum,Fotograf from Ogrenciler where OgrenciID= " + secilenUye);//seçilen ögrenci bilgilerini veritabanından çekme


            lblAdSoyad.Text = dataGVeri.Rows[0].Cells[1].Value.ToString() + " " + dataGVeri.Rows[0].Cells[2].Value.ToString(); // labele seçilen ögrenci ad soyadını yazdırma
            pbOgrenci.ImageLocation = Application.StartupPath + @"\Resimler\" + dataGVeri.Rows[0].Cells[8].Value.ToString();//seçilen ögrenci resmini gösterme
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtGidilenAdres.Text)) && !(string.IsNullOrEmpty(txtSorumluTelefon.Text)))//bütün alarlar doldurulduysa
            {


                if (dtBitisTarihi.Value > dtBaslangicTarihi.Value)//bitis tarihi, başlangic tarihinden büyük olmalıdır
                {
                    if (Baglanti.idu("insert into Izinler(OgrenciID,BaslangicTarihi,BitisTarihi,GidilenAdres,SorumluTelefon) values ('" + secilenUye + "','" + dtBaslangicTarihi.Value.ToString("MM.dd.yyyy HH:mm") + "','" + dtBitisTarihi.Value.ToString("MM.dd.yyyy HH:mm") + "','" + txtGidilenAdres.Text + "','" + txtSorumluTelefon.Text + "')") > 0)//veritabanına izni kaydetme
                    {
                        MessageBox.Show("Kayit Başarılı");//kullanıcıya mesaj gösterme
                        frmIzinler frm2 = new frmIzinler();//frmIzinler formunu açma kodları
                        this.Hide();
                        frm2.Show();



                    }
                }
                else
                {
                    MessageBox.Show("İzin bitiş tarihi, izin başlanğıç tarihinden büyük olmalıdır");//kullanıcıya mesaj gösterme
                }
            }
            else
            {
                MessageBox.Show("Tüm alanlar dolu olmalıdır");//kullanıcıya mesaj gösterme
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmOgrenci frm2 = new frmOgrenci();//frmOgrenci formunu açma kodları
            this.Hide();
            frm2.Show();
        }
    }
}
