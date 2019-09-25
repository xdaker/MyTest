namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_LANGUAGE")]
    public partial class BASE_LANGUAGE
    {
        [Key]
        [StringLength(50)]
        public string LANGUAGEID { get; set; }

        [StringLength(50)]
        public string OBJECTID { get; set; }

        [StringLength(50)]
        public string BUSINESSCODE { get; set; }

        [StringLength(50)]
        public string BUSINESSNAME { get; set; }

        [StringLength(1024)]
        public string FULLNAME { get; set; }

        [StringLength(200)]
        public string FULLVALUE { get; set; }

        [StringLength(1000)]
        public string NOTE { get; set; }

        [StringLength(50)]
        public string LANGUAGETYPE { get; set; }
    }
}
