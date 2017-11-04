namespace Convocatoria.Datos.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONCURSOLINEAAUX.TI_ANEXOHOJAVIDA")]
    public partial class TI_ANEXOHOJAVIDA
    {
        [Key]
        public decimal ID_TI_ANEXOHOJAVIDA { get; set; }

        public decimal ID_TP_TIPODOCUMENTOANEXO { get; set; }

        public decimal ID_TM_HOJAVIDA { get; set; }

        [StringLength(512)]
        public string NOMBRECOMPLETO { get; set; }

        [StringLength(512)]
        public string NOMBRE { get; set; }

        [StringLength(5)]
        public string EXTENSION { get; set; }

        [StringLength(2000)]
        public string RUTACOMPLETA { get; set; }

        public byte[] ARCHIVO { get; set; }

        public DateTime? FECHACARGUE { get; set; }

        [StringLength(50)]
        public string SECCION { get; set; }

        public DateTime AUDIT_FECHACREACION { get; set; }

        public decimal AUDIT_USUARIO { get; set; }

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
    }
}
