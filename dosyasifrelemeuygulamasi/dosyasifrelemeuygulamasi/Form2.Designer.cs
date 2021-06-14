
namespace dosyasifrelemeuygulamasi
{
    partial class Form2
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
            this.metin = new System.Windows.Forms.Label();
            this.sifrelimetin = new System.Windows.Forms.Label();
            this.sifresizmetin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sifrele = new System.Windows.Forms.Button();
            this.sifrekaldir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metin
            // 
            this.metin.AutoSize = true;
            this.metin.Location = new System.Drawing.Point(48, 15);
            this.metin.Name = "metin";
            this.metin.Size = new System.Drawing.Size(33, 13);
            this.metin.TabIndex = 0;
            this.metin.Text = "Metin";
            // 
            // sifrelimetin
            // 
            this.sifrelimetin.AutoSize = true;
            this.sifrelimetin.Location = new System.Drawing.Point(20, 41);
            this.sifrelimetin.Name = "sifrelimetin";
            this.sifrelimetin.Size = new System.Drawing.Size(61, 13);
            this.sifrelimetin.TabIndex = 2;
            this.sifrelimetin.Text = "Şifreli Metin";
            // 
            // sifresizmetin
            // 
            this.sifresizmetin.Location = new System.Drawing.Point(89, 64);
            this.sifresizmetin.Name = "sifresizmetin";
            this.sifresizmetin.Size = new System.Drawing.Size(282, 20);
            this.sifresizmetin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifresiz Metin";
            // 
            // sifrele
            // 
            this.sifrele.ForeColor = System.Drawing.Color.Red;
            this.sifrele.Location = new System.Drawing.Point(215, 90);
            this.sifrele.Name = "sifrele";
            this.sifrele.Size = new System.Drawing.Size(75, 23);
            this.sifrele.TabIndex = 6;
            this.sifrele.Text = "Şifrele";
            this.sifrele.UseVisualStyleBackColor = true;
            this.sifrele.Click += new System.EventHandler(this.sifrele_Click);
            // 
            // sifrekaldir
            // 
            this.sifrekaldir.ForeColor = System.Drawing.Color.Green;
            this.sifrekaldir.Location = new System.Drawing.Point(296, 90);
            this.sifrekaldir.Name = "sifrekaldir";
            this.sifrekaldir.Size = new System.Drawing.Size(75, 23);
            this.sifrekaldir.TabIndex = 7;
            this.sifrekaldir.Text = "Şifreyi Kaldır";
            this.sifrekaldir.UseVisualStyleBackColor = true;
            this.sifrekaldir.Click += new System.EventHandler(this.sifrekaldir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(282, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ana Ekrana Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 124);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sifrekaldir);
            this.Controls.Add(this.sifrele);
            this.Controls.Add(this.sifresizmetin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.sifrelimetin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "AES Şifreleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label metin;
        private System.Windows.Forms.Label sifrelimetin;
        private System.Windows.Forms.TextBox sifresizmetin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sifrele;
        private System.Windows.Forms.Button sifrekaldir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}