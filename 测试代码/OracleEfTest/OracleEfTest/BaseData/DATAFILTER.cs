namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.DATAFILTER")]
    public partial class DATAFILTER
    {
        [Key]
        public decimal SYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string CODE { get; set; }

        [Required]
        [StringLength(64)]
        public string NAME { get; set; }

        [Required]
        [StringLength(128)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        [Required]
        [StringLength(32)]
        public string COMPANYCODE { get; set; }

        [StringLength(128)]
        public string COMPANYNAME { get; set; }

        [StringLength(256)]
        public string FROMCLAUSE { get; set; }

        [StringLength(512)]
        public string WHERECLAUSE { get; set; }

        [StringLength(256)]
        public string ORDERBYCLAUSE { get; set; }

        [StringLength(512)]
        public string FULLSTATEMENT { get; set; }

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
