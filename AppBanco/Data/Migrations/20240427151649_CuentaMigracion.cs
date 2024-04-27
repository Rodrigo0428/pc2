using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace zefffood.Data.Migrations
{
    public partial class CuentaBancariaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_cuenta_bancaria",
                columns: table => new
                {
                    NumeroCuenta = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreTitular = table.Column<string>(type: "text", nullable: true),
                    TipoCuenta = table.Column<string>(type: "text", nullable: true),
                    Saldo = table.Column<decimal>(type: "numeric", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "text", nullable: true),
                    Contraseña = table.Column<string>(type: "text", nullable: true) // Consider using a secure hashing algorithm for password storage
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_cuenta_bancaria", x => x.NumeroCuenta);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "t_cuenta_bancaria");
        }
    }
}
