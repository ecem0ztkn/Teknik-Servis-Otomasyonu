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
    public partial class FrmYeniArizaliUrun : Form
    {
        public FrmYeniArizaliUrun()
        {
            InitializeComponent();
        }

        private void FrmYeniArizaliUrun_Load(object sender, EventArgs e)
        {

        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void BtnYeniKayit_Click(object sender, EventArgs e)
        {
            tbl_UrunKabul t = new tbl_UrunKabul();
            t.CARI = int.Parse(TxtMusteriID.Text);
            t.PERSONEL = short.Parse(TxtTarih.Text);
            t.GELISTARIHI = DateTime.Parse(TxtTarih.Text);
            t.URUNSERINO = TxtSeriNo.Text;
            db.tbl_UrunKabul.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi");
        }
    }
}
