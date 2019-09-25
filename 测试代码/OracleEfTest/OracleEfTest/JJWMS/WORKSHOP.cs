namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.WORKSHOP")]
    public partial class WORKSHOP
    {
        [Key]
        public decimal SYSNO { get; set; }

        [StringLength(255)]
        public string CODE { get; set; }

        [StringLength(255)]
        public string NAME { get; set; }

        [StringLength(255)]
        public string DEPTCODE { get; set; }

        [StringLength(255)]
        public string DEPTNAME { get; set; }

        [StringLength(255)]
        public string ADDRES { get; set; }

        [StringLength(64)]
        public string PERSONCHARGE { get; set; }

        [StringLength(1024)]
        public string REMARKS { get; set; }
    }
}
