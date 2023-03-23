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
    public class Giris
    {
        public string KullaniciAdi;
        public int KullaniciID { get; set; }

        public void GirisYap(string ad, string sifre)
        {
            SqlConnection conn = SqlConn.Baglanti;
            SqlCommand cmd = SqlConn.Komut("select * from KullaniciGiris where KullaniciAdi='" + ad + "' and Sifre='" + sifre + "'");
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
              
                Anasayfa frm = new Anasayfa();
                //kullanıcı adını listele ekranına yazdırmak iiçin değişken tanımlıyorum.
                frm.GidecekAd = ad;
                frm.gidecekID = rdr.GetInt32(0);
                frm.Show();
                rdr.Close();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı.");
                rdr.Close();

            }
            
        }
    }
}
