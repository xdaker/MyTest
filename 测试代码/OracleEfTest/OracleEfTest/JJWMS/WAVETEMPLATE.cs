namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.WAVETEMPLATE")]
    public partial class WAVETEMPLATE
    {
        [Key]
        public decimal SYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string CODE { get; set; }

        [StringLength(128)]
        public string DESCRIPTION { get; set; }

        public decimal WAREHOUSESYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string WAREHOUSECODE { get; set; }

        [Required]
        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        public decimal MINSKU { get; set; }

        public decimal MAXSKU { get; set; }

        public decimal MINORDERS { get; set; }

        public decimal MAXORDERS { get; set; }

        public decimal WAVEFLOWSYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string WAVEFLOWCODE { get; set; }

        [Required]
        [StringLength(128)]
        public string WAVEFLOWDESC { get; set; }

        public decimal ORDERFILTERSYSNO { get; set; }

        [Required]
        [StringLength(64)]
        public string ORDERFILTERCODE { get; set; }

        [Required]
        [StringLength(128)]
        public string ORDERFILTERNAME { get; set; }

        public decimal ISAUTOEXECUTE { get; set; }

        public decimal ISAUTORELEASE { get; set; }

        public decimal ISREJECTBACKORDER { get; set; }

        public decimal ISCHECKZONEPICKVOLUME { get; set; }

        public decimal ISPICKDIRECTTOPACK { get; set; }

        public decimal ENABLEFLAG { get; set; }

        [StringLength(512)]
        public string COMMENTS { get; set; }

        public DateTime ROWCREATEDATE { get; set; }

        [Required]
        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [Required]
        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime ROWMODIFYDATE { get; set; }

        [Required]
        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [Required]
        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        public decimal PICKTOLOCATION { get; set; }
    }
}
