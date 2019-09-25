namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.BASE_PHONENOTE")]
    public partial class BASE_PHONENOTE
    {
        [Key]
        [StringLength(50)]
        public string PHONENOTEID { get; set; }

        [StringLength(50)]
        public string PHONENNUMBER { get; set; }

        [StringLength(200)]
        public string SENDCONTENT { get; set; }

        public DateTime? SENDTIME { get; set; }

        [StringLength(50)]
        public string SENDSTATUS { get; set; }

        [StringLength(200)]
        public string DEVICENAME { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        public int? ENABLED { get; set; }

        public int? SORTCODE { get; set; }

        public int? DELETEMARK { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(50)]
        public string CREATEUSERID { get; set; }

        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }
    }
}
