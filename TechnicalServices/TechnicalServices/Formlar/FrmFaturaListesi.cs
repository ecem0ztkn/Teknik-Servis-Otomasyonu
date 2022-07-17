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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }

        void metot1()
        {
            var degerler = from u in db.tbl_FaturaBilgi
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRESI,
                               Cari = u.tbl_Cari.AD + u.tbl_Cari.SOYAD,
                               Personel = u.tbl_Personel.AD + u.tbl_Personel.SOYAD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {

            metot1();
            TxtCari.Properties.DataSource = (from x in db.tbl_Cari
                                             select new
                                             {
                                                 x.AD,
                                                 x.ID
                                             }).ToList();

            TxtPersonel.Properties.DataSource = (from x in db.tbl_Cari
                                             select new
                                             {
                                                 x.AD,
                                                 x.ID
                                             }).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            tbl_FaturaBilgi t = new tbl_FaturaBilgi();
            t.ID = int.Parse(TxtID.Text);
            t.SERI = TxtSeriNo.Text;
            t.SIRANO = TxtSıraNo.Text;
            t.TARIH = Convert.ToDateTime(TxtTarih.Text);
            t.SAAT = TxtSıraNo.Text;
            t.VERGIDAIRESI = TxtVergiDairesi.Text;
            t.CARI = int.Parse(TxtCari.EditValue.ToString());
            t.PERSONEL = short.Parse(TxtPersonel.EditValue.ToString());
            db.tbl_FaturaBilgi.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Sisteme Başarıyla Kaydedildi. Kalem girişi yapabilirsiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            metot1();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.tbl_FaturaBilgi.Find(id);
            deger.ID = int.Parse(TxtID.Text);
            deger.SERI = TxtSeriNo.Text;
            deger.SIRANO = TxtSıraNo.Text;
            deger.TARIH = Convert.ToDateTime(TxtTarih.Text);
            deger.SAAT = TxtSıraNo.Text;
            deger.VERGIDAIRESI = TxtVergiDairesi.Text;
            deger.CARI = int.Parse(TxtCari.EditValue.ToString());
            deger.PERSONEL = short.Parse(TxtPersonel.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
