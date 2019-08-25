using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class VentaAnulada: Autor
    {
        public int VentaId { get; set; }
        public int Motivo { get; set; }
        public DateTime Fecha { get; set; }
        [Column(TypeName = "Varchar(200)")]
        [Required, MinLength(10)]
        public string Comentario { get; set; }

        //Propiedades de navegacion
        public virtual Venta Venta { get; set; }
    }
}
