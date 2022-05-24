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
        public int Fiyat;
        public Kamp(string kampSehir, string kampAd, int kampSure, int kampKisiSayi, int k_fiyat)
        {
            Konum = kampSehir;
            Ad = kampAd;
            Gun = kampSure;
            KisiSayi = kampKisiSayi;
            Fiyat = k_fiyat;
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
            return Fiyat * KisiSayi * Gun;
        }
        public string KonaklamaBilgileri()
        {
            return Konum + " - " + Ad + " - " + KisiSayi + " - " + Gun + " - " + Tutar().ToString();
        }
    }
}
