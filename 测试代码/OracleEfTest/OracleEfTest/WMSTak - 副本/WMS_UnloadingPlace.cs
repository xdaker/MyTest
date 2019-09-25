namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_UnloadingPlace")]
    public partial class WMS_UnloadingPlace
    {
        [Key]
        [StringLength(36)]
        public string UnloadId { get; set; }

        [StringLength(32)]
        public string RoadJunctionCode { get; set; }

        [StringLength(32)]
        public string RoadJunctionName { get; set; }

        [StringLength(36)]
        public string BusinessId { get; set; }

        [StringLength(40)]
        public string ReceivePlace { get; set; }

        [StringLength(32)]
        public string WorkshopCode { get; set; }

        [StringLength(40)]
        public string WorkshopName { get; set; }

        [StringLength(32)]
        public string FactoryCode { get; set; }

        [StringLength(40)]
        public string FactoryName { get; set; }

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
