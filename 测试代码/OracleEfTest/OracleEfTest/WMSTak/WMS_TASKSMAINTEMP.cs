using Newtonsoft.Json;

namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_TASKSMAINTEMP")]
    public partial class WMS_TASKSMAINTEMP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WMS_TASKSMAINTEMP()
        {
            WMS_TASKSTEMP = new HashSet<WMS_TASKSTEMP>();
        }

        [Key]
        [StringLength(36)]
        public string TASKTEMPID { get; set; }

        [StringLength(16)]
        public string TYPECODE { get; set; }

        [StringLength(36)]
        public string BILLSID { get; set; }

        public DateTime? DOWNTIME { get; set; }

        [StringLength(36)]
        public string OPERATERID { get; set; }

        public int? TASKSTATUS { get; set; }

        public int? PRIORITY { get; set; }

        public int? ISINSERT { get; set; }

        public int? ISPAUSE { get; set; }

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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WMS_TASKSTEMP> WMS_TASKSTEMP { get; set; }
    }
}
