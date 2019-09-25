namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.LOGINGLOG")]
    public partial class LOGINGLOG
    {
        [Key]
        public decimal WORK_ID { get; set; }

        [StringLength(1000)]
        public string WORK_NAME { get; set; }

        public DateTime? CREATE_TIME { get; set; }
    }
}
