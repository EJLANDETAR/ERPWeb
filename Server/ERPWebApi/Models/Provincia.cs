using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class Provincia: Autor
    {
        [Column(TypeName = "Varchar(100)")]
        [Required, MinLength(4)]
        public string Nombre { get; set; }
        public int PaisId { get; set; }

        //Propiedades de Navegacion
        public virtual Pais Pais { get; set; }
        public virtual ICollection<Municipio> Municipios { get; set; }
    }
}
