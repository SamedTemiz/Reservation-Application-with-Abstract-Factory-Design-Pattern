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
        int Fiyat = 520;
        int S_Tip;
        public Otobus(string firma, string kalkis, string varis, DateTime gidis, DateTime donus, int tip)
        {
            OtobusFirma = firma;
            OtobusKalkis = kalkis;
            OtobusVaris = varis;
            O_gidis = gidis;
            O_donus = donus;
            S_Tip = tip;
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
            return 1500;
        }

        public string UlasimBilgileri()
        {
            return OtobusFirma + " - " + OtobusKalkis + " - " + OtobusVaris + " - " + O_gidis.ToString("dd/MM/yyyy") + " - " + O_donus.ToString("dd/MM/yyyy") + " - " + Fiyat;
        }
    }
}
