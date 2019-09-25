namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_PACKSPEC")]
    public partial class WMS_PACKSPEC
    {
        [Key]
        [StringLength(36)]
        public string PACKSPECID { get; set; }

        [StringLength(36)]
        public string MATERIALSID { get; set; }

        [StringLength(32)]
        public string PACKMODEL { get; set; }

        [StringLength(36)]
        public string INCONTAINERTYPEID { get; set; }

        public decimal? QUANTITYPERPACK { get; set; }

        public decimal? LENGTH { get; set; }

        public decimal? WIDTH { get; set; }

        public decimal? HIGH { get; set; }

        [StringLength(8)]
        public string LENGTHUNIT { get; set; }

        public decimal? WEIGHTPERPACK { get; set; }

        [StringLength(8)]
        public string WEIGHTUNIT { get; set; }

        [StringLength(8)]
        public string UNIT { get; set; }

        public decimal? FITCOUNT { get; set; }

        [StringLength(8)]
        public string STOCKPILEUNIT { get; set; }

        [StringLength(32)]
        public string PACKBARCODE { get; set; }

        [StringLength(36)]
        public string OUTCONTAINERTYPEID { get; set; }

        [StringLength(32)]
        public string STOCKMETHOD { get; set; }

        public int? STATUS { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public int? ATTRIBUTE1 { get; set; }

        [StringLength(32)]
        public string ATTRIBUTE2 { get; set; }

        [StringLength(80)]
        public string ATTRIBUTE3 { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(50)]
        public string CREATEUSERID { get; set; }

        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        [StringLength(50)]
        public string MODIFYUSERID { get; set; }

        [StringLength(50)]
        public string MODIFYUSERNAME { get; set; }
    }
}
