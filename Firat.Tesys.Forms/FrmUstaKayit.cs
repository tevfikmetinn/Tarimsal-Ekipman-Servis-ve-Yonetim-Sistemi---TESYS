using DevExpress.XtraEditors;
using Firat.Tesys.Business;
using Firat.Tesys.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firat.Tesys.Forms
{
    public partial class FrmUstaKayit : DevExpress.XtraEditors.XtraForm
    {
        public FrmUstaKayit()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Usta yeni = new Usta { AdSoyad = txtAdSoyad.Text };
            new SqlUstaService().UstaEkle(yeni);
            this.Close();
        }
    }
}