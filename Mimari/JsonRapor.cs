using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mimari
{
    class JsonRapor
    {
        List<string> JsonRaporlama = new List<string>();
        public void Add(string SeyahatBilgisi)
        {
            this.JsonRaporlama.Add(SeyahatBilgisi);
        }
        public void Jsonyaz()
        {
           //JSON CIKTI
        }
    }
}
