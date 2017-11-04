using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Convocatoria.Web.Front.Models
{
    public class IndexModel
    {
        public List<GeneriDropDownModel> ListaPaises {get; set;} 
    }
    public class GeneriDropDownModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}