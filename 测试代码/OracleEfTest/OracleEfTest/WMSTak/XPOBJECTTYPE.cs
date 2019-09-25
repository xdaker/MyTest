namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.XPOBJECTTYPE")]
    public partial class XPOBJECTTYPE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OID { get; set; }

        [StringLength(254)]
        public string TYPENAME { get; set; }

        [StringLength(254)]
        public string ASSEMBLYNAME { get; set; }
    }
}
