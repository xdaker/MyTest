namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_REBUILDAPPLYMAIN")]
    public partial class WMS_REBUILDAPPLYMAIN
    {
        [Key]
        [StringLength(32)]
        public string REBUILDAPPLYMAINID { get; set; }

        public DateTime? DOWNLOADTIME { get; set; }

        [StringLength(36)]
        public string SUPPLIERID { get; set; }

        public int? ORDERPROCESS { get; set; }

        public int? CREATEORDERTYPE { get; set; }

        public int? ISAUDITING { get; set; }

        [StringLength(36)]
        public string AUDITUSERID { get; set; }

        public DateTime? AUDITDATE { get; set; }

        [StringLength(36)]
        public string SYNCSYSTEMID { get; set; }

        public int? SYNCTYPE { get; set; }

        public DateTime? SYNCDATE { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public int? ATTRIBUTE1 { get; set; }

        [StringLength(32)]
        public string ATTRIBUTE2 { get; set; }

        [StringLength(80)]
        public string ATTRIBUTE3 { get; set; }

        [StringLength(80)]
        public string ATTRIBUTE4 { get; set; }

        [StringLength(80)]
        public string ATTRIBUTE5 { get; set; }

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
