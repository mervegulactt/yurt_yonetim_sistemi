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
    public partial class frmYeniOda : Form
    {
        public frmYeniOda()
        {
            InitializeComponent();
        }
        private void frmYeniOda_Load(object sender, EventArgs e)
        {

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtKat.Text))//txtKat textbox'ına veri girildiyse çalışır
            { 
            if (Baglanti.idu("insert into Odalar(Kat,YatakSayisi) values ('" + txtKat.Text + "','" +  "0" + "')") > 0)//yeni odayı veritabanına kaydetme
            {
                MessageBox.Show("Kayit Başarılı");//kullanıcıya mesaj verme


                this.Close();//formu kapatma

            }
            }
            else
            {
                MessageBox.Show("Kat alanı dolu olmalıdır");//kullanıcıya mesaj verme
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();//formu kapatma
        }

       
    }
}
