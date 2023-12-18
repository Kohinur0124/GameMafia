using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameMafia.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Markets",
                columns: table => new
                {
                    MarketId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markets", x => x.MarketId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Summ = table.Column<int>(type: "integer", nullable: false),
                    Security = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "CountRole",
                columns: table => new
                {
                    CountRoleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CountPlayer = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    CountRoles = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountRole", x => x.CountRoleId);
                    table.ForeignKey(
                        name: "FK_CountRole_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: true),
                    DeathDate = table.Column<int>(type: "integer", nullable: true),
                    Heal = table.Column<int>(type: "integer", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    CountPlayersStart = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Player_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId");
                    table.ForeignKey(
                        name: "FK_Player_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PlayerId = table.Column<int>(type: "integer", nullable: false),
                    MessagePlayer = table.Column<string>(type: "text", nullable: false),
                    DTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Messages_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Markets",
                columns: new[] { "MarketId", "Name", "Price" },
                values: new object[] { 1, "Himoya", 100 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "kechasi uxlaydi va kunduzi yovuz qahramonlarni aniqlashga va ularni yo`q qilishga harakat qiladi (ovoz berish o`tkaziladi)", "Tinch aholi", 0 },
                    { 2, "favqulodda ishchi. Kechasi u o`yinchilardan biriga kelib, hayotini saqlab qolishi mumkin. Har bir o'yinda bir marta o'zini qutqara oladi", "Shifokor", 0 },
                    { 3, "mafiya rahbari. Kechasi butun mafiya oilasi bilan birgalikda u jabrlanuvchini tanlaydi va hukmni ijro etadi", "Don", 1 },
                    { 4, "tartib qo'riqchisi. Kechasi u o'yinchilardan birining rolini bilishi yoki uni o'ldirishi mumkin.", "Kommisar", 0 },
                    { 5, "mafiya oilasi a'zosi. Kechasi oilasi bilan birga qurbonni tanlaydi. Agar eskisi o'ldirilgan bo'lsa, yangi Don bo'lishi mumkin", "Mafia", 1 },
                    { 6, "faqat kunduzgi o'lim ovozini yutib, g'alaba qozonadigan neytral rol (ha, siz kunduzi o'lishingiz kerak)", "Suisid", 2 }
                });

            migrationBuilder.InsertData(
                table: "CountRole",
                columns: new[] { "CountRoleId", "CountPlayer", "CountRoles", "RoleId" },
                values: new object[,]
                {
                    { 1, 4, 2, 1 },
                    { 2, 4, 1, 2 },
                    { 3, 4, 1, 3 },
                    { 4, 5, 3, 1 },
                    { 5, 5, 1, 2 },
                    { 6, 5, 1, 3 },
                    { 7, 6, 3, 1 },
                    { 8, 6, 1, 2 },
                    { 9, 6, 1, 3 },
                    { 10, 6, 1, 4 },
                    { 11, 7, 4, 1 },
                    { 12, 7, 1, 2 },
                    { 13, 7, 1, 3 },
                    { 14, 7, 1, 4 },
                    { 15, 8, 4, 1 },
                    { 16, 8, 1, 2 },
                    { 17, 8, 1, 3 },
                    { 18, 8, 1, 4 },
                    { 19, 8, 1, 5 },
                    { 20, 9, 4, 1 },
                    { 21, 9, 1, 2 },
                    { 22, 9, 1, 3 },
                    { 23, 9, 1, 4 },
                    { 24, 9, 1, 5 },
                    { 25, 9, 1, 6 },
                    { 26, 10, 4, 1 },
                    { 27, 10, 1, 2 },
                    { 28, 10, 1, 3 },
                    { 29, 10, 1, 4 },
                    { 30, 10, 2, 5 },
                    { 31, 10, 1, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountRole_RoleId",
                table: "CountRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_PlayerId",
                table: "Messages",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_RoleId",
                table: "Player",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_UserId",
                table: "Player",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountRole");

            migrationBuilder.DropTable(
                name: "Markets");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
