
namespace dosyasifrelemeuygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dosyaKonumu = new System.Windows.Forms.TextBox();
            this.gozat = new System.Windows.Forms.Button();
            this.sifrele = new System.Windows.Forms.RadioButton();
            this.sifreKaldir = new System.Windows.Forms.RadioButton();
            this.sifreGir = new System.Windows.Forms.TextBox();
            this.baslat = new System.Windows.Forms.Button();
            this.sifreleme2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Konumu";
            // 
            // dosyaKonumu
            // 
            this.dosyaKonumu.Location = new System.Drawing.Point(16, 25);
            this.dosyaKonumu.Name = "dosyaKonumu";
            this.dosyaKonumu.ReadOnly = true;
            this.dosyaKonumu.Size = new System.Drawing.Size(314, 20);
            this.dosyaKonumu.TabIndex = 1;
            this.dosyaKonumu.TextChanged += new System.EventHandler(this.dosyaKonumu_TextChanged);
            // 
            // gozat
            // 
            this.gozat.Location = new System.Drawing.Point(333, 23);
            this.gozat.Name = "gozat";
            this.gozat.Size = new System.Drawing.Size(75, 23);
            this.gozat.TabIndex = 2;
            this.gozat.Text = "Gözat";
            this.gozat.UseVisualStyleBackColor = true;
            this.gozat.Click += new System.EventHandler(this.gozat_Click);
            // 
            // sifrele
            // 
            this.sifrele.AutoSize = true;
            this.sifrele.ForeColor = System.Drawing.Color.Green;
            this.sifrele.Location = new System.Drawing.Point(16, 51);
            this.sifrele.Name = "sifrele";
            this.sifrele.Size = new System.Drawing.Size(54, 17);
            this.sifrele.TabIndex = 3;
            this.sifrele.TabStop = true;
            this.sifrele.Text = "Şifrele";
            this.sifrele.UseVisualStyleBackColor = true;
            this.sifrele.CheckedChanged += new System.EventHandler(this.sifrele_CheckedChanged);
            // 
            // sifreKaldir
            // 
            this.sifreKaldir.AutoSize = true;
            this.sifreKaldir.ForeColor = System.Drawing.Color.Red;
            this.sifreKaldir.Location = new System.Drawing.Point(69, 51);
            this.sifreKaldir.Name = "sifreKaldir";
            this.sifreKaldir.Size = new System.Drawing.Size(82, 17);
            this.sifreKaldir.TabIndex = 4;
            this.sifreKaldir.TabStop = true;
            this.sifreKaldir.Text = "Şifreyi Kaldır";
            this.sifreKaldir.UseVisualStyleBackColor = true;
            this.sifreKaldir.CheckedChanged += new System.EventHandler(this.sifreKaldir_CheckedChanged);
            // 
            // sifreGir
            // 
            this.sifreGir.Location = new System.Drawing.Point(0, 290);
            this.sifreGir.Name = "sifreGir";
            this.sifreGir.PasswordChar = '*';
            this.sifreGir.Size = new System.Drawing.Size(10, 20);
            this.sifreGir.TabIndex = 6;
            this.sifreGir.Visible = false;
            this.sifreGir.TextChanged += new System.EventHandler(this.sifreGir_TextChanged);
            // 
            // baslat
            // 
            this.baslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslat.Location = new System.Drawing.Point(12, 74);
            this.baslat.Name = "baslat";
            this.baslat.Size = new System.Drawing.Size(392, 48);
            this.baslat.TabIndex = 7;
            this.baslat.Text = "Başlat";
            this.baslat.UseVisualStyleBackColor = true;
            this.baslat.Click += new System.EventHandler(this.baslat_Click);
            // 
            // sifreleme2
            // 
            this.sifreleme2.Location = new System.Drawing.Point(12, 128);
            this.sifreleme2.Name = "sifreleme2";
            this.sifreleme2.Size = new System.Drawing.Size(156, 23);
            this.sifreleme2.TabIndex = 14;
            this.sifreleme2.Text = "Ana Ekrana Dön";
            this.sifreleme2.UseVisualStyleBackColor = true;
            this.sifreleme2.Click += new System.EventHandler(this.sifreleme2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 168);
            this.Controls.Add(this.sifreleme2);
            this.Controls.Add(this.baslat);
            this.Controls.Add(this.sifreGir);
            this.Controls.Add(this.sifreKaldir);
            this.Controls.Add(this.sifrele);
            this.Controls.Add(this.gozat);
            this.Controls.Add(this.dosyaKonumu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Dosya Şifreleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dosyaKonumu;
        private System.Windows.Forms.Button gozat;
        private System.Windows.Forms.RadioButton sifrele;
        private System.Windows.Forms.RadioButton sifreKaldir;
        private System.Windows.Forms.TextBox sifreGir;
        private System.Windows.Forms.Button baslat;
        private System.Windows.Forms.Button sifreleme2;
    }
}

