namespace OracleEfTest.WMSTakModelFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_JXDMX")]
    public partial class WMS_JXDMX
    {
        [StringLength(100)]
        public string JXNO { get; set; }

        public int? JXPO { get; set; }

        [StringLength(100)]
        public string PDNO { get; set; }

        public int? PONO { get; set; }

        public int? OPNO { get; set; }

        public int? SQNO { get; set; }

        public DateTime? STDT { get; set; }

        public DateTime? ENDT { get; set; }

        [StringLength(100)]
        public string CWOC { get; set; }

        
        public decimal? SQSL { get; set; }

        
        public decimal? JXSL { get; set; }

        
        public decimal? PFSL { get; set; }

        [StringLength(100)]
        public string SUNO { get; set; }

        [StringLength(100)]
        public string GMGY { get; set; }

        public int? JXZT { get; set; }

        [StringLength(100)]
        public string ITEM { get; set; }

        public DateTime? JX_DATE { get; set; }

        public DateTime? XQDT { get; set; }

        
        public decimal? XNFL { get; set; }

        public DateTime? STPN { get; set; }

        public DateTime? ENPN { get; set; }

        
        public decimal? TLSL { get; set; }

        [StringLength(100)]
        public string CTPY { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        
        public decimal? PSTL { get; set; }

        public DateTime? PRINT_TIME { get; set; }

        [StringLength(100)]
        public string PSRY { get; set; }

        public int? WLPB { get; set; }

        [StringLength(100)]
        public string WLFS { get; set; }

        [StringLength(100)]
        public string OPRO { get; set; }

        public int? JXFS { get; set; }

        public int? SFYZ { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        [StringLength(100)]
        public string HZJXNO { get; set; }

        [StringLength(100)]
        public string TLNO { get; set; }

        public int? SFMP { get; set; }

        public Guid ID { get; set; }
    }
}
