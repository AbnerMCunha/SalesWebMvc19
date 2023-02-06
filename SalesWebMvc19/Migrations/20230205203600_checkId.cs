using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc19.Migrations
{
    public partial class checkId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeparmentID",
                table: "Seller",
                newName: "DeparmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeparmentId",
                table: "Seller",
                newName: "DeparmentID");
        }
    }
}
