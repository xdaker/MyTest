namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.Base_ProvinceCity")]
    public partial class Base_ProvinceCity
    {
        [Key]
        [StringLength(50)]
        public string ProvinceCityId { get; set; }

        [StringLength(50)]
        public string ParentId { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

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
