using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto01.Infra.Data.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    IDEMPRESA = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOMEFANTASIA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    RAZAOSOCIAL = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.IDEMPRESA);
                });

            migrationBuilder.CreateTable(
                name: "FUNCIONARIO",
                columns: table => new
                {
                    IDFUNCIONARIO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    MATRICULA = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    DATAADMISSAO = table.Column<DateTime>(type: "date", nullable: false),
                    EMPRESAID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUNCIONARIO", x => x.IDFUNCIONARIO);
                    table.ForeignKey(
                        name: "FK_FUNCIONARIO_Empresa_EMPRESAID",
                        column: x => x.EMPRESAID,
                        principalTable: "Empresa",
                        principalColumn: "IDEMPRESA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_CNPJ",
                table: "Empresa",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FUNCIONARIO_CPF",
                table: "FUNCIONARIO",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FUNCIONARIO_EMPRESAID",
                table: "FUNCIONARIO",
                column: "EMPRESAID");

            migrationBuilder.CreateIndex(
                name: "IX_FUNCIONARIO_MATRICULA",
                table: "FUNCIONARIO",
                column: "MATRICULA",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FUNCIONARIO");

            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
