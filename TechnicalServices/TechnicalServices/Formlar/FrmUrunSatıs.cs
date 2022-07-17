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
    public partial class FrmUrunSatıs : Form
    {
        public FrmUrunSatıs()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void BtnSatısYap_Click(object sender, EventArgs e)
        {
            tbl_UrunHareket t = new tbl_UrunHareket();
            t.URUN = int.Parse(TxtUrunAd.Text);
            t.MUSTERI = int.Parse(TxtMusteri.Text);
            t.PERSONEL = short.Parse(TxtPersonel.Text);
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            t.ADET = short.Parse(TxtAdet.Text);
            t.FIYAT = decimal.Parse(TxtSatısFiyatı.Text);
            db.tbl_UrunHareket.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi");
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            FrmUrunSatıs fr = new FrmUrunSatıs();
            fr.Hide();
        }
    }
}
