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
            return bilgiler;
        }
        public List<string> UlasimBilgileri()
        {
            List<string> bilgiler = new List<string>();
            bilgiler.Add(ulasim.UlasimBilgileri());
            return bilgiler;
        }
    }
}
