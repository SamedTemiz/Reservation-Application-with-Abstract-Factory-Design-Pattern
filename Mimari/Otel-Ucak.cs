using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    class Otel_Ucak : ISoyutFabrika
    {
        string o_sehir, o_ad;
        int o_gun, o_kisi, s_tip;

        string u_firma, u_kalkis, u_varis;
        DateTime u_gidis, u_donus;
        public Otel_Ucak(string sehir, string ad, int gun, int kisi, int tip, string firma, string kalkis, string varis, DateTime gidis, DateTime donus)
        {
            o_sehir = sehir;
            o_ad = ad;
            o_gun = gun;
            o_kisi = kisi;
            s_tip = tip;

            u_firma = firma;
            u_kalkis = kalkis;
            u_varis = varis;
            u_gidis = gidis;
            u_donus = donus;
        }
        public IKonaklama KonaklamaOlustur() 
        {
            return new Otel(o_sehir, o_ad, o_gun, o_kisi);
        }
        public IUlasim UlasimOlustur()
        {
            return new Ucak(u_firma, u_kalkis, u_varis, u_gidis, u_donus, s_tip);
        }   
    }
}
