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
    public partial class kullanici_girisi : Form
    {
        public kullanici_girisi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txt_kuladi.Text != "") && (txt_sifre.Text != ""))
            {
                if ((txt_kuladi.Text == "q") && (txt_sifre.Text == "q"))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bilgileri Yanlış");
                }
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girildi");
            }
        }

        private void kullanici_girisi_Load(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = '*';
        }
    }
}
