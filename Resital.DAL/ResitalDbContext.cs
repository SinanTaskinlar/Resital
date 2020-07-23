using Microsoft.EntityFrameworkCore;
using Resital.Model;
using System;

namespace Resital.DAL
{
    public class ResitalDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyRegion> CompanyRegions { get; set; }
        public DbSet<CompanyRoute> CompanyRoutes{ get; set; }
        public DbSet<CompanyType> CompanyTypes{ get; set; }
        public DbSet<Guide> Guides{ get; set; }
        public DbSet<Region> Regions{ get; set; }
        public DbSet<Room> Rooms{ get; set; }
        public DbSet<RoomLocation> RoomLocations{ get; set; }
        public DbSet<RoomType> RoomTypes{ get; set; }
        public DbSet<Route> Routes{ get; set; }
        public DbSet<Vehicle> Vehicles{ get; set; }
        public DbSet<VehicleType> VehicleTypes{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Resital;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleType>().HasData(
                new VehicleType { Id = 1, Name = "Araba" },
                new VehicleType { Id = 2, Name = "Uçak" },
                new VehicleType { Id = 3, Name = "Gemi" },
                new VehicleType { Id = 4, Name = "Otobüs" }
            );

            modelBuilder.Entity<Region>().HasData(
                new Region { Id = 1, Name = "Akdeniz" },
                new Region { Id = 2, Name = "Doğu Anadolu" },
                new Region { Id = 3, Name = "Ege" },
                new Region { Id = 4, Name = "Güneydoğu Anadolu" },
                new Region { Id = 5, Name = "İç Anadolu" },
                new Region { Id = 6, Name = "Marmara" },
                new Region { Id = 7, Name = "Karadeniz" },
                new Region { Id = 8, Name = "Yurtdışı" }
            );

            modelBuilder.Entity<RoomType>().HasData(
                new RoomType { Id = 1, Name = "SGL" },
                new RoomType { Id = 2, Name = "DBL" },
                new RoomType { Id = 3, Name = "TRP" },
                new RoomType { Id = 4, Name = "DBL+1" },
                new RoomType { Id = 5, Name = "TRP+1" }
            );

            modelBuilder.Entity<RoomLocation>().HasData(
                new RoomLocation { Id = 1, Name = "DNZ" },
                new RoomLocation { Id = 2, Name = "GNL " },
                new RoomLocation { Id = 3, Name = "PRK " }
            );

            modelBuilder.Entity<CompanyType>().HasData(
                new CompanyType { Id = 1, TypeName = "Hotel Company" },
                new CompanyType { Id = 2, TypeName = "Tour Company " },
                new CompanyType { Id = 3, TypeName = "AirPlane Company " },
                new CompanyType { Id = 4, TypeName = "Transfer Company " },
                new CompanyType { Id = 5, TypeName = "RentACar Company " },
                new CompanyType { Id = 6, TypeName = "Ship Company " }
            );

            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "İstanbul" },
                new City { Id = 2, Name = "Ankara" },
                new City { Id = 3, Name = "İzmir" },
                new City { Id = 4, Name = "Antalya" },
                new City { Id = 5, Name = "Adana" },
                new City { Id = 6, Name = "Eskişehir" },
                new City { Id = 7, Name = "Afyonkarahisar " },
                new City { Id = 8, Name = "Artvin" },
                new City { Id = 9, Name = "Balıkesir" },
                new City { Id = 10, Name = "Bursa" },
                new City { Id = 11, Name = "Çanakkale" },
                new City { Id = 12, Name = "Diyarbakır" },
                new City { Id = 13, Name = "Edirne" },
                new City { Id = 14, Name = "Kastamonu" },
                new City { Id = 15, Name = "Kütahya" },
                new City { Id = 16, Name = "Muğla" },
                new City { Id = 17, Name = "Nevşehir" },
                new City { Id = 18, Name = "Sinop" },
                new City { Id = 19, Name = "Sivas" },
                new City { Id = 20, Name = "Şanlıurfa" },
                new City { Id = 21, Name = "Tokat" },
                new City { Id = 22, Name = "Trabzon" },
                new City { Id = 23, Name = "Yozgat" }
            );
        }
    }
}