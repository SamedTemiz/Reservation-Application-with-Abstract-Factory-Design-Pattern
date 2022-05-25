using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    class HtmlRapor
    {
        List<string> HtmlRaporlama = new List<string>();
        public void Add(string SeyahatBilgisi)
        {
            this.HtmlRaporlama.Add(SeyahatBilgisi);
        }
        public void Htmlyaz()
        {
            //Html cıktı
        }
    }
}
