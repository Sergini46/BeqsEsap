namespace Convocatoria.Datos.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONCURSOLINEAAUX.TM_CRONOGRAMA")]
    public partial class TM_CRONOGRAMA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TM_CRONOGRAMA()
        {
            TM_CRONOGRAMAACTIVIDAD = new HashSet<TM_CRONOGRAMAACTIVIDAD>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TM_CRONOGRAMA { get; set; }

        public int ID_TP_CONVOCATORIA { get; set; }

        public int ID_TP_ETAPA { get; set; }

        public bool? TIENECIERREETAPA { get; set; }

        public DateTime? FECHAINICIOETAPA { get; set; }

        public DateTime? FECHAFINETAPA { get; set; }

        public DateTime? FECHAINICIOEVALUACION { get; set; }

        public DateTime? FECHAFINEVALUACION { get; set; }

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

        public virtual TP_CONVOCATORIA TP_CONVOCATORIA { get; set; }

        public virtual TP_ETAPA TP_ETAPA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TM_CRONOGRAMAACTIVIDAD> TM_CRONOGRAMAACTIVIDAD { get; set; }
    }
}
