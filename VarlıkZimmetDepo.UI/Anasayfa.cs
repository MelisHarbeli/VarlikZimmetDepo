using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VarlıkZimmetDepo.UI
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        //kullanıcı adını listele ekranına yazdırmak iiçin değişken tanımlıyorum.
        public string GidecekAd;
        public int gidecekID;
        private void varlıkDepoListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele lst = new Listele();
            lst.AlinanAd = GidecekAd;
           
            FormGetir(lst);
            
        }
        public void FormGetir(Form frm)
        {
            panel1.Controls.Clear();
            frm.MdiParent = this;
            panel1.Controls.Add(frm);
            frm.Show();

        }

        private void yeniKayıtEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kayit kyt = new Kayit();
            kyt.AlinanId = gidecekID;
            FormGetir(kyt);
        }

        private void varlıkEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VarlikEkrani vr = new VarlikEkrani();
            FormGetir(vr);
        }
    }
}
