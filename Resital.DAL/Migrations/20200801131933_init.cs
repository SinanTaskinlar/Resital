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
                    { new Guid("162c75dd-012b-42e2-8035-0bb5ba77b604"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5260), "İstanbul" },
                    { new Guid("fef327b9-ad90-4d20-97a1-5a59023fbae7"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5793), "Yozgat" },
                    { new Guid("e0250938-6c1c-4954-a830-7aaf0fa973c8"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5791), "Trabzon" },
                    { new Guid("dedf4022-33ac-4b0e-a849-e490892dfc4e"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5786), "Şanlıurfa" },
                    { new Guid("ce7437b0-9594-4c82-9a91-3305d2e2948c"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5781), "Sivas" },
                    { new Guid("4e3637c8-244a-4870-bfc7-0efdc9daa340"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5778), "Sinop" },
                    { new Guid("18b493ea-a312-4d2c-8db8-fc356ee444ef"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5776), "Nevşehir" },
                    { new Guid("719f0beb-0c97-4bed-b9b1-fe7f9c24d32a"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5774), "Muğla" },
                    { new Guid("385e48b2-25f9-452e-8c31-6ebc6f785ad4"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5772), "Kütahya" },
                    { new Guid("dc9d65f9-a817-47f4-9cca-af508f04fb8f"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5770), "Kastamonu" },
                    { new Guid("7183d86b-99a7-48a9-802c-4eb77c6a20f6"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5769), "Edirne" },
                    { new Guid("b8aa3cd8-ae02-4ab1-a06a-e19f0a9c2ad0"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5789), "Tokat" },
                    { new Guid("117b8984-cb6e-4ff9-be1a-78e8be82a6bb"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5762), "Çanakkale" },
                    { new Guid("b643f488-77ef-4ed4-a433-751ae2a51cee"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5760), "Bursa" },
                    { new Guid("a6a24f85-77df-4cf5-a83c-3dcace9ca079"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5759), "Balıkesir" },
                    { new Guid("62ee7fcc-3c4f-4334-abd2-506c55576e77"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5757), "Artvin" },
                    { new Guid("d1bb95e9-8590-4cf7-ae54-ee891355c400"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5755), "Afyonkarahisar " },
                    { new Guid("83685720-a498-4155-953d-33ddca8a27e7"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5753), "Eskişehir" },
                    { new Guid("15ca0b97-9deb-49e9-b3c2-765d7c868eb6"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5751), "Adana" },
                    { new Guid("aeb91815-8726-4f67-b01b-781f2d22a9a9"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5749), "Antalya" },
                    { new Guid("dac56eb4-2476-4c21-9d8f-95a2df6b7d70"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5742), "İzmir" },
                    { new Guid("19f85b33-6b07-4fa9-99df-da4a926afcb3"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5718), "Ankara" },
                    { new Guid("75587eae-db4b-49c8-9392-81eec55df539"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(5767), "Diyarbakır" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "TypeName" },
                values: new object[,]
                {
                    { new Guid("6089b12d-669b-4b8d-a164-64f2a0427b9b"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(4436), "Ship Company " },
                    { new Guid("2637af49-5c00-4cb9-a4e7-91e44ac3926d"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(4434), "RentACar Company " },
                    { new Guid("e034b9a5-e3cf-4fdb-a584-d320ad79cf7c"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(4432), "Transfer Company " },
                    { new Guid("3a7de0ab-12fa-49e9-b3f3-f5391a822c98"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(4412), "Tour Company " },
                    { new Guid("2dab66e3-fe09-4907-a755-3d8ff26c1e9d"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(4110), "Hotel Company" },
                    { new Guid("22dd934d-eff9-409e-bff6-0149bf905581"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(4429), "AirPlane Company " }
                });

            migrationBuilder.InsertData(
                table: "RoomLocations",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("95ace62f-e388-4006-92c1-40a1d196d014"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(3162), "DNZ" },
                    { new Guid("118bd04d-ad1e-4a85-a4ef-bc8158552d43"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(3474), "GNL " },
                    { new Guid("1601d15e-6a3f-4360-ac5b-f413cd3083d8"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(3497), "PRK " }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("cbf8b885-57a6-4df0-99bd-da5902bb88b9"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(2132), "SGL" },
                    { new Guid("a8dc58c3-8fc2-4a1d-a7b6-5bf6ba07667f"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(2509), "DBL" },
                    { new Guid("5e86dc0b-08eb-499d-8e79-82757183e16b"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(2527), "TRP" },
                    { new Guid("3530fd0f-8e91-4944-a685-de4d78891cbd"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(2529), "DBL+1" },
                    { new Guid("09021fcf-8e23-42fe-b931-5fb5c7e46205"), new DateTime(2020, 8, 1, 16, 19, 33, 276, DateTimeKind.Local).AddTicks(2531), "TRP+1" }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("fbbc79bc-4845-49d3-b2ba-2c87f1582da7"), new DateTime(2020, 8, 1, 16, 19, 33, 275, DateTimeKind.Local).AddTicks(2194), "Gemi" },
                    { new Guid("e4ffd3cd-63a1-40ae-9186-43de77bd27c0"), new DateTime(2020, 8, 1, 16, 19, 33, 273, DateTimeKind.Local).AddTicks(9014), "Araba" },
                    { new Guid("5683445c-b07e-4e36-afa4-f118593a2a75"), new DateTime(2020, 8, 1, 16, 19, 33, 275, DateTimeKind.Local).AddTicks(2140), "Uçak" },
                    { new Guid("5f623b38-8f77-4c03-89f7-5a0d02462725"), new DateTime(2020, 8, 1, 16, 19, 33, 275, DateTimeKind.Local).AddTicks(2197), "Otobüs" }
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