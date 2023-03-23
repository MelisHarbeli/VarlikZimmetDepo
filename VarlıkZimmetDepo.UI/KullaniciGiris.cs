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

namespace VarlıkZimmetDepo.UI
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {

            InitializeComponent();
        }
        public string KullaniciAdi()
        {
            return txtAd.Text;
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
           
        }
        public static string ad;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string sifre = txtSifre.Text;
            Giris grs = new Giris();
            grs.GirisYap(ad,sifre);
           
            
          
            

          

        }
    }
}
