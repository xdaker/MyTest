namespace OracleEfTest.JJWMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JJWMS.TASKDETAIL")]
    public partial class TASKDETAIL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SYSNO { get; set; }

        public long? TASKID { get; set; }

        public long? TASKTYPE { get; set; }

        public long? TRANTYPE { get; set; }

        public long? CONFIRMTYPE { get; set; }

        [StringLength(10)]
        public string STATUS { get; set; }

        public long? SKUSYSNO { get; set; }

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

        public long? PRIORITY { get; set; }

        public long? PREPOSEID { get; set; }

        public long? POSEID { get; set; }

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

        public long? MARKING { get; set; }

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

        public long? PACKDETAILSYSNO { get; set; }

        [StringLength(10)]
        public string UMCODE { get; set; }

        [StringLength(64)]
        public string UMCODEDESC { get; set; }

        public long? UMQTY { get; set; }

        public decimal? QTY { get; set; }

        public decimal? COMPLETEDQTY { get; set; }

        public long? SOURCETYPE { get; set; }

        [StringLength(64)]
        public string SOURCEID { get; set; }

        public long? SOURCELINENO { get; set; }

        public long? ENGINEID { get; set; }

        public long? WAVEID { get; set; }

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

        public long? ZONESYSNO { get; set; }

        [StringLength(512)]
        public string DES { get; set; }

        public long? RV { get; set; }

        [StringLength(64)]
        public string GROUPKEY { get; set; }

        public long? CHANGEPLANSYSNO { get; set; }

        public long? CANGROUPSTATUS { get; set; }

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

        public long? MESSAGEID { get; set; }

        [StringLength(128)]
        public string RETRIEVEVALUE { get; set; }

        public long? RELEASEMODEL { get; set; }

        [StringLength(64)]
        public string WAVENUM { get; set; }

        public long? MOVETYPE { get; set; }

        public decimal? ENABLE { get; set; }

        [StringLength(128)]
        public string DISPATCHNODEINFO { get; set; }

        [StringLength(2)]
        public string ISAUTOTASK { get; set; }

        public long? ORDERSYSNO { get; set; }

        public long? ORDERLINESYSNO { get; set; }

        public long? RECEIPTSYSNO { get; set; }

        public long? RECEIPTLINESYSNO { get; set; }

        public long? PICKQUEUESYSNO { get; set; }

        public long? INV_ID { get; set; }

        [StringLength(1)]
        public string IS_LINE { get; set; }

        [StringLength(1)]
        public string IS_AUDIT { get; set; }

        [StringLength(1)]
        public string IS_WKPICK { get; set; }

        public decimal? INVNUM { get; set; }

        public decimal? AVERAGE { get; set; }

        [StringLength(50)]
        public string INVUNIT { get; set; }

        [StringLength(50)]
        public string INVUNITCODE { get; set; }

        public decimal? VENDORSYSNO { get; set; }

        [StringLength(50)]
        public string VENDORCODE { get; set; }

        [StringLength(128)]
        public string VENDORNAME { get; set; }

        public decimal? ALREADYQTY { get; set; }

        public decimal? ONINVNUM { get; set; }
    }
}
