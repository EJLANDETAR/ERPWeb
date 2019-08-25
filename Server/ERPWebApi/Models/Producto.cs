using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class Producto: Autor
    {
        public int EmpresaId { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [Required, MinLength(4)]
        public string Codigo { get; set; }
        [Column(TypeName = "Varchar(150)")]
        [Required, MinLength(10)]
        public string Nombre { get; set; }
        public int CategoriaId { get; set; }
        [Column(TypeName = "Numeric(18, 2)")]
        public decimal PrecioVenta { get; set; }
        [Column(TypeName = "Numeric(18, 2)")]
        public decimal PrecioMinimo { get; set; }
        [Column(TypeName = "Numeric(18, 2)")]
        public decimal? CostoUCompra { get; set; }
        public bool EsActivo { get; set; }
        [Column(TypeName = "Varchar(255)")]
        public string Picture { get; set; }

        //Propiedades de navegacion
        public virtual Empresa Empresa { get; set; }
        [ForeignKey("CategoriaId")]
        public virtual ProductoCategoria Categoria { get; set; }
    }
}
