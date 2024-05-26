using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace T2_DelCastillo_JoseMiguel.Migrations
{
    /// <inheritdoc />
    public partial class agregarcategoriaABD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Distribuidor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nombreDistribuidor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    razonSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<int>(type: "int", nullable: false),
                    anioInicioOperacion = table.Column<int>(type: "int", nullable: false),
                    contacto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribuidor", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Distribuidor");
        }
    }
}
