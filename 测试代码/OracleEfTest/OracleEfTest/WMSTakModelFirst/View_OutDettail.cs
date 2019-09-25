namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.View_OutDettail")]
    public partial class View_OutDettail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string OutDetailId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string OutPlanId { get; set; }

        [StringLength(48)]
        public string DeliveryId { get; set; }

        [StringLength(32)]
        public string OutCode { get; set; }

        public decimal? OutQuantity { get; set; }

        [StringLength(36)]
        public string UnloadingPlace { get; set; }

        [StringLength(80)]
        public string MaterialsCNName { get; set; }

        [StringLength(32)]
        public string MaterialsCode { get; set; }

        [StringLength(32)]
        public string PackModel { get; set; }

        [StringLength(36)]
        public string ContainerCode { get; set; }

        [StringLength(16)]
        public string LocationCode { get; set; }

        [StringLength(32)]
        public string ProductBatch { get; set; }

        public int? MaterialsAttribute { get; set; }

        public int? MaterialsStatus { get; set; }

        [StringLength(64)]
        public string BusinessName { get; set; }

        public DateTime? ProduceDate { get; set; }

        public DateTime? MatureDate { get; set; }

        [StringLength(1000)]
        public string Remark { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }
    }
}
