using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    public class Director
    {
        private IRaporla raporla;
        public IRaporla Raporla
        {
            set { raporla = value; }
        }
        public void BuildFullFeaturedProduct()
        {
            this.raporla.SeyahatBilgi();
            this.raporla.SeyahatDetayliBilgi();
            this.raporla.Tutar();
        }
       



    }
}
