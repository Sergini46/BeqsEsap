namespace Convocatoria.Datos.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONCURSOLINEAAUX.TP_PERSONA")]
    public partial class TP_PERSONA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TP_PERSONA()
        {
            TM_HOJAVIDA = new HashSet<TM_HOJAVIDA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TP_PERSONA { get; set; }

        [StringLength(50)]
        public string IDENTIFICACION { get; set; }

        [StringLength(255)]
        public string NOMBRES { get; set; }

        [StringLength(255)]
        public string APELLIDOS { get; set; }

        [StringLength(255)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string TELEFONOFIJOCONTACTO { get; set; }

        [StringLength(50)]
        public string TELEFONOMOVILCONTACTO { get; set; }

        [StringLength(512)]
        public string DIRECCIONRESIDENCIA { get; set; }

        public int ID_TP_CIUDAD_RESIDENCIA { get; set; }

        public int ID_TP_GENERO { get; set; }

        public DateTime? FEHAEXPEDICIONIDENTIFICACION { get; set; }

        public int ID_TP_TIPODISCAPACIDAD { get; set; }

        [StringLength(2000)]
        public string DISCAPACIDADCOMENTARIOS { get; set; }

        public int ID_TP_CIUDAD_EXAMENES { get; set; }

        public DateTime? FECHANACIMIENTO { get; set; }

        public int ID_TP_CIUDAD_NACIMIENTO { get; set; }

        public int ID_TP_TIPOIDENTIFICACION { get; set; }

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
        public virtual ICollection<TM_HOJAVIDA> TM_HOJAVIDA { get; set; }

        public virtual TP_CIUDAD TP_CIUDAD { get; set; }

        public virtual TP_GENERO TP_GENERO { get; set; }

        public virtual TP_TIPODISCAPACIDAD TP_TIPODISCAPACIDAD { get; set; }

        public virtual TP_TIPOIDENTIFICACION TP_TIPOIDENTIFICACION { get; set; }
    }
}
