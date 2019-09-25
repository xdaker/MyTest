namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.TASKS")]
    public partial class TASKS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SYSNO { get; set; }

        public long? HEADERID { get; set; }

        public long? TASKTYPE { get; set; }

        public long? TRANTYPE { get; set; }

        [StringLength(10)]
        public string STATUS { get; set; }

        public long? OWNERID { get; set; }

        public long? HANDLERID { get; set; }

        public long? CHILDNUM { get; set; }

        public long? COMPLETEDNUM { get; set; }

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

        [StringLength(64)]
        public string RETRIEVEVALUE { get; set; }

        public long? COMFIRMTYPE { get; set; }

        public DateTime? ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        public DateTime? LASTGETTIME { get; set; }

        public long? RV { get; set; }

        [StringLength(64)]
        public string GROUPKEY { get; set; }

        public long? CANGROUPSTATUS { get; set; }

        [Required]
        [StringLength(64)]
        public string COMPANYCODE { get; set; }

        [Required]
        [StringLength(128)]
        public string COMPANYNAME { get; set; }

        [Required]
        [StringLength(64)]
        public string WAREHOUSECODE { get; set; }

        [Required]
        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }
    }
}
