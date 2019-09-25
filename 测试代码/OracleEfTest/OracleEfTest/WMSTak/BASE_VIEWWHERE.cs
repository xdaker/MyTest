namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_VIEWWHERE")]
    public partial class BASE_VIEWWHERE
    {
        [Key]
        [StringLength(50)]
        public string VIEWWHEREID { get; set; }

        [StringLength(50)]
        public string MODULEID { get; set; }

        [StringLength(50)]
        public string CONTROLTYPE { get; set; }

        [StringLength(200)]
        public string CONTROLDEFAULT { get; set; }

        [StringLength(200)]
        public string CONTROLSOURCE { get; set; }

        [StringLength(50)]
        public string FIELDNAME { get; set; }

        [StringLength(50)]
        public string FULLNAME { get; set; }

        [StringLength(50)]
        public string SHOWNAME { get; set; }

        public int? ALLOWSHOW { get; set; }

        public int? ENABLED { get; set; }

        public int? SORTCODE { get; set; }

        public DateTime CREATEDATE { get; set; }

        [StringLength(200)]
        public string CONTROLCUSTOM { get; set; }
    }
}
