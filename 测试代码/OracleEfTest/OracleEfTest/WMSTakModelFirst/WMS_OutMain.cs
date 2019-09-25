using Newtonsoft.Json;

namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("WMS.WMS_OutMain")]
    public partial class WMS_OutMain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WMS_OutMain()
        {
            WMS_OutDetail = new HashSet<WMS_OutDetail>();
        }

        [StringLength(36)]
        public string UnloadingPlace { get; set; }

        [StringLength(28)]
        public string ContainerCodeJH { get; set; }

        [Key]
        [StringLength(32)]
        public string OutCode { get; set; }

        [StringLength(32)]
        public string OutPlanId { get; set; }

        [StringLength(32)]
        public string OutStockNum { get; set; }

        public DateTime? OutDate { get; set; }

        public int? OutMode { get; set; }

        [StringLength(36)]
        public string ContainerCode { get; set; }

        [StringLength(36)]
        public string LocationId { get; set; }

        public int? IsFull { get; set; }

        public int? IsTaskCompleted { get; set; }

        public int? SelectLocationType { get; set; }

        [StringLength(1000)]
        public string Remark { get; set; }

        public int? Attribute1 { get; set; }

        [StringLength(32)]
        public string Attribute2 { get; set; }

        [StringLength(80)]
        public string Attribute3 { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }

        [JsonIgnore]
        public virtual WMS_Location WMS_Location { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WMS_OutDetail> WMS_OutDetail { get; set; }
    }
}
