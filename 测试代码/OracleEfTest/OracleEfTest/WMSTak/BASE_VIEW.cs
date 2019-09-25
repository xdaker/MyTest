namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_VIEW")]
    public partial class BASE_VIEW
    {
        [Key]
        [StringLength(50)]
        public string VIEWID { get; set; }

        [StringLength(50)]
        public string MODULEID { get; set; }

        [StringLength(50)]
        public string PARENTID { get; set; }

        [StringLength(50)]
        public string FIELDNAME { get; set; }

        [StringLength(50)]
        public string FULLNAME { get; set; }

        [StringLength(50)]
        public string SHOWNAME { get; set; }

        public int? COLUMNWIDTH { get; set; }

        [StringLength(50)]
        public string TEXTALIGN { get; set; }

        public int? ALLOWSHOW { get; set; }

        public int? ALLOWDERIVE { get; set; }

        [StringLength(1000)]
        public string CUSTOMSWITCH { get; set; }

        public int? ENABLED { get; set; }

        public int? SORTCODE { get; set; }

        public DateTime CREATEDATE { get; set; }
    }
}
