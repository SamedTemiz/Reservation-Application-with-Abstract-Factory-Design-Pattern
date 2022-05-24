using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    interface ISoyutFabrika
    {
        IKonaklama KonaklamaOlustur();
        IUlasim UlasimOlustur();
    }
}
