namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.CCPLAN")]
    public partial class CCPLAN
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal PLANID { get; set; }

        [StringLength(1024)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [Required]
        [StringLength(32)]
        public string COMPANYCODE { get; set; }

        public decimal ISCHANGERECORD { get; set; }

        public decimal CHANGEDAYS { get; set; }

        public decimal ISINVENTORYAGE { get; set; }

        public decimal INVENTORYAGEDAYS { get; set; }

        public decimal ISPICKTOPERCENTAGE { get; set; }

        public decimal? PERCENTAGE { get; set; }

        public decimal ISSKUCCRECORD { get; set; }

        public decimal ISDELETESAMETASK { get; set; }

        public decimal ISBLIND { get; set; }

        public decimal MAXRECORD { get; set; }

        public decimal ISCREATETICKET { get; set; }

        public decimal MAXTICKETRECORD { get; set; }

        public decimal TASKPRIORITY { get; set; }

        public decimal ENABLEFLAG { get; set; }

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

        public decimal WAREHOUSESYSNO { get; set; }

        [Required]
        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        public decimal COMPANYSYSNO { get; set; }

        [Required]
        [StringLength(128)]
        public string COMPANYNAME { get; set; }

        public decimal? SKUFILTERSYSNO { get; set; }

        [StringLength(128)]
        public string SKUFILTERNAME { get; set; }

        public decimal? LOCATIONFILTERSYSNO { get; set; }

        [StringLength(128)]
        public string LOCATIONFILTERNAME { get; set; }
    }
}
