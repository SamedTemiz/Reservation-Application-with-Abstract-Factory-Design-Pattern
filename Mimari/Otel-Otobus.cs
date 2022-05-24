using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    class Otel_Otobus : ISoyutFabrika
    {
        string o_sehir, o_ad;
        int o_gun, o_kisi, s_tip, o_fiyat, u_fiyat;

        string oto_firma, oto_kalkis, oto_varis;
        DateTime oto_gidis, oto_donus;
        public Otel_Otobus(string sehir, string ad, int gun, int kisi, int tip, string firma, string kalkis, string varis, DateTime gidis, DateTime donus, int k_fiyat, int u_fiyat)
        {
            o_sehir = sehir;
            o_ad = ad;
            o_gun = gun;
            o_kisi = kisi;
            s_tip = tip;
            this.o_fiyat = k_fiyat;

            oto_firma = firma;
            oto_kalkis = kalkis;
            oto_varis = varis;
            oto_gidis = gidis;
            oto_donus = donus;
            this.u_fiyat = u_fiyat;
        }
        public IKonaklama KonaklamaOlustur()
        {
            return new Otel(o_sehir, o_ad, o_gun, o_kisi, o_fiyat);
        }
        public IUlasim UlasimOlustur()
        {
            return new Otobus(oto_firma, oto_kalkis, oto_varis, oto_gidis, oto_donus, s_tip, o_kisi, u_fiyat);
        }
    }
}
