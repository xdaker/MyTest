namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_OUTTASK")]
    public partial class WMS_OUTTASK
    {
        [Key]
        public Guid OID { get; set; }

        public int? ZHSTATUS { get; set; }

        [StringLength(100)]
        public string MATERIALCODE { get; set; }

        [StringLength(100)]
        public string MATERIALNAME { get; set; }

        [StringLength(100)]
        public string BATCH { get; set; }

        [StringLength(100)]
        public string SUPPLIERCODE { get; set; }

        [StringLength(100)]
        public string SUPPLIERNAME { get; set; }

        public decimal? PLANQUANTITY { get; set; }

        public decimal? OUTQUANTITY { get; set; }

        [StringLength(100)]
        public string OUTPLANDETAILID { get; set; }

        [StringLength(100)]
        public string DELIVERYID { get; set; }

        public int? OPTIMISTICLOCKFIELD { get; set; }

        public int? GCRECORD { get; set; }

        [StringLength(100)]
        public string TASKSTATE { get; set; }

        public DateTime? CREATETIME { get; set; }

        [StringLength(100)]
        public string TASKTYPE { get; set; }

        [StringLength(36)]
        public string LOCATIONID { get; set; }

        public decimal? ZHQUANTITY { get; set; }

        [StringLength(100)]
        public string ZHTASKSTATE { get; set; }

        public decimal? BHQUANTITY { get; set; }

        [StringLength(100)]
        public string BHTASKSTATE { get; set; }

        public int? JXPO { get; set; }

        public int? ISCHANGEPACKAGE { get; set; }

        public int? CODE { get; set; }

        public int? PTID { get; set; }

        public decimal? XNSL { get; set; }

        [StringLength(50)]
        public string AREACODE { get; set; }

        [StringLength(100)]
        public string PRODUCTNUMBER { get; set; }
    }
}
