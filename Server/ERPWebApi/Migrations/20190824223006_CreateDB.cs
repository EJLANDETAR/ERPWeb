using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERPWebApi.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
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
                    Email = table.Column<string>(type: "Varchar(50)", nullable: true),
                    Nombre = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Direccion = table.Column<string>(type: "Varchar(150)", nullable: true),
                    Telefono1 = table.Column<string>(type: "Varchar(20)", nullable: true),
                    Telefono2 = table.Column<string>(type: "Varchar(20)", nullable: true),
                    Logo = table.Column<string>(type: "Varchar(255)", nullable: true),
                    Estatus = table.Column<int>(nullable: false),
                    DNI = table.Column<string>(type: "Varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entidad",
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
                    DNI = table.Column<string>(type: "Varchar(20)", nullable: true),
                    Nombres = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Apellidos = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Email = table.Column<string>(type: "Varchar(60)", nullable: true),
                    Direccion = table.Column<string>(type: "Varchar(200)", nullable: true),
                    Telefono1 = table.Column<string>(type: "Varchar(20)", nullable: true),
                    Telefono2 = table.Column<string>(type: "Varchar(20)", nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    Picture = table.Column<string>(type: "Varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entidad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entidad_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
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
                    UserName = table.Column<string>(type: "Varchar(50)", nullable: false),
                    Nombres = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Apellidos = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Estatus = table.Column<int>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false),
                    Picture = table.Column<string>(type: "Varchar(255)", nullable: true),
                    EntidadId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_Entidad_EntidadId",
                        column: x => x.EntidadId,
                        principalTable: "Entidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entidad_EmpresaId",
                table: "Entidad",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_EmpresaId",
                table: "Usuario",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_EntidadId",
                table: "Usuario",
                column: "EntidadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Entidad");

            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
