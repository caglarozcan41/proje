using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dosyasifrelemeuygulamasi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "MD5":
                    MessageBox.Show("Şifreleme Başarılı!");
                    textBox2.Text = md5(textBox1.Text);
                    break;
                
                case "SHA1":
                    MessageBox.Show("Şifreleme Başarılı!");
                    textBox2.Text = sha1(textBox1.Text);
                    break;

                case "SHA256":
                    MessageBox.Show("Şifreleme Başarılı!");
                    textBox2.Text = sha256(textBox1.Text);
                    break;

                case "SHA384":
                    MessageBox.Show("Şifreleme Başarılı!");
                    textBox2.Text = sha384(textBox1.Text);
                    break;

                case "SHA512":
                    MessageBox.Show("Şifreleme Başarılı!");
                    textBox2.Text = sha512(textBox1.Text);
                    break;

                default:
                    MessageBox.Show("Lütfen Şifreleme Metodu Seçiniz.");
                    break;
            }
        }

        private string md5(string text)
        {
            MD5 md5sifreleme = new MD5CryptoServiceProvider();
            byte[] bytes = md5sifreleme.ComputeHash(Encoding.UTF8.GetBytes(text));

                StringBuilder builder = new StringBuilder();

            foreach (var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }

            return builder.ToString();
        }

        private string sha1(string text)
        {
            SHA1 sha1sifreleme = new SHA1CryptoServiceProvider();

            byte[] bytes = sha1sifreleme.ComputeHash(Encoding.UTF8.GetBytes(text));

            StringBuilder builder = new StringBuilder();

            foreach (var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }

            return builder.ToString();
        }
        private string sha256(string text)
        {
            SHA256 sha256sifreleme = new SHA256CryptoServiceProvider();

            byte[] bytes = sha256sifreleme.ComputeHash(Encoding.UTF8.GetBytes(text));

            StringBuilder builder = new StringBuilder();

            foreach (var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }

            return builder.ToString();
        }

        private string sha384(string text)
        {
            SHA384 sha384sifreleme = new SHA384CryptoServiceProvider();

            byte[] bytes = sha384sifreleme.ComputeHash(Encoding.UTF8.GetBytes(text));

            StringBuilder builder = new StringBuilder();

            foreach (var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }

            return builder.ToString();
        }

        private string sha512(string text)
        {
            SHA512 sha512sifreleme = new SHA512CryptoServiceProvider();

            byte[] bytes = sha512sifreleme.ComputeHash(Encoding.UTF8.GetBytes(text));

            StringBuilder builder = new StringBuilder();

            foreach (var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }

            return builder.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
            MessageBox.Show("Şifre Kopyalandı!");
        }
    }
}
