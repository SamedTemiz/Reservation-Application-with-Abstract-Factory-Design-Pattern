using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    class Json
    {
        private JsonRapor _product = new JsonRapor();
        public Json()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._product = new JsonRapor();
        }
        public void SeyahatBilgi(Seyahat s, KimlikBilgileri kimlik)
        {
            //gidis dönüş, lokasyon, KİMLİK Bİlgileri    
            _product.Add(s.UlasimBilgileri()[2]);       //Ulaşım gidiş - dönüş tarihi
            _product.Add(s.KonaklamaBilgileri()[0]);    //Konaklama lokasyon

            //Kimlik Bilgileri
            _product.Add(kimlik.Tc);
            _product.Add(kimlik.Ad);
            _product.Add(kimlik.Soyad);
            _product.Add(kimlik.Telefon);
            _product.Add(kimlik.Mail);
            _product.Add(kimlik.Cinsiyet);
        }
        public void SeyahatDetayliBilgi(Seyahat s)
        {
            //ulaşım ve konaklama
            _product.Add(s.UlasimBilgileri()[1]);       //Ulaşım aracının kalkış yeri
            _product.Add(s.UlasimBilgileri()[0]);       //Ulaşım aracının firması
            _product.Add(s.UlasimBilgileri()[3]);       //Ulaşım yapacak kişi sayısı
            _product.Add(s.UlasimBilgileri()[4]);       //Ulaşım tutarı

            _product.Add(s.KonaklamaBilgileri()[1]);    //Konaklama mekan adı
            _product.Add(s.KonaklamaBilgileri()[2]);    //Konaklama yapılacak gün sayısı
            _product.Add(s.KonaklamaBilgileri()[4]);    //Konaklama tutar
        }
        public void Tutar(Seyahat s)
        {
            _product.Add(s.KonaklamaBilgileri()[4] + s.UlasimBilgileri()[4]);
        }
        public void GetProduct()
        {
            JsonRapor result = this._product;
            //this.Reset();
            result.Jsonyaz();
        }
    }
}
