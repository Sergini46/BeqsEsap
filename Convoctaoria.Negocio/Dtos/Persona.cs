using Convocatoria.Negocio.StandarContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convocatoria.Negocio.Dtos
{
    public class Persona: ContractBll
    {
        public int IdPersona { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string TelefonoFijoContato { get; set; }
        public string TelefonoMovilContacto { get; set; }
        public string DireccionResidencia { get; set; }
        public int CiudadResidencia { get; set; }
        public int Genero { get; set; }
        public DateTime FechaExpedicionDocumento { get; set; }
        public int TipoDiscapacidad { get; set; }
        public string DiscapacidadComentario { get; set; }
        public int CiudadExamenes { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int CiudadNacimiento { get; set; }
        public int TipoIdentificacion { get; set; }

    }
}
