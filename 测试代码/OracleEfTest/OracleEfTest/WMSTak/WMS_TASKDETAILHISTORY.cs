namespace OracleEfTest.WMSTak
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WMS.WMS_TASKDETAILHISTORY")]
    public partial class WMS_TASKDETAILHISTORY
    {
        [Key]
        public decimal SYSNO { get; set; }

        public decimal? TASKID { get; set; }

        public decimal? TASKTYPE { get; set; }

        public decimal? TRANTYPE { get; set; }

        public decimal? CONFIRMTYPE { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? SKUSYSNO { get; set; }

        [StringLength(100)]
        public string SKUCODE { get; set; }

        [StringLength(256)]
        public string SKUNAME { get; set; }

        [StringLength(64)]
        public string WAREHOUSECODE { get; set; }

        [StringLength(128)]
        public string WAREHOUSENAME { get; set; }

        [StringLength(64)]
        public string COMPANYCODE { get; set; }

        [StringLength(128)]
        public string COMPANYNAME { get; set; }

        public decimal? PRIORITY { get; set; }

        public decimal? PREPOSEID { get; set; }

        public decimal? POSEID { get; set; }

        [StringLength(32)]
        public string GROUPNAME1 { get; set; }

        [StringLength(64)]
        public string GROUPVALUE1 { get; set; }

        [StringLength(32)]
        public string GROUPNAME2 { get; set; }

        [StringLength(64)]
        public string GROUPVALUE2 { get; set; }

        [StringLength(32)]
        public string GROUPNAME3 { get; set; }

        [StringLength(64)]
        public string GROUPVALUE3 { get; set; }

        public decimal? MARKING { get; set; }

        [StringLength(256)]
        public string WORKINSTRUCTION { get; set; }

        [StringLength(32)]
        public string TICKETNUMBER { get; set; }

        [StringLength(32)]
        public string LOCATIONFROM { get; set; }

        [StringLength(32)]
        public string LOCATIONTO { get; set; }

        [StringLength(32)]
        public string LOCATIONTOOVERRIDE { get; set; }

        [StringLength(32)]
        public string ZONECODE { get; set; }

        [StringLength(32)]
        public string AREACODE { get; set; }

        [StringLength(32)]
        public string AREACODESPREAD { get; set; }

        [StringLength(64)]
        public string PICKINGSEQ { get; set; }

        [StringLength(64)]
        public string CCSEQ { get; set; }

        [StringLength(64)]
        public string PUTSEQ { get; set; }

        [StringLength(64)]
        public string LOT { get; set; }

        [StringLength(64)]
        public string LPNFROM { get; set; }

        [StringLength(64)]
        public string LPNTO { get; set; }

        [StringLength(64)]
        public string TEMPLPN { get; set; }

        [StringLength(64)]
        public string PACKCODE { get; set; }

        public decimal? PACKDETAILSYSNO { get; set; }

        [StringLength(2)]
        public string UMCODE { get; set; }

        [StringLength(64)]
        public string UMCODEDESC { get; set; }

        public decimal? UMQTY { get; set; }

        public decimal? QTY { get; set; }

        public decimal? COMPLETEDQTY { get; set; }

        public decimal? SOURCETYPE { get; set; }

        [StringLength(64)]
        public string SOURCEID { get; set; }

        public decimal? SOURCELINENO { get; set; }

        public decimal? ENGINEID { get; set; }

        public decimal? WAVEID { get; set; }

        [StringLength(32)]
        public string ASSIGNUSERID { get; set; }

        [StringLength(64)]
        public string ASSIGNUSERNAME { get; set; }

        public DateTime? STARTTIME { get; set; }

        [Column(TypeName = "float")]
        public decimal? EXPTIME { get; set; }

        public DateTime? ENDTIME { get; set; }

        [StringLength(32)]
        public string EXECWHO { get; set; }

        [StringLength(64)]
        public string EXECWHONAME { get; set; }

        public DateTime? EXECTIME { get; set; }

        public decimal? ZONESYSNO { get; set; }

        [StringLength(512)]
        public string DES { get; set; }

        public decimal? RV { get; set; }

        [StringLength(64)]
        public string GROUPKEY { get; set; }

        public decimal? CHANGEPLANSYSNO { get; set; }

        public decimal? CANGROUPSTATUS { get; set; }

        [StringLength(32)]
        public string PAGENUMBER { get; set; }

        public DateTime? ROWCREATEDATE { get; set; }

        [StringLength(32)]
        public string CREATEUSERID { get; set; }

        [StringLength(64)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? ROWMODIFYDATE { get; set; }

        [StringLength(32)]
        public string MODIFYUSERID { get; set; }

        [StringLength(64)]
        public string MODIFYUSERNAME { get; set; }

        public decimal? MESSAGEID { get; set; }

        [StringLength(128)]
        public string RETRIEVEVALUE { get; set; }

        public decimal? RELEASEMODEL { get; set; }

        [StringLength(64)]
        public string WAVENUM { get; set; }

        public decimal? MOVETYPE { get; set; }

        public decimal? ENABLE { get; set; }

        [StringLength(128)]
        public string DISPATCHNODEINFO { get; set; }

        public decimal? ISAUTOTASK { get; set; }

        public long? ORDERSYSNO { get; set; }

        public long? ORDERLINESYSNO { get; set; }

        public long? RECEIPTSYSNO { get; set; }

        public long? RECEIPTLINESYSNO { get; set; }

        public decimal? PICKQUEUESYSNO { get; set; }

        public decimal? INV_ID { get; set; }

        [StringLength(10)]
        public string IS_LINE { get; set; }

        [StringLength(1)]
        public string IS_AUDIT { get; set; }

        [StringLength(1)]
        public string IS_WKPICK { get; set; }

        [StringLength(50)]
        public string QCODE { get; set; }

        [StringLength(50)]
        public string RECORDSYSNO { get; set; }

        [StringLength(50)]
        public string RECORDQUESYSNO { get; set; }
    }
}
