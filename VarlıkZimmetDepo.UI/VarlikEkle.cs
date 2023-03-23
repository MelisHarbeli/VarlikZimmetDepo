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
using VarlikZimmetDepo.Command;


namespace VarlıkZimmetDepo.UI
{
    public class VarlikEkle
    {
        SqlConnection conn = SqlConn.Baglanti;
       // SqlTransaction tran =null;
        //SqlCommand cmd = new SqlCommand();



        public void KayitEkle(params object[] txt)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();             
              //  tran = conn.BeginTransaction();
                //cmd.Connection = conn;
                 string komut = "insert VarlikListe (Barkod,UrunTipi,Marka,Model,IsGaranti,Aciklama,KayitTarihi,UrunMaliyet,ParaBirim,GuncelFiyat,GuncelFiyatParaBirim,KaydiAcanKullaniciID)values (@Barkod,@UrunTipi,@Marka,@Model,@IsGaranti,@Aciklama,@KayitTarihi,@UrunMaliyet,@ParaBirim,@GuncelFiyat,@GuncelFiyatParaBirim,@KaydiAcanKullaniciID)";
                SqlCommand cmd = new SqlCommand(komut,conn);
                
                cmd.Parameters.AddWithValue("@Barkod",txt[0]);
                cmd.Parameters.AddWithValue("@UrunTipi", txt[1]);
                cmd.Parameters.AddWithValue("@Marka", txt[2]);
                cmd.Parameters.AddWithValue("@Model", txt[3]);
                cmd.Parameters.AddWithValue("@IsGaranti", txt[4]);
                cmd.Parameters.AddWithValue("@Aciklama", txt[5]);
                cmd.Parameters.AddWithValue("@KayitTarihi", txt[6]);
                cmd.Parameters.AddWithValue("@UrunMaliyet", txt[7]);
                cmd.Parameters.AddWithValue("@ParaBirim", txt[8]);
                cmd.Parameters.AddWithValue("@GuncelFiyat", txt[9]);
                cmd.Parameters.AddWithValue("@GuncelFiyatParaBirim", txt[10]);
                cmd.Parameters.AddWithValue("@KaydiAcanKullaniciID",txt[11] );
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            }
            catch(Exception hata)
            {
                //tran.Rollback();
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            finally
            {
                conn.Close();
            }
        }
      
    }
}
