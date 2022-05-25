using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            string stringJSON = JsonConvert.SerializeObject(JsonRaporlama);

            using (FileStream deneme = new FileStream(Application.StartupPath + "\\deneme.json", FileMode.Append, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(deneme);
                sw.WriteLine(stringJSON);
                sw.AutoFlush = true;
                sw.Close(); 
            }
        }
    }
}
