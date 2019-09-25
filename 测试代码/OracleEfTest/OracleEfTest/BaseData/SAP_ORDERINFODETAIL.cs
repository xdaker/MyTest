namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.SAP_ORDERINFODETAIL")]
    public partial class SAP_ORDERINFODETAIL
    {
        [StringLength(128)]
        public string ACTIVENO { get; set; }

        [StringLength(32)]
        public string REQID { get; set; }

        [StringLength(128)]
        public string SOID { get; set; }

        [Key]
        public string MATERIALNO { get; set; }

        [StringLength(128)]
        public string CUSTOMERNAME { get; set; }

        [StringLength(64)]
        public string ORDERCREATETIME { get; set; }

        [StringLength(64)]
        public string CREATETIME { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(128)]
        public string CREATEUSERNAME { get; set; }

        [StringLength(128)]
        public string CUSTOMERCODE { get; set; }
    }
}
