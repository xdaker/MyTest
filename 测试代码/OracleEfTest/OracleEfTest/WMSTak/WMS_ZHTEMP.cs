namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_ZHTEMP")]
    public partial class WMS_ZHTEMP
    {
        [Key]
        [StringLength(36)]
        public string ZHTEMPID { get; set; }

        [StringLength(32)]
        public string OUTCODE { get; set; }

        [StringLength(28)]
        public string JHCONTAINERCODE { get; set; }

        [StringLength(28)]
        public string CONTAINERCODE { get; set; }

        [StringLength(36)]
        public string LOCATIONID { get; set; }

        public int? OUTMODE { get; set; }

        [StringLength(32)]
        public string OUTPLANID { get; set; }

        [StringLength(36)]
        public string OUTPLANDETAILID { get; set; }

        public decimal? OUTQUANTITY { get; set; }

        public int? FLAG { get; set; }

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

        [StringLength(36)]
        public string STOCKPILEID { get; set; }
    }
}
