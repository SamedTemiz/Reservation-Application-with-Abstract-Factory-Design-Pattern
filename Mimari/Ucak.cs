using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    public class Ucak : IUlasim
    {
        string UcakFirma;
        string UcakKalkis;
        string UcakVaris;
        DateTime U_gidis;
        DateTime U_donus;
        int Fiyat = 1333;
        int S_Tip;
        public Ucak(string firma, string kalkis, string varis, DateTime gidis, DateTime donus, int tip)
        {
            UcakFirma = firma;
            UcakKalkis = kalkis;
            UcakVaris = varis;
            U_gidis = gidis;
            U_donus = donus;
            S_Tip = tip;
        }
        public string KalkisYeri()
        {
            return UcakKalkis;
        }
        public string VarisYeri()
        {
            return UcakVaris;
        }
        public DateTime Tarih()
        {
            return U_gidis;
        }
        public int Tutar()
        {
            return 1000 * S_Tip;
        }

        public string UlasimBilgileri()
        {
            return UcakFirma + " - " + UcakKalkis + " - " + UcakVaris + " - " + U_gidis.ToString("dd/MM/yyyy") + " - " + U_donus.ToString("dd/MM/yyyy") + " - " + Fiyat;
        }
    }
}
