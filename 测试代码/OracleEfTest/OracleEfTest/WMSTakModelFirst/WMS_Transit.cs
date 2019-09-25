namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.WMS_Transit")]
    public partial class WMS_Transit
    {
        [Key]
        public Guid TransitCode { get; set; }

        [StringLength(32)]
        public string TransitStockNum { get; set; }

        [StringLength(50)]
        public string TransitType { get; set; }

        public DateTime? TransitDate { get; set; }

        [StringLength(36)]
        public string MaterialsId { get; set; }

        [StringLength(36)]
        public string PackSpecId { get; set; }

        [StringLength(32)]
        public string ProductBatch { get; set; }

        public int? MaterialsAttribute { get; set; }

        public int? MaterialsStatus { get; set; }

        [StringLength(36)]
        public string SupplierId { get; set; }

        [StringLength(32)]
        public string SupplierBatch { get; set; }

        [StringLength(36)]
        public string ProductionId { get; set; }

        public DateTime? ProduceDate { get; set; }

        public DateTime? MatureDate { get; set; }

        [StringLength(36)]
        public string ContainerCode { get; set; }

        
        public decimal? TransitQuantity { get; set; }

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
