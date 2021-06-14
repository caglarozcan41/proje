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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        aesSifrele AESsifrelee = new aesSifrele();


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sifrekaldir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Metin kısmını doldurunuz.");
            }
           

            sifresizmetin.Text = AESsifrelee.AESsifrecoz(textBox2.Text);
        }

        private void sifrele_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Metin kısmını doldurunuz.");
            }
            textBox2.Text = AESsifrelee.AESsifrele(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Form5 frm5 = new Form5();
                frm5.Show();
                this.Hide();
            
        }
    }
}
