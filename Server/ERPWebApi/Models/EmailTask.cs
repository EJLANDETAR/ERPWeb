using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class EmailTask: Autor
    {
        [Column(TypeName = "Varchar(100)")]
        public string Asunto { get; set; }
        [Column(TypeName = "Varchar(255)")]
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; }
        [Column(TypeName = "Varchar(200)")]
        public string Para { get; set; }
        public DateTime? FechaEnviado { get; set; }
        public DateTime? FechaFallo { get; set; }
        [Column(TypeName = "Varchar(255)")]
        public string ResourceAdjunto { get; set; }
    }
}
