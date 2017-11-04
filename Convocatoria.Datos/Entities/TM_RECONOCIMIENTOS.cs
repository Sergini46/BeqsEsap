namespace Convocatoria.Datos.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONCURSOLINEAAUX.TM_RECONOCIMIENTOS")]
    public partial class TM_RECONOCIMIENTOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TM_RECONOCIMIENTOS { get; set; }

        public int ID_TM_HOJAVIDA { get; set; }

        public DateTime? FECHARECONOCIMIENTO { get; set; }

        public int ID_TP_TIPORECONOCIMIENTO { get; set; }

        public string DESCRIPCIONRECONOCIMIENTO { get; set; }

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

        public virtual TP_TIPORECONOCIMIENTO TP_TIPORECONOCIMIENTO { get; set; }
    }
}
