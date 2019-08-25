using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class Funcion: Autor
    {
        public string Codigo { get; set; }
        public bool EsGold { get; set; }
        public bool EsBasico { get; set; }
        public bool EsPlatinium { get; set; }
        public bool EsActivo { get; set; }
    }
}
