using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    public class Seyahat //Raporlama için Director sınıfı
    {
        IKonaklama konaklama;
        IUlasim ulasim;

        IRaporla raporla;

        public Seyahat(ISoyutFabrika paket)
        {
            konaklama = paket.KonaklamaOlustur();
            ulasim = paket.UlasimOlustur();
        }
        public string[] KonaklamaBilgileri()
        {
            return konaklama.KonaklamaBilgileri();
        }
        public string[] UlasimBilgileri()
        {
            return ulasim.UlasimBilgileri();
        }
        public void Builder(Seyahat s, KimlikBilgileri kimlik)
        {
            raporla.SeyahatBilgi(s, kimlik);
            raporla.SeyahatDetayliBilgi(s);
            raporla.Tutar(s);
        }
    }
}
