namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_TasksMainTemp")]
    public partial class WMS_TasksMainTemp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WMS_TasksMainTemp()
        {
            WMS_TasksTemp = new HashSet<WMS_TasksTemp>();
        }

        [Key]
        [StringLength(36)]
        public string TaskTempId { get; set; }

        [StringLength(16)]
        public string TypeCode { get; set; }

        [StringLength(36)]
        public string BillsId { get; set; }

        public DateTime? DownTime { get; set; }

        [StringLength(36)]
        public string OperaterId { get; set; }

        public int? TaskStatus { get; set; }

        public int? Priority { get; set; }

        public int? IsInsert { get; set; }

        public int? IsPause { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WMS_TasksTemp> WMS_TasksTemp { get; set; }
    }
}
