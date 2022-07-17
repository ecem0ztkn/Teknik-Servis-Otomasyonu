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
    public partial class FrmMarkaIst : Form
    {
        public FrmMarkaIst()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmMarkaIst_Load(object sender, EventArgs e)
        {
            var degerler = db.tbl_Urun.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).
                Select(z => new
                {
                    Marka = z.Key,
                    Toplam = z.Count()
                });
            gridControl1.DataSource = degerler.ToList();
            labelControl3.Text = db.tbl_Urun.Count().ToString();
            labelControl1.Text = (from x in db.tbl_Urun
                                   select x.MARKA).Distinct().Count().ToString();
            labelControl7.Text = (from x in db.tbl_Urun
                                   orderby x.SATISFIYATI descending
                                   select x.MARKA).FirstOrDefault();
            chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 4);
            chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 6);
            chartControl1.Series["Series 1"].Points.AddPoint("Beko", 2);
            chartControl1.Series["Series 1"].Points.AddPoint("Toshiba", 1);
            chartControl1.Series["Series 1"].Points.AddPoint("Lenovo", 1);

            chartControl2.Series["Series 2"].Points.AddPoint("Beyaz Eşya", 4);
            chartControl2.Series["Series 2"].Points.AddPoint("Bilgisayar", 3);
            chartControl2.Series["Series 2"].Points.AddPoint("Küçük ev Aletleri", 6);
            chartControl2.Series["Series 2"].Points.AddPoint("Televizyon", 2);
            chartControl2.Series["Series 2"].Points.AddPoint("Diğer", 5);
            chartControl2.Series["Series 2"].Points.AddPoint("Telefon", 3);
        }
    }
}
