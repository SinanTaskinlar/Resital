﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Resital.DAL;

namespace DataAccess.Migrations
{
    [DbContext(typeof(ResitalDbContext))]
    internal class ResitalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Cart", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("UserId")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Carts");
            });

            modelBuilder.Entity("Model.CartItem", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("CardId")
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid?>("CartId")
                    .HasColumnType("uniqueidentifier");

                b.Property<int>("Quantity")
                    .HasColumnType("int");

                b.Property<Guid>("RoomId")
                    .HasColumnType("uniqueidentifier");

                b.HasKey("Id");

                b.HasIndex("CartId");

                b.HasIndex("RoomId");

                b.ToTable("CartItems");
            });

            modelBuilder.Entity("Resital.Model.City", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Cities");

                b.HasData(
                    new
                    {
                        Id = new Guid("6643d92d-5af2-4fe7-9f79-858de453c0fb"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(2827),
                        Name = "İstanbul"
                    },
                    new
                    {
                        Id = new Guid("17075669-099c-4b85-8fb5-e89f94ce64de"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3124),
                        Name = "Ankara"
                    },
                    new
                    {
                        Id = new Guid("0591df02-720d-48c2-9bd5-79502f6a54d3"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3147),
                        Name = "İzmir"
                    },
                    new
                    {
                        Id = new Guid("eacb19a6-c78f-49ed-b35e-ab1b208cca15"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3155),
                        Name = "Antalya"
                    },
                    new
                    {
                        Id = new Guid("922ccbd6-af1f-46b1-9a6b-23cca0f7922d"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3157),
                        Name = "Adana"
                    },
                    new
                    {
                        Id = new Guid("b966a529-8c32-45ac-8a66-ad0c7eb97fbe"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3159),
                        Name = "Eskişehir"
                    },
                    new
                    {
                        Id = new Guid("3f7f09c2-100f-4aca-a3a0-73e3b79f16b3"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3161),
                        Name = "Afyonkarahisar "
                    },
                    new
                    {
                        Id = new Guid("edbcd4e5-f695-4237-9f9b-741e965d4f78"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3163),
                        Name = "Artvin"
                    },
                    new
                    {
                        Id = new Guid("d8f2e801-e5cf-4f44-99c8-c256488b85c1"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3164),
                        Name = "Balıkesir"
                    },
                    new
                    {
                        Id = new Guid("5c1b4394-2b49-4d69-8e0e-bfd33a7c3c19"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3166),
                        Name = "Bursa"
                    },
                    new
                    {
                        Id = new Guid("66b9ce7e-8c97-432e-b350-03d9f3189d02"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3168),
                        Name = "Çanakkale"
                    },
                    new
                    {
                        Id = new Guid("b1cce621-e7e7-467f-8fa5-ba67e9797840"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3172),
                        Name = "Diyarbakır"
                    },
                    new
                    {
                        Id = new Guid("11e6aed3-5756-441c-804d-d0c8ae5ccf61"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3174),
                        Name = "Edirne"
                    },
                    new
                    {
                        Id = new Guid("c87259c8-c580-4df2-945e-c54146180762"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3176),
                        Name = "Kastamonu"
                    },
                    new
                    {
                        Id = new Guid("1b12b44a-1172-4f82-adeb-7fb5add052d1"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3177),
                        Name = "Kütahya"
                    },
                    new
                    {
                        Id = new Guid("34f79c04-f0d1-4b74-98d1-eab9901d5e88"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3179),
                        Name = "Muğla"
                    },
                    new
                    {
                        Id = new Guid("0dcb24a9-ab3d-42a7-97d4-a38e02c6c55c"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3181),
                        Name = "Nevşehir"
                    },
                    new
                    {
                        Id = new Guid("be19effb-d141-48da-948f-3496aad3faff"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3183),
                        Name = "Sinop"
                    },
                    new
                    {
                        Id = new Guid("9f9de17f-daaa-44f1-8e28-2c6e3e522dbf"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3185),
                        Name = "Sivas"
                    },
                    new
                    {
                        Id = new Guid("731f0f65-94a6-4308-bae3-e0da9d17bd20"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3189),
                        Name = "Şanlıurfa"
                    },
                    new
                    {
                        Id = new Guid("b073c13c-f6a5-4f94-abae-24e344d58458"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3190),
                        Name = "Tokat"
                    },
                    new
                    {
                        Id = new Guid("859aafdc-aa5e-42a3-a6a3-5b91ce6b44d7"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3192),
                        Name = "Trabzon"
                    },
                    new
                    {
                        Id = new Guid("111f100d-3e09-44fc-9fa7-c1a3052b6a2f"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3195),
                        Name = "Yozgat"
                    });
            });

            modelBuilder.Entity("Resital.Model.Company", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Address")
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid>("CompanyTypeId")
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Note")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("CompanyTypeId");

                b.ToTable("Companies");
            });

            modelBuilder.Entity("Resital.Model.CompanyRoute", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid?>("CompanyId")
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("datetime2");

                b.Property<Guid?>("RouteId")
                    .HasColumnType("uniqueidentifier");

                b.HasKey("Id");

                b.HasIndex("CompanyId");

                b.HasIndex("RouteId");

                b.ToTable("CompanyRoutes");
            });

            modelBuilder.Entity("Resital.Model.CompanyType", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("datetime2");

                b.Property<string>("TypeName")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("CompanyTypes");

                b.HasData(
                    new
                    {
                        Id = new Guid("e4ca49f3-e2ba-4407-af11-67ea81faa4c2"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(1830),
                        TypeName = "Hotel Company"
                    },
                    new
                    {
                        Id = new Guid("c3c3ed11-ad8d-4083-aa66-84ad4f020e63"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(2157),
                        TypeName = "Tour Company "
                    },
                    new
                    {
                        Id = new Guid("ebcf3f3b-c729-45a7-bea6-8f0e5848ddd4"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(2174),
                        TypeName = "AirPlane Company "
                    },
                    new
                    {
                        Id = new Guid("3995f0a1-aef4-4b1e-85b8-60e9eb6bebfc"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(2176),
                        TypeName = "Transfer Company "
                    },
                    new
                    {
                        Id = new Guid("1639fdf8-6555-4425-8d1e-7293ab2a7006"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(2178),
                        TypeName = "RentACar Company "
                    },
                    new
                    {
                        Id = new Guid("ec6899d1-5917-4cb9-9320-1d566c0eb9ce"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(2180),
                        TypeName = "Ship Company "
                    });
            });

            modelBuilder.Entity("Resital.Model.Guide", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Address")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("datetime2");

                b.Property<string>("Language")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Surname")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Guides");
            });

            modelBuilder.Entity("Resital.Model.Room", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("CompanyId")
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("datetime2");

                b.Property<bool>("IsAvailable")
                    .HasColumnType("bit");

                b.Property<Guid>("RoomLocationId")
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid>("RoomTypeId")
                    .HasColumnType("uniqueidentifier");

                b.HasKey("Id");

                b.HasIndex("CompanyId");

                b.HasIndex("RoomLocationId");

                b.HasIndex("RoomTypeId");

                b.ToTable("Rooms");
            });

            modelBuilder.Entity("Resital.Model.RoomLocation", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("RoomLocations");

                b.HasData(
                    new
                    {
                        Id = new Guid("088f62c7-2c25-4ef8-8427-421a92e4a1d5"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(697),
                        Name = "DNZ"
                    },
                    new
                    {
                        Id = new Guid("dcac06dd-7401-4d16-b9e8-6f27bdda25cd"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(1022),
                        Name = "GNL "
                    },
                    new
                    {
                        Id = new Guid("4db0f366-0902-48f9-ad11-efa732d55005"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(1046),
                        Name = "PRK "
                    });
            });

            modelBuilder.Entity("Resital.Model.RoomType", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("RoomTypes");

                b.HasData(
                    new
                    {
                        Id = new Guid("388e0e2b-6352-4389-9138-f12e91f980bd"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 802, DateTimeKind.Local).AddTicks(9612),
                        Name = "SGL"
                    },
                    new
                    {
                        Id = new Guid("20fd96c2-8364-4e51-8034-5714030aa090"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(8),
                        Name = "DBL"
                    },
                    new
                    {
                        Id = new Guid("94849b77-68cd-4b66-89a0-b817103c8f54"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(28),
                        Name = "TRP"
                    },
                    new
                    {
                        Id = new Guid("ad0b3eea-2853-427f-add3-fd432c95b880"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(30),
                        Name = "DBL+1"
                    },
                    new
                    {
                        Id = new Guid("139d3dd7-0876-45fe-8d5c-14e554294ac5"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(32),
                        Name = "TRP+1"
                    });
            });

            modelBuilder.Entity("Resital.Model.Route", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid?>("CompanyId")
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("datetime2");

                b.Property<Guid?>("EndLocationId")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid?>("StartLocationId")
                    .HasColumnType("uniqueidentifier");

                b.HasKey("Id");

                b.HasIndex("CompanyId");

                b.HasIndex("EndLocationId");

                b.HasIndex("StartLocationId");

                b.ToTable("Routes");
            });

            modelBuilder.Entity("Resital.Model.Vehicle", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<Guid?>("CompanyId")
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid?>("VehicleTypeId")
                    .HasColumnType("uniqueidentifier");

                b.HasKey("Id");

                b.HasIndex("CompanyId");

                b.HasIndex("VehicleTypeId");

                b.ToTable("Vehicles");
            });

            modelBuilder.Entity("Resital.Model.VehicleType", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("VehicleTypes");

                b.HasData(
                    new
                    {
                        Id = new Guid("ebf641c4-b1bc-4d53-9697-aa27d0b4a385"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 800, DateTimeKind.Local).AddTicks(3967),
                        Name = "Araba"
                    },
                    new
                    {
                        Id = new Guid("9da947cc-de47-4108-81bf-718aa08ad7ad"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 801, DateTimeKind.Local).AddTicks(9317),
                        Name = "Uçak"
                    },
                    new
                    {
                        Id = new Guid("b9ee1428-9e14-40ab-a324-fc633c2844a9"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 801, DateTimeKind.Local).AddTicks(9377),
                        Name = "Gemi"
                    },
                    new
                    {
                        Id = new Guid("55d29ad8-ca30-481e-8069-2ed791ccafa1"),
                        CreatedAt = new DateTime(2020, 8, 3, 18, 48, 50, 801, DateTimeKind.Local).AddTicks(9381),
                        Name = "Otobüs"
                    });
            });

            modelBuilder.Entity("Model.CartItem", b =>
            {
                b.HasOne("Model.Cart", "Cart")
                    .WithMany("CartItems")
                    .HasForeignKey("CartId");

                b.HasOne("Resital.Model.Room", "Room")
                    .WithMany()
                    .HasForeignKey("RoomId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Resital.Model.Company", b =>
            {
                b.HasOne("Resital.Model.CompanyType", "CompanyType")
                    .WithMany("Companies")
                    .HasForeignKey("CompanyTypeId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Resital.Model.CompanyRoute", b =>
            {
                b.HasOne("Resital.Model.Company", "Company")
                    .WithMany()
                    .HasForeignKey("CompanyId");

                b.HasOne("Resital.Model.Route", "Route")
                    .WithMany()
                    .HasForeignKey("RouteId");
            });

            modelBuilder.Entity("Resital.Model.Room", b =>
            {
                b.HasOne("Resital.Model.Company", "Company")
                    .WithMany("Rooms")
                    .HasForeignKey("CompanyId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Resital.Model.RoomLocation", "RoomLocation")
                    .WithMany("Rooms")
                    .HasForeignKey("RoomLocationId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Resital.Model.RoomType", "RoomType")
                    .WithMany("Rooms")
                    .HasForeignKey("RoomTypeId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Resital.Model.Route", b =>
            {
                b.HasOne("Resital.Model.Company", "Company")
                    .WithMany("Routes")
                    .HasForeignKey("CompanyId");

                b.HasOne("Resital.Model.City", "EndLocation")
                    .WithMany()
                    .HasForeignKey("EndLocationId");

                b.HasOne("Resital.Model.City", "StartLocation")
                    .WithMany()
                    .HasForeignKey("StartLocationId");
            });

            modelBuilder.Entity("Resital.Model.Vehicle", b =>
            {
                b.HasOne("Resital.Model.Company", "Company")
                    .WithMany("Vehicles")
                    .HasForeignKey("CompanyId");

                b.HasOne("Resital.Model.VehicleType", "VehicleType")
                    .WithMany("Vehicles")
                    .HasForeignKey("VehicleTypeId");
            });
#pragma warning restore 612, 618
        }
    }
}