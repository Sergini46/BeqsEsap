namespace Convocatoria.Datos.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONCURSOLINEAAUX.TM_DOCENTE")]
    public partial class TM_DOCENTE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TM_DOCENTE { get; set; }

        public int ID_TM_HOJAVIDA { get; set; }

        public DateTime? FECHAINGRESO { get; set; }

        public int ID_TP_ENTIDADEDUCATIVA { get; set; }

        public int ID_TP_TIPOVINCULACION { get; set; }

        public int? HORASMENSUALES { get; set; }

        [StringLength(50)]
        public string TELEFONOENTIDADEDUCATIVA { get; set; }

        [StringLength(512)]
        public string DIRECCIONENTIDADEDUCATIVA { get; set; }

        public int ID_TP_CIUDAD_ENTIDADEDUCATIVA { get; set; }

        public DateTime? FECHATERMINACION { get; set; }

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

        public virtual TM_HOJAVIDA TM_HOJAVIDA { get; set; }

        public virtual TP_CIUDAD TP_CIUDAD { get; set; }

        public virtual TP_ENTIDADEDUCATIVA TP_ENTIDADEDUCATIVA { get; set; }

        public virtual TP_TIPOVINCULACION TP_TIPOVINCULACION { get; set; }
    }
}
