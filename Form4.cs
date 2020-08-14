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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Kullanici k1 = new Kullanici();
            Kullanici k2 = new Kullanici();
            Kullanici k3 = new Kullanici();
            Kullanici k4 = new Kullanici();
            k1.KontrolEt(1, "1234");
            k2.KontrolEt(2, "1234");
            k3.KontrolEt(3, "1234");
            k4.KontrolEt(4, "1234");
            label7.Text = k1._daireNo + "-Nolu\n\n" + k2._daireNo+ "-Nolu\n\n" + k3._daireNo + "-Nolu\n\n" + k4._daireNo + "-Nolu\n\n";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            Kullanici k1 = new Kullanici();
            Kullanici k2 = new Kullanici();
            Kullanici k3 = new Kullanici();
            Kullanici k4 = new Kullanici();
            k1.KontrolEt(1, "1234");
            k2.KontrolEt(2, "1234");
            k3.KontrolEt(3, "1234");
            k4.KontrolEt(4, "1234");
            if (Convert.ToInt32(textBox1.Text) == 1)
            {
                label2.Text = "Ad Soyad : \n-" + k1.AdSoyad;
                label5.Text = "Mülk Durumu :\n-" + k1.mulkDurumu;
                if(k1.aylikAidatOdemesi == true)
                {
                    label6.Text = "Aidat Borcu :\n-Ödendi.";
                }
                else
                {
                    label6.Text = "Aidat Borcu :\n-180 TL borcu var.";
                }
                
            }
            else if(Convert.ToInt32(textBox1.Text) == 2)
            {
                label2.Text = "Ad Soyad : \n-" + k2.AdSoyad;
                label5.Text = "Mülk Durumu :\n-" + k2.mulkDurumu;
                if (k2.aylikAidatOdemesi == true)
                {
                    label6.Text = "Aidat Borcu :\n-Ödendi.";
                }
                else
                {
                    label6.Text = "Aidat Borcu :\n-180 TL borcu var.";
                }
            }
            else if (Convert.ToInt32(textBox1.Text) == 3)
            {
                label2.Text = "Ad Soyad : \n-" + k3.AdSoyad;
                label5.Text = "Mülk Durumu :\n-" + k3.mulkDurumu;
                if (k3.aylikAidatOdemesi == true)
                {
                    label6.Text = "Aidat Borcu :\n-Ödendi.";
                }
                else
                {
                    label6.Text = "Aidat Borcu :\n-180 TL borcu var.";
                }
            }
            else if (Convert.ToInt32(textBox1.Text) == 4)
            {
                label2.Text = "Ad Soyad : \n-" + k4.AdSoyad;
                label5.Text = "Mülk Durumu :\n-" + k4.mulkDurumu;
                if (k4.aylikAidatOdemesi == true)
                {
                    label6.Text = "Aidat Borcu :\n-Ödendi.";
                }
                else
                {
                    label6.Text = "Aidat Borcu :\n-180 TL borcu var.";
                }
            }
        }
    }
}
