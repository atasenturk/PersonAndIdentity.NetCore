using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp5.Migrations
{
    public partial class SeedPeopleAndIdentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Address", "Name", "Surname" },
                values: new object[] { 1, "Eskisehir", "Ata", "Senturk" });

            migrationBuilder.InsertData(
                table: "Identities",
                columns: new[] { "Id", "MaritalStat", "PersonId", "TCNo", "VolNum" },
                values: new object[] { 1, "Single", 1, "11036786912", "2125" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Identities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
