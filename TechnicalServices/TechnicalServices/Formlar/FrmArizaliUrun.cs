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
    public partial class FrmArizaliUrun : Form
    {
        public FrmArizaliUrun()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmArizaliUrun_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.tbl_UrunKabul
                           select new
                           {
                               x.ISLEMID,
                               ADI = x.tbl_Cari.AD + x.tbl_Cari.SOYAD,
                               PERSONELAD = x.tbl_Personel.AD + x.tbl_Personel.SOYAD,
                               x.GELISTARIHI,
                               x.CIKISTARIHI,
                               x.URUNSERINO
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
