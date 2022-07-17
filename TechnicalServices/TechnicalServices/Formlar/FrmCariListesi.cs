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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.tbl_Cari.ToList();
        }
    }
}
