using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class FuncionesPorRol: Autor
    {
        public int FuncionId { get; set; }
        public int RolId { get; set; }
        public bool EsActivo { get; set; }

        //Propiedades de Navegacion
        public virtual Funcion Funcion { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
