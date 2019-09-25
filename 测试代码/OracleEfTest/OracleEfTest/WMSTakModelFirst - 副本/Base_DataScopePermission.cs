namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.Base_DataScopePermission")]
    public partial class Base_DataScopePermission
    {
        [Key]
        [StringLength(50)]
        public string DataScopePermissionId { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(50)]
        public string ObjectId { get; set; }

        [StringLength(50)]
        public string ModuleId { get; set; }

        [StringLength(50)]
        public string ResourceId { get; set; }

        [StringLength(1024)]
        public string Condition { get; set; }

        [StringLength(1024)]
        public string ConditionJson { get; set; }

        [StringLength(50)]
        public string ScopeType { get; set; }

        public int? SortCode { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }
    }
}
