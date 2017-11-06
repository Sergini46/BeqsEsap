using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Convocatoria.Web.Front.Models
{
    public class EjemploPersonaModel : AuditoriaModel 
        
    {
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoMovil { get; set; }
        public string DireccionResidencia { get; set; }
        public List<ItemDropDown> Ciudades { get; set; }
        public int CiudadResidencia { get; set; }
        public List<ItemDropDown> Generos { get; set; }
        public int Genero { get; set; }
        public DateTime FechaExpedicion { get; set; }
        public List<ItemDropDown> Discapacidades { get; set; }
        public int Discapacidad { get; set; }
        public int CiudadExamanes { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int CiudadNacimiento { get; set; }
        public List<ItemDropDown> TiposIdentificacion { get; set; }
        public int TipoIdentificacion { get; set; }
        public string DiscapacidadComentario { get; set; }
        public int Id { get; set; }
    }
}