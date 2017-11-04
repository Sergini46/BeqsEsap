using Convocatoria.Negocio.StandarContract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Convocatoria.Negocio.Dtos
{
    public class DatosAspirante: ContractBll
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NoDocumento { get; set; }
        //y Aca mas datos del tipo complejo..
    }
}
