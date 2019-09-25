namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_OutTask")]
    public partial class WMS_OutTask
    {
        public int? ZHStatus { get; set; }

        [Key]
        public Guid Oid { get; set; }

        [StringLength(100)]
        public string MaterialCode { get; set; }

        [StringLength(100)]
        public string MaterialName { get; set; }

        [StringLength(100)]
        public string Batch { get; set; }

        [StringLength(100)]
        public string SupplierCode { get; set; }

        [StringLength(100)]
        public string SupplierName { get; set; }

        
        public decimal? PlanQuantity { get; set; }

        
        public decimal? OutQuantity { get; set; }

        [StringLength(100)]
        public string OutPlanDetailId { get; set; }

        [StringLength(100)]
        public string DeliveryId { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }

        [StringLength(100)]
        public string TaskState { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(100)]
        public string TaskType { get; set; }

        [StringLength(36)]
        public string LocationId { get; set; }

        
        public decimal? ZHQuantity { get; set; }

        [StringLength(100)]
        public string ZHTaskState { get; set; }

        
        public decimal? BHQuantity { get; set; }

        [StringLength(100)]
        public string BHTaskState { get; set; }

        public int? JXPO { get; set; }

        public int? IsChangePackage { get; set; }

        public int? Code { get; set; }

        public int? PTID { get; set; }

        
        public decimal? XNSL { get; set; }

        [StringLength(50)]
        public string AreaCode { get; set; }

        [StringLength(100)]
        public string PRODUCTNUMBER { get; set; }
    }
}
