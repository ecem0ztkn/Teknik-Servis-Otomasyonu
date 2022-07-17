using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TechnicalServices.Formlar
{
    public partial class FrmCariIl : Form
    {
        public FrmCariIl()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-KD72G1B\MSSQLSERVER1;Initial Catalog=DbTeknikServis;Integrated Security=True");
        private void FrmCariIl_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 15);
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul",23);
            //chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 12);
            //chartControl1.Series["Series 1"].Points.AddPoint("Bursa", 8);

            gridControl1.DataSource = db.tbl_Cari.OrderBy(x => x.IL).GroupBy(y => y.IL).Select(z => new { Il = z.Count() }).ToList();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select IL,COUNT(*) FROM tbl_Cari group by IL",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString( dr[0]),int.Parse(dr[1].ToString()));

            }
            baglanti.Close();
        }
    }
}
