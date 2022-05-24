using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    class Kamp_Ucak:ISoyutFabrika
    {
        string k_sehir, k_ad;
        int k_gun, k_kisi, s_tip, k_fiyat, u_fiyat;

        string u_firma, u_kalkis, u_varis;
        DateTime u_gidis, u_donus;
        public Kamp_Ucak(string sehir, string ad, int gun, int kisi, int tip, string firma, string kalkis, string varis, DateTime gidis, DateTime donus, int k_fiyat, int u_fiyat)
        {
            k_sehir = sehir;
            k_ad = ad;
            k_gun = gun;
            k_kisi = kisi;
            s_tip = tip;
            this.k_fiyat = k_fiyat;

            u_firma = firma;
            u_kalkis = kalkis;
            u_varis = varis;
            u_gidis = gidis;
            u_donus = donus;
            this.u_fiyat = u_fiyat;
        }
        public IKonaklama KonaklamaOlustur()
        {
            return new Kamp(k_sehir, k_ad, k_gun, k_kisi, k_fiyat);
        }
        public IUlasim UlasimOlustur()
        {
            return new Ucak(u_firma, u_kalkis, u_varis, u_gidis, u_donus, s_tip, k_kisi, u_fiyat);
        }
    }
}
