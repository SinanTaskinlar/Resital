using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

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
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CompanyId = table.Column<Guid>(nullable: true),
                    StartLocationId = table.Column<Guid>(nullable: true),
                    EndLocationId = table.Column<Guid>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Routes_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CardId = table.Column<Guid>(nullable: false),
                    CartId = table.Column<Guid>(nullable: true),
                    RoomId = table.Column<Guid>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItems_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("6643d92d-5af2-4fe7-9f79-858de453c0fb"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(2827), "İstanbul" },
                    { new Guid("111f100d-3e09-44fc-9fa7-c1a3052b6a2f"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3195), "Yozgat" },
                    { new Guid("859aafdc-aa5e-42a3-a6a3-5b91ce6b44d7"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3192), "Trabzon" },
                    { new Guid("731f0f65-94a6-4308-bae3-e0da9d17bd20"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3189), "Şanlıurfa" },
                    { new Guid("9f9de17f-daaa-44f1-8e28-2c6e3e522dbf"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3185), "Sivas" },
                    { new Guid("be19effb-d141-48da-948f-3496aad3faff"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3183), "Sinop" },
                    { new Guid("0dcb24a9-ab3d-42a7-97d4-a38e02c6c55c"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3181), "Nevşehir" },
                    { new Guid("34f79c04-f0d1-4b74-98d1-eab9901d5e88"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3179), "Muğla" },
                    { new Guid("1b12b44a-1172-4f82-adeb-7fb5add052d1"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3177), "Kütahya" },
                    { new Guid("c87259c8-c580-4df2-945e-c54146180762"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3176), "Kastamonu" },
                    { new Guid("11e6aed3-5756-441c-804d-d0c8ae5ccf61"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3174), "Edirne" },
                    { new Guid("b073c13c-f6a5-4f94-abae-24e344d58458"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3190), "Tokat" },
                    { new Guid("66b9ce7e-8c97-432e-b350-03d9f3189d02"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3168), "Çanakkale" },
                    { new Guid("5c1b4394-2b49-4d69-8e0e-bfd33a7c3c19"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3166), "Bursa" },
                    { new Guid("d8f2e801-e5cf-4f44-99c8-c256488b85c1"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3164), "Balıkesir" },
                    { new Guid("edbcd4e5-f695-4237-9f9b-741e965d4f78"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3163), "Artvin" },
                    { new Guid("3f7f09c2-100f-4aca-a3a0-73e3b79f16b3"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3161), "Afyonkarahisar " },
                    { new Guid("b966a529-8c32-45ac-8a66-ad0c7eb97fbe"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3159), "Eskişehir" },
                    { new Guid("922ccbd6-af1f-46b1-9a6b-23cca0f7922d"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3157), "Adana" },
                    { new Guid("eacb19a6-c78f-49ed-b35e-ab1b208cca15"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3155), "Antalya" },
                    { new Guid("0591df02-720d-48c2-9bd5-79502f6a54d3"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3147), "İzmir" },
                    { new Guid("17075669-099c-4b85-8fb5-e89f94ce64de"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3124), "Ankara" },
                    { new Guid("b1cce621-e7e7-467f-8fa5-ba67e9797840"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(3172), "Diyarbakır" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "TypeName" },
                values: new object[,]
                {
                    { new Guid("ec6899d1-5917-4cb9-9320-1d566c0eb9ce"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(2180), "Ship Company " },
                    { new Guid("1639fdf8-6555-4425-8d1e-7293ab2a7006"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(2178), "RentACar Company " },
                    { new Guid("3995f0a1-aef4-4b1e-85b8-60e9eb6bebfc"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(2176), "Transfer Company " },
                    { new Guid("c3c3ed11-ad8d-4083-aa66-84ad4f020e63"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(2157), "Tour Company " },
                    { new Guid("e4ca49f3-e2ba-4407-af11-67ea81faa4c2"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(1830), "Hotel Company" },
                    { new Guid("ebcf3f3b-c729-45a7-bea6-8f0e5848ddd4"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(2174), "AirPlane Company " }
                });

            migrationBuilder.InsertData(
                table: "RoomLocations",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("088f62c7-2c25-4ef8-8427-421a92e4a1d5"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(697), "DNZ" },
                    { new Guid("dcac06dd-7401-4d16-b9e8-6f27bdda25cd"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(1022), "GNL " },
                    { new Guid("4db0f366-0902-48f9-ad11-efa732d55005"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(1046), "PRK " }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("388e0e2b-6352-4389-9138-f12e91f980bd"), new DateTime(2020, 8, 3, 18, 48, 50, 802, DateTimeKind.Local).AddTicks(9612), "SGL" },
                    { new Guid("20fd96c2-8364-4e51-8034-5714030aa090"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(8), "DBL" },
                    { new Guid("94849b77-68cd-4b66-89a0-b817103c8f54"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(28), "TRP" },
                    { new Guid("ad0b3eea-2853-427f-add3-fd432c95b880"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(30), "DBL+1" },
                    { new Guid("139d3dd7-0876-45fe-8d5c-14e554294ac5"), new DateTime(2020, 8, 3, 18, 48, 50, 803, DateTimeKind.Local).AddTicks(32), "TRP+1" }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("b9ee1428-9e14-40ab-a324-fc633c2844a9"), new DateTime(2020, 8, 3, 18, 48, 50, 801, DateTimeKind.Local).AddTicks(9377), "Gemi" },
                    { new Guid("ebf641c4-b1bc-4d53-9697-aa27d0b4a385"), new DateTime(2020, 8, 3, 18, 48, 50, 800, DateTimeKind.Local).AddTicks(3967), "Araba" },
                    { new Guid("9da947cc-de47-4108-81bf-718aa08ad7ad"), new DateTime(2020, 8, 3, 18, 48, 50, 801, DateTimeKind.Local).AddTicks(9317), "Uçak" },
                    { new Guid("55d29ad8-ca30-481e-8069-2ed791ccafa1"), new DateTime(2020, 8, 3, 18, 48, 50, 801, DateTimeKind.Local).AddTicks(9381), "Otobüs" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_RoomId",
                table: "CartItems",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyTypeId",
                table: "Companies",
                column: "CompanyTypeId");

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
                name: "IX_Routes_CompanyId",
                table: "Routes",
                column: "CompanyId");

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
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "CompanyRoutes");

            migrationBuilder.DropTable(
                name: "Guides");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "VehicleTypes");

            migrationBuilder.DropTable(
                name: "RoomLocations");

            migrationBuilder.DropTable(
                name: "RoomTypes");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "CompanyTypes");
        }
    }
}
