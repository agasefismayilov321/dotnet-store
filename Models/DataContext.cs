using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Models;

public class DataContext:IdentityDbContext<AppUser,AppRole,int>
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    public DbSet<Urun> Urunler { get; set; }
    public DbSet<Kategori> Kategoriler { get; set; }
    public DbSet<Slider> Sliderlar { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Slider>().HasData(
            new List<Slider>()
            {
                new Slider(){Id = 1,Baslik = "UrunBaslik",Aciklama = "Urun Aciklama",Resim = "slider-1.jpeg",Index = 0,Aktiv = true},
                new Slider(){Id = 2,Baslik = "UrunBaslik",Aciklama = "Urun Aciklama",Resim = "slider-2.jpeg",Index = 1,Aktiv = true},
                new Slider(){Id = 3,Baslik = "UrunBaslik",Aciklama = "Urun Aciklama",Resim = "slider-3.jpeg",Index = 2,Aktiv = true}
            }
        );

        modelBuilder.Entity<Kategori>().HasData(
            new List<Kategori>()
            {
                new Kategori(){Id = 1,KategoriAdi = "Telefon",Url = "telefon"},
                new Kategori(){Id = 2,KategoriAdi = "Elektronik",Url = "elektronik"},
                new Kategori(){Id = 3,KategoriAdi = "Beyaz Eşya",Url = "beyaz-esya"},
                new Kategori(){Id = 4,KategoriAdi = "Giyim",Url = "giyim"},
                new Kategori(){Id = 5,KategoriAdi = "Kozmetik",Url = "kozmetik"},
                new Kategori(){Id = 6,KategoriAdi = "Kategori 1",Url = "kategori-1"},
                new Kategori(){Id = 7,KategoriAdi = "Kategori 2",Url = "kategori-2"},
                new Kategori(){Id = 8,KategoriAdi = "Kategori 3",Url = "kategori-3"},
                new Kategori(){Id = 9,KategoriAdi = "Kategori 4",Url = "kategori-4"},
                new Kategori(){Id = 10,KategoriAdi = "Kategori 5",Url = "kategori-5"}
            }
        );

        modelBuilder.Entity<Urun>().HasData(
            new List<Urun>()
            {
                new Urun(){Id = 1,UrunAd = "Apple Watch 7",Fiyat = 30000,Resim="1.jpeg",Aciklama="Lorem ipsum dolor sit amet consectetur adipisicing elit. Nihil mollitia earum distinctio, quo quos inventore modi voluptate, quia, reprehenderit magnam quaerat nam laudantium quas molestiae.",Active = true,Anasayfa=true,KategoriId = 1},
                new Urun(){Id = 2,UrunAd = "Apple Watch 8",Fiyat = 40000,Resim="2.jpeg",Aciklama="Lorem ipsum dolor sit amet consectetur adipisicing elit. Nihil mollitia earum distinctio, quo quos inventore modi voluptate, quia, reprehenderit magnam quaerat nam laudantium quas molestiae.",Active = false,Anasayfa=false,KategoriId = 1},
                new Urun(){Id = 3,UrunAd = "Apple Watch 9",Fiyat = 50000,Resim="3.jpeg",Aciklama="Lorem ipsum dolor sit amet consectetur adipisicing elit. Nihil mollitia earum distinctio, quo quos inventore modi voluptate, quia, reprehenderit magnam quaerat nam laudantium quas molestiae.",Active = true,Anasayfa=true,KategoriId = 2},
                new Urun(){Id = 4,UrunAd = "Apple Watch 10",Fiyat = 60000,Resim="4.jpeg",Aciklama="Lorem ipsum dolor sit amet consectetur adipisicing elit. Nihil mollitia earum distinctio, quo quos inventore modi voluptate, quia, reprehenderit magnam quaerat nam laudantium quas molestiae.",Active = true,Anasayfa=false,KategoriId = 2},
                new Urun(){Id = 5,UrunAd = "Apple Watch 11",Fiyat = 70000,Resim="5.jpeg",Aciklama="Lorem ipsum dolor sit amet consectetur adipisicing elit. Nihil mollitia earum distinctio, quo quos inventore modi voluptate, quia, reprehenderit magnam quaerat nam laudantium quas molestiae.",Active = true,Anasayfa=true,KategoriId = 2},
                new Urun(){Id = 6,UrunAd = "Apple Watch 12",Fiyat = 80000,Resim="6.jpeg",Aciklama="Lorem ipsum dolor sit amet consectetur adipisicing elit. Nihil mollitia earum distinctio, quo quos inventore modi voluptate, quia, reprehenderit magnam quaerat nam laudantium quas molestiae.",Active = false,Anasayfa=true,KategoriId = 3},
                new Urun(){Id = 7,UrunAd = "Apple Watch 13",Fiyat = 90000,Resim="7.jpeg",Aciklama="Lorem ipsum dolor sit amet consectetur adipisicing elit. Nihil mollitia earum distinctio, quo quos inventore modi voluptate, quia, reprehenderit magnam quaerat nam laudantium quas molestiae.",Active = true,Anasayfa=true,KategoriId = 3},
                new Urun(){Id = 8,UrunAd = "Apple Watch 14",Fiyat = 100000,Resim="8.jpeg",Aciklama="Lorem ipsum dolor sit amet consectetur adipisicing elit. Nihil mollitia earum distinctio, quo quos inventore modi voluptate, quia, reprehenderit magnam quaerat nam laudantium quas molestiae.",Active = true,Anasayfa=true,KategoriId = 4}
            }
        );
    }
}