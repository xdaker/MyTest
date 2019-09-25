namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_ALLOCATIONMAIN")]
    public partial class WMS_ALLOCATIONMAIN
    {
        [Key]
        [StringLength(36)]
        public string ALLOCATIONMAINID { get; set; }

        [StringLength(32)]
        public string ALLOCATIONPLANMAINID { get; set; }

        [StringLength(36)]
        public string ALLOCATIONPLANDETAILID { get; set; }

        [StringLength(10)]
        public string ALLOCATIONSTOCKNUM { get; set; }

        public decimal? ACTUALALLOCATIONQUANTITY { get; set; }

        public DateTime? TRANSITDATE { get; set; }

        [StringLength(8)]
        public string CONTAINERCODE { get; set; }

        [StringLength(32)]
        public string STARTWAREHOUSECODE { get; set; }

        [StringLength(32)]
        public string STARTAREACODE { get; set; }

        [StringLength(36)]
        public string STARTLOCATIONID { get; set; }

        [StringLength(32)]
        public string ENDWAREHOUSECODE { get; set; }

        [StringLength(32)]
        public string ENDAREACODE { get; set; }

        [StringLength(36)]
        public string ENDLOCATIONID { get; set; }

        public int? ISTASKCOMPLETED { get; set; }

        public int? SELECTLOCATIONTYPE { get; set; }

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
