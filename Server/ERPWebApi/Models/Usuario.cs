using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class Usuario: Autor
    {
        [Column(TypeName = "Varchar(50)")]
        [Required]
        public string UserName { get; set; }
        [Column(TypeName = "Varchar(100)")]
        [Required]
        public string Nombres { get; set; }
        [Column(TypeName = "Varchar(100)")]
        public string Apellidos { get; set; }
        [Required]
        public int Estatus { get; set; }
        public int EmpresaId { get; set; }
        [Column(TypeName = "Varchar(255)")]
        public string Picture { get; set; }

        //Propiedades no Mappeada
        [NotMapped]
        public string Password { get; set; }

        //Propiedades de navegacion
        public virtual Empresa Empresa { get; set; }
    }
}
