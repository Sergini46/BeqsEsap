using Convocatoria.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convocatoria.Negocio.Entidades 
{
    public class Persona
    {
        public IModel Crear(Dtos.Persona Persona, Dtos.Auditoria Auditoria)
        {
            Dtos.Persona datosCreacion = new Dtos.Persona();
            try
            {
                using (var context = new Datos.DBContext.ConvocatoriaModel())
                {

                    var Entidad = context.Set<Datos.Entities.TP_PERSONA>();
                    Datos.Entities.TP_PERSONA persona = new Datos.Entities.TP_PERSONA();
                    persona.AUDIT_ACCION = Auditoria.Accion;
                    persona.AUDIT_ELIMINADO = Auditoria.Eliminado;
                    persona.AUDIT_FECHACREACION = Auditoria.FechaCreacion;
                    persona.AUDIT_IP = Auditoria.IP;
                    persona.AUDIT_NAVEGADOR = Auditoria.Navegador;
                    persona.AUDIT_SISTEMAOPERATIVO = Auditoria.SistemaOperativo;
                    persona.AUDIT_USUARIO = Auditoria.Usuario;
                    persona.APELLIDOS = Persona.Apellidos;
                    persona.DIRECCIONRESIDENCIA = Persona.DireccionResidencia;
                    persona.DISCAPACIDADCOMENTARIOS = Persona.DiscapacidadComentario;
                    persona.EMAIL = Persona.Correo;
                    persona.FECHANACIMIENTO = Persona.FechaNacimiento;
                    persona.FEHAEXPEDICIONIDENTIFICACION = Persona.FechaExpedicionDocumento;
                    persona.IDENTIFICACION = Persona.Identificacion;
                    persona.ID_TP_CIUDAD_EXAMENES = Persona.CiudadExamenes;
                    persona.ID_TP_CIUDAD_NACIMIENTO = Persona.CiudadNacimiento;
                    persona.ID_TP_CIUDAD_RESIDENCIA = Persona.CiudadResidencia;
                    persona.ID_TP_GENERO = Persona.Genero;
                    persona.ID_TP_PERSONA = 3;//Acá preguntar por autonumerico de oracle..
                    persona.ID_TP_TIPODISCAPACIDAD = Persona.TipoDiscapacidad;
                    persona.ID_TP_TIPOIDENTIFICACION = Persona.TipoIdentificacion;
                    persona.NOMBRES = Persona.Nombres;
                    persona.TELEFONOFIJOCONTACTO = Persona.TelefonoFijoContato;
                    persona.TELEFONOMOVILCONTACTO = Persona.TelefonoMovilContacto;
                    Entidad.Add(persona);
                    context.SaveChanges();
                    datosCreacion.CodigoError = "200";
                }
            }
            catch (Exception ex)
            {
                datosCreacion.MensajeError = ex.Message;
                datosCreacion.CodigoError = "500";
            }
            return datosCreacion;
        }
        public IModel Delete(int Persona, Dtos.Auditoria Auditoria)
        {
            Dtos.Persona datosCreacion = new Dtos.Persona();
            try
            {
                using (var context = new Datos.DBContext.ConvocatoriaModel())
                {
                    var DatosPersona = from p in context.TP_PERSONA
                                       where p.ID_TP_PERSONA == Persona && p.AUDIT_ELIMINADO == false
                                       select p;

                    Datos.Entities.TP_PERSONA personEntity = DatosPersona.FirstOrDefault<Datos.Entities.TP_PERSONA>();
                    if (personEntity != null)
                    {
                        personEntity.AUDIT_ELIMINADO = true;
                        personEntity.AUDIT_ACCION = Auditoria.Accion;
                        personEntity.AUDIT_FECHACREACION = Auditoria.FechaCreacion;
                        personEntity.AUDIT_IP = Auditoria.IP;
                        personEntity.AUDIT_NAVEGADOR = Auditoria.Navegador;
                        personEntity.AUDIT_SISTEMAOPERATIVO = Auditoria.SistemaOperativo;
                        personEntity.AUDIT_USUARIO = Auditoria.Usuario;
                        context.Entry(personEntity).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
                        datosCreacion.CodigoError = "200";
                    }
                    else
                    {
                        datosCreacion.CodigoError = "404";
                    }
                }
            }
            catch (Exception ex)
            {
                datosCreacion.MensajeError = ex.Message;
                datosCreacion.CodigoError = "500";
            }
            return datosCreacion;
        }
        public IModel Update(Dtos.Persona Persona, Dtos.Auditoria Auditoria)
        {
            Dtos.Persona datosCreacion = new Dtos.Persona();
            try
            {
                using (var context = new Datos.DBContext.ConvocatoriaModel())
                {
                    var DatosPersona = from p in context.TP_PERSONA
                                       where p.ID_TP_PERSONA == Persona.IdPersona && p.AUDIT_ELIMINADO == false
                                       select p;

                    Datos.Entities.TP_PERSONA personEntity = DatosPersona.FirstOrDefault<Datos.Entities.TP_PERSONA>();
                    if (personEntity != null)
                    {
                        personEntity.AUDIT_ELIMINADO = true;
                        personEntity.AUDIT_ACCION = Auditoria.Accion;
                        personEntity.AUDIT_FECHACREACION = Auditoria.FechaCreacion;
                        personEntity.AUDIT_IP = Auditoria.IP;
                        personEntity.AUDIT_NAVEGADOR = Auditoria.Navegador;
                        personEntity.AUDIT_SISTEMAOPERATIVO = Auditoria.SistemaOperativo;
                        personEntity.AUDIT_USUARIO = Auditoria.Usuario;
                        personEntity.APELLIDOS = Persona.Apellidos;
                        personEntity.DIRECCIONRESIDENCIA = Persona.DireccionResidencia;
                        personEntity.DISCAPACIDADCOMENTARIOS = Persona.DiscapacidadComentario;
                        personEntity.EMAIL = Persona.Correo;
                        personEntity.FECHANACIMIENTO = Persona.FechaNacimiento;
                        personEntity.FEHAEXPEDICIONIDENTIFICACION = Persona.FechaExpedicionDocumento;
                        personEntity.IDENTIFICACION = Persona.Identificacion;
                        personEntity.ID_TP_CIUDAD_EXAMENES = Persona.CiudadExamenes;
                        personEntity.ID_TP_CIUDAD_NACIMIENTO = Persona.CiudadNacimiento;
                        personEntity.ID_TP_CIUDAD_RESIDENCIA = Persona.CiudadResidencia;
                        personEntity.ID_TP_GENERO = Persona.Genero;
                        personEntity.ID_TP_TIPODISCAPACIDAD = Persona.TipoDiscapacidad;
                        personEntity.ID_TP_TIPOIDENTIFICACION = Persona.TipoIdentificacion;
                        personEntity.NOMBRES = Persona.Nombres;
                        personEntity.TELEFONOFIJOCONTACTO = Persona.TelefonoFijoContato;
                        personEntity.TELEFONOMOVILCONTACTO = Persona.TelefonoMovilContacto;
                        context.Entry(personEntity).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
                        datosCreacion.CodigoError = "200";
                    }
                    else
                    {
                        datosCreacion.CodigoError = "404";
                    }
                }
            }
            catch (Exception ex)
            {
                datosCreacion.MensajeError = ex.Message;
                datosCreacion.CodigoError = "500";
            }
            return datosCreacion;
        }
        public IModel Select(int Persona)
        {
            Dtos.Persona datosCreacion = new Dtos.Persona();
            try
            {
                using (var context = new Datos.DBContext.ConvocatoriaModel())
                {
                    var DatosPersona = from p in context.TP_PERSONA
                                       join l in context.TM_HOJAVIDA on p.ID_TP_PERSONA equals l.ID_TP_PERSONA
                                       where p.ID_TP_PERSONA == Persona && p.AUDIT_ELIMINADO == false
                                       select p;

                    Datos.Entities.TP_PERSONA personEntity = DatosPersona.FirstOrDefault<Datos.Entities.TP_PERSONA>();
                    if (personEntity != null)
                    {
                        datosCreacion.Apellidos = personEntity.APELLIDOS;
                        datosCreacion.DireccionResidencia = personEntity.DIRECCIONRESIDENCIA;
                        datosCreacion.DiscapacidadComentario = personEntity.DISCAPACIDADCOMENTARIOS;
                        datosCreacion.Correo = personEntity.EMAIL;
                        datosCreacion.FechaNacimiento = personEntity.FECHANACIMIENTO.Value;
                        datosCreacion.FechaExpedicionDocumento = personEntity.FEHAEXPEDICIONIDENTIFICACION.Value;
                        datosCreacion.Identificacion = personEntity.IDENTIFICACION;
                        datosCreacion.CiudadExamenes = personEntity.ID_TP_CIUDAD_EXAMENES;
                        datosCreacion.CiudadNacimiento = personEntity.ID_TP_CIUDAD_NACIMIENTO;
                        datosCreacion.CiudadResidencia = personEntity.ID_TP_CIUDAD_RESIDENCIA;
                        datosCreacion.Genero = personEntity.ID_TP_GENERO;
                        datosCreacion.TipoDiscapacidad = personEntity.ID_TP_TIPODISCAPACIDAD;
                        datosCreacion.TipoIdentificacion = personEntity.ID_TP_TIPOIDENTIFICACION;
                        datosCreacion.Nombres = personEntity.NOMBRES;
                        datosCreacion.TelefonoFijoContato = personEntity.TELEFONOFIJOCONTACTO;
                        datosCreacion.TelefonoMovilContacto = personEntity.TELEFONOMOVILCONTACTO;
                        datosCreacion.CodigoError = "200";
                    }
                    else
                    {
                        datosCreacion.CodigoError = "404";
                    }
                }
            }
            catch (Exception ex)
            {
                datosCreacion.MensajeError = ex.Message;
                datosCreacion.CodigoError = "500";
            }
            return datosCreacion;
        }
    }
}
