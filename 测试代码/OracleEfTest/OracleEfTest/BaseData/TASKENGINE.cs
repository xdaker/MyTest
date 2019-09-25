namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.TASKENGINE")]
    public partial class TASKENGINE
    {
        [Key]
        public decimal SYSNO { get; set; }

        [StringLength(64)]
        public string OBJECTCODE { get; set; }

        [StringLength(64)]
        public string ENGINECODE { get; set; }

        public decimal? EGTYPE { get; set; }

        public decimal? PRIORITY { get; set; }

        [StringLength(512)]
        public string DESCRIPTION { get; set; }

        [StringLength(1024)]
        public string ONEDIMENSIONFILTER { get; set; }

        [StringLength(1024)]
        public string TWODIMENSIONFILTER { get; set; }

        [StringLength(64)]
        public string RETRIEVEVALUE { get; set; }

        [StringLength(64)]
        public string GROUPNAME1 { get; set; }

        [StringLength(64)]
        public string GROUPVALUE1 { get; set; }

        [StringLength(64)]
        public string GROUPNAME2 { get; set; }

        [StringLength(64)]
        public string GROUPVALUE2 { get; set; }

        [StringLength(64)]
        public string GROUPNAME3 { get; set; }

        [StringLength(64)]
        public string GROUPVALUE3 { get; set; }

        public decimal? CONFIRMTYPE { get; set; }

        [StringLength(512)]
        public string TASKINSTRUCTION { get; set; }

        [StringLength(512)]
        public string MARKING { get; set; }

        public decimal? RELEASEMODEL { get; set; }

        public decimal? MAXRECORDS { get; set; }

        [Column(TypeName = "float")]
        public decimal? MAXCUBE { get; set; }

        [Column(TypeName = "float")]
        public decimal? EXPTIME { get; set; }

        public decimal? INTPROPERTYONE { get; set; }

        public decimal? INTPROPERTYTWO { get; set; }

        public decimal? INTPROPERTYTHREE { get; set; }

        [StringLength(64)]
        public string STRINGPROPERTYONE { get; set; }

        [StringLength(64)]
        public string STRINGPROPERTYTWO { get; set; }

        [StringLength(64)]
        public string STRINGPROPERTYTHREE { get; set; }

        public decimal? ONEFILTERSYSNO { get; set; }

        [StringLength(128)]
        public string ONEFILTERNAME { get; set; }

        public decimal? TWOFILTERSYSNO { get; set; }

        [StringLength(128)]
        public string TWOFILTERNAME { get; set; }

        public decimal? LOCATIONMODEL { get; set; }

        public decimal? ISLPNTOSAMELOC { get; set; }

        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        public decimal? PICKTOLOCATION { get; set; }

        public decimal? ISCOLLECTAFTERPICK { get; set; }

        public decimal? SOURCETYPE { get; set; }
    }
}
