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
    public partial class frm_urun_guncelle : Form
    {

        public int k_id;
        public int kat_id;

        public frm_urun_guncelle()
        {
            InitializeComponent();
        }

        private void frm_urun_guncelle_Load(object sender, EventArgs e)
        {
            MessageBox.Show(k_id.ToString());

            string sql = " select * from urunler where u_id=" + k_id;
            SqlConnection con = new SqlConnection(Form1.baglanti);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;


            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows == true)
            {
                fnk_combo_doldur();
                cb_kategori.SelectedValue= Convert.ToInt32(dr["u_kat_id"]);
                txt_ad.Text = Convert.ToString(dr["u_adi"]);
                txt_aciklama.Text = Convert.ToString(dr["u_aciklama"]);
                txt_fiyat.Text = Convert.ToString(dr["u_fiyat"]);
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string sql = " update urunler set u_kat_id='" + Convert.ToInt32(cb_kategori.SelectedValue) + "', u_adi='" + txt_ad.Text + "', " +
                         " u_aciklama='" + txt_aciklama.Text + "', " +
                         " u_fiyat='" + txt_fiyat.Text + "' where u_id=" + k_id;

            SqlConnection con = new SqlConnection(Form1.baglanti);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Güncelleme Gerçekleşti");

            this.Close();
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


        private void frm_urun_guncelle_Activated(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
