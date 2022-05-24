using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    class Otobus : IUlasim
    {
        string OtobusFirma;
        string OtobusKalkis;
        string OtobusVaris;
        DateTime O_gidis;
        DateTime O_donus;
        int S_Tip;
        int KisiSayi;
        int Fiyat = 0;
        public Otobus(string firma, string kalkis, string varis, DateTime gidis, DateTime donus, int tip,int kisiSayi, int u_fiyat)
        {
            OtobusFirma = firma;
            OtobusKalkis = kalkis;
            OtobusVaris = varis;
            O_gidis = gidis;
            O_donus = donus;
            S_Tip = tip;
            KisiSayi = kisiSayi;
            Fiyat = u_fiyat;
        }
        public string KalkisYeri()
        {
            return OtobusKalkis;
        }
        public string VarisYeri()
        {
            return OtobusVaris;
        }
        public DateTime Tarih() 
        {
            return O_gidis;
        }
        public int Tutar()
        {
            return Fiyat * S_Tip * KisiSayi;
        }

        public string UlasimBilgileri()
        {
            return OtobusKalkis + " - " + OtobusVaris + " + " + O_gidis.ToString("dd/MM/yyyy") + " - " + KisiSayi + " - " + Tutar().ToString();
        }
    }
}
