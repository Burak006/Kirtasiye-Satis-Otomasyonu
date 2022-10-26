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
    public partial class kategori : Form
    {
        public kategori()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql_text = " insert into kategori values('"+txt_kat.Text+"') ";
            
            SqlConnection baglanti = new SqlConnection(Form1.baglanti);
            baglanti.Open();

            SqlCommand cmd = new SqlCommand(sql_text, baglanti);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            baglanti.Close();

            txt_kat.Clear();
            txt_kat.Focus();

            MessageBox.Show("Kayıt İşlemi Gerçekleşti");

            fnk_kategori_doldur();
        }

        public void fnk_kategori_doldur()
        {
            string sql = " select kat_id as 'Kategori Kodu', kat_adi as 'Kategori Adı' from kategori order by kat_id desc";



            SqlConnection baglan = new SqlConnection(Form1.baglanti);
            baglan.Open();

            SqlDataAdapter da = new SqlDataAdapter(sql, baglan);

            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void kategori_Load(object sender, EventArgs e)
        {
            fnk_kategori_doldur();
        }

        private void frm_kategori_Activated(object sender, EventArgs e)
        {
            fnk_kategori_doldur();
        }

        

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult mesaj = new DialogResult();
            mesaj = MessageBox.Show("Seçili Kaydı Silmek İstiyormusunuz", "Silme İşlemi", MessageBoxButtons.YesNo);

            if (mesaj == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Kategori Kodu"].Value);

                string sql = " delete from kategori where kat_id=" + id;

                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti");

                fnk_kategori_doldur();
            }
        }










        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
