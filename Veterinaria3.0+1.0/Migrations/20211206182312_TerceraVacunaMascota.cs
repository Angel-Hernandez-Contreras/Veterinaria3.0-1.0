using Microsoft.EntityFrameworkCore.Migrations;

namespace Veterinaria3._0_1._0.Migrations
{
    public partial class TerceraVacunaMascota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Vacunas",
                table: "Mascota",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vacunas",
                table: "Mascota");
        }
    }
}
