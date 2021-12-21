using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProgProje.Migrations
{
    public partial class PaperContext5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isRead",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "isRead",
                table: "Contacts");
        }
    }
}
