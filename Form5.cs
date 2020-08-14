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
    public partial class Form5 : Form
    {
        public string AdSoyad { get; set; }
        public string  IBAN { get; set; }
        public int daireNo { get; set; }
        public string parola { get; set; }
        public Form5()
        {
            InitializeComponent();
        }
        public void DegerCek(int _daireNo, string _Parola)
        {
            daireNo = _daireNo;
            parola = _Parola;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Kullanici k = new Kullanici();
            if(k.KontrolEt(daireNo, parola))
            {
                if (daireNo == 1)
                {
                    pictureBox1.Image = Properties.Resources.dogukan1;
                    lblAdSoyad.Location = new Point(10, 170);
                }
                else if (daireNo == 2)
                {
                    pictureBox1.Image = Properties.Resources.mert1;
                    lblAdSoyad.Location = new Point(35, 170); 
                }
                else if (daireNo == 3)
                {
                    pictureBox1.Image = Properties.Resources.ender1;
                    lblAdSoyad.Location = new Point(30, 170);
                }
                else if (daireNo == 4)
                {
                    pictureBox1.Image = Properties.Resources.eray1;
                    lblAdSoyad.Location = new Point(32, 170);
                }
                lblAdSoyad.Text = k.AdSoyad;
            }
            txtSifre1.PasswordChar = '*';
            txtSifre2.PasswordChar = '*';
            txtIBAN.MaxLength = 24;
            txtKod.MaxLength = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.daireNo = daireNo;
            f3.parola = parola;
            f3.IBAN = IBAN;
            f3.AdSoyad = AdSoyad;

            this.Hide();
            f3.ShowDialog();
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtIBAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtSifre1.Text != txtSifre2.Text )
            {
                MessageBox.Show("Şifreleriniz aynı değil !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IBAN = txtIBAN.Text.ToString();
                AdSoyad = txtAdSoyad.Text;
                MessageBox.Show("Hesap kaydetme işlemi tamamlandı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
