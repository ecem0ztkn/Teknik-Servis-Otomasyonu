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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void metotkategori()
        {
            var degerler = from k in db.tbl_Kategori
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmKategori_Load(object sender, EventArgs e)
        {
            metotkategori();
             
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            tbl_Kategori t = new tbl_Kategori();
            t.AD = TxtUrunAd.Text;
            db.tbl_Kategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Kaydedildi");
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString(); 
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.tbl_Kategori.Find(id);
            db.tbl_Kategori.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Bir Ürün Sildiniz  ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.tbl_Kategori.Find(id);
            deger.AD = TxtUrunAd.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            metotkategori();
        }
    }
}
