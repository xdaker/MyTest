namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_STOCKPILE")]
    public partial class WMS_STOCKPILE
    {
        [Key]
        [StringLength(36)]
        public string STOCKPILEID { get; set; }

        [StringLength(36)]
        public string LOCATIONID { get; set; }

        [StringLength(36)]
        public string CONTAINERCODE { get; set; }

        [StringLength(36)]
        public string MATERIALSID { get; set; }

        [StringLength(32)]
        public string PRODUCTBATCH { get; set; }

        public decimal? QUANTITY { get; set; }

        [StringLength(36)]
        public string PACKSPECID { get; set; }

        public int? MATERIALSSTATUS { get; set; }

        public int? MATERIALSATTRIBUTE { get; set; }

        public int? ISFULL { get; set; }

        public DateTime? PRODUCEDATE { get; set; }

        public DateTime? MATUREDATE { get; set; }

        public DateTime? INTIME { get; set; }

        public DateTime? LASTTIME { get; set; }

        [StringLength(50)]
        public string SUPPLIERID { get; set; }

        [StringLength(36)]
        public string PRODUCTID { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public int? ATTRIBUTE1 { get; set; }

        [StringLength(36)]
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

        [StringLength(36)]
        public string ATTRIBUTE4 { get; set; }

        [StringLength(36)]
        public string ATTRIBUTE5 { get; set; }
    }
}
