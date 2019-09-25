namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.WMS_Materials")]
    public partial class WMS_Materials
    {
        [Key]
        [StringLength(36)]
        public string MaterialsId { get; set; }

        [StringLength(36)]
        public string MaterialsSortsId { get; set; }

        [StringLength(32)]
        public string MaterialsCode { get; set; }

        [StringLength(80)]
        public string MaterialsCNName { get; set; }

        [StringLength(80)]
        public string MaterialsENName { get; set; }

        [StringLength(10)]
        public string Unit { get; set; }

        [StringLength(32)]
        public string Model { get; set; }

        
        public decimal? StorageUpperLimit { get; set; }

        
        public decimal? StorageLowerLimit { get; set; }

        
        public decimal? SafeStorage { get; set; }

        public int? StorageDateLimit { get; set; }

        public int? UsefulLife { get; set; }

        public int? MaturityLimit { get; set; }

        public int? Status { get; set; }

        [StringLength(48)]
        public string PYCode { get; set; }

        public int? IsChangePackage { get; set; }

        [StringLength(36)]
        public string SyncSystemId { get; set; }

        public int? SyncType { get; set; }

        public DateTime? SyncDate { get; set; }

        public int? QualityCheckType { get; set; }

        
        public decimal? RandomRatio { get; set; }

        
        public decimal? QualifiedRatio { get; set; }

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
