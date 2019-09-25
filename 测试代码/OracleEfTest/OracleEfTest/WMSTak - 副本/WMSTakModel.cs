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

        public virtual DbSet<Base_BackupJob> Base_BackupJob { get; set; }
        public virtual DbSet<Base_Button> Base_Button { get; set; }
        public virtual DbSet<Base_ButtonPermission> Base_ButtonPermission { get; set; }
        public virtual DbSet<Base_CodeRule> Base_CodeRule { get; set; }
        public virtual DbSet<Base_CodeRuleDetail> Base_CodeRuleDetail { get; set; }
        public virtual DbSet<Base_CodeRuleSerious> Base_CodeRuleSerious { get; set; }
        public virtual DbSet<Base_Company> Base_Company { get; set; }
        public virtual DbSet<Base_DataDictionary> Base_DataDictionary { get; set; }
        public virtual DbSet<Base_DataDictionaryDetail> Base_DataDictionaryDetail { get; set; }
        public virtual DbSet<Base_DataScopePermission> Base_DataScopePermission { get; set; }
        public virtual DbSet<Base_Department> Base_Department { get; set; }
        public virtual DbSet<Base_Email> Base_Email { get; set; }
        public virtual DbSet<Base_EmailAccessory> Base_EmailAccessory { get; set; }
        public virtual DbSet<Base_EmailAddressee> Base_EmailAddressee { get; set; }
        public virtual DbSet<Base_EmailCategory> Base_EmailCategory { get; set; }
        public virtual DbSet<Base_Employee> Base_Employee { get; set; }
        public virtual DbSet<Base_ExcelImport> Base_ExcelImport { get; set; }
        public virtual DbSet<Base_ExcelImportDetail> Base_ExcelImportDetail { get; set; }
        public virtual DbSet<Base_FormAttribute> Base_FormAttribute { get; set; }
        public virtual DbSet<Base_FormAttributeValue> Base_FormAttributeValue { get; set; }
        public virtual DbSet<Base_GroupUser> Base_GroupUser { get; set; }
        public virtual DbSet<Base_InterfaceManage> Base_InterfaceManage { get; set; }
        public virtual DbSet<Base_InterfaceManageParameter> Base_InterfaceManageParameter { get; set; }
        public virtual DbSet<Base_Language> Base_Language { get; set; }
        public virtual DbSet<Base_Module> Base_Module { get; set; }
        public virtual DbSet<Base_ModulePermission> Base_ModulePermission { get; set; }
        public virtual DbSet<Base_NetworkFile> Base_NetworkFile { get; set; }
        public virtual DbSet<Base_NetworkFolder> Base_NetworkFolder { get; set; }
        public virtual DbSet<Base_ObjectUserRelation> Base_ObjectUserRelation { get; set; }
        public virtual DbSet<Base_PhoneNote> Base_PhoneNote { get; set; }
        public virtual DbSet<Base_Post> Base_Post { get; set; }
        public virtual DbSet<Base_ProvinceCity> Base_ProvinceCity { get; set; }
        public virtual DbSet<Base_QueryRecord> Base_QueryRecord { get; set; }
        public virtual DbSet<Base_Roles> Base_Roles { get; set; }
        public virtual DbSet<Base_Shortcuts> Base_Shortcuts { get; set; }
        public virtual DbSet<Base_SysLog> Base_SysLog { get; set; }
        public virtual DbSet<Base_SysLogDetail> Base_SysLogDetail { get; set; }
        public virtual DbSet<Base_User> Base_User { get; set; }
        public virtual DbSet<Base_View> Base_View { get; set; }
        public virtual DbSet<Base_ViewPermission> Base_ViewPermission { get; set; }
        public virtual DbSet<Base_ViewWhere> Base_ViewWhere { get; set; }
        public virtual DbSet<Base_ViewWherePermission> Base_ViewWherePermission { get; set; }
        public virtual DbSet<DB_Import_InPlanDetail> DB_Import_InPlanDetail { get; set; }
        public virtual DbSet<ModuleInfo> ModuleInfo { get; set; }
        public virtual DbSet<POOrder> POOrder { get; set; }
        public virtual DbSet<POOrderEntry> POOrderEntry { get; set; }
        public virtual DbSet<WMS_AllocationMain> WMS_AllocationMain { get; set; }
        public virtual DbSet<WMS_AllocationPlanDetail> WMS_AllocationPlanDetail { get; set; }
        public virtual DbSet<WMS_AllocationPlanMain> WMS_AllocationPlanMain { get; set; }
        public virtual DbSet<WMS_BHDetail> WMS_BHDetail { get; set; }
        public virtual DbSet<WMS_BHMain> WMS_BHMain { get; set; }
        public virtual DbSet<WMS_BHTemp> WMS_BHTemp { get; set; }
        public virtual DbSet<WMS_BillNumber> WMS_BillNumber { get; set; }
        public virtual DbSet<WMS_BusinessInfo> WMS_BusinessInfo { get; set; }
        public virtual DbSet<WMS_CarInfo> WMS_CarInfo { get; set; }
        public virtual DbSet<WMS_CheckDetail> WMS_CheckDetail { get; set; }
        public virtual DbSet<WMS_CheckMain> WMS_CheckMain { get; set; }
        public virtual DbSet<WMS_CheckPlanDetail> WMS_CheckPlanDetail { get; set; }
        public virtual DbSet<WMS_CheckPlanMain> WMS_CheckPlanMain { get; set; }
        public virtual DbSet<WMS_ChildBatchManage> WMS_ChildBatchManage { get; set; }
        public virtual DbSet<WMS_ContainerInfo> WMS_ContainerInfo { get; set; }
        public virtual DbSet<WMS_ContainerType> WMS_ContainerType { get; set; }
        public virtual DbSet<WMS_ExamineDetail> WMS_ExamineDetail { get; set; }
        public virtual DbSet<WMS_ExamineMain> WMS_ExamineMain { get; set; }
        public virtual DbSet<WMS_InDetail> WMS_InDetail { get; set; }
        public virtual DbSet<WMS_InMain> WMS_InMain { get; set; }
        public virtual DbSet<WMS_InOrderDetail> WMS_InOrderDetail { get; set; }
        public virtual DbSet<WMS_InOrderMain> WMS_InOrderMain { get; set; }
        public virtual DbSet<WMS_InOrderTemp> WMS_InOrderTemp { get; set; }
        public virtual DbSet<WMS_InPlanDetail> WMS_InPlanDetail { get; set; }
        public virtual DbSet<WMS_InPlanMain> WMS_InPlanMain { get; set; }
        public virtual DbSet<WMS_InPlanTemp> WMS_InPlanTemp { get; set; }
        public virtual DbSet<WMS_InTemp> WMS_InTemp { get; set; }
        public virtual DbSet<WMS_JXD> WMS_JXD { get; set; }
        public virtual DbSet<WMS_JXDMX> WMS_JXDMX { get; set; }
        public virtual DbSet<WMS_LaneStatus> WMS_LaneStatus { get; set; }
        public virtual DbSet<WMS_Location> WMS_Location { get; set; }
        public virtual DbSet<WMS_LocationContainerMap> WMS_LocationContainerMap { get; set; }
        public virtual DbSet<WMS_LocationFunction> WMS_LocationFunction { get; set; }
        public virtual DbSet<WMS_Materials> WMS_Materials { get; set; }
        public virtual DbSet<WMS_MaterialsBusinessMap> WMS_MaterialsBusinessMap { get; set; }
        public virtual DbSet<WMS_MaterialsLocationMap> WMS_MaterialsLocationMap { get; set; }
        public virtual DbSet<WMS_MaterialsSorts> WMS_MaterialsSorts { get; set; }
        public virtual DbSet<WMS_MaterialStorageArea> WMS_MaterialStorageArea { get; set; }
        public virtual DbSet<WMS_OutDetail> WMS_OutDetail { get; set; }
        public virtual DbSet<WMS_OutMain> WMS_OutMain { get; set; }
        public virtual DbSet<WMS_OutOrderDetail> WMS_OutOrderDetail { get; set; }
        public virtual DbSet<WMS_OutOrderMain> WMS_OutOrderMain { get; set; }
        public virtual DbSet<WMS_OutPlanDetail> WMS_OutPlanDetail { get; set; }
        public virtual DbSet<WMS_OutPlanMain> WMS_OutPlanMain { get; set; }
        public virtual DbSet<WMS_OutPlanTemp> WMS_OutPlanTemp { get; set; }
        public virtual DbSet<WMS_OutTask> WMS_OutTask { get; set; }
        public virtual DbSet<WMS_OutTaskBHDetail> WMS_OutTaskBHDetail { get; set; }
        public virtual DbSet<WMS_OutTaskBHMain> WMS_OutTaskBHMain { get; set; }
        public virtual DbSet<WMS_OutTaskJHDetail> WMS_OutTaskJHDetail { get; set; }
        public virtual DbSet<WMS_OutTaskJHMain> WMS_OutTaskJHMain { get; set; }
        public virtual DbSet<WMS_OutTaskZHDetail> WMS_OutTaskZHDetail { get; set; }
        public virtual DbSet<WMS_OutTaskZHMain> WMS_OutTaskZHMain { get; set; }
        public virtual DbSet<WMS_OutTemp> WMS_OutTemp { get; set; }
        public virtual DbSet<WMS_PackSpec> WMS_PackSpec { get; set; }
        public virtual DbSet<WMS_PrinthHstoryTable> WMS_PrinthHstoryTable { get; set; }
        public virtual DbSet<WMS_PrintTable> WMS_PrintTable { get; set; }
        public virtual DbSet<WMS_ProductBatch> WMS_ProductBatch { get; set; }
        public virtual DbSet<WMS_QualityCheck> WMS_QualityCheck { get; set; }
        public virtual DbSet<WMS_RebuildApplyDetail> WMS_RebuildApplyDetail { get; set; }
        public virtual DbSet<WMS_RebuildApplyMain> WMS_RebuildApplyMain { get; set; }
        public virtual DbSet<WMS_RebuildMain> WMS_RebuildMain { get; set; }
        public virtual DbSet<WMS_RebuildPlanDetail> WMS_RebuildPlanDetail { get; set; }
        public virtual DbSet<WMS_RebuildPlanMain> WMS_RebuildPlanMain { get; set; }
        public virtual DbSet<WMS_Stockpile> WMS_Stockpile { get; set; }
        public virtual DbSet<WMS_StorageArea> WMS_StorageArea { get; set; }
        public virtual DbSet<WMS_StorageAreaMaterialMap> WMS_StorageAreaMaterialMap { get; set; }
        public virtual DbSet<WMS_SupplierMaterialsStorageArea> WMS_SupplierMaterialsStorageArea { get; set; }
        public virtual DbSet<WMS_Tasks> WMS_Tasks { get; set; }
        public virtual DbSet<WMS_TasksMainTemp> WMS_TasksMainTemp { get; set; }
        public virtual DbSet<WMS_TasksTemp> WMS_TasksTemp { get; set; }
        public virtual DbSet<WMS_TasksType> WMS_TasksType { get; set; }
        public virtual DbSet<WMS_TaskTypePostMap> WMS_TaskTypePostMap { get; set; }
        public virtual DbSet<WMS_Transit> WMS_Transit { get; set; }
        public virtual DbSet<WMS_TransitMain> WMS_TransitMain { get; set; }
        public virtual DbSet<WMS_UnloadingPlace> WMS_UnloadingPlace { get; set; }
        public virtual DbSet<WMS_ZHDetail> WMS_ZHDetail { get; set; }
        public virtual DbSet<WMS_ZHMain> WMS_ZHMain { get; set; }
        public virtual DbSet<WMS_ZHTemp> WMS_ZHTemp { get; set; }
        public virtual DbSet<XPObjectType> XPObjectType { get; set; }
        public virtual DbSet<Base_Supplies> Base_Supplies { get; set; }
        public virtual DbSet<Table_location> Table_location { get; set; }




        public virtual DbSet<View_AreaCode> View_AreaCode { get; set; }
        public virtual DbSet<View_InDettail> View_InDettail { get; set; }
        public virtual DbSet<View_Location> View_Location { get; set; }
        public virtual DbSet<View_LocationFunctionCode> View_LocationFunctionCode { get; set; }
        public virtual DbSet<View_OutDettail> View_OutDettail { get; set; }
        public virtual DbSet<View_OutTaskJHDetai> View_OutTaskJHDetai { get; set; }
        public virtual DbSet<View_OutTaskZHDetail> View_OutTaskZHDetail { get; set; }
        public virtual DbSet<View_Transit> View_Transit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("WMS");

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.BackupId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.ServerName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.DbName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.JobName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.Mode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.StartTime)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.FilePath)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.Enabled)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_BackupJob>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ButtonId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.JsEvent)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ActionEvent)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Button>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.ButtonPermissionId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.ModuleButtonId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ButtonPermission>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.CodeRuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRule>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.CodeRuleDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.CodeRuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.Consted)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.FormatStr)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.FType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.CodeSeriousId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.CodeRuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_CodeRuleSerious>()
                .Property(e => e.LastUpdateDate)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Nature)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Manager)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.ProvinceId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.CityId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.CountyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.County)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.AccountInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Postalcode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Web)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Company>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.DataDictionaryId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionary>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.DataDictionaryDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.DataDictionaryId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataDictionaryDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.DataScopePermissionId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.ResourceId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.Condition)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.ConditionJson)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.ScopeType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_DataScopePermission>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Nature)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Manager)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Department>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.Theme)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.ThemeColour)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.Addresser)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Email>()
                .HasMany(e => e.Base_EmailAccessory)
                .WithOptional(e => e.Base_Email)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Base_Email>()
                .HasMany(e => e.Base_EmailAddressee)
                .WithOptional(e => e.Base_Email)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.EmailAccessoryId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.FilePath)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.FileSize)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAccessory>()
                .Property(e => e.FileType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAddressee>()
                .Property(e => e.EmailAddresseeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAddressee>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAddressee>()
                .Property(e => e.AddresseeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailAddressee>()
                .Property(e => e.AddresseeName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.EmailCategoryId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_EmailCategory>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.EmployeeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Photograph)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.IDCard)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.BankCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.OfficeCornet)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.OfficePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.OfficeZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.OfficeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.OfficeFax)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Education)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.School)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Major)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Degree)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.HomeZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.HomeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.HomeFax)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.NativePlace)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Party)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Nation)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Nationality)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Duty)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.WorkingProperty)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.Competency)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.EmergencyContact)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.DimissionCause)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Employee>()
                .Property(e => e.DimissionWhither)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ImportId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ImportName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ImportTable)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ImportTableName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ImportFileName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImport>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ImportDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ImportId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ColumnName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ForeignTable)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.BackField)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.CompareField)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.AttachCondition)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ExcelImportDetail>()
                .Property(e => e.FieldRemark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.FormAttributeId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.PropertyName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ControlId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ControlType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ControlStyle)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ControlValidator)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.DefaultVlaue)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.AttributesProperty)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.DataSource)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ControlColspan)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttribute>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttributeValue>()
                .Property(e => e.AttributeValueId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttributeValue>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttributeValue>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_FormAttributeValue>()
                .Property(e => e.ObjectParameterJson)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.GroupUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_GroupUser>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.InterfaceId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.Constraints)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManage>()
                .HasMany(e => e.Base_InterfaceManageParameter)
                .WithOptional(e => e.Base_InterfaceManage)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Base_InterfaceManageParameter>()
                .Property(e => e.InterfaceParameterId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManageParameter>()
                .Property(e => e.InterfaceId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManageParameter>()
                .Property(e => e.Field)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManageParameter>()
                .Property(e => e.FieldMemo)
                .IsUnicode(false);

            modelBuilder.Entity<Base_InterfaceManageParameter>()
                .Property(e => e.FieldType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.LanguageId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.BusinessCode)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.BusinessName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.FullValue)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Language>()
                .Property(e => e.LanguageType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Target)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Module>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.ModulePermissionId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ModulePermission>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.NetworkFileId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FolderId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FilePath)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FileSize)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FileExtensions)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.FileType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.SharingFolderId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFile>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.FolderId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.FolderName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.SharingFolderId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_NetworkFolder>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.ObjectUserRelationId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ObjectUserRelation>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.PhoneNoteId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.PhonenNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.SendContent)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.SendStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.DeviceName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_PhoneNote>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.PostId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.RoleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Post>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.ProvinceCityId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ProvinceCity>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.QueryRecordId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.ConditionJson)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_QueryRecord>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.RoleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Roles>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Shortcuts>()
                .Property(e => e.ShortcutsId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Shortcuts>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Shortcuts>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.SysLogId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.LogType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.IPAddressName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLog>()
                .HasMany(e => e.Base_SysLogDetail)
                .WithOptional(e => e.Base_SysLog)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.SysLogDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.SysLogId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.PropertyName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.PropertyField)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.NewValue)
                .IsUnicode(false);

            modelBuilder.Entity<Base_SysLogDetail>()
                .Property(e => e.OldValue)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.CompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.DepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Secretkey)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.RealName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Spell)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.OICQ)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.AuditStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.AuditUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.AuditUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_User>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.ViewId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.ShowName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.TextAlign)
                .IsUnicode(false);

            modelBuilder.Entity<Base_View>()
                .Property(e => e.CustomSwitch)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.ViewPermissionId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.ViewId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewPermission>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ViewWhereId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ControlType)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ControlDefault)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ControlSource)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ShowName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWhere>()
                .Property(e => e.ControlCustom)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.ViewWherePermissionId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.ObjectId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.ModuleId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.ViewId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.ViewWhereDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_ViewWherePermission>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.POOrderId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.BillNo)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.Method)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.Clearing)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.Currency)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.FetchAdd)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.SalesmanId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.Salesman)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.CreateDepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.CreateDepartmentName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.ModifyDepartmentId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.ModifyDepartmentName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.AuditStatus)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.AuditStatusName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrder>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.POOrderEntryId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.POOrderId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.BatchNo)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ItemId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ItemModel)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.UnitId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<POOrderEntry>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.AllocationMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.AllocationPlanMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.AllocationPlanDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.AllocationStockNum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.StartWarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.StartAreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.StartLocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.EndWarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.EndAreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.EndLocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.Attribute4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.Attribute5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.AllocationPlanDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.AllocationPlanMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.StartAreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.EndAreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.SyncSystemId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.Attribute4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.Attribute5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanMain>()
                .Property(e => e.AllocationPlanMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanMain>()
                .Property(e => e.StartWarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanMain>()
                .Property(e => e.EndWarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanMain>()
                .Property(e => e.AuditUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanMain>()
                .Property(e => e.SyncSystemId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanMain>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanMain>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanMain>()
                .Property(e => e.Attribute4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanMain>()
                .Property(e => e.Attribute5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_AllocationPlanMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDetail>()
                .Property(e => e.OutDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDetail>()
                .Property(e => e.OutCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDetail>()
                .Property(e => e.OutPlanDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDetail>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDetail>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDetail>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDetail>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDetail>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDetail>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDetail>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDetail>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMain>()
                .Property(e => e.UnloadingPlace)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMain>()
                .Property(e => e.ContainerCodeJH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMain>()
                .Property(e => e.OutCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMain>()
                .Property(e => e.OutPlanId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMain>()
                .Property(e => e.OutStockNum)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMain>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMain>()
                .Property(e => e.LocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMain>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMain>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTemp>()
                .Property(e => e.OutTempId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTemp>()
                .Property(e => e.OutCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTemp>()
                .Property(e => e.JHContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTemp>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTemp>()
                .Property(e => e.LocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTemp>()
                .Property(e => e.OutPlanId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTemp>()
                .Property(e => e.OutPlanDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTemp>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTemp>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTemp>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTemp>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTemp>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTemp>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTemp>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BHTemp>()
                .Property(e => e.StockpileId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.BusinessId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.BusinessCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.BusinessType)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.BusinessName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.BusinessDescription)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.Phone1)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.Phone2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.Web)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.Linkman1)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.Linkman2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.PYCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.SyncSystemId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_BusinessInfo>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CarInfo>()
                .Property(e => e.CarId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CarInfo>()
                .Property(e => e.CarCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CarInfo>()
                .Property(e => e.Driver)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CarInfo>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CarInfo>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CarInfo>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CarInfo>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CarInfo>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CarInfo>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CarInfo>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckDetail>()
                .Property(e => e.CheckDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckDetail>()
                .Property(e => e.CheckCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckDetail>()
                .Property(e => e.CheckPlanDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckDetail>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckDetail>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckDetail>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckDetail>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckDetail>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckDetail>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckDetail>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckDetail>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckMain>()
                .Property(e => e.CheckCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckMain>()
                .Property(e => e.CheckPlanMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckMain>()
                .Property(e => e.CheckStockNum)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckMain>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckMain>()
                .Property(e => e.LocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckMain>()
                .Property(e => e.OperatorId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckMain>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckMain>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanDetail>()
                .Property(e => e.CheckPlanDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanDetail>()
                .Property(e => e.CheckPlanMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanDetail>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanDetail>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanDetail>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanDetail>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanDetail>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanDetail>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanDetail>()
                .Property(e => e.SyncSystemDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanDetail>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanDetail>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanMain>()
                .Property(e => e.CheckPlanMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanMain>()
                .Property(e => e.AuditUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanMain>()
                .Property(e => e.SyncSystemId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanMain>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanMain>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_CheckPlanMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerInfo>()
                .Property(e => e.ContainerCodeId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerInfo>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerInfo>()
                .Property(e => e.ContainerTypeId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerInfo>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerInfo>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerInfo>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerInfo>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerInfo>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerInfo>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerInfo>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerType>()
                .Property(e => e.ContainerTypeId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerType>()
                .Property(e => e.ContainerTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerType>()
                .Property(e => e.ContainerTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerType>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerType>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerType>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerType>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerType>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerType>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerType>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ContainerType>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineDetail>()
                .Property(e => e.ExamineDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineDetail>()
                .Property(e => e.ExamineMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineDetail>()
                .Property(e => e.InOrderDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineDetail>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineDetail>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineMain>()
                .Property(e => e.ExamineMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineMain>()
                .Property(e => e.InOrderId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineMain>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineMain>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ExamineMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InDetail>()
                .Property(e => e.InDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InDetail>()
                .Property(e => e.InCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InDetail>()
                .Property(e => e.InPlanDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InDetail>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InDetail>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InDetail>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InDetail>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InDetail>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InDetail>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InDetail>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InDetail>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InMain>()
                .Property(e => e.InCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InMain>()
                .Property(e => e.InOrderNumber)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InMain>()
                .Property(e => e.InPlanId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InMain>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InMain>()
                .Property(e => e.LocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InMain>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InMain>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderDetail>()
                .Property(e => e.InOrderDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderDetail>()
                .Property(e => e.InOrderId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderDetail>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderDetail>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderDetail>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderDetail>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderDetail>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderDetail>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderDetail>()
                .Property(e => e.SyncSystemDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderDetail>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderDetail>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderMain>()
                .Property(e => e.InOrderId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderMain>()
                .Property(e => e.InOrderCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderMain>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderMain>()
                .Property(e => e.SyncSystemId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderMain>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderMain>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderTemp>()
                .Property(e => e.InOrderTempId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderTemp>()
                .Property(e => e.InOrderId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderTemp>()
                .Property(e => e.InOrderCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderTemp>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderTemp>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderTemp>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderTemp>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderTemp>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderTemp>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderTemp>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderTemp>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderTemp>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderTemp>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderTemp>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderTemp>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InOrderTemp>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanDetail>()
                .Property(e => e.InPlanDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanDetail>()
                .Property(e => e.InPlanId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanDetail>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanDetail>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanDetail>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanDetail>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanDetail>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanDetail>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanDetail>()
                .Property(e => e.SyncSystemDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanDetail>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanDetail>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanMain>()
                .Property(e => e.InPlanId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanMain>()
                .Property(e => e.DeliveryId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanMain>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanMain>()
                .Property(e => e.SyncSystemId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanMain>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanMain>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanTemp>()
                .Property(e => e.InPlanTempId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanTemp>()
                .Property(e => e.InPlanId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanTemp>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanTemp>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanTemp>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanTemp>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanTemp>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanTemp>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanTemp>()
                .Property(e => e.OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanTemp>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanTemp>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanTemp>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanTemp>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanTemp>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanTemp>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InPlanTemp>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InTemp>()
                .Property(e => e.InTempId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InTemp>()
                .Property(e => e.InPlanId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InTemp>()
                .Property(e => e.InPlanDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InTemp>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InTemp>()
                .Property(e => e.LocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InTemp>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InTemp>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InTemp>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InTemp>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InTemp>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InTemp>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_InTemp>()
                .Property(e => e.ModifyUserName)
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

            modelBuilder.Entity<WMS_LaneStatus>()
                .Property(e => e.LaneId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LaneStatus>()
                .Property(e => e.LaneCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LaneStatus>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LaneStatus>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LaneStatus>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LaneStatus>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LaneStatus>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LaneStatus>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LaneStatus>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Location>()
                .Property(e => e.LocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Location>()
                .Property(e => e.StorageAreaId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Location>()
                .Property(e => e.LocationCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Location>()
                .Property(e => e.LocationTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Location>()
                .Property(e => e.LaneId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Location>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Location>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Location>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Location>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Location>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Location>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Location>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationContainerMap>()
                .Property(e => e.MapId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationContainerMap>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationContainerMap>()
                .Property(e => e.LocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationContainerMap>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationContainerMap>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationContainerMap>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationContainerMap>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationContainerMap>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationContainerMap>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationContainerMap>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationFunction>()
                .Property(e => e.LocationFunctionCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationFunction>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationFunction>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationFunction>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationFunction>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationFunction>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationFunction>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationFunction>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_LocationFunction>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Materials>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Materials>()
                .Property(e => e.MaterialsSortsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Materials>()
                .Property(e => e.MaterialsCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Materials>()
                .Property(e => e.MaterialsCNName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Materials>()
                .Property(e => e.MaterialsENName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Materials>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Materials>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Materials>()
                .Property(e => e.PYCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Materials>()
                .Property(e => e.SyncSystemId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Materials>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Materials>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Materials>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Materials>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Materials>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Materials>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Materials>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsBusinessMap>()
                .Property(e => e.MapId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsBusinessMap>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsBusinessMap>()
                .Property(e => e.BusinessId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsBusinessMap>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsBusinessMap>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsBusinessMap>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsBusinessMap>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsBusinessMap>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsBusinessMap>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsBusinessMap>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsBusinessMap>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_MaterialsLocationMap>()
                .Property(e => e.MapId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsLocationMap>()
                .Property(e => e.LocationCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsLocationMap>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsLocationMap>()
                .Property(e => e.MaterialsSortsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsLocationMap>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsLocationMap>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsLocationMap>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsLocationMap>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsLocationMap>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsLocationMap>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsLocationMap>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsSorts>()
                .Property(e => e.MaterialsSortsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsSorts>()
                .Property(e => e.SortsName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsSorts>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsSorts>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsSorts>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsSorts>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsSorts>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsSorts>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsSorts>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialsSorts>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialStorageArea>()
                .Property(e => e.MaterialStorageAreaId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialStorageArea>()
                .Property(e => e.MaterialsSortsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialStorageArea>()
                .Property(e => e.WarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialStorageArea>()
                .Property(e => e.StorageAreaId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialStorageArea>()
                .Property(e => e.LaneId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialStorageArea>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialStorageArea>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialStorageArea>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialStorageArea>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialStorageArea>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialStorageArea>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_MaterialStorageArea>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.OutDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.OutCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.OutPlanDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.MaterialsCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutDetail>()
                .Property(e => e.BusinessCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutMain>()
                .Property(e => e.UnloadingPlace)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutMain>()
                .Property(e => e.ContainerCodeJH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutMain>()
                .Property(e => e.OutCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutMain>()
                .Property(e => e.OutPlanId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutMain>()
                .Property(e => e.OutStockNum)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutMain>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutMain>()
                .Property(e => e.LocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutMain>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutMain>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.OutOrderDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.OutOrderId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.CardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.SyncSystemDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderMain>()
                .Property(e => e.OutOrderId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderMain>()
                .Property(e => e.DeliveryId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderMain>()
                .Property(e => e.ReceiveCompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderMain>()
                .Property(e => e.OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderMain>()
                .Property(e => e.UnloadId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderMain>()
                .Property(e => e.SyncSystemId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderMain>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderMain>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutOrderMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.OutPlanDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.OutPlanId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.UnloadId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.ReceiveCompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.CardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.SyncSystemDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanMain>()
                .Property(e => e.OutPlanId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanMain>()
                .Property(e => e.OutOrderId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanMain>()
                .Property(e => e.DeliveryId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanMain>()
                .Property(e => e.WarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanMain>()
                .Property(e => e.SyncSystemId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanMain>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanMain>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.OutPlanTempId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.UnloadId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.ReceiveCompanyId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.CardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.OutSerialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutPlanTemp>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTask>()
                .Property(e => e.PlanQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_OutTask>()
                .Property(e => e.OutQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_OutTask>()
                .Property(e => e.LocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTask>()
                .Property(e => e.ZHQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_OutTask>()
                .Property(e => e.BHQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_OutTask>()
                .Property(e => e.XNSL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_OutTask>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTask>()
                .Property(e => e.PRODUCTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTaskBHDetail>()
                .Property(e => e.OutQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_OutTaskJHDetail>()
                .Property(e => e.OutQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_OutTaskZHDetail>()
                .Property(e => e.OutQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<WMS_OutTemp>()
                .Property(e => e.OutTempId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTemp>()
                .Property(e => e.OutCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTemp>()
                .Property(e => e.JHContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTemp>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTemp>()
                .Property(e => e.LocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTemp>()
                .Property(e => e.OutPlanId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTemp>()
                .Property(e => e.OutPlanDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTemp>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTemp>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTemp>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTemp>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTemp>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTemp>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTemp>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_OutTemp>()
                .Property(e => e.StockpileId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.PackModel)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.InContainerTypeId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.LengthUnit)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.WeightUnit)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.StockpileUnit)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.PackBarCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.OutContainerTypeId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.StockMethod)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PackSpec>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrinthHstoryTable>()
                .Property(e => e.PrintId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrinthHstoryTable>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrinthHstoryTable>()
                .Property(e => e.MaterialsCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrinthHstoryTable>()
                .Property(e => e.MaterialsName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrinthHstoryTable>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrinthHstoryTable>()
                .Property(e => e.PackModel)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrinthHstoryTable>()
                .Property(e => e.MaterialsAttribute)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrinthHstoryTable>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            //modelBuilder.Entity<WMS_PrinthHstoryTable>()
            //    .Property(e => e.Quantity)
            //    .HasPrecision(18, 0);

            modelBuilder.Entity<WMS_PrinthHstoryTable>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrinthHstoryTable>()
                .Property(e => e.MatureDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrinthHstoryTable>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrinthHstoryTable>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrinthHstoryTable>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrinthHstoryTable>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrinthHstoryTable>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrinthHstoryTable>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrinthHstoryTable>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.PrintId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.MaterialsCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.MaterialsName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.FigureNumber)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.PackModel)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.MaterialsAttribute)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            //modelBuilder.Entity<WMS_PrintTable>()
            //    .Property(e => e.Quantity)
            //    .HasPrecision(18, 0);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.ProductCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.MatureDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.Flag)
                .IsFixedLength();

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_PrintTable>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QualityCheck>()
                .Property(e => e.QualityCheckID)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QualityCheck>()
                .Property(e => e.QualityCheckNum)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QualityCheck>()
                .Property(e => e.InPlanId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QualityCheck>()
                .Property(e => e.InPlanDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QualityCheck>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QualityCheck>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QualityCheck>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QualityCheck>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QualityCheck>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QualityCheck>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QualityCheck>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QualityCheck>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QualityCheck>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QualityCheck>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_QualityCheck>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyDetail>()
                .Property(e => e.RebuildApplyDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyDetail>()
                .Property(e => e.RebuildApplyMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyDetail>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyDetail>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyDetail>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyDetail>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyDetail>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyDetail>()
                .Property(e => e.SyncSystemDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyDetail>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyDetail>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyDetail>()
                .Property(e => e.Attribute4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyDetail>()
                .Property(e => e.Attribute5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyMain>()
                .Property(e => e.RebuildApplyMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyMain>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyMain>()
                .Property(e => e.AuditUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyMain>()
                .Property(e => e.SyncSystemId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyMain>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyMain>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyMain>()
                .Property(e => e.Attribute4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyMain>()
                .Property(e => e.Attribute5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildApplyMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.RebuildCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.RebuildPlanMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.RebuildPlanDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.RebuildStockNum)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.StartWarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.StartAreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.StartLocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.EndWarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.EndAreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.EndLocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.SyncSystemDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.Attribute4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.Attribute5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.RebuildPlanDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.RebuildPlanMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.SyncSystemDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.Attribute4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.Attribute5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanMain>()
                .Property(e => e.RebuildPlanMainId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanMain>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanMain>()
                .Property(e => e.AuditUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanMain>()
                .Property(e => e.SyncSystemId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanMain>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanMain>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanMain>()
                .Property(e => e.Attribute4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanMain>()
                .Property(e => e.Attribute5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_RebuildPlanMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Stockpile>()
                .Property(e => e.StockpileId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Stockpile>()
                .Property(e => e.LocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Stockpile>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Stockpile>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Stockpile>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Stockpile>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Stockpile>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Stockpile>()
                .Property(e => e.ProductId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Stockpile>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Stockpile>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Stockpile>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Stockpile>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Stockpile>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Stockpile>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Stockpile>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Stockpile>()
                .Property(e => e.Attribute4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Stockpile>()
                .Property(e => e.Attribute5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_StorageArea>()
                .Property(e => e.StorageAreaId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_StorageArea>()
                .Property(e => e.WarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_StorageArea>()
                .Property(e => e.LocationFunctionCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_StorageArea>()
                .Property(e => e.AreaName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_StorageArea>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_StorageArea>()
                .Property(e => e.StorageAreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_StorageArea>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_StorageArea>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_StorageArea>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_StorageArea>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_StorageArea>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_StorageArea>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_StorageArea>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_StorageAreaMaterialMap>()
                .Property(e => e.StorageAreaId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_StorageAreaMaterialMap>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_StorageAreaMaterialMap>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_StorageAreaMaterialMap>()
                .Property(e => e.MaterialsCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SupplierMaterialsStorageArea>()
                .Property(e => e.SupplierMaterialsStorageAreaId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SupplierMaterialsStorageArea>()
                .Property(e => e.BusinessId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SupplierMaterialsStorageArea>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SupplierMaterialsStorageArea>()
                .Property(e => e.WarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SupplierMaterialsStorageArea>()
                .Property(e => e.StorageAreaId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SupplierMaterialsStorageArea>()
                .Property(e => e.LaneId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SupplierMaterialsStorageArea>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SupplierMaterialsStorageArea>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SupplierMaterialsStorageArea>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SupplierMaterialsStorageArea>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SupplierMaterialsStorageArea>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SupplierMaterialsStorageArea>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_SupplierMaterialsStorageArea>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Tasks>()
                .Property(e => e.TaskCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Tasks>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Tasks>()
                .Property(e => e.GlideCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Tasks>()
                .Property(e => e.OperaterId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Tasks>()
                .Property(e => e.StartLocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Tasks>()
                .Property(e => e.EndLocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Tasks>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Tasks>()
                .Property(e => e.BillsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Tasks>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Tasks>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Tasks>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Tasks>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Tasks>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Tasks>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Tasks>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksMainTemp>()
                .Property(e => e.TaskTempId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksMainTemp>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksMainTemp>()
                .Property(e => e.BillsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksMainTemp>()
                .Property(e => e.OperaterId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksMainTemp>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksMainTemp>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksMainTemp>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksMainTemp>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksMainTemp>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksMainTemp>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksMainTemp>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksTemp>()
                .Property(e => e.TaskTempCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksTemp>()
                .Property(e => e.TaskTempId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksTemp>()
                .Property(e => e.GlideCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksTemp>()
                .Property(e => e.StartLocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksTemp>()
                .Property(e => e.EndLocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksTemp>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksTemp>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksTemp>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksTemp>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksTemp>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksTemp>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksTemp>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksTemp>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksType>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksType>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksType>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksType>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksType>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksType>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksType>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksType>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TasksType>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TaskTypePostMap>()
                .Property(e => e.MapId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TaskTypePostMap>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TaskTypePostMap>()
                .Property(e => e.PostId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TaskTypePostMap>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TaskTypePostMap>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TaskTypePostMap>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TaskTypePostMap>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TaskTypePostMap>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TaskTypePostMap>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TaskTypePostMap>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.TransitStockNum)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.StartWarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.StartAreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.StartLocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.EndWarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.EndAreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.EndLocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.Attribute4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.Attribute5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_Transit>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.TransitStockNum)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.StartWarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.StartAreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.StartLocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.EndWarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.EndAreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.EndLocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.Attribute4)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.Attribute5)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_TransitMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UnloadingPlace>()
                .Property(e => e.UnloadId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UnloadingPlace>()
                .Property(e => e.RoadJunctionCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UnloadingPlace>()
                .Property(e => e.RoadJunctionName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UnloadingPlace>()
                .Property(e => e.BusinessId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UnloadingPlace>()
                .Property(e => e.ReceivePlace)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UnloadingPlace>()
                .Property(e => e.WorkshopCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UnloadingPlace>()
                .Property(e => e.WorkshopName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UnloadingPlace>()
                .Property(e => e.FactoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UnloadingPlace>()
                .Property(e => e.FactoryName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UnloadingPlace>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UnloadingPlace>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UnloadingPlace>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UnloadingPlace>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UnloadingPlace>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UnloadingPlace>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_UnloadingPlace>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDetail>()
                .Property(e => e.OutDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDetail>()
                .Property(e => e.OutCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDetail>()
                .Property(e => e.OutPlanDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDetail>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDetail>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDetail>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDetail>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDetail>()
                .Property(e => e.SupplierBatch)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDetail>()
                .Property(e => e.ProductionId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDetail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDetail>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDetail>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDetail>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDetail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDetail>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHDetail>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMain>()
                .Property(e => e.UnloadingPlace)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMain>()
                .Property(e => e.ContainerCodeJH)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMain>()
                .Property(e => e.OutCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMain>()
                .Property(e => e.OutPlanId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMain>()
                .Property(e => e.OutStockNum)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMain>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMain>()
                .Property(e => e.LocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMain>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMain>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMain>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMain>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMain>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMain>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHMain>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTemp>()
                .Property(e => e.ZHTempId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTemp>()
                .Property(e => e.OutCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTemp>()
                .Property(e => e.JHContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTemp>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTemp>()
                .Property(e => e.LocationId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTemp>()
                .Property(e => e.OutPlanId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTemp>()
                .Property(e => e.OutPlanDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTemp>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTemp>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTemp>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTemp>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTemp>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTemp>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTemp>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<WMS_ZHTemp>()
                .Property(e => e.StockpileId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.AccountsMethod)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.LinkMan)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.LeadingOfficialId)
                .IsUnicode(false);

            modelBuilder.Entity<Base_Supplies>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Table_location>()
                .Property(e => e.LocationId)
                .IsUnicode(false);

            modelBuilder.Entity<Table_location>()
                .Property(e => e.StorageAreaId)
                .IsUnicode(false);

            modelBuilder.Entity<Table_location>()
                .Property(e => e.LocationCode)
                .IsUnicode(false);

            modelBuilder.Entity<Table_location>()
                .Property(e => e.LocationTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<Table_location>()
                .Property(e => e.LaneId)
                .IsUnicode(false);

            modelBuilder.Entity<Table_location>()
                .Property(e => e.Attribute2)
                .IsUnicode(false);

            modelBuilder.Entity<Table_location>()
                .Property(e => e.Attribute3)
                .IsUnicode(false);

            modelBuilder.Entity<Table_location>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Table_location>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Table_location>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Table_location>()
                .Property(e => e.ModifyUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Table_location>()
                .Property(e => e.ModifyUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_AreaCode>()
                .Property(e => e.MaterialsCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_AreaCode>()
                .Property(e => e.BusinessCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_AreaCode>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_AreaCode>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<View_AreaCode>()
                .Property(e => e.BusinessId)
                .IsUnicode(false);

            modelBuilder.Entity<View_AreaCode>()
                .Property(e => e.LocationCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_InDettail>()
                .Property(e => e.InDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<View_InDettail>()
                .Property(e => e.InCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_InDettail>()
                .Property(e => e.DeliveryId)
                .IsUnicode(false);

            modelBuilder.Entity<View_InDettail>()
                .Property(e => e.MaterialsCNName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InDettail>()
                .Property(e => e.MaterialsCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_InDettail>()
                .Property(e => e.PackModel)
                .IsUnicode(false);

            modelBuilder.Entity<View_InDettail>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_InDettail>()
                .Property(e => e.LocationCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_InDettail>()
                .Property(e => e.InOrderNumber)
                .IsUnicode(false);

            modelBuilder.Entity<View_InDettail>()
                .Property(e => e.BusinessName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InDettail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<View_InDettail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Location>()
                .Property(e => e.LocationId)
                .IsUnicode(false);

            modelBuilder.Entity<View_Location>()
                .Property(e => e.LocationCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Location>()
                .Property(e => e.StorageAreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Location>()
                .Property(e => e.LocationTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Location>()
                .Property(e => e.LaneCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Location>()
                .Property(e => e.WarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Location>()
                .Property(e => e.AreaName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Location>()
                .Property(e => e.LocationFunctionCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Location>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Location>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Location>()
                .Property(e => e.MaterialsCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Location>()
                .Property(e => e.MaterialsCNName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Location>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<View_LocationFunctionCode>()
                .Property(e => e.LocationId)
                .IsUnicode(false);

            modelBuilder.Entity<View_LocationFunctionCode>()
                .Property(e => e.LocationFunctionCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutDettail>()
                .Property(e => e.OutDetailId)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutDettail>()
                .Property(e => e.OutPlanId)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutDettail>()
                .Property(e => e.DeliveryId)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutDettail>()
                .Property(e => e.OutCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutDettail>()
                .Property(e => e.UnloadingPlace)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutDettail>()
                .Property(e => e.MaterialsCNName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutDettail>()
                .Property(e => e.MaterialsCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutDettail>()
                .Property(e => e.PackModel)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutDettail>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutDettail>()
                .Property(e => e.LocationCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutDettail>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutDettail>()
                .Property(e => e.BusinessName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutDettail>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutDettail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutTaskJHDetai>()
                .Property(e => e.DeliveryId)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutTaskJHDetai>()
                .Property(e => e.OutQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OutTaskJHDetai>()
                .Property(e => e.MaterialsCNName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutTaskJHDetai>()
                .Property(e => e.MaterialsCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutTaskJHDetai>()
                .Property(e => e.PackModel)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutTaskJHDetai>()
                .Property(e => e.LocationCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutTaskJHDetai>()
                .Property(e => e.BusinessName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutTaskZHDetail>()
                .Property(e => e.DeliveryId)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutTaskZHDetail>()
                .Property(e => e.OutQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<View_OutTaskZHDetail>()
                .Property(e => e.MaterialsCNName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutTaskZHDetail>()
                .Property(e => e.MaterialsCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutTaskZHDetail>()
                .Property(e => e.PackModel)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutTaskZHDetail>()
                .Property(e => e.LocationCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutTaskZHDetail>()
                .Property(e => e.BusinessName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.PackModel)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.SupplierId)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.MaterialsId)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.ProductBatch)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.MaterialsCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.MaterialsCNName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.BusinessName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.BusinessCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.StockpileId)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.LocationId)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.ContainerCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.PackSpecId)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.ProductId)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.CreateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.LocationCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Transit>()
                .Property(e => e.AreaCode)
                .IsUnicode(false);
        }
    }
}
