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
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            frmOgrenci frm2 = new frmOgrenci(); //frmOgrenci formunu açar
         
            frm2.Show();
            this.Hide();

        }

        private void frmAna_Load(object sender, EventArgs e)
        {
            pbArkaplan.ImageLocation = Application.StartupPath + @"\Resimler\arkaplan.png"; //form ekranına arkaplan resmi atma

            
        }

        private void btnOda_Click(object sender, EventArgs e)
        {
            frmOda frm2 = new frmOda();//frmOda formunu açar
            this.Hide();
            frm2.Show();

        }

        private void btnIzinler_Click(object sender, EventArgs e)
        {
            frmIzinler frm2 = new frmIzinler(); //frmIzinler formunu açar
            this.Hide();
            frm2.Show();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            frmTumOdemeler frm2 = new frmTumOdemeler();//frmTumOdemeler formunu açar
            this.Hide();
            frm2.Show();
        }

        private void btnGirisCikis_Click(object sender, EventArgs e)
        {
            frmGirisCikis frm2 = new frmGirisCikis();//frmGirisCikis formunu açar
            this.Hide();
            frm2.Show();
        }

        private void btnAlacaklar_Click(object sender, EventArgs e)
        {
            frmAlacaklar frm2 = new frmAlacaklar();//frmGirisCikis formunu açar
            this.Hide();
            frm2.Show();
        }
    }
}
