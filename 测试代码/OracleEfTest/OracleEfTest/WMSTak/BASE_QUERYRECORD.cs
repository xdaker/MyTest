namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_QUERYRECORD")]
    public partial class BASE_QUERYRECORD
    {
        [Key]
        [StringLength(50)]
        public string QUERYRECORDID { get; set; }

        [StringLength(50)]
        public string MODULEID { get; set; }

        [StringLength(50)]
        public string FULLNAME { get; set; }

        [StringLength(1000)]
        public string CONDITIONJSON { get; set; }

        public int? RESOURCESHARE { get; set; }

        public int? NEXTDEFAULT { get; set; }

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
