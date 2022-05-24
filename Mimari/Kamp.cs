using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    public class Kamp: IKonaklama
    {
        public string Ad;
        public string Konum;
        public int Gun;
        public int KisiSayi;
        public int Fiyat = 250;
        public Kamp(string kampSehir, string kampAd, int kampSure, int kampKisiSayi)
        {
            Konum = kampSehir;
            Ad = kampAd;
            Gun = kampSure;
            KisiSayi = kampKisiSayi;
        }

        public string Sehir()
        {
            return Konum;
        }
        public string MekanAdi()
        {
            return Ad;
        }
        public int Sure()
        {
            return Gun;
        }
        public int Tutar()
        {
            return 1000;
        }
        public string KonaklamaBilgileri()
        {
            return Konum + " - " + Ad + " - " + Gun + " - " + Fiyat * Gun;
        }
    }
}
