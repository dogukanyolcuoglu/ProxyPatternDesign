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
    public class Kullanici : IKullanici
    {
        public int _daireNo { get; set; }
        public string AdSoyad { get; set; }
        public string mulkDurumu { get; set; }
        public bool aylikAidatOdemesi { get; set; }
        public double elektrik { get; set; }
        public double su { get; set; }
        public double dogalgaz { get; set; }

        public string[] tarih = new string[10];
        public bool KontrolEt(int daireNo, string PassWord)
        {
            if (daireNo == 1)
            {
                _daireNo = 1;
                AdSoyad = "DOĞUKAN YOLCUOĞLU";
                mulkDurumu = "Ev Sahibi";
                aylikAidatOdemesi = false;
                elektrik = 252.61;
                su = 158.89;
                dogalgaz = 303.87;
                tarih[0] = "28/06/2020";
                tarih[1] = "20/06/2020";
                tarih[2] = "04/07/2020";
                return true;
            }
            else if (daireNo == 2)
            {
                _daireNo = 2;
                AdSoyad = "MERT GÜVEN";
                mulkDurumu = "Kiracı";
                aylikAidatOdemesi = true;
                elektrik = 219.43;
                su = 125.64;
                dogalgaz = 281.45;
                tarih[0] = "20/06/2020";
                tarih[1] = "16/06/2020";
                tarih[2] = "09/07/2020";
                return true;
            }
            else if(daireNo == 3)
            {
                _daireNo = 3;
                AdSoyad = "ENDER GÜLGER";
                mulkDurumu = "Ev Sahibi";
                aylikAidatOdemesi = true;
                elektrik = 210.48;
                su = 90.39;
                dogalgaz = 450.92;
                tarih[0] = "25/06/2020";
                tarih[1] = "21/06/2020";
                tarih[2] = "10/07/2020";
                return true;

            }
            else if (daireNo == 4)
            {
                _daireNo = 4;
                AdSoyad = "ERAY HAMURLU";
                mulkDurumu = "Kiracı";
                aylikAidatOdemesi = false;
                elektrik = 315.65;
                su = 150.02;
                dogalgaz = 567.13;
                tarih[0] = "22/06/2020";
                tarih[1] = "18/06/2020";
                tarih[2] = "07/07/2020";
                return true;
            }
            else
            {
                return false;
            }
                
        }
    }
}
