namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_InPlanDetail")]
    public partial class WMS_InPlanDetail
    {
        [Key]
        [StringLength(36)]
        public string InPlanDetailId { get; set; }

        [StringLength(32)]
        public string InPlanId { get; set; }

        [StringLength(36)]
        public string MaterialsId { get; set; }

        [StringLength(36)]
        public string PackSpecId { get; set; }

        [StringLength(32)]
        public string ProductBatch { get; set; }

        
        public decimal? PlanInQuantity { get; set; }

        
        public decimal? ActualInQuantity { get; set; }

        
        public decimal? InPrice { get; set; }

        public int? MaterialsInType { get; set; }

        public int? MaterialsAttribute { get; set; }

        public int? MaterialsStatus { get; set; }

        public int? Status { get; set; }

        [StringLength(36)]
        public string SupplierId { get; set; }

        [StringLength(32)]
        public string SupplierBatch { get; set; }

        [StringLength(36)]
        public string ProductionId { get; set; }

        public DateTime? ProduceDate { get; set; }

        public DateTime? MatureDate { get; set; }

        public DateTime? BuyerDate { get; set; }

        public DateTime? ReceiveDate { get; set; }

        [StringLength(36)]
        public string SyncSystemDetailId { get; set; }

        public int? SyncType { get; set; }

        public DateTime? SyncDate { get; set; }

        public DateTime? AddDateTime { get; set; }

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
