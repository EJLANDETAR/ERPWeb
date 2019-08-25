using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERPWebApi.Migrations
{
    public partial class AddTablesLocalidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CuentaSolicitud",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreadoPor = table.Column<string>(type: "Varchar(50)", nullable: false),
                    FechaCreado = table.Column<DateTime>(nullable: false),
                    ModificadoPor = table.Column<string>(type: "Varchar(50)", nullable: true),
                    FechaModificado = table.Column<DateTime>(nullable: true),
                    EliminadoPor = table.Column<string>(type: "Varchar(50)", nullable: true),
                    FechaDeleted = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DireccionIP = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaSolicitud", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreadoPor = table.Column<string>(type: "Varchar(50)", nullable: false),
                    FechaCreado = table.Column<DateTime>(nullable: false),
                    ModificadoPor = table.Column<string>(type: "Varchar(50)", nullable: true),
                    FechaModificado = table.Column<DateTime>(nullable: true),
                    EliminadoPor = table.Column<string>(type: "Varchar(50)", nullable: true),
                    FechaDeleted = table.Column<DateTime>(nullable: true),
                    Nombre = table.Column<string>(type: "Varchar(100)", nullable: false),
                    EsActivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreadoPor = table.Column<string>(type: "Varchar(50)", nullable: false),
                    FechaCreado = table.Column<DateTime>(nullable: false),
                    ModificadoPor = table.Column<string>(type: "Varchar(50)", nullable: true),
                    FechaModificado = table.Column<DateTime>(nullable: true),
                    EliminadoPor = table.Column<string>(type: "Varchar(50)", nullable: true),
                    FechaDeleted = table.Column<DateTime>(nullable: true),
                    Nombre = table.Column<string>(type: "Varchar(100)", nullable: false),
                    PaisId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provincia_Pais_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Municipio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreadoPor = table.Column<string>(type: "Varchar(50)", nullable: false),
                    FechaCreado = table.Column<DateTime>(nullable: false),
                    ModificadoPor = table.Column<string>(type: "Varchar(50)", nullable: true),
                    FechaModificado = table.Column<DateTime>(nullable: true),
                    EliminadoPor = table.Column<string>(type: "Varchar(50)", nullable: true),
                    FechaDeleted = table.Column<DateTime>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    ProvinciaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipio_Provincia_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Municipio_ProvinciaId",
                table: "Municipio",
                column: "ProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Provincia_PaisId",
                table: "Provincia",
                column: "PaisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuentaSolicitud");

            migrationBuilder.DropTable(
                name: "Municipio");

            migrationBuilder.DropTable(
                name: "Provincia");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
