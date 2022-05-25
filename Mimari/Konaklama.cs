using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    public interface IKonaklama
    {
        string Sehir();
        string MekanAdi();
        int Sure();
        int Tutar();
        string[] KonaklamaBilgileri();
    }
}
