namespace OracleEfTest.JJWMS
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class jjwmsModel : DbContext
    {
        public jjwmsModel()
            : base("name=jjwmsModel")
        {
        }

        public virtual DbSet<ACTIVITYLOG> ACTIVITYLOG { get; set; }
        public virtual DbSet<ADJUSTMENT> ADJUSTMENT { get; set; }
        public virtual DbSet<ADJUSTMENTDETAIL> ADJUSTMENTDETAIL { get; set; }
        public virtual DbSet<ALLOCATIONSTRATEGY> ALLOCATIONSTRATEGY { get; set; }
        public virtual DbSet<ALLOCATIONSTRATEGYDETAIL> ALLOCATIONSTRATEGYDETAIL { get; set; }
        public virtual DbSet<AREA> AREA { get; set; }
        public virtual DbSet<AUDITSN> AUDITSN { get; set; }
        public virtual DbSet<AUTO_LOCATION> AUTO_LOCATION { get; set; }
        public virtual DbSet<CCPLAN> CCPLAN { get; set; }
        public virtual DbSet<CCTASK> CCTASK { get; set; }
        public virtual DbSet<CF_PRIVILEGE> CF_PRIVILEGE { get; set; }
        public virtual DbSet<CF_ROLE> CF_ROLE { get; set; }
        public virtual DbSet<CF_USER> CF_USER { get; set; }
        public virtual DbSet<CF_USERROLE> CF_USERROLE { get; set; }
        public virtual DbSet<CURRENT_WAVE> CURRENT_WAVE { get; set; }
        public virtual DbSet<DATAFILTER> DATAFILTER { get; set; }
        public virtual DbSet<INVENTORY> INVENTORY { get; set; }
        public virtual DbSet<INVENTORYCHANGEPLAN> INVENTORYCHANGEPLAN { get; set; }
        public virtual DbSet<INVTRANSACTION> INVTRANSACTION { get; set; }
        public virtual DbSet<LOCATION> LOCATION { get; set; }
        public virtual DbSet<LOGINGLOG> LOGINGLOG { get; set; }
        public virtual DbSet<LOTRECORDS> LOTRECORDS { get; set; }
        public virtual DbSet<ORDEREXCEPTION> ORDEREXCEPTION { get; set; }
        public virtual DbSet<ORDEREXCEPTIONDTL> ORDEREXCEPTIONDTL { get; set; }
        public virtual DbSet<ORDEREXCEPTIONLOG> ORDEREXCEPTIONLOG { get; set; }
        public virtual DbSet<ORDERLINE> ORDERLINE { get; set; }
        public virtual DbSet<ORDERS> ORDERS { get; set; }
        public virtual DbSet<PICKING> PICKING { get; set; }
        public virtual DbSet<PICKINGLINE> PICKINGLINE { get; set; }
        public virtual DbSet<PICKQUEUE> PICKQUEUE { get; set; }
        public virtual DbSet<PICKS> PICKS { get; set; }
        public virtual DbSet<PRINT_SKU> PRINT_SKU { get; set; }
        public virtual DbSet<PRINTER> PRINTER { get; set; }
        public virtual DbSet<PURCHASE> PURCHASE { get; set; }
        public virtual DbSet<PURCHASELINE> PURCHASELINE { get; set; }
        public virtual DbSet<PUTAWAYSTRATEGY> PUTAWAYSTRATEGY { get; set; }
        public virtual DbSet<PUTAWAYSTRATEGYDETAIL> PUTAWAYSTRATEGYDETAIL { get; set; }
        public virtual DbSet<RECEIPT> RECEIPT { get; set; }
        public virtual DbSet<RECEIPTLINE> RECEIPTLINE { get; set; }
        public virtual DbSet<RECEIPTRECORD> RECEIPTRECORD { get; set; }
        public virtual DbSet<RECEIPTRECORDQUEUE> RECEIPTRECORDQUEUE { get; set; }
        public virtual DbSet<SERIAL_INFO> SERIAL_INFO { get; set; }
        public virtual DbSet<SP_DIS_SET> SP_DIS_SET { get; set; }
        public virtual DbSet<STATION> STATION { get; set; }
        public virtual DbSet<STN_CITY_MAP> STN_CITY_MAP { get; set; }
        public virtual DbSet<SYS_MENU> SYS_MENU { get; set; }
        public virtual DbSet<SYS_RPT_MENU> SYS_RPT_MENU { get; set; }
        public virtual DbSet<TASKDETAIL> TASKDETAIL { get; set; }
        public virtual DbSet<TASKENGINE> TASKENGINE { get; set; }
        public virtual DbSet<TASKS> TASKS { get; set; }
        public virtual DbSet<WAREHOUSESKU> WAREHOUSESKU { get; set; }
        public virtual DbSet<WAREHOUSESKUPICKLOCATION> WAREHOUSESKUPICKLOCATION { get; set; }
        public virtual DbSet<WAREHOUSESKUTACTICS> WAREHOUSESKUTACTICS { get; set; }
        public virtual DbSet<WAVE> WAVE { get; set; }
        public virtual DbSet<WAVE_ALL_RESULT> WAVE_ALL_RESULT { get; set; }
        public virtual DbSet<WAVE_CAL_RESULT> WAVE_CAL_RESULT { get; set; }
        public virtual DbSet<WAVE_CURR_SKU> WAVE_CURR_SKU { get; set; }
        public virtual DbSet<WAVEDETAIL> WAVEDETAIL { get; set; }
        public virtual DbSet<WAVEFLOW> WAVEFLOW { get; set; }
        public virtual DbSet<WAVEFLOWDETAIL> WAVEFLOWDETAIL { get; set; }
        public virtual DbSet<WAVETEMPLATE> WAVETEMPLATE { get; set; }
        public virtual DbSet<WORK_LOG> WORK_LOG { get; set; }
        public virtual DbSet<WORKINGCHANGESKU> WORKINGCHANGESKU { get; set; }
        public virtual DbSet<WORKPROFILE> WORKPROFILE { get; set; }
        public virtual DbSet<WORKPROFILEDETAIL> WORKPROFILEDETAIL { get; set; }
        public virtual DbSet<ZONE> ZONE { get; set; }
        public virtual DbSet<CARRIER> CARRIER { get; set; }
        public virtual DbSet<CARTONTYPE> CARTONTYPE { get; set; }
        public virtual DbSet<COMPANY> COMPANY { get; set; }
        public virtual DbSet<CONTRACT> CONTRACT { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMER { get; set; }
        public virtual DbSet<DISPATCHNODE> DISPATCHNODE { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<GROUPCOMPANY> GROUPCOMPANY { get; set; }
        public virtual DbSet<GROUPWAREHOUSE> GROUPWAREHOUSE { get; set; }
        public virtual DbSet<HANSTEMP1> HANSTEMP1 { get; set; }
        public virtual DbSet<HIS_DPS_CMD> HIS_DPS_CMD { get; set; }
        public virtual DbSet<INVENTORYCHANGEPLANHISTORY> INVENTORYCHANGEPLANHISTORY { get; set; }
        public virtual DbSet<LOTATTRTEMPLATE> LOTATTRTEMPLATE { get; set; }
        public virtual DbSet<LOTATTRTEMPLATEITEMS> LOTATTRTEMPLATEITEMS { get; set; }
        public virtual DbSet<OLDSERIALNUMBER> OLDSERIALNUMBER { get; set; }
        public virtual DbSet<ORDERSRECORD> ORDERSRECORD { get; set; }
        public virtual DbSet<PACK> PACK { get; set; }
        public virtual DbSet<PACKDETAIL> PACKDETAIL { get; set; }
        public virtual DbSet<PDAVERSIONSETTINGS> PDAVERSIONSETTINGS { get; set; }
        public virtual DbSet<SEQUENCES> SEQUENCES { get; set; }
        public virtual DbSet<SETTINGS> SETTINGS { get; set; }
        public virtual DbSet<SKU> SKU { get; set; }
        public virtual DbSet<SKUSERIALNUMBERRECORDS> SKUSERIALNUMBERRECORDS { get; set; }
        public virtual DbSet<SKUSERIALNUMBERRECORDS_HIS> SKUSERIALNUMBERRECORDS_HIS { get; set; }
        public virtual DbSet<TASKDETAILHISTORY> TASKDETAILHISTORY { get; set; }
        public virtual DbSet<TYPETABLE> TYPETABLE { get; set; }
        public virtual DbSet<UNIT> UNIT { get; set; }
        public virtual DbSet<USERCOMPANY> USERCOMPANY { get; set; }
        public virtual DbSet<USERGROUP> USERGROUP { get; set; }
        public virtual DbSet<USERWAREHOUSE> USERWAREHOUSE { get; set; }
        public virtual DbSet<VENDOR> VENDOR { get; set; }
        public virtual DbSet<WAREHOUSE> WAREHOUSE { get; set; }
        public virtual DbSet<WMSVERSION> WMSVERSION { get; set; }
        public virtual DbSet<WORKSHOP> WORKSHOP { get; set; }
        public virtual DbSet<WQFCARTON> WQFCARTON { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.WORKTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.WAVESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.WAVENUM)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.RECEIPTSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.RECEIPTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.ORDERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.ORDERNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.SKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.LPN)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.LOCATIONQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.SKUITEMQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.SKUTOTALQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.OPERATORUSERID1)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.OPERATORUSERID2)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.OPERATORUSERNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.OPERATORUSERID3)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.OPERATORUSERNAME3)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.OPERATORUSERID4)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.OPERATORUSERNAME4)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.EXPELAPSEDTIME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.ELAPSEDTIME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ACTIVITYLOG>()
                .Property(e => e.SOURCEID)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENT>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ADJUSTMENT>()
                .Property(e => e.ADJUSTMENTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENT>()
                .Property(e => e.EXTERNADJUSTMENTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENT>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ADJUSTMENT>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENT>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENT>()
                .Property(e => e.COMPANYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ADJUSTMENT>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENT>()
                .Property(e => e.COMPANYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENT>()
                .Property(e => e.ADTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ADJUSTMENT>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ADJUSTMENT>()
                .Property(e => e.REASON)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ADJUSTMENT>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENT>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENT>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENT>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENT>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.ADJUSTMENTSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.EXTERNADJUSTMENTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.DETAILNUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.COMPANYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.COMPANYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.SKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.SKUDESC)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.QTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.LOCATIONSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.LOCATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.LOTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.LPN)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ADJUSTMENTDETAIL>()
                .Property(e => e.INVCHANGEPLANSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALLOCATIONSTRATEGY>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALLOCATIONSTRATEGY>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ALLOCATIONSTRATEGY>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<ALLOCATIONSTRATEGY>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALLOCATIONSTRATEGY>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ALLOCATIONSTRATEGY>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ALLOCATIONSTRATEGYDETAIL>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALLOCATIONSTRATEGYDETAIL>()
                .Property(e => e.STRATEGYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALLOCATIONSTRATEGYDETAIL>()
                .Property(e => e.LINENUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALLOCATIONSTRATEGYDETAIL>()
                .Property(e => e.ORDERTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALLOCATIONSTRATEGYDETAIL>()
                .Property(e => e.UMCODE)
                .IsUnicode(false);

            modelBuilder.Entity<ALLOCATIONSTRATEGYDETAIL>()
                .Property(e => e.LOCATIONFILTERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALLOCATIONSTRATEGYDETAIL>()
                .Property(e => e.ALLOCATIONRULE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALLOCATIONSTRATEGYDETAIL>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ALLOCATIONSTRATEGYDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ALLOCATIONSTRATEGYDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<AREA>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AREA>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<AREA>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<AREA>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<AREA>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITSN>()
                .Property(e => e.SYSNO)
                .HasPrecision(18, 3);

            modelBuilder.Entity<AUDITSN>()
                .Property(e => e.SERIALNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITSN>()
                .Property(e => e.SKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<AUDITSN>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITSN>()
                .Property(e => e.LPN)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITSN>()
                .Property(e => e.LC_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITSN>()
                .Property(e => e.ORDERLINESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<AUDITSN>()
                .Property(e => e.ROWCREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITSN>()
                .Property(e => e.LPNTO)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITSN>()
                .Property(e => e.ORDERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<AUDITSN>()
                .Property(e => e.EXTERNORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITSN>()
                .Property(e => e.ORDERNUM)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITSN>()
                .Property(e => e.WAVENUM)
                .IsUnicode(false);

            modelBuilder.Entity<AUTO_LOCATION>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<AUTO_LOCATION>()
                .Property(e => e.LOC_NO)
                .IsUnicode(false);

            modelBuilder.Entity<AUTO_LOCATION>()
                .Property(e => e.BAY)
                .IsUnicode(false);

            modelBuilder.Entity<AUTO_LOCATION>()
                .Property(e => e.LEVELNO)
                .IsUnicode(false);

            modelBuilder.Entity<AUTO_LOCATION>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<AUTO_LOCATION>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<AUTO_LOCATION>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<AUTO_LOCATION>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<AUTO_LOCATION>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<AUTO_LOCATION>()
                .Property(e => e.LC_ST)
                .IsUnicode(false);

            modelBuilder.Entity<AUTO_LOCATION>()
                .Property(e => e.LPN_NO)
                .IsUnicode(false);

            modelBuilder.Entity<AUTO_LOCATION>()
                .Property(e => e.DVC_NO)
                .IsUnicode(false);

            modelBuilder.Entity<AUTO_LOCATION>()
                .Property(e => e.SKU_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.PLANID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.ISCHANGERECORD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.CHANGEDAYS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.ISINVENTORYAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.INVENTORYAGEDAYS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.ISPICKTOPERCENTAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.PERCENTAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.ISSKUCCRECORD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.ISDELETESAMETASK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.ISBLIND)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.MAXRECORD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.ISCREATETICKET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.MAXTICKETRECORD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.TASKPRIORITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.COMPANYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.COMPANYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.SKUFILTERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.SKUFILTERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.LOCATIONFILTERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCPLAN>()
                .Property(e => e.LOCATIONFILTERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.TASKID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.PLANID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.BATCHTIME)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.PRIORITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.LOCATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.ZONECODE)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.LPN)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.LOTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.QTYCOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.QTYRECOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.CHECKMETHOD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.TICKETNUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.ISBLIND)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.ASSIGNUSER)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.COMPANYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.COMPANYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.LOCATIONSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.SKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.SKUDESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.UNITQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.REASSIGNUSER)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.QTYCOUNTINV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.QTYRECOUNTINV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.QTYCOUNTDIFF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.QTYRECOUNTDIFF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.CCSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.ISAUTO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.AVERAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.INVUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.VENDORSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.VENDORCODE)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.VENDORNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CCTASK>()
                .Property(e => e.INVQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CF_PRIVILEGE>()
                .Property(e => e.P_MASTER)
                .IsUnicode(false);

            modelBuilder.Entity<CF_PRIVILEGE>()
                .Property(e => e.P_ACCESS)
                .IsUnicode(false);

            modelBuilder.Entity<CF_PRIVILEGE>()
                .Property(e => e.P_OPERATION)
                .IsUnicode(false);

            modelBuilder.Entity<CF_PRIVILEGE>()
                .Property(e => e.ADD_WHO)
                .IsUnicode(false);

            modelBuilder.Entity<CF_PRIVILEGE>()
                .Property(e => e.EDIT_WHO)
                .IsUnicode(false);

            modelBuilder.Entity<CF_PRIVILEGE>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<CF_ROLE>()
                .Property(e => e.ROLE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CF_ROLE>()
                .Property(e => e.ROLE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CF_ROLE>()
                .Property(e => e.ROLE_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<CF_ROLE>()
                .Property(e => e.ADD_WHO)
                .IsUnicode(false);

            modelBuilder.Entity<CF_ROLE>()
                .Property(e => e.EDIT_WHO)
                .IsUnicode(false);

            modelBuilder.Entity<CF_ROLE>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<CF_ROLE>()
                .Property(e => e.WH_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CF_USER>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CF_USER>()
                .Property(e => e.DEFAULTWAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CF_USER>()
                .Property(e => e.WORKPROFILESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CF_USER>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CF_USER>()
                .Property(e => e.USERPWD)
                .IsUnicode(false);

            modelBuilder.Entity<CF_USER>()
                .Property(e => e.ISADMIN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CF_USER>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<CF_USER>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<CF_USER>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CF_USERROLE>()
                .Property(e => e.USER_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CF_USERROLE>()
                .Property(e => e.ROLE_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CF_USERROLE>()
                .Property(e => e.ADD_WHO)
                .IsUnicode(false);

            modelBuilder.Entity<CF_USERROLE>()
                .Property(e => e.EDIT_WHO)
                .IsUnicode(false);

            modelBuilder.Entity<CF_USERROLE>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<CF_USERROLE>()
                .Property(e => e.WH_NO)
                .IsUnicode(false);

            modelBuilder.Entity<CURRENT_WAVE>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CURRENT_WAVE>()
                .Property(e => e.WAVENUM)
                .IsUnicode(false);

            modelBuilder.Entity<CURRENT_WAVE>()
                .Property(e => e.WAVENUM_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CURRENT_WAVE>()
                .Property(e => e.WAVESTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CURRENT_WAVE>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<CURRENT_WAVE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CURRENT_WAVE>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CURRENT_WAVE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CURRENT_WAVE>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<DATAFILTER>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DATAFILTER>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<DATAFILTER>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<DATAFILTER>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<DATAFILTER>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<DATAFILTER>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.COMPANYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.SKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.LOCATIONSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.LOCATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.LOTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.LPN)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.QTYONHAND)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.ISHOLD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.INVSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.DISQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.QTYPICK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.NETWEIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.GROSSWEIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.INVNUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.AVERAGEWEIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.UNITCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.INVUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.INVUNITCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.VENDORSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.VENDORCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.VENDORNAME)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORY>()
                .Property(e => e.DISCHARGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.TRANTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.QTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.FROMLOCCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.TOLOCCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.FROMLPN)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.ISWHOLEPLATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.TOLPN)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.LOTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.TEMPLPN)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.QTYINTRANSIT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.INVNUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.AVERAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORYCHANGEPLAN>()
                .Property(e => e.ALREADYNUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.TRANID)
                .IsUnicode(false);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.TRANTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.SYSTEMTRANTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.SYSTEMINVCHANGEPLANID)
                .IsUnicode(false);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.LPNFROM)
                .IsUnicode(false);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.QTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.PACKDETAILSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.ISWHOLEPLATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.SOURCETYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.SOURCEID)
                .IsUnicode(false);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.LOTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.AVERAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.UNITCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.INVUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.INVUNITCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVTRANSACTION>()
                .Property(e => e.RECEIPTNUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.SECTION)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.PUTZONE)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.ALLOCZONE)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.CCZONE)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.HIGHVALUE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.BAY)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.LEVELNO)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.POSITION)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.LENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.WIDTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.HEIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.CUBE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.WEIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.PICKINGSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.CCSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.PUTSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.INVENTORYSTS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.LOCATIONSTS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.LOCATIONTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.MOVEMENTTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.CHECKDIGIT)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.XCOORD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.YCOORD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.ZCOORD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.COMMINGLESKU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.COMMINGLELOT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.ISLOSTLPN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.ISIGNORECAPACITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.ISSHOW)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.PARALLELISM_ST)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.DEFULTSKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.DEFULTSKU)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.DEEP)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.ISIGNORESCALE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOGINGLOG>()
                .Property(e => e.WORK_ID)
                .HasPrecision(22, 0);

            modelBuilder.Entity<LOGINGLOG>()
                .Property(e => e.WORK_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<LOTRECORDS>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOTRECORDS>()
                .Property(e => e.LOTATTRSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOTRECORDS>()
                .Property(e => e.LOTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<LOTRECORDS>()
                .Property(e => e.SKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOTRECORDS>()
                .Property(e => e.COMPANYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOTRECORDS>()
                .Property(e => e.PACKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<LOTRECORDS>()
                .Property(e => e.VALUEDESC)
                .IsUnicode(false);

            modelBuilder.Entity<LOTRECORDS>()
                .Property(e => e.MD5)
                .IsUnicode(false);

            modelBuilder.Entity<LOTRECORDS>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<LOTRECORDS>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.EXCEPTIONNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.GENTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.ORDERNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.ORDERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.DEPT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.REASON)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.CANCELUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.CANCELUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.CONFIRMUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.CONFIRMUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.DEALUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.DEALUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.WAVENUM)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.WAVESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.EXCEPTIOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.EXTERNORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTION>()
                .Property(e => e.ERRTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONDTL>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDEREXCEPTIONDTL>()
                .Property(e => e.ORDERLINENUM)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONDTL>()
                .Property(e => e.ORDERNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONDTL>()
                .Property(e => e.EXTERNORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONDTL>()
                .Property(e => e.SKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDEREXCEPTIONDTL>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONDTL>()
                .Property(e => e.SKUDESC)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONDTL>()
                .Property(e => e.QTYORDERED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDEREXCEPTIONDTL>()
                .Property(e => e.QTYSHORT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDEREXCEPTIONDTL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONDTL>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONDTL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONDTL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONDTL>()
                .Property(e => e.REASON)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONDTL>()
                .Property(e => e.ERRTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONDTL>()
                .Property(e => e.REASONDESC)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONLOG>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDEREXCEPTIONLOG>()
                .Property(e => e.EXCEPTIONSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDEREXCEPTIONLOG>()
                .Property(e => e.EXCEPTIONNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONLOG>()
                .Property(e => e.DEALNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONLOG>()
                .Property(e => e.DEALLOG)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONLOG>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONLOG>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONLOG>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONLOG>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEREXCEPTIONLOG>()
                .Property(e => e.REASONDESC)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.ORDERLINENUM)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.ORDERNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.EXTERNORDERLINENUM)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.SKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.ORDERLINESTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.QTYORDERED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.QTYALLOCATED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.QTYPICKED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.QTYSHIPPED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.WEIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.ORDERLINETYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.WORKISOVER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.QTYCHANGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.CARDTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.PRODUCTTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.PACKTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.CARDNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.PROCESSINGTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.PROCESSINGCONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.PACKAGEID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.DETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.IS_CARD_USER)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.IS_AUDIT_ECCARD)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.INVUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.NUMBERALLOCATED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.NUMBERPICK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.STYLE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.TECHNICSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.TECHNICSLINE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.INVUSABLENUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.TECHNICSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.SORTNUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.RECEIVINGWAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERLINE>()
                .Property(e => e.RECEIVINGWAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ORDERNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ORDERTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.BUSINESSTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.WORKSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.EXTERNORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.EXTERNORDERTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.COMPANYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.COMPANYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.CUSTOMERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.CUSTOMERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.CUSTOMERCLASS)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.CUSTOMERTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.SALESMANID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.SALESMANTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.RCADDRESSDESC)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.RCPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.RCUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.RCZIP)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.RCAREAID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.RCAREADESC)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.DELIVERYHUBID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.DELIVERYHUBDESC)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.DELIVERYMETHODID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.DELIVERYMETHODDESC)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.WAVESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.WAVENUM)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.DISPATCHNODESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.DISPATCHNODENAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.PAYMETHOD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.PAYAMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.INVOICESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ISAUTOINVOICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.INVOICETYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.PRIORITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ZONECOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ISCONTAINLARGEAPPLIANCES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ISCONTAINSERVICEPRODUCTS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ISCROSSWH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ISSEPARATEINVOICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ISNEUTRALPACKING)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.DELIVERYDATETIMESPAN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.AUDITDELIVERYTIMESPAN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.RCMOBILEPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.DELIVERYMEMO)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ISSIGNBYOTHERS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.PAYMETHODNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ISALLOWPARTSHIP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.NUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ORDERSIZE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.RCUSERNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.RCPHONE2)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.SHIPMENTSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.SRCSYSTEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ISSUSPEND)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.SUSPENDREASON)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ISVAT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ISHIDEAMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.TOOTHERWAREHOSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ISHAVEINVOICED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.TICKETNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ISBINDDPS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.IO_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.LOGISTICS)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.WEIGHT)
                .HasPrecision(8, 2);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.LOGISTICS_NO)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.PICKINGTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.PRODUCETYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.ISPRINT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.DEPARTMENT)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.WORKSHOP)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.PRODUCTIONLINE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.WORKSHOPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.PRODUCTIONLINECODE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.AUDITOR)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERS>()
                .Property(e => e.RECEIVINGDEPARTMENT)
                .IsUnicode(false);

            modelBuilder.Entity<PICKING>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PICKING>()
                .Property(e => e.PICKINGNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PICKING>()
                .Property(e => e.PICKINGTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PICKING>()
                .Property(e => e.BUSINESSTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PICKING>()
                .Property(e => e.WORKSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PICKING>()
                .Property(e => e.PICKDATE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKING>()
                .Property(e => e.PICKINGER)
                .IsUnicode(false);

            modelBuilder.Entity<PICKING>()
                .Property(e => e.CUSTOMERID)
                .IsUnicode(false);

            modelBuilder.Entity<PICKING>()
                .Property(e => e.CUSTOMERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PICKING>()
                .Property(e => e.RCPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKING>()
                .Property(e => e.RCADDRESSDESC)
                .IsUnicode(false);

            modelBuilder.Entity<PICKING>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<PICKING>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PICKING>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PICKINGLINE>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PICKINGLINE>()
                .Property(e => e.PICKINGSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PICKINGLINE>()
                .Property(e => e.PICKINGNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PICKINGLINE>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKINGLINE>()
                .Property(e => e.SKUNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PICKINGLINE>()
                .Property(e => e.STYLE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKINGLINE>()
                .Property(e => e.MATERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<PICKINGLINE>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PICKINGLINE>()
                .Property(e => e.UNITCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKINGLINE>()
                .Property(e => e.QTYORDERED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PICKINGLINE>()
                .Property(e => e.QTYPICKED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PICKINGLINE>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PICKINGLINE>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKINGLINE>()
                .Property(e => e.PICKINGSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PICKINGLINE>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<PICKINGLINE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PICKINGLINE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.COMPANYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.SKUNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.ORDERNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.WAVENUM)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.LOCATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.ZONECODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.LOCATIONTOCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.LPN)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.PACKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.UMCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.CARTONTO)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.QTY)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.QTYPICKED)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.QTYSORTED)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.QTYPACKED)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.QTYSHIPPED)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.ENGINEID)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.QTYCHANGE)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PICKQUEUE>()
                .Property(e => e.LPNTO)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.COMPANYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.SKUNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.ORDERNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.WAVENUM)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.LOCATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.ZONECODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.LOCATIONTOCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.LPN)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.PACKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.UMCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.CARTONTO)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.QTY)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.QTYPICKED)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.QTYSORTED)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.QTYPACKED)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.QTYSHIPPED)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<PICKS>()
                .Property(e => e.QTYOUTSTOCK)
                .HasPrecision(18, 3);

            modelBuilder.Entity<PRINT_SKU>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRINT_SKU>()
                .Property(e => e.SKU_NO)
                .IsUnicode(false);

            modelBuilder.Entity<PRINT_SKU>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PRINT_SKU>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PRINT_SKU>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<PRINT_SKU>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PRINT_SKU>()
                .Property(e => e.MODIFYUSERNAME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRINT_SKU>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRINT_SKU>()
                .Property(e => e.CURRENT_NO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRINT_SKU>()
                .Property(e => e.SKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRINTER>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRINTER>()
                .Property(e => e.PROCESS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRINTER>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRINTER>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<PRINTER>()
                .Property(e => e.ZONESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRINTER>()
                .Property(e => e.ZONECODE)
                .IsUnicode(false);

            modelBuilder.Entity<PRINTER>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRINTER>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PRINTER>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.SRCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.SRCTTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.VENDORCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.VENDORNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.VENDORADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.VENDORCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.WAREHOUSECONTRACT)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.WAREHOUSEPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.COMPANYSYSNO)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.COMPANYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.PURCHASER)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.SHIPPINGTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.SRCSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.SRCDATE)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.CONTRACT)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.CLOSEDUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.CLOSEDUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.FILE1)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.FILE2)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.FILE3)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.FILE4)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.FILE5)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.FILE6)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.FILE7)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.FILE8)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.FILE9)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASE>()
                .Property(e => e.FILE10)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.SKUNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.MATERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.STYLE)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.PURCHASESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.PURCHASESRCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.VENDORCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.VENDORNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.COMPANYSYSNO)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.COMPANYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.SKUSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.ALLQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.PURCHASEWEIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.WEIGHTUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.UMCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.QTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.ISEXCEED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.STAYWEIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.ALREADYWEIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.FILE1)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.FILE2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.FILE3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.FILE4)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.FILE5)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.FILE6)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.FILE7)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.FILE8)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.FILE9)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.FILE10)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.ISURGEN)
                .IsUnicode(false);

            modelBuilder.Entity<PURCHASELINE>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PUTAWAYSTRATEGY>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PUTAWAYSTRATEGY>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PUTAWAYSTRATEGY>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<PUTAWAYSTRATEGY>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PUTAWAYSTRATEGY>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PUTAWAYSTRATEGY>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PUTAWAYSTRATEGYDETAIL>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PUTAWAYSTRATEGYDETAIL>()
                .Property(e => e.PUTAWAYSTRATEGYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PUTAWAYSTRATEGYDETAIL>()
                .Property(e => e.LINENUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PUTAWAYSTRATEGYDETAIL>()
                .Property(e => e.RECEIPTTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PUTAWAYSTRATEGYDETAIL>()
                .Property(e => e.PUTAWAYRULE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PUTAWAYSTRATEGYDETAIL>()
                .Property(e => e.LOCATIONFILTERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PUTAWAYSTRATEGYDETAIL>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PUTAWAYSTRATEGYDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PUTAWAYSTRATEGYDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.RECEIPTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.RECEIPTTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.SRCNUM)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.RECEIPTSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.WAREHOUSECONTRACT)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.WAREHOUSEPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.COMPANYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.COMPANYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.PURCHASER)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.SHIPPINGTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.CLOSEDUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.CLOSEDUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.CANCELUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.CANCELUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.VENDORSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.VENDORCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.VENDORNAME)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.VENDORADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.VENDORRETURNADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.VENDORCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.VENDORPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.VENDORFAX)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.SALESMAN)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.PRIORITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.CARRIERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.CARRIERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.CARRIERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.SONUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.HOSTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.TRAILERID)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.COMMENTIN)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.COMMENTOUT)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.NUM_NO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.SRCSYSTEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.TICKETNAME)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.SRCNUM2)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.ISCROSSWAREHOUSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.ISFACTORYSEND)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.AUDITOR)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.WORKSHOP)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.PRODUCTIONLINE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.APPLICANT)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.WORKSHOPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.PRODUCTIONLINECODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.SHIPPINGDEPARTMENT)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.RECEIVINGDEPARTMENT)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPT>()
                .Property(e => e.RECEIVINGER)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.RECEIPTSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.SKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.COMPANYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.COMPANYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.RECEIPTSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.UMCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.EXPECTEDQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.RECEIVEDQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.ADJUSTEDQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.PNFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.SERIALNOFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.LINENUM)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.ISDELETE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.ISICSONNOPRINTED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.ISWQFREENOPRINTED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.WEIGHTUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.WEIGHTUNITCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.AVERAGEWEIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.NUMUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.INVNUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.VENDORSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.VENDORCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.VENDORNAME)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.STYLE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.TAXRATE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.COLLECTTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.RETURNNUM)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.RETURNQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.SEQ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.ISURGENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.ORDERQUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.APPLICATIONSQUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.STORAGEQUANTITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.RETURNMATERIALREASON)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.SORTNUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.DELIVERYWAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTLINE>()
                .Property(e => e.DELIVERYWAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.RECEIPTLINESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.RECEIPTRECORDSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.PACKDETAILSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.LOTRECORDSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.LOTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.LPNCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.LOCATIONSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.LOCATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.RECEIVEDQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.RECIPTSTYLE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.RECEIPTNUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.AVERAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.UNITCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.INVUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.INVUNITCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.VENDORSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.VENDORCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORD>()
                .Property(e => e.VENDORNAME)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.SOURCETYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.RECEIPTTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.SOURCELINENO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.RECEIPTSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.RECEIPTLINESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.SKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.COMPANYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.LOCATIONSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.LOCATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.PACKDETAILSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.LOTRECORDSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.LOTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.LPNCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.UMCODE)
                .IsFixedLength();

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.UMQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.QTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.ENGINEID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.DEALSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.UPDATEVERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.LOCATIONFROM)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.LOCATIONTO)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.PICKINGSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.PUTSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.CCSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.ZONECODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.PACKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.RECIPTSTYLE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.RECEIPTNUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.AVERAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.UNITCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.INVUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.INVUNITCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.VENDORSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.VENDORCODE)
                .IsUnicode(false);

            modelBuilder.Entity<RECEIPTRECORDQUEUE>()
                .Property(e => e.VENDORNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SERIAL_INFO>()
                .Property(e => e.SERIAL_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SERIAL_INFO>()
                .Property(e => e.SERIAL_QZ)
                .IsUnicode(false);

            modelBuilder.Entity<SERIAL_INFO>()
                .Property(e => e.CUR_DAY)
                .IsUnicode(false);

            modelBuilder.Entity<SERIAL_INFO>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<SP_DIS_SET>()
                .Property(e => e.DIS_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SP_DIS_SET>()
                .Property(e => e.SP_AREA)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STATION>()
                .Property(e => e.ST_NO)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.ST_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.ST_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.MODIFYUSERNAME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STATION>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STATION>()
                .Property(e => e.IS_LOCK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STATION>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.WCS_ST_NO)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.WCS_ST_NO_IN)
                .IsUnicode(false);

            modelBuilder.Entity<STATION>()
                .Property(e => e.WCS_ST_NO_OUT)
                .IsUnicode(false);

            modelBuilder.Entity<STN_CITY_MAP>()
                .Property(e => e.STN_NO)
                .IsUnicode(false);

            modelBuilder.Entity<STN_CITY_MAP>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<STN_CITY_MAP>()
                .Property(e => e.CITY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<STN_CITY_MAP>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.ACTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_MENU>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_RPT_MENU>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_RPT_MENU>()
                .Property(e => e.ACTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_RPT_MENU>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_RPT_MENU>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SYS_RPT_MENU>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_RPT_MENU>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_RPT_MENU>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_RPT_MENU>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_RPT_MENU>()
                .Property(e => e.RPTURL)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.SKUNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.COMPANYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.GROUPNAME1)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.GROUPVALUE1)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.GROUPNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.GROUPVALUE2)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.GROUPNAME3)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.GROUPVALUE3)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.WORKINSTRUCTION)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.TICKETNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.LOCATIONFROM)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.LOCATIONTO)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.LOCATIONTOOVERRIDE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.ZONECODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.AREACODESPREAD)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.PICKINGSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.CCSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.PUTSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.LPNFROM)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.LPNTO)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.TEMPLPN)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.PACKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.UMCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.UMCODEDESC)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.QTY)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.COMPLETEDQTY)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.SOURCEID)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.ASSIGNUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.ASSIGNUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.EXPTIME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.EXECWHO)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.EXECWHONAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.DES)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.GROUPKEY)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.PAGENUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.RETRIEVEVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.WAVENUM)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.ENABLE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.DISPATCHNODEINFO)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.ISAUTOTASK)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.IS_LINE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.IS_AUDIT)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.IS_WKPICK)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.INVNUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.AVERAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.INVUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.INVUNITCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.VENDORSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.VENDORCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.VENDORNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.ALREADYQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAIL>()
                .Property(e => e.ONINVNUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.OBJECTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.ENGINECODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.EGTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.PRIORITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.ONEDIMENSIONFILTER)
                .IsUnicode(false);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.RETRIEVEVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.GROUPNAME1)
                .IsUnicode(false);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.GROUPVALUE1)
                .IsUnicode(false);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.GROUPNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.GROUPVALUE2)
                .IsUnicode(false);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.GROUPNAME3)
                .IsUnicode(false);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.GROUPVALUE3)
                .IsUnicode(false);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.CONFIRMTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.TASKINSTRUCTION)
                .IsUnicode(false);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.MARKING)
                .IsUnicode(false);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.RELEASEMODEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.MAXRECORDS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.MAXCUBE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.EXPTIME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.INTPROPERTYONE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.INTPROPERTYTWO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.INTPROPERTYTHREE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.STRINGPROPERTYONE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.STRINGPROPERTYTWO)
                .IsUnicode(false);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.STRINGPROPERTYTHREE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.ONEFILTERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.TWOFILTERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.LOCATIONMODEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.ISLPNTOSAMELOC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.PICKTOLOCATION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.ISCOLLECTAFTERPICK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKENGINE>()
                .Property(e => e.SOURCETYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKS>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<TASKS>()
                .Property(e => e.GROUPNAME1)
                .IsUnicode(false);

            modelBuilder.Entity<TASKS>()
                .Property(e => e.GROUPVALUE1)
                .IsUnicode(false);

            modelBuilder.Entity<TASKS>()
                .Property(e => e.GROUPNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<TASKS>()
                .Property(e => e.GROUPVALUE2)
                .IsUnicode(false);

            modelBuilder.Entity<TASKS>()
                .Property(e => e.GROUPNAME3)
                .IsUnicode(false);

            modelBuilder.Entity<TASKS>()
                .Property(e => e.GROUPVALUE3)
                .IsUnicode(false);

            modelBuilder.Entity<TASKS>()
                .Property(e => e.RETRIEVEVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKS>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<TASKS>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKS>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<TASKS>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKS>()
                .Property(e => e.GROUPKEY)
                .IsUnicode(false);

            modelBuilder.Entity<TASKS>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKS>()
                .Property(e => e.COMPANYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKS>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKS>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKU>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKU>()
                .Property(e => e.SKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKU>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKU>()
                .Property(e => e.COMPANYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKU>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKU>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKU>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKU>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKU>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKU>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKUPICKLOCATION>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKUPICKLOCATION>()
                .Property(e => e.WAREHOUSESKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKUPICKLOCATION>()
                .Property(e => e.LOCATIONSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKUPICKLOCATION>()
                .Property(e => e.LOCATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKUPICKLOCATION>()
                .Property(e => e.ZONESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKUPICKLOCATION>()
                .Property(e => e.ZONECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKUPICKLOCATION>()
                .Property(e => e.UMCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKUPICKLOCATION>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKUPICKLOCATION>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKUPICKLOCATION>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKUPICKLOCATION>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKUPICKLOCATION>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.WAREHOUSESKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.ALLOCATIONSTRATEGYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.ALLOCATIONSTRATEGYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.PUTAWAYSTRATEGYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.PUTAWAYSTRATEGYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.INLOCSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.INLOC)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.PUTZONESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.PUTLOCATIONSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.CYCLECOUNTFEQ)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.REORDERPOINT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.REORDERQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.ISNONTASK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.HIGHVALUE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.PICKZONESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSESKUTACTICS>()
                .Property(e => e.PICKZONENAME)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVE>()
                .Property(e => e.WAVENUM)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE>()
                .Property(e => e.WAVETEMPLATESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVE>()
                .Property(e => e.WAVETEMPLATECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE>()
                .Property(e => e.DISPATCHNODESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVE>()
                .Property(e => e.DISPATCHNODECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVE>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE>()
                .Property(e => e.CREATEMODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVE>()
                .Property(e => e.WAVESTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVE>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE>()
                .Property(e => e.COLLECTUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE>()
                .Property(e => e.COLLECTUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE>()
                .Property(e => e.NUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVE>()
                .Property(e => e.RV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVE_ALL_RESULT>()
                .Property(e => e.EXTERNORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_ALL_RESULT>()
                .Property(e => e.ORDERNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_ALL_RESULT>()
                .Property(e => e.WAVENUM)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_ALL_RESULT>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_ALL_RESULT>()
                .Property(e => e.SKUNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_ALL_RESULT>()
                .Property(e => e.SKUCLASS)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_ALL_RESULT>()
                .Property(e => e.REASON)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_ALL_RESULT>()
                .Property(e => e.ORDERQTY)
                .HasPrecision(18, 3);

            modelBuilder.Entity<WAVE_CAL_RESULT>()
                .Property(e => e.EXTERNORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_CAL_RESULT>()
                .Property(e => e.ORDERNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_CAL_RESULT>()
                .Property(e => e.WAVENUM)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_CAL_RESULT>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_CAL_RESULT>()
                .Property(e => e.SKUNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_CAL_RESULT>()
                .Property(e => e.SKUCLASS)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_CAL_RESULT>()
                .Property(e => e.REASON)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_CAL_RESULT>()
                .Property(e => e.ORDERQTY)
                .HasPrecision(18, 3);

            modelBuilder.Entity<WAVE_CURR_SKU>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVE_CURR_SKU>()
                .Property(e => e.WAVENUM)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_CURR_SKU>()
                .Property(e => e.ORDERNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_CURR_SKU>()
                .Property(e => e.EXTERNORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_CURR_SKU>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_CURR_SKU>()
                .Property(e => e.SKUNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_CURR_SKU>()
                .Property(e => e.LOCATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_CURR_SKU>()
                .Property(e => e.LPN)
                .IsUnicode(false);

            modelBuilder.Entity<WAVE_CURR_SKU>()
                .Property(e => e.QTY)
                .HasPrecision(18, 3);

            modelBuilder.Entity<WAVEDETAIL>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVEDETAIL>()
                .Property(e => e.WAVESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVEDETAIL>()
                .Property(e => e.WAVENUM)
                .IsUnicode(false);

            modelBuilder.Entity<WAVEDETAIL>()
                .Property(e => e.ORDERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVEDETAIL>()
                .Property(e => e.ORDERNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WAVEDETAIL>()
                .Property(e => e.WAVEORDERSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVEDETAIL>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<WAVEDETAIL>()
                .Property(e => e.SEQUENCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVEDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAVEDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAVEFLOW>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVEFLOW>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAVEFLOW>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVEFLOW>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAVEFLOW>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVEFLOW>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<WAVEFLOW>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAVEFLOW>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAVEFLOWDETAIL>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVEFLOWDETAIL>()
                .Property(e => e.WAVEFLOWSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVEFLOWDETAIL>()
                .Property(e => e.WAVEFLOWCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAVEFLOWDETAIL>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAVEFLOWDETAIL>()
                .Property(e => e.SEQUENCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVEFLOWDETAIL>()
                .Property(e => e.STEP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVEFLOWDETAIL>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVEFLOWDETAIL>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<WAVEFLOWDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAVEFLOWDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.MINSKU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.MAXSKU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.MINORDERS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.MAXORDERS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.WAVEFLOWSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.WAVEFLOWCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.ORDERFILTERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.ORDERFILTERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.ISAUTOEXECUTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.ISAUTORELEASE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.ISREJECTBACKORDER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.ISCHECKZONEPICKVOLUME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.ISPICKDIRECTTOPACK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAVETEMPLATE>()
                .Property(e => e.PICKTOLOCATION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WORK_LOG>()
                .Property(e => e.WORK_ID)
                .HasPrecision(22, 0);

            modelBuilder.Entity<WORK_LOG>()
                .Property(e => e.WORK_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WORK_LOG>()
                .Property(e => e.LPN_NO)
                .IsUnicode(false);

            modelBuilder.Entity<WORK_LOG>()
                .Property(e => e.WORK_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WORK_LOG>()
                .Property(e => e.WORK_MSG)
                .IsUnicode(false);

            modelBuilder.Entity<WORK_LOG>()
                .Property(e => e.WORK_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<WORK_LOG>()
                .Property(e => e.WORK_SEC)
                .HasPrecision(10, 4);

            modelBuilder.Entity<WORK_LOG>()
                .Property(e => e.WORK_PER_NO)
                .IsUnicode(false);

            modelBuilder.Entity<WORK_LOG>()
                .Property(e => e.WORK_PER_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.SKUNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.LOCATIONFROM)
                .IsUnicode(false);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.LOCATIONTO)
                .IsUnicode(false);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.LPNFROM)
                .IsUnicode(false);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.LPNTO)
                .IsUnicode(false);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.TEMPLPN)
                .IsUnicode(false);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.QTY)
                .HasPrecision(18, 3);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.OPERTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.COMPLETEDQTY)
                .HasPrecision(18, 3);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.EXTERNORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.WAVENO)
                .IsUnicode(false);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.ORDERNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WORKINGCHANGESKU>()
                .Property(e => e.TASKTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WORKPROFILE>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WORKPROFILE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WORKPROFILE>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<WORKPROFILE>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WORKPROFILE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WORKPROFILE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WORKPROFILEDETAIL>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WORKPROFILEDETAIL>()
                .Property(e => e.PROFILESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WORKPROFILEDETAIL>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WORKPROFILEDETAIL>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<WORKPROFILEDETAIL>()
                .Property(e => e.WORKTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WORKPROFILEDETAIL>()
                .Property(e => e.DIRECTTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WORKPROFILEDETAIL>()
                .Property(e => e.PRIORITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WORKPROFILEDETAIL>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<WORKPROFILEDETAIL>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WORKPROFILEDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WORKPROFILEDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ZONE>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ZONE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<ZONE>()
                .Property(e => e.ZONETYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ZONE>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<ZONE>()
                .Property(e => e.INLOC)
                .IsUnicode(false);

            modelBuilder.Entity<ZONE>()
                .Property(e => e.OUTLOC)
                .IsUnicode(false);

            modelBuilder.Entity<ZONE>()
                .Property(e => e.CHECKMETHOD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ZONE>()
                .Property(e => e.PICKMETHOD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ZONE>()
                .Property(e => e.XCOORD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ZONE>()
                .Property(e => e.YCOORD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ZONE>()
                .Property(e => e.ZCOORD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ZONE>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ZONE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ZONE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ZONE>()
                .Property(e => e.ISCOLLECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CARRIER>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CARRIER>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CARRIER>()
                .Property(e => e.ZIP)
                .IsUnicode(false);

            modelBuilder.Entity<CARRIER>()
                .Property(e => e.CONTACT1)
                .IsUnicode(false);

            modelBuilder.Entity<CARRIER>()
                .Property(e => e.PHONE1)
                .IsUnicode(false);

            modelBuilder.Entity<CARRIER>()
                .Property(e => e.MOBILE1)
                .IsUnicode(false);

            modelBuilder.Entity<CARRIER>()
                .Property(e => e.FAX1)
                .IsUnicode(false);

            modelBuilder.Entity<CARRIER>()
                .Property(e => e.EMAIL1)
                .IsUnicode(false);

            modelBuilder.Entity<CARRIER>()
                .Property(e => e.CONTACT2)
                .IsUnicode(false);

            modelBuilder.Entity<CARRIER>()
                .Property(e => e.PHONE2)
                .IsUnicode(false);

            modelBuilder.Entity<CARRIER>()
                .Property(e => e.MOBILE2)
                .IsUnicode(false);

            modelBuilder.Entity<CARRIER>()
                .Property(e => e.FAX2)
                .IsUnicode(false);

            modelBuilder.Entity<CARRIER>()
                .Property(e => e.EMAIL2)
                .IsUnicode(false);

            modelBuilder.Entity<CARRIER>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<CARRIER>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CARRIER>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CARRIER>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CARTONTYPE>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CARTONTYPE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CARTONTYPE>()
                .Property(e => e.CUBE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CARTONTYPE>()
                .Property(e => e.WEIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CARTONTYPE>()
                .Property(e => e.LENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CARTONTYPE>()
                .Property(e => e.WIDTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CARTONTYPE>()
                .Property(e => e.HEIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CARTONTYPE>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CARTONTYPE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CARTONTYPE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.ZIP)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.PHONE1)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.MOBILE1)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.FAX1)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.PHONE2)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.MOBILE2)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.FAX2)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.SOCIALCODING)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.TELL)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.BANKACCOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.CAPITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.KIND)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANY>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT>()
                .Property(e => e.ORIGINSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT>()
                .Property(e => e.ISDEFAULT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRACT>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRACT>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.ACTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.ROUTE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.STATE)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.ZIP)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CONTACT1)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.PHONE1)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.MOBILE1)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.FAX1)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.EMAIL1)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CONTACT2)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.PHONE2)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.MOBILE2)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.FAX2)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.EMAIL2)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.BANKACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.SOCIALCODING)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CAPITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.KIND)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.SHORTNMAE)
                .IsUnicode(false);

            modelBuilder.Entity<DISPATCHNODE>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DISPATCHNODE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<DISPATCHNODE>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DISPATCHNODE>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<DISPATCHNODE>()
                .Property(e => e.PRIORITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DISPATCHNODE>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DISPATCHNODE>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<DISPATCHNODE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<DISPATCHNODE>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<DISPATCHNODE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<DISPATCHNODE>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .Property(e => e.SysNo)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Group>()
                .Property(e => e.EnableFlag)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Group>()
                .Property(e => e.CreateUserID)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .Property(e => e.ModifyUserID)
                .IsUnicode(false);

            modelBuilder.Entity<GROUPCOMPANY>()
                .Property(e => e.GROUPSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GROUPCOMPANY>()
                .Property(e => e.COMPANYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GROUPCOMPANY>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<GROUPCOMPANY>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<GROUPWAREHOUSE>()
                .Property(e => e.GROUPSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GROUPWAREHOUSE>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GROUPWAREHOUSE>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<GROUPWAREHOUSE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<HANSTEMP1>()
                .Property(e => e.SKUCODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HANSTEMP1>()
                .Property(e => e.WAREHOUSESYSCODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HANSTEMP1>()
                .Property(e => e.QTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HIS_DPS_CMD>()
                .Property(e => e.DPS_CMD_ID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<HIS_DPS_CMD>()
                .Property(e => e.LOCATE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<HIS_DPS_CMD>()
                .Property(e => e.LPN)
                .IsUnicode(false);

            modelBuilder.Entity<HIS_DPS_CMD>()
                .Property(e => e.DPS_OPE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<HIS_DPS_CMD>()
                .Property(e => e.DPS_COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<HIS_DPS_CMD>()
                .Property(e => e.DPS_CMD_ST)
                .IsUnicode(false);

            modelBuilder.Entity<HIS_DPS_CMD>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<HIS_DPS_CMD>()
                .Property(e => e.TASKDTL)
                .HasPrecision(20, 0);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.TRANTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.QTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.FROMLOCCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.TOLOCCODE)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.FROMLPN)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.ISWHOLEPLATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.TOLPN)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.LOTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.TEMPLPN)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.QTYINTRANSIT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.INVNUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.AVERAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INVENTORYCHANGEPLANHISTORY>()
                .Property(e => e.ALREADYNUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOTATTRTEMPLATE>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOTATTRTEMPLATE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<LOTATTRTEMPLATE>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOTATTRTEMPLATE>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<LOTATTRTEMPLATE>()
                .Property(e => e.MD5)
                .IsUnicode(false);

            modelBuilder.Entity<LOTATTRTEMPLATE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<LOTATTRTEMPLATE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<LOTATTRTEMPLATEITEMS>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOTATTRTEMPLATEITEMS>()
                .Property(e => e.LOTATTRTEMPLATESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOTATTRTEMPLATEITEMS>()
                .Property(e => e.DATATYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOTATTRTEMPLATEITEMS>()
                .Property(e => e.ISOPTIONALFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LOTATTRTEMPLATEITEMS>()
                .Property(e => e.SYSTEMIDENTIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<OLDSERIALNUMBER>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OLDSERIALNUMBER>()
                .Property(e => e.PRODUCTSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<OLDSERIALNUMBER>()
                .Property(e => e.SN)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.ORDERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.ORDERNUM)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.ORDERLINESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.LOCATIONSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.LOCATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.LOTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.INVUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.ORDERSINVNUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.QTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.AVERAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.VENDORCODE)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.VENDORNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ORDERSRECORD>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<PACK>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PACK>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PACK>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<PACK>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PACK>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PACK>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PACKDETAIL>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PACKDETAIL>()
                .Property(e => e.PACKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PACKDETAIL>()
                .Property(e => e.PACKLINENUM)
                .IsUnicode(false);

            modelBuilder.Entity<PACKDETAIL>()
                .Property(e => e.BASEUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PACKDETAIL>()
                .Property(e => e.UMCODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PACKDETAIL>()
                .Property(e => e.QTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PACKDETAIL>()
                .Property(e => e.BARCODE)
                .IsUnicode(false);

            modelBuilder.Entity<PACKDETAIL>()
                .Property(e => e.LENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PACKDETAIL>()
                .Property(e => e.WIDTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PACKDETAIL>()
                .Property(e => e.HEIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PACKDETAIL>()
                .Property(e => e.CUBE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PACKDETAIL>()
                .Property(e => e.WEIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PACKDETAIL>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PACKDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PACKDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<PDAVERSIONSETTINGS>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PDAVERSIONSETTINGS>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<PDAVERSIONSETTINGS>()
                .Property(e => e.APPNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PDAVERSIONSETTINGS>()
                .Property(e => e.VERSION)
                .IsUnicode(false);

            modelBuilder.Entity<PDAVERSIONSETTINGS>()
                .Property(e => e.DBVERSION)
                .IsUnicode(false);

            modelBuilder.Entity<PDAVERSIONSETTINGS>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<PDAVERSIONSETTINGS>()
                .Property(e => e.FILENAME)
                .IsUnicode(false);

            modelBuilder.Entity<PDAVERSIONSETTINGS>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<PDAVERSIONSETTINGS>()
                .Property(e => e.USERDEF1)
                .IsUnicode(false);

            modelBuilder.Entity<PDAVERSIONSETTINGS>()
                .Property(e => e.USERDEF2)
                .IsUnicode(false);

            modelBuilder.Entity<PDAVERSIONSETTINGS>()
                .Property(e => e.USERDEF3)
                .IsUnicode(false);

            modelBuilder.Entity<PDAVERSIONSETTINGS>()
                .Property(e => e.USERDEF4)
                .IsUnicode(false);

            modelBuilder.Entity<PDAVERSIONSETTINGS>()
                .Property(e => e.USERDEF5)
                .IsUnicode(false);

            modelBuilder.Entity<SEQUENCES>()
                .Property(e => e.SEQNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SETTINGS>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SETTINGS>()
                .Property(e => e.KEY)
                .IsUnicode(false);

            modelBuilder.Entity<SETTINGS>()
                .Property(e => e.PARENTID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SETTINGS>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<SETTINGS>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.CODE2)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.CODE3)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.PN)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.STYLE)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.DESCRIPTION2)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.COMPANYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.CARTONTYPESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.CARTONTYPECODE)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.ACTSIZE)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.SEASON)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.SHELFLIFE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.SHELFLIFEPRE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.SHELFLIFERATIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.SKUTYPEDESC)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.SKUCLASS)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.SKUCLASSDESC)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.PACKSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.PACKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.LENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.WIDTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.HEIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.CUBE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.NETWEIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.TARE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.MOVEMENTTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.COST)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.ISLOTCONTROLLED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.SERIANUMBERTRACKING)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.PNFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.ACTIVE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.LOTATTRTEMPLATESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.LOTATTRTEMPLATECODE)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.BARCODETEMPLATECODE)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.ISCOMMINGLELOT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.ISFRAGILE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.ISPRIVATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.ISLIQUID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.ISINFLAMMABLESANDEXPLOSIVES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.ISSERVICEPRODUCTS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.GROSSWEIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.BRAND)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.TAG)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.SIZETYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.ISENERGYSUBSIDIES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.ISMANDATORYSNACQUISITION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.PACKQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.BUSINESSFLAG)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.ISREVIEWPHYSICALINFO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.ISICSONNUMBERFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.ISWQFREENUMBERFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKU>()
                .Property(e => e.ALERTQTY)
                .HasPrecision(18, 3);

            modelBuilder.Entity<SKU>()
                .Property(e => e.MATERIAL)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.MEASURINGUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.CHARGEUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<SKU>()
                .Property(e => e.QUALITY)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS>()
                .Property(e => e.WQFREENO)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS>()
                .Property(e => e.SERIALNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS>()
                .Property(e => e.SKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS>()
                .Property(e => e.RECEIPTSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS>()
                .Property(e => e.RECEIPTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS>()
                .Property(e => e.LOTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS>()
                .Property(e => e.LPN)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS>()
                .Property(e => e.LC_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS>()
                .Property(e => e.ORDERLINESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS>()
                .Property(e => e.ROWCREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS>()
                .Property(e => e.BINDSNUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS>()
                .Property(e => e.LPNTO)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS>()
                .Property(e => e.ORDERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS>()
                .Property(e => e.TEL)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS_HIS>()
                .Property(e => e.WQFREENO)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS_HIS>()
                .Property(e => e.SERIALNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS_HIS>()
                .Property(e => e.SKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS_HIS>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS_HIS>()
                .Property(e => e.RECEIPTSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS_HIS>()
                .Property(e => e.RECEIPTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS_HIS>()
                .Property(e => e.LOTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS_HIS>()
                .Property(e => e.LPN)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS_HIS>()
                .Property(e => e.LC_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS_HIS>()
                .Property(e => e.ORDERLINESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS_HIS>()
                .Property(e => e.ROWCREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS_HIS>()
                .Property(e => e.BINDSNUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS_HIS>()
                .Property(e => e.LPNTO)
                .IsUnicode(false);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS_HIS>()
                .Property(e => e.ORDERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SKUSERIALNUMBERRECORDS_HIS>()
                .Property(e => e.TEL)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.TASKID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.TASKTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.TRANTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.CONFIRMTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.SKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.SKUNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.COMPANYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.PRIORITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.PREPOSEID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.POSEID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.GROUPNAME1)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.GROUPVALUE1)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.GROUPNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.GROUPVALUE2)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.GROUPNAME3)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.GROUPVALUE3)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.MARKING)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.WORKINSTRUCTION)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.TICKETNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.LOCATIONFROM)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.LOCATIONTO)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.LOCATIONTOOVERRIDE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.ZONECODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.AREACODESPREAD)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.PICKINGSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.CCSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.PUTSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.LPNFROM)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.LPNTO)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.TEMPLPN)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.PACKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.PACKDETAILSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.UMCODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.UMCODEDESC)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.UMQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.QTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.COMPLETEDQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.SOURCETYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.SOURCEID)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.SOURCELINENO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.ENGINEID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.WAVEID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.ASSIGNUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.ASSIGNUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.EXPTIME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.EXECWHO)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.EXECWHONAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.ZONESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.DES)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.RV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.GROUPKEY)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.CHANGEPLANSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.CANGROUPSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.PAGENUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.MESSAGEID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.RETRIEVEVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.RELEASEMODEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.WAVENUM)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.MOVETYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.ENABLE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.DISPATCHNODEINFO)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.ISAUTOTASK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.PICKQUEUESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.INV_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.IS_LINE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.IS_AUDIT)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.IS_WKPICK)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.INVNUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.AVERAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.INVUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.INVUNITCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.VENDORSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.VENDORCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.VENDORNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.ALREADYQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TASKDETAILHISTORY>()
                .Property(e => e.ONINVNUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPETABLE>()
                .Property(e => e.TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPETABLE>()
                .Property(e => e.SUBORDINATETYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<UNIT>()
                .Property(e => e.SYSNO)
                .IsUnicode(false);

            modelBuilder.Entity<UNIT>()
                .Property(e => e.UNITCODE)
                .IsUnicode(false);

            modelBuilder.Entity<UNIT>()
                .Property(e => e.UNITNAME)
                .IsUnicode(false);

            modelBuilder.Entity<UNIT>()
                .Property(e => e.TYPEST)
                .IsUnicode(false);

            modelBuilder.Entity<UNIT>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<UNIT>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<UNIT>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<UNIT>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<USERCOMPANY>()
                .Property(e => e.USERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USERCOMPANY>()
                .Property(e => e.COMPANYSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USERCOMPANY>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<USERCOMPANY>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<USERGROUP>()
                .Property(e => e.GROUPSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USERGROUP>()
                .Property(e => e.USERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USERGROUP>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<USERWAREHOUSE>()
                .Property(e => e.USERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USERWAREHOUSE>()
                .Property(e => e.WAREHOUSESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<USERWAREHOUSE>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<USERWAREHOUSE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<USERWAREHOUSE>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.QAFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.SIGNFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.QARATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.STATE)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.ZIP)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.CONTACT1)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.PHONE1)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.MOBILE1)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.FAX1)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.EMAIL1)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.CONTACT2)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.PHONE2)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.MOBILE2)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.FAX2)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.EMAIL2)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.SOCIALCODING)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.BANKACCOUNT)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.CAPITAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.KIND)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.AREACOMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VENDOR>()
                .Property(e => e.SERIALNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.REGION)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.REGIONNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.LEVELNO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.LEVELNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.PARENTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.CONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.ZIP)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.PROVINCE)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.ENABLEFLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.BRANCHSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.WHTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.GOODSTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.INDRAWING_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WAREHOUSE>()
                .Property(e => e.ISOFTENUSEDWMS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMSVERSION>()
                .Property(e => e.SYSNO)
                .IsUnicode(false);

            modelBuilder.Entity<WMSVERSION>()
                .Property(e => e.VERSIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMSVERSION>()
                .Property(e => e.ISENABLE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMSVERSION>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMSVERSION>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMSVERSION>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMSVERSION>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WORKSHOP>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WORKSHOP>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<WORKSHOP>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<WORKSHOP>()
                .Property(e => e.DEPTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WORKSHOP>()
                .Property(e => e.DEPTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WORKSHOP>()
                .Property(e => e.ADDRES)
                .IsUnicode(false);

            modelBuilder.Entity<WORKSHOP>()
                .Property(e => e.PERSONCHARGE)
                .IsUnicode(false);

            modelBuilder.Entity<WORKSHOP>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<WQFCARTON>()
                .Property(e => e.WQFCARTON_NO)
                .IsUnicode(false);

            modelBuilder.Entity<WQFCARTON>()
                .Property(e => e.SKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WQFCARTON>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WQFCARTON>()
                .Property(e => e.RECEIPTSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WQFCARTON>()
                .Property(e => e.LOTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WQFCARTON>()
                .Property(e => e.PACK)
                .IsUnicode(false);

            modelBuilder.Entity<WQFCARTON>()
                .Property(e => e.QTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WQFCARTON>()
                .Property(e => e.ROWCREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WQFCARTON>()
                .Property(e => e.ROWCREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WQFCARTON>()
                .Property(e => e.SEQ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WQFCARTON>()
                .Property(e => e.CUSTOMERNO)
                .IsUnicode(false);

            modelBuilder.Entity<WQFCARTON>()
                .Property(e => e.CUSTOMERNAME)
                .IsUnicode(false);
        }
    }
}
