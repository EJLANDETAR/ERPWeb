using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class VentaDetalle: Autor
    {
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        [Column(TypeName = "Numeric(18, 2)")]
        public decimal Cantidad { get; set; }
        [Column(TypeName = "Numeric(18, 2)")]
        public decimal Precio { get; set; }
        [Column(TypeName = "Numeric(6, 2)")]
        public decimal TasaItbis { get; set; }
        [Column(TypeName = "Numeric(18, 2)")]
        public decimal Itbis { get; set; }
        [Column(TypeName = "Numeric(18, 2)")]
        public decimal Total { get; set; }

        //Propiedades de navegacion
        public virtual Venta Venta { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
