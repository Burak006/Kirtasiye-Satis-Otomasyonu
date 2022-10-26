using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace otomasyon
{
    public partial class urunler : Form
    {
        public urunler()
        {
            InitializeComponent();
        }

        public void fnk_combo_doldur()
        {
            string sql_text = "select * from kategori order by kat_adi asc ";

            SqlConnection baglan = new SqlConnection(Form1.baglanti);
            baglan.Open();

            SqlCommand cmd = new SqlCommand(sql_text, baglan);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);

            cb_kategori.DataSource = ds.Tables[0];
            cb_kategori.DisplayMember = "kat_adi";
            cb_kategori.ValueMember = "kat_id";
            baglan.Close();
        }

        public void fnk_liste_doldur()
        {
            string sql = " select u_id as 'Ürün Kodu', kat_adi as 'Kategori',  " +
                         " u_adi as 'Ürün Adı',  u_aciklama as 'Ürün Açıklaması', u_fiyat as 'Fiyatı' " +
                         " from   urunler  " +
                         " left join kategori on urunler.u_kat_id=kategori.kat_id order by u_id desc";
            SqlConnection baglan = new SqlConnection(Form1.baglanti);
            baglan.Open();

            SqlDataAdapter da = new SqlDataAdapter(sql, baglan);

            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void urunler_Load(object sender, EventArgs e)
        {
            fnk_combo_doldur();
            fnk_liste_doldur();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql_text = "insert into urunler values('"+Convert.ToInt32( cb_kategori.SelectedValue)+"','"+txt_ad.Text+ "','" + txt_aciklama.Text + "','" + txt_fiyat.Text+"')";

            SqlConnection baglanti = new SqlConnection(Form1.baglanti);
            baglanti.Open();

            SqlCommand cmd = new SqlCommand(sql_text, baglanti);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            baglanti.Close();
            MessageBox.Show("Kayıt İşlemi Gerçekleşti");

            txt_ad.Clear();
            txt_aciklama.Clear();
            txt_fiyat.Clear();

            fnk_liste_doldur();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult mesaj = new DialogResult();
            mesaj = MessageBox.Show("Seçili Kaydı Silmek İstiyormusunuz", "Silme İşlemi", MessageBoxButtons.YesNo);

            if (mesaj == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Ürün Kodu"].Value);

                string sql = " delete from urunler where u_id=" + id;

                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti");

                fnk_liste_doldur();
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Ürün Kodu"].Value);

            frm_urun_guncelle gun = new frm_urun_guncelle();
            gun.k_id = id;
            gun.ShowDialog();
            fnk_liste_doldur();
        }
        private void urunler_Activated(object sender, EventArgs e)
        {
            fnk_liste_doldur();
        }




    }
}
