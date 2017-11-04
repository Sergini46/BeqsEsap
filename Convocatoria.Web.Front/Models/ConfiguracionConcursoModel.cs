using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Convocatoria.Web.Front.Models
{
    #region Consultas
    public class ConfiguracionConcursoModel
    {
        public int Vista { get; set; }
        public int IdConcurso { get; set; }
        public string NombreConcurso { get; set; }
        public List<ListConfiguracionConcurso> ListConcursos { get; set; }
    }
    public class ListConfiguracionConcurso
    {
        public int IdConcurso { get; set; }
        public string CodigoConcurso { get; set; }
        public string NombreConcurso { get; set; }
    }
    #endregion

    #region Ponderacion
    public class PonderacionModel
    {
        public int PonderacionPorcentajePruebas { get; set; }
        public int PonderacionPorcentajeAntecedentes { get; set; }
        public List<ListPruebas> ListPruebas { get; set; }
        public int PorcentajePrueba { get; set; }
        public int PuntosMaximoPrueba { get; set; }
        public List<ListPruebasPonderacion> ListPruebasPonderacion { get; set; }
        public int PorcentajeEstudio { get; set; }
        public int PuntosMaximoEstudio { get; set; }
        public int PorcentajeExperiencia { get; set; }
        public int PuntosMaximoExperiencia { get; set; }
        public List<ListEstudios> ListEstudios { get; set; }
        public List<ListEstudios> ListEstudiosNoFormal { get; set; }
        public List<ListAntecedentesPonderacion> ListAntecedentesPonderacionEstudios { get; set; }
        public List<ListAntecedentesPonderacion> ListAntecedentesPonderacionEstudiosNoFormal { get; set; }
    }
    public class ListAntecedentesPonderacion
    {
        public int IdEstudio { get; set; }
        public string NombreEstudio { get; set; }
        public int PuntosMaximo { get; set; }

    }
    public class ListPruebasPonderacion
    {
        public int IdPrueba { get; set; }
        public string NombrePrueba { get; set; }
        public int Porcentaje { get; set; }
        public int PuntosMaximoPrueba { get; set; }
    }
    #endregion

    #region Otros parametros

    public class OtrosParametros
    {
        public List<ListCiudades> ListCiudades { get; set; }
        public List<ListCiudades> DdlCiudades { get; set; }
        //pendiente el adjunto del documento
    }
    #endregion

    #region Modulos
    public class ModulosModel
    {
        public int IdModulo { get; set; }
        public List<ListModulos> ListModulo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public List<ListModulosExistentes> ListModulosExistentes { get; set; }
    }
    public class ListModulosExistentes
    {
        public int Id { get; set; }
        public int IdModulo { get; set; }
        public string NombreModulo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
    #endregion

    #region HojaDeVida
    public class ConfiguracionHojaVidaModel
    {
        public List<ListSeccion> ListSeccion { get; set; }
        public List<ListSeccion> DdlSeccion { get; set; }
        public List<ListRequisitos> ListRequisitos { get; set; }
        public List<ListEquivalencias> ListEquivalencias { get; set; }
        public List<ListRequisitoEquivalencia> ListRequisitoEquivalencia { get; set; }
    }
    public class ListRequisitoEquivalencia
    {
        public int Id { get; set; }
        public int IdRequisito { get; set; }
        public string NombreRequisito { get; set; }
        public int IdEquivalencia { get; set; }
        public string NombreEquivalencia { get; set; }
    }
    #endregion

    #region Evaluacion
    public class EvaluacionModel
    {
        public List<ListFases> ListFases { get; set; }
        public List<ListSeleccion> ListSeleccion { get; set; }
        public List<ListAspirantes> ListAspirantes { get; set; }
        public List<ListLugares> ListLugares { get; set; }
        public List<ListPruebas> ListPruebas { get; set; }
        public List<ListSalones> ListSalones { get; set; }
        public DateTime FechaCitacion { get; set; }
        public DateTime FechaPresentacion { get; set; }
        public List<ListCitaciones> ListCitaciones { get; set; }
    }
    public class ListSeleccion
    {
        public int IdSeleccion { get; set; }
        public int IdCiudad { get; set; }
        public string NombreCiudad { get; set; }
        public string Admitidos { get; set; }
        public string Pendientes { get; set; }
    }
    public class ListCitaciones
    {
        public int IdSalon { get; set; }
        public string NombreSalon { get; set; }
        public int IdLugar { get; set; }
        public string NombreLugar { get; set; }
        public int IdPrueba { get; set; }
        public string NombrePrueba { get; set; }
        public int IdAspirante { get; set; }
        public string NombreAspirante { get; set; }
        public int IdCiudad { get; set; }
        public string NombreCiudad { get; set; }
    }
    #endregion

    #region Cronograma
    public class CronogramaModel
    {
        public List<ListEtapas> ListEtapas { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaInicioEvaluacion { get; set; }
        public DateTime FechaFinEvaluacion { get; set; }
        public List<ListCronograma> ListCronograma { get; set; }
        public List<ListSubEtapas> ListSubEtapas { get; set; }
        public DateTime FechaInicioSub { get; set; }
        public DateTime FechaFinSub { get; set; }
        public List<ListSubEtapaCronograma> ListSubEtapaCronograma { get; set; }
    }
    public class ListCronograma
    {
        public int Id { get; set; }
        public int IdEtapa { get; set; }
        public string NombreEtapa { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaInicioEvaluacion { get; set; }
        public DateTime FechaFinEvaluacion { get; set; }
    }
    public class ListSubEtapaCronograma
    {
        public int Id { get; set; }
        public int IdSubEtapa { get; set; }
        public string NombreSubEtapa { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }

    #endregion

    #region Cargos
    public class CargosModel
    {
        public List<ListCargosExistentes> ListCargosExistentes { get; set; }
        public List<ListCargos> ListCargos { get; set; }
        public List<ListMunicipios> ListMunicipios { get; set; }
    }
    public class ListCargosExistentes
    {
        public int IdCargoMunicipio { get; set; }
        public int IdMunicipio { get; set; }
        public string NombreMunicipio { get; set; }
        public int IdCargo { get; set; }
        public string NombreCargo { get; set; }
    }
    #endregion

    #region Parametricos
    public class ListCargos
    {
        public int IdCargo { get; set; }
        public string NombreCargo { get; set; }
    }
    public class ListMunicipios
    {
        public int IdMunicipio { get; set; }
        public string NombreMunicipio { get; set; }
    }
    public class ListEtapas
    {
        public int IdEtapa { get; set; }
        public string NombreEtapa { get; set; }
    }
    public class ListSubEtapas
    {
        public int IdSubEtapa { get; set; }
        public string NombreSubEtapa { get; set; }
    }
    public class ListSalones
    {
        public int IdSalon { get; set; }
        public string NombreSalon { get; set; }
    }
    public class ListLugares
    {
        public int IdLugar { get; set; }
        public string NombreLugar { get; set; }
    }
    public class ListPruebas
    {
        public int IdPrueba { get; set; }
        public string NombrePrueba { get; set; }
    }
    public class ListFases
    {
        public int IdFase { get; set; }
        public string NombreFase { get; set; }
    }
    public class ListAspirantes
    {
        public int IdAspirante { get; set; }
        public string NombreAspirante { get; set; }
    }
    public class ListSeccion
    {
        public int IdSeccion { get; set; }
        public string NombreSeccion { get; set; }
    }
    public class ListRequisitos
    {
        public int IdRequisito { get; set; }
        public string NombreRequisito { get; set; }
    }
    public class ListEquivalencias
    {
        public int IdEquivalencia { get; set; }
        public string NombreEquivalencia { get; set; }
    }
    public class ListModulos
    {
        public int IdModulo { get; set; }
        public string NombreModulo { get; set; }
    }

    public class ListEstudios
    {
        public int IdEstudio { get; set; }
        public string NombreEstudio { get; set; }
    }
    public class ListCiudades
    {
        public int IdCiudad { get; set; }
        public string NombreCiudad { get; set; }
    }
    #endregion
}