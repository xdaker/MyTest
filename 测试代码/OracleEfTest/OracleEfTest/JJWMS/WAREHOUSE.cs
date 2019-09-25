namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.WAREHOUSE")]
    public partial class WAREHOUSE
    {
        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        public string ACTNAME { get; set; }

        [StringLength(2)]
        public string REGION { get; set; }

        [StringLength(64)]
        public string REGIONNAME { get; set; }

        [StringLength(2)]
        public string LEVELNO { get; set; }

        [StringLength(64)]
        public string LEVELNAME { get; set; }

        [StringLength(16)]
        public string PARENTCODE { get; set; }

        [StringLength(64)]
        public string CONTACT { get; set; }

        [StringLength(16)]
        public string PHONE { get; set; }

        [StringLength(16)]
        public string FAX { get; set; }

        [StringLength(16)]
        public string MOBILE { get; set; }

        [StringLength(64)]
        public string EMAIL { get; set; }

        [StringLength(16)]
        public string ZIP { get; set; }

        [StringLength(128)]
        public string ADDRESS { get; set; }

        [StringLength(32)]
        public string CITY { get; set; }

        [StringLength(32)]
        public string PROVINCE { get; set; }

        [StringLength(32)]
        public string COUNTRY { get; set; }

        [StringLength(256)]
        public string COMMENTS { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal ENABLEFLAG { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime ROWCREATEDATE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime ROWMODIFYDATE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        public decimal? BRANCHSYSNO { get; set; }

        public decimal? WHTYPE { get; set; }

        public decimal? GOODSTYPE { get; set; }

        public decimal? INDRAWING_STATUS { get; set; }

        public decimal? ISOFTENUSEDWMS { get; set; }
    }
}
