namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_BUSINESSINFO")]
    public partial class WMS_BUSINESSINFO
    {
        [Key]
        [StringLength(36)]
        public string BUSINESSID { get; set; }

        [StringLength(32)]
        public string BUSINESSCODE { get; set; }

        [StringLength(36)]
        public string BUSINESSTYPE { get; set; }

        [StringLength(64)]
        public string BUSINESSNAME { get; set; }

        [StringLength(32)]
        public string SHORTNAME { get; set; }

        [StringLength(1000)]
        public string BUSINESSDESCRIPTION { get; set; }

        [StringLength(800)]
        public string ADDRESS { get; set; }

        [StringLength(16)]
        public string PHONE1 { get; set; }

        [StringLength(16)]
        public string PHONE2 { get; set; }

        [StringLength(16)]
        public string FAX1 { get; set; }

        [StringLength(36)]
        public string WEB { get; set; }

        [StringLength(36)]
        public string EMAIL1 { get; set; }

        [StringLength(16)]
        public string LINKMAN1 { get; set; }

        [StringLength(16)]
        public string LINKMAN2 { get; set; }

        public int? STATUS { get; set; }

        [StringLength(36)]
        public string PYCODE { get; set; }

        [StringLength(36)]
        public string SYNCSYSTEMID { get; set; }

        public int? SYNCTYPE { get; set; }

        public DateTime? SYNCDATE { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public int? ATTRIBUTE1 { get; set; }

        [StringLength(32)]
        public string ATTRIBUTE2 { get; set; }

        [StringLength(80)]
        public string ATTRIBUTE3 { get; set; }

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

        [StringLength(64)]
        public string SHOPTO { get; set; }

        [StringLength(16)]
        public string FAX2 { get; set; }

        [StringLength(16)]
        public string EMAIL2 { get; set; }

        [StringLength(16)]
        public string MOBILE2 { get; set; }

        [StringLength(16)]
        public string MOBILE1 { get; set; }

        [StringLength(128)]
        public string ROUTE { get; set; }

        [StringLength(32)]
        public string CITY { get; set; }

        [StringLength(32)]
        public string STATE { get; set; }

        [StringLength(16)]
        public string ZIP { get; set; }

        [StringLength(32)]
        public string COUNTRY { get; set; }
    }
}
