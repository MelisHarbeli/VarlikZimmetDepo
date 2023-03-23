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
    public class MyMetod
    {
        //markları comboboxa eklecen metod
        public void MarkalarıGetir(ComboBox cnt)
        {

            SqlConnection conn = SqlConn.Baglanti;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Marka";
            cmd.Connection = conn;
            SqlDataReader rdr = cmd.ExecuteReader();
            
            if (rdr.HasRows)
            {

                while (rdr.Read())
                {
                    Marka m = new Marka();
                    m.MarkaAdi = rdr.GetString(1);
                    m.MarkaID = rdr.GetInt32(0);

                    cnt.Items.Add(m);
                }



            }
            rdr.Close();

        }
        //modelleri comboboxa eklecen metod
        public void ModelGetir(ComboBox cntr, string txt)
        {
            //her markanın modelleri kendine özgü olduğu için seçili markaya ait modellerin götüntülendiği komut
            SqlConnection conn = SqlConn.Baglanti;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = " select Model,ModelID from Model inner join Marka on Model.MarkaID = Marka.MarkaID where Marka.Marka ='" + txt + "'";
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {

                while (rdr.Read())
                {
                    Model m = new Model();
                    m.ModelAdi = rdr.GetString(0);
                    m.ModelID = rdr.GetInt32(1);

                    cntr.Items.Add(m);
                }



            }
            rdr.Close();
        }
        //urun tplerini comboboxa eklecen metod
        public void UrunTipiGetir(ComboBox cnt)
        {

            SqlConnection conn = SqlConn.Baglanti;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from UrunTipi";
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {

                while (rdr.Read())
                {
                    UrunTipi m = new UrunTipi();
                    m.UrunTipiAdi = rdr.GetString(1);
                    m.UrunTipiID = rdr.GetInt32(0);

                    cnt.Items.Add(m);
                }



            }
            rdr.Close();


        }
        //para birimlerini comboboxa eklecen metod
        public void ParaBirimGetir(ComboBox cnt)
        {

            SqlConnection conn = SqlConn.Baglanti;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ParaBirim from ParaBirim";
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {

                while (rdr.Read())
                {
                    ParaBirim m = new ParaBirim();
                    m.ParaBirimi = rdr.GetString(0);

                    cnt.Items.Add(m);
                }



            }
            rdr.Close();
        }
    }

}
