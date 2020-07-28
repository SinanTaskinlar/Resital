using Microsoft.EntityFrameworkCore;
using Resital.Model;
using System;

namespace Resital.DAL
{
    public class ResitalDbContext : DbContext
    {
        public ResitalDbContext()
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyRegion> CompanyRegions { get; set; }
        public DbSet<CompanyRoute> CompanyRoutes { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomLocation> RoomLocations { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Resital;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleType>().HasData(
                new VehicleType { Id = Guid.NewGuid(), Name = "Araba" },
                new VehicleType { Id = Guid.NewGuid(), Name = "Uçak" },
                new VehicleType { Id = Guid.NewGuid(), Name = "Gemi" },
                new VehicleType { Id = Guid.NewGuid(), Name = "Otobüs" }
            );

            modelBuilder.Entity<Region>().HasData(
                new Region { Id = Guid.NewGuid(), Name = "Akdeniz" },
                new Region { Id = Guid.NewGuid(), Name = "Doğu Anadolu" },
                new Region { Id = Guid.NewGuid(), Name = "Ege" },
                new Region { Id = Guid.NewGuid(), Name = "Güneydoğu Anadolu" },
                new Region { Id = Guid.NewGuid(), Name = "İç Anadolu" },
                new Region { Id = Guid.NewGuid(), Name = "Marmara" },
                new Region { Id = Guid.NewGuid(), Name = "Karadeniz" },
                new Region { Id = Guid.NewGuid(), Name = "Yurtdışı" }
            );

            modelBuilder.Entity<RoomType>().HasData(
                new RoomType { Id = Guid.NewGuid(), Name = "SGL" },
                new RoomType { Id = Guid.NewGuid(), Name = "DBL" },
                new RoomType { Id = Guid.NewGuid(), Name = "TRP" },
                new RoomType { Id = Guid.NewGuid(), Name = "DBL+1" },
                new RoomType { Id = Guid.NewGuid(), Name = "TRP+1" }
            );

            modelBuilder.Entity<RoomLocation>().HasData(
                new RoomLocation { Id = Guid.NewGuid(), Name = "DNZ" },
                new RoomLocation { Id = Guid.NewGuid(), Name = "GNL " },
                new RoomLocation { Id = Guid.NewGuid(), Name = "PRK " }
            );

            modelBuilder.Entity<CompanyType>().HasData(
                new CompanyType { Id = Guid.NewGuid(), TypeName = "Hotel Company" },
                new CompanyType { Id = Guid.NewGuid(), TypeName = "Tour Company " },
                new CompanyType { Id = Guid.NewGuid(), TypeName = "AirPlane Company " },
                new CompanyType { Id = Guid.NewGuid(), TypeName = "Transfer Company " },
                new CompanyType { Id = Guid.NewGuid(), TypeName = "RentACar Company " },
                new CompanyType { Id = Guid.NewGuid(), TypeName = "Ship Company " }
            );

            modelBuilder.Entity<City>().HasData(
                new City { Id = Guid.NewGuid(), Name = "İstanbul" },
                new City { Id = Guid.NewGuid(), Name = "Ankara" },
                new City { Id = Guid.NewGuid(), Name = "İzmir" },
                new City { Id = Guid.NewGuid(), Name = "Antalya" },
                new City { Id = Guid.NewGuid(), Name = "Adana" },
                new City { Id = Guid.NewGuid(), Name = "Eskişehir" },
                new City { Id = Guid.NewGuid(), Name = "Afyonkarahisar " },
                new City { Id = Guid.NewGuid(), Name = "Artvin" },
                new City { Id = Guid.NewGuid(), Name = "Balıkesir" },
                new City { Id = Guid.NewGuid(), Name = "Bursa" },
                new City { Id = Guid.NewGuid(), Name = "Çanakkale" },
                new City { Id = Guid.NewGuid(), Name = "Diyarbakır" },
                new City { Id = Guid.NewGuid(), Name = "Edirne" },
                new City { Id = Guid.NewGuid(), Name = "Kastamonu" },
                new City { Id = Guid.NewGuid(), Name = "Kütahya" },
                new City { Id = Guid.NewGuid(), Name = "Muğla" },
                new City { Id = Guid.NewGuid(), Name = "Nevşehir" },
                new City { Id = Guid.NewGuid(), Name = "Sinop" },
                new City { Id = Guid.NewGuid(), Name = "Sivas" },
                new City { Id = Guid.NewGuid(), Name = "Şanlıurfa" },
                new City { Id = Guid.NewGuid(), Name = "Tokat" },
                new City { Id = Guid.NewGuid(), Name = "Trabzon" },
                new City { Id = Guid.NewGuid(), Name = "Yozgat" }
            );
        }
    }
}