using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarlikZimmetDepo.Command;

namespace VarlıkZimmetDepo.UI
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            txtBarkod.Enabled = false;
        }
        public int AlinanId;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            VarlikEkle ekle = new VarlikEkle();
            //parabirimlerinin indexini alarak tabloya ıd girişini sağlayacağım bu kod ile
            string ParaBirim = Convert.ToString(cmbParaBirim.SelectedIndex+1);
            string GcelPara = Convert.ToString(cmbGnceParaBirim.SelectedIndex+1);
            
            ekle.KayitEkle(txtBarkod.Text,labelTip.Text,labelmarka.Text,labelmodel.Text, labelGaranti.Text, richTextBox1.Text,dateGiris.Value,txtMaliyet.Text,ParaBirim,txtGuncelFiyat.Text,GcelPara,AlinanId);
        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            MyMetod mt = new MyMetod();
            mt.MarkalarıGetir(cmbMarka);
            mt.UrunTipiGetir(cmbTip);
            mt.ParaBirimGetir(cmbParaBirim);
            mt.ParaBirimGetir(cmbGnceParaBirim);


        }

        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelTip.Text = string.Empty;
            UrunTipi tip = cmbTip.SelectedItem as UrunTipi;
            labelTip.Text = Convert.ToString( tip.UrunTipiID);
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seçilen markaya göre model gelmesi
            cmbModel.Items.Clear();
            cmbModel.Text = string.Empty;
            MyMetod mt = new MyMetod();
            mt.ModelGetir(cmbModel, cmbMarka.Text);
            //labela ıd ataması
            labelmarka.Text = string.Empty;
            Marka tip = cmbMarka.SelectedItem as Marka;
            labelmarka.Text = Convert.ToString(tip.MarkaID);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtBarkod.Enabled = true;
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //model ıd almak için
            labelmodel.Text = string.Empty;
            Model tip = cmbModel.SelectedItem as Model;
            labelmodel.Text = Convert.ToString(tip.ModelID);

        }

        private void cmbGaranti_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kayıt edilecek varığın garanti kısmıa bit türü kaydedilmesi için
            if(cmbGaranti.Text== "Evet")
            {
                labelGaranti.Text = "1";
            }
            else
            {
                labelGaranti.Text = "0";
            }
        }
    }
}
