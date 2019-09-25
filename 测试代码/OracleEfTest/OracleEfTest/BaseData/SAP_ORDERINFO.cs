namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.SAP_ORDERINFO")]
    public partial class SAP_ORDERINFO
    {
        [Key]
        [Column(Order = 0)]
        public string ACTIVENO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string REQID { get; set; }

        [Key]
        [Column(Order = 2)]
        public string SOID { get; set; }

        [StringLength(64)]
        public string ORDERCREATETIME { get; set; }

        [StringLength(64)]
        public string CREATETIME { get; set; }

        [StringLength(128)]
        public string ORDERTYPE { get; set; }

        [StringLength(128)]
        public string DEAL_FALG { get; set; }

        [StringLength(128)]
        public string COMMENTS { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(128)]
        public string CREATEUSERNAME { get; set; }
    }
}
