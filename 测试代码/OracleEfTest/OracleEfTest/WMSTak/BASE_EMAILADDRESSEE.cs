namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_EMAILADDRESSEE")]
    public partial class BASE_EMAILADDRESSEE
    {
        [Key]
        [StringLength(50)]
        public string EMAILADDRESSEEID { get; set; }

        [StringLength(50)]
        public string EMAILID { get; set; }

        [StringLength(50)]
        public string ADDRESSEEID { get; set; }

        [StringLength(50)]
        public string ADDRESSEENAME { get; set; }

        public int? ADDRESSEEIDSTATE { get; set; }

        public int? ISREAD { get; set; }

        public int? READCOUNT { get; set; }

        public DateTime? READDATE { get; set; }

        public DateTime? ENDREADDATE { get; set; }

        public int? HIGHLIGHT { get; set; }

        public int? BACKLOG { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public int? DELETEMARK { get; set; }

        public virtual BASE_EMAIL BASE_EMAIL { get; set; }
    }
}
