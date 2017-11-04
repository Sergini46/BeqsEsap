namespace Convocatoria.Datos.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONCURSOLINEAAUX.TP_CONVOCATORIA")]
    public partial class TP_CONVOCATORIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TP_CONVOCATORIA()
        {
            TM_CONVOCATORIACARGO = new HashSet<TM_CONVOCATORIACARGO>();
            TM_CONVOCATORIAMODULO = new HashSet<TM_CONVOCATORIAMODULO>();
            TM_CRONOGRAMA = new HashSet<TM_CRONOGRAMA>();
            TM_INSCRIPCIONCONVOCATORIA = new HashSet<TM_INSCRIPCIONCONVOCATORIA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TP_CONVOCATORIA { get; set; }

        [StringLength(512)]
        public string NOMBRE { get; set; }

        [StringLength(512)]
        public string URL_CMS { get; set; }

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
        public virtual ICollection<TM_CONVOCATORIACARGO> TM_CONVOCATORIACARGO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TM_CONVOCATORIAMODULO> TM_CONVOCATORIAMODULO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TM_CRONOGRAMA> TM_CRONOGRAMA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TM_INSCRIPCIONCONVOCATORIA> TM_INSCRIPCIONCONVOCATORIA { get; set; }
    }
}
