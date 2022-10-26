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
    public partial class frm_kullanici_guncelle : Form
    {
        public int kul_id;

        public frm_kullanici_guncelle()
        {
            InitializeComponent();
        }

        private void frm_kullanici_guncelle_Load(object sender, EventArgs e)
        {
            MessageBox.Show(kul_id.ToString());

            string sql = " select * from kullanici where k_id="+ kul_id;
            SqlConnection con = new SqlConnection(Form1.baglanti);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.CommandType = CommandType.Text;


            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows==true)
            {
                txt_kad.Text = Convert.ToString(dr["k_adi"]);
                txt_ksifre.Text = Convert.ToString(dr["k_sifre"]);
                int durumu = Convert.ToInt32(dr["k_durum"]);
                if (durumu == 0)
                {
                    rb_pasif.Checked = true;
                }
                else
                {
                    rb_aktif.Checked = true;
                }

                int yetki = Convert.ToInt32(dr["k_yetki"]);
                if (yetki == 0)
                {
                    rb_kullanici.Checked = true;
                }
                else
                {
                    rb_yonetici.Checked = true;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yetki = 0;
            if (rb_yonetici.Checked == true) { yetki = 1; }

            int durum = 0;
            if (rb_aktif.Checked == true) { durum = 1; }

            string sql = " update kullanici set k_adi='" + txt_kad.Text + "', " +
                         " k_sifre='" + txt_ksifre.Text + "', k_durum='" + durum + "', " +
                         " k_yetki='" + yetki + "' where k_id=" + kul_id;

            SqlConnection con = new SqlConnection(Form1.baglanti);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("Güncelleme Gerçekleşti");

            this.Close();

            


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
