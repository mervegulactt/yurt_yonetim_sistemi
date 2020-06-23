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
    public partial class frmYeniYatak : Form
    {
        public frmYeniYatak()
        {
            InitializeComponent();
        }
        int OdaID = frmOda.OdaID;
        private void frmYeniYatak_Load(object sender, EventArgs e)
        {
            if (OdaID == 0)
            {

                MessageBox.Show("Önce oda seçiniz");//kullanıcıya mesaj verme
                this.Close();
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtYatakBirimFiyat.Text)) && !(string.IsNullOrEmpty(txtYatakSayisi.Text)))// textboxlara değer girildi mi kontrol etme
            {
                DataRow dataRow = Baglanti.DataRowGetir("Select * from Odalar where OdaID=" + OdaID);
                int YatakSayisi = Convert.ToInt32(dataRow[2].ToString());
                YatakSayisi += Convert.ToInt32(txtYatakSayisi.Text);

                Baglanti.idu("update Odalar set YatakSayisi = '" + YatakSayisi + "' where OdaID = " + OdaID + "");//yarak eklenen odadaki yatak sayısını arttırma
                int a = 0;
                for (int i = 0; i < YatakSayisi; i++)//eklenen yatak sayısı kadar insert gerçekleştirme
                {
                    if (Baglanti.idu("insert into Yataklar(OdaID,Fiyat) values ('" + OdaID + "','" + txtYatakBirimFiyat.Text + "')") > 0)//yatağı veritabanına kaydetme
                    {
                        a++;
                    }

                }
                if (a == YatakSayisi)
                {
                    MessageBox.Show("Yatak ekleme başarılı");//kullanıcıya mesaj verme
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Tüm alanlar dolu olmalıdır");//kullanıcıya mesaj verme
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();//formu kapatma
        }
    }
}
