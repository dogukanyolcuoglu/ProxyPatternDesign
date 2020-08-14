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
    public partial class Form1 : Form
    {
        public int daireNo { get; set; }
        public string parola { get; set; }

        public Form1()
        {

            InitializeComponent();
        }

        private void btnYonetim_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.TextCek(txtDaireNo, txtParola);

            ProxyKullanici _proxy = new ProxyKullanici();
            if(_proxy.KontrolEt(Convert.ToInt32(txtDaireNo.Text),txtParola.Text))
            {
                this.Hide();
                f3.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtParola.PasswordChar = '*';
        }

        private void txtDaireNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}