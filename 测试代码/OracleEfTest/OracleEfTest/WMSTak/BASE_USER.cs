namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_USER")]
    public partial class BASE_USER
    {
        [Key]
        [StringLength(50)]
        public string USERID { get; set; }

        [StringLength(50)]
        public string COMPANYID { get; set; }

        [StringLength(50)]
        public string DEPARTMENTID { get; set; }

        public int? INNERUSER { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string ACCOUNT { get; set; }

        [StringLength(50)]
        public string PASSWORD { get; set; }

        [StringLength(50)]
        public string SECRETKEY { get; set; }

        [StringLength(50)]
        public string REALNAME { get; set; }

        [StringLength(200)]
        public string SPELL { get; set; }

        [StringLength(50)]
        public string GENDER { get; set; }

        public DateTime? BIRTHDAY { get; set; }

        [StringLength(50)]
        public string MOBILE { get; set; }

        [StringLength(50)]
        public string TELEPHONE { get; set; }

        [StringLength(50)]
        public string OICQ { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public DateTime? CHANGEPASSWORDDATE { get; set; }

        public int? OPENID { get; set; }

        public int? LOGONCOUNT { get; set; }

        public DateTime? FIRSTVISIT { get; set; }

        public DateTime? PREVIOUSVISIT { get; set; }

        public DateTime? LASTVISIT { get; set; }

        [StringLength(50)]
        public string AUDITSTATUS { get; set; }

        [StringLength(50)]
        public string AUDITUSERID { get; set; }

        [StringLength(50)]
        public string AUDITUSERNAME { get; set; }

        public DateTime? AUDITDATETIME { get; set; }

        public int? ONLINE { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

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
