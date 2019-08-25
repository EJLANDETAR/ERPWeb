using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPWebApi.Models
{
    public class Autor
    {
        public int Id { get; set; }
        [Column(TypeName = "Varchar(50)")]
        [Required, MinLength(2)]
        public string CreadoPor { get; set; }
        public DateTime FechaCreado { get; set; }
        [Column(TypeName = "Varchar(50)")]
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificado { get; set; }
        [Column(TypeName = "Varchar(50)")]
        public string EliminadoPor { get; set; }
        public DateTime? FechaDeleted { get; set; }

        //Propiedad privada
        private string Usuario = "";
        private HttpContext _httpContext = null;

        private void GetUsuarioFromIdentity()
        {
            try
            {
                if (_httpContext == null) Usuario = "SYSTEM";
                //var identity = _httpContext.User.Identity as identity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        void SetAutor(int valorId, HttpContext httpContext = null)
        {
            try
            {
                _httpContext = httpContext;
                GetUsuarioFromIdentity();

                var feActual = DateTime.UtcNow;
                if (valorId <= 0)
                {
                    CreadoPor = Usuario;
                    FechaCreado = feActual;
                }
                else
                {
                    ModificadoPor = Usuario;
                    FechaModificado = feActual;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        void SetDeleted(HttpContext httpContext)
        {
            try
            {
                _httpContext = httpContext;
                GetUsuarioFromIdentity();
                FechaDeleted = DateTime.UtcNow;
                EliminadoPor = Usuario;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
