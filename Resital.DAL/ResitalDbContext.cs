using Microsoft.EntityFrameworkCore;
using Resital.Model;
using System;
using System.Collections.Generic;
using System.Text;

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

    }
}