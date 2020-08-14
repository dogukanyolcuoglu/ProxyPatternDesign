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
    class ProxyKullanici : IKullanici
    {

        private Kullanici _Kullanici;
        private bool login;

        public bool KontrolEt(int daireNo, string PassWord)
        {
            if (daireNo == 1 && PassWord == "1234")
            {
                login = true;
                _Kullanici = new Kullanici();
                MessageBox.Show("Kullanıcı bilgileri yükleniyor.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                _Kullanici.KontrolEt(daireNo, PassWord);
                return login;
            }
            else if(daireNo == 2 && PassWord == "1234")
            {
                login = true;
                _Kullanici = new Kullanici();
                MessageBox.Show("Kullanıcı bilgileri yükleniyor.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Kullanici.KontrolEt(daireNo, PassWord);
                return login;
            }
            else if (daireNo == 3 && PassWord == "1234")
            {
                login = true;
                _Kullanici = new Kullanici();
                MessageBox.Show("Kullanıcı bilgileri yükleniyor.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Kullanici.KontrolEt(daireNo, PassWord);
                return login;
            }
            else if (daireNo == 4 && PassWord == "1234")
            {
                login = true;
                _Kullanici = new Kullanici();
                MessageBox.Show("Kullanıcı bilgileri yükleniyor.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Kullanici.KontrolEt(daireNo, PassWord);
                return login;
            }
            else
            {
                login = false;
                MessageBox.Show("Giriş sağlanamadı!","UYARI",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                return login;
            }
        }
    }
}
