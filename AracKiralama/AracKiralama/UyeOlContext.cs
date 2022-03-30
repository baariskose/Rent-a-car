using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AracKiralama
{
    public class UyeOlContext : DbContext
    {
        public DbSet<aracBilgileri> AracBilgileri { get; set; }
        public DbSet<Kiralama> Kiralamalar { get; set; }
        public DbSet<kullanıcı> Kullanıcılar { get; set; }
        public DbSet<muşteri> Musteriler { get; set; }
        public DbSet<rezervasyon> Rezervasyonlar { get; set; }
        public DbSet<şirket> Sirketler { get; set; }

    }

    public class muşteri
    {
    }
}