using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    public interface IRaporla
    {
        //IBuilder
         void SeyahatBilgi(Seyahat s, KimlikBilgileri kimlik);
         void SeyahatDetayliBilgi(Seyahat s);
         void Tutar(Seyahat s);
        
    }
}
