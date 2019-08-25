using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class SecuenciaNCF: Autor
    {
        [Required]
        public int Codigo { get; set; }
        public int EmpresaId { get; set; }
        public int NumeroMaximo { get; set; }
        public int NumeroAnterior { get; set; }
        public int PuntoReorden { get; set; }

        //Propiedades de Navegacion
        public virtual Empresa Empresa { get; set; }
        [NotMapped]
        public virtual TipoNCF TipoNCF { get; set; }
    }
}
