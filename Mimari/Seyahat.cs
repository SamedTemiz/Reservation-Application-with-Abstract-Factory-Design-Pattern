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
        public List<string> KonaklamaBilgileri()
        {
            List<string> bilgiler = new List<string>();
            bilgiler.Add(konaklama.KonaklamaBilgileri());
            bilgiler.Add(konaklama.Tutar().ToString());
            return bilgiler;
        }
        public List<string> UlasimBilgileri()
        {
            List<string> bilgiler = new List<string>();
            bilgiler.Add(ulasim.UlasimBilgileri());
            bilgiler.Add(ulasim.Tutar().ToString());
            return bilgiler;
        }
    }
}
