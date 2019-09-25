namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.POORDERENTRY")]
    public partial class POORDERENTRY
    {
        [StringLength(50)]
        public string POORDERENTRYID { get; set; }

        [StringLength(50)]
        public string POORDERID { get; set; }

        [StringLength(50)]
        public string BATCHNO { get; set; }

        [StringLength(50)]
        public string ITEMID { get; set; }

        [StringLength(50)]
        public string ITEMCODE { get; set; }

        [StringLength(200)]
        public string ITEMNAME { get; set; }

        [StringLength(50)]
        public string ITEMMODEL { get; set; }

        [StringLength(50)]
        public string UNITID { get; set; }

        public decimal? QTY { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? PRICEAMOUNT { get; set; }

        public decimal? PLUSPRICE { get; set; }

        public decimal? PLUSPRICEAMOUNT { get; set; }

        public decimal? CESS { get; set; }

        public decimal? CESSAMOUNT { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public int? SORTCODE { get; set; }

        public int? DELETEMARK { get; set; }

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
