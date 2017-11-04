namespace Convocatoria.Datos.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONCURSOLINEAAUX.TP_CARGO")]
    public partial class TP_CARGO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TP_CARGO()
        {
            TM_CONVOCATORIACARGO = new HashSet<TM_CONVOCATORIACARGO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TP_CARGO { get; set; }

        [StringLength(256)]
        public string NOMBRE { get; set; }

        [StringLength(50)]
        public string CODIGO { get; set; }

        [StringLength(2000)]
        public string DESCRIPCION { get; set; }

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
    }
}
