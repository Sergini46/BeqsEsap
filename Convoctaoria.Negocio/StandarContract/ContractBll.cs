using Convocatoria.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Convocatoria.Negocio.StandarContract
{
    public class ContractBll: IModel
    {
        public string Codigo { get; set; }
        public string Mensaje { get; set; }

    }
}
