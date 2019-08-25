using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class Venta: Autor
    {
        public int EmpresaId { get; set; }
        public long Numero { get; set; }
        public DateTime Fecha { get; set; }
        [Column(TypeName = "Numeric(18, 2)")]
        public decimal SubTotal { get; set; }
        [Column(TypeName = "Numeric(18, 2)")]
        public decimal TotalItbis { get; set; }
        [Column(TypeName = "Numeric(18, 2)")]
        public decimal Total { get; set; }
        [Column(TypeName = "Varchar(200)")]
        public string Comentario { get; set; }
        public DateTime? FechaAnulado { get; set; }
        [Column(TypeName = "Varchar(20)")]
        public string NCF { get; set; }

        //Propiedades de Navegacion
        public virtual Empresa Empresa { get; set; }
        public virtual VentaDetalle Items { get; set; }
    }
}
