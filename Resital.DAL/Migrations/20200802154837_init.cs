using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
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
                    { new Guid("e07d3455-ea3b-453e-9440-7d0c0b97a6a0"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5485), "İstanbul" },
                    { new Guid("a0eb6d06-516c-4f50-9df7-7adf0cfa7d5a"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5845), "Yozgat" },
                    { new Guid("6c9acea1-6cd5-49b9-ba9c-001c4d402731"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5843), "Trabzon" },
                    { new Guid("e71ca81b-e1c7-4478-aa14-096fe92e33be"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5839), "Şanlıurfa" },
                    { new Guid("b6af9d71-03b7-426f-82cc-7af405461e99"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5838), "Sivas" },
                    { new Guid("64bf4d54-3aeb-4c4e-b463-020ac82d846d"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5836), "Sinop" },
                    { new Guid("e71fc392-c629-46e1-95e3-acb10d608ea9"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5834), "Nevşehir" },
                    { new Guid("fa43fbf3-2afe-453c-bf0e-4ddbe873ac97"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5832), "Muğla" },
                    { new Guid("10e9d10d-673b-429e-9435-5bb739953355"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5828), "Kütahya" },
                    { new Guid("e7a974dc-a454-4175-9c41-2663b993bb2e"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5826), "Kastamonu" },
                    { new Guid("6e4e252f-cf1f-46ea-b0d5-5394e5e0eab9"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5824), "Edirne" },
                    { new Guid("c65c6047-a883-4afb-be5a-1dc08dcbf2ce"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5841), "Tokat" },
                    { new Guid("f04ecb88-edeb-4d05-81bd-8c51b5eb170e"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5820), "Çanakkale" },
                    { new Guid("6c8aed9d-1011-4941-8142-4dc482215fc4"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5819), "Bursa" },
                    { new Guid("77d9eae3-47f7-442c-a306-e2d3a0fc2213"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5817), "Balıkesir" },
                    { new Guid("39913100-ad70-4038-9fb9-ab28630b463c"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5815), "Artvin" },
                    { new Guid("45f579c9-e6b9-4404-aa79-4949f753dab3"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5808), "Afyonkarahisar " },
                    { new Guid("e2871ac4-13e5-425f-a562-5ab66971652c"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5806), "Eskişehir" },
                    { new Guid("2a6cceb1-69b2-4803-97f6-fa6fdfccd474"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5804), "Adana" },
                    { new Guid("a1708eaa-69f8-4514-9f0f-8902f91d892a"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5802), "Antalya" },
                    { new Guid("e0ecaf1a-de89-4ccc-ab58-b63404f6118b"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5800), "İzmir" },
                    { new Guid("a9c0c698-1028-4a5d-9a97-ff803910e298"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5775), "Ankara" },
                    { new Guid("ac1296be-c388-4cc4-9ec5-f76d84636b98"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(5822), "Diyarbakır" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "TypeName" },
                values: new object[,]
                {
                    { new Guid("76b15c5f-1137-4851-bd7e-6e4c3005dfac"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(4875), "Ship Company " },
                    { new Guid("934b8b43-b22b-424e-84e7-2c1ef79e128f"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(4869), "RentACar Company " },
                    { new Guid("24889c90-8e83-4dbc-a8b7-5dc7480adf5e"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(4867), "Transfer Company " },
                    { new Guid("0981ac6a-1b71-4383-8069-c869ab3836a4"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(4849), "Tour Company " },
                    { new Guid("85309226-2f5c-4cd4-a16b-36f49884ce7d"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(4552), "Hotel Company" },
                    { new Guid("5a95de08-1def-48a8-9860-69c31aae8a5b"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(4864), "AirPlane Company " }
                });

            migrationBuilder.InsertData(
                table: "RoomLocations",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("56686cdc-bcd9-4ebb-9f8d-f3e35019b83e"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(3579), "DNZ" },
                    { new Guid("edd7b919-8bc5-465c-873d-5f2ff48d76c7"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(3892), "GNL " },
                    { new Guid("b7b5dcf6-0ea1-4e43-a8e1-955fb8ed502b"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(3913), "PRK " }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("045c7b52-397b-4d21-bf27-f32532c65d64"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(2512), "SGL" },
                    { new Guid("44f320c4-1f36-466e-bb87-87a60997663d"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(2880), "DBL" },
                    { new Guid("36f5c7ac-a3aa-4e99-8300-c096a71bd52d"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(2898), "TRP" },
                    { new Guid("890caf1c-ff04-499f-8521-ae53cfd209b9"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(2900), "DBL+1" },
                    { new Guid("57f049e4-e7d3-41f0-bbb8-6c394c8d7f3d"), new DateTime(2020, 8, 2, 18, 48, 37, 308, DateTimeKind.Local).AddTicks(2902), "TRP+1" }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("4219ebbf-993b-45ac-bc45-4e83c0e74102"), new DateTime(2020, 8, 2, 18, 48, 37, 307, DateTimeKind.Local).AddTicks(2628), "Gemi" },
                    { new Guid("ac938c9f-c404-477e-be67-bf09a5728283"), new DateTime(2020, 8, 2, 18, 48, 37, 305, DateTimeKind.Local).AddTicks(8936), "Araba" },
                    { new Guid("7e64c8b3-43eb-4ed0-bf3c-59a333e28d82"), new DateTime(2020, 8, 2, 18, 48, 37, 307, DateTimeKind.Local).AddTicks(2576), "Uçak" },
                    { new Guid("7eef288f-c183-4b28-be3a-51783ab02a9e"), new DateTime(2020, 8, 2, 18, 48, 37, 307, DateTimeKind.Local).AddTicks(2632), "Otobüs" }
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
