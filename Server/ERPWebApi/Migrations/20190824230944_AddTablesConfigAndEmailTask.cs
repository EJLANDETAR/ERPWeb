using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERPWebApi.Migrations
{
    public partial class AddTablesConfigAndEmailTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Empresa",
                type: "Varchar(150)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "Empresa",
                type: "Varchar(150)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Linkedin",
                table: "Empresa",
                type: "Varchar(150)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "Empresa",
                type: "Varchar(150)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WebSite",
                table: "Empresa",
                type: "Varchar(150)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Youtube",
                table: "Empresa",
                type: "Varchar(150)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Configuracion",
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
                    Clave = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Valor = table.Column<string>(type: "Varchar(300)", nullable: true),
                    Grupo = table.Column<string>(type: "Varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuracion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailTask",
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
                    Asunto = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Mensaje = table.Column<string>(type: "Varchar(255)", nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Para = table.Column<string>(type: "Varchar(200)", nullable: true),
                    FechaEnviado = table.Column<DateTime>(nullable: true),
                    FechaFallo = table.Column<DateTime>(nullable: true),
                    ResourceAdjunto = table.Column<string>(type: "Varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTask", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuracion");

            migrationBuilder.DropTable(
                name: "EmailTask");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "Linkedin",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "WebSite",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "Youtube",
                table: "Empresa");
        }
    }
}
