using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif.Proje
{
    public class Rezervasyon
    {
        public int RezervasyonId { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string TelefonNumarasi { get; set; }
        public DateTime RezervasyonTarihi { get; set; }
        public int KisiSayisi { get; set; }
        public bool OnaylandiMi { get; set; }




        public void RezervasyonuOnayla()
        {
            if (!OnaylandiMi)
            {

            }
            else
            {

            }
        }


        public void RezervasyonuIptalEt()
        {
            if (OnaylandiMi)
            {

            }
            else
            {

            }

        }
    }
}
