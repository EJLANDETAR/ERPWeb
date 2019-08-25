using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class TipoNCF: Autor
    {
        public int Codigo { get; set; }
        [Column(TypeName = "Varchar(100)")]
        public string Nombre { get; set; }
        [Column(TypeName = "Varchar(3)")]
        [Required, MinLength(3)]
        public string Prefijo { get; set; }
        public bool EsVenta { get; set; }
        public bool EsCompra { get; set; }

        //Propiedades de navegacion
        [NotMapped]
        public virtual SecuenciaNCF Secuencia { get; set; }
    }
}
