using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AppBanco.Data.Migrations
{
    /// <inheritdoc />
    public partial class CuentaBancariaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_cuenta_bancaria",
                columns: table => new
                {
                    NumeroCuenta = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreTitular = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TipoCuenta = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Saldo = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "text", nullable: false),
                    Contraseña = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_cuenta_bancaria", x => x.NumeroCuenta);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_cuenta_bancaria");
        }
    }
}
