namespace Convocatoria.Datos.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONCURSOLINEAAUX.TM_CRONOGRAMAACTIVIDAD")]
    public partial class TM_CRONOGRAMAACTIVIDAD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TM_CRONOGRAMAACTIVIDAD { get; set; }

        public int ID_TP_ACTIVIDAD { get; set; }

        public int ID_TM_CRONOGRAMA { get; set; }

        public DateTime? FECHAINICIO { get; set; }

        public DateTime? FECHAFIN { get; set; }

        public DateTime AUDIT_FECHACREACION { get; set; }

        public int AUDIT_USUARIO { get; set; }

        [Required]
        [StringLength(256)]
        public string AUDIT_IP { get; set; }

        [Required]
        [StringLength(256)]
        public string AUDIT_NAVEGADOR { get; set; }

        [Required]
        [StringLength(256)]
        public string AUDIT_SISTEMAOPERATIVO { get; set; }

        [Required]
        [StringLength(256)]
        public string AUDIT_ACCION { get; set; }

        public bool AUDIT_ELIMINADO { get; set; }

        public virtual TM_CRONOGRAMA TM_CRONOGRAMA { get; set; }

        public virtual TP_ACTIVIDAD TP_ACTIVIDAD { get; set; }
    }
}
