using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ESAP.Models;

namespace ESAP.Controllers
{
    public class ConfiguracionConcursoController : Controller
    {
        ConfiguracionConcursoModel model = new ConfiguracionConcursoModel();
        // GET: ConfiguracionConcurso
        public ActionResult Index(int? vista)
        {
            model.Vista = Convert.ToInt32(vista);
            return View("ConfiguracionConcurso", model);
        }
    }
}