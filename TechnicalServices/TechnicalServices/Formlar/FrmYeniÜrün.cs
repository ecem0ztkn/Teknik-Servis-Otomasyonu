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
    public partial class FrmYeniÜrün : Form
    {
        public FrmYeniÜrün()
        {
            InitializeComponent();
        }

        private void FrmYeniÜrün_Load(object sender, EventArgs e)
        {

        }

        private void pictureEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            FrmYeniÜrün fr = new FrmYeniÜrün();
            fr.Hide();

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            tbl_Urun t = new tbl_Urun
            {
                AD = TxtUrunAd.Text,
                MARKA = TxtMarka.Text,
                ALISFIYATI = decimal.Parse(TxtAlisFiyat.Text),
                SATISFIYATI = decimal.Parse(TxtSatisFiyat.Text),
                STOK = short.Parse(TxtStok.Text),
                KATEGORI = byte.Parse(TxtKategori.Text)
            };
            db.tbl_Urun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi");
        }
    }
}
