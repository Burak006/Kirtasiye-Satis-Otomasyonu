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
    public partial class frm_kullanici_kayit : Form
    {
        public frm_kullanici_kayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k_yetki = 0;
            int k_durum = 0;

            if (rb_aktif.Checked == true)
            {
                k_durum = 1;
            }

            if (rb_yonetici.Checked == true)
            {
                k_yetki = 1;
            }


            string sql_text = "insert into kullanici values('"+txt_kad.Text+"'"+
                ",'"+txt_ksifre.Text+"','"+k_durum+"','"+k_yetki+"')";

            SqlConnection baglanti = new SqlConnection(Form1.baglanti);
            baglanti.Open();

            SqlCommand cmd = new SqlCommand(sql_text, baglanti);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            baglanti.Close();

            MessageBox.Show("Kayıt İşlemi Gerçekleşti");
            txt_kad.Clear();
            txt_ksifre.Clear();
            

            fnk_liste_doldur();
                
        }

        public void fnk_liste_doldur()
        {
            string sql = " select k_id as 'Kullanıcı Kodu', k_adi as 'Kullanıcı Adı', "+
                         " case k_durum when 0 then 'Pasif' else 'Aktif' end as 'K ullanıcı Durum', "+
                         " case k_yetki when 0 then 'Kullanıcı' when 1 then 'Yönetici' end as 'Kullanıcı Yetki'"+
                         " from kullanici order by k_id desc";

            SqlConnection baglan = new SqlConnection(Form1.baglanti);
            baglan.Open();

            SqlDataAdapter da = new SqlDataAdapter(sql, baglan);

            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }
        private void frm_kullanici_kayit_Activated(object sender, EventArgs e)
        {
            fnk_liste_doldur();
        }
        private void frm_kullanici_kayit_Load(object sender, EventArgs e)
        {
            fnk_liste_doldur();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult mesaj = new DialogResult();
            mesaj = MessageBox.Show("Seçili Kaydı Silmek İstiyormusunuz", "Silme İşlemi", MessageBoxButtons.YesNo);

            if (mesaj==DialogResult.Yes)
            {
                int id =Convert.ToInt32( dataGridView1.CurrentRow.Cells["Kullanıcı Kodu"].Value);
                
                string sql = " delete from kullanici where k_id="+id;
                
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

        private void aktifYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Kullanıcı Kodu"].Value);

            string sql = " update kullanici set k_durum=1 where k_id=" + id;

            SqlConnection baglan = new SqlConnection(Form1.baglanti);
            baglan.Open();
            SqlCommand cmd = new SqlCommand(sql,baglan);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            baglan.Close();

            fnk_liste_doldur();

        }

        private void pasifYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Kullanıcı Kodu"].Value);

            string sql = " update kullanici set k_durum=0 where k_id=" + id;

            SqlConnection baglan = new SqlConnection(Form1.baglanti);
            baglan.Open();
            SqlCommand cmd = new SqlCommand(sql, baglan);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            baglan.Close();

            fnk_liste_doldur();
        }

        private void kullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Kullanıcı Kodu"].Value);

            string sql = " update kullanici set k_yetki=0 where k_id=" + id;

            SqlConnection baglan = new SqlConnection(Form1.baglanti);
            baglan.Open();
            SqlCommand cmd = new SqlCommand(sql, baglan);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            baglan.Close();

            fnk_liste_doldur();
        }

        private void yöneticiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Kullanıcı Kodu"].Value);

            string sql = " update kullanici set k_yetki=1 where k_id=" + id;

            SqlConnection baglan = new SqlConnection(Form1.baglanti);
            baglan.Open();
            SqlCommand cmd = new SqlCommand(sql, baglan);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            baglan.Close();

            fnk_liste_doldur();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Kullanıcı Kodu"].Value);

            frm_kullanici_guncelle gun = new frm_kullanici_guncelle();
            gun.kul_id = id;
            gun.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
