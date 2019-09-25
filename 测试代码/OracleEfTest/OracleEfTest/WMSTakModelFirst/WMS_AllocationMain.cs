namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.WMS_AllocationMain")]
    public partial class WMS_AllocationMain
    {
        [Key]
        [StringLength(36)]
        public string AllocationMainId { get; set; }

        [StringLength(32)]
        public string AllocationPlanMainId { get; set; }

        [StringLength(36)]
        public string AllocationPlanDetailId { get; set; }

        [StringLength(10)]
        public string AllocationStockNum { get; set; }

        public decimal? ActualAllocationQuantity { get; set; }

        public DateTime? TransitDate { get; set; }

        [StringLength(8)]
        public string ContainerCode { get; set; }

        [StringLength(32)]
        public string StartWarehouseCode { get; set; }

        [StringLength(32)]
        public string StartAreaCode { get; set; }

        [StringLength(36)]
        public string StartLocationId { get; set; }

        [StringLength(32)]
        public string EndWarehouseCode { get; set; }

        [StringLength(32)]
        public string EndAreaCode { get; set; }

        [StringLength(36)]
        public string EndLocationId { get; set; }

        public int? IsTaskCompleted { get; set; }

        public int? SelectLocationType { get; set; }

        [StringLength(1000)]
        public string Remark { get; set; }

        public int? Attribute1 { get; set; }

        [StringLength(32)]
        public string Attribute2 { get; set; }

        [StringLength(80)]
        public string Attribute3 { get; set; }

        [StringLength(80)]
        public string Attribute4 { get; set; }

        [StringLength(80)]
        public string Attribute5 { get; set; }

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
