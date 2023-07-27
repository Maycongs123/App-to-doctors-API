using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorAPI.Migrations
{
    /// <inheritdoc />
    public partial class criacaoDeNovasColunas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Administracao",
                table: "Medicamentos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dose",
                table: "Medicamentos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreparoDiluicao",
                table: "Medicamentos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsoGestacao",
                table: "Medicamentos",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Administracao",
                table: "Medicamentos");

            migrationBuilder.DropColumn(
                name: "Dose",
                table: "Medicamentos");

            migrationBuilder.DropColumn(
                name: "PreparoDiluicao",
                table: "Medicamentos");

            migrationBuilder.DropColumn(
                name: "UsoGestacao",
                table: "Medicamentos");
        }
    }
}
