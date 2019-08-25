using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class Entidad: Autor
    {
        [Column(TypeName = "Varchar(20)")]
        public string DNI { get; set; }
        [Column(TypeName = "Varchar(100)")]
        public string Nombres { get; set; }
        [Column(TypeName = "Varchar(100)")]
        public string Apellidos { get; set; }
        [Column(TypeName = "Varchar(60)")]
        public string Email { get; set; }
        [Column(TypeName = "Varchar(200)")]
        public string Direccion { get; set; }
        [Column(TypeName = "Varchar(20)")]
        public string Telefono1 { get; set; }
        [Column(TypeName = "Varchar(20)")]
        public string Telefono2 { get; set; }
        public int EmpresaId { get; set; }
        [Column(TypeName = "Varchar(255)")]
        public string Picture { get; set; }

        //Propiedades de navegacion
        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
