using Convocatoria.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convocatoria.Negocio.Entidades
{
    public class Laboral
    {
        public IModel Crear(Dtos.Laboral obj, Dtos.Auditoria Auditoria)
        {
            Dtos.Laboral datosObj = new Dtos.Laboral();
            try
            {
                using (var context = new Datos.DBContext.ConvocatoriaModel())
                {

                    var Entidad = context.Set<Datos.Entities.TM_LABORAL>();
                    Datos.Entities.TM_LABORAL entiti = new Datos.Entities.TM_LABORAL();
                    entiti.AUDIT_ACCION = Auditoria.Accion;
                    entiti.AUDIT_ELIMINADO = Auditoria.Eliminado;
                    entiti.AUDIT_FECHACREACION = Auditoria.FechaCreacion;
                    entiti.AUDIT_IP = Auditoria.IP;
                    entiti.AUDIT_NAVEGADOR = Auditoria.Navegador;
                    entiti.AUDIT_SISTEMAOPERATIVO = Auditoria.SistemaOperativo;
                    entiti.AUDIT_USUARIO = Auditoria.Usuario;
                    entiti.ID_TM_HOJAVIDA = obj.IdHojaVida;
                    entiti.FECHAINGRESO = obj.FechaIngreso;
                    entiti.FECHASALIDA = obj.FechaSalida;
                    entiti.EMPRESA = obj.Empresa;
                    entiti.TELEFONOEMPRESA = obj.TelefonoEmpresa;
                    entiti.CARGO = obj.CargoEmpresa;
                    entiti.NITEMMPRESA = obj.NitEmpresa;
                    entiti.DIRECCIONEMPRESA = obj.DireccionEmpresa;
                    entiti.ID_TP_CIUDAD_EMPRESA = obj.IdCiudadEmpresa;
                    entiti.ID_TM_LABORAL = 1;// retorno id

                    Entidad.Add(entiti);
                    context.SaveChanges();
                    datosObj.Codigo = "200";
                }
            }
            catch (Exception ex)
            {
                datosObj.Mensaje = ex.Message;
                datosObj.Codigo = "500";
            }
            return datosObj;
        }
        public IModel ConsultaXId(int id)
        {
            Dtos.Laboral obj = new Dtos.Laboral();
            try
            {
                using (var context = new Datos.DBContext.ConvocatoriaModel())
                {
                    var resultado = from p in context.TM_LABORAL
                                       where p.ID_TM_HOJAVIDA == id && p.AUDIT_ELIMINADO == false
                                       select p;

                    Datos.Entities.TM_LABORAL Entity = resultado.FirstOrDefault<Datos.Entities.TM_LABORAL>();
                    if (Entity != null)
                    {
                        obj.IdHojaVida = Entity.ID_TM_HOJAVIDA;
                        obj.FechaIngreso = Convert.ToDateTime(Entity.FECHAINGRESO);
                        obj.FechaSalida = Convert.ToDateTime(Entity.FECHASALIDA);
                        obj.Empresa = Entity.EMPRESA;
                        obj.TelefonoEmpresa = Entity.TELEFONOEMPRESA;
                        obj.CargoEmpresa = Entity.CARGO;
                        obj.NitEmpresa = Entity.NITEMMPRESA;
                        obj.DireccionEmpresa = Entity.DIRECCIONEMPRESA;
                        obj.IdCiudadEmpresa = Entity.ID_TP_CIUDAD_EMPRESA;
                        obj.Id = Entity.ID_TM_LABORAL;

                        obj.Codigo = "200";
                    }
                    else
                    {
                        obj.Codigo = "404";
                    }
                }
            }
            catch (Exception ex)
            {
                obj.Mensaje = ex.Message;
                obj.Codigo = "500";
            }
            return obj;
        }
    }
}
