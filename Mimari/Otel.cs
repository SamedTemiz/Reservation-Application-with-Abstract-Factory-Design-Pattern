
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
        public int Fiyat;

        public Otel(string otelSehir, string otelAd, int otelSure, int otelKisiSayi, int k_fiyat)
        {
            Konum = otelSehir;
            Ad = otelAd;
            Gun = otelSure;
            KisiSayi = otelKisiSayi;
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

        public string[] KonaklamaBilgileri()
        {
            string[] bilgiler = {Konum, Ad, Gun.ToString(), KisiSayi.ToString(), Tutar().ToString() };
            return bilgiler;
        }
    }
}
