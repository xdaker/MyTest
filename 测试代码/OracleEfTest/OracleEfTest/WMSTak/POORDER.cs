namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.POORDER")]
    public partial class POORDER
    {
        [StringLength(50)]
        public string POORDERID { get; set; }

        [StringLength(50)]
        public string PARENTID { get; set; }

        [StringLength(50)]
        public string BILLNO { get; set; }

        public DateTime? BILLDATE { get; set; }

        [StringLength(20)]
        public string METHOD { get; set; }

        [StringLength(50)]
        public string CLEARING { get; set; }

        public DateTime? CLEARINGTIME { get; set; }

        [StringLength(50)]
        public string CURRENCY { get; set; }

        public decimal? EXCHANGERATE { get; set; }

        [StringLength(50)]
        public string SUPPLIERID { get; set; }

        [StringLength(200)]
        public string FETCHADD { get; set; }

        [StringLength(50)]
        public string SALESMANID { get; set; }

        [StringLength(50)]
        public string SALESMAN { get; set; }

        public int? POORDERTYPE { get; set; }

        public int? CANCELLATION { get; set; }

        [StringLength(50)]
        public string CREATEDEPARTMENTID { get; set; }

        [StringLength(50)]
        public string CREATEDEPARTMENTNAME { get; set; }

        [StringLength(50)]
        public string CREATEUSERID { get; set; }

        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public int? ISSUBMIT { get; set; }

        public int? DELETEMARK { get; set; }

        [StringLength(50)]
        public string MODIFYDEPARTMENTID { get; set; }

        [StringLength(50)]
        public string MODIFYDEPARTMENTNAME { get; set; }

        [StringLength(50)]
        public string MODIFYUSERID { get; set; }

        [StringLength(50)]
        public string MODIFYUSERNAME { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        [StringLength(50)]
        public string AUDITSTATUS { get; set; }

        [StringLength(50)]
        public string AUDITSTATUSNAME { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }
    }
}
