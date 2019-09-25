namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.VIEW_INDETTAIL")]
    public partial class VIEW_INDETTAIL
    {
        [Key]
        [StringLength(36)]
        public string INDETAILID { get; set; }

        [StringLength(32)]
        public string INCODE { get; set; }

        [StringLength(48)]
        public string DELIVERYID { get; set; }

        [StringLength(80)]
        public string MATERIALSCNNAME { get; set; }

        [StringLength(32)]
        public string MATERIALSCODE { get; set; }

        public decimal? INQUANTITY { get; set; }

        [StringLength(32)]
        public string PACKMODEL { get; set; }

        [StringLength(28)]
        public string CONTAINERCODE { get; set; }

        [StringLength(16)]
        public string LOCATIONCODE { get; set; }

        [StringLength(32)]
        public string INORDERNUMBER { get; set; }

        public int? MATERIALSATTRIBUTE { get; set; }

        public int? MATERIALSSTATUS { get; set; }

        [StringLength(64)]
        public string BUSINESSNAME { get; set; }

        public DateTime? PRODUCEDATE { get; set; }

        public DateTime? MATUREDATE { get; set; }

        public int? FLAG { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERNAME { get; set; }
    }
}
