namespace Convocatoria.Datos.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONCURSOLINEAAUX.TM_ACADEMICA")]
    public partial class TM_ACADEMICA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TM_ACADEMICA { get; set; }

        public int ID_TM_HOJAVIDA { get; set; }

        public DateTime? FECHAGRADO { get; set; }

        public int ID_TP_CIUDAD_ESTUDIO { get; set; }

        public int ID_TP_TIPOFORMACION { get; set; }

        public int ID_TP_ENTIDADEDUCATIVA { get; set; }

        [StringLength(512)]
        public string TITULOOBTENIDO { get; set; }

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

        public virtual TP_TIPOFORMACION TP_TIPOFORMACION { get; set; }
    }
}
