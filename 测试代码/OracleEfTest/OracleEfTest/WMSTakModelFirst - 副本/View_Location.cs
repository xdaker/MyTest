namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.View_Location")]
    public partial class View_Location
    {
        [Key]
        [StringLength(36)]
        public string LocationId { get; set; }

        [StringLength(16)]
        public string LocationCode { get; set; }

        [StringLength(32)]
        public string StorageAreaCode { get; set; }

        [StringLength(32)]
        public string LocationTypeCode { get; set; }

        [StringLength(16)]
        public string LaneCode { get; set; }

        public int? Layer { get; set; }

        public int? Row { get; set; }

        public int? Vertical { get; set; }

        public int? OpenStatus { get; set; }

        public int? TaskTroubleStatus { get; set; }

        public int? MaximumSize { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(32)]
        public string WarehouseCode { get; set; }

        [StringLength(32)]
        public string AreaName { get; set; }

        [StringLength(16)]
        public string LocationFunctionCode { get; set; }

        [StringLength(32)]
        public string AreaCode { get; set; }

        [StringLength(16)]
        public string ContainerCode { get; set; }

        [StringLength(32)]
        public string MaterialsCode { get; set; }

        [StringLength(80)]
        public string MaterialsCNName { get; set; }

        public decimal? Quantity { get; set; }

        public int? Status { get; set; }

        [StringLength(1000)]
        public string Remark { get; set; }
    }
}
