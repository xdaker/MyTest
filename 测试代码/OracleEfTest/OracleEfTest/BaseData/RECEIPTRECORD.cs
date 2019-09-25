namespace OracleEfTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZBWMS.RECEIPTRECORD")]
    public partial class RECEIPTRECORD
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal RECEIPTLINESYSNO { get; set; }

        public decimal RECEIPTRECORDSTATUS { get; set; }

        public decimal? PACKDETAILSYSNO { get; set; }

        public decimal LOTRECORDSYSNO { get; set; }

        [Required]
        [StringLength(32)]
        public string LOTNUMBER { get; set; }

        [StringLength(32)]
        public string LPNCODE { get; set; }

        public decimal LOCATIONSYSNO { get; set; }

        [StringLength(32)]
        public string LOCATIONCODE { get; set; }

        public decimal? RECEIVEDQTY { get; set; }

        public DateTime ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        [StringLength(2)]
        public string RECIPTSTYLE { get; set; }

        [StringLength(50)]
        public string QRCODE { get; set; }

        [StringLength(64)]
        public string UNCODE { get; set; }

        public decimal? VALVE { get; set; }
    }
}
