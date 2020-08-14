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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGerigit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "admin" && txtPw.Text == "admin")
            {
                
                MessageBox.Show("Yönetici olarak giriş yapılıyor.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form4 f4 = new Form4();
                this.Hide();
                f4.ShowDialog();
            }
            else
            {
                
                MessageBox.Show("Giriş sağlanamadı!", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtPw.PasswordChar = '*';
        }
    }
}
