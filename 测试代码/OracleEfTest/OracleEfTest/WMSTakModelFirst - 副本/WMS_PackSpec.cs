namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_PackSpec")]
    public partial class WMS_PackSpec
    {
        [Key]
        [StringLength(36)]
        public string PackSpecId { get; set; }

        [StringLength(36)]
        public string MaterialsId { get; set; }

        [StringLength(32)]
        public string PackModel { get; set; }

        [StringLength(36)]
        public string InContainerTypeId { get; set; }

        
        public decimal? QuantityPerPack { get; set; }

        
        public decimal? Length { get; set; }

        
        public decimal? Width { get; set; }

        
        public decimal? High { get; set; }

        [StringLength(8)]
        public string LengthUnit { get; set; }

        
        public decimal? WeightPerPack { get; set; }

        [StringLength(8)]
        public string WeightUnit { get; set; }

        [StringLength(8)]
        public string Unit { get; set; }

        
        public decimal? FitCount { get; set; }

        [StringLength(8)]
        public string StockpileUnit { get; set; }

        [StringLength(32)]
        public string PackBarCode { get; set; }

        [StringLength(36)]
        public string OutContainerTypeId { get; set; }

        [StringLength(32)]
        public string StockMethod { get; set; }

        public int? Status { get; set; }

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
