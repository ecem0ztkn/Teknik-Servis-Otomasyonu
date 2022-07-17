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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        void metot1()
        {
            var degerler = from u in db.tbl_FaturaDetay
                           select new
                           {
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID,
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            tbl_FaturaDetay t = new tbl_FaturaDetay();
            t.URUN = TxtUrun.Text;
            t.ADET = short.Parse(TxtAdet.Text);
            t.FIYAT = decimal.Parse(TxtFiyat.Text);
            t.TUTAR = decimal.Parse(TxtTutar.Text);
            t.FATURAID = int.Parse(TxtFatura.Text);
            db.tbl_FaturaDetay.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Sisteme Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            metot1();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }
    }
}
