using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class Empresa: Autor
    {
        [Column(TypeName = "Varchar(50)")]
        public string Email { get; set; }
        [Column(TypeName = "Varchar(100)")]
        public string Nombre { get; set; }
        [Column(TypeName = "Varchar(150)")]
        public string Direccion { get; set; }
        [Column(TypeName = "Varchar(20)")]
        public string Telefono1 { get; set; }
        [Column(TypeName = "Varchar(20)")]
        public string Telefono2 { get; set; }
        [Column(TypeName = "Varchar(255)")]
        public string Logo { get; set; }
        public int Estatus { get; set; }
        [Column(TypeName = "Varchar(20)")]
        public string DNI { get; set; }
        [Column(TypeName = "Varchar(150)")]
        public string WebSite { get; set; }
        [Column(TypeName = "Varchar(150)")]
        public string Facebook { get; set; }
        [Column(TypeName = "Varchar(150)")]
        public string Instagram { get; set; }
        [Column(TypeName = "Varchar(150)")]
        public string Twitter { get; set; }
        [Column(TypeName = "Varchar(150)")]
        public string Youtube { get; set; }
        [Column(TypeName = "Varchar(150)")]
        public string Linkedin { get; set; }

        //Propiedades de navegacion
        public virtual ICollection<Entidad> Entidades { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<Rol> Roles { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }
    }
}
