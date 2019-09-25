namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.PUTAWAYSTRATEGYDETAIL")]
    public partial class PUTAWAYSTRATEGYDETAIL
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal PUTAWAYSTRATEGYSYSNO { get; set; }

        public decimal LINENUM { get; set; }

        public decimal RECEIPTTYPE { get; set; }

        public decimal PUTAWAYRULE { get; set; }

        public decimal LOCATIONFILTERSYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string LOCATIONFILTERNAME { get; set; }

        public decimal ENABLEFLAG { get; set; }

        public DateTime ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }
    }
}
