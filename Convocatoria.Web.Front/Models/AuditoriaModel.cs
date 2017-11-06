using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Convocatoria.Web.Front.Models
{
    public class AuditoriaModel 
    {
        public DateTime FechaCreacion { get; set; }
        public int Usuario { get; set; }
        public string IP { get; set; }
        public string Navegador { get; set; }
        public string SistemaOperativo { get; set; }
        public string Accion { get; set; }
        public int Eliminado { get; set; }
        public List<MensajeModel> Mensajes { get; set; }
    }
}