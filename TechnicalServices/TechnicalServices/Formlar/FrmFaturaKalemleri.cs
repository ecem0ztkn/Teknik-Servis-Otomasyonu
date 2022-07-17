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
    public partial class FrmFaturaKalemleri : Form
    {
        public FrmFaturaKalemleri()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtFaturaID.Text);

            var degerler = (from u in db.tbl_FaturaDetay
                            select new
                            {
                                u.FATURADETAYID,
                                u.URUN,
                                u.ADET,
                                u.FIYAT,
                                u.TUTAR,
                                u.FATURAID,
                            }).Where(x => x.FATURAID == id);
            gridControl1.DataSource = degerler.ToList();

            var val2 = (from i in db.tbl_FaturaDetay.Where(m => m.tbl_FaturaBilgi.SERI == TxtSeriNo.Text.ToLower() | m.tbl_FaturaBilgi.SIRANO == TxtSiraNo.Text)
                        select new
                        {
                            i.URUN,
                            i.FIYAT,
                            i.TUTAR,
                            CARİ = i.tbl_FaturaBilgi.tbl_Cari.AD + " " + i.tbl_FaturaBilgi.tbl_Cari.SOYAD,
                            SERINO = i.tbl_FaturaBilgi.SERI,
                            SIRANO = i.tbl_FaturaBilgi.SIRANO,
                            i.FATURAID
                        });

            gridControl1.DataSource = val2.ToList();
        }
    }
}
