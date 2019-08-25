using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class Configuracion: Autor
    {

        [Column(TypeName = "Varchar(100)")]
        public string Clave { get; set; }
        [Column(TypeName = "Varchar(300)")]
        public string Valor { get; set; }
        [Column(TypeName = "Varchar(50)")]
        public string Grupo { get; set; }
    }
}
