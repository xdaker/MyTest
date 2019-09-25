namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.View_InDettail")]
    public partial class View_InDettail
    {
        [Key]
        [StringLength(36)]
        public string InDetailId { get; set; }

        [StringLength(32)]
        public string InCode { get; set; }

        [StringLength(48)]
        public string DeliveryId { get; set; }

        [StringLength(80)]
        public string MaterialsCNName { get; set; }

        [StringLength(32)]
        public string MaterialsCode { get; set; }

        public decimal? InQuantity { get; set; }

        [StringLength(32)]
        public string PackModel { get; set; }

        [StringLength(28)]
        public string ContainerCode { get; set; }

        [StringLength(16)]
        public string LocationCode { get; set; }

        [StringLength(32)]
        public string InOrderNumber { get; set; }

        public int? MaterialsAttribute { get; set; }

        public int? MaterialsStatus { get; set; }

        [StringLength(64)]
        public string BusinessName { get; set; }

        public DateTime? ProduceDate { get; set; }

        public DateTime? MatureDate { get; set; }

        public int? flag { get; set; }

        [StringLength(1000)]
        public string Remark { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(32)]
        public string CreateUserName { get; set; }
    }
}
