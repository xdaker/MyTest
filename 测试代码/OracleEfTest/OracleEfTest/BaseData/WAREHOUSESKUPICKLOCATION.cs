namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.WAREHOUSESKUPICKLOCATION")]
    public partial class WAREHOUSESKUPICKLOCATION
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal WAREHOUSESKUSYSNO { get; set; }

        public decimal LOCATIONSYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string LOCATIONCODE { get; set; }

        public decimal? ZONESYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string ZONECODE { get; set; }

        [StringLength(50)]
        public string UMCODE { get; set; }

        public decimal ENABLEFLAG { get; set; }

        public DateTime? ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }
    }
}
