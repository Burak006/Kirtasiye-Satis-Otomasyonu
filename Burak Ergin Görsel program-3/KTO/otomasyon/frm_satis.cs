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
    public partial class frm_satis : Form
    {
        public frm_satis()
        {
            InitializeComponent();
        }


        public void fnk_liste_doldur_musteri()
        {
            string sql = " select m_id as 'Müş.No', m_firma as 'Firma Adı', " +
                         " m_adi as 'Adı', m_soyadi as 'Soyadı'" +
                         " from   musteri order by m_id desc";
            SqlConnection baglan = new SqlConnection(Form1.baglanti);
            baglan.Open();

            SqlDataAdapter da = new SqlDataAdapter(sql, baglan);

            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }
        public void fnk_liste_doldur_urun()
        {
            string sql = " select u_id as 'Ürün Kodu', kat_adi as 'Kategori',  " +
                         " u_adi as 'Ürün Adı', u_fiyat as 'Fiyatı' " +
                         " from   urunler  " +
                         " left join kategori on urunler.u_kat_id=kategori.kat_id order by u_id desc";
            SqlConnection baglan = new SqlConnection(Form1.baglanti);
            baglan.Open();

            SqlDataAdapter da = new SqlDataAdapter(sql, baglan);

            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView2.DataSource = ds.Tables[0];
            baglan.Close();
        }


        public void fnk_liste_doldur_satis()
        {
            string sql = " select sa_id as 'Satış No', m_firma as 'Firma Adı'," +
                        " m_adi as 'Adı', m_soyadi as 'Soyadı', " +
                        " kat_adi as 'Kategori', u_adi as 'Ürün Adı', sa_adet as 'Adet', " +
                        " sa_tutar as 'TUTAR' " +
                        " from satis" +
                        " left join musteri on satis.sa_mid=musteri.m_id " +
                        " left join urunler on satis.sa_urid=urunler.u_id " +
                        " left join kategori on urunler.u_kat_id=kategori.kat_id order by sa_id desc ";


            SqlConnection baglan = new SqlConnection(Form1.baglanti);
            baglan.Open();

            SqlDataAdapter da = new SqlDataAdapter(sql, baglan);

            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView3.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void frm_satis_Load(object sender, EventArgs e)
        {
            fnk_liste_doldur_musteri();
            fnk_liste_doldur_urun();
            fnk_liste_doldur_satis();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = " select m_id as 'Müş.No', m_firma as 'Firma Adı', " +
                        " m_adi as 'Adı', m_soyadi as 'Soyadı'" +
                        " from   musteri  " +
                        " where m_firma like '%" + textBox1.Text + "%' or m_soyadi like '%" + textBox1.Text + "%' ";
            SqlConnection baglan = new SqlConnection(Form1.baglanti);
            baglan.Open();

            SqlDataAdapter da = new SqlDataAdapter(sql, baglan);

            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void txt_urun_TextChanged(object sender, EventArgs e)
        {
            string sql = " select u_id as 'Ürün Kodu', kat_adi as 'Kategori',  " +
                         " u_adi as 'Ürün Adı', u_fiyat as 'Fiyatı' " +
                         " from   urunler  " +
                         " left join kategori on urunler.u_kat_id=kategori.kat_id " +
                         " where u_adi like '%" + txt_urun.Text + "%' or kat_adi like '%" + txt_urun.Text + "%' ";
            SqlConnection baglan = new SqlConnection(Form1.baglanti);
            baglan.Open();

            SqlDataAdapter da = new SqlDataAdapter(sql, baglan);

            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView2.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mus_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Müş.No"].Value);
            int urun_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells["Ürün Kodu"].Value);
            int adet = Convert.ToInt32(txt_adet.Text);
            int tutar = Convert.ToInt32(dataGridView2.CurrentRow.Cells["Fiyatı"].Value)*(adet);

            if ((mus_id > 0) && (urun_id > 0) && (adet > 0))
            {

                string sql = "insert into satis values('" + mus_id + "','" + urun_id + "','" + adet + "','" + tutar + "')";

                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();

                MessageBox.Show("Satış Gerçekleşti");
                txt_adet.Clear();
                fnk_liste_doldur_satis();
            }

        }
        private void seçiliVeriyiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult mesaj = new DialogResult();
            mesaj = MessageBox.Show("Seçili Kaydı Silmek İstiyormusunuz", "Silme İşlemi", MessageBoxButtons.YesNo);

            if (mesaj == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView3.CurrentRow.Cells["Satış No"].Value);

                string sql = " delete from satis where sa_id=" + id;

                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti");

                fnk_liste_doldur_musteri();
                fnk_liste_doldur_urun();
                fnk_liste_doldur_satis();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
