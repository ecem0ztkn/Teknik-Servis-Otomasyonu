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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void metot1()
        {
            var degerler = from u in db.tbl_Urun
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.MARKA,
                               kategori = u.tbl_Kategori.AD,
                               u.ALISFIYATI,
                               u.SATISFIYATI,
                               u.STOK,
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            //var degerler = db.tbl_Urun.ToList();
            metot1();
            TxtKategori.Properties.DataSource = db.tbl_Kategori.ToList() ;
            
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            tbl_Urun t = new tbl_Urun();
            t.AD = TxtUrunAd.Text;
            t.MARKA = TxtMarka.Text;    
            t.SATISFIYATI = decimal.Parse( TxtSatisFiyat.Text);
            t.ALISFIYATI =decimal.Parse( TxtAlisFiyat.Text);
            t.STOK =short.Parse( TxtStok.Text);
            t.KATEGORI = byte.Parse(TxtKategori.EditValue.ToString());
            db.tbl_Urun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            TxtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYATI").ToString();
            TxtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYATI").ToString();
            TxtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.tbl_Urun.Find(id);
            db.tbl_Urun.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Bir Ürün Sildiniz  ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.tbl_Urun.Find(id);
            deger.AD = TxtUrunAd.Text;   
            deger.STOK = short.Parse(TxtStok.Text);
            deger.MARKA = TxtMarka.Text;
            deger.SATISFIYATI = decimal.Parse(TxtSatisFiyat.Text);
            deger.ALISFIYATI = decimal.Parse(TxtAlisFiyat.Text);
            deger.KATEGORI = byte.Parse(TxtKategori.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
