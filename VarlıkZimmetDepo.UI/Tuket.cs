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
    public partial class Tuket : Form
    {
        public Tuket()
        {
            InitializeComponent();
        }
        int alinanId = VarlikEkrani.gidecekID;
        SqlConnection conn = SqlConn.Baglanti;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string komut = "insert TuketilmisVarlik (KullaniciID,Aciklama,VarlikID) values (@KullaniciID,@Aciklama,@VarlikID)";
                SqlCommand cmd = new SqlCommand(komut, conn);

                cmd.Parameters.AddWithValue("@KullaniciID", Convert.ToInt32(textBox1.Text));
                cmd.Parameters.AddWithValue("@Aciklama", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@VarlikID", alinanId);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Varlık Tüketildi.");
            }
            catch (Exception hata)
            {
                //tran.Rollback();
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            finally
            {
                conn.Open();
                string komut = "update VarlikListe  set IsTuketilmis=1 where KayitID='"+alinanId+"'";
                SqlCommand cmd = new SqlCommand(komut, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ok");

                conn.Close();
            }
        }
    }
}
