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
    #endregion
}