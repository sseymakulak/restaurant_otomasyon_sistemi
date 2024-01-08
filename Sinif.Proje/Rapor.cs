using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif.Proje
{
    public  class Rapor
    {
        public DateTime RaporTarihi { get; set; }
        public double ToplamGelir { get; set; }
        public double ToplamGider { get; set; }
        public double NetKar { get { return ToplamGelir - ToplamGider; } }

        public int toplamSiparis { get; set; }

        public int toplamMusteri {  get; set; }
    }
}
