namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_QUALITYCHECK")]
    public partial class WMS_QUALITYCHECK
    {
        [Key]
        [StringLength(32)]
        public string QUALITYCHECKID { get; set; }

        [StringLength(32)]
        public string QUALITYCHECKNUM { get; set; }

        [StringLength(32)]
        public string INPLANID { get; set; }

        [StringLength(36)]
        public string INPLANDETAILID { get; set; }

        public DateTime? DOWNLOADTIME { get; set; }

        [StringLength(28)]
        public string CONTAINERCODE { get; set; }

        [StringLength(36)]
        public string MATERIALSID { get; set; }

        [StringLength(32)]
        public string PRODUCTBATCH { get; set; }

        [StringLength(36)]
        public string SUPPLIERID { get; set; }

        public int? QUALITYCHECKTYPE { get; set; }

        public decimal? QUALITYCHECKQUANTITY { get; set; }

        public int? ISPROCESS { get; set; }

        public DateTime? QUALITYCHECKDATE { get; set; }

        public int? CONCLUSION { get; set; }

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
