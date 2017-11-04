namespace Convocatoria.Datos.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONCURSOLINEAAUX.TM_HOJAVIDA")]
    public partial class TM_HOJAVIDA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TM_HOJAVIDA()
        {
            TM_ACADEMICA = new HashSet<TM_ACADEMICA>();
            TM_DOCENTE = new HashSet<TM_DOCENTE>();
            TM_EXPERIENCIAOTROS = new HashSet<TM_EXPERIENCIAOTROS>();
            TM_HOJAVIDAOTRASEXPERIENCIAS = new HashSet<TM_HOJAVIDAOTRASEXPERIENCIAS>();
            TM_INSCRIPCIONCONVOCATORIA = new HashSet<TM_INSCRIPCIONCONVOCATORIA>();
            TM_INVESTIGACION = new HashSet<TM_INVESTIGACION>();
            TM_LABORAL = new HashSet<TM_LABORAL>();
            TM_PUBLICACIONES = new HashSet<TM_PUBLICACIONES>();
            TM_RECONOCIMIENTOS = new HashSet<TM_RECONOCIMIENTOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TM_HOJAVIDA { get; set; }

        public int ID_TP_PERSONA { get; set; }

        public DateTime? FECHAULTIMAACTUALIZACION { get; set; }

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
        public virtual ICollection<TM_ACADEMICA> TM_ACADEMICA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TM_DOCENTE> TM_DOCENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TM_EXPERIENCIAOTROS> TM_EXPERIENCIAOTROS { get; set; }

        public virtual TP_PERSONA TP_PERSONA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TM_HOJAVIDAOTRASEXPERIENCIAS> TM_HOJAVIDAOTRASEXPERIENCIAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TM_INSCRIPCIONCONVOCATORIA> TM_INSCRIPCIONCONVOCATORIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TM_INVESTIGACION> TM_INVESTIGACION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TM_LABORAL> TM_LABORAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TM_PUBLICACIONES> TM_PUBLICACIONES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TM_RECONOCIMIENTOS> TM_RECONOCIMIENTOS { get; set; }
    }
}
