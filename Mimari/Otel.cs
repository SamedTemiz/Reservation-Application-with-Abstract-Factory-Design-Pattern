
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    class Otel : IKonaklama
    {
        public string Ad;
        public string Konum;
        public int Gun;
        public int KisiSayi;
        public int Fiyat = 1250;

        public Otel(string otelSehir, string otelAd, int otelSure, int otelKisiSayi)
        {
            Konum = otelSehir;
            Ad = otelAd;
            Gun = otelSure;
            KisiSayi = otelKisiSayi;
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
            return 1500;
        }

        public string KonaklamaBilgileri()
        {
            return Konum + " - " + Ad + " - " + Gun + " - " + Fiyat * Gun * KisiSayi;
        }
    }
}
