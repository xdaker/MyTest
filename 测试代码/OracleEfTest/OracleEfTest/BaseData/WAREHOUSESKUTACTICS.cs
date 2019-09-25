namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.WAREHOUSESKUTACTICS")]
    public partial class WAREHOUSESKUTACTICS
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal WAREHOUSESKUSYSNO { get; set; }

        public decimal ALLOCATIONSTRATEGYSYSNO { get; set; }

        [StringLength(64)]
        public string ALLOCATIONSTRATEGYCODE { get; set; }

        [StringLength(64)]
        public string ALLOCATIONSTRATEGYNAME { get; set; }

        public decimal PUTAWAYSTRATEGYSYSNO { get; set; }

        [StringLength(64)]
        public string PUTAWAYSTRATEGYCODE { get; set; }

        [StringLength(64)]
        public string PUTAWAYSTRATEGYNAME { get; set; }

        public decimal INLOCSYSNO { get; set; }

        [StringLength(64)]
        public string INLOC { get; set; }

        [StringLength(32)]
        public string PUTZONE { get; set; }

        public decimal PUTZONESYSNO { get; set; }

        [StringLength(32)]
        public string PUTLOCATION { get; set; }

        public decimal PUTLOCATIONSYSNO { get; set; }

        [StringLength(32)]
        public string CYCLECOUNTFEQ { get; set; }

        public DateTime? LASTCYCLECOUNT { get; set; }

        public decimal? REORDERPOINT { get; set; }

        public decimal? REORDERQTY { get; set; }

        public decimal ISNONTASK { get; set; }

        [StringLength(256)]
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

        public decimal HIGHVALUE { get; set; }

        [StringLength(32)]
        public string PICKZONE { get; set; }

        public decimal? PICKZONESYSNO { get; set; }

        [StringLength(100)]
        public string PICKZONENAME { get; set; }
    }
}
