namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.WAVE")]
    public partial class WAVE
    {
        [Key]
        public decimal SYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string WAVENUM { get; set; }

        public decimal WAVETEMPLATESYSNO { get; set; }

        [StringLength(32)]
        public string WAVETEMPLATECODE { get; set; }

        [StringLength(128)]
        public string WAVETEMPLATEDESC { get; set; }

        public decimal DISPATCHNODESYSNO { get; set; }

        [StringLength(32)]
        public string DISPATCHNODECODE { get; set; }

        [StringLength(128)]
        public string DISPATCHNODEDESC { get; set; }

        public decimal WAREHOUSESYSNO { get; set; }

        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        public decimal CREATEMODE { get; set; }

        public decimal WAVESTATUS { get; set; }

        [StringLength(512)]
        public string COMMENTS { get; set; }

        public DateTime ROWCREATEDATE { get; set; }

        [Required]
        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [Required]
        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime ROWMODIFYDATE { get; set; }

        [Required]
        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [Required]
        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        [StringLength(32)]
        public string COLLECTUSERID { get; set; }

        [StringLength(64)]
        public string COLLECTUSERNAME { get; set; }

        public DateTime? COLLECTDATE { get; set; }

        public decimal NUM { get; set; }

        public decimal RV { get; set; }
    }
}
