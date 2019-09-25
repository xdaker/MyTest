namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.WMS_QualityCheck")]
    public partial class WMS_QualityCheck
    {
        [Key]
        [StringLength(32)]
        public string QualityCheckID { get; set; }

        [StringLength(32)]
        public string QualityCheckNum { get; set; }

        [StringLength(32)]
        public string InPlanId { get; set; }

        [StringLength(36)]
        public string InPlanDetailId { get; set; }

        public DateTime? DownloadTime { get; set; }

        [StringLength(28)]
        public string ContainerCode { get; set; }

        [StringLength(36)]
        public string MaterialsId { get; set; }

        [StringLength(32)]
        public string ProductBatch { get; set; }

        [StringLength(36)]
        public string SupplierId { get; set; }

        public int? QualityCheckType { get; set; }

        
        public decimal? QualityCheckQuantity { get; set; }

        public int? IsProcess { get; set; }

        public DateTime? QualityCheckDate { get; set; }

        public int? Conclusion { get; set; }

        [StringLength(1000)]
        public string Remark { get; set; }

        public int? Attribute1 { get; set; }

        [StringLength(32)]
        public string Attribute2 { get; set; }

        [StringLength(80)]
        public string Attribute3 { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }
    }
}
