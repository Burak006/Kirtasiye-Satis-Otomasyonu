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
    public partial class frm_musteri_guncelle : Form
    {

        public int k_id;

        public frm_musteri_guncelle()
        {
            InitializeComponent();
        }

        private void frm_musteri_guncelle_Load(object sender, EventArgs e)
        {
            MessageBox.Show(k_id.ToString());

            string sql = " select * from musteri where m_id=" + k_id;
            SqlConnection con = new SqlConnection(Form1.baglanti);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;


            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows == true)
            {
                txt_adi.Text = Convert.ToString(dr["m_adi"]);
                txt_soyadi.Text = Convert.ToString(dr["m_soyadi"]);
                int durumu = Convert.ToInt32(dr["m_cinsiyeti"]);
                if (durumu == 0)
                {
                    rb_kadin.Checked = true;
                }
                else
                {
                    rb_erkek.Checked = true;
                }
                txt_firma.Text = Convert.ToString(dr["m_firma"]);
                txt_tel.Text = Convert.ToString(dr["m_tel"]);
                txt_eposta.Text = Convert.ToString(dr["m_mail"]);



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k_erkek = 0;
            if (rb_erkek.Checked == true) { k_erkek = 1; }

            string sql = " update musteri set m_adi='" + txt_adi.Text + "', " +
                         " m_soyadi='" + txt_soyadi.Text + "', m_cinsiyeti='" + k_erkek + "', " +
                         " m_firma='" + txt_firma.Text + "',m_tel='" + txt_tel.Text + "', " +
                         " m_mail='" + txt_eposta.Text + "' where m_id=" + k_id;

            SqlConnection con = new SqlConnection(Form1.baglanti);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Güncelleme Gerçekleşti");

            this.Close();

            
        }

        private void frm_musteri_guncelle_Activated(object sender, EventArgs e)
        {
            
        }


    }
}
