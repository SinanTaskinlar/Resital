using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
                    CompanyId = table.Column<Guid>(nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
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
                    CompanyId = table.Column<Guid>(nullable: true),
                    VehicleTypeId = table.Column<Guid>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
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
                    { new Guid("f18c8cd4-215f-4194-b4ef-82415501d2c3"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(157), "İstanbul" },
                    { new Guid("c7770d5e-c2eb-4a6c-9307-1fa727f10a3e"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(721), "Yozgat" },
                    { new Guid("67c22f9d-b57b-4b32-8535-e6d79ad21218"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(719), "Trabzon" },
                    { new Guid("b2ad5115-0ea4-48a0-b6f7-63d6d54d930a"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(717), "Tokat" },
                    { new Guid("180706bb-d927-4c80-b9e7-740924d8eafa"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(715), "Şanlıurfa" },
                    { new Guid("b7722d28-661d-4e74-8ff0-9d3643fbf938"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(710), "Sivas" },
                    { new Guid("2b7830c8-f41c-453f-aa09-b63a06279600"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(709), "Sinop" },
                    { new Guid("d0ca1c4d-cdf6-4131-9ce5-7cae50ba5aa6"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(707), "Nevşehir" },
                    { new Guid("f168a9a0-eedd-4f82-a26d-2a59700c68a1"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(705), "Muğla" },
                    { new Guid("0af25785-2feb-4fe0-9838-093cd956f3f3"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(703), "Kütahya" },
                    { new Guid("0a62fb86-bfd9-41a0-8f24-965b42616bdf"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(700), "Kastamonu" },
                    { new Guid("45fa5ea3-02ae-410a-884c-73fc5314eef5"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(698), "Edirne" },
                    { new Guid("682087e8-0d26-4c3f-8e9e-c7bdf3a164db"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(691), "Çanakkale" },
                    { new Guid("f2bcce94-ea22-49f4-b04d-b5fe7ccc248e"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(689), "Bursa" },
                    { new Guid("9d244412-b276-45b8-8e71-3467cf97a006"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(686), "Balıkesir" },
                    { new Guid("696e8e1b-c503-4ec5-a50e-fda24be6240a"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(684), "Artvin" },
                    { new Guid("8bad33fa-da3f-4545-9259-7a41a80f42ab"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(682), "Afyonkarahisar " },
                    { new Guid("9c62a3d3-8cca-4d5d-9239-0f046fda6d5d"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(680), "Eskişehir" },
                    { new Guid("b3738e56-558a-480d-981e-215d5eecbcfa"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(678), "Adana" },
                    { new Guid("c9478258-56d7-49a1-9cd0-438c55d8c5c4"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(676), "Antalya" },
                    { new Guid("8f2ea544-acaa-4a36-a3fa-e866f9726d60"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(669), "İzmir" },
                    { new Guid("41fa2fcb-f5ff-47b8-bafc-2f153ad56117"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(650), "Ankara" },
                    { new Guid("399204ff-c5a5-4f0d-8d1e-616f6d5a5dd8"), new DateTime(2020, 7, 29, 0, 31, 31, 194, DateTimeKind.Local).AddTicks(696), "Diyarbakır" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "TypeName" },
                values: new object[,]
                {
                    { new Guid("d5476bf9-abee-4f41-932b-9ea65ac6f59e"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(9436), "RentACar Company " },
                    { new Guid("69531377-3205-47e9-9c02-e4e4fd2b59b7"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(9493), "Ship Company " },
                    { new Guid("b9434cfe-bcd1-4f3b-8712-87a724c54a7c"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(9434), "Transfer Company " },
                    { new Guid("f53fe6fd-7854-4f07-b413-39b5ad759456"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(9406), "Tour Company " },
                    { new Guid("4d447864-3590-4c07-9c57-fe8f2cb8cf20"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(9089), "Hotel Company" },
                    { new Guid("bb092416-4b17-49fa-911a-d5a269be20a3"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(9432), "AirPlane Company " }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("aaca2287-1c33-4daa-9b0e-802bc9630bed"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(5228), "Yurtdışı" },
                    { new Guid("cb24c16d-ac53-40c2-b8eb-f2d4715eae59"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(4111), "Akdeniz" },
                    { new Guid("744fd9f0-1729-4d84-8d5d-d1d28f27e933"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(5196), "Doğu Anadolu" },
                    { new Guid("3ac9c6a8-a5cc-4ccc-bcbf-1de4c9497aae"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(5217), "Ege" },
                    { new Guid("47892553-aa73-44d2-977e-f944abbbe5ec"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(5220), "Güneydoğu Anadolu" },
                    { new Guid("2520b464-5bb7-4f40-b47a-d3563e9453a0"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(5222), "İç Anadolu" },
                    { new Guid("414573ba-125e-4083-bd61-a01cb928c383"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(5224), "Marmara" },
                    { new Guid("f9fe3b11-c38a-4ec7-b788-c45fdeade220"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(5226), "Karadeniz" }
                });

            migrationBuilder.InsertData(
                table: "RoomLocations",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("33dfb9fb-fe4b-4434-8424-3b9d222fdce8"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(8240), "PRK " },
                    { new Guid("8d97f7ec-3819-42da-a9d2-d74a8e78e695"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(7901), "DNZ" },
                    { new Guid("a68b9bd8-45e9-4990-a659-db8d7398d338"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(8222), "GNL " }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("b92f61ff-8c58-4ff6-aab4-51b000d6ae0d"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(7204), "TRP+1" },
                    { new Guid("4ed77298-cdff-49a7-a685-f8b0c8e8e6f9"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(6831), "SGL" },
                    { new Guid("485a148d-2b21-4f76-add9-c3c3c5b6be41"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(7177), "DBL" },
                    { new Guid("5d436b0b-dd53-478b-9f77-186dec81419b"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(7200), "TRP" },
                    { new Guid("4ba016ff-a14f-49ee-ba25-c44590c39b3b"), new DateTime(2020, 7, 29, 0, 31, 31, 193, DateTimeKind.Local).AddTicks(7202), "DBL+1" }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("ac6a27f6-95a8-4dff-b3d6-159c4436f058"), new DateTime(2020, 7, 29, 0, 31, 31, 192, DateTimeKind.Local).AddTicks(2475), "Uçak" },
                    { new Guid("8f97e3a7-2745-4cd6-b19f-08fb98f5c14a"), new DateTime(2020, 7, 29, 0, 31, 31, 192, DateTimeKind.Local).AddTicks(2531), "Gemi" },
                    { new Guid("8e196584-17f3-4220-9a1c-f19a6572f931"), new DateTime(2020, 7, 29, 0, 31, 31, 191, DateTimeKind.Local).AddTicks(3636), "Araba" },
                    { new Guid("082f3933-0e96-44a2-8246-37c0d599c046"), new DateTime(2020, 7, 29, 0, 31, 31, 192, DateTimeKind.Local).AddTicks(2535), "Otobüs" }
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
