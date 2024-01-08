using static Sinif.Proje.Masa;

namespace Sinif.Proje
{
    public class Masa
    {
        public int Id { get; set; }
        public string MasaKodu { get; set; }

        public string MasaAdi { get; set; }

        public bool BosMu { get; set; }
        public bool RezerveEdilmisMi { get; set; }

        public bool OdendiMi { get; set; }

        public int ToplamSiparisSayisi { get; set; }
        public double ToplamGelir { get; set; }


        public class Siparis
        {
            public List<Siparis> Siparisler { get; set; }

        }
        
    }

}

