namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_MODULE")]
    public partial class BASE_MODULE
    {
        [Key]
        [StringLength(50)]
        public string MODULEID { get; set; }

        [StringLength(50)]
        public string PARENTID { get; set; }

        [StringLength(50)]
        public string CATEGORY { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string FULLNAME { get; set; }

        [StringLength(50)]
        public string ICON { get; set; }

        [StringLength(200)]
        public string LOCATION { get; set; }

        [StringLength(50)]
        public string TARGET { get; set; }

        public int? LEVEL { get; set; }

        public int? ISEXPAND { get; set; }

        public int? ALLOWBUTTON { get; set; }

        public int? ALLOWVIEW { get; set; }

        public int? ALLOWFORM { get; set; }

        public int? AUTHORITY { get; set; }

        public int? DATASCOPE { get; set; }

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
