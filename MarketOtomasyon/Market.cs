using System;
using System.Collections.Generic;


namespace MarketOtomasyon {
    using System;
    using System.Collections.Generic;

    public class Market
    {
        private List<Product> urunler = new List<Product>();

        // ürün ekle
        public void UrunEkle(Product urun)
        {
            urun.Id = urunler.Count + 1;
            urunler.Add(urun);
            Console.WriteLine("Ürün başarıyla eklendi.");
        }

        //ürün listele
        public void UrunleriListele()
        {
            Console.WriteLine("Ürünlerin Listesi:");
            foreach (var urun in urunler)
            {
                Console.WriteLine($"ID: {urun.Id}, Ad: {urun.Ad}, Fiyat: {urun.Fiyat}, Stok Adedi: {urun.StokAdedi}");
            }
        }

        //ürün sil
        public void UrunSil(int id)
        {
            Product silinecekUrun = urunler.Find(u => u.Id == id);
            if (silinecekUrun != null)
            {
                urunler.Remove(silinecekUrun);
                Console.WriteLine("Ürün başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Ürün bulunamadı.");
            }
        }

        // ürün güncelle
        public void UrunGuncelle(int id, Product guncelUrun)
        {
            Product guncellenecekUrun = urunler.Find(u => u.Id == id);
            if (guncellenecekUrun != null)
            {
                guncellenecekUrun.Ad = guncelUrun.Ad;
                guncellenecekUrun.Fiyat = guncelUrun.Fiyat;
                guncellenecekUrun.StokAdedi = guncelUrun.StokAdedi;
                Console.WriteLine("Ürün başarıyla güncellendi.");
            }
            else
            {
                Console.WriteLine("Ürün bulunamadı.");
            }
        }
    }

}

