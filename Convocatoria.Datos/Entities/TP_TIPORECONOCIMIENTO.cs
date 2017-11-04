namespace Convocatoria.Datos.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONCURSOLINEAAUX.TP_TIPORECONOCIMIENTO")]
    public partial class TP_TIPORECONOCIMIENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TP_TIPORECONOCIMIENTO()
        {
            TM_RECONOCIMIENTOS = new HashSet<TM_RECONOCIMIENTOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TP_TIPORECONOCIMIENTO { get; set; }

        [StringLength(256)]
        public string NOMBRE { get; set; }

        [StringLength(50)]
        public string CODIGO { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TM_RECONOCIMIENTOS> TM_RECONOCIMIENTOS { get; set; }
    }
}
