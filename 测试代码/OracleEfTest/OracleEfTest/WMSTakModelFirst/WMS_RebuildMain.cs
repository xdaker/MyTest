namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.WMS_RebuildMain")]
    public partial class WMS_RebuildMain
    {
        [Key]
        [StringLength(32)]
        public string RebuildCode { get; set; }

        [StringLength(32)]
        public string RebuildPlanMainId { get; set; }

        [StringLength(36)]
        public string RebuildPlanDetailId { get; set; }

        [StringLength(32)]
        public string RebuildStockNum { get; set; }

        public DateTime? RebuildDate { get; set; }

        [StringLength(36)]
        public string SupplierId { get; set; }

        [StringLength(36)]
        public string MaterialsId { get; set; }

        [StringLength(36)]
        public string PackSpecId { get; set; }

        [StringLength(32)]
        public string ProductBatch { get; set; }

        public int? MaterialsAttribute { get; set; }

        public int? MaterialsStatus { get; set; }

        public DateTime? ProduceDate { get; set; }

        public DateTime? MatureDate { get; set; }

        [StringLength(8)]
        public string ContainerCode { get; set; }

        [StringLength(32)]
        public string SupplierBatch { get; set; }

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

        
        public decimal? RebuildQuantity { get; set; }

        [StringLength(36)]
        public string ProductionId { get; set; }

        [StringLength(36)]
        public string SyncSystemDetailId { get; set; }

        public int? SyncType { get; set; }

        public DateTime? SyncDate { get; set; }

        public int? IsProcess { get; set; }

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
