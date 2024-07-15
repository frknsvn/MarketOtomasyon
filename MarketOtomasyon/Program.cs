using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            Market market = new Market();

             
            market.UrunEkle(new Product { Ad = "Elma", Fiyat = 22, StokAdedi = 100 });
            market.UrunEkle(new Product { Ad = "Portakal", Fiyat = 48, StokAdedi = 75 });
            market.UrunEkle(new Product { Ad = "Muz", Fiyat = 78, StokAdedi = 30 });
            market.UrunEkle(new Product { Ad = "Karpuz", Fiyat = 12, StokAdedi = 20 });
            market.UrunEkle(new Product { Ad = "Üzüm", Fiyat = 28, StokAdedi = 75 });
            market.UrunEkle(new Product { Ad = "Erik", Fiyat = 80, StokAdedi = 65 });


            market.UrunleriListele();

            
            market.UrunGuncelle(1, new Product { Ad = "Yeşil Elma", Fiyat = 3.0m, StokAdedi = 90 });

            
            market.UrunleriListele();

            
            market.UrunSil(2);

            
            market.UrunleriListele();
        }
    }

}
    

