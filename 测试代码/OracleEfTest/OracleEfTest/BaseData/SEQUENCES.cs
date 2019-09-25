namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.SEQUENCES")]
    public partial class SEQUENCES
    {
        public long? ID { get; set; }

        [Key]
        public string SEQNAME { get; set; }

        public long? SEQID { get; set; }

        public long? TIMES { get; set; }
    }
}
