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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.tbl_Urun.Count().ToString();
            labelControl3.Text = db.tbl_Kategori.Count().ToString();
            labelControl5.Text = db.tbl_Urun.Sum(x => x.STOK).ToString();
            labelControl19.Text = (from x in db.tbl_Urun
                                   orderby x.STOK descending
                                   select x.AD).FirstOrDefault();
            labelControl17.Text = (from x in db.tbl_Urun
                                   orderby x.STOK ascending
                                   select x.AD).FirstOrDefault();
            labelControl13.Text = (from x in db.tbl_Urun
                                   orderby x.SATISFIYATI descending
                                   select x.AD).FirstOrDefault();
            labelControl11.Text = (from x in db.tbl_Urun
                                   orderby x.SATISFIYATI ascending
                                   select x.AD).FirstOrDefault();
            labelControl25.Text = db.tbl_Urun.Count(x => x.KATEGORI == 4).ToString();
            labelControl29.Text = db.tbl_Urun.Count(x => x.KATEGORI == 1).ToString();
            labelControl21.Text = db.tbl_Urun.Count(x => x.KATEGORI == 3).ToString();
            labelControl39.Text = (from x in db.tbl_Urun
                                   select x.MARKA).Distinct().Count().ToString();   
        }
                
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
