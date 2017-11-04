namespace Convocatoria.Datos.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONCURSOLINEAAUX.TM_CONVOCATORIACARGO")]
    public partial class TM_CONVOCATORIACARGO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TM_CONVOCATORIACARGO { get; set; }

        public int ID_TP_CONVOCATORIA { get; set; }

        public int ID_TP_CARGO { get; set; }

        public int ID_TP_CIUDAD { get; set; }

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

        public virtual TP_CARGO TP_CARGO { get; set; }

        public virtual TP_CIUDAD TP_CIUDAD { get; set; }

        public virtual TP_CONVOCATORIA TP_CONVOCATORIA { get; set; }
    }
}
