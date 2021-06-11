using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dosyasifrelemeuygulamasi
{
    public partial class Form1 : Form
    {
        byte[] abc;
        byte[,] table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {

            }
            sifrele.Checked = true;
           
            abc = new byte[256];
            for (int i = 0; i < 256; i++)
                abc[i] = Convert.ToByte(i);
            

            table = new byte[256, 256];
            for (int i = 0; i < 256; i++)
                for(int j = 0; j < 256; j++)
                {
                    table[i, j] = abc[(i + j) % 256];
                }

        }

        private void gozat_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if(od.ShowDialog() == DialogResult.OK)
            {
                dosyaKonumu.Text = od.FileName;
            }
            
            
           

        }

        private void sifrele_CheckedChanged(object sender, EventArgs e)
        {
            if(sifrele.Checked)
            {
                sifreKaldir.Checked = false;
            }
        }

        private void sifreKaldir_CheckedChanged(object sender, EventArgs e)
        {
            if(sifreKaldir.Checked)
                sifrele.Checked = false;
            
        }

        private void baslat_Click(object sender, EventArgs e)
        {
            if(!File.Exists(dosyaKonumu.Text))
            {
                MessageBox.Show("Dosya Seçiniz.");
                return;
            }
            try
            {
              byte[] fileContent = File.ReadAllBytes(dosyaKonumu.Text);
                byte[] passwordTmp = Encoding.ASCII.GetBytes(Text);
                byte[] keys = new byte[fileContent.Length];
                for (int i = 0; i < fileContent.Length; i++)
                    keys[i] = passwordTmp[i % passwordTmp.Length];

                byte[] result = new byte[fileContent.Length];

                if (sifrele.Checked)
                {
                    {
                        MessageBox.Show("Şifreleme Başarılı! Lütfen kayıt yerini seçiniz.");
                    }
                  for(int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;
                        for(int j = 0; j < 256; j++)
                            if(abc[j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        for(int j = 0; j < 256; j++)
                            if(abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        result[i] = table[keyIndex, valueIndex];
                    }
                }

                else
                {
                    {
                        MessageBox.Show("Dosya Şifresi Başarıyla Kaldırıldı! Lütfen kayıt yerini seçiniz.");
                    }
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;                      
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (table[keyIndex, j] == value)
                            {
                                valueIndex = j;
                                break;
                            }                  
                        result[i] = abc[valueIndex];
                    }
                }
                String fileExt = Path.GetExtension(dosyaKonumu.Text);
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Files  (*" + fileExt + ") | *" + fileExt;
                if(sd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sd.FileName, result);
                }
            }
            catch
            {
                MessageBox.Show("Dosya Kullanımda. Kullanımdaki dosyayı kapatınız ve tekrar deneyiniz.");
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dosyaKonumu_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifreleme2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void sifreleme3_Click(object sender, EventArgs e)
        {

        }

        private void sifreGir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
