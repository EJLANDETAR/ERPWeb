using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class Rol: Autor
    {
        public int EmpresaId { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [Required, MinLength(4)]
        public string Nombre { get; set; }
        public bool EsActivo { get; set; }

        //Propiedades de navegacion
        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<Funcion> Funciones { get; set; }
    }
}
