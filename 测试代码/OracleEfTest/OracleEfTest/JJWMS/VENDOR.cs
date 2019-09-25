namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.VENDOR")]
    public partial class VENDOR
    {
        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        public string ACTNAME { get; set; }

        public decimal? QAFLAG { get; set; }

        public decimal? SIGNFLAG { get; set; }

        public decimal? QARATE { get; set; }

        [StringLength(512)]
        public string ADDRESS { get; set; }

        [StringLength(32)]
        public string CITY { get; set; }

        [StringLength(32)]
        public string STATE { get; set; }

        [StringLength(16)]
        public string ZIP { get; set; }

        [StringLength(32)]
        public string COUNTRY { get; set; }

        [StringLength(64)]
        public string CONTACT1 { get; set; }

        [StringLength(64)]
        public string PHONE1 { get; set; }

        [StringLength(64)]
        public string MOBILE1 { get; set; }

        [StringLength(64)]
        public string FAX1 { get; set; }

        [StringLength(64)]
        public string EMAIL1 { get; set; }

        [StringLength(64)]
        public string CONTACT2 { get; set; }

        [StringLength(64)]
        public string PHONE2 { get; set; }

        [StringLength(64)]
        public string MOBILE2 { get; set; }

        [StringLength(64)]
        public string FAX2 { get; set; }

        [StringLength(64)]
        public string EMAIL2 { get; set; }

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

        [StringLength(64)]
        public string WEBSITE { get; set; }

        [StringLength(32)]
        public string SOCIALCODING { get; set; }

        [StringLength(64)]
        public string DEPOSITBANK { get; set; }

        [StringLength(64)]
        public string BANKACCOUNT { get; set; }

        public decimal? CAPITAL { get; set; }

        [StringLength(64)]
        public string LEGALLPERSON { get; set; }

        [StringLength(16)]
        public string KIND { get; set; }

        [StringLength(128)]
        public string COMPANYCODE { get; set; }

        [StringLength(128)]
        public string AREACODE { get; set; }

        [StringLength(128)]
        public string AREACOMPANYCODE { get; set; }

        [StringLength(128)]
        public string SERIALNUMBER { get; set; }
    }
}
