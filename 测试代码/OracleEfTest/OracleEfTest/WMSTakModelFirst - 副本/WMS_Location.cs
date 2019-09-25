namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_Location")]
    public partial class WMS_Location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WMS_Location()
        {
            WMS_OutMain = new HashSet<WMS_OutMain>();
        }

        [Key]
        [StringLength(36)]
        public string LocationId { get; set; }

        [StringLength(36)]
        public string StorageAreaId { get; set; }

        [StringLength(20)]
        public string LocationCode { get; set; }

        [StringLength(32)]
        public string LocationTypeCode { get; set; }

        [StringLength(36)]
        public string LaneId { get; set; }

        public int? Row { get; set; }

        public int? Vertical { get; set; }

        public int? Layer { get; set; }

        public int? OpenStatus { get; set; }

        public int? TaskTroubleStatus { get; set; }

        public int? MaximumSize { get; set; }

        public int? Attribute1 { get; set; }

        [StringLength(32)]
        public string Attribute2 { get; set; }

        [StringLength(80)]
        public string Attribute3 { get; set; }

        [StringLength(1000)]
        public string Remark { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WMS_OutMain> WMS_OutMain { get; set; }
    }
}
