﻿using System;
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
        Negocio.Entidades.Persona persona = new Negocio.Entidades.Persona();

        public ActionResult Index(int? vista)
        {
            modelo = new HojaDeVidaModel();

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
                CargaInicialDP();
            }
            else if (modelo.Vista == 5)// carga inicial de experiencia docente
            {
                CargaInicialExperienciaDocente();
            }
            else// carga inicial de datos personales
            {
                CargaInicialENF();
            }

            return View(modelo);
        }


        #region Cargas inciales 

        private void ObtenerModelo()
        {
            try
            {
                if (TempData["ModelHojaVida"] != null)
                {
                    modelo = (HojaDeVidaModel)TempData["ModelHojaVida"];
                }
                else
                    modelo = new HojaDeVidaModel();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }
        public void AsignarModelo()
        {
            try
            {
                TempData["ModelHojaVida"] = modelo;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
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
                if (Datos.Codigo == "200")
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
        private List<ListDiscapacidad> CargarDiscapacidad()
        {
            List<ListDiscapacidad> list = new List<ListDiscapacidad>();
            list = new List<ListDiscapacidad>();
            try
            {
                Negocio.Dtos.ListGenericDropDown Datos = (Negocio.Dtos.ListGenericDropDown)new Negocio.Entidades.Comun().GetDiscapacidad();
                if (Datos.Codigo == "200")
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

        private IList<ItemDropDown> CargarTipoVinculacion()
        {
            IList<ItemDropDown> listaTipoVinculacion = new List<ItemDropDown>();
            try
            {
                Negocio.Dtos.ListGenericDropDown Datos = (Negocio.Dtos.ListGenericDropDown)new Negocio.Entidades.Comun().GetTipoVinculacion();
                if (Datos.Codigo == String.Empty)
                {
                    foreach (var item in Datos.Lista)
                        listaTipoVinculacion.Add(new ItemDropDown() { Id = item.Id, Nombre = item.Valor });
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return listaTipoVinculacion;
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
        public ActionResult CrearPersona(HojaDeVidaModel model)
        {
            //ObtenerModelo();
            Negocio.Dtos.Persona personaCrear = new Negocio.Dtos.Persona();
            Negocio.Dtos.Auditoria auditoria = new Negocio.Dtos.Auditoria();
            personaCrear.Apellidos = modelo.Apellido;
            //personaCrear.CiudadExamenes = model.CiudadExamanes;
            personaCrear.CiudadNacimiento = Convert.ToInt32(modelo.DdlIdCiudad);
            personaCrear.CiudadResidencia = Convert.ToInt32(modelo.ddlIdCiudadRecidencia) ;
            personaCrear.Correo = modelo.Email;
            personaCrear.DireccionResidencia = modelo.Direccion;
            personaCrear.DiscapacidadComentario = modelo.RequiereApoyo;
            personaCrear.FechaExpedicionDocumento = modelo.FechaExpedicion;
            personaCrear.FechaNacimiento = modelo.FechaNacimiento;
            personaCrear.Genero = Convert.ToInt32( modelo.DdlIdGenero);
            personaCrear.Identificacion = modelo.Identificacion;
            personaCrear.Nombres = modelo.Nombre;
            personaCrear.TelefonoFijoContato = modelo.TelefonoFijo;
            personaCrear.TelefonoMovilContacto = modelo.TelefonoFijo2;
            personaCrear.TipoDiscapacidad = Convert.ToInt32(modelo.ddlIdDiscapacidad);
            personaCrear.TipoIdentificacion = Convert.ToInt32(modelo.DdlIdTipoIdentificacion);
            personaCrear.IdPersona = modelo.IdPersona;
            Negocio.Dtos.Persona datosRetorno = (Negocio.Dtos.Persona)persona.Crear(personaCrear, auditoria);

            if (datosRetorno.Codigo == "200")
            {
                AsignarModelo();
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                if (modelo.Mensaje == null)
                    modelo.Mensaje = new List<MensajeModel>();

                modelo.Mensaje.Add(new MensajeModel() { Codigo = datosRetorno.Codigo, Mensaje = datosRetorno.Mensaje, InformacionAdicional = "Create" });
                AsignarModelo();
                return Json(false, JsonRequestBehavior.AllowGet);
            }

        }
        #endregion

        #region Experiencia laboral
        private void CargaInicialEL(int? IdHv)
        {
            try
            {
                modelo.ListPais = CargarPais();
                modelo.ListDepartamento = CargarDepartamento();
                modelo.ListCiudad = CargarCiudad();
                //modelo.ListExperiencia = new List<Negocio.Dtos.Laboral>(); 09/11/2017
                if (Convert.ToInt32(IdHv) <= 0)
                {
                    modelo.IdHV = Convert.ToInt32(IdHv);
                    Negocio.Entidades.Laboral labo = new Negocio.Entidades.Laboral();
                    //modelo.ListExperiencia = labo.ConsultaXId(modelo.IdHV);
                }
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

        #region Experiencia docente
        public void CargaInicialExperienciaDocente()
        {
            try
            {
                modelo.ExperienciaDocenteModel = new ExperienciaDocenteModel();
                modelo.ExperienciaDocenteModel.ListaCiudadEntidadEducativa = CargarCiudad();
                modelo.ExperienciaDocenteModel.ListaTipoVinculacion = CargarTipoVinculacion();
                modelo.ExperienciaDocenteModel.ListaEntidadEducativa = CargarInstitucion();
                modelo.ExperienciaDocenteModel.ListaPaisEntidadEducativa = CargarPais();
                modelo.ExperienciaDocenteModel.ListaDepartamentoEntidadEducativa = CargarDepartamento();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

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