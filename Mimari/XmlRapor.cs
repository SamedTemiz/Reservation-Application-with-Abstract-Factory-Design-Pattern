using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    public class XmlRapor
    {
        //product

        List<string> XmlRaporlama = new List<string>();

        public void Add(string SeyahatBilgisi)
        {
            this.XmlRaporlama.Add(SeyahatBilgisi);
        }

        public string BilgileriListele()
        {
            string str = string.Empty;

            for (int i = 0; i < this.XmlRaporlama.Count; i++)
            {
                str += this.XmlRaporlama[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
        }
    }
}
