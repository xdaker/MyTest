namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.PDAVERSIONSETTINGS")]
    public partial class PDAVERSIONSETTINGS
    {
        public decimal? SYSNO { get; set; }

        [StringLength(50)]
        public string WAREHOUSECODE { get; set; }

        [StringLength(50)]
        public string APPNAME { get; set; }

        [StringLength(50)]
        public string VERSION { get; set; }

        [StringLength(50)]
        public string DBVERSION { get; set; }

        [StringLength(100)]
        public string URL { get; set; }

        [StringLength(250)]
        public string FILENAME { get; set; }

        [StringLength(2)]
        public string STATUS { get; set; }

        [StringLength(100)]
        public string USERDEF1 { get; set; }

        [StringLength(100)]
        public string USERDEF2 { get; set; }

        [StringLength(100)]
        public string USERDEF3 { get; set; }

        [StringLength(100)]
        public string USERDEF4 { get; set; }

        [StringLength(100)]
        public string USERDEF5 { get; set; }

        [Key]
        public DateTime ROWCREATEDATE { get; set; }

        public DateTime? ROWMODIFYDATE { get; set; }
    }
}
