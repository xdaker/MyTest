namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_MATERIALS")]
    public partial class WMS_MATERIALS
    {
        [Key]
        [StringLength(36)]
        public string MATERIALSID { get; set; }

        [StringLength(36)]
        public string MATERIALSSORTSID { get; set; }

        [StringLength(32)]
        public string MATERIALSCODE { get; set; }

        [StringLength(80)]
        public string MATERIALSCNNAME { get; set; }

        [StringLength(80)]
        public string MATERIALSENNAME { get; set; }

        [StringLength(10)]
        public string UNIT { get; set; }

        [StringLength(32)]
        public string MODEL { get; set; }

        public decimal? STORAGEUPPERLIMIT { get; set; }

        public decimal? STORAGELOWERLIMIT { get; set; }

        public decimal? SAFESTORAGE { get; set; }

        public int? STORAGEDATELIMIT { get; set; }

        public int? USEFULLIFE { get; set; }

        public int? MATURITYLIMIT { get; set; }

        public int? STATUS { get; set; }

        [StringLength(48)]
        public string PYCODE { get; set; }

        public int? ISCHANGEPACKAGE { get; set; }

        [StringLength(36)]
        public string SYNCSYSTEMID { get; set; }

        public int? SYNCTYPE { get; set; }

        public DateTime? SYNCDATE { get; set; }

        public int? QUALITYCHECKTYPE { get; set; }

        public decimal? RANDOMRATIO { get; set; }

        public decimal? QUALIFIEDRATIO { get; set; }

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
