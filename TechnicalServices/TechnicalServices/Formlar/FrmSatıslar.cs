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
    public partial class FrmSatıslar : Form
    {
        public FrmSatıslar()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmSatıslar_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.tbl_UrunHareket
                           select new
                           {
                               x.HAREKETID,
                               x.tbl_Urun.AD,
                               MUSTERI = x.tbl_Cari.AD + x.tbl_Cari.SOYAD,
                               PERSONEL = x.tbl_Personel.AD + x.tbl_Personel.SOYAD,
                               x.TARIH,
                               x.ADET,
                               x.FIYAT,
                               x.URUNSERINO
                           };
            gridControl1.DataSource = degerler.ToList();

        }
    }
}
