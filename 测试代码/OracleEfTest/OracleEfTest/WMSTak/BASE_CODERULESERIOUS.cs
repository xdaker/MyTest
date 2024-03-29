namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_CODERULESERIOUS")]
    public partial class BASE_CODERULESERIOUS
    {
        [Key]
        [StringLength(50)]
        public string CODESERIOUSID { get; set; }

        [StringLength(50)]
        public string CODERULEID { get; set; }

        [StringLength(50)]
        public string USERID { get; set; }

        public int? VALUETYPE { get; set; }

        public int? NOWVALUE { get; set; }

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

        [StringLength(20)]
        public string LASTUPDATEDATE { get; set; }
    }
}
