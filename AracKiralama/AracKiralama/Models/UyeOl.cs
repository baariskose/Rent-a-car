using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AracKiralama.Models
{
    public class UyeOl
    {
        public int ID { get; set; }
        public string musteriAd { get; set; }
        public string musteriSoyad { get; set; }
        public int musteriTC { get; set; }
        public DateTime musteriDogumTarihi { get; set; }
        public string kullaniciAd { get; set; }
        public int sifre { get; set; }
    }
}