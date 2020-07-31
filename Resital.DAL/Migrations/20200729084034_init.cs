using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Resital.DAL.Migrations
{
    public partial class İnit : Migration
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
                    CompanyId = table.Column<Guid>(nullable: true),
                    RoomLocationId = table.Column<Guid>(nullable: true),
                    RoomTypeId = table.Column<Guid>(nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    { new Guid("c153ce9d-3708-4471-8c12-fcc77c3a5a12"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3457), "İstanbul" },
                    { new Guid("f35676ba-a3e7-44f5-92b1-acada39683bb"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3822), "Yozgat" },
                    { new Guid("6441549a-4f8f-48c0-b916-e7f2ae684bdd"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3820), "Trabzon" },
                    { new Guid("87f23a1c-dc1c-4217-9bbf-3e712e0ed01b"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3814), "Şanlıurfa" },
                    { new Guid("d2053be5-1a0b-47f5-8862-784f98e2109d"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3812), "Sivas" },
                    { new Guid("d88a1aa5-1279-43c4-87c5-2ae84a963b40"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3811), "Sinop" },
                    { new Guid("71c2e9a5-b3ea-4108-8f13-448f0280bd06"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3809), "Nevşehir" },
                    { new Guid("d8c823c2-081c-4dd2-a898-e94b63c89ae9"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3807), "Muğla" },
                    { new Guid("80815145-a279-49ae-9145-26f564820adb"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3805), "Kütahya" },
                    { new Guid("6a3504d2-b454-4aff-b23e-65a96f8593fe"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3803), "Kastamonu" },
                    { new Guid("f4203ddb-5565-4827-a786-0309390a6380"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3801), "Edirne" },
                    { new Guid("c48ed081-8adf-4b3a-8b0d-2b09c9e60d6b"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3818), "Tokat" },
                    { new Guid("aa8a6586-38ae-4d5f-96e3-dfd7f52705e8"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3795), "Çanakkale" },
                    { new Guid("7634d9fd-f7a6-44cd-9190-d8796e77f0fc"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3793), "Bursa" },
                    { new Guid("ee865b66-f513-4dc5-98ea-3cd0e6fdf31d"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3791), "Balıkesir" },
                    { new Guid("217ccc91-a13e-4965-8988-7e4f3a9e70a4"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3789), "Artvin" },
                    { new Guid("b05d243d-21c6-446b-8261-9c7e9760beb4"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3787), "Afyonkarahisar " },
                    { new Guid("62ae5644-5cfd-4cb3-bb98-b33cd595597b"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3785), "Eskişehir" },
                    { new Guid("7ac907a0-d7ff-4778-8a7b-e073019aa3fc"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3782), "Adana" },
                    { new Guid("cb3e2568-e09f-46c4-9641-b9557b20641e"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3776), "Antalya" },
                    { new Guid("1663e83b-ca62-4183-ac92-d4ce892867f9"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3773), "İzmir" },
                    { new Guid("e80ffb33-0fe6-48b8-b29b-5fd23bbc31f4"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3744), "Ankara" },
                    { new Guid("a90adf12-d9cb-43dc-8bdc-98f070b79a5e"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(3797), "Diyarbakır" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "TypeName" },
                values: new object[,]
                {
                    { new Guid("c77ec791-d7f0-43e7-ba76-e616c18a291b"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(2779), "Ship Company " },
                    { new Guid("eb216a45-5344-4069-b53f-6d5b5055fd5c"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(2777), "RentACar Company " },
                    { new Guid("7ea38dfd-d2d9-4f73-9836-20c646051171"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(2775), "Transfer Company " },
                    { new Guid("ff283664-e78e-43db-9f50-08b45fa1f529"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(2745), "Tour Company " },
                    { new Guid("d03d01e6-36b4-4b4b-96a7-117f497e6546"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(2447), "Hotel Company" },
                    { new Guid("85cea106-a7d7-4aa3-b865-3024ee1d3447"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(2772), "AirPlane Company " }
                });

            migrationBuilder.InsertData(
                table: "RoomLocations",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("2c0c3ad4-dc88-41a3-9690-f7a4c11918cb"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(1467), "DNZ" },
                    { new Guid("afe7280b-0f43-4b8e-99a4-cd832c861e9b"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(1785), "GNL " },
                    { new Guid("aa2a0a73-2584-41cd-ba00-459fdb07fb87"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(1805), "PRK " }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("b841a2dd-b9e4-4385-b5cd-b8c5e58d90a8"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(409), "SGL" },
                    { new Guid("acbc5bf8-d023-4360-9923-7ee9fac8606c"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(780), "DBL" },
                    { new Guid("c5acb95d-c734-479e-962e-e944a169c3e5"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(810), "TRP" },
                    { new Guid("102b1dac-bcf4-459f-9ff8-e04c3af422f8"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(813), "DBL+1" },
                    { new Guid("7aaeaf3a-1b70-4415-a985-730888350857"), new DateTime(2020, 7, 29, 11, 40, 34, 546, DateTimeKind.Local).AddTicks(815), "TRP+1" }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("a9035bbe-0d10-4ffb-ac85-dc6089536d9c"), new DateTime(2020, 7, 29, 11, 40, 34, 544, DateTimeKind.Local).AddTicks(9409), "Gemi" },
                    { new Guid("93feff4b-8f80-4e69-ad57-fb4db9029ca5"), new DateTime(2020, 7, 29, 11, 40, 34, 543, DateTimeKind.Local).AddTicks(5188), "Araba" },
                    { new Guid("a1f321ee-0923-4a5e-8407-519bd3844027"), new DateTime(2020, 7, 29, 11, 40, 34, 544, DateTimeKind.Local).AddTicks(9337), "Uçak" },
                    { new Guid("7bba55b1-66d5-42e4-9578-c83ca2badace"), new DateTime(2020, 7, 29, 11, 40, 34, 544, DateTimeKind.Local).AddTicks(9413), "Otobüs" }
                });

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
                name: "CompanyRoutes");

            migrationBuilder.DropTable(
                name: "Guides");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "RoomLocations");

            migrationBuilder.DropTable(
                name: "RoomTypes");

            migrationBuilder.DropTable(
                name: "VehicleTypes");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "CompanyTypes");
        }
    }
}
