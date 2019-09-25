namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.SERIAL_INFO")]
    public partial class SERIAL_INFO
    {
        [Key]
        [StringLength(20)]
        public string SERIAL_TYPE { get; set; }

        [StringLength(20)]
        public string SERIAL_QZ { get; set; }

        public byte? SERAIL_LEN { get; set; }

        public int? SRRAIL_VALUE { get; set; }

        [StringLength(20)]
        public string CUR_DAY { get; set; }

        [StringLength(20)]
        public string COMMENTS { get; set; }
    }
}
