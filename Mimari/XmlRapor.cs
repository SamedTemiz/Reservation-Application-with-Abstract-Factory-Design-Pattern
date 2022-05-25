using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

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
        public void XMLyaz()
        {
            XmlTextWriter dosya = new XmlTextWriter(@"Rezervasyon.xml", Encoding.UTF8);
            dosya.Formatting = Formatting.Indented;
            dosya.WriteStartDocument();
            dosya.WriteStartElement("Seyahat Bilgileri");

                dosya.WriteElementString("Gidiş Tarihi: ", XmlRaporlama[0]);
                dosya.WriteElementString("Lokasyon: ", XmlRaporlama[1]);
                dosya.WriteElementString("Kalkış Yeri: ", XmlRaporlama[8]);
                dosya.WriteElementString("Firma: ", XmlRaporlama[9]);
                dosya.WriteElementString("Ulaşım Tutarı: ", XmlRaporlama[11]);
                dosya.WriteElementString("Konaklama Mekan Adı: ", XmlRaporlama[12]);
                dosya.WriteElementString("Konaklama Tutar: ", XmlRaporlama[14]);

            dosya.WriteStartElement("Kimlik Bilgileri");

                dosya.WriteElementString("T.C: ", XmlRaporlama[2]);
                dosya.WriteElementString("Ad: ", XmlRaporlama[3]);
                dosya.WriteElementString("Soyad: ", XmlRaporlama[4]);
                dosya.WriteElementString("Telefon: ", XmlRaporlama[5]);
                dosya.WriteElementString("Mail: ", XmlRaporlama[6]);
                dosya.WriteElementString("Cinsiyet: ", XmlRaporlama[7]);

            dosya.WriteEndElement();
            dosya.WriteEndElement();
            dosya.Close();
        }

        XDocument xDoc = new XDocument();
        string directory_path = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "//XML";
        //string file_path = .Global.AppPath + "//XML//Personeller.xml";
    }
}
