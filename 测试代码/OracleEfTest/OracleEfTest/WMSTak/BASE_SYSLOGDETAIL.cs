namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_SYSLOGDETAIL")]
    public partial class BASE_SYSLOGDETAIL
    {
        [Key]
        [StringLength(50)]
        public string SYSLOGDETAILID { get; set; }

        [StringLength(50)]
        public string SYSLOGID { get; set; }

        [StringLength(200)]
        public string PROPERTYNAME { get; set; }

        [StringLength(50)]
        public string PROPERTYFIELD { get; set; }

        [StringLength(1000)]
        public string NEWVALUE { get; set; }

        [StringLength(50)]
        public string OLDVALUE { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public virtual BASE_SYSLOG BASE_SYSLOG { get; set; }
    }
}
