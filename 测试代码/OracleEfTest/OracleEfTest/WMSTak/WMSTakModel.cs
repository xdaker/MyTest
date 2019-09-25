namespace OracleEfTest.WMSTak
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WMSTakModel : DbContext
    {
        public WMSTakModel()
            : base("name=WMSTakModelOracle")
        {
        }

        public virtual DbSet<BASE_BUTTON> BASE_BUTTON { get; set; }
        public virtual DbSet<BASE_BUTTONPERMISSION> BASE_BUTTONPERMISSION { get; set; }
        public virtual DbSet<BASE_CODERULE> BASE_CODERULE { get; set; }
        public virtual DbSet<BASE_CODERULEDETAIL> BASE_CODERULEDETAIL { get; set; }
        public virtual DbSet<BASE_CODERULESERIOUS> BASE_CODERULESERIOUS { get; set; }
        public virtual DbSet<BASE_COMPANY> BASE_COMPANY { get; set; }
        public virtual DbSet<BASE_DATADICTIONARY> BASE_DATADICTIONARY { get; set; }
        public virtual DbSet<BASE_DATADICTIONARYDETAIL> BASE_DATADICTIONARYDETAIL { get; set; }
        public virtual DbSet<BASE_DATASCOPEPERMISSION> BASE_DATASCOPEPERMISSION { get; set; }
        public virtual DbSet<BASE_DEPARTMENT> BASE_DEPARTMENT { get; set; }
        public virtual DbSet<BASE_EMAIL> BASE_EMAIL { get; set; }
        public virtual DbSet<BASE_EMAILACCESSORY> BASE_EMAILACCESSORY { get; set; }
        public virtual DbSet<BASE_EMAILADDRESSEE> BASE_EMAILADDRESSEE { get; set; }
        public virtual DbSet<BASE_EMAILCATEGORY> BASE_EMAILCATEGORY { get; set; }
        public virtual DbSet<BASE_EMPLOYEE> BASE_EMPLOYEE { get; set; }
        public virtual DbSet<BASE_EXCELIMPORT> BASE_EXCELIMPORT { get; set; }
        public virtual DbSet<BASE_EXCELIMPORTDETAIL> BASE_EXCELIMPORTDETAIL { get; set; }
        public virtual DbSet<BASE_FORMATTRIBUTE> BASE_FORMATTRIBUTE { get; set; }
        public virtual DbSet<BASE_FORMATTRIBUTEVALUE> BASE_FORMATTRIBUTEVALUE { get; set; }
        public virtual DbSet<BASE_GROUPUSER> BASE_GROUPUSER { get; set; }
        public virtual DbSet<BASE_INTERFACEMANAGE> BASE_INTERFACEMANAGE { get; set; }
        public virtual DbSet<BASE_INTERFACEMANAGEPARAMETER> BASE_INTERFACEMANAGEPARAMETER { get; set; }
        public virtual DbSet<BASE_LANGUAGE> BASE_LANGUAGE { get; set; }
        public virtual DbSet<BASE_MODULE> BASE_MODULE { get; set; }
        public virtual DbSet<BASE_MODULEPERMISSION> BASE_MODULEPERMISSION { get; set; }
        public virtual DbSet<BASE_NETWORKFILE> BASE_NETWORKFILE { get; set; }
        public virtual DbSet<BASE_NETWORKFOLDER> BASE_NETWORKFOLDER { get; set; }
        public virtual DbSet<BASE_OBJECTUSERRELATION> BASE_OBJECTUSERRELATION { get; set; }
        public virtual DbSet<BASE_PHONENOTE> BASE_PHONENOTE { get; set; }
        public virtual DbSet<BASE_POST> BASE_POST { get; set; }
        public virtual DbSet<BASE_PROVINCECITY> BASE_PROVINCECITY { get; set; }
        public virtual DbSet<BASE_QUERYRECORD> BASE_QUERYRECORD { get; set; }
        public virtual DbSet<BASE_ROLES> BASE_ROLES { get; set; }
        public virtual DbSet<BASE_SHORTCUTS> BASE_SHORTCUTS { get; set; }
        public virtual DbSet<BASE_SUPPLIES> BASE_SUPPLIES { get; set; }
        public virtual DbSet<BASE_SYSLOG> BASE_SYSLOG { get; set; }
        public virtual DbSet<BASE_SYSLOGDETAIL> BASE_SYSLOGDETAIL { get; set; }
        public virtual DbSet<BASE_USER> BASE_USER { get; set; }
        public virtual DbSet<BASE_VIEW> BASE_VIEW { get; set; }
        public virtual DbSet<BASE_VIEWPERMISSION> BASE_VIEWPERMISSION { get; set; }
        public virtual DbSet<BASE_VIEWWHERE> BASE_VIEWWHERE { get; set; }
        public virtual DbSet<BASE_VIEWWHEREPERMISSION> BASE_VIEWWHEREPERMISSION { get; set; }
        public virtual DbSet<DB_IMPORT_INPLANDETAIL> DB_IMPORT_INPLANDETAIL { get; set; }
        public virtual DbSet<MODULEINFO> MODULEINFO { get; set; }
        public virtual DbSet<POORDER> POORDER { get; set; }
        public virtual DbSet<POORDERENTRY> POORDERENTRY { get; set; }
        public virtual DbSet<TABLE_LOCATION> TABLE_LOCATION { get; set; }
        public virtual DbSet<VIEW_AREACODE> VIEW_AREACODE { get; set; }
        public virtual DbSet<VIEW_INDETTAIL> VIEW_INDETTAIL { get; set; }
        public virtual DbSet<VIEW_LOCATIONFUNCTIONCODE> VIEW_LOCATIONFUNCTIONCODE { get; set; }
        public virtual DbSet<VIEW_OUTDETTAIL> VIEW_OUTDETTAIL { get; set; }
        public virtual DbSet<VIEW_OUTTASKJHDETAI> VIEW_OUTTASKJHDETAI { get; set; }
        public virtual DbSet<VIEW_OUTTASKZHDETAIL> VIEW_OUTTASKZHDETAIL { get; set; }

        public virtual DbSet<VIEW_TRANSIT> VIEW_TRANSIT { get; set; }
        public virtual DbSet<WMS_ALLOCATIONMAIN> WMS_ALLOCATIONMAIN { get; set; }
        public virtual DbSet<WMS_ALLOCATIONPLANDETAIL> WMS_ALLOCATIONPLANDETAIL { get; set; }
        public virtual DbSet<WMS_ALLOCATIONPLANMAIN> WMS_ALLOCATIONPLANMAIN { get; set; }
        public virtual DbSet<WMS_BHDETAIL> WMS_BHDETAIL { get; set; }
        public virtual DbSet<WMS_BHMAIN> WMS_BHMAIN { get; set; }
        public virtual DbSet<WMS_BHTEMP> WMS_BHTEMP { get; set; }
        public virtual DbSet<WMS_BILLNUMBER> WMS_BILLNUMBER { get; set; }
        public virtual DbSet<WMS_BUSINESSINFO> WMS_BUSINESSINFO { get; set; }
        public virtual DbSet<WMS_CARINFO> WMS_CARINFO { get; set; }
        public virtual DbSet<WMS_CHECKDETAIL> WMS_CHECKDETAIL { get; set; }
        public virtual DbSet<WMS_CHECKMAIN> WMS_CHECKMAIN { get; set; }
        public virtual DbSet<WMS_CHECKPLANDETAIL> WMS_CHECKPLANDETAIL { get; set; }
        public virtual DbSet<WMS_CHECKPLANMAIN> WMS_CHECKPLANMAIN { get; set; }
        public virtual DbSet<WMS_CHILDBATCHMANAGE> WMS_CHILDBATCHMANAGE { get; set; }
        public virtual DbSet<WMS_CONTAINERINFO> WMS_CONTAINERINFO { get; set; }
        public virtual DbSet<WMS_CONTAINERTYPE> WMS_CONTAINERTYPE { get; set; }
        public virtual DbSet<WMS_EXAMINEDETAIL> WMS_EXAMINEDETAIL { get; set; }
        public virtual DbSet<WMS_EXAMINEMAIN> WMS_EXAMINEMAIN { get; set; }
        public virtual DbSet<WMS_INDETAIL> WMS_INDETAIL { get; set; }
        public virtual DbSet<WMS_INMAIN> WMS_INMAIN { get; set; }
        public virtual DbSet<WMS_INORDERDETAIL> WMS_INORDERDETAIL { get; set; }
        public virtual DbSet<WMS_INORDERMAIN> WMS_INORDERMAIN { get; set; }
        public virtual DbSet<WMS_INORDERTEMP> WMS_INORDERTEMP { get; set; }
        public virtual DbSet<WMS_INPLANDETAIL> WMS_INPLANDETAIL { get; set; }
        public virtual DbSet<WMS_INPLANMAIN> WMS_INPLANMAIN { get; set; }
        public virtual DbSet<WMS_INPLANTEMP> WMS_INPLANTEMP { get; set; }
        public virtual DbSet<WMS_INTEMP> WMS_INTEMP { get; set; }
        public virtual DbSet<WMS_JXD> WMS_JXD { get; set; }
        public virtual DbSet<WMS_JXDMX> WMS_JXDMX { get; set; }
        public virtual DbSet<WMS_LANESTATUS> WMS_LANESTATUS { get; set; }
        public virtual DbSet<WMS_LOCATION> WMS_LOCATION { get; set; }
        public virtual DbSet<WMS_LOCATIONCONTAINERMAP> WMS_LOCATIONCONTAINERMAP { get; set; }
        public virtual DbSet<WMS_LOCATIONFUNCTION> WMS_LOCATIONFUNCTION { get; set; }
        public virtual DbSet<WMS_MATERIALS> WMS_MATERIALS { get; set; }
        public virtual DbSet<WMS_MATERIALSBUSINESSMAP> WMS_MATERIALSBUSINESSMAP { get; set; }
        public virtual DbSet<WMS_MATERIALSLOCATIONMAP> WMS_MATERIALSLOCATIONMAP { get; set; }
        public virtual DbSet<WMS_MATERIALSSORTS> WMS_MATERIALSSORTS { get; set; }
        public virtual DbSet<WMS_MATERIALSTORAGEAREA> WMS_MATERIALSTORAGEAREA { get; set; }
        public virtual DbSet<WMS_OUTDETAIL> WMS_OUTDETAIL { get; set; }
        public virtual DbSet<WMS_OUTMAIN> WMS_OUTMAIN { get; set; }
        public virtual DbSet<WMS_OUTORDERDETAIL> WMS_OUTORDERDETAIL { get; set; }
        public virtual DbSet<WMS_OUTORDERMAIN> WMS_OUTORDERMAIN { get; set; }
        public virtual DbSet<WMS_OUTPLANDETAIL> WMS_OUTPLANDETAIL { get; set; }
        public virtual DbSet<WMS_OUTPLANMAIN> WMS_OUTPLANMAIN { get; set; }
        public virtual DbSet<WMS_OUTPLANTEMP> WMS_OUTPLANTEMP { get; set; }
        public virtual DbSet<WMS_OUTTASK> WMS_OUTTASK { get; set; }
        public virtual DbSet<WMS_OUTTASKBHDETAIL> WMS_OUTTASKBHDETAIL { get; set; }
        public virtual DbSet<WMS_OUTTASKBHMAIN> WMS_OUTTASKBHMAIN { get; set; }
        public virtual DbSet<WMS_OUTTASKJHDETAIL> WMS_OUTTASKJHDETAIL { get; set; }
        public virtual DbSet<WMS_OUTTASKJHMAIN> WMS_OUTTASKJHMAIN { get; set; }
        public virtual DbSet<WMS_OUTTASKZHDETAIL> WMS_OUTTASKZHDETAIL { get; set; }
        public virtual DbSet<WMS_OUTTASKZHMAIN> WMS_OUTTASKZHMAIN { get; set; }
        public virtual DbSet<WMS_OUTTEMP> WMS_OUTTEMP { get; set; }
        public virtual DbSet<WMS_PACKSPEC> WMS_PACKSPEC { get; set; }
        public virtual DbSet<WMS_PRINTHHSTORYTABLE> WMS_PRINTHHSTORYTABLE { get; set; }
        public virtual DbSet<WMS_PRINTTABLE> WMS_PRINTTABLE { get; set; }
        public virtual DbSet<WMS_PRODUCTBATCH> WMS_PRODUCTBATCH { get; set; }
        public virtual DbSet<WMS_QUALITYCHECK> WMS_QUALITYCHECK { get; set; }
        public virtual DbSet<WMS_REBUILDAPPLYDETAIL> WMS_REBUILDAPPLYDETAIL { get; set; }
        public virtual DbSet<WMS_REBUILDAPPLYMAIN> WMS_REBUILDAPPLYMAIN { get; set; }
        public virtual DbSet<WMS_REBUILDMAIN> WMS_REBUILDMAIN { get; set; }
        public virtual DbSet<WMS_REBUILDPLANDETAIL> WMS_REBUILDPLANDETAIL { get; set; }
        public virtual DbSet<WMS_REBUILDPLANMAIN> WMS_REBUILDPLANMAIN { get; set; }
        public virtual DbSet<WMS_STOCKPILE> WMS_STOCKPILE { get; set; }
        public virtual DbSet<WMS_STORAGEAREA> WMS_STORAGEAREA { get; set; }
        public virtual DbSet<WMS_STORAGEAREAMATERIALMAP> WMS_STORAGEAREAMATERIALMAP { get; set; }
        public virtual DbSet<WMS_SUPPLIERMTLSTORAGEAREA> WMS_SUPPLIERMTLSTORAGEAREA { get; set; }
        public virtual DbSet<WMS_SUPPLIERMTLSTOTAGEAREA> WMS_SUPPLIERMTLSTOTAGEAREA { get; set; }
        public virtual DbSet<WMS_TASKDETAIL> WMS_TASKDETAIL { get; set; }
        public virtual DbSet<WMS_TASKDETAILHISTORY> WMS_TASKDETAILHISTORY { get; set; }
        public virtual DbSet<WMS_TASKENGINE> WMS_TASKENGINE { get; set; }

        //public virtual DbSet<WMS_TASKS> WMS_TASKS { get; set; }
        public virtual DbSet<WMS_TASKSMAINTEMP> WMS_TASKSMAINTEMP { get; set; }
        public virtual DbSet<WMS_TASKSTEMP> WMS_TASKSTEMP { get; set; }
        public virtual DbSet<WMS_TASKSTYPE> WMS_TASKSTYPE { get; set; }
        public virtual DbSet<WMS_TASKTYPEPOSTMAP> WMS_TASKTYPEPOSTMAP { get; set; }
        public virtual DbSet<WMS_TRANSIT> WMS_TRANSIT { get; set; }
        public virtual DbSet<WMS_TRANSITMAIN> WMS_TRANSITMAIN { get; set; }
        public virtual DbSet<WMS_UNLOADINGPLACE> WMS_UNLOADINGPLACE { get; set; }
        public virtual DbSet<WMS_ZHDETAIL> WMS_ZHDETAIL { get; set; }
        public virtual DbSet<WMS_ZHMAIN> WMS_ZHMAIN { get; set; }
        public virtual DbSet<WMS_ZHTEMP> WMS_ZHTEMP { get; set; }
        public virtual DbSet<XPOBJECTTYPE> XPOBJECTTYPE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("WMS");

            modelBuilder.Entity<BASE_BUTTON>()
                .Property(e => e.BUTTONID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTON>()
                .Property(e => e.MODULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTON>()
                .Property(e => e.PARENTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTON>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTON>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTON>()
                .Property(e => e.ICON)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTON>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTON>()
                .Property(e => e.JSEVENT)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTON>()
                .Property(e => e.ACTIONEVENT)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTON>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTON>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTON>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTON>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTON>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTONPERMISSION>()
                .Property(e => e.BUTTONPERMISSIONID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTONPERMISSION>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTONPERMISSION>()
                .Property(e => e.OBJECTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTONPERMISSION>()
                .Property(e => e.MODULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTONPERMISSION>()
                .Property(e => e.MODULEBUTTONID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTONPERMISSION>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_BUTTONPERMISSION>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULE>()
                .Property(e => e.CODERULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULE>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULE>()
                .Property(e => e.MODULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULE>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULE>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULEDETAIL>()
                .Property(e => e.CODERULEDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULEDETAIL>()
                .Property(e => e.CODERULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULEDETAIL>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULEDETAIL>()
                .Property(e => e.CONSTED)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULEDETAIL>()
                .Property(e => e.FORMATSTR)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULEDETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULEDETAIL>()
                .Property(e => e.FTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULEDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULEDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULEDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULEDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULESERIOUS>()
                .Property(e => e.CODESERIOUSID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULESERIOUS>()
                .Property(e => e.CODERULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULESERIOUS>()
                .Property(e => e.USERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULESERIOUS>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULESERIOUS>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULESERIOUS>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULESERIOUS>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_CODERULESERIOUS>()
                .Property(e => e.LASTUPDATEDATE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.COMPANYID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.PARENTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.SHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.NATURE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.MANAGER)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.CONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.PROVINCEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.PROVINCE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.CITYID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.COUNTYID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.COUNTY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.ACCOUNTINFO)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.POSTALCODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.WEB)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_COMPANY>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARY>()
                .Property(e => e.DATADICTIONARYID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARY>()
                .Property(e => e.COMPANYID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARY>()
                .Property(e => e.PARENTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARY>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARY>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARY>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARY>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARY>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARY>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARY>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARYDETAIL>()
                .Property(e => e.DATADICTIONARYDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARYDETAIL>()
                .Property(e => e.DATADICTIONARYID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARYDETAIL>()
                .Property(e => e.PARENTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARYDETAIL>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARYDETAIL>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARYDETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARYDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARYDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARYDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATADICTIONARYDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATASCOPEPERMISSION>()
                .Property(e => e.DATASCOPEPERMISSIONID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATASCOPEPERMISSION>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATASCOPEPERMISSION>()
                .Property(e => e.OBJECTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATASCOPEPERMISSION>()
                .Property(e => e.MODULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATASCOPEPERMISSION>()
                .Property(e => e.RESOURCEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATASCOPEPERMISSION>()
                .Property(e => e.CONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATASCOPEPERMISSION>()
                .Property(e => e.CONDITIONJSON)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATASCOPEPERMISSION>()
                .Property(e => e.SCOPETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATASCOPEPERMISSION>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DATASCOPEPERMISSION>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DEPARTMENT>()
                .Property(e => e.DEPARTMENTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DEPARTMENT>()
                .Property(e => e.COMPANYID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DEPARTMENT>()
                .Property(e => e.PARENTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DEPARTMENT>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DEPARTMENT>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DEPARTMENT>()
                .Property(e => e.SHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DEPARTMENT>()
                .Property(e => e.NATURE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DEPARTMENT>()
                .Property(e => e.MANAGER)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DEPARTMENT>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DEPARTMENT>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DEPARTMENT>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DEPARTMENT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DEPARTMENT>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DEPARTMENT>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DEPARTMENT>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_DEPARTMENT>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL>()
                .Property(e => e.EMAILID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL>()
                .Property(e => e.PARENTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL>()
                .Property(e => e.THEME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL>()
                .Property(e => e.THEMECOLOUR)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL>()
                .Property(e => e.CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL>()
                .Property(e => e.ADDRESSER)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAIL>()
                .HasMany(e => e.BASE_EMAILACCESSORY)
                .WithOptional(e => e.BASE_EMAIL)
                .WillCascadeOnDelete();

            modelBuilder.Entity<BASE_EMAIL>()
                .HasMany(e => e.BASE_EMAILADDRESSEE)
                .WithOptional(e => e.BASE_EMAIL)
                .WillCascadeOnDelete();

            modelBuilder.Entity<BASE_EMAILACCESSORY>()
                .Property(e => e.EMAILACCESSORYID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAILACCESSORY>()
                .Property(e => e.EMAILID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAILACCESSORY>()
                .Property(e => e.FILENAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAILACCESSORY>()
                .Property(e => e.FILEPATH)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAILACCESSORY>()
                .Property(e => e.FILESIZE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAILACCESSORY>()
                .Property(e => e.FILETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAILADDRESSEE>()
                .Property(e => e.EMAILADDRESSEEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAILADDRESSEE>()
                .Property(e => e.EMAILID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAILADDRESSEE>()
                .Property(e => e.ADDRESSEEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAILADDRESSEE>()
                .Property(e => e.ADDRESSEENAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAILCATEGORY>()
                .Property(e => e.EMAILCATEGORYID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAILCATEGORY>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAILCATEGORY>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAILCATEGORY>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAILCATEGORY>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAILCATEGORY>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMAILCATEGORY>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.EMPLOYEEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.USERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.PHOTOGRAPH)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.IDCARD)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.BANKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.OFFICECORNET)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.OFFICEPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.OFFICEZIPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.OFFICEADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.OFFICEFAX)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.EDUCATION)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.SCHOOL)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.MAJOR)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.DEGREE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.HOMEZIPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.HOMEADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.HOMEPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.HOMEFAX)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.PROVINCE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.AREA)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.NATIVEPLACE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.PARTY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.NATION)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.NATIONALITY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.DUTY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.WORKINGPROPERTY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.COMPETENCY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.EMERGENCYCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.DIMISSIONCAUSE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EMPLOYEE>()
                .Property(e => e.DIMISSIONWHITHER)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORT>()
                .Property(e => e.IMPORTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORT>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORT>()
                .Property(e => e.IMPORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORT>()
                .Property(e => e.IMPORTTABLE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORT>()
                .Property(e => e.IMPORTTABLENAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORT>()
                .Property(e => e.IMPORTFILENAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORT>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORT>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORT>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORT>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORT>()
                .Property(e => e.MODULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORTDETAIL>()
                .Property(e => e.IMPORTDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORTDETAIL>()
                .Property(e => e.IMPORTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORTDETAIL>()
                .Property(e => e.COLUMNNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORTDETAIL>()
                .Property(e => e.FIELDNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORTDETAIL>()
                .Property(e => e.FOREIGNTABLE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORTDETAIL>()
                .Property(e => e.BACKFIELD)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORTDETAIL>()
                .Property(e => e.COMPAREFIELD)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORTDETAIL>()
                .Property(e => e.ATTACHCONDITION)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORTDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORTDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORTDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORTDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_EXCELIMPORTDETAIL>()
                .Property(e => e.FIELDREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTE>()
                .Property(e => e.FORMATTRIBUTEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTE>()
                .Property(e => e.MODULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTE>()
                .Property(e => e.PROPERTYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTE>()
                .Property(e => e.CONTROLID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTE>()
                .Property(e => e.CONTROLTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTE>()
                .Property(e => e.CONTROLSTYLE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTE>()
                .Property(e => e.CONTROLVALIDATOR)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTE>()
                .Property(e => e.DEFAULTVLAUE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTE>()
                .Property(e => e.ATTRIBUTESPROPERTY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTE>()
                .Property(e => e.DATASOURCE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTE>()
                .Property(e => e.CONTROLCOLSPAN)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTE>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTE>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTEVALUE>()
                .Property(e => e.ATTRIBUTEVALUEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTEVALUE>()
                .Property(e => e.MODULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTEVALUE>()
                .Property(e => e.OBJECTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_FORMATTRIBUTEVALUE>()
                .Property(e => e.OBJECTPARAMETERJSON)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_GROUPUSER>()
                .Property(e => e.GROUPUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_GROUPUSER>()
                .Property(e => e.COMPANYID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_GROUPUSER>()
                .Property(e => e.DEPARTMENTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_GROUPUSER>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_GROUPUSER>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_GROUPUSER>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_GROUPUSER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_GROUPUSER>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_GROUPUSER>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_GROUPUSER>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_GROUPUSER>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_INTERFACEMANAGE>()
                .Property(e => e.INTERFACEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_INTERFACEMANAGE>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_INTERFACEMANAGE>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_INTERFACEMANAGE>()
                .Property(e => e.ACTION)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_INTERFACEMANAGE>()
                .Property(e => e.CONSTRAINTS)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_INTERFACEMANAGE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_INTERFACEMANAGE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_INTERFACEMANAGE>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_INTERFACEMANAGE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_INTERFACEMANAGE>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_INTERFACEMANAGE>()
                .HasMany(e => e.BASE_INTERFACEMANAGEPARAMETER)
                .WithOptional(e => e.BASE_INTERFACEMANAGE)
                .WillCascadeOnDelete();

            modelBuilder.Entity<BASE_INTERFACEMANAGEPARAMETER>()
                .Property(e => e.INTERFACEPARAMETERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_INTERFACEMANAGEPARAMETER>()
                .Property(e => e.INTERFACEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_INTERFACEMANAGEPARAMETER>()
                .Property(e => e.FIELD)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_INTERFACEMANAGEPARAMETER>()
                .Property(e => e.FIELDMEMO)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_INTERFACEMANAGEPARAMETER>()
                .Property(e => e.FIELDTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_LANGUAGE>()
                .Property(e => e.LANGUAGEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_LANGUAGE>()
                .Property(e => e.OBJECTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_LANGUAGE>()
                .Property(e => e.BUSINESSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_LANGUAGE>()
                .Property(e => e.BUSINESSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_LANGUAGE>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_LANGUAGE>()
                .Property(e => e.FULLVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_LANGUAGE>()
                .Property(e => e.NOTE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_LANGUAGE>()
                .Property(e => e.LANGUAGETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_MODULEPERMISSION>()
                .Property(e => e.MODULEPERMISSIONID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_MODULEPERMISSION>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_MODULEPERMISSION>()
                .Property(e => e.OBJECTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_MODULEPERMISSION>()
                .Property(e => e.MODULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_MODULEPERMISSION>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_MODULEPERMISSION>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFILE>()
                .Property(e => e.NETWORKFILEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFILE>()
                .Property(e => e.FOLDERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFILE>()
                .Property(e => e.FILENAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFILE>()
                .Property(e => e.FILEPATH)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFILE>()
                .Property(e => e.FILESIZE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFILE>()
                .Property(e => e.FILEEXTENSIONS)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFILE>()
                .Property(e => e.FILETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFILE>()
                .Property(e => e.ICON)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFILE>()
                .Property(e => e.SHARINGFOLDERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFILE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFILE>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFOLDER>()
                .Property(e => e.FOLDERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFOLDER>()
                .Property(e => e.PARENTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFOLDER>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFOLDER>()
                .Property(e => e.FOLDERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFOLDER>()
                .Property(e => e.SHARINGFOLDERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFOLDER>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFOLDER>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFOLDER>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_NETWORKFOLDER>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_OBJECTUSERRELATION>()
                .Property(e => e.OBJECTUSERRELATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_OBJECTUSERRELATION>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_OBJECTUSERRELATION>()
                .Property(e => e.OBJECTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_OBJECTUSERRELATION>()
                .Property(e => e.USERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_OBJECTUSERRELATION>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_OBJECTUSERRELATION>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_PHONENOTE>()
                .Property(e => e.PHONENOTEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_PHONENOTE>()
                .Property(e => e.PHONENNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_PHONENOTE>()
                .Property(e => e.SENDCONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_PHONENOTE>()
                .Property(e => e.SENDSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_PHONENOTE>()
                .Property(e => e.DEVICENAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_PHONENOTE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_PHONENOTE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_PHONENOTE>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_POST>()
                .Property(e => e.POSTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_POST>()
                .Property(e => e.COMPANYID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_POST>()
                .Property(e => e.DEPARTMENTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_POST>()
                .Property(e => e.ROLEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_POST>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_POST>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_POST>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_POST>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_POST>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_POST>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_POST>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_PROVINCECITY>()
                .Property(e => e.PROVINCECITYID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_PROVINCECITY>()
                .Property(e => e.PARENTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_PROVINCECITY>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_PROVINCECITY>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_PROVINCECITY>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_PROVINCECITY>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_PROVINCECITY>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_PROVINCECITY>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_PROVINCECITY>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_QUERYRECORD>()
                .Property(e => e.QUERYRECORDID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_QUERYRECORD>()
                .Property(e => e.MODULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_QUERYRECORD>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_QUERYRECORD>()
                .Property(e => e.CONDITIONJSON)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_QUERYRECORD>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_QUERYRECORD>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_QUERYRECORD>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_QUERYRECORD>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ROLES>()
                .Property(e => e.ROLEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ROLES>()
                .Property(e => e.COMPANYID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ROLES>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ROLES>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ROLES>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ROLES>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ROLES>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ROLES>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ROLES>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_ROLES>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SHORTCUTS>()
                .Property(e => e.SHORTCUTSID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SHORTCUTS>()
                .Property(e => e.MODULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SHORTCUTS>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SUPPLIES>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SUPPLIES>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SUPPLIES>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SUPPLIES>()
                .Property(e => e.TELEPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SUPPLIES>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SUPPLIES>()
                .Property(e => e.ACCOUNTSMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SUPPLIES>()
                .Property(e => e.LINKMAN)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SUPPLIES>()
                .Property(e => e.LEADINGOFFICIALID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SUPPLIES>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOG>()
                .Property(e => e.SYSLOGID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOG>()
                .Property(e => e.OBJECTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOG>()
                .Property(e => e.LOGTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOG>()
                .Property(e => e.IPADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOG>()
                .Property(e => e.IPADDRESSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOG>()
                .Property(e => e.COMPANYID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOG>()
                .Property(e => e.DEPARTMENTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOG>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOG>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOG>()
                .Property(e => e.MODULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOG>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOG>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOG>()
                .HasMany(e => e.BASE_SYSLOGDETAIL)
                .WithOptional(e => e.BASE_SYSLOG)
                .WillCascadeOnDelete();

            modelBuilder.Entity<BASE_SYSLOGDETAIL>()
                .Property(e => e.SYSLOGDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOGDETAIL>()
                .Property(e => e.SYSLOGID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOGDETAIL>()
                .Property(e => e.PROPERTYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOGDETAIL>()
                .Property(e => e.PROPERTYFIELD)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOGDETAIL>()
                .Property(e => e.NEWVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_SYSLOGDETAIL>()
                .Property(e => e.OLDVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEW>()
                .Property(e => e.VIEWID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEW>()
                .Property(e => e.MODULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEW>()
                .Property(e => e.PARENTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEW>()
                .Property(e => e.FIELDNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEW>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEW>()
                .Property(e => e.SHOWNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEW>()
                .Property(e => e.TEXTALIGN)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEW>()
                .Property(e => e.CUSTOMSWITCH)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWPERMISSION>()
                .Property(e => e.VIEWPERMISSIONID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWPERMISSION>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWPERMISSION>()
                .Property(e => e.OBJECTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWPERMISSION>()
                .Property(e => e.MODULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWPERMISSION>()
                .Property(e => e.VIEWID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWPERMISSION>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWPERMISSION>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWWHERE>()
                .Property(e => e.VIEWWHEREID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWWHERE>()
                .Property(e => e.MODULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWWHERE>()
                .Property(e => e.CONTROLTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWWHERE>()
                .Property(e => e.CONTROLDEFAULT)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWWHERE>()
                .Property(e => e.CONTROLSOURCE)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWWHERE>()
                .Property(e => e.FIELDNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWWHERE>()
                .Property(e => e.FULLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWWHERE>()
                .Property(e => e.SHOWNAME)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWWHERE>()
                .Property(e => e.CONTROLCUSTOM)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWWHEREPERMISSION>()
                .Property(e => e.VIEWWHEREPERMISSIONID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWWHEREPERMISSION>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWWHEREPERMISSION>()
                .Property(e => e.OBJECTID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWWHEREPERMISSION>()
                .Property(e => e.MODULEID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWWHEREPERMISSION>()
                .Property(e => e.VIEWID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWWHEREPERMISSION>()
                .Property(e => e.VIEWWHEREDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWWHEREPERMISSION>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<BASE_VIEWWHEREPERMISSION>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.POORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.PARENTID)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.BILLNO)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.METHOD)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.CLEARING)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.CURRENCY)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.FETCHADD)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.SALESMANID)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.SALESMAN)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.CREATEDEPARTMENTID)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.CREATEDEPARTMENTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.MODIFYDEPARTMENTID)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.MODIFYDEPARTMENTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.AUDITSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.AUDITSTATUSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<POORDER>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<POORDERENTRY>()
                .Property(e => e.POORDERENTRYID)
                .IsUnicode(false);

            modelBuilder.Entity<POORDERENTRY>()
                .Property(e => e.POORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<POORDERENTRY>()
                .Property(e => e.BATCHNO)
                .IsUnicode(false);

            modelBuilder.Entity<POORDERENTRY>()
                .Property(e => e.ITEMID)
                .IsUnicode(false);

            modelBuilder.Entity<POORDERENTRY>()
                .Property(e => e.ITEMCODE)
                .IsUnicode(false);

            modelBuilder.Entity<POORDERENTRY>()
                .Property(e => e.ITEMNAME)
                .IsUnicode(false);

            modelBuilder.Entity<POORDERENTRY>()
                .Property(e => e.ITEMMODEL)
                .IsUnicode(false);

            modelBuilder.Entity<POORDERENTRY>()
                .Property(e => e.UNITID)
                .IsUnicode(false);

            modelBuilder.Entity<POORDERENTRY>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<POORDERENTRY>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<POORDERENTRY>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<POORDERENTRY>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<POORDERENTRY>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_AREACODE>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_AREACODE>()
                .Property(e => e.BUSINESSID)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_AREACODE>()
                .Property(e => e.MATERIALSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_AREACODE>()
                .Property(e => e.BUSINESSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_AREACODE>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_AREACODE>()
                .Property(e => e.LOCATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_INDETTAIL>()
                .Property(e => e.INDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_INDETTAIL>()
                .Property(e => e.INCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_INDETTAIL>()
                .Property(e => e.DELIVERYID)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_INDETTAIL>()
                .Property(e => e.MATERIALSCNNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_INDETTAIL>()
                .Property(e => e.MATERIALSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_INDETTAIL>()
                .Property(e => e.PACKMODEL)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_INDETTAIL>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_INDETTAIL>()
                .Property(e => e.LOCATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_INDETTAIL>()
                .Property(e => e.INORDERNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_INDETTAIL>()
                .Property(e => e.BUSINESSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_INDETTAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_INDETTAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_LOCATIONFUNCTIONCODE>()
                .Property(e => e.LOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_LOCATIONFUNCTIONCODE>()
                .Property(e => e.LOCATIONFUNCTIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTDETTAIL>()
                .Property(e => e.OUTDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTDETTAIL>()
                .Property(e => e.OUTPLANID)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTDETTAIL>()
                .Property(e => e.DELIVERYID)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTDETTAIL>()
                .Property(e => e.OUTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTDETTAIL>()
                .Property(e => e.UNLOADINGPLACE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTDETTAIL>()
                .Property(e => e.MATERIALSCNNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTDETTAIL>()
                .Property(e => e.MATERIALSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTDETTAIL>()
                .Property(e => e.PACKMODEL)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTDETTAIL>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTDETTAIL>()
                .Property(e => e.LOCATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTDETTAIL>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTDETTAIL>()
                .Property(e => e.BUSINESSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTDETTAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTDETTAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTTASKJHDETAI>()
                .Property(e => e.DELIVERYID)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTTASKJHDETAI>()
                .Property(e => e.OUTQUANTITY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<VIEW_OUTTASKJHDETAI>()
                .Property(e => e.MATERIALSCNNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTTASKJHDETAI>()
                .Property(e => e.MATERIALSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTTASKJHDETAI>()
                .Property(e => e.PACKMODEL)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTTASKJHDETAI>()
                .Property(e => e.LOCATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTTASKJHDETAI>()
                .Property(e => e.BUSINESSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTTASKZHDETAIL>()
                .Property(e => e.DELIVERYID)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTTASKZHDETAIL>()
                .Property(e => e.OUTQUANTITY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<VIEW_OUTTASKZHDETAIL>()
                .Property(e => e.MATERIALSCNNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTTASKZHDETAIL>()
                .Property(e => e.MATERIALSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTTASKZHDETAIL>()
                .Property(e => e.PACKMODEL)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTTASKZHDETAIL>()
                .Property(e => e.LOCATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_OUTTASKZHDETAIL>()
                .Property(e => e.BUSINESSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.ALLOCATIONMAINID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.ALLOCATIONPLANMAINID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.ALLOCATIONPLANDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.ALLOCATIONSTOCKNUM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.STARTWAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.STARTAREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.STARTLOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.ENDWAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.ENDAREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.ENDLOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.ATTRIBUTE4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.ATTRIBUTE5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONMAIN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.ALLOCATIONPLANDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.ALLOCATIONPLANMAINID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.STARTAREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.ENDAREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.SYNCSYSTEMID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.ATTRIBUTE4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.ATTRIBUTE5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANMAIN>()
                .Property(e => e.ALLOCATIONPLANMAINID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANMAIN>()
                .Property(e => e.STARTWAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANMAIN>()
                .Property(e => e.ENDWAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANMAIN>()
                .Property(e => e.AUDITUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANMAIN>()
                .Property(e => e.SYNCSYSTEMID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANMAIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANMAIN>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANMAIN>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANMAIN>()
                .Property(e => e.ATTRIBUTE4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANMAIN>()
                .Property(e => e.ATTRIBUTE5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANMAIN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANMAIN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANMAIN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ALLOCATIONPLANMAIN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDETAIL>()
                .Property(e => e.OUTDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDETAIL>()
                .Property(e => e.OUTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDETAIL>()
                .Property(e => e.OUTPLANDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDETAIL>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDETAIL>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDETAIL>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDETAIL>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDETAIL>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDETAIL>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDETAIL>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDETAIL>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMAIN>()
                .Property(e => e.OUTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMAIN>()
                .Property(e => e.UNLOADINGPLACE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMAIN>()
                .Property(e => e.CONTAINERCODEJH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMAIN>()
                .Property(e => e.OUTPLANID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMAIN>()
                .Property(e => e.OUTSTOCKNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMAIN>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMAIN>()
                .Property(e => e.LOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMAIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMAIN>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMAIN>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMAIN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMAIN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMAIN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMAIN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTEMP>()
                .Property(e => e.OUTTEMPID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTEMP>()
                .Property(e => e.OUTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTEMP>()
                .Property(e => e.JHCONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTEMP>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTEMP>()
                .Property(e => e.LOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTEMP>()
                .Property(e => e.OUTPLANID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTEMP>()
                .Property(e => e.OUTPLANDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTEMP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTEMP>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTEMP>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTEMP>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTEMP>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTEMP>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTEMP>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTEMP>()
                .Property(e => e.STOCKPILEID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.BUSINESSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.BUSINESSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.BUSINESSTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.BUSINESSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.SHORTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.BUSINESSDESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.PHONE1)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.PHONE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.FAX1)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.WEB)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.EMAIL1)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.LINKMAN1)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.LINKMAN2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.PYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.SYNCSYSTEMID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.SHOPTO)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.FAX2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.EMAIL2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.MOBILE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.MOBILE1)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.ROUTE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.STATE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.ZIP)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BUSINESSINFO>()
                .Property(e => e.COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CARINFO>()
                .Property(e => e.CARID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CARINFO>()
                .Property(e => e.CARCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CARINFO>()
                .Property(e => e.DRIVER)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CARINFO>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CARINFO>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CARINFO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CARINFO>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CARINFO>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CARINFO>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CARINFO>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKDETAIL>()
                .Property(e => e.CHECKDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKDETAIL>()
                .Property(e => e.CHECKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKDETAIL>()
                .Property(e => e.CHECKPLANDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKDETAIL>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKDETAIL>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKDETAIL>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKDETAIL>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKDETAIL>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKDETAIL>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKDETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKDETAIL>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKDETAIL>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKMAIN>()
                .Property(e => e.CHECKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKMAIN>()
                .Property(e => e.CHECKPLANMAINID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKMAIN>()
                .Property(e => e.CHECKSTOCKNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKMAIN>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKMAIN>()
                .Property(e => e.LOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKMAIN>()
                .Property(e => e.OPERATORID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKMAIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKMAIN>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKMAIN>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKMAIN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKMAIN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKMAIN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKMAIN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANDETAIL>()
                .Property(e => e.CHECKPLANDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANDETAIL>()
                .Property(e => e.CHECKPLANMAINID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANDETAIL>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANDETAIL>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANDETAIL>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANDETAIL>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANDETAIL>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANDETAIL>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANDETAIL>()
                .Property(e => e.SYNCSYSTEMDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANDETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANDETAIL>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANDETAIL>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANMAIN>()
                .Property(e => e.CHECKPLANMAINID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANMAIN>()
                .Property(e => e.AUDITUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANMAIN>()
                .Property(e => e.SYNCSYSTEMID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANMAIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANMAIN>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANMAIN>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANMAIN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANMAIN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANMAIN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CHECKPLANMAIN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERINFO>()
                .Property(e => e.CONTAINERCODEID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERINFO>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERINFO>()
                .Property(e => e.CONTAINERTYPEID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERINFO>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERINFO>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERINFO>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERINFO>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERINFO>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERINFO>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERINFO>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERTYPE>()
                .Property(e => e.CONTAINERTYPEID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERTYPE>()
                .Property(e => e.CONTAINERTYPECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERTYPE>()
                .Property(e => e.CONTAINERTYPENAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERTYPE>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERTYPE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERTYPE>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERTYPE>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERTYPE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERTYPE>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERTYPE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CONTAINERTYPE>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEDETAIL>()
                .Property(e => e.EXAMINEDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEDETAIL>()
                .Property(e => e.EXAMINEMAINID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEDETAIL>()
                .Property(e => e.INORDERDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEDETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEDETAIL>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEDETAIL>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEMAIN>()
                .Property(e => e.EXAMINEMAINID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEMAIN>()
                .Property(e => e.INORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEMAIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEMAIN>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEMAIN>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEMAIN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEMAIN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEMAIN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_EXAMINEMAIN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INDETAIL>()
                .Property(e => e.INDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INDETAIL>()
                .Property(e => e.INCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INDETAIL>()
                .Property(e => e.INPLANDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INDETAIL>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INDETAIL>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INDETAIL>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INDETAIL>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INDETAIL>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INDETAIL>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INDETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INDETAIL>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INDETAIL>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INMAIN>()
                .Property(e => e.INCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INMAIN>()
                .Property(e => e.INORDERNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INMAIN>()
                .Property(e => e.INPLANID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INMAIN>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INMAIN>()
                .Property(e => e.LOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INMAIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INMAIN>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INMAIN>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INMAIN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INMAIN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INMAIN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INMAIN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERDETAIL>()
                .Property(e => e.INORDERDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERDETAIL>()
                .Property(e => e.INORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERDETAIL>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERDETAIL>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERDETAIL>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERDETAIL>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERDETAIL>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERDETAIL>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERDETAIL>()
                .Property(e => e.SYNCSYSTEMDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERDETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERDETAIL>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERDETAIL>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERMAIN>()
                .Property(e => e.INORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERMAIN>()
                .Property(e => e.INORDERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERMAIN>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERMAIN>()
                .Property(e => e.SYNCSYSTEMID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERMAIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERMAIN>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERMAIN>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERMAIN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERMAIN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERMAIN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERMAIN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERTEMP>()
                .Property(e => e.INORDERTEMPID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERTEMP>()
                .Property(e => e.INORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERTEMP>()
                .Property(e => e.INORDERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERTEMP>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERTEMP>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERTEMP>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERTEMP>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERTEMP>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERTEMP>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERTEMP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERTEMP>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERTEMP>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERTEMP>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERTEMP>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERTEMP>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INORDERTEMP>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANDETAIL>()
                .Property(e => e.INPLANDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANDETAIL>()
                .Property(e => e.INPLANID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANDETAIL>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANDETAIL>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANDETAIL>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANDETAIL>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANDETAIL>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANDETAIL>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANDETAIL>()
                .Property(e => e.SYNCSYSTEMDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANDETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANDETAIL>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANDETAIL>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANMAIN>()
                .Property(e => e.INPLANID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANMAIN>()
                .Property(e => e.DELIVERYID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANMAIN>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANMAIN>()
                .Property(e => e.SYNCSYSTEMID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANMAIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANMAIN>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANMAIN>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANMAIN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANMAIN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANMAIN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANMAIN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANTEMP>()
                .Property(e => e.INPLANTEMPID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANTEMP>()
                .Property(e => e.INPLANID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANTEMP>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANTEMP>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANTEMP>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANTEMP>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANTEMP>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANTEMP>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANTEMP>()
                .Property(e => e.ORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANTEMP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANTEMP>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANTEMP>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANTEMP>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANTEMP>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANTEMP>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INPLANTEMP>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INTEMP>()
                .Property(e => e.INTEMPID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INTEMP>()
                .Property(e => e.INPLANID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INTEMP>()
                .Property(e => e.INPLANDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INTEMP>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INTEMP>()
                .Property(e => e.LOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INTEMP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INTEMP>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INTEMP>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INTEMP>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INTEMP>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INTEMP>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_INTEMP>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_JXDMX>()
                .Property(e => e.SQSL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_JXDMX>()
                .Property(e => e.JXSL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_JXDMX>()
                .Property(e => e.PFSL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_JXDMX>()
                .Property(e => e.XNFL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_JXDMX>()
                .Property(e => e.TLSL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_JXDMX>()
                .Property(e => e.PSTL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_LANESTATUS>()
                .Property(e => e.LANEID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LANESTATUS>()
                .Property(e => e.LANECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LANESTATUS>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LANESTATUS>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LANESTATUS>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LANESTATUS>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LANESTATUS>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LANESTATUS>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LANESTATUS>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONCONTAINERMAP>()
                .Property(e => e.MAPID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONCONTAINERMAP>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONCONTAINERMAP>()
                .Property(e => e.LOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONCONTAINERMAP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONCONTAINERMAP>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONCONTAINERMAP>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONCONTAINERMAP>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONCONTAINERMAP>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONCONTAINERMAP>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONCONTAINERMAP>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONFUNCTION>()
                .Property(e => e.LOCATIONFUNCTIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONFUNCTION>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONFUNCTION>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONFUNCTION>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONFUNCTION>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONFUNCTION>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONFUNCTION>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONFUNCTION>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LOCATIONFUNCTION>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALS>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALS>()
                .Property(e => e.MATERIALSSORTSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALS>()
                .Property(e => e.MATERIALSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALS>()
                .Property(e => e.MATERIALSCNNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALS>()
                .Property(e => e.MATERIALSENNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALS>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALS>()
                .Property(e => e.MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALS>()
                .Property(e => e.PYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALS>()
                .Property(e => e.SYNCSYSTEMID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALS>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALS>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALS>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALS>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALS>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALS>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALS>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSBUSINESSMAP>()
                .Property(e => e.MAPID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSBUSINESSMAP>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSBUSINESSMAP>()
                .Property(e => e.BUSINESSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSBUSINESSMAP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSBUSINESSMAP>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSBUSINESSMAP>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSBUSINESSMAP>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSBUSINESSMAP>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSBUSINESSMAP>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSBUSINESSMAP>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSBUSINESSMAP>()
                .Property(e => e.QUANTITY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_MATERIALSLOCATIONMAP>()
                .Property(e => e.MAPID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSLOCATIONMAP>()
                .Property(e => e.LOCATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSLOCATIONMAP>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSLOCATIONMAP>()
                .Property(e => e.MATERIALSSORTSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSLOCATIONMAP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSLOCATIONMAP>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSLOCATIONMAP>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSLOCATIONMAP>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSLOCATIONMAP>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSLOCATIONMAP>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSLOCATIONMAP>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSSORTS>()
                .Property(e => e.MATERIALSSORTSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSSORTS>()
                .Property(e => e.SORTSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSSORTS>()
                .Property(e => e.PARENTID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSSORTS>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSSORTS>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSSORTS>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSSORTS>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSSORTS>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSSORTS>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSSORTS>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSTORAGEAREA>()
                .Property(e => e.MATERIALSTORAGEAREAID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSTORAGEAREA>()
                .Property(e => e.MATERIALSSORTSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSTORAGEAREA>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSTORAGEAREA>()
                .Property(e => e.STORAGEAREAID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSTORAGEAREA>()
                .Property(e => e.LANEID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSTORAGEAREA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSTORAGEAREA>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSTORAGEAREA>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSTORAGEAREA>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSTORAGEAREA>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSTORAGEAREA>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MATERIALSTORAGEAREA>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.OUTDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.OUTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.OUTPLANDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.MATERIALSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTDETAIL>()
                .Property(e => e.BUSINESSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTMAIN>()
                .Property(e => e.OUTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTMAIN>()
                .Property(e => e.UNLOADINGPLACE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTMAIN>()
                .Property(e => e.CONTAINERCODEJH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTMAIN>()
                .Property(e => e.OUTPLANID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTMAIN>()
                .Property(e => e.OUTSTOCKNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTMAIN>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTMAIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTMAIN>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTMAIN>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTMAIN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTMAIN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTMAIN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTMAIN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.OUTORDERDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.OUTORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.CARDNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.ORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.SYNCSYSTEMDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERMAIN>()
                .Property(e => e.OUTORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERMAIN>()
                .Property(e => e.DELIVERYID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERMAIN>()
                .Property(e => e.RECEIVECOMPANYID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERMAIN>()
                .Property(e => e.ORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERMAIN>()
                .Property(e => e.UNLOADID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERMAIN>()
                .Property(e => e.SYNCSYSTEMID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERMAIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERMAIN>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERMAIN>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERMAIN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERMAIN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERMAIN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTORDERMAIN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.OUTPLANDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.OUTPLANID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.UNLOADID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.RECEIVECOMPANYID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.CARDNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.ORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.SYNCSYSTEMDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANMAIN>()
                .Property(e => e.OUTPLANID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANMAIN>()
                .Property(e => e.OUTORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANMAIN>()
                .Property(e => e.DELIVERYID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANMAIN>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANMAIN>()
                .Property(e => e.SYNCSYSTEMID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANMAIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANMAIN>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANMAIN>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANMAIN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANMAIN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANMAIN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANMAIN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.OUTPLANTEMPID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.UNLOADID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.RECEIVECOMPANYID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.CARDNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.ORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.OUTSERIALNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTPLANTEMP>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTASK>()
                .Property(e => e.PLANQUANTITY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_OUTTASK>()
                .Property(e => e.OUTQUANTITY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_OUTTASK>()
                .Property(e => e.LOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTASK>()
                .Property(e => e.ZHQUANTITY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_OUTTASK>()
                .Property(e => e.BHQUANTITY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_OUTTASK>()
                .Property(e => e.XNSL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_OUTTASK>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTASK>()
                .Property(e => e.PRODUCTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTASKBHDETAIL>()
                .Property(e => e.OUTQUANTITY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_OUTTASKJHDETAIL>()
                .Property(e => e.OUTQUANTITY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_OUTTASKZHDETAIL>()
                .Property(e => e.OUTQUANTITY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_OUTTEMP>()
                .Property(e => e.OUTTEMPID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTEMP>()
                .Property(e => e.OUTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTEMP>()
                .Property(e => e.JHCONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTEMP>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTEMP>()
                .Property(e => e.LOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTEMP>()
                .Property(e => e.OUTPLANID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTEMP>()
                .Property(e => e.OUTPLANDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTEMP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTEMP>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTEMP>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTEMP>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTEMP>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTEMP>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTEMP>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OUTTEMP>()
                .Property(e => e.STOCKPILEID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.PACKMODEL)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.INCONTAINERTYPEID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.LENGTHUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.WEIGHTUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.STOCKPILEUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.PACKBARCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.OUTCONTAINERTYPEID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.STOCKMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PACKSPEC>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTHHSTORYTABLE>()
                .Property(e => e.PRINTID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTHHSTORYTABLE>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTHHSTORYTABLE>()
                .Property(e => e.MATERIALSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTHHSTORYTABLE>()
                .Property(e => e.MATERIALSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTHHSTORYTABLE>()
                .Property(e => e.MODEL)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTHHSTORYTABLE>()
                .Property(e => e.PACKMODEL)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTHHSTORYTABLE>()
                .Property(e => e.MATERIALSATTRIBUTE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTHHSTORYTABLE>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTHHSTORYTABLE>()
                .Property(e => e.PRODUCTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTHHSTORYTABLE>()
                .Property(e => e.MATUREDATE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTHHSTORYTABLE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTHHSTORYTABLE>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTHHSTORYTABLE>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTHHSTORYTABLE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTHHSTORYTABLE>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTHHSTORYTABLE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTHHSTORYTABLE>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.PRINTID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.MATERIALSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.MATERIALSNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.FIGURENUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.PACKMODEL)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.MATERIALSATTRIBUTE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.PRODUCTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.PRODUCTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.MATUREDATE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.FLAG)
                .IsFixedLength();

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PRINTTABLE>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QUALITYCHECK>()
                .Property(e => e.QUALITYCHECKID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QUALITYCHECK>()
                .Property(e => e.QUALITYCHECKNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QUALITYCHECK>()
                .Property(e => e.INPLANID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QUALITYCHECK>()
                .Property(e => e.INPLANDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QUALITYCHECK>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QUALITYCHECK>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QUALITYCHECK>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QUALITYCHECK>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QUALITYCHECK>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QUALITYCHECK>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QUALITYCHECK>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QUALITYCHECK>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QUALITYCHECK>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QUALITYCHECK>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QUALITYCHECK>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYDETAIL>()
                .Property(e => e.REBUILDAPPLYDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYDETAIL>()
                .Property(e => e.REBUILDAPPLYMAINID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYDETAIL>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYDETAIL>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYDETAIL>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYDETAIL>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYDETAIL>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYDETAIL>()
                .Property(e => e.SYNCSYSTEMDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYDETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYDETAIL>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYDETAIL>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYDETAIL>()
                .Property(e => e.ATTRIBUTE4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYDETAIL>()
                .Property(e => e.ATTRIBUTE5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYMAIN>()
                .Property(e => e.REBUILDAPPLYMAINID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYMAIN>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYMAIN>()
                .Property(e => e.AUDITUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYMAIN>()
                .Property(e => e.SYNCSYSTEMID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYMAIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYMAIN>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYMAIN>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYMAIN>()
                .Property(e => e.ATTRIBUTE4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYMAIN>()
                .Property(e => e.ATTRIBUTE5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYMAIN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYMAIN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYMAIN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDAPPLYMAIN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.REBUILDCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.REBUILDPLANMAINID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.REBUILDPLANDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.REBUILDSTOCKNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.STARTWAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.STARTAREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.STARTLOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.ENDWAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.ENDAREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.ENDLOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.SYNCSYSTEMDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.ATTRIBUTE4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.ATTRIBUTE5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDMAIN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.REBUILDPLANDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.REBUILDPLANMAINID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.SYNCSYSTEMDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.ATTRIBUTE4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.ATTRIBUTE5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANMAIN>()
                .Property(e => e.REBUILDPLANMAINID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANMAIN>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANMAIN>()
                .Property(e => e.AUDITUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANMAIN>()
                .Property(e => e.SYNCSYSTEMID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANMAIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANMAIN>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANMAIN>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANMAIN>()
                .Property(e => e.ATTRIBUTE4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANMAIN>()
                .Property(e => e.ATTRIBUTE5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANMAIN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANMAIN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANMAIN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_REBUILDPLANMAIN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STOCKPILE>()
                .Property(e => e.STOCKPILEID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STOCKPILE>()
                .Property(e => e.LOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STOCKPILE>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STOCKPILE>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STOCKPILE>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STOCKPILE>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STOCKPILE>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STOCKPILE>()
                .Property(e => e.PRODUCTID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STOCKPILE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STOCKPILE>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STOCKPILE>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STOCKPILE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STOCKPILE>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STOCKPILE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STOCKPILE>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STOCKPILE>()
                .Property(e => e.ATTRIBUTE4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STOCKPILE>()
                .Property(e => e.ATTRIBUTE5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STORAGEAREA>()
                .Property(e => e.STORAGEAREAID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STORAGEAREA>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STORAGEAREA>()
                .Property(e => e.LOCATIONFUNCTIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STORAGEAREA>()
                .Property(e => e.AREANAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STORAGEAREA>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STORAGEAREA>()
                .Property(e => e.STORAGEAREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STORAGEAREA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STORAGEAREA>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STORAGEAREA>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STORAGEAREA>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STORAGEAREA>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STORAGEAREA>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STORAGEAREA>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STORAGEAREAMATERIALMAP>()
                .Property(e => e.STORAGEAREAID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STORAGEAREAMATERIALMAP>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STORAGEAREAMATERIALMAP>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_STORAGEAREAMATERIALMAP>()
                .Property(e => e.MATERIALSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SUPPLIERMTLSTORAGEAREA>()
                .Property(e => e.SUPPLIERMATERIALSSTORAGEAREAID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SUPPLIERMTLSTORAGEAREA>()
                .Property(e => e.BUSINESSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SUPPLIERMTLSTORAGEAREA>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SUPPLIERMTLSTORAGEAREA>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SUPPLIERMTLSTORAGEAREA>()
                .Property(e => e.STORAGEAREAID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SUPPLIERMTLSTORAGEAREA>()
                .Property(e => e.LANEID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SUPPLIERMTLSTORAGEAREA>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SUPPLIERMTLSTORAGEAREA>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SUPPLIERMTLSTORAGEAREA>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SUPPLIERMTLSTORAGEAREA>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SUPPLIERMTLSTORAGEAREA>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SUPPLIERMTLSTORAGEAREA>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SUPPLIERMTLSTORAGEAREA>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.SKUNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.COMPANYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.GROUPNAME1)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.GROUPVALUE1)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.GROUPNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.GROUPVALUE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.GROUPNAME3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.GROUPVALUE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.WORKINSTRUCTION)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.TICKETNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.LOCATIONFROM)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.LOCATIONTO)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.LOCATIONTOOVERRIDE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.ZONECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.AREACODESPREAD)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.PICKINGSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.CCSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.PUTSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.LPNFROM)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.LPNTO)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.TEMPLPN)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.PACKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.UMCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.UMCODEDESC)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.QTY)
                .HasPrecision(18, 3);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.COMPLETEDQTY)
                .HasPrecision(18, 3);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.SOURCEID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.ASSIGNUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.ASSIGNUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.EXPTIME)
                .HasPrecision(12, 0);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.EXECWHO)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.EXECWHONAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.DES)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.GROUPKEY)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.PAGENUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.RETRIEVEVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.WAVENUM)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.ENABLE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.DISPATCHNODEINFO)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.ISAUTOTASK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.IS_LINE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.IS_AUDIT)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.IS_WKPICK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.QCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.RECORDSYSNO)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAIL>()
                .Property(e => e.RECORDQUESYSNO)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.TASKID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.TASKTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.TRANTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.CONFIRMTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.SKUSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.SKUCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.SKUNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.COMPANYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.PRIORITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.PREPOSEID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.POSEID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.GROUPNAME1)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.GROUPVALUE1)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.GROUPNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.GROUPVALUE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.GROUPNAME3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.GROUPVALUE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.MARKING)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.WORKINSTRUCTION)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.TICKETNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.LOCATIONFROM)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.LOCATIONTO)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.LOCATIONTOOVERRIDE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.ZONECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.AREACODESPREAD)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.PICKINGSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.CCSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.PUTSEQ)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.LOT)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.LPNFROM)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.LPNTO)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.TEMPLPN)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.PACKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.PACKDETAILSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.UMCODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.UMCODEDESC)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.UMQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.QTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.COMPLETEDQTY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.SOURCETYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.SOURCEID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.SOURCELINENO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.ENGINEID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.WAVEID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.ASSIGNUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.ASSIGNUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.EXPTIME)
                .HasPrecision(12, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.EXECWHO)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.EXECWHONAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.ZONESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.DES)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.RV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.GROUPKEY)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.CHANGEPLANSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.CANGROUPSTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.PAGENUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.MESSAGEID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.RETRIEVEVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.RELEASEMODEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.WAVENUM)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.MOVETYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.ENABLE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.DISPATCHNODEINFO)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.ISAUTOTASK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.PICKQUEUESYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.INV_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.IS_LINE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.IS_AUDIT)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.IS_WKPICK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.QCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.RECORDSYSNO)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKDETAILHISTORY>()
                .Property(e => e.RECORDQUESYSNO)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.SYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.OBJECTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.ENGINECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.EGTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.PRIORITY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.ONEDIMENSIONFILTER)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.RETRIEVEVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.GROUPNAME1)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.GROUPVALUE1)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.GROUPNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.GROUPVALUE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.GROUPNAME3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.GROUPVALUE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.CONFIRMTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.TASKINSTRUCTION)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.MARKING)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.RELEASEMODEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.MAXRECORDS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.MAXCUBE)
                .HasPrecision(12, 0);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.EXPTIME)
                .HasPrecision(12, 0);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.INTPROPERTYONE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.INTPROPERTYTWO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.INTPROPERTYTHREE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.STRINGPROPERTYONE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.STRINGPROPERTYTWO)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.STRINGPROPERTYTHREE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.ONEFILTERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.TWOFILTERSYSNO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.LOCATIONMODEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.ISLPNTOSAMELOC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.PICKTOLOCATION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.ISCOLLECTAFTERPICK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKENGINE>()
                .Property(e => e.SOURCETYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<WMS_TASKS>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKS>()
                .Property(e => e.GROUPNAME1)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKS>()
                .Property(e => e.GROUPVALUE1)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKS>()
                .Property(e => e.GROUPNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKS>()
                .Property(e => e.GROUPVALUE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKS>()
                .Property(e => e.GROUPNAME3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKS>()
                .Property(e => e.GROUPVALUE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKS>()
                .Property(e => e.RETRIEVEVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKS>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKS>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKS>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKS>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKS>()
                .Property(e => e.GROUPKEY)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKS>()
                .Property(e => e.COMPANYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKS>()
                .Property(e => e.COMPANYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKS>()
                .Property(e => e.WAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKS>()
                .Property(e => e.WAREHOUSENAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSMAINTEMP>()
                .Property(e => e.TASKTEMPID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSMAINTEMP>()
                .Property(e => e.TYPECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSMAINTEMP>()
                .Property(e => e.BILLSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSMAINTEMP>()
                .Property(e => e.OPERATERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSMAINTEMP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSMAINTEMP>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSMAINTEMP>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSMAINTEMP>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSMAINTEMP>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSMAINTEMP>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSMAINTEMP>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTEMP>()
                .Property(e => e.TASKTEMPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTEMP>()
                .Property(e => e.TASKTEMPID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTEMP>()
                .Property(e => e.GLIDECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTEMP>()
                .Property(e => e.STARTLOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTEMP>()
                .Property(e => e.ENDLOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTEMP>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTEMP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTEMP>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTEMP>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTEMP>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTEMP>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTEMP>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTEMP>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTYPE>()
                .Property(e => e.TYPECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTYPE>()
                .Property(e => e.TYPENAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTYPE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTYPE>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTYPE>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTYPE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTYPE>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTYPE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKSTYPE>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKTYPEPOSTMAP>()
                .Property(e => e.MAPID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKTYPEPOSTMAP>()
                .Property(e => e.TYPECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKTYPEPOSTMAP>()
                .Property(e => e.POSTID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKTYPEPOSTMAP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKTYPEPOSTMAP>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKTYPEPOSTMAP>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKTYPEPOSTMAP>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKTYPEPOSTMAP>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKTYPEPOSTMAP>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TASKTYPEPOSTMAP>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.TRANSITSTOCKNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.STARTWAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.STARTAREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.STARTLOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.ENDWAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.ENDAREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.ENDLOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.ATTRIBUTE4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.ATTRIBUTE5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSIT>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.TRANSITSTOCKNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.STARTWAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.STARTAREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.STARTLOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.ENDWAREHOUSECODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.ENDAREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.ENDLOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.ATTRIBUTE4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.ATTRIBUTE5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TRANSITMAIN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UNLOADINGPLACE>()
                .Property(e => e.UNLOADID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UNLOADINGPLACE>()
                .Property(e => e.ROADJUNCTIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UNLOADINGPLACE>()
                .Property(e => e.ROADJUNCTIONNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UNLOADINGPLACE>()
                .Property(e => e.BUSINESSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UNLOADINGPLACE>()
                .Property(e => e.RECEIVEPLACE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UNLOADINGPLACE>()
                .Property(e => e.WORKSHOPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UNLOADINGPLACE>()
                .Property(e => e.WORKSHOPNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UNLOADINGPLACE>()
                .Property(e => e.FACTORYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UNLOADINGPLACE>()
                .Property(e => e.FACTORYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UNLOADINGPLACE>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UNLOADINGPLACE>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UNLOADINGPLACE>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UNLOADINGPLACE>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UNLOADINGPLACE>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UNLOADINGPLACE>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UNLOADINGPLACE>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDETAIL>()
                .Property(e => e.OUTDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDETAIL>()
                .Property(e => e.OUTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDETAIL>()
                .Property(e => e.OUTPLANDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDETAIL>()
                .Property(e => e.MATERIALSID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDETAIL>()
                .Property(e => e.PACKSPECID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDETAIL>()
                .Property(e => e.PRODUCTBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDETAIL>()
                .Property(e => e.SUPPLIERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDETAIL>()
                .Property(e => e.SUPPLIERBATCH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDETAIL>()
                .Property(e => e.PRODUCTIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDETAIL>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDETAIL>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDETAIL>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDETAIL>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDETAIL>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDETAIL>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDETAIL>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMAIN>()
                .Property(e => e.OUTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMAIN>()
                .Property(e => e.UNLOADINGPLACE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMAIN>()
                .Property(e => e.CONTAINERCODEJH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMAIN>()
                .Property(e => e.OUTPLANID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMAIN>()
                .Property(e => e.OUTSTOCKNUM)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMAIN>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMAIN>()
                .Property(e => e.LOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMAIN>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMAIN>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMAIN>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMAIN>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMAIN>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMAIN>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMAIN>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTEMP>()
                .Property(e => e.ZHTEMPID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTEMP>()
                .Property(e => e.OUTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTEMP>()
                .Property(e => e.JHCONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTEMP>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTEMP>()
                .Property(e => e.LOCATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTEMP>()
                .Property(e => e.OUTPLANID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTEMP>()
                .Property(e => e.OUTPLANDETAILID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTEMP>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTEMP>()
                .Property(e => e.ATTRIBUTE2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTEMP>()
                .Property(e => e.ATTRIBUTE3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTEMP>()
                .Property(e => e.CREATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTEMP>()
                .Property(e => e.CREATEUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTEMP>()
                .Property(e => e.MODIFYUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTEMP>()
                .Property(e => e.MODIFYUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTEMP>()
                .Property(e => e.STOCKPILEID)
                .IsUnicode(false);
        }
    }
}
