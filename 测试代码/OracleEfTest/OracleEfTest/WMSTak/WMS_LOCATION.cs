namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_LOCATION")]
    public partial class WMS_LOCATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WMS_LOCATION()
        {
            WMS_OUTMAIN = new HashSet<WMS_OUTMAIN>();
        }

        [Key]
        [StringLength(36)]
        public string LOCATIONID { get; set; }

        [StringLength(36)]
        public string STORAGEAREAID { get; set; }

        [StringLength(20)]
        public string LOCATIONCODE { get; set; }

        [StringLength(32)]
        public string LOCATIONTYPECODE { get; set; }

        [StringLength(36)]
        public string LANEID { get; set; }

        public int? ROW { get; set; }

        public int? VERTICAL { get; set; }

        public int? LAYER { get; set; }

        public int? OPENSTATUS { get; set; }

        public int? TASKTROUBLESTATUS { get; set; }

        public int? MAXIMUMSIZE { get; set; }

        public int? ATTRIBUTE1 { get; set; }

        [StringLength(32)]
        public string ATTRIBUTE2 { get; set; }

        [StringLength(80)]
        public string ATTRIBUTE3 { get; set; }

        [StringLength(1000)]
        public string REMARK { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WMS_OUTMAIN> WMS_OUTMAIN { get; set; }
    }
}
