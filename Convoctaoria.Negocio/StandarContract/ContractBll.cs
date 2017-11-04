using Convocatoria.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Convocatoria.Negocio.StandarContract
{
    public class ContractBll: IModel
    {
        public string CodigoError { get; set; }
        public string MensajeError { get; set; }
    }
}
