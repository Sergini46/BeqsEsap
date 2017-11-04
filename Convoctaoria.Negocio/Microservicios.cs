using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convocatoria.Datos.Entities;
using Convocatoria.Datos.DBContext;

namespace Convocatoria.Negocio
{
    public class Microservicios
    {
        public List<TP_PAIS> Pais_Lista()
        {

            List<TP_PAIS> Respuesta = null;
            using (var db = new ConvocatoriaModel())
            {
                var Resp = from c in db.TP_PAIS select c;
                Respuesta = Resp.ToList();
            }
            return Respuesta;

        }
        public List<TP_DEPARTAMENTO> Departamento_Lista()//(ref int CodigoError, ref string MensajeError)
        {

            List<TP_DEPARTAMENTO> Respuesta = null;
            using (var db = new ConvocatoriaModel())
            {
                var Resp = from c in db.TP_DEPARTAMENTO select c;
                Respuesta = Resp.ToList();
            }
            return Respuesta;

        }

        public List<TP_CIUDAD> Ciudad_Lista()//(ref int CodigoError, ref string MensajeError)
        {

            List<TP_CIUDAD> Respuesta = null;
            using (var db = new ConvocatoriaModel())
            {
                var Resp = from c in db.TP_CIUDAD select c;
                Respuesta = Resp.ToList();
            }
            return Respuesta;

        }


        public List<TP_TIPOIDENTIFICACION> TpoIdentficacion_Lista()//(ref int CodigoError, ref string MensajeError)
        {

            List<TP_TIPOIDENTIFICACION> Respuesta = null;
            using (var db = new ConvocatoriaModel())
            {
                var Resp = from c in db.TP_TIPOIDENTIFICACION select c;
                Respuesta = Resp.ToList();
            }
            return Respuesta;

        }

        public List<TP_GENERO> Genero_Lista()//(ref int CodigoError, ref string MensajeError)
        {

            List<TP_GENERO> Respuesta = null;
            using (var db = new ConvocatoriaModel())
            {
                var Resp = from c in db.TP_GENERO select c;
                Respuesta = Resp.ToList();
            }
            return Respuesta;

        }


        public List<TP_TIPOFORMACION> TipoFormacion_Lista(ref int CodigoError, ref string MensajeError)
        {

            List<TP_TIPOFORMACION> Respuesta = null;
            using (var db = new ConvocatoriaModel())
            {
                var Resp = from c in db.TP_TIPOFORMACION select c;
                Respuesta = Resp.ToList();
            }
            return Respuesta;

        }

        public List<TP_ENTIDADEDUCATIVA> EntidadEducativa_Lista(ref int CodigoError, ref string MensajeError)
        {

            List<TP_ENTIDADEDUCATIVA> Respuesta = null;
            using (var db = new ConvocatoriaModel())
            {
                var Resp = from c in db.TP_ENTIDADEDUCATIVA select c;
                Respuesta = Resp.ToList();
            }
            return Respuesta;

        }
    }
}
