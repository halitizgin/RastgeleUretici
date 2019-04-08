using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastgeleÜreticiv1._00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] karakterler = { '\"', '}', '{', '(', ')', '[', ']', '/', '&', '$', '+', '#', '^', '!', '%', '=', '?', '*', '_', '\'' };
            char[] harfler = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z', 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z'};
            char[] sayilar = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] hepsi = { '\"', '}', '{', '(', ')', '[', ']', '/', '&', '$', '+', '#', '^', '!', '%', '=', '?', '*', '-', '_', '\'', 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z', 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char karakter_temsil = 'K', sayi_temsil = 'S', harf_temsil = 'H', hepsi_temsil = 'İ';
            if (textBox1.Text.Trim() != "")
            {
                errorProvider1.SetError(textBox1, "");
                listView1.Items.Clear();
                if (textBox2.Text != "")
                {
                    errorProvider1.SetError(textBox2, "");
                    Random rastgele = new Random();
                    string uretilen = "";
                    int uretilen_sayi = 0;
                    int uretilecek = Convert.ToInt32(textBox2.Text);
                    string metin = textBox1.Text;
                    int sayi = 0;

                    int sira = 0;

                    for (int i = 1; i <= uretilecek; i++)
                    {
                        for (int m = 0; m < metin.Length; m++)
                        {
                            char karakter = Convert.ToChar(metin.Substring(m, 1));
                            if (karakter == karakter_temsil)
                            {
                                sayi = rastgele.Next(0, karakterler.Length);
                                uretilen = uretilen + karakterler[sayi].ToString();
                            }
                            else if (karakter == sayi_temsil)
                            {
                                sayi = rastgele.Next(0, sayilar.Length);
                                uretilen = uretilen + sayilar[sayi].ToString();
                            }
                            else if (karakter == harf_temsil)
                            {
                                sayi = rastgele.Next(0, harfler.Length);
                                uretilen = uretilen + harfler[sayi].ToString();
                            }
                            else if (karakter == hepsi_temsil)
                            {
                                sayi = rastgele.Next(0, hepsi.Length);
                                uretilen = uretilen + hepsi[sayi].ToString();
                            }
                            else
                            {
                                uretilen = uretilen + karakter.ToString();
                            }
                        }

                        uretilen_sayi++;

                        sira = listView1.Items.Count;

                        listView1.Items.Add(uretilen_sayi.ToString());
                        listView1.Items[sira].SubItems.Add(uretilen);

                        uretilen = "";

                        decimal yuzde = ((decimal)uretilen_sayi / (decimal)uretilecek) * 100;
                        progressBar1.Value = Convert.ToInt32(Math.Floor(yuzde));

                    }
                }
                else
                {
                    errorProvider1.SetError(textBox2, "Buraya adeti giriniz.");
                }
            }
            else
            {
                errorProvider1.SetError(textBox1, "Buraya kodları giriniz.");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                try
                {
                    errorProvider1.SetError(listView1, "");
                    saveFileDialog1.Title = "Rastgele Üretici | Kayıt";
                    saveFileDialog1.Filter = "Metin Dosyaları (*.txt)|*.txt";
                    saveFileDialog1.ShowDialog();
                    StreamWriter kayit = new StreamWriter(saveFileDialog1.FileName);
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        kayit.WriteLine(listView1.Items[i].SubItems[1].Text);
                    }
                    kayit.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                errorProvider1.SetError(listView1, "En az bir veri bulunması gerekmektedir.");
            }
        }

        private void seçileniKopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kopyalanacak = "";
            if (listView1.SelectedItems.Count > 0)
            {
                errorProvider1.SetError(listView1, "");
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    kopyalanacak = kopyalanacak + item.SubItems[1].Text;
                }
                Clipboard.SetText(kopyalanacak);
            }
            else
            {
                errorProvider1.SetError(listView1, "Herhangi bir veri seçmeniz gerekmektedir.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                errorProvider1.SetError(textBox3, "");
                char[] karakterler = { '\"', '}', '{', '(', ')', '[', ']', '/', '&', '$', '+', '#', '^', '!', '%', '=', 'é', '*', '_', '\'', '~', '>', '<', '|' };
                char[] harfler = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z', 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
                char[] sayilar = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
                char[] hepsi = { '\"', '}', '{', '(', ')', '[', ']', '/', '&', '$', '+', '#', '^', '!', '%', '=', '?', '*', '_', '\'', 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z', 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
                string cevirilecek = textBox3.Text;
                string olusan = "";
                int hatali = 0;
                char yazilacak = '?';
                for (int i = 0; i < cevirilecek.Length; i++)
                {
                    char karakter = char.Parse(cevirilecek.Substring(i, 1));

                    if (karakter == '-')
                    {
                        yazilacak = '-';
                    }
                    else
                    {
                        for (int m = 0; m < karakterler.Length; m++)
                        {
                            if (karakter == karakterler[m])
                            {
                                MessageBox.Show(karakter.ToString());
                                yazilacak = 'K';
                            }
                        }

                        for (int c = 0; c < harfler.Length; c++)
                        {
                            if (karakter == harfler[c])
                            {
                                yazilacak = 'H';
                            }
                        }

                        for (int k = 0; k < sayilar.Length; k++)
                        {
                            if (karakter == sayilar[k])
                            {
                                yazilacak = 'S';
                            }
                        }
                    }

                    if (yazilacak == '?')
                    {
                        hatali++;
                    }

                    olusan = olusan + yazilacak;
                }
                if (hatali > 0)
                {
                    errorProvider1.SetError(textBox3, hatali + " adet karakterin kodu çözümlenemedi.");
                    
                    textBox1.Text = olusan;
                }
                else
                {
                    errorProvider1.SetError(textBox3, "");
                    textBox1.Text = olusan;
                }
                
            }
            else
            {
                errorProvider1.SetError(textBox3, "Burası boş bırakılamaz.");
                errorProvider1.SetIconAlignment(textBox3, ErrorIconAlignment.BottomLeft);
            }
        }

        private void hepsiniKopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                errorProvider1.SetError(listView1, "");
                string kopyalanacak = "";
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (kopyalanacak == "")
                    {
                        kopyalanacak = listView1.Items[i].SubItems[1].Text;
                    }
                    else
                    {
                        kopyalanacak = kopyalanacak + "      -       " + listView1.Items[i].SubItems[1].Text;
                    }
                }

                Clipboard.SetText(kopyalanacak);
            }
            else
            {
                errorProvider1.SetError(listView1, "En az bir adet veri bulunması gerekmektedir.");
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void rastgeleÜreticiYardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("\\Resources\\Rastgele_Üretici_Yardım.chm");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
            }
        }

        private void rastgeleÜreticiYardımToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void helpDosyasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process yardim = new Process();
            yardim.StartInfo.FileName = Application.StartupPath.ToString() + "\\Resources\\Rastgele_Üretici_Yardım.chm";
            yardim.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            yardim.Start();
        }

        private void hTMLDosyasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process yardim = new Process();
            yardim.StartInfo.FileName = Application.StartupPath.ToString() + "\\Resources\\Rastgele_Üretici_Yardım.html";
            yardim.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            yardim.Start();
        }
    }
}
