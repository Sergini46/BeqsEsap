using Convocatoria.Negocio.StandarContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convocatoria.Negocio.Dtos
{
    public class Laboral : ContractBll
    {
        public int Id { get; set; }
        public int IdHojaVida { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Empresa { get; set; }
        public string TelefonoEmpresa { get; set; }
        public string CargoEmpresa { get; set; }
        public string NitEmpresa { get; set; }
        public string DireccionEmpresa { get; set; }
        public int IdCiudadEmpresa { get; set; }
        public string CodigoError { get; set; }
        public string MensajeError { get; set; }

    }
}
