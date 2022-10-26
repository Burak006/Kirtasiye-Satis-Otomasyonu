namespace otomasyon
{
    partial class frm_kullanici_guncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_kullanici_guncelle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_yonetici = new System.Windows.Forms.RadioButton();
            this.rb_kullanici = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_pasif = new System.Windows.Forms.RadioButton();
            this.rb_aktif = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_ksifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_ksifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_kad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Güncelle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kullanıcı Yetki :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kullanıcı Durumu :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_yonetici);
            this.groupBox3.Controls.Add(this.rb_kullanici);
            this.groupBox3.Location = new System.Drawing.Point(129, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 34);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // rb_yonetici
            // 
            this.rb_yonetici.AutoSize = true;
            this.rb_yonetici.Location = new System.Drawing.Point(97, 12);
            this.rb_yonetici.Name = "rb_yonetici";
            this.rb_yonetici.Size = new System.Drawing.Size(69, 19);
            this.rb_yonetici.TabIndex = 6;
            this.rb_yonetici.TabStop = true;
            this.rb_yonetici.Text = "Yönetici";
            this.rb_yonetici.UseVisualStyleBackColor = true;
            // 
            // rb_kullanici
            // 
            this.rb_kullanici.AutoSize = true;
            this.rb_kullanici.Location = new System.Drawing.Point(15, 12);
            this.rb_kullanici.Name = "rb_kullanici";
            this.rb_kullanici.Size = new System.Drawing.Size(74, 19);
            this.rb_kullanici.TabIndex = 5;
            this.rb_kullanici.TabStop = true;
            this.rb_kullanici.Text = "Kullanıcı";
            this.rb_kullanici.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_pasif);
            this.groupBox2.Controls.Add(this.rb_aktif);
            this.groupBox2.Location = new System.Drawing.Point(129, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 31);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // rb_pasif
            // 
            this.rb_pasif.AutoSize = true;
            this.rb_pasif.Location = new System.Drawing.Point(97, 10);
            this.rb_pasif.Name = "rb_pasif";
            this.rb_pasif.Size = new System.Drawing.Size(52, 19);
            this.rb_pasif.TabIndex = 6;
            this.rb_pasif.TabStop = true;
            this.rb_pasif.Text = "Pasif";
            this.rb_pasif.UseVisualStyleBackColor = true;
            // 
            // rb_aktif
            // 
            this.rb_aktif.AutoSize = true;
            this.rb_aktif.Location = new System.Drawing.Point(15, 10);
            this.rb_aktif.Name = "rb_aktif";
            this.rb_aktif.Size = new System.Drawing.Size(51, 19);
            this.rb_aktif.TabIndex = 5;
            this.rb_aktif.TabStop = true;
            this.rb_aktif.Text = "Aktif";
            this.rb_aktif.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(129, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "GÜNCELLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_ksifre
            // 
            this.txt_ksifre.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ksifre.ForeColor = System.Drawing.Color.Red;
            this.txt_ksifre.Location = new System.Drawing.Point(129, 44);
            this.txt_ksifre.Name = "txt_ksifre";
            this.txt_ksifre.Size = new System.Drawing.Size(200, 23);
            this.txt_ksifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Şifre :";
            // 
            // txt_kad
            // 
            this.txt_kad.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kad.ForeColor = System.Drawing.Color.Red;
            this.txt_kad.Location = new System.Drawing.Point(129, 18);
            this.txt_kad.Name = "txt_kad";
            this.txt_kad.Size = new System.Drawing.Size(200, 23);
            this.txt_kad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // frm_kullanici_guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(374, 220);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "frm_kullanici_guncelle";
            this.Text = "Kullanıcı Güncelle";
            this.Load += new System.EventHandler(this.frm_kullanici_guncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_yonetici;
        private System.Windows.Forms.RadioButton rb_kullanici;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_pasif;
        private System.Windows.Forms.RadioButton rb_aktif;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_ksifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kad;
        private System.Windows.Forms.Label label1;
    }
}