namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.Base_DataDictionaryDetail")]
    public partial class Base_DataDictionaryDetail
    {
        [Key]
        [StringLength(50)]
        public string DataDictionaryDetailId { get; set; }

        [StringLength(50)]
        public string DataDictionaryId { get; set; }

        [StringLength(50)]
        public string ParentId { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

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
