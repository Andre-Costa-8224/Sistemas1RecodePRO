using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgenciaDeViagens.Migrations
{
    public partial class Viagens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    ID_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_nasc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.ID_Cliente);
                });

            migrationBuilder.CreateTable(
                name: "viagens",
                columns: table => new
                {
                    ID_Viagem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    destino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    passagem = table.Column<int>(type: "int", nullable: false),
                    ClienteID_Cliente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_viagens", x => x.ID_Viagem);
                    table.ForeignKey(
                        name: "FK_viagens_clientes_ClienteID_Cliente",
                        column: x => x.ClienteID_Cliente,
                        principalTable: "clientes",
                        principalColumn: "ID_Cliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_viagens_ClienteID_Cliente",
                table: "viagens",
                column: "ClienteID_Cliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "viagens");

            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}
