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
    public partial class Listele : Form
    {
        public Listele()
        {
        
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //List<Varlik> varlikListe = new List<Varlik>();
        private void button3_Click(object sender, EventArgs e)
        {
            //varlik sınıfı üzerinden verileri çekip dtgridw. da gösterilemedi direkt tablo çekildi.
            SqlConnection conn = SqlConn.Baglanti;
            SqlCommand cmd = SqlConn.Komut("select v.KayitID,v.Barkod, u.UrunTİpi,m.Marka,mm.Model,v.GuncelFiyat from VarlikListe v inner join UrunTipi u on v.UrunTipi=u.UrunTipiID join Marka m on m.MarkaID=v.Marka join Model mm on mm.ModelID=v.Model where  IsTuketilmis=0");          
            SqlDataAdapter da = new SqlDataAdapter("select v.KayitID,v.Barkod, u.UrunTİpi,m.Marka,mm.Model,v.GuncelFiyat from VarlikListe v inner join UrunTipi u on v.UrunTipi=u.UrunTipiID join Marka m on m.MarkaID=v.Marka join Model mm on mm.ModelID=v.Model  where  IsTuketilmis=0", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            //SqlDataReader rdr = cmd.ExecuteReader();
            //while (rdr.Read())
            //{
            //Varlik varl = new Varlik();
            //varl.KayitNo = rdr.GetInt32(0);
            //varl.Barkod = rdr.GetGuid(1);
            //varl.UrunTİpi = rdr.GetString(2);
            //varl.Marka = rdr.GetString(3);
            //varl.Model = rdr.GetString(4);
            //varl.GuncelFiyat = rdr.GetDecimal(5);
            ////varlikListe.Add(varl);
            //dataGridView1.Rows.Add(varl.KayitNo);
            //dataGridView1.Rows.Add(varl.Barkod);
            //dataGridView1.Rows.Add(varl.UrunTİpi);
            //dataGridView1.Rows.Add(varl.Marka);
            //dataGridView1.Rows.Add(varl.Model);
            //dataGridView1.Rows.Add(varl.GuncelFiyat);
            //}

        }
        //kullanıcı adını listele ekranına yazdırmak iiçin değişken tanımlıyorum.
        public string AlinanAd;
        

        private void Listele_Load(object sender, EventArgs e)
        {

            label1.Text = AlinanAd;
        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SqlConn.Baglanti;
            SqlCommand cmd = SqlConn.Komut("select v.KayitID,v.Barkod, u.UrunTİpi,m.Marka,mm.Model,v.GuncelFiyat from VarlikListe v inner join UrunTipi u on v.UrunTipi=u.UrunTipiID join Marka m on m.MarkaID=v.Marka join Model mm on mm.ModelID=v.Model join KullaniciGiris k on k.KullaniciID=v.KaydiAcanKullaniciID where k.KullaniciAdi='"+AlinanAd+ "' and IsTuketilmis=0");
            SqlDataAdapter da = new SqlDataAdapter("select v.KayitID, v.Barkod, u.UrunTİpi, m.Marka, mm.Model, v.GuncelFiyat from VarlikListe v inner join UrunTipi u on v.UrunTipi = u.UrunTipiID join Marka m on m.MarkaID = v.Marka join Model mm on mm.ModelID = v.Model join KullaniciGiris k on k.KullaniciID = v.KaydiAcanKullaniciID where k.KullaniciAdi = '"+AlinanAd+"' and IsTuketilmis=0", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
