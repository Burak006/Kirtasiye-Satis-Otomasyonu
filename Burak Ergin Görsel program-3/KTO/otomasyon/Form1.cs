using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class Form1 : Form
    {
        public static string baglanti = "Data Source=BURAK; Initial Catalog=kirtasiye_otomasyon; Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kullanici_girisi giris = new kullanici_girisi();
            giris.ShowDialog();
        }

        private void sayışİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_satis sat = new frm_satis();
            sat.ShowDialog();
        }

        private void kullanıcıKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_kullanici_kayit kayit = new frm_kullanici_kayit();
            kayit.ShowDialog();
        }

        private void kategoriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kategori kat = new kategori();
            kat.ShowDialog();
        }

        private void ürünİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            urunler urn = new urunler();
            urn.ShowDialog();
        }

        private void müşteriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_musteri_kayit kayit = new frm_musteri_kayit();
            kayit.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
