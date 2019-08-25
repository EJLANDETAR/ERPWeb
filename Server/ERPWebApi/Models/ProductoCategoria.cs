using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class ProductoCategoria: Autor
    {
        public int EmpresaId { get; set; }
        [Column(TypeName = "Varchar(100)")]
        [Required]
        public string Nombre { get; set; }
        [Column(TypeName = "Numeric(6, 2)")]
        public decimal TasaItbis { get; set; }
        public bool EsActivo { get; set; }

        //Propiedades de navegacion
        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
