using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Convocatoria.Datos.Entities;

namespace Convocatoria.Web.Front.Models
{
    public class HojaDeVidaModel
    {
        public int Vista { get; set; }
        public List<ListTipoIdentificacion> ListTipoIdentificacion { get; set; }
        public int? DdlIdTipoIdentificacion { get; set; }
        public List<ListGenero> ListGenero { get; set; }
        public int? DdlIdGenero { get; set; }
        public List<ListPais> ListPais { get; set; }
        public int? DdlIdPais { get; set; }
        public List<ListDepartamento> ListDepartamento { get; set; }
        public int? DdlIdDepartamento { get; set; }
        public List<ListCiudad> ListCiudad { get; set; }
        public int? DdlIdCiudad { get; set; }
        public List<ListDiscapacidad> ListDiscapacidad { get; set; }
        public int? ddlIdDiscapacidad { get; set; }

        #region DatosPersonales
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaExpedicion { get; set; }
        public List<ListPais> ListPaisRecidencia { get; set; }
        public int? ddlIdPaisRecidencia { get; set; }
        public List<ListDepartamento> ListDepartamentoRecidencia { get; set; }
        public int? ddlIdDepartamentoRecidencia { get; set; }
        public List<ListCiudad> ListCiudadRecidencia { get; set; }
        public int? ddlIdCiudadRecidencia { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoFijo2 { get; set; }
        public string Email { get; set; }
        public string RequiereApoyo { get; set; }
        #endregion

        #region Estudios Formales
        public List<ListPais> ListPaisDondeEstudio { get; set; }
        public int? ddlIdPaisDondeEstudio { get; set; }
        public List<ListDepartamento> ListDepartamentoDondeEstudio { get; set; }
        public int? ddlIdDepartamentoDondeEstudio { get; set; }
        public List<ListCiudad> ListCiudadDondeEstudio { get; set; }
        public int? ddlIdCiudadDondeEstudio { get; set; }
        public List<ListInstitucion> ListInstitucionDondeEstudio { get; set; }
        public int? ddlIdInstitucionDondeEstudio { get; set; }
        public string TipoDeEstudio { get; set; }
        public string NombreTitulo { get; set; }
        public Boolean TerminoEstudios { get; set; }
        public DateTime FechaTerminacionEstudios { get; set; }
        public DateTime FechaUltimoSemestre { get; set; }
        public DateTime FechaFormalizacionSemestre { get; set; }
        #endregion


        #region Estudios No Formales
        
        public List<ListPais> ListPaisDondeEstudioNF { get; set; }
        public int? ddlIdPaisDondeEstudioNF { get; set; }
        public List<ListDepartamento> ListDepartamentoDondeEstudioNF { get; set; }
        public int? ddlIdDepartamentoDondeEstudioNF { get; set; }
        public List<ListCiudad> ListCiudadDondeEstudioNF { get; set; }
        public int? ddlIdCiudadDondeEstudioNF { get; set; }
        public List<ListInstitucion> ListInstitucionDondeEstudioNF { get; set; }
        public int? ddlIdInstitucionDondeEstudioNF { get; set; }
        public string TipoDeEstudioNF { get; set; }
        public string NombreTituloNF { get; set; }
        public int IntensidadHoraria { get; set; }
        public int AnnoTerminacion { get; set; }
        #endregion

    }

    #region obj parametricos
    public class ListDiscapacidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    public class ListPais
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    public class ListCiudad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    public class ListDepartamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    public class ListGenero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    public class ListTipoIdentificacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class ListInstitucion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
    #endregion
}