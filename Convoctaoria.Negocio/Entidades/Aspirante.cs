using Convocatoria.Negocio.Dtos;
using Convocatoria.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Convocatoria.Datos;

namespace Convocatoria.Negocio.Entidades
{
    public class Aspirante
    {
        public IModel ConsultarAspirante(int IdAspirante)
        {
            DatosAspirante informacion = new DatosAspirante();
            try
            {
                using (var context = new Convocatoria.Datos.DBContext.ConvocatoriaModel())
                {
                    var datos = from AS in context.TP_PERSONA
                                    //aca hacer inner join si es necesario...para crear el tipo complejo
                                where AS.ID_TP_PERSONA == IdAspirante
                                select AS;

                    Convocatoria.Datos.Entities.TP_PERSONA aspirante = (Convocatoria.Datos.Entities.TP_PERSONA)datos;
                    if (aspirante != null)
                    {
                        informacion.Apellido = aspirante.APELLIDOS;
                        informacion.NoDocumento = aspirante.IDENTIFICACION;
                        informacion.Nombre = aspirante.NOMBRES;
                        /*
                         . Aca todos los datos que se necesiten...
                         */
                        informacion.Codigo = "200";
                        informacion.Mensaje = "Ok";
                    }
                    else
                    {
                        informacion.Codigo = "404";
                        informacion.Mensaje = "No encontrado";
                    }


                }
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
         *  Ejemplos para ejeuctar modelo con code firts de entity Framework, CRUD
         * 
         *  Pendiente ejemplo de consumo procedimientos almacenados Oracle SAGC
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
    }
}
