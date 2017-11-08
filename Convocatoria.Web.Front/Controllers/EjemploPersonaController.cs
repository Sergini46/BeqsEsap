using Convocatoria.Web.Front.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Convocatoria.Web.Front.Controllers
{
    public class EjemploPersonaController : Controller
    {
        EjemploPersonaModel model ;
        Convocatoria.Negocio.Entidades.Persona person = new Negocio.Entidades.Persona();
        enum DropDown { Ciudades = 1, Discapacidades = 2, Generos = 3, TiposIdentificacion= 4 };

        public ActionResult Index()
        {
            ObtenerModelo();
            model.Mensajes = new List<MensajeModel>();
            LoadDropDown(DropDown.Ciudades);
            LoadDropDown(DropDown.Discapacidades);
            LoadDropDown(DropDown.Generos);
            LoadDropDown(DropDown.TiposIdentificacion);
            AsignarModelo();
            return View(model);
        }

        public ActionResult ExperienciaLaboral (int? idPersona)
        {
            ExperienciaLaboralModel modeloParcial = new Models.ExperienciaLaboralModel() { Dato = idPersona != null ? idPersona.Value.ToString() : "0" };
            return View(modeloParcial);
        }

        private void LoadDropDown (DropDown Drop)
        {
            try
            {
                Negocio.Dtos.ListGenericDropDown Datos;
                switch (Drop)
                {
                    case (DropDown.Ciudades):
                        model.Ciudades = new List<ItemDropDown>();
                        Datos = (Negocio.Dtos.ListGenericDropDown)new Negocio.Entidades.Comun().GetCiudades();
                        break;
                    case (DropDown.Discapacidades):
                        model.Discapacidades = new List<ItemDropDown>();
                        Datos = (Negocio.Dtos.ListGenericDropDown)new Negocio.Entidades.Comun().GetDiscapacidad();
                        break;
                    case (DropDown.Generos):
                        model.Generos = new List<ItemDropDown>();
                        Datos = (Negocio.Dtos.ListGenericDropDown)new Negocio.Entidades.Comun().GetGeneros();
                        break;
                    case (DropDown.TiposIdentificacion):
                        model.TiposIdentificacion = new List<ItemDropDown>();
                        Datos = (Negocio.Dtos.ListGenericDropDown)new Negocio.Entidades.Comun().GetTipoIdentificaciones();
                        break;
                    default:
                        Datos = new Negocio.Dtos.ListGenericDropDown();
                        break;
                }
                if (Datos != null && Datos.CodigoError == "200")
                {
                    foreach (var item in Datos.Lista)
                    {
                        switch (Drop)
                        {
                            case (DropDown.Ciudades):
                                model.Ciudades.Add(new ItemDropDown() { Id = item.Id, Nombre = item.Valor });
                                break;
                            case (DropDown.Discapacidades):
                                model.Discapacidades.Add(new ItemDropDown() { Id = item.Id, Nombre = item.Valor });
                                break;
                            case (DropDown.Generos):
                                model.Generos.Add(new ItemDropDown() { Id = item.Id, Nombre = item.Valor });
                                break;
                            case (DropDown.TiposIdentificacion):
                                model.TiposIdentificacion.Add(new ItemDropDown() { Id = item.Id, Nombre = item.Valor });
                                break;
                            default:
                                break;
                        }
                    }
                }
                else
                {
                    model.Mensajes.Add(new MensajeModel() { Codigo = Datos.CodigoError, Mensaje = Datos.MensajeError, InformacionAdicional = "LoadDropDown" });
                }
            }
            catch (Exception ex)
            {
                model.Mensajes.Add(new MensajeModel() { Codigo =ex.InnerException.GetHashCode().ToString(), Mensaje = ex.Message, InformacionAdicional = ex.InnerException.Message});
                //implements log4net pending SAGC
            }

        }

        public ActionResult Create(EjemploPersonaModel modelo)
        {
            ObtenerModelo();
            Negocio.Dtos.Persona personaCrear = new Negocio.Dtos.Persona();
            Negocio.Dtos.Auditoria auditoria = new Negocio.Dtos.Auditoria();
            personaCrear.Apellidos = modelo.Apellidos;
            personaCrear.CiudadExamenes = model.CiudadExamanes;
            personaCrear.CiudadNacimiento = model.CiudadNacimiento;
            personaCrear.CiudadResidencia = model.CiudadResidencia;
            personaCrear.Correo = modelo.Email;
            personaCrear.DireccionResidencia = modelo.DireccionResidencia;
            personaCrear.DiscapacidadComentario = modelo.DiscapacidadComentario;
            personaCrear.FechaExpedicionDocumento = modelo.FechaExpedicion;
            personaCrear.FechaNacimiento = modelo.FechaNacimiento;
            personaCrear.Genero = modelo.Genero;
            personaCrear.Identificacion = modelo.Identificacion;
            personaCrear.Nombres = modelo.Nombres;
            personaCrear.TelefonoFijoContato = modelo.TelefonoFijo;
            personaCrear.TelefonoMovilContacto = modelo.TelefonoMovil;
            personaCrear.TipoDiscapacidad = modelo.Discapacidad;
            personaCrear.TipoIdentificacion = modelo.TipoIdentificacion;
            personaCrear.IdPersona = model.Id;
            Negocio.Dtos.Persona datosRetorno = (Negocio.Dtos.Persona) person.Crear(personaCrear, auditoria);
            
            if(datosRetorno.CodigoError == "200")
            {
                AsignarModelo();
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                if (model.Mensajes == null)
                    model.Mensajes = new List<MensajeModel>();

                model.Mensajes.Add(new MensajeModel() { Codigo = datosRetorno.CodigoError, Mensaje = datosRetorno.MensajeError, InformacionAdicional = "Create" });
                AsignarModelo();
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            
        }
        public ActionResult Delete (int IdPersona)
        {
            ObtenerModelo();
            Negocio.Dtos.Auditoria auditoria = new Negocio.Dtos.Auditoria();
            Negocio.Dtos.Persona datosRetorno = (Negocio.Dtos.Persona)person.Delete(IdPersona, auditoria);
            if (datosRetorno.CodigoError == "200")
            {
                AsignarModelo();
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                if (model.Mensajes == null)
                    model.Mensajes = new List<MensajeModel>();

                model.Mensajes.Add(new MensajeModel() { Codigo = datosRetorno.CodigoError, Mensaje = datosRetorno.MensajeError, InformacionAdicional = "Create" });
                AsignarModelo();
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Update(EjemploPersonaModel modelo)
        {
            ObtenerModelo();
            Negocio.Dtos.Persona personaActualizar= new Negocio.Dtos.Persona();
            Negocio.Dtos.Auditoria auditoria = new Negocio.Dtos.Auditoria();
            personaActualizar.Apellidos = modelo.Apellidos;
            personaActualizar.CiudadExamenes = model.CiudadExamanes;
            personaActualizar.CiudadNacimiento = model.CiudadNacimiento;
            personaActualizar.CiudadResidencia = model.CiudadResidencia;
            personaActualizar.Correo = modelo.Email;
            personaActualizar.DireccionResidencia = modelo.DireccionResidencia;
            personaActualizar.DiscapacidadComentario = modelo.DiscapacidadComentario;
            personaActualizar.FechaExpedicionDocumento = modelo.FechaExpedicion;
            personaActualizar.FechaNacimiento = modelo.FechaNacimiento;
            personaActualizar.Genero = modelo.Genero;
            personaActualizar.Identificacion = modelo.Identificacion;
            personaActualizar.Nombres = modelo.Nombres;
            personaActualizar.TelefonoFijoContato = modelo.TelefonoFijo;
            personaActualizar.TelefonoMovilContacto = modelo.TelefonoMovil;
            personaActualizar.TipoDiscapacidad = modelo.Discapacidad;
            personaActualizar.TipoIdentificacion = modelo.TipoIdentificacion;
            personaActualizar.IdPersona = modelo.Id;
            Negocio.Dtos.Persona datosRetorno = (Negocio.Dtos.Persona)person.Update(personaActualizar, auditoria);

            if (datosRetorno.CodigoError == "200")
            {
                AsignarModelo();
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                if (model.Mensajes == null)
                    model.Mensajes = new List<MensajeModel>();

                model.Mensajes.Add(new MensajeModel() { Codigo = datosRetorno.CodigoError, Mensaje = datosRetorno.MensajeError, InformacionAdicional = "Create" });
                AsignarModelo();
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Select(int IdPersona)
        {
            ObtenerModelo();
            Negocio.Dtos.Persona datosRetorno = (Negocio.Dtos.Persona)person.Select(IdPersona);
            if (datosRetorno.CodigoError == "200")
            {
                model.Apellidos = datosRetorno.Apellidos;
                model.CiudadExamanes = datosRetorno.CiudadExamenes;
                model.CiudadNacimiento = datosRetorno.CiudadNacimiento;
                model.CiudadResidencia = datosRetorno.CiudadResidencia;
                model.DireccionResidencia = datosRetorno.DireccionResidencia;
                model.Discapacidad = datosRetorno.TipoDiscapacidad;
                model.Email = datosRetorno.Correo;
                model.FechaExpedicion = datosRetorno.FechaExpedicionDocumento;
                model.FechaNacimiento = datosRetorno.FechaNacimiento;
                model.Genero = datosRetorno.Genero;
                model.Identificacion = datosRetorno.Identificacion;
                model.Nombres = datosRetorno.Nombres;
                model.TelefonoFijo = datosRetorno.TelefonoFijoContato;
                model.TelefonoMovil = datosRetorno.TelefonoMovilContacto;
                model.TipoIdentificacion = datosRetorno.TipoIdentificacion;
                AsignarModelo();
                return Json(true, JsonRequestBehavior.AllowGet);
                //return Json(model, JsonRequestBehavior.AllowGet);
            }
            else
            {
                if (model.Mensajes == null)
                    model.Mensajes = new List<MensajeModel>();

                model.Mensajes.Add(new MensajeModel() { Codigo = datosRetorno.CodigoError, Mensaje = datosRetorno.MensajeError, InformacionAdicional = "Create" });
                AsignarModelo();
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        private void ObtenerModelo()
        {
            try
            {
                if (TempData["ModelPersona"] != null)
                {
                    model = (EjemploPersonaModel)TempData["ModelPersona"];
                }
                else
                    model = new EjemploPersonaModel();
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
                TempData["ModelPersona"] = model;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}




