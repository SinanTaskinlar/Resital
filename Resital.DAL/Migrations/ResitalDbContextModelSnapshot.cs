﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Resital.DAL;

namespace DataAccess.Migrations
{
    [DbContext(typeof(ResitalDbContext))]
    partial class ResitalDbContextModelSnapshot : ModelSnapshot
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
                            Id = new Guid("d192f9c9-e360-419f-8423-34ec02f5356b"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6006),
                            Name = "İstanbul"
                        },
                        new
                        {
                            Id = new Guid("067efa49-a8b7-4617-92c2-5e2edf78011f"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6325),
                            Name = "Ankara"
                        },
                        new
                        {
                            Id = new Guid("d8f5ed6c-26dd-4015-96ff-a7100a253631"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6350),
                            Name = "İzmir"
                        },
                        new
                        {
                            Id = new Guid("618fe19d-159c-4ba9-813f-d8a08dc78c26"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6353),
                            Name = "Antalya"
                        },
                        new
                        {
                            Id = new Guid("f2609f09-d1a6-456e-a8d8-95c57cc92639"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6354),
                            Name = "Adana"
                        },
                        new
                        {
                            Id = new Guid("9e709362-e663-4fc2-bd74-99eb396b0502"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6356),
                            Name = "Eskişehir"
                        },
                        new
                        {
                            Id = new Guid("18ff7f9c-f0cd-4c81-bbba-2d7be0902541"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6364),
                            Name = "Afyonkarahisar "
                        },
                        new
                        {
                            Id = new Guid("ef6a59b2-2de2-4809-8cf2-5c592c0635c9"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6366),
                            Name = "Artvin"
                        },
                        new
                        {
                            Id = new Guid("a633e150-c810-4c33-b3e5-f4f1c40318ea"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6368),
                            Name = "Balıkesir"
                        },
                        new
                        {
                            Id = new Guid("4ef6cf64-84c5-4cfb-aacc-2724c9896372"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6370),
                            Name = "Bursa"
                        },
                        new
                        {
                            Id = new Guid("72fc73ca-7040-48dd-8c4c-1d3c6a79f51a"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6372),
                            Name = "Çanakkale"
                        },
                        new
                        {
                            Id = new Guid("277828c0-463e-41a8-be3a-62c21e4fded7"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6374),
                            Name = "Diyarbakır"
                        },
                        new
                        {
                            Id = new Guid("cabf2b04-f618-4877-b802-f4f5604d33fd"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6375),
                            Name = "Edirne"
                        },
                        new
                        {
                            Id = new Guid("7ea60581-b9e9-4270-b748-34a7ccf12ff1"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6377),
                            Name = "Kastamonu"
                        },
                        new
                        {
                            Id = new Guid("eb6a4462-1858-4235-950b-873f4da12823"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6382),
                            Name = "Kütahya"
                        },
                        new
                        {
                            Id = new Guid("8b9dc007-5f10-442f-9734-14dbde735563"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6384),
                            Name = "Muğla"
                        },
                        new
                        {
                            Id = new Guid("867d1772-61f9-4465-9f96-0853f5dce39c"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6386),
                            Name = "Nevşehir"
                        },
                        new
                        {
                            Id = new Guid("83472766-3fc4-4237-8a1c-7d822752cfd8"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6388),
                            Name = "Sinop"
                        },
                        new
                        {
                            Id = new Guid("e7044d03-3e35-4e46-b31f-7c9fc43a9aae"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6389),
                            Name = "Sivas"
                        },
                        new
                        {
                            Id = new Guid("b4cc0b0e-012e-4d6b-bcd4-629b9c9bfb81"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6391),
                            Name = "Şanlıurfa"
                        },
                        new
                        {
                            Id = new Guid("68d042d2-f910-4c3d-8f6b-bec381ea5322"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6393),
                            Name = "Tokat"
                        },
                        new
                        {
                            Id = new Guid("41b404ca-ce5c-45b7-9461-0fcb098d213f"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6395),
                            Name = "Trabzon"
                        },
                        new
                        {
                            Id = new Guid("86f73beb-089e-4b56-a732-90bb16b438ac"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6399),
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
                            Id = new Guid("3e3e477a-1006-4e72-90f4-1482486171eb"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(4833),
                            TypeName = "Hotel Company"
                        },
                        new
                        {
                            Id = new Guid("17bce783-3037-42cb-95fd-e9e43b763e5c"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(5151),
                            TypeName = "Tour Company "
                        },
                        new
                        {
                            Id = new Guid("7f0b46e8-e91e-4346-a6aa-afd13fd10d7e"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(5168),
                            TypeName = "AirPlane Company "
                        },
                        new
                        {
                            Id = new Guid("f4e50947-1f87-40d0-b961-73b4ffeabe3b"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(5170),
                            TypeName = "Transfer Company "
                        },
                        new
                        {
                            Id = new Guid("c692e129-9329-4cc5-8950-168b59d2b9da"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(5178),
                            TypeName = "RentACar Company "
                        },
                        new
                        {
                            Id = new Guid("eec01196-45af-4d9a-b78e-72d28ddbb4ae"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(5180),
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

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<Guid?>("RoomLocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RoomTypeId")
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
                            Id = new Guid("79621946-7fc2-4210-9539-627a1eb3a7fe"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(3759),
                            Name = "DNZ"
                        },
                        new
                        {
                            Id = new Guid("7689af3d-f4de-4c39-a63d-b992d2e3a64f"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(4107),
                            Name = "GNL "
                        },
                        new
                        {
                            Id = new Guid("f90ce176-d2a8-4495-830e-d47c3dc28d8c"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(4132),
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
                            Id = new Guid("47363ba0-180a-4a8c-9be8-dc4d702ed134"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(2614),
                            Name = "SGL"
                        },
                        new
                        {
                            Id = new Guid("315d392d-827b-4c53-9353-a0e9fd908a3f"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(3025),
                            Name = "DBL"
                        },
                        new
                        {
                            Id = new Guid("25632fc1-11ad-49b2-b2fb-9797bb09e54f"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(3044),
                            Name = "TRP"
                        },
                        new
                        {
                            Id = new Guid("40d9f203-8179-4076-8535-e468aa13fbbd"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(3047),
                            Name = "DBL+1"
                        },
                        new
                        {
                            Id = new Guid("b06d1920-ef2c-4251-b9b0-32c7c587b467"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(3059),
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
                            Id = new Guid("22029b66-cd88-4174-b278-57f1dc787fbe"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 359, DateTimeKind.Local).AddTicks(4721),
                            Name = "Araba"
                        },
                        new
                        {
                            Id = new Guid("9cc0226b-3dc2-41d5-a3fe-6bb2ea61e289"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 361, DateTimeKind.Local).AddTicks(1276),
                            Name = "Uçak"
                        },
                        new
                        {
                            Id = new Guid("e08d5daa-92c3-4bdf-9f85-43f5aab311e2"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 361, DateTimeKind.Local).AddTicks(1343),
                            Name = "Gemi"
                        },
                        new
                        {
                            Id = new Guid("087f6724-32c6-476b-bbff-5a38418641d6"),
                            CreatedAt = new DateTime(2020, 8, 3, 14, 53, 38, 361, DateTimeKind.Local).AddTicks(1347),
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
                        .HasForeignKey("CompanyId");

                    b.HasOne("Resital.Model.RoomLocation", "RoomLocation")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomLocationId");

                    b.HasOne("Resital.Model.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeId");
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
