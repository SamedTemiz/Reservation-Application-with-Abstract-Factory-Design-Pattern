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
        int S_Tip;
        int KisiSayi;
        int Fiyat;
        public Ucak(string firma, string kalkis, string varis, DateTime gidis, DateTime donus, int tip, int kisiSayi, int u_fiyat)
        {
            UcakFirma = firma;
            UcakKalkis = kalkis;
            UcakVaris = varis;
            U_gidis = gidis;
            U_donus = donus;
            S_Tip = tip;
            KisiSayi = kisiSayi;
            Fiyat = u_fiyat;
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
            return Fiyat * S_Tip * KisiSayi;
        }

        public string UlasimBilgileri()
        {
            //string[] rapor=new string[7];
            //rapor[0] = UcakFirma;
            //rapor[1] = UcakKalkis;
            //rapor[2] = UcakVaris;
            //rapor[3] = U_gidis.ToString("dd/MM/yyyy");
            //rapor[4] = U_donus.ToString("dd/MM/yyyy");
            //rapor[5] = S_Tip.ToString();

            return UcakKalkis + " - " + UcakVaris + " + " + U_gidis.ToString("dd/MM/yyyy") + " - " + KisiSayi + " - " + Tutar().ToString();
        }
    }
}
