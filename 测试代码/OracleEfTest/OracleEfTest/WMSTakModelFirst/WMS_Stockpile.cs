namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.WMS_Stockpile")]
    public partial class WMS_Stockpile
    {
        [Key]
        [StringLength(36)]
        public string StockpileId { get; set; }

        [StringLength(36)]
        public string LocationId { get; set; }

        [StringLength(36)]
        public string ContainerCode { get; set; }

        [StringLength(36)]
        public string MaterialsId { get; set; }

        [StringLength(32)]
        public string ProductBatch { get; set; }

        
        public decimal? Quantity { get; set; }

        [StringLength(36)]
        public string PackSpecId { get; set; }

        public int? MaterialsStatus { get; set; }

        public int? MaterialsAttribute { get; set; }

        public int? IsFull { get; set; }

        public DateTime? ProduceDate { get; set; }

        public DateTime? MatureDate { get; set; }

        public DateTime? InTime { get; set; }

        public DateTime? LastTime { get; set; }

        [StringLength(50)]
        public string SupplierId { get; set; }

        [StringLength(36)]
        public string ProductId { get; set; }

        [StringLength(1000)]
        public string Remark { get; set; }

        public int? Attribute1 { get; set; }

        [StringLength(36)]
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

        [StringLength(36)]
        public string Attribute4 { get; set; }

        [StringLength(36)]
        public string Attribute5 { get; set; }
    }
}
