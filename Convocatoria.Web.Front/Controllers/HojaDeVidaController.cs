using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Convocatoria.Web.Front.Models;
using Convocatoria.Negocio;
using Convocatoria.Datos.Entities;

namespace Convocatoria.Web.Front.Controllers
{
    public class HojaDeVidaController : Controller
    {
        // GET: HojaDeVida
        Microservicios servicios = new Microservicios();
        HojaDeVidaModel modelo = new HojaDeVidaModel();
        IndexModel model;

        public ActionResult Index(int? vista)
        {
            /*Codigo de ejemplo Sergio Gracia */
            //model = new IndexModel();
            //Negocio.Dtos.ListGenericDropDown Datos = (Negocio.Dtos.ListGenericDropDown)new Negocio.Entidades.Comun().GetPaises();
            //if (Datos.CodigoError == "200")
            //{
            //    foreach (var item in Datos.Lista)
            //        model.ListaPaises.Add(new GeneriDropDownModel() { Id = item.Id, Nombre = item.Valor });
            //}
            //else
            //{
            //    //Administrar el error para mostrar en presentación , pendiente SAGC
            //}
            ////return View(model); se comenta por que ya hay un return view y no afectar el trabajo de yuly

            ////ejemplo de cargar datos de una persona con el ID = 1

            //Negocio.Dtos.DatosAspirante Aspirante = (Negocio.Dtos.DatosAspirante)new Negocio.Entidades.Aspirante().ConsultarAspirante(1);
            //if (Aspirante.CodigoError == "200")
            //{
            //    modelo.Apellido = Aspirante.Apellido;
            //    modelo.Identificacion = Aspirante.NoDocumento;
            //    modelo.Nombre = Aspirante.Nombre;
            //}
            //else
            //{
            //    //Administrar el error para mostrar en presentación , pendiente SAGC
            //}

            /*FIN Codigo de ejemplo Sergio Gracia */

            modelo.Vista = Convert.ToInt32(vista);

            if (modelo.Vista == 1)// carga inicial de educacion formal
            {
                CargaInicialEF();
            }
            else if (modelo.Vista == 0)// carga inicial de datos personales
            {
                CargaInicialDP();
            }
            else if (modelo.Vista == 2)// carga inicial de datos personales
            {
                CargaInicialENF();
            }

            return View(modelo);
        }

        #region Cargas inciales drop down list
        private List<ListTipoIdentificacion> CargarTipoIdentificacion()
        {
            List<ListTipoIdentificacion> list = new List<ListTipoIdentificacion>();
            list = new List<ListTipoIdentificacion>();
            try
            {
                Negocio.Dtos.ListGenericDropDown Datos = (Negocio.Dtos.ListGenericDropDown)new Negocio.Entidades.Comun().GetTipoIdentificaciones();
                if (Datos.Codigo == "200")
                {
                    foreach (var item in Datos.Lista)
                        list.Add(new ListTipoIdentificacion() { Id = item.Id, Nombre = item.Valor });
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return list;
        }
        private List<ListGenero> CargarGenero()
        {
            List<ListGenero> list = new List<ListGenero>();
            list = new List<ListGenero>();
            try
            {
                Negocio.Dtos.ListGenericDropDown Datos = (Negocio.Dtos.ListGenericDropDown)new Negocio.Entidades.Comun().GetGeneros();
                if (Datos.Codigo == "200")
                {
                    foreach (var item in Datos.Lista)
                        list.Add(new ListGenero() { Id = item.Id, Nombre = item.Valor });
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return list;
        }
        private List<ListDepartamento> CargarDepartamento()
        {
            List<ListDepartamento> list = new List<ListDepartamento>();
            list = new List<ListDepartamento>();
            try
            {
                Negocio.Dtos.ListGenericDropDown Datos = (Negocio.Dtos.ListGenericDropDown)new Negocio.Entidades.Comun().GetDepartamentos();
                if (Datos.Codigo == "200")
                {
                    foreach (var item in Datos.Lista)
                        list.Add(new ListDepartamento() { Id = item.Id, Nombre = item.Valor });
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return list;
        }
        private List<ListCiudad> CargarCiudad()
        {
            List<ListCiudad> list = new List<ListCiudad>();
            list = new List<ListCiudad>();
            try
            {
                Negocio.Dtos.ListGenericDropDown Datos = (Negocio.Dtos.ListGenericDropDown)new Negocio.Entidades.Comun().GetCiudades();
                if (Datos.Codigo == "200")
                {
                    foreach (var item in Datos.Lista)
                        list.Add(new ListCiudad() { Id = item.Id, Nombre = item.Valor });
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return list;
        }
        private List<ListPais> CargarPais()
        {
            List<ListPais> list = new List<ListPais>();
            list = new List<ListPais>();
            try
            {
                Negocio.Dtos.ListGenericDropDown Datos = (Negocio.Dtos.ListGenericDropDown)new Negocio.Entidades.Comun().GetPaises();
                if (Datos.Codigo == "200")
                {
                    foreach (var item in Datos.Lista)
                        list.Add(new ListPais() { Id = item.Id, Nombre = item.Valor });
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return list;
        }

        private List<ListInstitucion> CargarInstitucion()
        {
            List<ListInstitucion> list = new List<ListInstitucion>();
            list = new List<ListInstitucion>();
            try
            {
                Negocio.Dtos.ListGenericDropDown Datos = (Negocio.Dtos.ListGenericDropDown)new Negocio.Entidades.Comun().GetInstituciones();
                if (Datos.CodigoError == "200")
                {
                    foreach (var item in Datos.Lista)
                        list.Add(new ListInstitucion() { Id = item.Id, Nombre = item.Valor });
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return list;
        }
        #endregion

        #region Datos Personales
        private void CargaInicialDP()
        {
            try
            {
                modelo.ListPais = CargarPais();
                modelo.ListTipoIdentificacion = CargarTipoIdentificacion();
                modelo.ListGenero = CargarGenero();
                modelo.ListDepartamento = CargarDepartamento();
                modelo.ListCiudad = CargarCiudad();
                modelo.ListPaisRecidencia = CargarPais();
                modelo.ListDepartamentoRecidencia = CargarDepartamento();
                modelo.ListCiudadRecidencia = CargarCiudad();
                modelo.ListDiscapacidad = new List<ListDiscapacidad>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Educación Formal

        public ActionResult EducacionFormal()
        {
            CargaInicialEF();
            return View("EducacionFormal", modelo);
        }

        private void CargaInicialEF()
        {
            try
            {
                modelo.ListPaisDondeEstudio = CargarPais();
                modelo.ListDepartamentoDondeEstudio = CargarDepartamento();
                modelo.ListCiudadDondeEstudio = CargarCiudad();
                modelo.ListInstitucionDondeEstudio = CargarInstitucion();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //[HttpPost]
        //public ActionResult CrearEducacionFormal()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        return RedirectToAction("EducacionFormal");
        //    }
        //    else
        //    {
        //    }
        //}
        #endregion


        #region Educación No Formal

        public ActionResult EducacionNoFormal()
        {
            CargaInicialENF();
            return View("EducacionNoFormal", modelo);
        }

        private void CargaInicialENF()
        {
            try
            {
                modelo.ListPaisDondeEstudioNF = CargarPais();
                modelo.ListDepartamentoDondeEstudioNF = CargarDepartamento();
                modelo.ListCiudadDondeEstudioNF = CargarCiudad();
                modelo.ListInstitucionDondeEstudioNF = CargarInstitucion();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

    }
}