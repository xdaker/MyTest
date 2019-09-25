namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.View_Transit")]
    public partial class View_Transit
    {
        [StringLength(32)]
        public string PackModel { get; set; }

        [StringLength(50)]
        public string SupplierId { get; set; }

        [StringLength(36)]
        public string MaterialsId { get; set; }

        [StringLength(32)]
        public string ProductBatch { get; set; }

        [StringLength(32)]
        public string MaterialsCode { get; set; }

        [StringLength(80)]
        public string MaterialsCNName { get; set; }

        [StringLength(64)]
        public string BusinessName { get; set; }

        [StringLength(32)]
        public string BusinessCode { get; set; }

        [Key]
        [StringLength(36)]
        public string StockpileId { get; set; }

        [StringLength(36)]
        public string LocationId { get; set; }

        [StringLength(36)]
        public string ContainerCode { get; set; }

        public decimal? Quantity { get; set; }

        [StringLength(36)]
        public string PackSpecId { get; set; }

        public int? MaterialsStatus { get; set; }

        public int? MaterialsAttribute { get; set; }

        public int? IsFull { get; set; }

        public DateTime? ProduceDate { get; set; }

        public DateTime? InTime { get; set; }

        public DateTime? LastTime { get; set; }

        [StringLength(36)]
        public string ProductId { get; set; }

        [StringLength(1000)]
        public string Remark { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        [StringLength(16)]
        public string LocationCode { get; set; }

        public int? Layer { get; set; }

        public int? Row { get; set; }

        public int? Vertical { get; set; }

        [StringLength(32)]
        public string AreaCode { get; set; }
    }
}
