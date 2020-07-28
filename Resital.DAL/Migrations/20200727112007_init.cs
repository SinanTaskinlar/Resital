using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Resital.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TypeName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guides",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomLocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StartLocationId = table.Column<Guid>(nullable: true),
                    EndLocationId = table.Column<Guid>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Routes_Cities_EndLocationId",
                        column: x => x.EndLocationId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Routes_Cities_StartLocationId",
                        column: x => x.StartLocationId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    CompanyTypeId = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_CompanyTypes_CompanyTypeId",
                        column: x => x.CompanyTypeId,
                        principalTable: "CompanyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyRegions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: true),
                    RegionId = table.Column<Guid>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyRegions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyRegions_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyRegions_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyRoutes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: true),
                    RouteId = table.Column<Guid>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyRoutes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyRoutes_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyRoutes_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: false),
                    RoomLocationId = table.Column<Guid>(nullable: false),
                    RoomTypeId = table.Column<Guid>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomLocations_RoomLocationId",
                        column: x => x.RoomLocationId,
                        principalTable: "RoomLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    VehicleTypeId = table.Column<Guid>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("5fae75e6-4838-4a72-9d34-9fdec247312d"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3282), "İstanbul" },
                    { new Guid("ac680eb8-a86f-4a6e-8b96-f64251a6c0cf"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3646), "Yozgat" },
                    { new Guid("9c69d89b-8097-4534-b612-9615982b5312"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3644), "Trabzon" },
                    { new Guid("0f11a363-43d1-4528-b128-9a6595f8fc31"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3642), "Tokat" },
                    { new Guid("a42b4cae-b70d-4ac9-9af1-2238836a02b3"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3640), "Şanlıurfa" },
                    { new Guid("69c1974c-d356-4060-9aaa-1cf6088c72b1"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3638), "Sivas" },
                    { new Guid("88766751-220d-46bb-abd2-bfdc749be070"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3634), "Sinop" },
                    { new Guid("312a6d2a-3e72-487b-af7b-7c2000dd1f76"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3632), "Nevşehir" },
                    { new Guid("1bb7fd30-4716-4911-89c9-dd6ac1f7e107"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3630), "Muğla" },
                    { new Guid("201f8bc2-6139-4ba4-a8e5-3b3f50358d19"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3628), "Kütahya" },
                    { new Guid("2cda6c0c-b1ff-4615-8ec3-c97fb43dc0e2"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3626), "Kastamonu" },
                    { new Guid("ced59c7d-ff37-4781-ad3f-32dc8bd223ff"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3624), "Edirne" },
                    { new Guid("d146477d-a9ff-484a-ba3c-5ab65c7af8d7"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3620), "Çanakkale" },
                    { new Guid("5e72cc7d-10d6-4e7b-9873-0d7c83b00174"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3615), "Bursa" },
                    { new Guid("1f4c7de0-e942-4e2e-8f35-06e2c588ac87"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3613), "Balıkesir" },
                    { new Guid("45e79d3c-4578-4748-924e-b34e127f57c7"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3611), "Artvin" },
                    { new Guid("c64b3fd1-4994-493e-94e8-e2010424d0ac"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3609), "Afyonkarahisar " },
                    { new Guid("377d52dd-5f05-456f-b6d9-9fc2b7f3e86d"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3607), "Eskişehir" },
                    { new Guid("cefa2761-95d9-4928-b21f-ac4fe70f00d1"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3605), "Adana" },
                    { new Guid("3e126224-9c72-49a6-953c-99fb75b82288"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3603), "Antalya" },
                    { new Guid("4afe0ff4-b424-4f46-a8a4-6b6f678e5daf"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3601), "İzmir" },
                    { new Guid("82604518-295f-456b-876e-a0ad535de310"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3579), "Ankara" },
                    { new Guid("dae733b4-eba1-4027-83ab-7d368ef8e6b2"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(3622), "Diyarbakır" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "TypeName" },
                values: new object[,]
                {
                    { new Guid("5eb5053c-5092-4401-8d7b-af5ba76b840c"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(2660), "RentACar Company " },
                    { new Guid("ba26aeaf-cfd2-456c-9c34-7c957d099f39"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(2662), "Ship Company " },
                    { new Guid("ef829760-3861-4d74-96ca-c87a89f68a90"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(2658), "Transfer Company " },
                    { new Guid("2fd6a56c-e287-4c03-a86e-aa035277fb9c"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(2631), "Tour Company " },
                    { new Guid("1cb9623f-9338-43d0-b5dd-1c3d9542aba7"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(2329), "Hotel Company" },
                    { new Guid("c6c3f46e-5686-4fab-9ffe-267fb66fe409"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(2655), "AirPlane Company " }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("90f01ddd-a0cd-401d-96f5-5924d8825fcb"), new DateTime(2020, 7, 27, 14, 20, 6, 791, DateTimeKind.Local).AddTicks(9563), "Yurtdışı" },
                    { new Guid("a97d68ee-1101-4835-b23c-7313e9098a30"), new DateTime(2020, 7, 27, 14, 20, 6, 791, DateTimeKind.Local).AddTicks(9145), "Akdeniz" },
                    { new Guid("15a8ff2f-e51f-4cec-9664-1f841e6e46d4"), new DateTime(2020, 7, 27, 14, 20, 6, 791, DateTimeKind.Local).AddTicks(9535), "Doğu Anadolu" },
                    { new Guid("0a9583aa-c8d1-4253-b2a6-c24099bb385c"), new DateTime(2020, 7, 27, 14, 20, 6, 791, DateTimeKind.Local).AddTicks(9552), "Ege" },
                    { new Guid("800af8e8-9112-4b22-9c9d-b0826a8d3139"), new DateTime(2020, 7, 27, 14, 20, 6, 791, DateTimeKind.Local).AddTicks(9554), "Güneydoğu Anadolu" },
                    { new Guid("e5cdd054-1a83-4693-85b1-b104ad8dfffa"), new DateTime(2020, 7, 27, 14, 20, 6, 791, DateTimeKind.Local).AddTicks(9557), "İç Anadolu" },
                    { new Guid("cceef3b6-0eac-4912-af27-03784624cfcd"), new DateTime(2020, 7, 27, 14, 20, 6, 791, DateTimeKind.Local).AddTicks(9559), "Marmara" },
                    { new Guid("95251185-b1ed-4e41-b7ea-937e0600bd54"), new DateTime(2020, 7, 27, 14, 20, 6, 791, DateTimeKind.Local).AddTicks(9561), "Karadeniz" }
                });

            migrationBuilder.InsertData(
                table: "RoomLocations",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("450daf59-4f51-453b-b4a4-5e0bac36e614"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(1679), "PRK " },
                    { new Guid("3fa7b06a-5088-4c37-b4a5-56f8364fb3e0"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(1350), "DNZ" },
                    { new Guid("bb7f2f52-13e8-47fb-a474-46ecd4b7dbf7"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(1661), "GNL " }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("39f72624-8839-4d34-ae56-e8d6d6d58152"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(678), "TRP+1" },
                    { new Guid("5926210a-8a2b-4a50-a90e-47f65d4c0ac1"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(309), "SGL" },
                    { new Guid("604f5966-7cbd-47e6-b01e-095013e9c591"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(643), "DBL" },
                    { new Guid("b9f0afd4-1709-485a-bb5a-10e993b80c2c"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(673), "TRP" },
                    { new Guid("f029c0d7-ca0c-45f0-90c6-a195220dfbbb"), new DateTime(2020, 7, 27, 14, 20, 6, 792, DateTimeKind.Local).AddTicks(675), "DBL+1" }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("1256d25e-861e-4364-ba1c-6f7194d88a83"), new DateTime(2020, 7, 27, 14, 20, 6, 790, DateTimeKind.Local).AddTicks(7815), "Uçak" },
                    { new Guid("5b109634-103e-40a8-996a-e453a172399a"), new DateTime(2020, 7, 27, 14, 20, 6, 790, DateTimeKind.Local).AddTicks(7873), "Gemi" },
                    { new Guid("137025cf-ade4-4e5b-8d70-d7c55b88fe74"), new DateTime(2020, 7, 27, 14, 20, 6, 789, DateTimeKind.Local).AddTicks(7340), "Araba" },
                    { new Guid("4c45d818-fb55-4a8f-b66c-064856626da1"), new DateTime(2020, 7, 27, 14, 20, 6, 790, DateTimeKind.Local).AddTicks(7912), "Otobüs" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyTypeId",
                table: "Companies",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRegions_CompanyId",
                table: "CompanyRegions",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRegions_RegionId",
                table: "CompanyRegions",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRoutes_CompanyId",
                table: "CompanyRoutes",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRoutes_RouteId",
                table: "CompanyRoutes",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_CompanyId",
                table: "Rooms",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomLocationId",
                table: "Rooms",
                column: "RoomLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_EndLocationId",
                table: "Routes",
                column: "EndLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_StartLocationId",
                table: "Routes",
                column: "StartLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CompanyId",
                table: "Vehicles",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleTypeId",
                table: "Vehicles",
                column: "VehicleTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyRegions");

            migrationBuilder.DropTable(
                name: "CompanyRoutes");

            migrationBuilder.DropTable(
                name: "Guides");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "RoomLocations");

            migrationBuilder.DropTable(
                name: "RoomTypes");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "VehicleTypes");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "CompanyTypes");
        }
    }
}