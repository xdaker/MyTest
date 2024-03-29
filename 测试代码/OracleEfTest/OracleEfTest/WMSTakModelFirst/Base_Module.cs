namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.Base_Module")]
    public partial class Base_Module
    {
        [Key]
        [StringLength(50)]
        public string ModuleId { get; set; }

        [StringLength(50)]
        public string ParentId { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Icon { get; set; }

        [StringLength(200)]
        public string Location { get; set; }

        [StringLength(50)]
        public string Target { get; set; }

        public int? Level { get; set; }

        public int? Isexpand { get; set; }

        public int? AllowButton { get; set; }

        public int? AllowView { get; set; }

        public int? AllowForm { get; set; }

        public int? Authority { get; set; }

        public int? DataScope { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        public int? Enabled { get; set; }

        public int? SortCode { get; set; }

        public int? DeleteMark { get; set; }

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
