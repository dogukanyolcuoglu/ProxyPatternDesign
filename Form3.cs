using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyPatternWork
{
    public partial class Form3 : Form
    {
        public int daireNo { get; set; }
        public string parola { get; set; }
        public string AdSoyad { get; set; }
        public string IBAN { get; set; }

        public Form3()
        {
            InitializeComponent();
        }
        public void TextCek(TextBox text1 , TextBox text2)
        {
            daireNo = Convert.ToInt32(text1.Text);
            parola = text2.Text;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();

            if (kullanici.KontrolEt(daireNo, parola))
            {
                if (daireNo == 1)
                {
                    pictureBox1.Image = Properties.Resources.dogukan1;
                    label1.Location = new Point(10, 200);
                }
                else if (daireNo == 2)
                {
                    pictureBox1.Image = Properties.Resources.mert1;
                    label1.Location = new Point(35, 200);
                }
                else if (daireNo == 3)
                {
                    pictureBox1.Image = Properties.Resources.ender1;
                    label1.Location = new Point(30, 200);
                }
                else if (daireNo == 4)
                {
                    pictureBox1.Image = Properties.Resources.eray1;
                    label1.Location = new Point(32, 200);
                }
                if (kullanici.aylikAidatOdemesi == true)
                {
                    label2.Text = "Aidat Borcu : Ödendi.";
                }
                else
                {
                    label2.Text = "Aidat Borcu : " + "180 TL\nSon ödeme tarihi : 30/06/2020";
                }
                label1.Text = kullanici.AdSoyad;
                label3.Text = "Elektrik Tutarı : " + kullanici.elektrik + "TL" + "\nSon ödeme tarihi : " + kullanici.tarih[0];
                label4.Text = "Su Tutarı : " + kullanici.su + "TL" + "\nSon ödeme tarihi : " + kullanici.tarih[1];
                label5.Text = "Doğalgaz Tutarı : " + kullanici.dogalgaz + "TL" + "\nSon ödeme tarihi : " + kullanici.tarih[2];
                label6.Text = kullanici._daireNo.ToString() +"-Nolu Konut'un Borç Bilgileri";
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = " (*.jpg)|*.jpg|(*.png)|*.png";

            if(fd.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = new Bitmap(fd.OpenFile());
            }

        }
        private void btnAnaEkran_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void btnOde_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
             
             if(radioAidat.Checked == false && radioElektrik.Checked == false && radioSu.Checked == false && radioDogalgaz.Checked == false)
             {
                MessageBox.Show("Ödenecek borcu seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
             else if (IBAN == null && AdSoyad == null)
             {
                    MessageBox.Show("Ödeme yapabilecek kayıtlı hesap bulunmamaktadır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
             else
             {
                if (kullanici.KontrolEt(daireNo, parola))
                {
                    if (daireNo == 1)
                    {
                        if (radioAidat.Checked == true)
                        {

                            kullanici.aylikAidatOdemesi = true;
                            MessageBox.Show("İşleminiz devam ediyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(AdSoyad + "\n\nTR" +IBAN + "\n\nHesabında ödeme yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label2.Text = "Aidat Borcu : Ödendi.";
                            
                        }
                        else if (radioElektrik.Checked == true)
                        {
                            kullanici.elektrik = 0;
                            MessageBox.Show("İşleminiz devam ediyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(AdSoyad + "\n\nTR" + IBAN + "\n\nHesabında ödeme yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label3.Text = "Elektrik Faturası : Ödendi.";
                        }
                        else if (radioSu.Checked == true)
                        {
                            kullanici.su = 0;
                            MessageBox.Show("İşleminiz devam ediyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(AdSoyad + "\n\nTR" + IBAN + "\n\nHesabında ödeme yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label4.Text = "Su Faturası : Ödendi.";
                            
                        }
                        else if (radioDogalgaz.Checked == true)
                        {
                            kullanici.dogalgaz = 0;
                            MessageBox.Show("İşleminiz devam ediyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(AdSoyad + "\n\nTR" + IBAN + "\n\nHesabında ödeme yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label5.Text = "Doğalgaz Faturası : Ödendi.";
                            
                        }
                    }
                    else if (daireNo == 2)
                    {
                        if (radioAidat.Checked == true)
                        {

                            kullanici.aylikAidatOdemesi = true;
                            MessageBox.Show("İşleminiz devam ediyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(AdSoyad + "\n\nTR" + IBAN + "\n\nHesabından ödeme yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label2.Text = "Aidat Borcu : Ödendi.";

                        }
                        else if (radioElektrik.Checked == true)
                        {
                            kullanici.elektrik = 0;
                            MessageBox.Show("İşleminiz devam ediyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(AdSoyad + "\n\nTR" + IBAN + "\n\nHesabından ödeme yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label3.Text = "Elektrik Faturası : Ödendi.";
                        }
                        else if (radioSu.Checked == true)
                        {
                            kullanici.su = 0;
                            MessageBox.Show("İşleminiz devam ediyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(AdSoyad + "\n\nTR" + IBAN + "\n\nHesabında ödeme yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label4.Text = "Su Faturası : Ödendi.";

                        }
                        else if (radioDogalgaz.Checked == true)
                        {
                            kullanici.dogalgaz = 0;
                            MessageBox.Show("İşleminiz devam ediyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(AdSoyad + "\n\nTR" + IBAN + "\n\nHesabında ödeme yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label5.Text = "Doğalgaz Faturası : Ödendi.";

                        }
                    }
                    else if (daireNo == 3)
                    {
                        if (radioAidat.Checked == true)
                        {

                            kullanici.aylikAidatOdemesi = true;
                            MessageBox.Show("İşleminiz devam ediyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(AdSoyad + "\n\nTR" + IBAN + "\n\nHesabından ödeme yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label2.Text = "Aidat Borcu : Ödendi.";

                        }
                        else if (radioElektrik.Checked == true)
                        {
                            kullanici.elektrik = 0;
                            MessageBox.Show("İşleminiz devam ediyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(AdSoyad + "\n\nTR" + IBAN + "\n\nHesabından ödeme yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label3.Text = "Elektrik Faturası : Ödendi.";
                        }
                        else if (radioSu.Checked == true)
                        {
                            kullanici.su = 0;
                            MessageBox.Show("İşleminiz devam ediyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(AdSoyad + "\n\nTR" + IBAN + "\n\nHesabında ödeme yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label4.Text = "Su Faturası : Ödendi.";

                        }
                        else if (radioDogalgaz.Checked == true)
                        {
                            kullanici.dogalgaz = 0;
                            MessageBox.Show("İşleminiz devam ediyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(AdSoyad + "\n\nTR" + IBAN + "\n\nHesabında ödeme yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label5.Text = "Doğalgaz Faturası : Ödendi.";

                        }
                    }
                    else if (daireNo == 4)
                    {
                        if (radioAidat.Checked == true)
                        {

                            kullanici.aylikAidatOdemesi = true;
                            MessageBox.Show("İşleminiz devam ediyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(AdSoyad + "\n\nTR" + IBAN + "\n\nHesabından ödeme yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label2.Text = "Aidat Borcu : Ödendi.";

                        }
                        else if (radioElektrik.Checked == true)
                        {
                            kullanici.elektrik = 0;
                            MessageBox.Show("İşleminiz devam ediyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(AdSoyad + "\n\nTR" + IBAN + "\n\nHesabından ödeme yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label3.Text = "Elektrik Faturası : Ödendi.";
                        }
                        else if (radioSu.Checked == true)
                        {
                            kullanici.su = 0;
                            MessageBox.Show("İşleminiz devam ediyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(AdSoyad + "\n\nTR" + IBAN + "\n\nHesabında ödeme yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label4.Text = "Su Faturası : Ödendi.";

                        }
                        else if (radioDogalgaz.Checked == true)
                        {
                            kullanici.dogalgaz = 0;
                            MessageBox.Show("İşleminiz devam ediyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(AdSoyad + "\n\nTR" + IBAN + "\n\nHesabında ödeme yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label5.Text = "Doğalgaz Faturası : Ödendi.";

                        }
                    }
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.DegerCek(daireNo, parola);
            this.Hide();
            f5.ShowDialog();
        }
    }
}
