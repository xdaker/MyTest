namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_COMPANY")]
    public partial class BASE_COMPANY
    {
        [Key]
        [StringLength(50)]
        public string COMPANYID { get; set; }

        [StringLength(50)]
        public string PARENTID { get; set; }

        [StringLength(50)]
        public string CATEGORY { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string FULLNAME { get; set; }

        [StringLength(50)]
        public string SHORTNAME { get; set; }

        [StringLength(50)]
        public string NATURE { get; set; }

        [StringLength(50)]
        public string MANAGER { get; set; }

        [StringLength(50)]
        public string CONTACT { get; set; }

        [StringLength(50)]
        public string PHONE { get; set; }

        [StringLength(50)]
        public string FAX { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string PROVINCEID { get; set; }

        [StringLength(50)]
        public string PROVINCE { get; set; }

        [StringLength(50)]
        public string CITYID { get; set; }

        [StringLength(50)]
        public string CITY { get; set; }

        [StringLength(50)]
        public string COUNTYID { get; set; }

        [StringLength(50)]
        public string COUNTY { get; set; }

        [StringLength(50)]
        public string ADDRESS { get; set; }

        [StringLength(200)]
        public string ACCOUNTINFO { get; set; }

        [StringLength(200)]
        public string POSTALCODE { get; set; }

        [StringLength(200)]
        public string WEB { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public int? ENABLED { get; set; }

        public int? SORTCODE { get; set; }

        public int? DELETEMARK { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(50)]
        public string CREATEUSERID { get; set; }

        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        [StringLength(50)]
        public string MODIFYUSERID { get; set; }

        [StringLength(50)]
        public string MODIFYUSERNAME { get; set; }
    }
}
