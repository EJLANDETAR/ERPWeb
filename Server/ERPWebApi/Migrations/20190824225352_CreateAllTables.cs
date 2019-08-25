using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERPWebApi.Migrations
{
    public partial class CreateAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entidad_Empresa_EmpresaId",
                table: "Entidad");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Empresa_EmpresaId",
                table: "Usuario");

            migrationBuilder.CreateTable(
                name: "ProductoCategoria",
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
                    EmpresaId = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(type: "Varchar(100)", nullable: false),
                    TasaItbis = table.Column<decimal>(type: "Numeric(6, 2)", nullable: false),
                    EsActivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoCategoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductoCategoria_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
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
                    EmpresaId = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(type: "Varchar(50)", nullable: false),
                    EsActivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rol_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SecuenciaNCF",
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
                    Codigo = table.Column<int>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false),
                    NumeroMaximo = table.Column<int>(nullable: false),
                    NumeroAnterior = table.Column<int>(nullable: false),
                    PuntoReorden = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecuenciaNCF", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecuenciaNCF_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipoNCF",
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
                    Codigo = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Prefijo = table.Column<string>(type: "Varchar(3)", nullable: false),
                    EsVenta = table.Column<bool>(nullable: false),
                    EsCompra = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoNCF", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
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
                    EmpresaId = table.Column<int>(nullable: false),
                    Numero = table.Column<long>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    SubTotal = table.Column<decimal>(type: "Numeric(18, 2)", nullable: false),
                    TotalItbis = table.Column<decimal>(type: "Numeric(18, 2)", nullable: false),
                    Total = table.Column<decimal>(type: "Numeric(18, 2)", nullable: false),
                    Comentario = table.Column<string>(type: "Varchar(200)", nullable: true),
                    FechaAnulado = table.Column<DateTime>(nullable: true),
                    NCF = table.Column<string>(type: "Varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venta_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
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
                    EmpresaId = table.Column<int>(nullable: false),
                    Codigo = table.Column<string>(type: "Varchar(50)", nullable: false),
                    Nombre = table.Column<string>(type: "Varchar(150)", nullable: false),
                    CategoriaId = table.Column<int>(nullable: false),
                    PrecioVenta = table.Column<decimal>(type: "Numeric(18, 2)", nullable: false),
                    PrecioMinimo = table.Column<decimal>(type: "Numeric(18, 2)", nullable: false),
                    CostoUCompra = table.Column<decimal>(type: "Numeric(18, 2)", nullable: true),
                    EsActivo = table.Column<bool>(nullable: false),
                    Picture = table.Column<string>(type: "Varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Producto_ProductoCategoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "ProductoCategoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Producto_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Funcion",
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
                    Codigo = table.Column<string>(nullable: true),
                    EsGold = table.Column<bool>(nullable: false),
                    EsBasico = table.Column<bool>(nullable: false),
                    EsPlatinium = table.Column<bool>(nullable: false),
                    EsActivo = table.Column<bool>(nullable: false),
                    RolId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcion_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VentaAnulada",
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
                    VentaId = table.Column<int>(nullable: false),
                    Motivo = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Comentario = table.Column<string>(type: "Varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentaAnulada", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VentaAnulada_Venta_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Venta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VentaDetalle",
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
                    VentaId = table.Column<int>(nullable: false),
                    ProductoId = table.Column<int>(nullable: false),
                    Cantidad = table.Column<decimal>(type: "Numeric(18, 2)", nullable: false),
                    Precio = table.Column<decimal>(type: "Numeric(18, 2)", nullable: false),
                    TasaItbis = table.Column<decimal>(type: "Numeric(6, 2)", nullable: false),
                    Itbis = table.Column<decimal>(type: "Numeric(18, 2)", nullable: false),
                    Total = table.Column<decimal>(type: "Numeric(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentaDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VentaDetalle_Producto_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VentaDetalle_Venta_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Venta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FuncionesPorRols",
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
                    FuncionId = table.Column<int>(nullable: false),
                    RolId = table.Column<int>(nullable: false),
                    EsActivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncionesPorRols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FuncionesPorRols_Funcion_FuncionId",
                        column: x => x.FuncionId,
                        principalTable: "Funcion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FuncionesPorRols_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcion_RolId",
                table: "Funcion",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_FuncionesPorRols_FuncionId",
                table: "FuncionesPorRols",
                column: "FuncionId");

            migrationBuilder.CreateIndex(
                name: "IX_FuncionesPorRols_RolId",
                table: "FuncionesPorRols",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CategoriaId",
                table: "Producto",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_EmpresaId",
                table: "Producto",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoCategoria_EmpresaId",
                table: "ProductoCategoria",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rol_EmpresaId",
                table: "Rol",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_SecuenciaNCF_EmpresaId",
                table: "SecuenciaNCF",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_EmpresaId",
                table: "Venta",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_VentaAnulada_VentaId",
                table: "VentaAnulada",
                column: "VentaId");

            migrationBuilder.CreateIndex(
                name: "IX_VentaDetalle_ProductoId",
                table: "VentaDetalle",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_VentaDetalle_VentaId",
                table: "VentaDetalle",
                column: "VentaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Entidad_Empresa_EmpresaId",
                table: "Entidad",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Empresa_EmpresaId",
                table: "Usuario",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entidad_Empresa_EmpresaId",
                table: "Entidad");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Empresa_EmpresaId",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "FuncionesPorRols");

            migrationBuilder.DropTable(
                name: "SecuenciaNCF");

            migrationBuilder.DropTable(
                name: "TipoNCF");

            migrationBuilder.DropTable(
                name: "VentaAnulada");

            migrationBuilder.DropTable(
                name: "VentaDetalle");

            migrationBuilder.DropTable(
                name: "Funcion");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "ProductoCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Entidad_Empresa_EmpresaId",
                table: "Entidad",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Empresa_EmpresaId",
                table: "Usuario",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
