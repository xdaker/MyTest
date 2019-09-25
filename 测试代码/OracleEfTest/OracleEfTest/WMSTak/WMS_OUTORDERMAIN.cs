namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_OUTORDERMAIN")]
    public partial class WMS_OUTORDERMAIN
    {
        [Key]
        [StringLength(32)]
        public string OUTORDERID { get; set; }

        [StringLength(48)]
        public string DELIVERYID { get; set; }

        [StringLength(36)]
        public string RECEIVECOMPANYID { get; set; }

        [StringLength(32)]
        public string ORDERID { get; set; }

        [StringLength(36)]
        public string UNLOADID { get; set; }

        public DateTime? DOWNLOADTIME { get; set; }

        public int? ISAUDITING { get; set; }

        public int? ORDERPROCESS { get; set; }

        public int? CREATEORDERTYPE { get; set; }

        [StringLength(36)]
        public string SYNCSYSTEMID { get; set; }

        public int? SYNCTYPE { get; set; }

        public DateTime? SYNCDATE { get; set; }

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
