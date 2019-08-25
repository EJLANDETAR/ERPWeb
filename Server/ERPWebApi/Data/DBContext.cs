using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ERPWebApi.Models
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<ERPWebApi.Models.Empresa> Empresa { get; set; }
        public DbSet<ERPWebApi.Models.Rol> Rol { get; set; }
        public DbSet<ERPWebApi.Models.Funcion> Funcion { get; set; }
        public DbSet<ERPWebApi.Models.FuncionesPorRol> FuncionesPorRols { get; set; }
        public DbSet<ERPWebApi.Models.Usuario> Usuario { get; set; }
        public DbSet<ERPWebApi.Models.Producto> Producto { get; set; }
        public DbSet<ERPWebApi.Models.ProductoCategoria> ProductoCategoria { get; set; }
        public DbSet<ERPWebApi.Models.SecuenciaNCF> SecuenciaNCF { get; set; }
        public DbSet<ERPWebApi.Models.TipoNCF> TipoNCF { get; set; }
        public DbSet<ERPWebApi.Models.Venta> Venta { get; set; }
        public DbSet<ERPWebApi.Models.VentaDetalle> VentaDetalle { get; set; }
        public DbSet<ERPWebApi.Models.VentaAnulada> VentaAnulada { get; set; }
        public DbSet<ERPWebApi.Models.Entidad> Entidad { get; set; }
        public DbSet<ERPWebApi.Models.EmailTask> EmailTask { get; set; }
        public DbSet<ERPWebApi.Models.Configuracion> Configuracion { get; set; }
        public DbSet<ERPWebApi.Models.Pais> Pais { get; set; }
        public DbSet<ERPWebApi.Models.Provincia> Provincia { get; set; }
        public DbSet<ERPWebApi.Models.Municipio> Municipio { get; set; }
        public DbSet<ERPWebApi.Models.CuentaSolicitud> CuentaSolicitud { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);

            
        }

    }
}
