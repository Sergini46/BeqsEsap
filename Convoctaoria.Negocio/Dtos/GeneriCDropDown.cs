using Convocatoria.Negocio.StandarContract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Convocatoria.Negocio.Dtos
{
    public class GenericDropDown 
    {
        public int Id { get; set; }
        public string Valor { get; set; }
    }
    public class ListGenericDropDown : ContractBll
    {
        public List<GenericDropDown> Lista { get; set; }
    }
}
