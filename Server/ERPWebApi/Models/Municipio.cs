using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class Municipio: Autor
    {
        public string Nombre { get; set; }
        public int ProvinciaId { get; set; }

        //Propiedades de nageacion
        public virtual Provincia Provincia { get; set; }
    }
}
