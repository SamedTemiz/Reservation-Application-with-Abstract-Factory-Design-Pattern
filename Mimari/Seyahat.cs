using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    
    class Seyahat
    {
        IKonaklama konaklama;
        IUlasim ulasim;
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
    }
}
