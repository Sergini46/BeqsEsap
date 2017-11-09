using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Convocatoria.Web.Front.Models
{
    public class ExperienciaDocenteModel: AuditoriaModel
    {
        public int Id { get; set; }

        public int IdHojaVida { get; set; }

        public DateTime? FechaIngreso { get; set; }

        public int IdEntidadEducativa { get; set; }

        public int IdTipoVinculacion { get; set; }

        public int? HorasMensuales { get; set; }

        public string TelefonoEntidadEducativa { get; set; }

        public string DireccionEntidadEducativa { get; set; }

        public int IdCiudadEntidadEducativa { get; set; }

        public DateTime? FechaTerminacion { get; set; }
    }
}