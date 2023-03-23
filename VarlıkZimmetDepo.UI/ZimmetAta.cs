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
    public partial class ZimmetAta : Form
    {
        public ZimmetAta()
        {
            InitializeComponent();
        }

        private void ZimmetAta_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
        int alinanId = VarlikEkrani.gidecekID;
        SqlConnection conn = SqlConn.Baglanti;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (conn.State == ConnectionState.Closed)
                    conn.Open();          
                string komut = "insert  ZimmetAta (KullaniciID,ZimmetNedeni,ZimmetTuru,ZimmetBaslangic,ZimmetBitis,aciklama,VarlikID) values (@kullanici,@ZimmetNedeni,@ZimmetTuru,@ZimmetBaslangic,@ZimmetBitis,@aciklama,@VarlikID)";
                SqlCommand cmd = new SqlCommand(komut, conn);

                cmd.Parameters.AddWithValue("@kullanici", Convert.ToInt32(txtKullanici.Text));
                cmd.Parameters.AddWithValue("@ZimmetNedeni", cmbNeden.Text);
                cmd.Parameters.AddWithValue("@ZimmetTuru", cmbTur.Text);
                cmd.Parameters.AddWithValue("@ZimmetBaslangic",dateBAsla.Value);
                cmd.Parameters.AddWithValue("@ZimmetBitis",dateBitis.Value);
                cmd.Parameters.AddWithValue("@aciklama", txtAcik.Text);
                cmd.Parameters.AddWithValue("@VarlikID", alinanId);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Zimmet İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
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
