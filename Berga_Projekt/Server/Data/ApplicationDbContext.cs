using Berga_Projekt.Server.Models;
using Berga_Projekt.Shared;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berga_Projekt.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                 Id = 1,
                 Title = "XFX AMD Radeon RX 550",
                 Description = "2GB RAM",
                 ImageURL = "https://www.hgspot.hr/image/cachewebp/catalog/slike/145204-878-640x480.webp",
                 Price = 2500,

               },
               new Product
               {
                 Id = 2,
                 Title = "Sapphire Pulse AMD Radeon RX 550",
                 Description = "2GB RAM",
                 ImageURL = "https://www.instar-informatika.hr/slike/velike/11268-21-20g.jpg",
                 Price = 2500,

               },
               new Product
               {
                 Id = 3,
                 Title = "Samsung Galaxy Z Fold 3",
                 Description = "5G, 256 GB/12 GB,12MP+12MP+12MP/4MP",
                 ImageURL = "https://www.hgspot.hr/image/catalog/slike/167318-878.jpg",
                 Price = 10000,

               },
               new Product
               {
                Id = 4,
                Title = "Apple iPhone 13 Mini",
                Description = "5G,128GB, Midnight",
                ImageURL = "https://www.hgspot.hr/image/catalog/slike/162633-878.jpg",
                Price = 4500,

               },
               new Product
               {
                Id = 5,
                Title = "Slušalice + mikrofon MARSHALL Major III",
                Description = "DRIVERS 40 mm,DRIVER TYPE Dynamic,DRIVER IMPEDANCE 32 OHM,DRIVER SENSITIVITY 97 dB SPL,FREQUENCY RESPONSE 20Hz",
                ImageURL = "https://www.hgspot.hr/image/catalog/slike/126934-878.jpg",
                Price = 1200,

               }
            );
        }
        public DbSet<Product> Products { get; set; }

    }
}
