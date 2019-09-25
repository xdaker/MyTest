namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_ExamineDetail")]
    public partial class WMS_ExamineDetail
    {
        [Key]
        [StringLength(36)]
        public string ExamineDetailId { get; set; }

        [StringLength(32)]
        public string ExamineMainId { get; set; }

        [StringLength(36)]
        public string InOrderDetailId { get; set; }

        public DateTime? DownloadTime { get; set; }

        public int? ExamineProcess { get; set; }

        
        public decimal? QualifiedNum { get; set; }

        
        public decimal? UnqualifiedNum { get; set; }

        
        public decimal? OtherNum { get; set; }

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
