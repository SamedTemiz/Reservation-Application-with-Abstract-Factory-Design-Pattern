using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    class Xml:IRaporla
    {
        //concreate builder
        private XmlRapor _product = new XmlRapor();
        public Xml()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new XmlRapor();
        }
        public string SeyahatDetayliBilgi()
        {
          
            return "s" ;
        }
        public string SeyahatBilgi()
        {
           

            return "";    
            //ulaşım ve konaklama
        }
        public void Tutar()
        {
            //rezervasyon fiyat
        }
        public XmlRapor GetProduct()
        {
            XmlRapor result = this._product;

            this.Reset();

            return result;
        }
    }
}
