using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class CuentaSolicitud: Autor
    {
        public string Email { get; set; }
        public string DireccionIP { get; set; }
        public int? EmpresaId { get; set; }
    }
}
