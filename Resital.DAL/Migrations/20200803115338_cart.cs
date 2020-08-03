using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class cart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("10e9d10d-673b-429e-9435-5bb739953355"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("2a6cceb1-69b2-4803-97f6-fa6fdfccd474"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("39913100-ad70-4038-9fb9-ab28630b463c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("45f579c9-e6b9-4404-aa79-4949f753dab3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("64bf4d54-3aeb-4c4e-b463-020ac82d846d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6c8aed9d-1011-4941-8142-4dc482215fc4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6c9acea1-6cd5-49b9-ba9c-001c4d402731"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6e4e252f-cf1f-46ea-b0d5-5394e5e0eab9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("77d9eae3-47f7-442c-a306-e2d3a0fc2213"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a0eb6d06-516c-4f50-9df7-7adf0cfa7d5a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a1708eaa-69f8-4514-9f0f-8902f91d892a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a9c0c698-1028-4a5d-9a97-ff803910e298"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ac1296be-c388-4cc4-9ec5-f76d84636b98"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b6af9d71-03b7-426f-82cc-7af405461e99"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("c65c6047-a883-4afb-be5a-1dc08dcbf2ce"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e07d3455-ea3b-453e-9440-7d0c0b97a6a0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e0ecaf1a-de89-4ccc-ab58-b63404f6118b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e2871ac4-13e5-425f-a562-5ab66971652c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e71ca81b-e1c7-4478-aa14-096fe92e33be"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e71fc392-c629-46e1-95e3-acb10d608ea9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e7a974dc-a454-4175-9c41-2663b993bb2e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f04ecb88-edeb-4d05-81bd-8c51b5eb170e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("fa43fbf3-2afe-453c-bf0e-4ddbe873ac97"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("0981ac6a-1b71-4383-8069-c869ab3836a4"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("24889c90-8e83-4dbc-a8b7-5dc7480adf5e"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("5a95de08-1def-48a8-9860-69c31aae8a5b"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("76b15c5f-1137-4851-bd7e-6e4c3005dfac"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("85309226-2f5c-4cd4-a16b-36f49884ce7d"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("934b8b43-b22b-424e-84e7-2c1ef79e128f"));

            migrationBuilder.DeleteData(
                table: "RoomLocations",
                keyColumn: "Id",
                keyValue: new Guid("56686cdc-bcd9-4ebb-9f8d-f3e35019b83e"));

            migrationBuilder.DeleteData(
                table: "RoomLocations",
                keyColumn: "Id",
                keyValue: new Guid("b7b5dcf6-0ea1-4e43-a8e1-955fb8ed502b"));

            migrationBuilder.DeleteData(
                table: "RoomLocations",
                keyColumn: "Id",
                keyValue: new Guid("edd7b919-8bc5-465c-873d-5f2ff48d76c7"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("045c7b52-397b-4d21-bf27-f32532c65d64"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("36f5c7ac-a3aa-4e99-8300-c096a71bd52d"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("44f320c4-1f36-466e-bb87-87a60997663d"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("57f049e4-e7d3-41f0-bbb8-6c394c8d7f3d"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("890caf1c-ff04-499f-8521-ae53cfd209b9"));

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: new Guid("4219ebbf-993b-45ac-bc45-4e83c0e74102"));

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: new Guid("7e64c8b3-43eb-4ed0-bf3c-59a333e28d82"));

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: new Guid("7eef288f-c183-4b28-be3a-51783ab02a9e"));

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: new Guid("ac938c9f-c404-477e-be67-bf09a5728283"));

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

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("d192f9c9-e360-419f-8423-34ec02f5356b"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6006), "İstanbul" },
                    { new Guid("86f73beb-089e-4b56-a732-90bb16b438ac"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6399), "Yozgat" },
                    { new Guid("41b404ca-ce5c-45b7-9461-0fcb098d213f"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6395), "Trabzon" },
                    { new Guid("b4cc0b0e-012e-4d6b-bcd4-629b9c9bfb81"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6391), "Şanlıurfa" },
                    { new Guid("e7044d03-3e35-4e46-b31f-7c9fc43a9aae"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6389), "Sivas" },
                    { new Guid("83472766-3fc4-4237-8a1c-7d822752cfd8"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6388), "Sinop" },
                    { new Guid("867d1772-61f9-4465-9f96-0853f5dce39c"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6386), "Nevşehir" },
                    { new Guid("8b9dc007-5f10-442f-9734-14dbde735563"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6384), "Muğla" },
                    { new Guid("eb6a4462-1858-4235-950b-873f4da12823"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6382), "Kütahya" },
                    { new Guid("7ea60581-b9e9-4270-b748-34a7ccf12ff1"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6377), "Kastamonu" },
                    { new Guid("cabf2b04-f618-4877-b802-f4f5604d33fd"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6375), "Edirne" },
                    { new Guid("68d042d2-f910-4c3d-8f6b-bec381ea5322"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6393), "Tokat" },
                    { new Guid("72fc73ca-7040-48dd-8c4c-1d3c6a79f51a"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6372), "Çanakkale" },
                    { new Guid("4ef6cf64-84c5-4cfb-aacc-2724c9896372"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6370), "Bursa" },
                    { new Guid("a633e150-c810-4c33-b3e5-f4f1c40318ea"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6368), "Balıkesir" },
                    { new Guid("ef6a59b2-2de2-4809-8cf2-5c592c0635c9"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6366), "Artvin" },
                    { new Guid("18ff7f9c-f0cd-4c81-bbba-2d7be0902541"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6364), "Afyonkarahisar " },
                    { new Guid("9e709362-e663-4fc2-bd74-99eb396b0502"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6356), "Eskişehir" },
                    { new Guid("f2609f09-d1a6-456e-a8d8-95c57cc92639"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6354), "Adana" },
                    { new Guid("618fe19d-159c-4ba9-813f-d8a08dc78c26"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6353), "Antalya" },
                    { new Guid("d8f5ed6c-26dd-4015-96ff-a7100a253631"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6350), "İzmir" },
                    { new Guid("067efa49-a8b7-4617-92c2-5e2edf78011f"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6325), "Ankara" },
                    { new Guid("277828c0-463e-41a8-be3a-62c21e4fded7"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(6374), "Diyarbakır" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "TypeName" },
                values: new object[,]
                {
                    { new Guid("eec01196-45af-4d9a-b78e-72d28ddbb4ae"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(5180), "Ship Company " },
                    { new Guid("c692e129-9329-4cc5-8950-168b59d2b9da"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(5178), "RentACar Company " },
                    { new Guid("f4e50947-1f87-40d0-b961-73b4ffeabe3b"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(5170), "Transfer Company " },
                    { new Guid("17bce783-3037-42cb-95fd-e9e43b763e5c"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(5151), "Tour Company " },
                    { new Guid("3e3e477a-1006-4e72-90f4-1482486171eb"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(4833), "Hotel Company" },
                    { new Guid("7f0b46e8-e91e-4346-a6aa-afd13fd10d7e"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(5168), "AirPlane Company " }
                });

            migrationBuilder.InsertData(
                table: "RoomLocations",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("79621946-7fc2-4210-9539-627a1eb3a7fe"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(3759), "DNZ" },
                    { new Guid("7689af3d-f4de-4c39-a63d-b992d2e3a64f"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(4107), "GNL " },
                    { new Guid("f90ce176-d2a8-4495-830e-d47c3dc28d8c"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(4132), "PRK " }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("47363ba0-180a-4a8c-9be8-dc4d702ed134"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(2614), "SGL" },
                    { new Guid("315d392d-827b-4c53-9353-a0e9fd908a3f"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(3025), "DBL" },
                    { new Guid("25632fc1-11ad-49b2-b2fb-9797bb09e54f"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(3044), "TRP" },
                    { new Guid("40d9f203-8179-4076-8535-e468aa13fbbd"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(3047), "DBL+1" },
                    { new Guid("b06d1920-ef2c-4251-b9b0-32c7c587b467"), new DateTime(2020, 8, 3, 14, 53, 38, 362, DateTimeKind.Local).AddTicks(3059), "TRP+1" }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypes",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("e08d5daa-92c3-4bdf-9f85-43f5aab311e2"), new DateTime(2020, 8, 3, 14, 53, 38, 361, DateTimeKind.Local).AddTicks(1343), "Gemi" },
                    { new Guid("22029b66-cd88-4174-b278-57f1dc787fbe"), new DateTime(2020, 8, 3, 14, 53, 38, 359, DateTimeKind.Local).AddTicks(4721), "Araba" },
                    { new Guid("9cc0226b-3dc2-41d5-a3fe-6bb2ea61e289"), new DateTime(2020, 8, 3, 14, 53, 38, 361, DateTimeKind.Local).AddTicks(1276), "Uçak" },
                    { new Guid("087f6724-32c6-476b-bbff-5a38418641d6"), new DateTime(2020, 8, 3, 14, 53, 38, 361, DateTimeKind.Local).AddTicks(1347), "Otobüs" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_RoomId",
                table: "CartItems",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("067efa49-a8b7-4617-92c2-5e2edf78011f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("18ff7f9c-f0cd-4c81-bbba-2d7be0902541"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("277828c0-463e-41a8-be3a-62c21e4fded7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("41b404ca-ce5c-45b7-9461-0fcb098d213f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("4ef6cf64-84c5-4cfb-aacc-2724c9896372"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("618fe19d-159c-4ba9-813f-d8a08dc78c26"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("68d042d2-f910-4c3d-8f6b-bec381ea5322"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("72fc73ca-7040-48dd-8c4c-1d3c6a79f51a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("7ea60581-b9e9-4270-b748-34a7ccf12ff1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("83472766-3fc4-4237-8a1c-7d822752cfd8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("867d1772-61f9-4465-9f96-0853f5dce39c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("86f73beb-089e-4b56-a732-90bb16b438ac"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("8b9dc007-5f10-442f-9734-14dbde735563"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("9e709362-e663-4fc2-bd74-99eb396b0502"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("a633e150-c810-4c33-b3e5-f4f1c40318ea"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("b4cc0b0e-012e-4d6b-bcd4-629b9c9bfb81"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("cabf2b04-f618-4877-b802-f4f5604d33fd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d192f9c9-e360-419f-8423-34ec02f5356b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("d8f5ed6c-26dd-4015-96ff-a7100a253631"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("e7044d03-3e35-4e46-b31f-7c9fc43a9aae"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("eb6a4462-1858-4235-950b-873f4da12823"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("ef6a59b2-2de2-4809-8cf2-5c592c0635c9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("f2609f09-d1a6-456e-a8d8-95c57cc92639"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("17bce783-3037-42cb-95fd-e9e43b763e5c"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("3e3e477a-1006-4e72-90f4-1482486171eb"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("7f0b46e8-e91e-4346-a6aa-afd13fd10d7e"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("c692e129-9329-4cc5-8950-168b59d2b9da"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("eec01196-45af-4d9a-b78e-72d28ddbb4ae"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("f4e50947-1f87-40d0-b961-73b4ffeabe3b"));

            migrationBuilder.DeleteData(
                table: "RoomLocations",
                keyColumn: "Id",
                keyValue: new Guid("7689af3d-f4de-4c39-a63d-b992d2e3a64f"));

            migrationBuilder.DeleteData(
                table: "RoomLocations",
                keyColumn: "Id",
                keyValue: new Guid("79621946-7fc2-4210-9539-627a1eb3a7fe"));

            migrationBuilder.DeleteData(
                table: "RoomLocations",
                keyColumn: "Id",
                keyValue: new Guid("f90ce176-d2a8-4495-830e-d47c3dc28d8c"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("25632fc1-11ad-49b2-b2fb-9797bb09e54f"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("315d392d-827b-4c53-9353-a0e9fd908a3f"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("40d9f203-8179-4076-8535-e468aa13fbbd"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("47363ba0-180a-4a8c-9be8-dc4d702ed134"));

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: new Guid("b06d1920-ef2c-4251-b9b0-32c7c587b467"));

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: new Guid("087f6724-32c6-476b-bbff-5a38418641d6"));

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: new Guid("22029b66-cd88-4174-b278-57f1dc787fbe"));

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: new Guid("9cc0226b-3dc2-41d5-a3fe-6bb2ea61e289"));

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: new Guid("e08d5daa-92c3-4bdf-9f85-43f5aab311e2"));

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
        }
    }
}
