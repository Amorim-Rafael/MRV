using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MRV.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Suburb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Accepted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leads", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "Id", "Accepted", "Category", "DateCreated", "Description", "Email", "FirstName", "FullName", "PhoneNumber", "Price", "Suburb" },
                values: new object[,]
                {
                    { 1, false, "Fantasia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caverna do Dragão", "mestre@magos.com", "Mestre", "Mestre do Magos", "99 999999999", 100m, "A Noite sem Amanhã" },
                    { 2, false, "Fantasia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caverna do Dragão", "hank@ded.com", "Hank", "Hank Arqueiro", "11 111111111", 675.00m, "O Olho do Observador" },
                    { 3, false, "Fantasia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caverna do Dragão", "eric@ded.com", "Eric", "Eric Cavaleiro", "22 222222222", 720.00m, "O Salão dos Ossos" },
                    { 4, false, "Fantasia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caverna do Dragão", "diana@ded.com", "Diana", "Diana Acrobata", "33 333333333", 320m, "O Vale dos Unicórnios" },
                    { 5, false, "Fantasia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caverna do Dragão", "sheila@ded.com", "Sheila", "Sheila Ladina", "44 444444444", 500m, "Em Busca do Mestre dos Magos" },
                    { 6, false, "Fantasia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caverna do Dragão", "bobby@ded.com", "Bobby", "Bobby Barbaro", "55 555555555", 450m, "A Bela e a Fera do Pântano" },
                    { 7, false, "Fantasia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caverna do Dragão", "uni@ded.com", "Uni", "Uni Unicornio", "66 666666666", 450.90m, "Prisão sem Muros" },
                    { 8, false, "Fantasia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caverna do Dragão", "presto@ded.com", "Presto", "Presto Mago", "77 777777777", 562.50m, "Servo do Mal" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leads");
        }
    }
}
