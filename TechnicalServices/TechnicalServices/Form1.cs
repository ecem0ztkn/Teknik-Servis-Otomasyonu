using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalServices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunListesi fr = new Formlar.FrmUrunListesi();
            fr.MdiParent = this;
            fr.Show(); 
        }

        private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniÜrün fr = new Formlar.FrmYeniÜrün();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKategori fr = new Formlar.FrmKategori();
            fr.MdiParent = this;
            fr.Show();

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniKategori fr = new Formlar.FrmYeniKategori();
            fr.Show();
        }

        private void BtnIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmIstatistik fr = new Formlar.FrmIstatistik();
            fr.MdiParent = this;
            fr.Show();

        }

        private void BtnMarkaIst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmMarkaIst fr = new Formlar.FrmMarkaIst();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariListesi fr = new Formlar.FrmCariListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnCariIl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariIl fr = new Formlar.FrmCariIl();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnArızalıUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaliUrun fr = new Formlar.FrmArizaliUrun();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunSatıs fr = new Formlar.FrmUrunSatıs();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void BtnSatıslar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmSatıslar fr = new Formlar.FrmSatıslar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnArizaDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaDetay fr = new Formlar.FrmArizaDetay();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void BtnQRolustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmQRkod fr = new Formlar.FrmQRkod();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void BtnFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFaturaListesi fr = new Formlar.FrmFaturaListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFaturaKalem fr = new Formlar.FrmFaturaKalem();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnFaturaDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmFaturaKalemleri fr = new Formlar.FrmFaturaKalemleri();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnHarita_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
