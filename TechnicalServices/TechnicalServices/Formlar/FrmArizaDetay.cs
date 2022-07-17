using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalServices.Formlar
{
    public partial class FrmArizaDetay : Form
    {
        public FrmArizaDetay()
        {
            InitializeComponent();
        }

        private void FrmArizaDetay_Load(object sender, EventArgs e)
        {

        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();


        private void BtnEkle_Click(object sender, EventArgs e)
        {
            tbl_UrunTakip t = new tbl_UrunTakip();
            t.ACIKLAMA = richTextBox1.Text;
            t.SERINO = TxtSeriNo.Text;
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            db.tbl_UrunTakip.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün arıza detayları güncellendi");


        }
    }
}
