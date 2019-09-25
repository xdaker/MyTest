namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.LOTATTRTEMPLATEITEMS")]
    public partial class LOTATTRTEMPLATEITEMS
    {
        [Key]
        [Column(Order = 0)]
        public decimal SYSNO { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal LOTATTRTEMPLATESYSNO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(32)]
        public string ATTRKEYNAME { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal DATATYPE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal ISOPTIONALFLAG { get; set; }

        [StringLength(32)]
        public string SYSTEMIDENTIFIER { get; set; }
    }
}
