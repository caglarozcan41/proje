using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dosyasifrelemeuygulamasi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi;
            string sifre;
            kullaniciadi = textBox2.Text;
            sifre = textBox1.Text;

            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Lütfen Kullanıcı Adı giriniz.");
                return;
            }
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Lütfen bir şifre giriniz.");
                return;
            }


            if (kullaniciadi == "caglar" && sifre == "123")
            {
                MessageBox.Show("Giriş Başarılı");

                Form5 frm5 = new Form5();
                frm5.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre Yanlış");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
            }
        }
    }
}
