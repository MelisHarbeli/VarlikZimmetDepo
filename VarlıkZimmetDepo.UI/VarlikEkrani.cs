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
    public partial class VarlikEkrani : Form
    {
        public VarlikEkrani()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtkayit.Text);
            SqlConnection conn = SqlConn.Baglanti;
            //kayit numarasına göre varlığı getirecek komut
            SqlCommand cmd = SqlConn.Komut("select * from VarlikListe where KayitID ='" + a + "'");
            SqlDataAdapter da = new SqlDataAdapter("select * from VarlikListe where KayitID = '" + a + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            label4.Text = txtkayit.Text;
            //update için verileri çekme
            //SqlConnection conn = SqlConn.Baglanti;
            SqlCommand cmd2 = new SqlCommand("select * from VarlikListe v inner join UrunTipi u on v.UrunTipi=u.UrunTipiID join Marka m on m.MarkaID=v.Marka join Model mo on mo.ModelID=v.Model join ParaBirim p on p.ParaBirimID = v.ParaBirim join ParaBirim pb on pb.ParaBirimID = v.GuncelFiyatParaBirim where KayitID='" + a + "'");
            cmd2.Connection = conn;
            SqlDataReader rdr = cmd2.ExecuteReader();
            rdr.Read();
            cmbTip.Text = rdr.GetString(18);
            cmbMarka.Text = rdr.GetString(20);
            cmbModel.Text = rdr.GetString(22);
            cmbParaBirim.Text = rdr.GetString(25);
            cmbGnceParaBirim.Text = rdr.GetString(27);
            txtBarkod.Text = Convert.ToString(rdr.GetGuid(1));
            labelTip.Text = Convert.ToString(rdr.GetInt32(2));
            labelmarka.Text = Convert.ToString(rdr.GetInt32(3));
            labelmodel.Text = Convert.ToString(rdr.GetInt32(4));
            labelGaranti.Text = Convert.ToString(rdr.GetBoolean(5));
            richTextBox1.Text = rdr.GetString(6);
            dateGiris.Value = rdr.GetDateTime(7);
            txtMaliyet.Text = Convert.ToString(rdr.GetDecimal(9));
            cmbParaBirim.Text = Convert.ToString(rdr.GetInt32(10));
            txtGuncelFiyat.Text = Convert.ToString(rdr.GetDecimal(11));
            cmbGnceParaBirim.Text = Convert.ToString(rdr.GetInt32(12));
            if (labelGaranti.Text == "1")
            {
                cmbGaranti.Text = "Evet";
            }
            else
            {
                cmbGaranti.Text = "Hayır";
            }
            rdr.Close();
           






        }
       

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            UrunTipi tip = cmbTip.SelectedItem as UrunTipi;
            int ur = tip.UrunTipiID;
            Marka marka = cmbMarka.SelectedItem as Marka;
            int m = marka.MarkaID;
            //Model model = cmbModel.SelectedItem as Model;
            //int mo = model.ModelID;
            int a = Int32.Parse(txtkayit.Text);

           
            SqlConnection conn = SqlConn.Baglanti;
            SqlCommand cmd = new SqlCommand("update VarlikListe set Barkod=@b,UrunTipi=@u,Marka=@ma,/*Model=@mo,*/IsGaranti=@g,Aciklama=@a,UrunMaliyet=@mal,ParaBirim=@pa,GuncelFiyat=@gu,GuncelFiyatParaBirim=@gupa where KayitID='" + a + "'", conn);
            cmd.Parameters.AddWithValue("@b", txtBarkod.Text);
            cmd.Parameters.AddWithValue("@u",ur);
            cmd.Parameters.AddWithValue("@ma", m);
            //cmd.Parameters.AddWithValue("@mo", mo);
            cmd.Parameters.AddWithValue("@g", Convert.ToBoolean(Convert.ToInt32(labelGaranti.Text)));
            cmd.Parameters.AddWithValue("@a", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@mal", Convert.ToDecimal(txtMaliyet.Text));
            cmd.Parameters.AddWithValue("@pa", Convert.ToInt32(cmbParaBirim.SelectedIndex + 1));
            cmd.Parameters.AddWithValue("@gu",Convert.ToDecimal( txtGuncelFiyat.Text));
            cmd.Parameters.AddWithValue("@gupa", Convert.ToInt32(cmbGnceParaBirim.SelectedIndex+1));
            cmd.ExecuteNonQuery();
            int etkilenenSatirSayisi = cmd.ExecuteNonQuery();
            MessageBox.Show((etkilenenSatirSayisi>=1)
                ?"Başarıyla Güncellendi."
                :"Hata.");

        }

        private void VarlikEkrani_Load(object sender, EventArgs e)
        {
            MyMetod mt = new MyMetod();
            mt.MarkalarıGetir(cmbMarka);
            mt.UrunTipiGetir(cmbTip);
            mt.ParaBirimGetir(cmbParaBirim);
            mt.ParaBirimGetir(cmbGnceParaBirim);
            
        }

        private void cmbGaranti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGaranti.Text == "Evet")
            {
                labelGaranti.Text = "1";
            }
            else
            {
                labelGaranti.Text = "0";
            }
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        public static int gidecekID;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==6)
            {
                gidecekID = Convert.ToInt32(txtkayit.Text);
                ZimmetAta z = new ZimmetAta();              
                z.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                gidecekID = Convert.ToInt32(txtkayit.Text);
                Tuket t = new Tuket();
                t.Show();
            }
        }
    }
}
