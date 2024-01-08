using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif.Proje
{
    public class Mutfak
    {

        private List<Urun> stok;

        public Mutfak()
        {
            stok = new List<Urun>();
        }

        public List<Urun> Stok
        {
            get { return stok; }
            set { stok = value; }
        }

        
        public void UrunEkle(Urun urun)
        {
           
        }

        public void StoktakiUrunleriListele()
        {
           
        }

    }
}
