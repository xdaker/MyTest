namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.VIEW_OUTTASKJHDETAI")]
    public partial class VIEW_OUTTASKJHDETAI
    {
        [Key]
        [StringLength(36)]
        public string OUTDETAILID { get; set; }

        [StringLength(32)]
        public string OUTPLANID { get; set; }

        [StringLength(32)]
        public string OUTCODE { get; set; }

        [StringLength(48)]
        public string DELIVERYID { get; set; }

        public decimal? OUTQUANTITY { get; set; }

        [StringLength(80)]
        public string MATERIALSCNNAME { get; set; }

        [StringLength(32)]
        public string MATERIALSCODE { get; set; }

        [StringLength(32)]
        public string PACKMODEL { get; set; }

        [StringLength(8)]
        public string CONTAINERCODE { get; set; }

        [StringLength(16)]
        public string LOCATIONCODE { get; set; }

        [StringLength(32)]
        public string PRODUCTBATCH { get; set; }

        public int? MATERIALSATTRIBUTE { get; set; }

        public int? MATERIALSSTATUS { get; set; }

        [StringLength(64)]
        public string BUSINESSNAME { get; set; }

        [StringLength(32)]
        public string SUPPLIERBATCH { get; set; }

        public DateTime? MATUREDATE { get; set; }

        public int? FLAG { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }
    }
}
