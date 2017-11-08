using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convocatoria.Negocio.Dtos
{
    public class Auditoria
    {
        public string  Accion { get; set; }
        public bool Eliminado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string IP { get; set; }
        public string Navegador { get; set; }
        public string SistemaOperativo { get; set; }
        public int Usuario { get; set; }
    }
}
