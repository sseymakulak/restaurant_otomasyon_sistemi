using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif.Proje
{
    public class Kasa
    {
        private double toplamGelir;
        private double toplamGider;

        public double ToplamGelir
        {
            get { return toplamGelir; }
            set { toplamGelir = value; }
        }

        public double ToplamGider
        {
            get { return toplamGider; }
            set { toplamGider = value; }
        }

        public double NetKar
        {
            get { return toplamGelir - toplamGider; }
        }

    }
}
