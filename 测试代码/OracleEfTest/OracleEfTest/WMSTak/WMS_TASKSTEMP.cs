using Newtonsoft.Json;

namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_TASKSTEMP")]
    public partial class WMS_TASKSTEMP
    {
        [Key]
        [StringLength(36)]
        public string TASKTEMPCODE { get; set; }

        [StringLength(36)]
        public string TASKTEMPID { get; set; }

        [StringLength(32)]
        public string GLIDECODE { get; set; }

        [StringLength(36)]
        public string STARTLOCATIONID { get; set; }

        [StringLength(36)]
        public string ENDLOCATIONID { get; set; }

        public DateTime? DOWNTIME { get; set; }

        public int? TASKSTATUS { get; set; }

        [StringLength(28)]
        public string CONTAINERCODE { get; set; }

        public int? PRIORITY { get; set; }

        public int? ISINSERT { get; set; }

        public int? ISPAUSE { get; set; }

        public int? DOWNCODE { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

        public int? ATTRIBUTE1 { get; set; }

        [StringLength(32)]
        public string ATTRIBUTE2 { get; set; }

        [StringLength(80)]
        public string ATTRIBUTE3 { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(50)]
        public string CREATEUSERID { get; set; }

        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        [StringLength(50)]
        public string MODIFYUSERID { get; set; }

        [StringLength(50)]
        public string MODIFYUSERNAME { get; set; }

        [JsonIgnore]
        public virtual WMS_TASKSMAINTEMP WMS_TASKSMAINTEMP { get; set; }
    }
}
