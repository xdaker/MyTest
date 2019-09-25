namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_CHECKPLANDETAIL")]
    public partial class WMS_CHECKPLANDETAIL
    {
        [Key]
        [StringLength(36)]
        public string CHECKPLANDETAILID { get; set; }

        [StringLength(32)]
        public string CHECKPLANMAINID { get; set; }

        [StringLength(36)]
        public string SUPPLIERID { get; set; }

        [StringLength(36)]
        public string MATERIALSID { get; set; }

        [StringLength(36)]
        public string PACKSPECID { get; set; }

        [StringLength(32)]
        public string PRODUCTBATCH { get; set; }

        public int? MATERIALSATTRIBUTE { get; set; }

        public int? MATERIALSSTATUS { get; set; }

        [StringLength(32)]
        public string SUPPLIERBATCH { get; set; }

        public decimal? PLANCHECKQUANTITY { get; set; }

        public decimal? ACTUALCHECKQUANTITY { get; set; }

        [StringLength(36)]
        public string PRODUCTIONID { get; set; }

        [StringLength(36)]
        public string SYNCSYSTEMDETAILID { get; set; }

        public int? SYNCTYPE { get; set; }

        public DateTime? SYNCDATE { get; set; }

        public int? ISPROCESS { get; set; }

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
