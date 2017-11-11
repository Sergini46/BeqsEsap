using Convocatoria.Datos;
using Convocatoria.Negocio.Dtos;
using Convocatoria.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convocatoria.Negocio.Entidades
{
    public class Comun
    {

        public IModel GetPaises()
        {
            ListGenericDropDown informacion = new ListGenericDropDown();
            informacion.Lista = new List<GenericDropDown>();
            try
            {
                using (var context = new  Convocatoria.Datos.DBContext.ConvocatoriaModel())
                {
                    var datos = from AS in context.TP_PAIS
                                select AS;

                    List<Convocatoria.Datos.Entities.TP_PAIS> paises = datos.ToList<Convocatoria.Datos.Entities.TP_PAIS>();
                    for (int i = 0; i < paises.Count; i++)
                    {
                        informacion.Lista.Add(new GenericDropDown() { Id = paises[i].ID_TP_PAIS, Valor = paises[i].NOMBRE });
                    }
                }
                informacion.Codigo = "200";
            }
            catch (Exception ex)
            {
                informacion.Mensaje = ex.Message;
                informacion.Codigo = "403";
            }
            return informacion;
        }
        public IModel GetTipoIdentificaciones()
        {
            ListGenericDropDown informacion = new ListGenericDropDown();
            informacion.Lista = new List<GenericDropDown>();
            try
            {
                using (var context = new Convocatoria.Datos.DBContext.ConvocatoriaModel())
                {
                    var datos = from AS in context.TP_TIPOIDENTIFICACION
                                select AS;

                    List<Convocatoria.Datos.Entities.TP_TIPOIDENTIFICACION> TiposIdentificacion = datos.ToList<Convocatoria.Datos.Entities.TP_TIPOIDENTIFICACION>();
                    if (TiposIdentificacion != null)
                    {
                        for (int i = 0; i < TiposIdentificacion.Count; i++)
                        {
                            informacion.Lista.Add(new GenericDropDown() { Id = TiposIdentificacion[i].ID_TP_TIPOIDENTIFICACION, Valor = TiposIdentificacion[i].NOMBRE });
                        }
                    }
                }
                informacion.Codigo = "200";
            }
            catch (Exception ex)
            {
                informacion.Mensaje = ex.Message;
                informacion.Codigo = "403";
            }
            return informacion;
        }
        public IModel GetGeneros()
        {
            ListGenericDropDown informacion = new ListGenericDropDown();
            informacion.Lista = new List<GenericDropDown>();
            try
            {
                using (var context = new Convocatoria.Datos.DBContext.ConvocatoriaModel())
                {
                    var datos = from AS in context.TP_GENERO
                                select AS;

                    List<Convocatoria.Datos.Entities.TP_GENERO> Generos = datos.ToList<Convocatoria.Datos.Entities.TP_GENERO>();
                    if (Generos != null)
                    {
                        for (int i = 0; i < Generos.Count; i++)
                        {
                            informacion.Lista.Add(new GenericDropDown() { Id = Generos[i].ID_TP_GENERO, Valor = Generos[i].NOMBRE });
                        }
                    }
                }
                informacion.Codigo = "200";
            }
            catch (Exception ex)
            {
                informacion.Mensaje = ex.Message;
                informacion.Codigo = "403";
            }
            return informacion;
        }
        public IModel GetDepartamentos()
        {
            ListGenericDropDown informacion = new ListGenericDropDown();
            informacion.Lista = new List<GenericDropDown>();
            try
            {
                using (var context = new Convocatoria.Datos.DBContext.ConvocatoriaModel())
                {
                    var datos = from AS in context.TP_DEPARTAMENTO
                                select AS;

                    List<Convocatoria.Datos.Entities.TP_DEPARTAMENTO> DEPARTAMENTO = datos.ToList<Convocatoria.Datos.Entities.TP_DEPARTAMENTO>();
                    for (int i = 0; i < DEPARTAMENTO.Count; i++)
                    {
                        informacion.Lista.Add(new GenericDropDown() { Id = DEPARTAMENTO[i].ID_TP_DEPARTAMENTO, Valor = DEPARTAMENTO[i].NOMBRE });
                    }
                }
                informacion.Codigo = "200";
            }
            catch (Exception ex)
            {
                informacion.Mensaje = ex.Message;
                informacion.Codigo = "403";
            }
            return informacion;
        }
        public IModel GetCiudades()
        {
            ListGenericDropDown informacion = new ListGenericDropDown();
            informacion.Lista = new List<GenericDropDown>();
            try
            {
                using (var context = new Convocatoria.Datos.DBContext.ConvocatoriaModel())
                {
                    var datos = from AS in context.TP_CIUDAD
                                select AS;

                    List<Convocatoria.Datos.Entities.TP_CIUDAD> Ciudades = datos.ToList<Convocatoria.Datos.Entities.TP_CIUDAD>();
                    if (Ciudades != null)
                    {
                        for (int i = 0; i < Ciudades.Count; i++)
                        {
                            informacion.Lista.Add(new GenericDropDown() { Id = Ciudades[i].ID_TP_CIUDAD, Valor = Ciudades[i].NOMBRE });
                        }
                    }
                }
                informacion.Codigo = "200";
            }
            catch (Exception ex)
            {
                informacion.Mensaje = ex.Message;
                informacion.Codigo = "403";
            }
            return informacion;
        }
        public IModel GetDiscapacidad()
        {
            ListGenericDropDown informacion = new ListGenericDropDown();
            informacion.Lista = new List<GenericDropDown>();
            try
            {
                using (var context = new Convocatoria.Datos.DBContext.ConvocatoriaModel())
                {
                    var datos = from AS in context.TP_TIPODISCAPACIDAD
                                select AS;

                    List<Convocatoria.Datos.Entities.TP_TIPODISCAPACIDAD> Discapacidades = datos.ToList<Convocatoria.Datos.Entities.TP_TIPODISCAPACIDAD>();
                    for (int i = 0; i < Discapacidades.Count; i++)
                    {
                        informacion.Lista.Add(new GenericDropDown() { Id = Discapacidades[i].ID_TP_TIPODISCAPACIDAD, Valor = Discapacidades[i].NOMBRE });
                    }
                }
                informacion.Codigo = "200";
            }
            catch (Exception ex)
            {
                informacion.Mensaje = ex.Message;
                informacion.Codigo = "403";
            }
            return informacion;
        }
        public IModel SuMetodo()
        {
            throw new NotImplementedException();
        }




        /****************************************************************************************************************
         * 
         *  Ejemplos para ejecutar modelo con code firts de entity Framework, CRUD
         * 
         * Pendiente ejemplo de consumo procedimientos almacenados Oracle SAGC
         * ***************************************************************************************************************/


        //        //select and delete

        //using (var context = new ConsultorioModel())
        //{
        //	var ActuacionPenal = from ap in context.ActuacionPenal
        //                         where ap.IdActuacion == IdActuacion
        //                         select ap;


        //    ConsultorioJuridicoDAL.ActuacionPenal Apenal = ActuacionPenal.FirstOrDefault<ConsultorioJuridicoDAL.ActuacionPenal>();
        //	if (Apenal != null)
        //	{
        //		var Data = from APD in context.ActuacionPenalDelito
        //                   where APD.IdDelito == IdDelito && APD.IdActuacionPenal == Apenal.Id
        //                   select APD;

        //    ConsultorioJuridicoDAL.ActuacionPenalDelito Delito = Data.FirstOrDefault<ConsultorioJuridicoDAL.ActuacionPenalDelito>();
        //		if (Delito != null)
        //		{
        //			context.Entry(Delito).State = System.Data.Entity.EntityState.Deleted;
        //			context.SaveChanges();
        //			return true;
        //		}
        //	}

        //}

        ////update

        //using (var context = new ConsultorioModel())
        //            {
        //                var Data = from ins in context.Inscripcion
        //                           where ins.Id == IdInscripcion
        //                           select ins;

        //Inscripcion inscripcionExistente = Data.FirstOrDefault<Inscripcion>();
        //                if (inscripcionExistente != null)
        //                {
        //                    inscripcionExistente.IdEps = IdEps;
        //                    context.Entry(inscripcionExistente).State = System.Data.Entity.EntityState.Modified;
        //                    context.SaveChanges();
        //                    return inscripcionExistente.Id;
        //                }
        //            }


        ////insert

        //using (var context = new ConsultorioModel())
        //            {
        //                var formulario = context.Set<AnotacionHojaVida>();
        //AnotacionHojaVida anotacion = new ConsultorioJuridicoDAL.AnotacionHojaVida();
        //anotacion.Anotacion = Observacion;
        //                anotacion.Fecha = DateTime.Now;
        //                anotacion.IdSap = IdSap;
        //                anotacion.IdUsuario = IdUsuario;
        //                formulario.Add(anotacion);
        //                context.SaveChanges();
        //                return anotacion.Id;
        //            }

        ////  select complejo

        // using (var context = new ConsultorioModel())
        //            {
        //                var Data = from AP in context.ActuacionPenal
        //                           join AC in context.Actuacion on AP.IdActuacion equals AC.Id
        //                           join APD in context.ActuacionPenalDelito on AP.Id equals APD.IdActuacionPenal
        //                           join D in context.Delito on APD.IdDelito equals D.Id
        //                           select new ConsultorioJuridicoDAL.Entidades.SalaPenal.DelitoCustom()
        //                           {
        //                               IdCasoSolicitud = APD.IdActuacionPenal,
        //                               IdDelito = APD.IdDelito,
        //                               NombreDelito = D.Nombre
        //                           };
        //                return Data.ToList<Entidades.SalaPenal.DelitoCustom>();
        //            }

        //    }

        public IModel GetInstituciones()
        {
            ListGenericDropDown informacion = new ListGenericDropDown();
            informacion.Lista = new List<GenericDropDown>();
            try
            {
                using (var context = new Convocatoria.Datos.DBContext.ConvocatoriaModel())
                {
                    var datos = from AS in context.TP_ENTIDADEDUCATIVA
                                select AS;

                    List<Convocatoria.Datos.Entities.TP_ENTIDADEDUCATIVA> paises = datos.ToList<Convocatoria.Datos.Entities.TP_ENTIDADEDUCATIVA>();
                    for (int i = 0; i < paises.Count; i++)
                    {
                        informacion.Lista.Add(new GenericDropDown() { Id = paises[i].ID_TP_ENTIDADEDUCATIVA, Valor = paises[i].NOMBRE });
                    }
                }
                informacion.Codigo = "200";
            }
            catch (Exception ex)
            {
                informacion.Mensaje = ex.Message;
                informacion.Codigo = "403";
            }
            return informacion;
        }

        public IModel GetTipoVinculacion()
        {
            ListGenericDropDown datos = new ListGenericDropDown();
            datos.Lista = new List<GenericDropDown>();
            try
            {
                using (var context = new Convocatoria.Datos.DBContext.ConvocatoriaModel())
                {
                    var datosConsultados = from AS in context.TP_TIPOVINCULACION
                                select AS;

                    List<Convocatoria.Datos.Entities.TP_TIPOVINCULACION> tipos = datosConsultados.ToList<Convocatoria.Datos.Entities.TP_TIPOVINCULACION>();
                    for (int i = 0; i < tipos.Count; i++)
                    {
                        datos.Lista.Add(new GenericDropDown() { Id = tipos[i].ID_TP_TIPOVINCULACION, Valor = tipos[i].NOMBRE });
                    }
                }
                datos.Codigo = String.Empty;
            }
            catch (Exception ex)
            {
                datos.Mensaje = ex.Message;
                datos.Codigo = "403";
            }
            return datos;
        }
    }
}
