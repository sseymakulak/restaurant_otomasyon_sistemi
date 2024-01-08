using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif.Proje
{
    public class Menu
    {
        private List<Urun> urunler;

        public Menu()
        {
            urunler = new List<Urun>();
        }

        public List<Urun> Urunler
        {
            get { return urunler; }
            set { urunler = value; }
        }

        public void UrunEkle(Urun urun)
        {
            urunler.Add(urun);

        }
    }


}   

