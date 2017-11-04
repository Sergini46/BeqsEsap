namespace Convocatoria.Datos.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONCURSOLINEAAUX.TM_PUBLICACIONES")]
    public partial class TM_PUBLICACIONES
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TM_PUBLICACIONES { get; set; }

        public int ID_TM_HOJAVIDA { get; set; }

        public DateTime? FECHAPUBLICACION { get; set; }

        public int ID_TP_TIPOPUBLICACION { get; set; }

        [StringLength(512)]
        public string NOMBREPUBLICACION { get; set; }

        public string DESCRIPCIONPUBLICACION { get; set; }

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

        public virtual TP_TIPOPUBLICACION TP_TIPOPUBLICACION { get; set; }
    }
}
