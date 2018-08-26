using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace WebApplication1.Models
{
    public class ProductContext:DbContext
    {

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Basket> Baskets { get; set; }
    }

    public class DbInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext db)
        {
            db.Categories.Add(new Category { Id = 1, Name = "Ноутбуки" });
            db.Categories.Add(new Category { Id = 2, Name = "Планшеты" });

            db.Products.Add(new Product {
                Id = 1,
                CatId = 1,
                Name = "ASUS FX503VM-E4037",
                Description = "Экран 15.6 IPS(1920x1080) Full HD, матовый / Intel Core i5 - 7300HQ(2.5 - 3.5 ГГц) / RAM 8 ГБ / SSHD 1 ТБ + 8 ГБ / nVidia GeForce GTX 1060,3 ГБ / без ОД / LAN / Wi - Fi / Bluetooth / веб - камера / Endless OS / 2.5 кг / черный",
                Price = 3900});

            db.Products.Add(new Product
            {
                Id = 2,
                CatId = 1,
                Name = "HP 250 G6",
                Description = "Экран 15.6 (1366x768) HD, матовый / Intel Core i3-6006U (2.0 ГГц) / RAM 4 ГБ / HDD 500 ГБ / AMD Radeon 520, 2 ГБ / Без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / DOS / 1.86 кг / черный",
                Price = 5000
            });

            db.Products.Add(new Product
            {
                Id = 3,
                CatId = 2,
                Name = "Lenovo Tab 3 Plus X70L",
                Description = "Экран 10 IPS(1920x1200) MultiTouch / MediaTek MT8735(1.3 ГГц) / RAM 2 ГБ / 32 ГБ встроенной памяти + microSD / 3G / LTE / Wi - Fi / Bluetooth 4.0 / основная камера 8 Мп,фронтальная - 5 Мп / GPS / ГЛОНАСС / Android 6.0(Marshmallow) / 509 г / черный",
                Price = 4999
            });

            db.Products.Add(new Product
            {
                Id = 4,
                CatId = 2,
                Name = "Asus ZenPad 10 2/32GB",
                Description = "Экран 10.1 IPS(1280x800) MultiTouch / MediaTek MT8163B(1.3 ГГц) / RAM 2 ГБ / 32 ГБ встроенной памяти + microSD / Wi - Fi / Bluetooth 4.2 / основная камера 5 Мп, фронтальная - 2 Мп / GPS / ГЛОНАСС / Android 7.0(Nougat) / 490 г / синий",
                Price = 6750
            });

            



            base.Seed(db);
        }
    }
}