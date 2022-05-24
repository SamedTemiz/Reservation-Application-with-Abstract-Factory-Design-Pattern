using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    interface IUlasim
    {
        string KalkisYeri();
        string VarisYeri();
        DateTime Tarih();
        int Tutar();

        string UlasimBilgileri();
    }
}
