namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.CCTASK")]
    public partial class CCTASK
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal TASKID { get; set; }

        public decimal PLANID { get; set; }

        [Required]
        [StringLength(20)]
        public string BATCHTIME { get; set; }

        public decimal TYPE { get; set; }

        public decimal STATUS { get; set; }

        public decimal PRIORITY { get; set; }

        [Required]
        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [Required]
        [StringLength(32)]
        public string COMPANYCODE { get; set; }

        [Required]
        [StringLength(64)]
        public string LOCATIONCODE { get; set; }

        [StringLength(64)]
        public string ZONECODE { get; set; }

        [StringLength(64)]
        public string AREACODE { get; set; }

        [StringLength(64)]
        public string LPN { get; set; }

        [Required]
        [StringLength(100)]
        public string SKUCODE { get; set; }

        [Required]
        [StringLength(64)]
        public string LOTNUMBER { get; set; }

        public decimal? QTYCOUNT { get; set; }

        public decimal? QTYRECOUNT { get; set; }

        public decimal? CHECKMETHOD { get; set; }

        public decimal? TICKETNUMBER { get; set; }

        public decimal ISBLIND { get; set; }

        [StringLength(64)]
        public string ASSIGNUSER { get; set; }

        public DateTime? STARTTIME { get; set; }

        public DateTime? ENDTIME { get; set; }

        public DateTime? DEPOSITTIME { get; set; }

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

        public decimal LOCATIONSYSNO { get; set; }

        public decimal SKUSYSNO { get; set; }

        [Required]
        [StringLength(1024)]
        public string SKUDESCRIPTION { get; set; }

        public decimal UNITQTY { get; set; }

        [StringLength(64)]
        public string REASSIGNUSER { get; set; }

        public decimal? QTYCOUNTINV { get; set; }

        public decimal? QTYRECOUNTINV { get; set; }

        public decimal? QTYCOUNTDIFF { get; set; }

        public decimal? QTYRECOUNTDIFF { get; set; }

        public DateTime? RESTARTTIME { get; set; }

        public DateTime? REENDTIME { get; set; }

        [Required]
        [StringLength(64)]
        public string CCSEQ { get; set; }

        public decimal? ISAUTO { get; set; }
    }
}
