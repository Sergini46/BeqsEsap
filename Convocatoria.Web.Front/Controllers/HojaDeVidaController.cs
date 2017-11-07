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
            modelo = new HojaDeVidaModel();

            modelo.Vista = Convert.ToInt32(vista);

            if (modelo.Vista == 1)// carga inicial de educacion formal
            {
                CargaInicialDP();
            }
            else if (modelo.Vista == 2)
            {
                CargaInicialEL();
            }
            else// carga inicial de datos personales
            {
                CargaInicialDP();
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
                if (Datos.CodigoError == "200")
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
                if (Datos.CodigoError == "200")
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
                if (Datos.CodigoError == "200")
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
                if (Datos.CodigoError == "200")
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
                if (Datos.CodigoError == "200")
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
        private List<ListDiscapacidad> CargarDiscapacidad()
        {
            List<ListDiscapacidad> list = new List<ListDiscapacidad>();
            list = new List<ListDiscapacidad>();
            try
            {
                Negocio.Dtos.ListGenericDropDown Datos = (Negocio.Dtos.ListGenericDropDown)new Negocio.Entidades.Comun().GetDiscapacidad();
                if (Datos.CodigoError == "200")
                {
                    foreach (var item in Datos.Lista)
                        list.Add(new ListDiscapacidad() { Id = item.Id, Nombre = item.Valor });
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
                modelo.ListDiscapacidad = CargarDiscapacidad();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Experiencia laboral
        private void CargaInicialEL()
        {
            try
            {
                modelo.ListPais = CargarPais();
                modelo.ListDepartamento = CargarDepartamento();
                modelo.ListCiudad = CargarCiudad();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        public ActionResult EducacionFormal()
        {
            CargaInicialDP();
            return View("EducacionFormal", modelo);
        }

    }
}