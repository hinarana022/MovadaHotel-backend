using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Domain.Entities;
using Domain.SP;

namespace Infrastructure.Data
{
    public partial class dbHMSContext : DbContext
    {
        public dbHMSContext()
        {
        }

        public dbHMSContext(DbContextOptions<dbHMSContext> options)
            : base(options)
        {
        }

     
        public virtual DbSet<proc_LoadRoomTariff> proc_LoadRoomTariff { get; set; } = null!;
        public virtual DbSet<Proc_LoadReservationSeason> Proc_LoadReservationSeason { get; set; } = null!;
        public virtual DbSet<proc_customSupplierbalance> proc_customSupplierbalance { get; set; } = null!;
        public virtual DbSet<AvailabeGrnqty> AvailabeGrnqties { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<RptviewGrnDetail> RptviewGrnDetails { get; set; } = null!;
        public virtual DbSet<RptviewLogHistoryDataView> RptviewLogHistoryDataViews { get; set; } = null!;
        public virtual DbSet<RptviewSaleDeliveryOrderDetail> RptviewSaleDeliveryOrderDetails { get; set; } = null!;
        public virtual DbSet<SavedGrnrecord> SavedGrnrecords { get; set; } = null!;
        public virtual DbSet<TableSampleReport> TableSampleReports { get; set; } = null!;
        public virtual DbSet<TblAccountGroup> TblAccountGroups { get; set; } = null!;
        public virtual DbSet<TblAccountLedger> TblAccountLedgers { get; set; } = null!;
        public virtual DbSet<TblAccountLedgerGaurantor> TblAccountLedgerGaurantors { get; set; } = null!;
        public virtual DbSet<TblAccountLedgerImage> TblAccountLedgerImages { get; set; } = null!;
        public virtual DbSet<TblActualMaterialReceiptDetail> TblActualMaterialReceiptDetails { get; set; } = null!;
        public virtual DbSet<TblActualMaterialReceiptMaster> TblActualMaterialReceiptMasters { get; set; } = null!;
        public virtual DbSet<TblAdjustmentDetail> TblAdjustmentDetails { get; set; } = null!;
        public virtual DbSet<TblAdjustmentMaster> TblAdjustmentMasters { get; set; } = null!;
        public virtual DbSet<TblAdmin> TblAdmins { get; set; } = null!;
        public virtual DbSet<TblAllergy> TblAllergies { get; set; } = null!;
        public virtual DbSet<TblAllowanceEnhancementDepartmentDetail> TblAllowanceEnhancementDepartmentDetails { get; set; } = null!;
        public virtual DbSet<TblAllowanceEnhancementEmployeeDetail> TblAllowanceEnhancementEmployeeDetails { get; set; } = null!;
        public virtual DbSet<TblAllowanceEnhancementMaster> TblAllowanceEnhancementMasters { get; set; } = null!;
        public virtual DbSet<TblAmenty> TblAmenties { get; set; } = null!;
        public virtual DbSet<TblApplication> TblApplications { get; set; } = null!;
        public virtual DbSet<TblApplicationButtonSetting> TblApplicationButtonSettings { get; set; } = null!;
        public virtual DbSet<TblApplicationDetail> TblApplicationDetails { get; set; } = null!;
        public virtual DbSet<TblApplicationFormSettingSqltable> TblApplicationFormSettingSqltables { get; set; } = null!;
        public virtual DbSet<TblApplicationFormsSettingDetail> TblApplicationFormsSettingDetails { get; set; } = null!;
        public virtual DbSet<TblApplicationFormsSettingMaster> TblApplicationFormsSettingMasters { get; set; } = null!;
        public virtual DbSet<TblApplicationMdibuttonSetting> TblApplicationMdibuttonSettings { get; set; } = null!;
        public virtual DbSet<TblApplicationRegistersColumn> TblApplicationRegistersColumns { get; set; } = null!;
        public virtual DbSet<TblApplyPromotionsDetail> TblApplyPromotionsDetails { get; set; } = null!;
        public virtual DbSet<TblApplyPromotionsForBrand> TblApplyPromotionsForBrands { get; set; } = null!;
        public virtual DbSet<TblApplyPromotionsForProductGroup> TblApplyPromotionsForProductGroups { get; set; } = null!;
        public virtual DbSet<TblApplyPromotionsMaster> TblApplyPromotionsMasters { get; set; } = null!;
        public virtual DbSet<TblApplyPromotionsWithHappyHour> TblApplyPromotionsWithHappyHours { get; set; } = null!;
        public virtual DbSet<TblArea> TblAreas { get; set; } = null!;
        public virtual DbSet<TblAssignPrevilidgeDetail> TblAssignPrevilidgeDetails { get; set; } = null!;
        public virtual DbSet<TblAssignPrevilidgeMaster> TblAssignPrevilidgeMasters { get; set; } = null!;
        public virtual DbSet<TblAssignPrevilidgesUserDetail> TblAssignPrevilidgesUserDetails { get; set; } = null!;
        public virtual DbSet<TblAssignPrevilidgesUserMaster> TblAssignPrevilidgesUserMasters { get; set; } = null!;
        public virtual DbSet<TblAttaBooking> TblAttaBookings { get; set; } = null!;
        public virtual DbSet<TblAttaBookingRateSheet> TblAttaBookingRateSheets { get; set; } = null!;
        public virtual DbSet<TblAttendanceProductionType> TblAttendanceProductionTypes { get; set; } = null!;
        public virtual DbSet<TblAttendanceVoucher> TblAttendanceVouchers { get; set; } = null!;
        public virtual DbSet<TblAttendanceVoucherDetail> TblAttendanceVoucherDetails { get; set; } = null!;
        public virtual DbSet<TblAuhtorityLetterDeliveryAttachment> TblAuhtorityLetterDeliveryAttachments { get; set; } = null!;
        public virtual DbSet<TblBackOrderDetail> TblBackOrderDetails { get; set; } = null!;
        public virtual DbSet<TblBackOrderMaster> TblBackOrderMasters { get; set; } = null!;
        public virtual DbSet<TblBackupPath> TblBackupPaths { get; set; } = null!;
        public virtual DbSet<TblBank> TblBanks { get; set; } = null!;
        public virtual DbSet<TblBankAccount> TblBankAccounts { get; set; } = null!;
        public virtual DbSet<TblBankDetail> TblBankDetails { get; set; } = null!;
        public virtual DbSet<TblBarcodeSetting> TblBarcodeSettings { get; set; } = null!;
        public virtual DbSet<TblBarcodeSettingMaster> TblBarcodeSettingMasters { get; set; } = null!;
        public virtual DbSet<TblBatch> TblBatches { get; set; } = null!;
        public virtual DbSet<TblBikeDocumentDelivery> TblBikeDocumentDeliveries { get; set; } = null!;
        public virtual DbSet<TblBikeDocumentReceiving> TblBikeDocumentReceivings { get; set; } = null!;
        public virtual DbSet<TblBikeInfo> TblBikeInfos { get; set; } = null!;
        public virtual DbSet<TblBikeRegistrationNo> TblBikeRegistrationNos { get; set; } = null!;
        public virtual DbSet<TblBikeStatus> TblBikeStatuses { get; set; } = null!;
        public virtual DbSet<TblBlock> TblBlocks { get; set; } = null!;
        public virtual DbSet<TblBonusQuantity> TblBonusQuantities { get; set; } = null!;
        public virtual DbSet<TblBookingCount> TblBookingCounts { get; set; } = null!;
        public virtual DbSet<TblBrand> TblBrands { get; set; } = null!;
        public virtual DbSet<TblBranding> TblBrandings { get; set; } = null!;
        public virtual DbSet<TblBuisnessSource> TblBuisnessSources { get; set; } = null!;
        public virtual DbSet<TblCanceledCheque> TblCanceledCheques { get; set; } = null!;
        public virtual DbSet<TblCashMaster> TblCashMasters { get; set; } = null!;
        public virtual DbSet<TblCashOpening> TblCashOpenings { get; set; } = null!;
        public virtual DbSet<TblCashReceived> TblCashReceiveds { get; set; } = null!;
        public virtual DbSet<TblCaste> TblCastes { get; set; } = null!;
        public virtual DbSet<TblCategoriesHelp> TblCategoriesHelps { get; set; } = null!;
        public virtual DbSet<TblCategoryOpdScreenMapping> TblCategoryOpdScreenMappings { get; set; } = null!;
        public virtual DbSet<TblCategoryOpdmappingValue> TblCategoryOpdmappingValues { get; set; } = null!;
        public virtual DbSet<TblCheck> TblChecks { get; set; } = null!;
        public virtual DbSet<TblChequeBook> TblChequeBooks { get; set; } = null!;
        public virtual DbSet<TblChequeDetail> TblChequeDetails { get; set; } = null!;
        public virtual DbSet<TblChequesManagment> TblChequesManagments { get; set; } = null!;
        public virtual DbSet<TblCity> TblCities { get; set; } = null!;
        public virtual DbSet<TblColor> TblColors { get; set; } = null!;
        public virtual DbSet<TblComissionMapper> TblComissionMappers { get; set; } = null!;
        public virtual DbSet<TblCompany> TblCompanies { get; set; } = null!;
        public virtual DbSet<TblCompanyImage> TblCompanyImages { get; set; } = null!;
        public virtual DbSet<TblCompanyIncentiveDetail> TblCompanyIncentiveDetails { get; set; } = null!;
        public virtual DbSet<TblCompanyIncentiveMaster> TblCompanyIncentiveMasters { get; set; } = null!;
        public virtual DbSet<TblCompanyInfo> TblCompanyInfos { get; set; } = null!;
        public virtual DbSet<TblCompanyPath> TblCompanyPaths { get; set; } = null!;
        public virtual DbSet<TblConfiguration> TblConfigurations { get; set; } = null!;
        public virtual DbSet<TblContactDatum> TblContactData { get; set; } = null!;
        public virtual DbSet<TblContactGroup> TblContactGroups { get; set; } = null!;
        public virtual DbSet<TblContactList> TblContactLists { get; set; } = null!;
        public virtual DbSet<TblCounter> TblCounters { get; set; } = null!;
        public virtual DbSet<TblCurrency> TblCurrencies { get; set; } = null!;
        public virtual DbSet<TblCurrencyNote> TblCurrencyNotes { get; set; } = null!;
        public virtual DbSet<TblCustomField> TblCustomFields { get; set; } = null!;
        public virtual DbSet<TblCustomFieldsSearchMapping> TblCustomFieldsSearchMappings { get; set; } = null!;
        public virtual DbSet<TblCustomFieldsSearchingDetail> TblCustomFieldsSearchingDetails { get; set; } = null!;
        public virtual DbSet<TblCustomFieldsSearchingMaster> TblCustomFieldsSearchingMasters { get; set; } = null!;
        public virtual DbSet<TblCustomReport> TblCustomReports { get; set; } = null!;
        public virtual DbSet<TblCustomSaleReturnDetail> TblCustomSaleReturnDetails { get; set; } = null!;
        public virtual DbSet<TblCustomSaleReturnMaster> TblCustomSaleReturnMasters { get; set; } = null!;
        public virtual DbSet<TblCustomerAttendance> TblCustomerAttendances { get; set; } = null!;
        public virtual DbSet<TblCustomerBalance> TblCustomerBalances { get; set; } = null!;
        public virtual DbSet<TblCustomerDiscountPercentage> TblCustomerDiscountPercentages { get; set; } = null!;
        public virtual DbSet<TblCustomerGroup> TblCustomerGroups { get; set; } = null!;
        public virtual DbSet<TblCustomerPrevDiscount> TblCustomerPrevDiscounts { get; set; } = null!;
        public virtual DbSet<TblCustomerRegistrationRequest> TblCustomerRegistrationRequests { get; set; } = null!;
        public virtual DbSet<TblCustomerSubAccount> TblCustomerSubAccounts { get; set; } = null!;
        public virtual DbSet<TblDealsDetail> TblDealsDetails { get; set; } = null!;
        public virtual DbSet<TblDealsMaster> TblDealsMasters { get; set; } = null!;
        public virtual DbSet<TblDefault> TblDefaults { get; set; } = null!;
        public virtual DbSet<TblDefault1> TblDefaults1 { get; set; } = null!;
        public virtual DbSet<TblDefaultWpfImage> TblDefaultWpfImages { get; set; } = null!;
        public virtual DbSet<TblDepartment> TblDepartments { get; set; } = null!;
        public virtual DbSet<TblDepartmentLedgerMapping> TblDepartmentLedgerMappings { get; set; } = null!;
        public virtual DbSet<TblDepartmentPrinterMapping> TblDepartmentPrinterMappings { get; set; } = null!;
        public virtual DbSet<TblDesignation> TblDesignations { get; set; } = null!;
        public virtual DbSet<TblDesignationMappingWithPayScaleDetail> TblDesignationMappingWithPayScaleDetails { get; set; } = null!;
        public virtual DbSet<TblDesignationMappingWithPayScaleMaster> TblDesignationMappingWithPayScaleMasters { get; set; } = null!;
        public virtual DbSet<TblDesignationMappingWithRoleDetail> TblDesignationMappingWithRoleDetails { get; set; } = null!;
        public virtual DbSet<TblDesignationMappingWithRoleMaster> TblDesignationMappingWithRoleMasters { get; set; } = null!;
        public virtual DbSet<TblDishCategory> TblDishCategories { get; set; } = null!;
        public virtual DbSet<TblDishesDetail> TblDishesDetails { get; set; } = null!;
        public virtual DbSet<TblDishesMaster> TblDishesMasters { get; set; } = null!;
        public virtual DbSet<TblDocter> TblDocters { get; set; } = null!;
        public virtual DbSet<TblDosage> TblDosages { get; set; } = null!;
        public virtual DbSet<TblDraftBulkProduct> TblDraftBulkProducts { get; set; } = null!;
        public virtual DbSet<TblDutyShift> TblDutyShifts { get; set; } = null!;
        public virtual DbSet<TblDynamicReportDetail> TblDynamicReportDetails { get; set; } = null!;
        public virtual DbSet<TblDynamicReportMaster> TblDynamicReportMasters { get; set; } = null!;
        public virtual DbSet<TblEattachmentsDetail> TblEattachmentsDetails { get; set; } = null!;
        public virtual DbSet<TblEattachmentsMaster> TblEattachmentsMasters { get; set; } = null!;
        public virtual DbSet<TblEducationalLevel> TblEducationalLevels { get; set; } = null!;
        public virtual DbSet<TblEducationalLevelStatus> TblEducationalLevelStatuses { get; set; } = null!;
        public virtual DbSet<TblEmailCompose> TblEmailComposes { get; set; } = null!;
        public virtual DbSet<TblEmailComposeAttachment> TblEmailComposeAttachments { get; set; } = null!;
        public virtual DbSet<TblEmailpending> TblEmailpendings { get; set; } = null!;
        public virtual DbSet<TblEmpImage> TblEmpImages { get; set; } = null!;
        public virtual DbSet<TblEmpMiscDetail> TblEmpMiscDetails { get; set; } = null!;
        public virtual DbSet<TblEmpMiscDetailsType> TblEmpMiscDetailsTypes { get; set; } = null!;
        public virtual DbSet<TblEmpRelation> TblEmpRelations { get; set; } = null!;
        public virtual DbSet<TblEmployee> TblEmployees { get; set; } = null!;
        public virtual DbSet<TblEmployeeAttendance> TblEmployeeAttendances { get; set; } = null!;
        public virtual DbSet<TblEmployeeCategory> TblEmployeeCategories { get; set; } = null!;
        public virtual DbSet<TblEmployeeCommisionDetail> TblEmployeeCommisionDetails { get; set; } = null!;
        public virtual DbSet<TblEmployeeCommisionMaster> TblEmployeeCommisionMasters { get; set; } = null!;
        public virtual DbSet<TblEmployeeGatepass> TblEmployeeGatepasses { get; set; } = null!;
        public virtual DbSet<TblEpurchaseOrderDetail> TblEpurchaseOrderDetails { get; set; } = null!;
        public virtual DbSet<TblEpurchaseOrderMaster> TblEpurchaseOrderMasters { get; set; } = null!;
        public virtual DbSet<TblEvaluationType> TblEvaluationTypes { get; set; } = null!;
        public virtual DbSet<TblExchangeRate> TblExchangeRates { get; set; } = null!;
        public virtual DbSet<TblExtraBarcode> TblExtraBarcodes { get; set; } = null!;
        public virtual DbSet<TblFacility> TblFacilities { get; set; } = null!;
        public virtual DbSet<TblFacilityMappingWithHead> TblFacilityMappingWithHeads { get; set; } = null!;
        public virtual DbSet<TblFbrintegration> TblFbrintegrations { get; set; } = null!;
        public virtual DbSet<TblFinancialYear> TblFinancialYears { get; set; } = null!;
        public virtual DbSet<TblFinger> TblFingers { get; set; } = null!;
        public virtual DbSet<TblFloor> TblFloors { get; set; } = null!;
        public virtual DbSet<TblForm> TblForms { get; set; } = null!;
        public virtual DbSet<TblFormForPrevilidge> TblFormForPrevilidges { get; set; } = null!;
        public virtual DbSet<TblFormInsideButtonRight> TblFormInsideButtonRights { get; set; } = null!;
        public virtual DbSet<TblGatePass> TblGatePasses { get; set; } = null!;
        public virtual DbSet<TblGeneralPolicy> TblGeneralPolicies { get; set; } = null!;
        public virtual DbSet<TblGeneralPrescriptionRadioOption> TblGeneralPrescriptionRadioOptions { get; set; } = null!;
        public virtual DbSet<TblGeneralSetting> TblGeneralSettings { get; set; } = null!;
        public virtual DbSet<TblGodown> TblGodowns { get; set; } = null!;
        public virtual DbSet<TblGodownLocationMappingDetail> TblGodownLocationMappingDetails { get; set; } = null!;
        public virtual DbSet<TblGodownLocationMappingMaster> TblGodownLocationMappingMasters { get; set; } = null!;
        public virtual DbSet<TblGodownPackingLog> TblGodownPackingLogs { get; set; } = null!;
        public virtual DbSet<TblGodownSetting> TblGodownSettings { get; set; } = null!;
        public virtual DbSet<TblGodownStockDetail> TblGodownStockDetails { get; set; } = null!;
        public virtual DbSet<TblGodownStockManage> TblGodownStockManages { get; set; } = null!;
        public virtual DbSet<TblGodownStockManageLog> TblGodownStockManageLogs { get; set; } = null!;
        public virtual DbSet<TblGoodsReceivedNoteAcLedger> TblGoodsReceivedNoteAcLedgers { get; set; } = null!;
        public virtual DbSet<TblGoodsReceivedNoteDetail> TblGoodsReceivedNoteDetails { get; set; } = null!;
        public virtual DbSet<TblGoodsReceivedNoteMaster> TblGoodsReceivedNoteMasters { get; set; } = null!;
        public virtual DbSet<TblGroup> TblGroups { get; set; } = null!;
        public virtual DbSet<TblGroupSm> TblGroupSms { get; set; } = null!;
        public virtual DbSet<TblHoldWpfPosbillTaxesDatum> TblHoldWpfPosbillTaxesData { get; set; } = null!;
        public virtual DbSet<TblHoldWpfPosdataMaster> TblHoldWpfPosdataMasters { get; set; } = null!;
        public virtual DbSet<TblHoldWpfPosdatum> TblHoldWpfPosdata { get; set; } = null!;
        public virtual DbSet<TblHoliday> TblHolidays { get; set; } = null!;
        public virtual DbSet<TblImage> TblImages { get; set; } = null!;
        public virtual DbSet<TblImagesPath> TblImagesPaths { get; set; } = null!;
        public virtual DbSet<TblInstallment> TblInstallments { get; set; } = null!;
        public virtual DbSet<TblInstallmentsDefinition> TblInstallmentsDefinitions { get; set; } = null!;
        public virtual DbSet<TblInstallmentsVoucherDetail> TblInstallmentsVoucherDetails { get; set; } = null!;
        public virtual DbSet<TblInstallmentsVoucherMaster> TblInstallmentsVoucherMasters { get; set; } = null!;
        public virtual DbSet<TblInvestigation> TblInvestigations { get; set; } = null!;
        public virtual DbSet<TblInvoiceGenerationStatus> TblInvoiceGenerationStatuses { get; set; } = null!;
        public virtual DbSet<TblInvoiceWiseReceiptVoucher> TblInvoiceWiseReceiptVouchers { get; set; } = null!;
        public virtual DbSet<TblIssueStockDetail> TblIssueStockDetails { get; set; } = null!;
        public virtual DbSet<TblIssueStockMaster> TblIssueStockMasters { get; set; } = null!;
        public virtual DbSet<TblJobStatus> TblJobStatuses { get; set; } = null!;
        public virtual DbSet<TblJournalDetail> TblJournalDetails { get; set; } = null!;
        public virtual DbSet<TblJournalMaster> TblJournalMasters { get; set; } = null!;
        public virtual DbSet<TblKitchenOrder> TblKitchenOrders { get; set; } = null!;
        public virtual DbSet<TblKot> TblKots { get; set; } = null!;
        public virtual DbSet<TblLead> TblLeads { get; set; } = null!;
        public virtual DbSet<TblLedgerPosting> TblLedgerPostings { get; set; } = null!;
        public virtual DbSet<TblLedgerRegisterDataColumn> TblLedgerRegisterDataColumns { get; set; } = null!;
        public virtual DbSet<TblLedgerRegisterFiltersList> TblLedgerRegisterFiltersLists { get; set; } = null!;
        public virtual DbSet<TblLetterDelivery> TblLetterDeliveries { get; set; } = null!;
        public virtual DbSet<TblLetterReceiving> TblLetterReceivings { get; set; } = null!;
        public virtual DbSet<TblLicensePlan> TblLicensePlans { get; set; } = null!;
        public virtual DbSet<TblLiscenseStatus> TblLiscenseStatuses { get; set; } = null!;
        public virtual DbSet<TblLiscenseType> TblLiscenseTypes { get; set; } = null!;
        public virtual DbSet<TblLocation> TblLocations { get; set; } = null!;
        public virtual DbSet<TblLogOperation> TblLogOperations { get; set; } = null!;
        public virtual DbSet<TblMEmployee> TblMEmployees { get; set; } = null!;
        public virtual DbSet<TblMEmployeeAttachmentsDetail> TblMEmployeeAttachmentsDetails { get; set; } = null!;
        public virtual DbSet<TblMEmployeeBankDetail> TblMEmployeeBankDetails { get; set; } = null!;
        public virtual DbSet<TblMEmployeeContractDetail> TblMEmployeeContractDetails { get; set; } = null!;
        public virtual DbSet<TblMEmployeeDocumentsDetail> TblMEmployeeDocumentsDetails { get; set; } = null!;
        public virtual DbSet<TblMEmployeeEducationDetail> TblMEmployeeEducationDetails { get; set; } = null!;
        public virtual DbSet<TblMEmployeeExperienceDetail> TblMEmployeeExperienceDetails { get; set; } = null!;
        public virtual DbSet<TblMEmployeeExpiredAttachmentsDetail> TblMEmployeeExpiredAttachmentsDetails { get; set; } = null!;
        public virtual DbSet<TblMEmployeeFamilyDetail> TblMEmployeeFamilyDetails { get; set; } = null!;
        public virtual DbSet<TblMEmployeeImage> TblMEmployeeImages { get; set; } = null!;
        public virtual DbSet<TblMEmployeeIncrementDetail> TblMEmployeeIncrementDetails { get; set; } = null!;
        public virtual DbSet<TblMEmployeePassportDetail> TblMEmployeePassportDetails { get; set; } = null!;
        public virtual DbSet<TblMEmployeeSalaryStructureDetail> TblMEmployeeSalaryStructureDetails { get; set; } = null!;
        public virtual DbSet<TblMEmployeeStatutoryDetail> TblMEmployeeStatutoryDetails { get; set; } = null!;
        public virtual DbSet<TblMarketPlace> TblMarketPlaces { get; set; } = null!;
        public virtual DbSet<TblMaterialReceiptDetail> TblMaterialReceiptDetails { get; set; } = null!;
        public virtual DbSet<TblMaterialReceiptDocument> TblMaterialReceiptDocuments { get; set; } = null!;
        public virtual DbSet<TblMaterialReceiptMaster> TblMaterialReceiptMasters { get; set; } = null!;
        public virtual DbSet<TblMcustomer> TblMcustomers { get; set; } = null!;
        public virtual DbSet<TblMembership> TblMemberships { get; set; } = null!;
        public virtual DbSet<TblMobileBarcode> TblMobileBarcodes { get; set; } = null!;
        public virtual DbSet<TblMobileStock> TblMobileStocks { get; set; } = null!;
        public virtual DbSet<TblModelNo> TblModelNos { get; set; } = null!;
        public virtual DbSet<TblModule> TblModules { get; set; } = null!;
        public virtual DbSet<TblMultiLanguageControl> TblMultiLanguageControls { get; set; } = null!;
        public virtual DbSet<TblMultipleBillCollectionDetail> TblMultipleBillCollectionDetails { get; set; } = null!;
        public virtual DbSet<TblMultipleBillCollectionMaster> TblMultipleBillCollectionMasters { get; set; } = null!;
        public virtual DbSet<TblMultipleImage> TblMultipleImages { get; set; } = null!;
        public virtual DbSet<TblMultiresult> TblMultiresults { get; set; } = null!;
        public virtual DbSet<TblNewTest> TblNewTests { get; set; } = null!;
        public virtual DbSet<TblNewTicketDetail> TblNewTicketDetails { get; set; } = null!;
        public virtual DbSet<TblOpdRefundDetail> TblOpdRefundDetails { get; set; } = null!;
        public virtual DbSet<TblOpdRefundMaster> TblOpdRefundMasters { get; set; } = null!;
        public virtual DbSet<TblOpdService> TblOpdServices { get; set; } = null!;
        public virtual DbSet<TblOpdTicketDetail> TblOpdTicketDetails { get; set; } = null!;
        public virtual DbSet<TblOpdTicketMaster> TblOpdTicketMasters { get; set; } = null!;
        public virtual DbSet<TblPackage> TblPackages { get; set; } = null!;
        public virtual DbSet<TblPackageDetail> TblPackageDetails { get; set; } = null!;
        public virtual DbSet<TblPatientAllergy> TblPatientAllergies { get; set; } = null!;
        public virtual DbSet<TblPatientDetailsInfo> TblPatientDetailsInfos { get; set; } = null!;
        public virtual DbSet<TblPatientVital> TblPatientVitals { get; set; } = null!;
        public virtual DbSet<TblPayHead> TblPayHeads { get; set; } = null!;
        public virtual DbSet<TblPayHeadDetail> TblPayHeadDetails { get; set; } = null!;
        public virtual DbSet<TblPayHeadFormulaDetail> TblPayHeadFormulaDetails { get; set; } = null!;
        public virtual DbSet<TblPayHeadFormulaMaster> TblPayHeadFormulaMasters { get; set; } = null!;
        public virtual DbSet<TblPayHeadType> TblPayHeadTypes { get; set; } = null!;
        public virtual DbSet<TblPayRollGeneration> TblPayRollGenerations { get; set; } = null!;
        public virtual DbSet<TblPayRollGenerationDetail> TblPayRollGenerationDetails { get; set; } = null!;
        public virtual DbSet<TblPayRollVoucher> TblPayRollVouchers { get; set; } = null!;
        public virtual DbSet<TblPayRollVoucherDetail> TblPayRollVoucherDetails { get; set; } = null!;
        public virtual DbSet<TblPayScale> TblPayScales { get; set; } = null!;
        public virtual DbSet<TblPaymentDetail> TblPaymentDetails { get; set; } = null!;
        public virtual DbSet<TblPaymentMaster> TblPaymentMasters { get; set; } = null!;
        public virtual DbSet<TblPaymentMethod> TblPaymentMethods { get; set; } = null!;
        public virtual DbSet<TblPaymentMethodMapping> TblPaymentMethodMappings { get; set; } = null!;
        public virtual DbSet<TblPaymentVoucherDoubleDetail> TblPaymentVoucherDoubleDetails { get; set; } = null!;
        public virtual DbSet<TblPaymentVoucherDoubleMaster> TblPaymentVoucherDoubleMasters { get; set; } = null!;
        public virtual DbSet<TblPhysicalExamination> TblPhysicalExaminations { get; set; } = null!;
        public virtual DbSet<TblPolicy> TblPolicies { get; set; } = null!;
        public virtual DbSet<TblPolicyDetail> TblPolicyDetails { get; set; } = null!;
        public virtual DbSet<TblPosOpeningStock> TblPosOpeningStocks { get; set; } = null!;
        public virtual DbSet<TblPosuser> TblPosusers { get; set; } = null!;
        public virtual DbSet<TblPosuserPasswordsAndRole> TblPosuserPasswordsAndRoles { get; set; } = null!;
        public virtual DbSet<TblPosusersImage> TblPosusersImages { get; set; } = null!;
        public virtual DbSet<TblPrescription> TblPrescriptions { get; set; } = null!;
        public virtual DbSet<TblPrescriptionMedicine> TblPrescriptionMedicines { get; set; } = null!;
        public virtual DbSet<TblPrescriptionTest> TblPrescriptionTests { get; set; } = null!;
        public virtual DbSet<TblPresentingComplaint> TblPresentingComplaints { get; set; } = null!;
        public virtual DbSet<TblPricingLevel> TblPricingLevels { get; set; } = null!;
        public virtual DbSet<TblProdCategoryWithUser> TblProdCategoryWithUsers { get; set; } = null!;
        public virtual DbSet<TblProduct> TblProducts { get; set; } = null!;
        public virtual DbSet<TblProductAdditionInfoMaster> TblProductAdditionInfoMasters { get; set; } = null!;
        public virtual DbSet<TblProductAdditionalInfo> TblProductAdditionalInfos { get; set; } = null!;
        public virtual DbSet<TblProductAdditionalInfoClone1> TblProductAdditionalInfoClone1s { get; set; } = null!;
        public virtual DbSet<TblProductAdditionalInfoClone2> TblProductAdditionalInfoClone2s { get; set; } = null!;
        public virtual DbSet<TblProductBarcode> TblProductBarcodes { get; set; } = null!;
        public virtual DbSet<TblProductGroup> TblProductGroups { get; set; } = null!;
        public virtual DbSet<TblProductGroupNumber> TblProductGroupNumbers { get; set; } = null!;
        public virtual DbSet<TblProductImage> TblProductImages { get; set; } = null!;
        public virtual DbSet<TblProductLog> TblProductLogs { get; set; } = null!;
        public virtual DbSet<TblProductLog1> TblProductLogs1 { get; set; } = null!;
        public virtual DbSet<TblProductRegisterFiltersList> TblProductRegisterFiltersLists { get; set; } = null!;
        public virtual DbSet<TblProductionDetail> TblProductionDetails { get; set; } = null!;
        public virtual DbSet<TblProductionMaster> TblProductionMasters { get; set; } = null!;
        public virtual DbSet<TblProfitAnalysisReport> TblProfitAnalysisReports { get; set; } = null!;
        public virtual DbSet<TblProject> TblProjects { get; set; } = null!;
        public virtual DbSet<TblPromotion> TblPromotions { get; set; } = null!;
        public virtual DbSet<TblPurchaseAcLedger> TblPurchaseAcLedgers { get; set; } = null!;
        public virtual DbSet<TblPurchaseBillTax> TblPurchaseBillTaxes { get; set; } = null!;
        public virtual DbSet<TblPurchaseImportAcLedger> TblPurchaseImportAcLedgers { get; set; } = null!;
        public virtual DbSet<TblPurchaseInvoiceDetail> TblPurchaseInvoiceDetails { get; set; } = null!;
        public virtual DbSet<TblPurchaseInvoiceImportDetail> TblPurchaseInvoiceImportDetails { get; set; } = null!;
        public virtual DbSet<TblPurchaseInvoiceImportMaster> TblPurchaseInvoiceImportMasters { get; set; } = null!;
        public virtual DbSet<TblPurchaseInvoiceInstallment> TblPurchaseInvoiceInstallments { get; set; } = null!;
        public virtual DbSet<TblPurchaseInvoiceMaster> TblPurchaseInvoiceMasters { get; set; } = null!;
        public virtual DbSet<TblPurchaseOrderDetail> TblPurchaseOrderDetails { get; set; } = null!;
        public virtual DbSet<TblPurchaseOrderMaster> TblPurchaseOrderMasters { get; set; } = null!;
        public virtual DbSet<TblPurchasePriceListDetail> TblPurchasePriceListDetails { get; set; } = null!;
        public virtual DbSet<TblPurchasePriceListDetailsLog> TblPurchasePriceListDetailsLogs { get; set; } = null!;
        public virtual DbSet<TblPurchasePriceListMaster> TblPurchasePriceListMasters { get; set; } = null!;
        public virtual DbSet<TblPurchaseQoutationDetail> TblPurchaseQoutationDetails { get; set; } = null!;
        public virtual DbSet<TblPurchaseQoutationMaster> TblPurchaseQoutationMasters { get; set; } = null!;
        public virtual DbSet<TblPurchaseReturnBillTax> TblPurchaseReturnBillTaxes { get; set; } = null!;
        public virtual DbSet<TblPurchaseReturnDetail> TblPurchaseReturnDetails { get; set; } = null!;
        public virtual DbSet<TblPurchaseReturnMaster> TblPurchaseReturnMasters { get; set; } = null!;
        public virtual DbSet<TblRack> TblRacks { get; set; } = null!;
        public virtual DbSet<TblRange> TblRanges { get; set; } = null!;
        public virtual DbSet<TblRateType> TblRateTypes { get; set; } = null!;
        public virtual DbSet<TblReOrderLevel> TblReOrderLevels { get; set; } = null!;
        public virtual DbSet<TblReceiptDetail> TblReceiptDetails { get; set; } = null!;
        public virtual DbSet<TblReceiptMaster> TblReceiptMasters { get; set; } = null!;
        public virtual DbSet<TblReconcileChequeDetail> TblReconcileChequeDetails { get; set; } = null!;
        public virtual DbSet<TblRegisteratationDeliveryAttachment> TblRegisteratationDeliveryAttachments { get; set; } = null!;
        public virtual DbSet<TblRegisteration> TblRegisterations { get; set; } = null!;
        public virtual DbSet<TblRegisterationDetail> TblRegisterationDetails { get; set; } = null!;
        public virtual DbSet<TblRegisterationDetailLog> TblRegisterationDetailLogs { get; set; } = null!;
        public virtual DbSet<TblRegisterationLog> TblRegisterationLogs { get; set; } = null!;
        public virtual DbSet<TblRegisterationLogAttempt> TblRegisterationLogAttempts { get; set; } = null!;
        public virtual DbSet<TblRegisterationSubModuleDetail> TblRegisterationSubModuleDetails { get; set; } = null!;
        public virtual DbSet<TblRegistrationFeeDeposit> TblRegistrationFeeDeposits { get; set; } = null!;
        public virtual DbSet<TblReminder> TblReminders { get; set; } = null!;
        public virtual DbSet<TblRentalUnitValue> TblRentalUnitValues { get; set; } = null!;
        public virtual DbSet<TblReportSetting> TblReportSettings { get; set; } = null!;
        public virtual DbSet<TblRestaurantSaleDetail> TblRestaurantSaleDetails { get; set; } = null!;
        public virtual DbSet<TblRestaurantTokenNo> TblRestaurantTokenNos { get; set; } = null!;
        public virtual DbSet<TblRestaurantTransaction> TblRestaurantTransactions { get; set; } = null!;
        public virtual DbSet<TblRestaurantTransactionsMaster> TblRestaurantTransactionsMasters { get; set; } = null!;
        public virtual DbSet<TblReturnIssueStockDetail> TblReturnIssueStockDetails { get; set; } = null!;
        public virtual DbSet<TblReturnIssueStockMaster> TblReturnIssueStockMasters { get; set; } = null!;
        public virtual DbSet<TblRole> TblRoles { get; set; } = null!;
        public virtual DbSet<TblRoom> TblRooms { get; set; } = null!;
        public virtual DbSet<TblRoomBookingCancel> TblRoomBookingCancels { get; set; } = null!;
        public virtual DbSet<TblRoomBookingCancelMaster> TblRoomBookingCancelMasters { get; set; } = null!;
        public virtual DbSet<TblRoomBookingCancelScheduleDetail> TblRoomBookingCancelScheduleDetails { get; set; } = null!;
        public virtual DbSet<TblRoomBookingMaster> TblRoomBookingMasters { get; set; } = null!;
        public virtual DbSet<TblRoomBookingScheduleDetail> TblRoomBookingScheduleDetails { get; set; } = null!;
        public virtual DbSet<TblRoomBookingTimelineDetail> TblRoomBookingTimelineDetails { get; set; } = null!;
        public virtual DbSet<TblRoomImage> TblRoomImages { get; set; } = null!;
        public virtual DbSet<TblAmentiesImage> TblAmentiesImages { get; set; } = null!;
        public virtual DbSet<TblRoomTariff> TblRoomTariffs { get; set; } = null!;
        public virtual DbSet<TblRoomTypeAmentiesDetail> TblRoomTypeAmentiesDetails { get; set; } = null!;
        public virtual DbSet<TblRoomTypeHouseKeepingDetail> TblRoomTypeHouseKeepingDetails { get; set; } = null!;
        public virtual DbSet<TblRoomTypeImage> TblRoomTypeImages { get; set; } = null!;
        public virtual DbSet<TblRoomTypeMaster> TblRoomTypeMasters { get; set; } = null!;
        public virtual DbSet<TblRoute> TblRoutes { get; set; } = null!;
        public virtual DbSet<TblSalaryChequeDetail> TblSalaryChequeDetails { get; set; } = null!;
        public virtual DbSet<TblSalaryPaymentDetail> TblSalaryPaymentDetails { get; set; } = null!;
        public virtual DbSet<TblSalaryPaymentMaster> TblSalaryPaymentMasters { get; set; } = null!;
        public virtual DbSet<TblSalaryStructureDetail> TblSalaryStructureDetails { get; set; } = null!;
        public virtual DbSet<TblSalaryStructureMaster> TblSalaryStructureMasters { get; set; } = null!;
        public virtual DbSet<TblSaleAcLedger> TblSaleAcLedgers { get; set; } = null!;
        public virtual DbSet<TblSaleAcLedgerDuplicate> TblSaleAcLedgerDuplicates { get; set; } = null!;
        public virtual DbSet<TblSaleBillTax> TblSaleBillTaxes { get; set; } = null!;
        public virtual DbSet<TblSaleBillTaxDuplicate> TblSaleBillTaxDuplicates { get; set; } = null!;
        public virtual DbSet<TblSaleDeliveryOrderDetail> TblSaleDeliveryOrderDetails { get; set; } = null!;
        public virtual DbSet<TblSaleDeliveryOrderMaster> TblSaleDeliveryOrderMasters { get; set; } = null!;
        public virtual DbSet<TblSaleInstallmentsHistory> TblSaleInstallmentsHistories { get; set; } = null!;
        public virtual DbSet<TblSaleInvoiceInstallment> TblSaleInvoiceInstallments { get; set; } = null!;
        public virtual DbSet<TblSaleOrderDetail> TblSaleOrderDetails { get; set; } = null!;
        public virtual DbSet<TblSaleOrderMaster> TblSaleOrderMasters { get; set; } = null!;
        public virtual DbSet<TblSalePriceListDetail> TblSalePriceListDetails { get; set; } = null!;
        public virtual DbSet<TblSalePriceListDetailsLog> TblSalePriceListDetailsLogs { get; set; } = null!;
        public virtual DbSet<TblSalePriceListMaster> TblSalePriceListMasters { get; set; } = null!;
        public virtual DbSet<TblSaleQoutationDetail> TblSaleQoutationDetails { get; set; } = null!;
        public virtual DbSet<TblSaleQoutationMaster> TblSaleQoutationMasters { get; set; } = null!;
        public virtual DbSet<TblSaleReturnDetail> TblSaleReturnDetails { get; set; } = null!;
        public virtual DbSet<TblSaleReturnMaster> TblSaleReturnMasters { get; set; } = null!;
        public virtual DbSet<TblSaleTemplateDetail> TblSaleTemplateDetails { get; set; } = null!;
        public virtual DbSet<TblSaleTemplateMaster> TblSaleTemplateMasters { get; set; } = null!;
        public virtual DbSet<TblSalesCustomer> TblSalesCustomers { get; set; } = null!;
        public virtual DbSet<TblSalesInvoiceDetail> TblSalesInvoiceDetails { get; set; } = null!;
        public virtual DbSet<TblSalesInvoiceDetailsCalc> TblSalesInvoiceDetailsCalcs { get; set; } = null!;
        public virtual DbSet<TblSalesInvoiceDetailsDuplicate> TblSalesInvoiceDetailsDuplicates { get; set; } = null!;
        public virtual DbSet<TblSalesInvoiceMaster> TblSalesInvoiceMasters { get; set; } = null!;
        public virtual DbSet<TblSalesInvoiceMasterCalc> TblSalesInvoiceMasterCalcs { get; set; } = null!;
        public virtual DbSet<TblSalesInvoiceMasterDuplicate> TblSalesInvoiceMasterDuplicates { get; set; } = null!;
        public virtual DbSet<TblSalesMaster> TblSalesMasters { get; set; } = null!;
        public virtual DbSet<TblSalesReturnWithoutInvDetail> TblSalesReturnWithoutInvDetails { get; set; } = null!;
        public virtual DbSet<TblSalesReturnWithoutInvMaster> TblSalesReturnWithoutInvMasters { get; set; } = null!;
        public virtual DbSet<TblSeason> TblSeasons { get; set; } = null!;
        public virtual DbSet<TblSeasonRate> TblSeasonRates { get; set; } = null!;
        public virtual DbSet<TblSeasonType> TblSeasonTypes { get; set; } = null!;
        public virtual DbSet<TblServer> TblServers { get; set; } = null!;
        public virtual DbSet<TblService> TblServices { get; set; } = null!;
        public virtual DbSet<TblServiceCategory> TblServiceCategories { get; set; } = null!;
        public virtual DbSet<TblServiceDoctorMapping> TblServiceDoctorMappings { get; set; } = null!;
        public virtual DbSet<TblServiceLog> TblServiceLogs { get; set; } = null!;
        public virtual DbSet<TblServiceMembership> TblServiceMemberships { get; set; } = null!;
        public virtual DbSet<TblServiceStatus> TblServiceStatuses { get; set; } = null!;
        public virtual DbSet<TblServicesAddOnField> TblServicesAddOnFields { get; set; } = null!;
        public virtual DbSet<TblServicesAddOnFieldsLog> TblServicesAddOnFieldsLogs { get; set; } = null!;
        public virtual DbSet<TblServicesAddOnsDatum> TblServicesAddOnsData { get; set; } = null!;
        public virtual DbSet<TblServicesCustomField> TblServicesCustomFields { get; set; } = null!;
        public virtual DbSet<TblServicesCustomFieldsDatum> TblServicesCustomFieldsData { get; set; } = null!;
        public virtual DbSet<TblServicesCustomerDatum> TblServicesCustomerData { get; set; } = null!;
        public virtual DbSet<TblSetting> TblSettings { get; set; } = null!;
        public virtual DbSet<TblSheduleSm> TblSheduleSms { get; set; } = null!;
        public virtual DbSet<TblShipmentType> TblShipmentTypes { get; set; } = null!;
        public virtual DbSet<TblShortPrevilidgeDetail> TblShortPrevilidgeDetails { get; set; } = null!;
        public virtual DbSet<TblShortPrevilidgeMaster> TblShortPrevilidgeMasters { get; set; } = null!;
        public virtual DbSet<TblSiadvanceSearch> TblSiadvanceSearches { get; set; } = null!;
        public virtual DbSet<TblSingleBillCollection> TblSingleBillCollections { get; set; } = null!;
        public virtual DbSet<TblSingleSm> TblSingleSms { get; set; } = null!;
        public virtual DbSet<TblSize> TblSizes { get; set; } = null!;
        public virtual DbSet<TblSkinnedcash> TblSkinnedcashes { get; set; } = null!;
        public virtual DbSet<TblSmsapiSetting> TblSmsapiSettings { get; set; } = null!;
        public virtual DbSet<TblSmssetting> TblSmssettings { get; set; } = null!;
        public virtual DbSet<TblSmstemplate> TblSmstemplates { get; set; } = null!;
        public virtual DbSet<TblSmtp> TblSmtps { get; set; } = null!;
        public virtual DbSet<TblSmtpemail> TblSmtpemails { get; set; } = null!;
        public virtual DbSet<TblSplitBill> TblSplitBills { get; set; } = null!;
        public virtual DbSet<TblStandardRate> TblStandardRates { get; set; } = null!;
        public virtual DbSet<TblStockAlert> TblStockAlerts { get; set; } = null!;
        public virtual DbSet<TblStockBatchLedger> TblStockBatchLedgers { get; set; } = null!;
        public virtual DbSet<TblStockDetail> TblStockDetails { get; set; } = null!;
        public virtual DbSet<TblStockMaster> TblStockMasters { get; set; } = null!;
        public virtual DbSet<TblStockReturnDetail> TblStockReturnDetails { get; set; } = null!;
        public virtual DbSet<TblStockReturnMaster> TblStockReturnMasters { get; set; } = null!;
        public virtual DbSet<TblStockTransferDetail> TblStockTransferDetails { get; set; } = null!;
        public virtual DbSet<TblStockTransferMaster> TblStockTransferMasters { get; set; } = null!;
        public virtual DbSet<TblSubCategoryMapping> TblSubCategoryMappings { get; set; } = null!;
        public virtual DbSet<TblSuffixPrefix> TblSuffixPrefixes { get; set; } = null!;
        public virtual DbSet<TblSystemDepartment> TblSystemDepartments { get; set; } = null!;
        public virtual DbSet<TblTabbedView> TblTabbedViews { get; set; } = null!;
        public virtual DbSet<TblTable> TblTables { get; set; } = null!;
        public virtual DbSet<TblTax> TblTaxes { get; set; } = null!;
        public virtual DbSet<TblTest> TblTests { get; set; } = null!;
        public virtual DbSet<TblTestBookingDetail> TblTestBookingDetails { get; set; } = null!;
        public virtual DbSet<TblTestBookingMaster> TblTestBookingMasters { get; set; } = null!;
        public virtual DbSet<TblTestBookingpatient> TblTestBookingpatients { get; set; } = null!;
        public virtual DbSet<TblTicketDetail> TblTicketDetails { get; set; } = null!;
        public virtual DbSet<TblTicketMaster> TblTicketMasters { get; set; } = null!;
        public virtual DbSet<TblTiming> TblTimings { get; set; } = null!;
        public virtual DbSet<TblTimingDetail> TblTimingDetails { get; set; } = null!;
        public virtual DbSet<TblUnitsOfMeasurementGroup> TblUnitsOfMeasurementGroups { get; set; } = null!;
        public virtual DbSet<TblUom> TblUoms { get; set; } = null!;
        public virtual DbSet<TblUomWithUomgroup> TblUomWithUomgroups { get; set; } = null!;
        public virtual DbSet<TblUomdefination> TblUomdefinations { get; set; } = null!;
        public virtual DbSet<TblUomgroup> TblUomgroups { get; set; } = null!;
        public virtual DbSet<TblUser> TblUsers { get; set; } = null!;
        public virtual DbSet<TblUserPrevilige> TblUserPreviliges { get; set; } = null!;
        public virtual DbSet<TblValidation> TblValidations { get; set; } = null!;
        public virtual DbSet<TblVariablePricing> TblVariablePricings { get; set; } = null!;
        public virtual DbSet<TblVoucherAttachment> TblVoucherAttachments { get; set; } = null!;
        public virtual DbSet<TblVoucherType> TblVoucherTypes { get; set; } = null!;
        public virtual DbSet<TblVoucherTypeTax> TblVoucherTypeTaxes { get; set; } = null!;
        public virtual DbSet<TblWarranty> TblWarranties { get; set; } = null!;
        public virtual DbSet<TblWarrantyDetail> TblWarrantyDetails { get; set; } = null!;
        public virtual DbSet<TblWorkUnit> TblWorkUnits { get; set; } = null!;
        public virtual DbSet<TblWpftaxis> TblWpftaxes { get; set; } = null!;
        public virtual DbSet<TblZakatPosting> TblZakatPostings { get; set; } = null!;
        public virtual DbSet<TbldummyAdditional> TbldummyAdditionals { get; set; } = null!;
        public virtual DbSet<ViewAttaBookingReportDatum> ViewAttaBookingReportData { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//          //     optionsBuilder.UseSqlServer("Server=HANI\\sqlexpress;Database=dbHMS;Trusted_Connection=True;Timeout=300;command timeout=300;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<proc_LoadRoomTariff>().HasNoKey();
            modelBuilder.Entity<Proc_LoadReservationSeason>().HasNoKey();
            modelBuilder.Entity<proc_customSupplierbalance>().HasNoKey();
            modelBuilder.Entity<AvailabeGrnqty>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AvailabeGRNQty");

                entity.Property(e => e.Balance).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ConsumedByGrn).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.PurchaseInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Message)
                    .IsUnicode(false)
                    .HasColumnName("message");
            });

            modelBuilder.Entity<RptviewGrnDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("rptview_GrnDetails");

                entity.Property(e => e.Barcode)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.DeliveredQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("deliveredQty");

                entity.Property(e => e.DeliveryUomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("deliveryUOMId");

                entity.Property(e => e.DeliveryUomname).HasColumnName("deliveryUOMName");

                entity.Property(e => e.GrnDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("grnDetailsId");

                entity.Property(e => e.GrnId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grnId");

                entity.Property(e => e.InvoiceQty).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Perctn)
                    .HasColumnType("decimal(37, 4)")
                    .HasColumnName("PERCTN");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.ProductUomgroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ProductUOMGroupId");

                entity.Property(e => e.ProductUomgroupName).HasColumnName("ProductUOMGroupName");

                entity.Property(e => e.ProductUomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ProductUOMId");

                entity.Property(e => e.ProductUomname).HasColumnName("ProductUOMName");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<RptviewLogHistoryDataView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("rptview_LogHistoryDataView");

                entity.Property(e => e.OperationDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperationTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OperationType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherTypeName).IsUnicode(false);
            });

            modelBuilder.Entity<RptviewSaleDeliveryOrderDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("rptview_SaleDeliveryOrderDetails");

                entity.Property(e => e.Barcode)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.DeliveredQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("deliveredQty");

                entity.Property(e => e.DeliveryUomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("deliveryUOMId");

                entity.Property(e => e.DeliveryUomname).HasColumnName("deliveryUOMName");

                entity.Property(e => e.InvoiceQty).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Perctn)
                    .HasColumnType("decimal(37, 4)")
                    .HasColumnName("PERCTN");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.ProductUomgroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ProductUOMGroupId");

                entity.Property(e => e.ProductUomgroupName).HasColumnName("ProductUOMGroupName");

                entity.Property(e => e.ProductUomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ProductUOMId");

                entity.Property(e => e.ProductUomname).HasColumnName("ProductUOMName");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaleDomasterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleDOMasterId");

                entity.Property(e => e.SalesInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceId");
            });

            modelBuilder.Entity<SavedGrnrecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SavedGRNRecords");

                entity.Property(e => e.GrnDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("grnDetailsId");

                entity.Property(e => e.GrnId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grnId");

                entity.Property(e => e.GrnNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grnNo");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.PurchaseInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseInvoiceId");

                entity.Property(e => e.PurchaseInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseInvoiceNo");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.Qtyrceived)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qtyrceived");
            });

            modelBuilder.Entity<TableSampleReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("table_SampleReports");

                entity.Property(e => e.ReportId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reportID");

                entity.Property(e => e.Sample).HasColumnName("sample");
            });

            modelBuilder.Entity<TblAccountGroup>(entity =>
            {
                entity.HasKey(e => e.AccountGroupId)
                    .HasName("PK__tbl_Acco__74C422AE625A9A57");

                entity.ToTable("tbl_AccountGroup");

                entity.Property(e => e.AccountGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("accountGroupId");

                entity.Property(e => e.AccountGroupName)
                    .IsUnicode(false)
                    .HasColumnName("accountGroupName");

                entity.Property(e => e.AffectGrossProfit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("affectGrossProfit");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.GroupUnder)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("groupUnder");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.Nature)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nature");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<TblAccountLedger>(entity =>
            {
                entity.HasKey(e => e.LedgerId)
                    .HasName("PK_tbl_AccountLedger_1");

                entity.ToTable("tbl_AccountLedger");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.AccountGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("accountGroupId");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Age)
                    .HasMaxLength(50)
                    .HasColumnName("age");

                entity.Property(e => e.AreaId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("areaId");

                entity.Property(e => e.BankAccountNumber)
                    .IsUnicode(false)
                    .HasColumnName("bankAccountNumber");

                entity.Property(e => e.BankName).HasMaxLength(100);

                entity.Property(e => e.BeneficiaryName).HasMaxLength(50);

                entity.Property(e => e.BillByBill).HasColumnName("billByBill");

                entity.Property(e => e.BirthPlace)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(50)
                    .HasColumnName("bloodGroup");

                entity.Property(e => e.BranchCode)
                    .IsUnicode(false)
                    .HasColumnName("branchCode");

                entity.Property(e => e.BranchName).HasColumnName("branchName");

                entity.Property(e => e.CasteId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("casteId");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.CityId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cityId");

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNIC");

                entity.Property(e => e.CompanyName).HasColumnName("companyName");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(100)
                    .HasColumnName("contactPerson");

                entity.Property(e => e.CrOrDr)
                    .IsUnicode(false)
                    .HasColumnName("crOrDr");

                entity.Property(e => e.CreditLimit)
                    .HasMaxLength(50)
                    .HasColumnName("creditLimit");

                entity.Property(e => e.CreditLimitAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditLimitDays).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreditPeriod).HasColumnName("creditPeriod");

                entity.Property(e => e.Cst)
                    .IsUnicode(false)
                    .HasColumnName("cst");

                entity.Property(e => e.CustomerShopName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Customercode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customercode");

                entity.Property(e => e.DateOfRegistration)
                    .HasColumnType("date")
                    .HasColumnName("dateOfRegistration");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.ExamptGst).HasColumnName("ExamptGST");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.FathersName).HasColumnName("fathersName");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Gstno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GSTNo");

                entity.Property(e => e.GuestType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCountry).HasMaxLength(50);

                entity.Property(e => e.IdState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdentityId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdentityType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.LedgerCode)
                    .IsUnicode(false)
                    .HasColumnName("ledgerCode");

                entity.Property(e => e.LedgerName).HasColumnName("ledgerName");

                entity.Property(e => e.MailingName).HasColumnName("mailingName");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobile");

                entity.Property(e => e.MobileNo2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobileNo2");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.Ntnno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NTNNo");

                entity.Property(e => e.OpeningBalance)
                    .HasMaxLength(50)
                    .HasColumnName("openingBalance");

                entity.Property(e => e.OpeningBalanceDate)
                    .HasColumnType("date")
                    .HasColumnName("openingBalanceDate");

                entity.Property(e => e.Pan)
                    .IsUnicode(false)
                    .HasColumnName("pan");

                entity.Property(e => e.PartyGroup)
                    .HasMaxLength(50)
                    .HasColumnName("partyGroup");

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("passportNo");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.PricinglevelId)
                    .HasMaxLength(50)
                    .HasColumnName("pricinglevelId");

                entity.Property(e => e.PromiseDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Route).HasMaxLength(50);

                entity.Property(e => e.RouteId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("routeId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SwiftCode).HasMaxLength(50);

                entity.Property(e => e.Tin)
                    .IsUnicode(false)
                    .HasColumnName("tin");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValidDateFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidDateTo).HasColumnType("datetime");

                entity.Property(e => e.VehicleColo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleLic).IsUnicode(false);

                entity.Property(e => e.VehicleModel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YearlyVist)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAccountLedgerGaurantor>(entity =>
            {
                entity.HasKey(e => e.LedgerGaurantorId);

                entity.ToTable("tbl_AccountLedgerGaurantor");

                entity.Property(e => e.LedgerGaurantorId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerGaurantorId");

                entity.Property(e => e.GaurantorAddress)
                    .IsUnicode(false)
                    .HasColumnName("gaurantorAddress");

                entity.Property(e => e.GaurantorFatherName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gaurantorFatherName");

                entity.Property(e => e.GaurantorMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gaurantorMobile");

                entity.Property(e => e.GaurantorName)
                    .IsUnicode(false)
                    .HasColumnName("gaurantorName");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");
            });

            modelBuilder.Entity<TblAccountLedgerImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_AccountLedgerImages");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.LedgerPhoto)
                    .HasColumnType("image")
                    .HasColumnName("ledgerPhoto");
            });

            modelBuilder.Entity<TblActualMaterialReceiptDetail>(entity =>
            {
                entity.HasKey(e => e.MaterialReceiptDetailsId);

                entity.ToTable("tbl_ActualMaterialReceiptDetails");

                entity.Property(e => e.MaterialReceiptDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("materialReceiptDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.GodownId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MaterialReceiptMasterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("materialReceiptMasterId");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productName");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("qty");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.ReceiptDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("receiptDate");

                entity.Property(e => e.ReceiptStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("receiptStatus");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");
            });

            modelBuilder.Entity<TblActualMaterialReceiptMaster>(entity =>
            {
                entity.HasKey(e => e.MaterialReceiptMasterId);

                entity.ToTable("tbl_ActualMaterialReceiptMaster");

                entity.Property(e => e.MaterialReceiptMasterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("materialReceiptMasterId");

                entity.Property(e => e.Batch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batch");

                entity.Property(e => e.MaterialReceiptDocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("materialReceiptDocumentDate");

                entity.Property(e => e.MaterialReceiptNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("materialReceiptNo");

                entity.Property(e => e.MaterialReceiptPostingDate)
                    .HasColumnType("date")
                    .HasColumnName("materialReceiptPostingDate");

                entity.Property(e => e.Narration).IsUnicode(false);

                entity.Property(e => e.PurchaseInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseInvoiceId");

                entity.Property(e => e.PurchaseInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseInvoiceNo");

                entity.Property(e => e.PurchaseOrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseOrderNo");

                entity.Property(e => e.ReceivedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("receivedBy");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.SupplierId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("supplierId");

                entity.Property(e => e.SupplierRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplierRefNo");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("total");

                entity.Property(e => e.VendorInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vendorInvoiceNo");
            });

            modelBuilder.Entity<TblAdjustmentDetail>(entity =>
            {
                entity.HasKey(e => e.AdjustmentDetailsId);

                entity.ToTable("tbl_AdjustmentDetails");

                entity.Property(e => e.AdjustmentDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("adjustmentDetailsId");

                entity.Property(e => e.AdjustmentMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("adjustmentMasterId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.PurchasePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchasePrice");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("quantity");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblAdjustmentMaster>(entity =>
            {
                entity.HasKey(e => e.AdjustmentMasterId);

                entity.ToTable("tbl_AdjustmentMaster");

                entity.Property(e => e.AdjustmentMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("adjustmentMasterId");

                entity.Property(e => e.AdjustmentNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adjustmentNo");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.IngredientsCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ingredientsCost");

                entity.Property(e => e.IsApproved).HasColumnName("isApproved");

                entity.Property(e => e.Memo).HasColumnName("memo");

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reference");

                entity.Property(e => e.SalesStaffId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesStaffId");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.WarehouseId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("warehouseId");
            });

            modelBuilder.Entity<TblAdmin>(entity =>
            {
                entity.ToTable("tbl_Admin");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblAllergy>(entity =>
            {
                entity.HasKey(e => e.AllergyId);

                entity.ToTable("tbl_Allergy");

                entity.Property(e => e.AllergyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("allergyId");

                entity.Property(e => e.AllergyName)
                    .HasMaxLength(50)
                    .HasColumnName("allergyName");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblAllowanceEnhancementDepartmentDetail>(entity =>
            {
                entity.ToTable("tbl_AllowanceEnhancementDepartmentDetails");

                entity.Property(e => e.Id).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");
            });

            modelBuilder.Entity<TblAllowanceEnhancementEmployeeDetail>(entity =>
            {
                entity.ToTable("tbl_AllowanceEnhancementEmployeeDetails");

                entity.Property(e => e.Id).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeId");
            });

            modelBuilder.Entity<TblAllowanceEnhancementMaster>(entity =>
            {
                entity.HasKey(e => e.AllowenceEnhancementId)
                    .HasName("PK_tbl_AllowanceEnhancement");

                entity.ToTable("tbl_AllowanceEnhancementMaster");

                entity.Property(e => e.AllowenceEnhancementId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");

                entity.Property(e => e.DesignationId).HasColumnName("designationId");

                entity.Property(e => e.PayScaleId).HasColumnName("payScaleId");

                entity.Property(e => e.Uid)
                    .HasMaxLength(10)
                    .HasColumnName("uid")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblAmenty>(entity =>
            {
                entity.HasKey(e => e.AmentiesId);

                entity.ToTable("tbl_Amenties");

                entity.Property(e => e.AmentiesId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amentiesId");

                entity.Property(e => e.AmentiesName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("amentiesName");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblApplication>(entity =>
            {
                entity.ToTable("tbl_Application");

                entity.Property(e => e.ApplicationKey).IsUnicode(false);

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblApplicationButtonSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_ApplicationButtonSetting");

                entity.Property(e => e.ControlName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblApplicationDetail>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("tbl_ApplicationDetail");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TblApplicationFormSettingSqltable>(entity =>
            {
                entity.HasKey(e => e.FormName);

                entity.ToTable("tbl_ApplicationFormSetting_SQLTable");

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KEY");

                entity.Property(e => e.Sqltable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SQLTable");
            });

            modelBuilder.Entity<TblApplicationFormsSettingDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_ApplicationFormsSettingDetail");

                entity.Property(e => e.ControlName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Operation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblApplicationFormsSettingMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_ApplicationFormsSettingMaster");

                entity.Property(e => e.ControlName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<TblApplicationMdibuttonSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_ApplicationMDIButtonSetting");

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Information).IsUnicode(false);

                entity.Property(e => e.Mdibutton)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MDIButton");

                entity.Property(e => e.Path)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblApplicationRegistersColumn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_ApplicationRegistersColumns");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Formname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("formname");
            });

            modelBuilder.Entity<TblApplyPromotionsDetail>(entity =>
            {
                entity.HasKey(e => e.ApplyPromotionsDetailsId)
                    .HasName("PK_tbl_ApplyPromotionsForAllProducts");

                entity.ToTable("tbl_ApplyPromotionsDetails");

                entity.Property(e => e.ApplyPromotionsDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("applyPromotionsDetailsId");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ApplyPromotionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("applyPromotionId");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.FromDate)
                    .HasColumnType("date")
                    .HasColumnName("fromDate");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.PromotionPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("promotionPrice");

                entity.Property(e => e.ToDate)
                    .HasColumnType("date")
                    .HasColumnName("toDate");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("unitPrice");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");
            });

            modelBuilder.Entity<TblApplyPromotionsForBrand>(entity =>
            {
                entity.HasKey(e => e.PromotionsForBrandId);

                entity.ToTable("tbl_ApplyPromotionsForBrand");

                entity.Property(e => e.PromotionsForBrandId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("promotionsForBrandId");

                entity.Property(e => e.ApplyPromotionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("applyPromotionId");

                entity.Property(e => e.BrandId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("brandId");

                entity.Property(e => e.CashDiscount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cashDiscount");

                entity.Property(e => e.PercentDiscount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("percentDiscount");

                entity.Property(e => e.PromotionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("promotionCode");
            });

            modelBuilder.Entity<TblApplyPromotionsForProductGroup>(entity =>
            {
                entity.HasKey(e => e.PromotionsForProductGroupId)
                    .HasName("PK_tbl_ApplyPromotionsForCategories");

                entity.ToTable("tbl_ApplyPromotionsForProductGroup");

                entity.Property(e => e.PromotionsForProductGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("promotionsForProductGroupId");

                entity.Property(e => e.ApplyPromotionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("applyPromotionId");

                entity.Property(e => e.CashDiscount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cashDiscount");

                entity.Property(e => e.PercentDiscount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("percentDiscount");

                entity.Property(e => e.ProductGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productGroupId");

                entity.Property(e => e.PromotionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("promotionCode");
            });

            modelBuilder.Entity<TblApplyPromotionsMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_ApplyPromotionsMaster");

                entity.Property(e => e.ApplyPromotionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("applyPromotionId");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.FromDate)
                    .HasColumnType("date")
                    .HasColumnName("fromDate");

                entity.Property(e => e.ToDate)
                    .HasColumnType("date")
                    .HasColumnName("toDate");
            });

            modelBuilder.Entity<TblApplyPromotionsWithHappyHour>(entity =>
            {
                entity.HasKey(e => e.HappyHourTableId);

                entity.ToTable("tbl_ApplyPromotionsWithHappyHours");

                entity.Property(e => e.HappyHourTableId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("happyHourTableId");

                entity.Property(e => e.ApplyPromotionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("applyPromotionId");

                entity.Property(e => e.Friday).HasColumnName("friday");

                entity.Property(e => e.HappyHour).HasColumnName("happyHour");

                entity.Property(e => e.Monday).HasColumnName("monday");

                entity.Property(e => e.PromotionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("promotionCode");

                entity.Property(e => e.Saturday).HasColumnName("saturday");

                entity.Property(e => e.Sunday).HasColumnName("sunday");

                entity.Property(e => e.Thursday).HasColumnName("thursday");

                entity.Property(e => e.Time1From).HasColumnName("time1From");

                entity.Property(e => e.Time1To).HasColumnName("time1To");

                entity.Property(e => e.Time1isActive).HasColumnName("time1isActive");

                entity.Property(e => e.Time2From).HasColumnName("time2From");

                entity.Property(e => e.Time2To).HasColumnName("time2To");

                entity.Property(e => e.Time2isActive).HasColumnName("time2isActive");

                entity.Property(e => e.Tuesday).HasColumnName("tuesday");

                entity.Property(e => e.Wednesday).HasColumnName("wednesday");
            });

            modelBuilder.Entity<TblArea>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("tbl_Area");

                entity.Property(e => e.AreaId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("areaId");

                entity.Property(e => e.AreaName).HasColumnName("areaName");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.Narration).HasColumnName("narration");
            });

            modelBuilder.Entity<TblAssignPrevilidgeDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_AssignPrevilidgeDetail");

                entity.Property(e => e.AssignPrevilidgesId).HasColumnName("AssignPrevilidgesID");

                entity.Property(e => e.Permissions)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAssignPrevilidgeMaster>(entity =>
            {
                entity.HasKey(e => e.AssignPrevilidgesId)
                    .HasName("PK_tbl_AssignPrevilidges");

                entity.ToTable("tbl_AssignPrevilidgeMaster");

                entity.Property(e => e.AssignPrevilidgesId)
                    .ValueGeneratedNever()
                    .HasColumnName("AssignPrevilidgesID");

                entity.Property(e => e.EffectiveFrom).HasColumnType("date");

                entity.Property(e => e.EffectiveTo).HasColumnType("date");

                entity.Property(e => e.Location)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAssignPrevilidgesUserDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_AssignPrevilidgesUserDetail");

                entity.Property(e => e.AssignPrevilidgesUserId).HasColumnName("AssignPrevilidgesUserID");

                entity.Property(e => e.Permissions)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAssignPrevilidgesUserMaster>(entity =>
            {
                entity.HasKey(e => e.AssignPrevilidgesUserId)
                    .HasName("PK_AssignPrevilidgesUserMaster");

                entity.ToTable("tbl_AssignPrevilidgesUserMaster");

                entity.Property(e => e.AssignPrevilidgesUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("AssignPrevilidgesUserID");

                entity.Property(e => e.EffectiveFrom).HasColumnType("date");

                entity.Property(e => e.EffectiveTo).HasColumnType("date");

                entity.Property(e => e.Location)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TblAttaBooking>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_AttaBooking");

                entity.Property(e => e.AdvanceFlour).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AttaBookingId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeductFlour).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductAtta).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductDaal).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductHaldiMirch).HasDefaultValueSql("((0))");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TokenDate).HasColumnType("datetime");

                entity.Property(e => e.TokenNo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblAttaBookingRateSheet>(entity =>
            {
                entity.ToTable("tbl_AttaBookingRateSheet");

                entity.Property(e => e.BalanceAtta)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Khout).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductAtta).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductDaal).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductHaldiMirch).HasDefaultValueSql("((0))");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Safai).HasDefaultValueSql("((0))");

                entity.Property(e => e.StandardValue)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblAttendanceProductionType>(entity =>
            {
                entity.HasKey(e => e.AttendanceProductionId);

                entity.ToTable("tbl_AttendanceProductionType");

                entity.Property(e => e.AttendanceProductionId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("attendanceProductionId");

                entity.Property(e => e.AttendanceType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("attendanceType");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.PeriodType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("periodType");

                entity.Property(e => e.WorkUnitId).HasColumnName("workUnitId");
            });

            modelBuilder.Entity<TblAttendanceVoucher>(entity =>
            {
                entity.HasKey(e => e.AttendanceVoucherId);

                entity.ToTable("tbl_AttendanceVoucher");

                entity.Property(e => e.AttendanceVoucherId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AttendanceVoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttendanceVoucherStatus).HasMaxLength(50);

                entity.Property(e => e.AttendanceVoucherType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .HasColumnName("departmentId");

                entity.Property(e => e.DocumentDate).HasColumnType("date");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<TblAttendanceVoucherDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_AttendanceVoucherDetails");

                entity.Property(e => e.ActualDays).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApproveDays).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AttendanceVoucherDetailId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalFullDays).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalHalfDays).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalHours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalMinutes).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblAuhtorityLetterDeliveryAttachment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_AuhtorityLetterDeliveryAttachments");

                entity.Property(e => e.AttachmentId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Extenstion).HasColumnName("extenstion");

                entity.Property(e => e.FileName).HasColumnName("fileName");

                entity.Property(e => e.FileType).HasColumnName("fileType");

                entity.Property(e => e.LetterNo).HasMaxLength(50);

                entity.Property(e => e.Path).HasColumnName("path");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<TblBackOrderDetail>(entity =>
            {
                entity.HasKey(e => e.BackOrderDetailsId);

                entity.ToTable("tbl_BackOrderDetails");

                entity.Property(e => e.BackOrderDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("backOrderDetailsId");

                entity.Property(e => e.BackOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("backOrderId");

                entity.Property(e => e.BackOrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("backOrderNo");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerId");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productName");

                entity.Property(e => e.Qty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("qty");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");
            });

            modelBuilder.Entity<TblBackOrderMaster>(entity =>
            {
                entity.HasKey(e => e.BackOrderId);

                entity.ToTable("tbl_BackOrderMaster");

                entity.Property(e => e.BackOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("backOrderId");

                entity.Property(e => e.BackOrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("backOrderNo");

                entity.Property(e => e.BackOrderPistatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("backOrderPIStatus");

                entity.Property(e => e.BackOrderPostatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("backOrderPOStatus");

                entity.Property(e => e.BackOrderStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackOrderisApproved).HasColumnName("backOrderisApproved");

                entity.Property(e => e.CurrencyId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("currencyId");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("deliveryDate");

                entity.Property(e => e.DocumentDate)
                    .HasColumnType("date")
                    .HasColumnName("documentDate");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.Pino)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PINo");

                entity.Property(e => e.Pono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PONo");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("date")
                    .HasColumnName("postingDate");

                entity.Property(e => e.PricingLevelId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.SalesmanId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesmanId");
            });

            modelBuilder.Entity<TblBackupPath>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_BackupPath");

                entity.Property(e => e.BackupPath)
                    .IsUnicode(false)
                    .HasColumnName("backupPath");
            });

            modelBuilder.Entity<TblBank>(entity =>
            {
                entity.HasKey(e => e.BankId)
                    .HasName("PK_bankID");

                entity.ToTable("tbl_Banks");

                entity.Property(e => e.BankId)
                    .ValueGeneratedNever()
                    .HasColumnName("bankID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankAccount>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("tbl_BankAccounts");

                entity.Property(e => e.AccountId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("AccountID");

                entity.Property(e => e.AccountTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActiveEnd)
                    .HasColumnType("date")
                    .HasColumnName("activeEnd");

                entity.Property(e => e.ActiveFrom)
                    .HasColumnType("date")
                    .HasColumnName("activeFrom");

                entity.Property(e => e.Balance)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.CrOrDr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("crOrDr");

                entity.Property(e => e.Glaccount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GLAccount");

                entity.Property(e => e.OpeningBalance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("openingBalance");

                entity.Property(e => e.StatusInactiveEnd).HasColumnType("date");

                entity.Property(e => e.StatusInactivefrom).HasColumnType("date");
            });

            modelBuilder.Entity<TblBankDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_BankDetails");

                entity.Property(e => e.AccountNo)
                    .IsUnicode(false)
                    .HasColumnName("accountNo");

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bankName");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("branchCode");

                entity.Property(e => e.BranchName)
                    .IsUnicode(false)
                    .HasColumnName("branchName");

                entity.Property(e => e.Comments)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.EmpRegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empRegNo");
            });

            modelBuilder.Entity<TblBarcodeSetting>(entity =>
            {
                entity.HasKey(e => e.BarcodeId);

                entity.ToTable("tbl_BarcodeSettings");

                entity.Property(e => e.BarcodeId).ValueGeneratedNever();

                entity.Property(e => e.ApplyOn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShowMrp).HasColumnName("showMRP");

                entity.Property(e => e.ShowProductCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShowProductName)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblBarcodeSettingMaster>(entity =>
            {
                entity.HasKey(e => e.BarcodeId);

                entity.ToTable("tbl_BarcodeSettingMaster");

                entity.Property(e => e.BarcodeId).ValueGeneratedNever();

                entity.Property(e => e.Val1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("val1");

                entity.Property(e => e.Val10)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("val10");

                entity.Property(e => e.Val2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("val2");

                entity.Property(e => e.Val3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("val3");

                entity.Property(e => e.Val4)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("val4");

                entity.Property(e => e.Val5)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("val5");

                entity.Property(e => e.Val6)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("val6");

                entity.Property(e => e.Val7)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("val7");

                entity.Property(e => e.Val8)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("val8");

                entity.Property(e => e.Val9)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("val9");
            });

            modelBuilder.Entity<TblBatch>(entity =>
            {
                entity.HasKey(e => e.BatchId)
                    .HasName("PK__tbl_Batc__78CCD773147C05D0");

                entity.ToTable("tbl_Batch");

                entity.Property(e => e.BatchId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("batchId");

                entity.Property(e => e.Barcode)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.BatchNo)
                    .IsUnicode(false)
                    .HasColumnName("batchNo");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expiryDate");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.ManufacturingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("manufacturingDate");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.PartNo)
                    .IsUnicode(false)
                    .HasColumnName("partNo");

                entity.Property(e => e.ProductId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productId");
            });

            modelBuilder.Entity<TblBikeDocumentDelivery>(entity =>
            {
                entity.HasKey(e => e.BikeDocumentDeliveryId);

                entity.ToTable("tbl_BikeDocumentDelivery");

                entity.Property(e => e.BikeDocumentDeliveryId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("bikeDocumentDeliveryId");

                entity.Property(e => e.BikeDocumentReceivingId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("bikeDocumentReceivingId");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("deliveryDate");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.ReceivedBy).HasColumnName("receivedBy");

                entity.Property(e => e.Remarks).HasColumnName("remarks");
            });

            modelBuilder.Entity<TblBikeDocumentReceiving>(entity =>
            {
                entity.HasKey(e => e.BikeDocumentReceivingId);

                entity.ToTable("tbl_BikeDocumentReceiving");

                entity.Property(e => e.BikeDocumentReceivingId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("bikeDocumentReceivingId");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.ReceivingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("receivingDate");

                entity.Property(e => e.RegistrationNumberReceivingId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("registrationNumberReceivingId");
            });

            modelBuilder.Entity<TblBikeInfo>(entity =>
            {
                entity.ToTable("tbl_BikeInfo");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChasisNo).HasMaxLength(50);

                entity.Property(e => e.DetailsId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EngineNo).HasMaxLength(50);

                entity.Property(e => e.Extra1).HasMaxLength(50);

                entity.Property(e => e.Extra2).HasMaxLength(50);

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uomid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOMId");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblBikeRegistrationNo>(entity =>
            {
                entity.HasKey(e => e.RegistrationNumberReceivingId);

                entity.ToTable("tbl_BikeRegistrationNo");

                entity.Property(e => e.RegistrationNumberReceivingId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("registrationNumberReceivingId");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.RecevingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("recevingDate");

                entity.Property(e => e.RegistrationFeeDespositId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("registrationFeeDespositId");

                entity.Property(e => e.RegistrationNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("registrationNo");
            });

            modelBuilder.Entity<TblBikeStatus>(entity =>
            {
                entity.HasKey(e => e.ChasisNo);

                entity.ToTable("tbl_BikeStatus");

                entity.Property(e => e.ChasisNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBlock>(entity =>
            {
                entity.HasKey(e => e.BlockId);

                entity.ToTable("tbl_Blocks");

                entity.Property(e => e.BlockId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("blockId");

                entity.Property(e => e.BlockName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("blockName");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblBonusQuantity>(entity =>
            {
                entity.HasKey(e => e.BonusQuantityId);

                entity.ToTable("tbl_BonusQuantity");

                entity.Property(e => e.BonusQuantityId).HasColumnName("bonusQuantityId");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Uomid).HasColumnName("UOMId");

                entity.Property(e => e.VoucherTypeId).HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblBookingCount>(entity =>
            {
                entity.ToTable("tbl_BookingCounts");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");
            });

            modelBuilder.Entity<TblBrand>(entity =>
            {
                entity.HasKey(e => e.BrandId)
                    .HasName("PK__tbl_Bran__06B7729946136164");

                entity.ToTable("tbl_Brand");

                entity.Property(e => e.BrandId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("brandId");

                entity.Property(e => e.BrandName).HasColumnName("brandName");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("manufacturer");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblBranding>(entity =>
            {
                entity.ToTable("tbl_Branding");

                entity.Property(e => e.BrandingType).HasMaxLength(50);
            });

            modelBuilder.Entity<TblBuisnessSource>(entity =>
            {
                entity.HasKey(e => e.BuisnessSourceId);

                entity.ToTable("tbl_BuisnessSource");

                entity.Property(e => e.BuisnessSourceId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Email)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCanceledCheque>(entity =>
            {
                entity.HasKey(e => e.ChequeCancelId);

                entity.ToTable("tbl_CanceledCheques");

                entity.Property(e => e.ChequeCancelId)
                    .ValueGeneratedNever()
                    .HasColumnName("chequeCancelId");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AccountID");

                entity.Property(e => e.CancellerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cancellerId");

                entity.Property(e => e.ChequeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocDate).HasColumnType("date");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("docNumber");

                entity.Property(e => e.IsApproved).HasColumnName("isApproved");

                entity.Property(e => e.PostingDate).HasColumnType("date");

                entity.Property(e => e.Reason)
                    .IsUnicode(false)
                    .HasColumnName("reason");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCashMaster>(entity =>
            {
                entity.ToTable("tbl_CashMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime");

                entity.Property(e => e.LastInvoice)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastInvoice");

                entity.Property(e => e.Machine)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("machine");

                entity.Property(e => e.SessionEndingInvoice)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sessionEndingInvoice");

                entity.Property(e => e.Sessionstatus).HasColumnName("sessionstatus");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("shiftName");

                entity.Property(e => e.Shiftid).HasColumnName("shiftid");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<TblCashOpening>(entity =>
            {
                entity.ToTable("tbl_cashOpening");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cash)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cash");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Masterid).HasColumnName("masterid");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<TblCashReceived>(entity =>
            {
                entity.ToTable("tbl_CashReceived");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Currencyid).HasColumnName("currencyid");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime");

                entity.Property(e => e.Fromuser).HasColumnName("fromuser");

                entity.Property(e => e.Masterid).HasColumnName("masterid");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<TblCaste>(entity =>
            {
                entity.HasKey(e => e.CasteId)
                    .HasName("PK__tbl_Caste");

                entity.ToTable("tbl_Caste");

                entity.Property(e => e.CasteId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("casteId");

                entity.Property(e => e.CasteName).HasColumnName("casteName");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblCategoriesHelp>(entity =>
            {
                entity.ToTable("tbl_CategoriesHelp");

                entity.Property(e => e.GroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("groupId");

                entity.Property(e => e.GroupName).HasColumnName("groupName");

                entity.Property(e => e.GroupNamehelp).HasColumnName("groupNamehelp");

                entity.Property(e => e.GroupUnder)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("groupUnder");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblCategoryOpdScreenMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_CategoryOpdScreenMapping");

                entity.Property(e => e.CategoryType).HasColumnName("categoryType");
            });

            modelBuilder.Entity<TblCategoryOpdmappingValue>(entity =>
            {
                entity.HasKey(e => e.CategoryTypeValueId);

                entity.ToTable("tbl_CategoryOPDMappingValues");

                entity.Property(e => e.CategoryTypeValueId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("categoryTypeValueId");

                entity.Property(e => e.CategoryType).HasColumnName("categoryType");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<TblCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Check");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("companyId");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.TableId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("tableId");
            });

            modelBuilder.Entity<TblChequeBook>(entity =>
            {
                entity.ToTable("tbl_ChequeBooks");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("AccountID");

                entity.Property(e => e.ChequeNumberTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeNumberfrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocDate).HasColumnType("date");

                entity.Property(e => e.DocNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("docNumber");

                entity.Property(e => e.PostingDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblChequeDetail>(entity =>
            {
                entity.HasKey(e => e.ChequeDetailsId);

                entity.ToTable("tbl_ChequeDetails");

                entity.Property(e => e.ChequeDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("chequeDetailsId");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accountId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.BankCharges)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bankCharges");

                entity.Property(e => e.ChequeDate)
                    .HasColumnType("date")
                    .HasColumnName("chequeDate");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chequeNo");

                entity.Property(e => e.ChequeSeries)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chequeSeries");

                entity.Property(e => e.ClearanceDate)
                    .HasColumnType("date")
                    .HasColumnName("clearanceDate");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("date")
                    .HasColumnName("issueDate");

                entity.Property(e => e.IssuerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("issuerId");

                entity.Property(e => e.PayeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("payeeId");

                entity.Property(e => e.PaymentMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMasterId");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TblChequesManagment>(entity =>
            {
                entity.HasKey(e => e.ChequesManagmentId);

                entity.ToTable("tbl_ChequesManagment");

                entity.Property(e => e.ChequesManagmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("chequesManagmentId");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accountId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.BankCharges)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bankCharges");

                entity.Property(e => e.BankId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("bankId");

                entity.Property(e => e.ChequeDate)
                    .HasColumnType("date")
                    .HasColumnName("chequeDate");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chequeNo");

                entity.Property(e => e.ChequeSeries)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chequeSeries");

                entity.Property(e => e.ClearanceDate)
                    .HasColumnType("date")
                    .HasColumnName("clearanceDate");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("date")
                    .HasColumnName("issueDate");

                entity.Property(e => e.IssuerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("issuerId");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.StatusDate)
                    .HasColumnType("date")
                    .HasColumnName("statusDate");

                entity.Property(e => e.TransactionCharges)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("transactionCharges");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .HasColumnName("transactionDate");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transactionType");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voucherNo");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblCity>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK__tbl_City");

                entity.ToTable("tbl_City");

                entity.Property(e => e.CityId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cityId");

                entity.Property(e => e.CityName).HasColumnName("cityName");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblColor>(entity =>
            {
                entity.HasKey(e => e.ColorId);

                entity.ToTable("tbl_Color");

                entity.Property(e => e.ColorId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ColorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblComissionMapper>(entity =>
            {
                entity.ToTable("tbl_ComissionMapper");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CommissionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.StageId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StageID");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<TblCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PK__tbl_Comp__AD5459903E723F9C");

                entity.ToTable("tbl_Company");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("companyId");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.CompanyName).HasColumnName("companyName");

                entity.Property(e => e.Country).HasColumnName("country");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .HasColumnName("emailId");

                entity.Property(e => e.Logo)
                    .HasColumnType("image")
                    .HasColumnName("logo");

                entity.Property(e => e.MailingName)
                    .IsUnicode(false)
                    .HasColumnName("mailingName");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .HasColumnName("mobile");

                entity.Property(e => e.Ntn).HasColumnName("NTN");

                entity.Property(e => e.Pan)
                    .HasMaxLength(50)
                    .HasColumnName("pan");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.Pin)
                    .HasMaxLength(50)
                    .HasColumnName("pin");

                entity.Property(e => e.SalesTaxRegistrationNo).HasColumnName("salesTaxRegistrationNo");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Tdate)
                    .HasColumnType("date")
                    .HasColumnName("tdate");

                entity.Property(e => e.Tin)
                    .HasMaxLength(50)
                    .HasColumnName("tin");

                entity.Property(e => e.Web).HasColumnName("web");
            });

            modelBuilder.Entity<TblCompanyImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_CompanyImages");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("companyId");

                entity.Property(e => e.CompanyLogo)
                    .HasColumnType("image")
                    .HasColumnName("companyLogo");
            });

            modelBuilder.Entity<TblCompanyIncentiveDetail>(entity =>
            {
                entity.HasKey(e => e.CompanyIncentiveDetailsId);

                entity.ToTable("tbl_CompanyIncentiveDetails");

                entity.Property(e => e.CompanyIncentiveDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("companyIncentiveDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brandName");

                entity.Property(e => e.CompanyIncentiveMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("companyIncentiveMasterId");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("groupName");

                entity.Property(e => e.MasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("masterId");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.PurchaseInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseInvoiceNo");

                entity.Property(e => e.Qty)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("qty");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TotalIncentive)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalIncentive");

                entity.Property(e => e.UomgroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOMGroupName");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname)
                    .HasMaxLength(50)
                    .HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblCompanyIncentiveMaster>(entity =>
            {
                entity.HasKey(e => e.CompanyIncentiveMasterId);

                entity.ToTable("tbl_CompanyIncentiveMaster");

                entity.Property(e => e.CompanyIncentiveMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("companyIncentiveMasterId");

                entity.Property(e => e.CashierId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cashierId");

                entity.Property(e => e.CompanyIncentiveNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("companyIncentiveNo");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("dateFrom");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("dateTo");

                entity.Property(e => e.GroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("groupId");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMethodId");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.SupplierId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("supplierId");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalAmount");

                entity.Property(e => e.TotalQty)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("totalQty");

                entity.Property(e => e.UnitIncentive)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("unitIncentive");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblCompanyInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Company_Info");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Email_ID");

                entity.Property(e => e.Id)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCompanyPath>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PK__tbl_Comp__AD5459903B36AB95");

                entity.ToTable("tbl_CompanyPath");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("companyId");

                entity.Property(e => e.CompanyName)
                    .IsUnicode(false)
                    .HasColumnName("companyName");

                entity.Property(e => e.CompanyPath)
                    .IsUnicode(false)
                    .HasColumnName("companyPath");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            });

            modelBuilder.Entity<TblConfiguration>(entity =>
            {
                entity.HasKey(e => e.ConfigurationId);

                entity.ToTable("tbl_Configuration");

                entity.Property(e => e.ConfigurationId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Ax).HasColumnName("AX");

                entity.Property(e => e.Dx).HasColumnName("DX");

                entity.Property(e => e.Ex).HasColumnName("EX");

                entity.Property(e => e.Gx).HasColumnName("GX");

                entity.Property(e => e.Hx).HasColumnName("HX");

                entity.Property(e => e.Ix).HasColumnName("IX");

                entity.Property(e => e.Ixx).HasColumnName("IXX");

                entity.Property(e => e.Jx).HasColumnName("JX");

                entity.Property(e => e.Kx).HasColumnName("KX");

                entity.Property(e => e.Mx).HasColumnName("MX");

                entity.Property(e => e.Px).HasColumnName("PX");

                entity.Property(e => e.Rak).HasColumnName("RAK");

                entity.Property(e => e.Rasm).HasColumnName("RASM");

                entity.Property(e => e.Rb).HasColumnName("RB");

                entity.Property(e => e.Rblr).HasColumnName("RBLR");

                entity.Property(e => e.Rbsr).HasColumnName("RBSR");

                entity.Property(e => e.Rcn).HasColumnName("RCN");

                entity.Property(e => e.Rcr).HasColumnName("RCR");

                entity.Property(e => e.Rd).HasColumnName("RD");

                entity.Property(e => e.Red).HasColumnName("RED");

                entity.Property(e => e.Rh).HasColumnName("RH");

                entity.Property(e => e.Rha).HasColumnName("RHA");

                entity.Property(e => e.Rhs).HasColumnName("RHS");

                entity.Property(e => e.Rln).HasColumnName("RLN");

                entity.Property(e => e.Rlp).HasColumnName("RLP");

                entity.Property(e => e.Rlpn).HasColumnName("RLPN");

                entity.Property(e => e.Rls).HasColumnName("RLS");

                entity.Property(e => e.Rlsn).HasColumnName("RLSN");

                entity.Property(e => e.Rlt).HasColumnName("RLT");

                entity.Property(e => e.Rltn).HasColumnName("RLTN");

                entity.Property(e => e.Rm).HasColumnName("RM");

                entity.Property(e => e.Rma).HasColumnName("RMA");

                entity.Property(e => e.Rmc).HasColumnName("RMC");

                entity.Property(e => e.Rmt).HasColumnName("RMT");

                entity.Property(e => e.Rnoc).HasColumnName("RNOC");

                entity.Property(e => e.Rnoi).HasColumnName("RNOI");

                entity.Property(e => e.Rnom).HasColumnName("RNOM");

                entity.Property(e => e.Rnor).HasColumnName("RNOR");

                entity.Property(e => e.Rnos).HasColumnName("RNOS");

                entity.Property(e => e.Rp).HasColumnName("RP");

                entity.Property(e => e.Rpr).HasColumnName("RPR");

                entity.Property(e => e.Rpt).HasColumnName("RPT");

                entity.Property(e => e.Rr).HasColumnName("RR");

                entity.Property(e => e.Rrk).HasColumnName("RRK");

                entity.Property(e => e.Rscm).HasColumnName("RSCM");

                entity.Property(e => e.Rsd).HasColumnName("RSD");

                entity.Property(e => e.Rsm).HasColumnName("RSM");

                entity.Property(e => e.Rsu).HasColumnName("RSU");

                entity.Property(e => e.Run).HasColumnName("RUN");

                entity.Property(e => e.Rup).HasColumnName("RUP");

                entity.Property(e => e.Rx).HasColumnName("RX");

                entity.Property(e => e.Rxx).HasColumnName("RXX");

                entity.Property(e => e.Sx).HasColumnName("SX");

                entity.Property(e => e.Sxx).HasColumnName("SXX");

                entity.Property(e => e.Zx).HasColumnName("ZX");
            });

            modelBuilder.Entity<TblContactDatum>(entity =>
            {
                entity.HasKey(e => e.ContactDataid);

                entity.ToTable("tbl_ContactData");

                entity.Property(e => e.ContactDataid).ValueGeneratedNever();

                entity.Property(e => e.ContactData)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblContactGroup>(entity =>
            {
                entity.HasKey(e => e.ContactGroupId);

                entity.ToTable("tbl_ContactGroup");

                entity.Property(e => e.ContactGroupId).ValueGeneratedNever();

                entity.Property(e => e.ContactGroupCode).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContactGroupName).HasMaxLength(50);

                entity.Property(e => e.GroupDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblContactList>(entity =>
            {
                entity.HasKey(e => e.ContactListId);

                entity.ToTable("tbl_ContactList");

                entity.Property(e => e.ContactListId)
                    .ValueGeneratedNever()
                    .HasColumnName("ContactListID");

                entity.Property(e => e.ContactGroupId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCounter>(entity =>
            {
                entity.HasKey(e => e.CounterId)
                    .HasName("PK__tbl_Coun__08A9D0236497E884");

                entity.ToTable("tbl_Counter");

                entity.Property(e => e.CounterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("counterId");

                entity.Property(e => e.CounterName)
                    .IsUnicode(false)
                    .HasColumnName("counterName");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblCurrency>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Currency");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("currencyId");

                entity.Property(e => e.CurrencyName)
                    .IsUnicode(false)
                    .HasColumnName("currencyName");

                entity.Property(e => e.CurrencySymbol)
                    .IsUnicode(false)
                    .HasColumnName("currencySymbol");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.NoOfDecimalPlaces)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("noOfDecimalPlaces");

                entity.Property(e => e.SubunitName)
                    .IsUnicode(false)
                    .HasColumnName("subunitName");
            });

            modelBuilder.Entity<TblCurrencyNote>(entity =>
            {
                entity.ToTable("tbl_CurrencyNotes");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CurrencyNotes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("currencyNotes");

                entity.Property(e => e.Currencyid).HasColumnName("currencyid");

                entity.Property(e => e.IsActive).HasColumnName("isActive");
            });

            modelBuilder.Entity<TblCustomField>(entity =>
            {
                entity.HasKey(e => e.CustomFieldsId);

                entity.ToTable("tbl_CustomFields");

                entity.Property(e => e.CustomFieldsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customFieldsId");

                entity.Property(e => e.FieldName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fieldName");

                entity.Property(e => e.ProductGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productGroupId");
            });

            modelBuilder.Entity<TblCustomFieldsSearchMapping>(entity =>
            {
                entity.HasKey(e => e.CustomFieldMappingId);

                entity.ToTable("tbl_CustomFieldsSearchMapping");

                entity.Property(e => e.CustomFieldMappingId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customFieldMappingId");

                entity.Property(e => e.CustomFieldDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customFieldDetailsId");

                entity.Property(e => e.CustomFieldMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customFieldMasterId");

                entity.Property(e => e.ProductId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productId");
            });

            modelBuilder.Entity<TblCustomFieldsSearchingDetail>(entity =>
            {
                entity.HasKey(e => e.CustomFieldDetailsId);

                entity.ToTable("tbl_CustomFieldsSearchingDetails");

                entity.Property(e => e.CustomFieldDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customFieldDetailsId");

                entity.Property(e => e.CustomFieldMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customFieldMasterId");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<TblCustomFieldsSearchingMaster>(entity =>
            {
                entity.HasKey(e => e.CustomFieldMasterId);

                entity.ToTable("tbl_CustomFieldsSearchingMaster");

                entity.Property(e => e.CustomFieldMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customFieldMasterId");

                entity.Property(e => e.CustomerFieldName)
                    .HasMaxLength(50)
                    .HasColumnName("customerFieldName");

                entity.Property(e => e.SelectionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("selectionType");
            });

            modelBuilder.Entity<TblCustomReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_CustomReports");

                entity.Property(e => e.CaseId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("caseID");

                entity.Property(e => e.TestName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCustomSaleReturnDetail>(entity =>
            {
                entity.HasKey(e => e.CustomSaleReturnDetailsId);

                entity.ToTable("tbl_CustomSaleReturnDetails");

                entity.Property(e => e.CustomSaleReturnDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customSaleReturnDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.CustomSaleReturnId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customSaleReturnId");

                entity.Property(e => e.Deduction)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("deduction");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.ReturnQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("returnQty");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblCustomSaleReturnMaster>(entity =>
            {
                entity.HasKey(e => e.CustomSaleReturnId);

                entity.ToTable("tbl_CustomSaleReturnMaster");

                entity.Property(e => e.CustomSaleReturnId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customSaleReturnId");

                entity.Property(e => e.BalanceDue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("balanceDue");

                entity.Property(e => e.CustomSaleReturnNarration).HasColumnName("customSaleReturnNarration");

                entity.Property(e => e.CustomSaleReturnNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customSaleReturnNo");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerId");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DownPayment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("downPayment");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.ShiftUserid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("shiftUserid");

                entity.Property(e => e.Shiftid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("shiftid");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<TblCustomerAttendance>(entity =>
            {
                entity.HasKey(e => e.AttendanceId);

                entity.ToTable("tbl_CustomerAttendance");

                entity.Property(e => e.AttendanceId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AttendanceDate).HasColumnType("date");

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.IsPresent).HasColumnName("isPresent");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.Minutes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.Seconds).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblCustomerBalance>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK_tbl_CustomerPayments");

                entity.ToTable("tbl_CustomerBalances");

                entity.Property(e => e.TransactionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("transactionId");

                entity.Property(e => e.Balance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("balance");

                entity.Property(e => e.Credit)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("credit");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerCode");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Debit)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("debit");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblCustomerDiscountPercentage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_CustomerDiscountPercentage");

                entity.Property(e => e.DiscountType).HasColumnName("discountType");

                entity.Property(e => e.Discountvalue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountvalue");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.ValueType).HasColumnName("valueType");
            });

            modelBuilder.Entity<TblCustomerGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("tblCustomerGroup");

                entity.Property(e => e.GroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("GroupID");

                entity.Property(e => e.Descp)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCustomerPrevDiscount>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.ProductCode, e.Uomid });

                entity.ToTable("tbl_CustomerPrevDiscounts");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerId");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.Uomname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblCustomerRegistrationRequest>(entity =>
            {
                entity.HasKey(e => e.RegistrationRequestId);

                entity.ToTable("tbl_CustomerRegistrationRequest");

                entity.Property(e => e.RegistrationRequestId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("registrationRequestId");

                entity.Property(e => e.BalanceDue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("balanceDue");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerId");

                entity.Property(e => e.DownPayment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("downPayment");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.LetterId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegistrationRequestDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registrationRequestDate");

                entity.Property(e => e.RegistrationRequestNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("registrationRequestNo");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<TblCustomerSubAccount>(entity =>
            {
                entity.HasKey(e => e.CustomerSubAccountId);

                entity.ToTable("tbl_CustomerSubAccounts");

                entity.Property(e => e.CustomerSubAccountId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerSubAccountId");

                entity.Property(e => e.AccountGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("accountGroupId");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<TblDealsDetail>(entity =>
            {
                entity.HasKey(e => e.DealsDetailsId);

                entity.ToTable("tbl_DealsDetails");

                entity.Property(e => e.DealsDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dealsDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.DealsMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dealsMasterId");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("quantity");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblDealsMaster>(entity =>
            {
                entity.HasKey(e => e.DealsMasterId);

                entity.ToTable("tbl_DealsMaster");

                entity.Property(e => e.DealsMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dealsMasterId");

                entity.Property(e => e.AverageCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageCost");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.DealCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dealCode");

                entity.Property(e => e.DealName).HasColumnName("dealName");

                entity.Property(e => e.DealPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("dealPrice");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.DocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("documentDate");

                entity.Property(e => e.Expenses)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("expenses");

                entity.Property(e => e.GroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("groupId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsKotitem).HasColumnName("isKOTItem");

                entity.Property(e => e.IsSaleItem).HasColumnName("isSaleItem");

                entity.Property(e => e.IsTaxable).HasColumnName("isTaxable");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.TotalDealCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDealCost");
            });

            modelBuilder.Entity<TblDefault>(entity =>
            {
                entity.ToTable("tbl_Default");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Defaultpreviliges)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDefault1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Defaults");

                entity.Property(e => e.Currentdate)
                    .HasColumnType("date")
                    .HasColumnName("currentdate");

                entity.Property(e => e.Skin)
                    .IsUnicode(false)
                    .HasColumnName("skin");

                entity.Property(e => e.Timezone).HasColumnName("timezone");
            });

            modelBuilder.Entity<TblDefaultWpfImage>(entity =>
            {
                entity.HasKey(e => e.DefaultImageId);

                entity.ToTable("tbl_DefaultWpfImage");

                entity.Property(e => e.DefaultImageId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("defaultImageId");

                entity.Property(e => e.DefaultWpfImage)
                    .HasColumnType("image")
                    .HasColumnName("defaultWpfImage");
            });

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("tbl_department");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("departmentId");

                entity.Property(e => e.Abbrevation)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .HasColumnName("departmentName");

                entity.Property(e => e.EmployeeCategoryId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employeeCategoryId");

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblDepartmentLedgerMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_DepartmentLedgerMapping");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("departmentId");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.MappingId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("mappingId");
            });

            modelBuilder.Entity<TblDepartmentPrinterMapping>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("tbl_DepartmentPrinterMapping");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("departmentId");

                entity.Property(e => e.Printer).HasColumnName("printer");
            });

            modelBuilder.Entity<TblDesignation>(entity =>
            {
                entity.HasKey(e => e.DesignationId)
                    .HasName("PK__tbl_Desi__197CE32A30C33EC3");

                entity.ToTable("tbl_Designation");

                entity.Property(e => e.DesignationId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("designationId");

                entity.Property(e => e.AdvanceAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("advanceAmount");

                entity.Property(e => e.DesignationName)
                    .IsUnicode(false)
                    .HasColumnName("designationName");

                entity.Property(e => e.Enableshift).HasColumnName("enableshift");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.IsServiceProvider).HasColumnName("isServiceProvider");

                entity.Property(e => e.LeaveDays)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("leaveDays");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblDesignationMappingWithPayScaleDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_DesignationMappingWithPayScaleDetail");

                entity.Property(e => e.AppliedRoleId).HasColumnName("AppliedRoleID");

                entity.Property(e => e.MappingPayScaleId).HasColumnName("MappingPayScaleID");
            });

            modelBuilder.Entity<TblDesignationMappingWithPayScaleMaster>(entity =>
            {
                entity.HasKey(e => e.MappingPayScaleId);

                entity.ToTable("tbl_DesignationMappingWithPayScaleMaster");

                entity.Property(e => e.MappingPayScaleId)
                    .ValueGeneratedNever()
                    .HasColumnName("MappingPayScaleID");

                entity.Property(e => e.PayscaleId).HasColumnName("PayscaleID");
            });

            modelBuilder.Entity<TblDesignationMappingWithRoleDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_DesignationMappingWithRoleDetail");

                entity.Property(e => e.AppliedRoleId).HasColumnName("AppliedRoleID");

                entity.Property(e => e.MappingRoleId).HasColumnName("MappingRoleID");
            });

            modelBuilder.Entity<TblDesignationMappingWithRoleMaster>(entity =>
            {
                entity.HasKey(e => e.MappingRoleId)
                    .HasName("PK_tbl_designationMappingWithRole");

                entity.ToTable("tbl_DesignationMappingWithRoleMaster");

                entity.Property(e => e.MappingRoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("MappingRoleID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            });

            modelBuilder.Entity<TblDishCategory>(entity =>
            {
                entity.HasKey(e => e.DishCategoryId);

                entity.ToTable("tbl_DishCategory");

                entity.Property(e => e.DishCategoryId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dishCategoryId");

                entity.Property(e => e.CategoryName).HasColumnName("categoryName");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblDishesDetail>(entity =>
            {
                entity.HasKey(e => e.DishDetailsId);

                entity.ToTable("tbl_DishesDetails");

                entity.Property(e => e.DishDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dishDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.Calories)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("calories");

                entity.Property(e => e.DishMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dishMasterId");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.PurchasePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchasePrice");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("salePrice");

                entity.Property(e => e.Topping).HasColumnName("topping");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblDishesMaster>(entity =>
            {
                entity.HasKey(e => e.DishMasterId);

                entity.ToTable("tbl_DishesMaster");

                entity.Property(e => e.DishMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dishMasterId");

                entity.Property(e => e.AverageCostPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageCostPrice");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.DefaultUomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("defaultUOMId");

                entity.Property(e => e.DishCategoryId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dishCategoryId");

                entity.Property(e => e.DishCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dishCode");

                entity.Property(e => e.DishName).HasColumnName("dishName");

                entity.Property(e => e.Expenses)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("expenses");

                entity.Property(e => e.GroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("groupId");

                entity.Property(e => e.Guide)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("guide");

                entity.Property(e => e.IngredientsCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ingredientsCost");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsKotitem).HasColumnName("isKOTItem");

                entity.Property(e => e.IsSaleItem).HasColumnName("isSaleItem");

                entity.Property(e => e.IsTaxable).HasColumnName("isTaxable");

                entity.Property(e => e.Ismultipleunit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ismultipleunit");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.SaleRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saleRate");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.UomgroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMGroupId");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");
            });

            modelBuilder.Entity<TblDocter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Docter");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocterId).HasColumnName("Docter_ID");

                entity.Property(e => e.DocterName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Docter_Name");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Mobile_No");
            });

            modelBuilder.Entity<TblDosage>(entity =>
            {
                entity.HasKey(e => e.DosageId);

                entity.ToTable("tbl_Dosages");

                entity.Property(e => e.DosageId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dosageId");

                entity.Property(e => e.DosageName).HasColumnName("dosageName");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblDraftBulkProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_DraftBulkProducts");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.BrandId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DefaultUom)
                    .HasMaxLength(50)
                    .HasColumnName("DefaultUOM");

                entity.Property(e => e.DefaultUomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DefaultUOMId");

                entity.Property(e => e.MultiUom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MultiUOM");

                entity.Property(e => e.MultiUomtype)
                    .HasMaxLength(100)
                    .HasColumnName("MultiUOMType");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductGroup).HasMaxLength(50);

                entity.Property(e => e.ProductGroupId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ProductId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Uom1id)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOM1Id");

                entity.Property(e => e.Uom1idReorderLevel)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("UOM1IdReorderLevel");

                entity.Property(e => e.Uom1name)
                    .HasMaxLength(50)
                    .HasColumnName("UOM1Name");

                entity.Property(e => e.Uom1pp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("UOM1PP");

                entity.Property(e => e.Uom1sp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("UOM1SP");

                entity.Property(e => e.Uom2id)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOM2Id");

                entity.Property(e => e.Uom2idReorderLevel)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("UOM2IdReorderLevel");

                entity.Property(e => e.Uom2name)
                    .HasMaxLength(50)
                    .HasColumnName("UOM2Name");

                entity.Property(e => e.Uom2pp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("UOM2PP");

                entity.Property(e => e.Uom2sp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("UOM2SP");

                entity.Property(e => e.Uom3id)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOM3Id");

                entity.Property(e => e.Uom3idReorderLevel)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("UOM3IdReorderLevel");

                entity.Property(e => e.Uom3name)
                    .HasMaxLength(50)
                    .HasColumnName("UOM3Name");

                entity.Property(e => e.Uom3pp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("UOM3PP");

                entity.Property(e => e.Uom3sp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("UOM3SP");

                entity.Property(e => e.Uom4id)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOM4Id");

                entity.Property(e => e.Uom4idReorderLevel)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("UOM4IdReorderLevel");

                entity.Property(e => e.Uom4name)
                    .HasMaxLength(50)
                    .HasColumnName("UOM4Name");

                entity.Property(e => e.Uom4pp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("UOM4PP");

                entity.Property(e => e.Uom4sp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("UOM4SP");

                entity.Property(e => e.Uom5id)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOM5Id");

                entity.Property(e => e.Uom5idReorderLevel)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("UOM5IdReorderLevel");

                entity.Property(e => e.Uom5name)
                    .HasMaxLength(50)
                    .HasColumnName("UOM5Name");

                entity.Property(e => e.Uom5pp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("UOM5PP");

                entity.Property(e => e.Uom5sp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("UOM5SP");

                entity.Property(e => e.Uomgroup)
                    .HasMaxLength(50)
                    .HasColumnName("UOMGroup");

                entity.Property(e => e.UomgroupDefinition)
                    .HasMaxLength(50)
                    .HasColumnName("UOMGroupDefinition");

                entity.Property(e => e.UomgroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMGroupId");
            });

            modelBuilder.Entity<TblDutyShift>(entity =>
            {
                entity.HasKey(e => e.ShiftId)
                    .HasName("PK_DutyShifts");

                entity.ToTable("tbl_DutyShifts");

                entity.Property(e => e.ShiftId).ValueGeneratedNever();

                entity.Property(e => e.Narration).IsUnicode(false);

                entity.Property(e => e.ShiftFrom).HasColumnName("Shift_From");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Shift_Name");

                entity.Property(e => e.ShiftNature)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Shift_Nature");

                entity.Property(e => e.ShiftStart)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Shift_Start");
            });

            modelBuilder.Entity<TblDynamicReportDetail>(entity =>
            {
                entity.ToTable("tbl_DynamicReportDetails");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.MasterId).HasColumnName("masterID");

                entity.Property(e => e.ParameterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDynamicReportMaster>(entity =>
            {
                entity.ToTable("tbl_DynamicReportMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Header).HasColumnName("header");

                entity.Property(e => e.ProcedureName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReportHeader)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReportName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeperatorValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialPerson).HasColumnName("specialPerson");

                entity.Property(e => e.SpecialPersonName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEattachmentsDetail>(entity =>
            {
                entity.HasKey(e => e.VoucherAttachmentDetailsId)
                    .HasName("PK_tbl_EAttachmentsDetails_1");

                entity.ToTable("tbl_EAttachmentsDetails");

                entity.Property(e => e.VoucherAttachmentDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherAttachmentDetailsId");

                entity.Property(e => e.Extenstion)
                    .HasMaxLength(50)
                    .HasColumnName("extenstion");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.FileName).HasColumnName("fileName");

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fileType");

                entity.Property(e => e.Path).HasColumnName("path");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.VoucherAttachmentMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherAttachmentMasterId");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voucherNo");
            });

            modelBuilder.Entity<TblEattachmentsMaster>(entity =>
            {
                entity.HasKey(e => e.VoucherAttachmentMasterId);

                entity.ToTable("tbl_EAttachmentsMaster");

                entity.Property(e => e.VoucherAttachmentMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherAttachmentMasterId");

                entity.Property(e => e.AttachmentType)
                    .HasMaxLength(50)
                    .HasColumnName("attachmentType");

                entity.Property(e => e.Attachmentdate)
                    .HasColumnType("datetime")
                    .HasColumnName("attachmentdate");

                entity.Property(e => e.Blno)
                    .HasMaxLength(50)
                    .HasColumnName("BLNo");

                entity.Property(e => e.Etd)
                    .HasMaxLength(50)
                    .HasColumnName("ETD");

                entity.Property(e => e.Pino)
                    .HasMaxLength(50)
                    .HasColumnName("PINo");

                entity.Property(e => e.Pono)
                    .HasMaxLength(50)
                    .HasColumnName("PONo");

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.TrackingNo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblEducationalLevel>(entity =>
            {
                entity.HasKey(e => e.EducationLevelId);

                entity.ToTable("tbl_EducationalLevel");

                entity.Property(e => e.EducationLevelId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("educationLevelId");

                entity.Property(e => e.EducationLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("educationLevel");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblEducationalLevelStatus>(entity =>
            {
                entity.HasKey(e => e.EducationalLevelStatusId);

                entity.ToTable("tbl_educationalLevelStatus");

                entity.Property(e => e.EducationalLevelStatusId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("educationalLevelStatusId");

                entity.Property(e => e.EducationalLevelStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("educationalLevelStatus");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblEmailCompose>(entity =>
            {
                entity.ToTable("tbl_EmailCompose");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmailGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SentTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblEmailComposeAttachment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_EmailComposeAttachment");

                entity.Property(e => e.Attachment).IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.SentTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmailpending>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Emailpending");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmailGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SentTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblEmpImage>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("tbl_EmpImages");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.EmpImage)
                    .HasColumnType("image")
                    .HasColumnName("empImage");
            });

            modelBuilder.Entity<TblEmpMiscDetail>(entity =>
            {
                entity.HasKey(e => e.EmpMiscDetailsId)
                    .HasName("PK_tbl_EmpMiscDetails_1");

                entity.ToTable("tbl_EmpMiscDetails");

                entity.Property(e => e.EmpMiscDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("empMiscDetailsId");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.EmpRegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empRegNo");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<TblEmpMiscDetailsType>(entity =>
            {
                entity.HasKey(e => e.MiscDetailsTypeId)
                    .HasName("PK_tbl_EmpMiscDetails");

                entity.ToTable("tbl_EmpMiscDetailsType");

                entity.Property(e => e.MiscDetailsTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("miscDetailsTypeId");

                entity.Property(e => e.AttachmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("attachmentType");

                entity.Property(e => e.MiscDetailsType)
                    .IsUnicode(false)
                    .HasColumnName("miscDetailsType");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblEmpRelation>(entity =>
            {
                entity.HasKey(e => e.RelationId);

                entity.ToTable("tbl_EmpRelation");

                entity.Property(e => e.RelationId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("relationId");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.RelationName)
                    .IsUnicode(false)
                    .HasColumnName("relationName");
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__tbl_Empl__C134C9C125518C17");

                entity.ToTable("tbl_Employee");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("employeeId");

                entity.Property(e => e.Address)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.BankAccountNumber)
                    .IsUnicode(false)
                    .HasColumnName("bankAccountNumber");

                entity.Property(e => e.BankName)
                    .IsUnicode(false)
                    .HasColumnName("bankName");

                entity.Property(e => e.BloodGroup)
                    .IsUnicode(false)
                    .HasColumnName("bloodGroup");

                entity.Property(e => e.BranchCode)
                    .IsUnicode(false)
                    .HasColumnName("branchCode");

                entity.Property(e => e.BranchName)
                    .IsUnicode(false)
                    .HasColumnName("branchName");

                entity.Property(e => e.DailyWage)
                    .HasColumnType("numeric(18, 5)")
                    .HasColumnName("dailyWage");

                entity.Property(e => e.DefaultPackageId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("defaultPackageId");

                entity.Property(e => e.DesignationId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("designationId");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmployeeCode)
                    .IsUnicode(false)
                    .HasColumnName("employeeCode");

                entity.Property(e => e.EmployeeName)
                    .IsUnicode(false)
                    .HasColumnName("employeeName");

                entity.Property(e => e.EsiNumber)
                    .IsUnicode(false)
                    .HasColumnName("esiNumber");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.Gender)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.JoiningDate)
                    .HasColumnType("datetime")
                    .HasColumnName("joiningDate");

                entity.Property(e => e.LabourCardExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("labourCardExpiryDate");

                entity.Property(e => e.LabourCardNumber)
                    .IsUnicode(false)
                    .HasColumnName("labourCardNumber");

                entity.Property(e => e.MaritalStatus)
                    .IsUnicode(false)
                    .HasColumnName("maritalStatus");

                entity.Property(e => e.MobileNumber)
                    .IsUnicode(false)
                    .HasColumnName("mobileNumber");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.PanNumber)
                    .IsUnicode(false)
                    .HasColumnName("panNumber");

                entity.Property(e => e.PassportExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("passportExpiryDate");

                entity.Property(e => e.PassportNo)
                    .IsUnicode(false)
                    .HasColumnName("passportNo");

                entity.Property(e => e.PfNumber)
                    .IsUnicode(false)
                    .HasColumnName("pfNumber");

                entity.Property(e => e.PhoneNumber)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.Qualification)
                    .IsUnicode(false)
                    .HasColumnName("qualification");

                entity.Property(e => e.SalaryType)
                    .IsUnicode(false)
                    .HasColumnName("salaryType");

                entity.Property(e => e.TerminationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("terminationDate");

                entity.Property(e => e.VisaExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("visaExpiryDate");

                entity.Property(e => e.VisaNumber)
                    .IsUnicode(false)
                    .HasColumnName("visaNumber");
            });

            modelBuilder.Entity<TblEmployeeAttendance>(entity =>
            {
                entity.HasKey(e => e.AttendanceId);

                entity.ToTable("tbl_EmployeeAttendance");

                entity.Property(e => e.AttendanceId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AttendanceDate).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeId");

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InTime).HasColumnType("datetime");

                entity.Property(e => e.IsPresent).HasColumnName("isPresent");

                entity.Property(e => e.Minutes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OutTime).HasColumnType("datetime");

                entity.Property(e => e.Seconds).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblEmployeeCategory>(entity =>
            {
                entity.HasKey(e => e.EmployeeCategoryId);

                entity.ToTable("tbl_EmployeeCategory");

                entity.Property(e => e.EmployeeCategoryId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("employeeCategoryId");

                entity.Property(e => e.AllocateNonRevenueItems).HasColumnName("allocateNonRevenueItems");

                entity.Property(e => e.AllocateRevenueItems).HasColumnName("allocateRevenueItems");

                entity.Property(e => e.EmployeeCategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employeeCategoryName");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblEmployeeCommisionDetail>(entity =>
            {
                entity.HasKey(e => e.EmployeeCommissionDetailsId);

                entity.ToTable("tbl_EmployeeCommisionDetails");

                entity.Property(e => e.EmployeeCommissionDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeCommissionDetailsId");

                entity.Property(e => e.AcheivedAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("acheivedAmount");

                entity.Property(e => e.BonusAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bonusAmount");

                entity.Property(e => e.BonusType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bonusType");

                entity.Property(e => e.BonusValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bonusValue");

                entity.Property(e => e.EmployeeCommissionMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeCommissionMasterId");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.Target)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("target");
            });

            modelBuilder.Entity<TblEmployeeCommisionMaster>(entity =>
            {
                entity.HasKey(e => e.EmployeeCommissionMasterId)
                    .HasName("PK_tbl_EmployeeCommision");

                entity.ToTable("tbl_EmployeeCommisionMaster");

                entity.Property(e => e.EmployeeCommissionMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeCommissionMasterId");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("dateFrom");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("dateTo");

                entity.Property(e => e.DocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("documentDate");

                entity.Property(e => e.EmployeeCommissionNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employeeCommissionNo");
            });

            modelBuilder.Entity<TblEmployeeGatepass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_EmployeeGatepass");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.EmployeeGatepassId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeGatepassId");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employeeName");

                entity.Property(e => e.EmployewGatepassNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employewGatepassNo");

                entity.Property(e => e.Passtype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("passtype");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purpose");

                entity.Property(e => e.Reason)
                    .IsUnicode(false)
                    .HasColumnName("reason");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.ShiftId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("shiftId");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.VehicleNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vehicleNo");

                entity.Property(e => e.VehicleType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vehicleType");
            });

            modelBuilder.Entity<TblEpurchaseOrderDetail>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrderDetailsId);

                entity.ToTable("tbl_EPurchaseOrderDetails");

                entity.Property(e => e.PurchaseOrderDetailsId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductBarcode).HasMaxLength(50);

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.PurchaseOrderMasterId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Unit1Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Unit2Id).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TblEpurchaseOrderMaster>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrderMasterId);

                entity.ToTable("tbl_EPurchaseOrderMaster");

                entity.Property(e => e.PurchaseOrderMasterId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BalanceDue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ContractDate).HasColumnType("datetime");

                entity.Property(e => e.ContractNo).HasMaxLength(50);

                entity.Property(e => e.CurrencyId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DownPayment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Extra1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Extra2).HasColumnType("date");

                entity.Property(e => e.ExtraDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NoOfFcl)
                    .HasMaxLength(50)
                    .HasColumnName("NoOfFCL");

                entity.Property(e => e.PortOfDischarge).HasMaxLength(200);

                entity.Property(e => e.PortOfLanding).HasMaxLength(200);

                entity.Property(e => e.PurchaseOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.SupplierId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotalCif)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TotalCIF");

                entity.Property(e => e.TotalFob)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TotalFOB");

                entity.Property(e => e.TotalFreight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalInsurance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TypeOfFcl)
                    .HasMaxLength(50)
                    .HasColumnName("TypeOfFCL");
            });

            modelBuilder.Entity<TblEvaluationType>(entity =>
            {
                entity.HasKey(e => e.EvaluationTypeId);

                entity.ToTable("tbl_EvaluationType");

                entity.Property(e => e.EvaluationTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("evaluationTypeId");

                entity.Property(e => e.EvaluationTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("evaluationTypeName");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblExchangeRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_ExchangeRate");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("currencyId");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.ExchangeRateId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("exchangeRateId");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");
            });

            modelBuilder.Entity<TblExtraBarcode>(entity =>
            {
                entity.HasKey(e => e.ExtraBarcodeId)
                    .HasName("PK__tbl_Extr__059BA3D9E4146BC9");

                entity.ToTable("tbl_ExtraBarcodes");

                entity.Property(e => e.ExtraBarcodeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("extraBarcodeId");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");
            });

            modelBuilder.Entity<TblFacility>(entity =>
            {
                entity.HasKey(e => e.FacilityId);

                entity.ToTable("tbl_Facility");

                entity.Property(e => e.FacilityId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("facilityId");

                entity.Property(e => e.FacilityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("facilityName");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.WorthInFigures)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("worthInFigures");
            });

            modelBuilder.Entity<TblFacilityMappingWithHead>(entity =>
            {
                entity.HasKey(e => e.FacilityMappingId);

                entity.ToTable("tbl_FacilityMappingWithHeads");

                entity.Property(e => e.FacilityMappingId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("facilityMappingId");

                entity.Property(e => e.AllowanceId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("allowanceId");

                entity.Property(e => e.Condition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("condition");

                entity.Property(e => e.FacilityId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("facilityId");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblFbrintegration>(entity =>
            {
                entity.ToTable("tbl_fbrintegration");

                entity.Property(e => e.Five)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Four)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.One)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Six)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Three)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Two)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFinancialYear>(entity =>
            {
                entity.HasKey(e => e.FinancialYearId)
                    .HasName("PK__tbl_Fina__FE30A41137661AB1");

                entity.ToTable("tbl_FinancialYear");

                entity.Property(e => e.FinancialYearId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("financialYearId");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.FromDate)
                    .HasColumnType("date")
                    .HasColumnName("fromDate");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ToDate)
                    .HasColumnType("date")
                    .HasColumnName("toDate");
            });

            modelBuilder.Entity<TblFinger>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Finger");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LedgerId).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TblFloor>(entity =>
            {
                entity.HasKey(e => e.FloorId);

                entity.ToTable("tbl_Floors");

                entity.Property(e => e.FloorId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("floorId");

                entity.Property(e => e.FloorName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("floorName");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblForm>(entity =>
            {
                entity.HasKey(e => e.FormName);

                entity.ToTable("tbl_Forms");

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormText).IsUnicode(false);

                entity.Property(e => e.Shortcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("shortcode");
            });

            modelBuilder.Entity<TblFormForPrevilidge>(entity =>
            {
                entity.ToTable("tbl_FormForPrevilidges");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFormInsideButtonRight>(entity =>
            {
                entity.ToTable("tbl_FormInsideButtonRights");

                entity.Property(e => e.FormName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblGatePass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_GatePass");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("companyId");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.DosraWasan)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("dosraWasan");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.GatepassId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("gatepassId");

                entity.Property(e => e.GatepassNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gatepassNo");

                entity.Property(e => e.PehlaWasan)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("pehlaWasan");

                entity.Property(e => e.SafiWasan).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.ShiftId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("shiftId");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.VehicleNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vehicleNo");

                entity.Property(e => e.VehicleType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vehicleType");
            });

            modelBuilder.Entity<TblGeneralPolicy>(entity =>
            {
                entity.HasKey(e => e.GeneralPolicyId);

                entity.ToTable("tbl_GeneralPolicy");

                entity.Property(e => e.GeneralPolicyId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DesignationId).HasColumnName("designationId");

                entity.Property(e => e.FullDayUnit).HasMaxLength(50);

                entity.Property(e => e.GeneralPolicyCode).HasMaxLength(50);

                entity.Property(e => e.HalfDayUnit).HasMaxLength(50);

                entity.Property(e => e.MonthlyUnit).HasMaxLength(50);

                entity.Property(e => e.PaidAbsentsUnit).HasMaxLength(50);

                entity.Property(e => e.PaidLeavesUnit).HasMaxLength(50);

                entity.Property(e => e.UnPaidAbsentsUnit).HasMaxLength(50);

                entity.Property(e => e.UnPaidLeavesUnit).HasMaxLength(50);

                entity.Property(e => e.WeeklyUnit).HasMaxLength(50);
            });

            modelBuilder.Entity<TblGeneralPrescriptionRadioOption>(entity =>
            {
                entity.HasKey(e => e.PrescriptionId);

                entity.ToTable("tbl_GeneralPrescriptionRadioOptions");

                entity.Property(e => e.PrescriptionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("prescriptionId");

                entity.Property(e => e.Cnsexamination)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNSExamination");

                entity.Property(e => e.Cvsexamination)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CVSExamination");

                entity.Property(e => e.GeneralUrinaryExamination)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gitexamination)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GITExamination");

                entity.Property(e => e.RespirationExamination)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RheumatologicalExamination)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SystematicExamination)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("systematicExamination");

                entity.Property(e => e.ThyroidExamination)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGeneralSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_GeneralSettings");

                entity.Property(e => e.BillDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("billDiscount");

                entity.Property(e => e.Branding).HasColumnName("branding");

                entity.Property(e => e.CalculateProfitBasedOn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationFeePercentage)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomName1)
                    .HasMaxLength(50)
                    .HasColumnName("customName1");

                entity.Property(e => e.CustomName2)
                    .HasMaxLength(50)
                    .HasColumnName("customName2");

                entity.Property(e => e.CustomName3)
                    .HasMaxLength(50)
                    .HasColumnName("customName3");

                entity.Property(e => e.CustomUnitFormName).HasMaxLength(50);

                entity.Property(e => e.DefaultBarcodePrinter).HasColumnName("defaultBarcodePrinter");

                entity.Property(e => e.DefaultCurrencyId).HasColumnName("defaultCurrencyId");

                entity.Property(e => e.DefaultCustomerGroup)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("defaultCustomerGroup");

                entity.Property(e => e.DefaultImagePath)
                    .IsUnicode(false)
                    .HasColumnName("defaultImagePath");

                entity.Property(e => e.DefaultMop).HasColumnName("defaultMOP");

                entity.Property(e => e.DefaultMultiUom)
                    .HasMaxLength(50)
                    .HasColumnName("defaultMultiUOM");

                entity.Property(e => e.DefaultMultiUomtype)
                    .HasMaxLength(50)
                    .HasColumnName("defaultMultiUOMType");

                entity.Property(e => e.DefaultPaperSize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("defaultPaperSize");

                entity.Property(e => e.DefaultSaleInvoiceSearchOption)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("defaultSaleInvoiceSearchOption");

                entity.Property(e => e.DefaultSmsSendingDevice)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("defaultSmsSendingDevice");

                entity.Property(e => e.DefaultSticker).HasColumnName("defaultSticker");

                entity.Property(e => e.DefaultpricingLevelId).HasColumnName("defaultpricingLevelId");

                entity.Property(e => e.DepartureTime).HasMaxLength(50);

                entity.Property(e => e.DueDateAfterDays)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dueDateAfterDays");

                entity.Property(e => e.EnableAdditionalColumns).HasColumnName("enableAdditionalColumns");

                entity.Property(e => e.EnableAutoSmsSender).HasColumnName("enableAutoSmsSender");

                entity.Property(e => e.EnableCalender).HasColumnName("enableCalender");

                entity.Property(e => e.EnableDefaultPrint).HasColumnName("enableDefaultPrint");

                entity.Property(e => e.EnableDummyInvoice).HasColumnName("enableDummyInvoice");

                entity.Property(e => e.EnableInstallments).HasColumnName("enableInstallments");

                entity.Property(e => e.EnableMaintainDiscOnTp).HasColumnName("enableMaintainDiscOnTP");

                entity.Property(e => e.EnableMembership).HasColumnName("enableMembership");

                entity.Property(e => e.EnableMultiBaseUomsystem).HasColumnName("enableMultiBaseUOMSystem");

                entity.Property(e => e.EnableMultipleUom).HasColumnName("enableMultipleUOM");

                entity.Property(e => e.EnablePromotions).HasColumnName("enablePromotions");

                entity.Property(e => e.EnablePurchasePriceChangeInPi).HasColumnName("enablePurchasePriceChangeInPI");

                entity.Property(e => e.EnableReminder).HasColumnName("enableReminder");

                entity.Property(e => e.EnableSalePriceChangeOnPi).HasColumnName("enableSalePriceChangeOnPI");

                entity.Property(e => e.EnableSalePriceChangeOnSi).HasColumnName("enableSalePriceChangeOnSI");

                entity.Property(e => e.EnableSmallReceipt).HasColumnName("enableSmallReceipt");

                entity.Property(e => e.EnableStages).HasColumnName("enableStages");

                entity.Property(e => e.EnableTpvalue).HasColumnName("enableTPValue");

                entity.Property(e => e.EnableWarrantySystem).HasColumnName("enableWarrantySystem");

                entity.Property(e => e.ExpiryBeforeDays)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("expiryBeforeDays");

                entity.Property(e => e.GenerateOpdticketWrtDoc).HasColumnName("GenerateOPDTicketWrtDoc");

                entity.Property(e => e.HrmdataRestrictions).HasColumnName("HRMDataRestrictions");

                entity.Property(e => e.InventorySettings)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inventorySettings");

                entity.Property(e => e.InvoiceBeforeDays)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("invoiceBeforeDays");

                entity.Property(e => e.InvoiceTemplate).HasMaxLength(50);

                entity.Property(e => e.KotprintType)
                    .HasMaxLength(50)
                    .HasColumnName("KOTPrintType");

                entity.Property(e => e.LoadPrevDiscOnSi).HasColumnName("loadPrevDiscOnSI");

                entity.Property(e => e.Multicurrency).HasColumnName("multicurrency");

                entity.Property(e => e.NoOfDefaultProducts)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("noOfDefaultProducts");

                entity.Property(e => e.NoOfPrintOuts)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pkrfunction).HasColumnName("PKRFunction");

                entity.Property(e => e.PrintBatchonInvoices).HasColumnName("printBatchonInvoices");

                entity.Property(e => e.PrintBonusQuantityInvoicesonInvoices).HasColumnName("printBonusQuantityInvoicesonInvoices");

                entity.Property(e => e.PrintExpiryonInvoices).HasColumnName("printExpiryonInvoices");

                entity.Property(e => e.PrintForEmployees).HasColumnName("printForEmployees");

                entity.Property(e => e.PrintLabelsOnPi).HasColumnName("printLabelsOnPI");

                entity.Property(e => e.PrintTickets).HasColumnName("printTickets");

                entity.Property(e => e.PrintWarrantyDetailsOnInvoices).HasColumnName("printWarrantyDetailsOnInvoices");

                entity.Property(e => e.PrinterForKitchen)
                    .IsUnicode(false)
                    .HasColumnName("printerForKitchen");

                entity.Property(e => e.PrinterForLargeInvoice)
                    .IsUnicode(false)
                    .HasColumnName("printerForLargeInvoice");

                entity.Property(e => e.PrinterForSmallInvoice)
                    .IsUnicode(false)
                    .HasColumnName("printerForSmallInvoice");

                entity.Property(e => e.ProductSorting)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productSorting");

                entity.Property(e => e.ProfitRptOnAvgPurCost).HasColumnName("profitRptOnAvgPurCost");

                entity.Property(e => e.PurchasePriceEditableInPi).HasColumnName("purchasePriceEditableInPI");

                entity.Property(e => e.ReportTitle).HasMaxLength(50);

                entity.Property(e => e.SalePriceEditableInSi).HasColumnName("salePriceEditableInSI");

                entity.Property(e => e.SaleSelection)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleSelection");

                entity.Property(e => e.SaveProductNames).HasColumnName("saveProductNames");

                entity.Property(e => e.SendOnSaleSms).HasColumnName("sendOnSaleSMS");

                entity.Property(e => e.SendSmsonInstallmentVoucher).HasColumnName("sendSMSonInstallmentVoucher");

                entity.Property(e => e.SendSmsonInstallmentVoucherRegister).HasColumnName("sendSMSonInstallmentVoucherRegister");

                entity.Property(e => e.SendSmsonPaymentVoucher).HasColumnName("sendSMSonPaymentVoucher");

                entity.Property(e => e.SendSmsonReceiptVoucher).HasColumnName("sendSMSonReceiptVoucher");

                entity.Property(e => e.ShowAdvancedSearchOnSi).HasColumnName("showAdvancedSearchOnSI");

                entity.Property(e => e.ShowAdvertisementVideo).HasColumnName("showAdvertisementVideo");

                entity.Property(e => e.ShowAvailableQty).HasColumnName("showAvailableQty");

                entity.Property(e => e.ShowBalance).HasColumnName("showBalance");

                entity.Property(e => e.ShowBarcodeOnSireport).HasColumnName("showBarcodeOnSIReport");

                entity.Property(e => e.ShowBatchOnSi).HasColumnName("showBatchOnSI");

                entity.Property(e => e.ShowBatchonInvoices).HasColumnName("showBatchonInvoices");

                entity.Property(e => e.ShowBonusQtyonInvoices).HasColumnName("showBonusQtyonInvoices");

                entity.Property(e => e.ShowBorrowedFromTo).HasColumnName("showBorrowedFromTo");

                entity.Property(e => e.ShowChequeDate).HasColumnName("showChequeDate");

                entity.Property(e => e.ShowChequeNo).HasColumnName("showChequeNo");

                entity.Property(e => e.ShowDisandHideTax).HasColumnName("showDisandHideTax");

                entity.Property(e => e.ShowDiscountOnInvoices).HasColumnName("showDiscountOnInvoices");

                entity.Property(e => e.ShowDiscountPercentageonInvoices).HasColumnName("showDiscountPercentageonInvoices");

                entity.Property(e => e.ShowExpiryOnSireport).HasColumnName("showExpiryOnSIReport");

                entity.Property(e => e.ShowExpiryonInvoices).HasColumnName("showExpiryonInvoices");

                entity.Property(e => e.ShowInoviceNo).HasColumnName("showInoviceNo");

                entity.Property(e => e.ShowInvoiceNoteOnInvoices).HasColumnName("showInvoiceNoteOnInvoices");

                entity.Property(e => e.ShowInvoicePertainsTo).HasColumnName("showInvoicePertainsTo");

                entity.Property(e => e.ShowIssueDate).HasColumnName("showIssueDate");

                entity.Property(e => e.ShowNarration).HasColumnName("showNarration");

                entity.Property(e => e.ShowNarrationOnInvoices).HasColumnName("showNarrationOnInvoices");

                entity.Property(e => e.ShowPaid).HasColumnName("showPaid");

                entity.Property(e => e.ShowPharmacySireport).HasColumnName("showPharmacySIReport");

                entity.Property(e => e.ShowPonoInPi).HasColumnName("showPONoInPI");

                entity.Property(e => e.ShowPrintName).HasColumnName("showPrintName");

                entity.Property(e => e.ShowProdCodeOnSireport).HasColumnName("showProdCodeOnSIReport");

                entity.Property(e => e.ShowPurchasePrice).HasColumnName("showPurchasePrice");

                entity.Property(e => e.ShowSelectCheque).HasColumnName("showSelectCheque");

                entity.Property(e => e.ShowSelectProject).HasColumnName("showSelectProject");

                entity.Property(e => e.ShowSmsnote).HasColumnName("showSMSNote");

                entity.Property(e => e.ShowStockTypeonPos)
                    .HasMaxLength(50)
                    .HasColumnName("showStockTypeonPOS");

                entity.Property(e => e.ShowTaxesOnInvoices).HasColumnName("showTaxesOnInvoices");

                entity.Property(e => e.ShowZeroStockProudcts).HasColumnName("showZeroStockProudcts");

                entity.Property(e => e.SmsNote).HasColumnName("smsNote");

                entity.Property(e => e.SpaerateGrnProcess).HasDefaultValueSql("((0))");

                entity.Property(e => e.TakeAutoBackup).HasColumnName("takeAutoBackup");

                entity.Property(e => e.ThermalPrintType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UomfieldType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOMFieldType");
            });

            modelBuilder.Entity<TblGodown>(entity =>
            {
                entity.HasKey(e => e.GodownId)
                    .HasName("PK__tbl_Godo__14F1AFAB51851410");

                entity.ToTable("tbl_Godown");

                entity.Property(e => e.GodownId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("godownId");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.GodownName)
                    .IsUnicode(false)
                    .HasColumnName("godownName");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblGodownLocationMappingDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_GodownLocationMappingDetails");

                entity.Property(e => e.GodownId).HasColumnName("godownId");

                entity.Property(e => e.LocationId).HasColumnName("locationId");
            });

            modelBuilder.Entity<TblGodownLocationMappingMaster>(entity =>
            {
                entity.ToTable("tbl_GodownLocationMappingMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.LocationId).HasColumnName("locationId");
            });

            modelBuilder.Entity<TblGodownPackingLog>(entity =>
            {
                entity.HasKey(e => e.GodownPackingLogId);

                entity.ToTable("tbl_GodownPackingLog");

                entity.Property(e => e.GodownPackingLogId).HasColumnName("godownPackingLogId");

                entity.Property(e => e.FromBatch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromExpiry).HasColumnType("date");

                entity.Property(e => e.FromGodownId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FromProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromQuantity).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FromUomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("FromUOMId");

                entity.Property(e => e.ToBatch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToExpiry).HasColumnType("date");

                entity.Property(e => e.ToGodownId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ToProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToQuantity).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ToUomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ToUOMId");
            });

            modelBuilder.Entity<TblGodownSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_GodownSettings");

                entity.Property(e => e.DefaultInventoryMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("defaultInventoryMethod");

                entity.Property(e => e.EnableExpiredBatchSale).HasColumnName("enableExpiredBatchSale");

                entity.Property(e => e.SaleBasedOnExpiry).HasColumnName("saleBasedOnExpiry");
            });

            modelBuilder.Entity<TblGodownStockDetail>(entity =>
            {
                entity.HasKey(e => e.GodownStockDetailsId);

                entity.ToTable("tbl_GodownStockDetails");

                entity.Property(e => e.GodownStockDetailsId).HasColumnName("godownStockDetailsId");

                entity.Property(e => e.Batch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batch");

                entity.Property(e => e.Expiry)
                    .HasColumnType("date")
                    .HasColumnName("expiry");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.Uomid).HasColumnName("UOMId");

                entity.Property(e => e.VoucherTypeId).HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblGodownStockManage>(entity =>
            {
                entity.HasKey(e => e.GodownManageId)
                    .HasName("PK_tbl_godownManage");

                entity.ToTable("tbl_godownStockManage");

                entity.Property(e => e.GodownManageId)
                    .ValueGeneratedNever()
                    .HasColumnName("godownManageId");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batchNo");

                entity.Property(e => e.Expiry)
                    .HasColumnType("date")
                    .HasColumnName("expiry");

                entity.Property(e => e.Extra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra");

                entity.Property(e => e.GodownId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("godownId");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");
            });

            modelBuilder.Entity<TblGodownStockManageLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_godownStockManageLog");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batchNo");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("date");

                entity.Property(e => e.Expiry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("expiry");

                entity.Property(e => e.GodownId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("godownId");

                entity.Property(e => e.InvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceId");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.Qty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("qty");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.Time)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("time");

                entity.Property(e => e.Uomid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOMId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.VoucherTypeId).HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblGoodsReceivedNoteAcLedger>(entity =>
            {
                entity.HasKey(e => e.GrnAcLedgerId);

                entity.ToTable("tbl_GoodsReceivedNoteAcLedger");

                entity.Property(e => e.GrnAcLedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("grnAcLedgerId");

                entity.Property(e => e.Credit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("credit");

                entity.Property(e => e.Debit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("debit");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voucherNo");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblGoodsReceivedNoteDetail>(entity =>
            {
                entity.HasKey(e => e.GrnDetailsId);

                entity.ToTable("tbl_GoodsReceivedNoteDetails");

                entity.Property(e => e.GrnDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("grnDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.BorrowedFromTo)
                    .HasMaxLength(50)
                    .HasColumnName("borrowedFromTo");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.GrnId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grnId");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.InvoicePertainsTo).HasColumnName("invoicePertainsTo");

                entity.Property(e => e.Paid)
                    .HasMaxLength(50)
                    .HasColumnName("paid");

                entity.Property(e => e.Prate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PRate");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("projectId");

                entity.Property(e => e.PurchaseInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseInvoiceId")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PurchaseOrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseOrderNo");

                entity.Property(e => e.PurchasePricePercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.Qtybalance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qtybalance");

                entity.Property(e => e.Qtyrceived)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qtyrceived");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");

                entity.Property(e => e.TradePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblGoodsReceivedNoteMaster>(entity =>
            {
                entity.HasKey(e => e.GrnId);

                entity.ToTable("tbl_GoodsReceivedNoteMaster");

                entity.Property(e => e.GrnId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grnId");

                entity.Property(e => e.BalanceDue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("balanceDue");

                entity.Property(e => e.Batch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batch");

                entity.Property(e => e.ChkBatchOnAll).HasColumnName("chkBatchOnAll");

                entity.Property(e => e.ChkExpiryOnAll).HasColumnName("chkExpiryOnAll");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("currencyId");

                entity.Property(e => e.DiscountAllowed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountAllowed");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .HasColumnName("dueDate");

                entity.Property(e => e.Expiry)
                    .HasColumnType("date")
                    .HasColumnName("expiry");

                entity.Property(e => e.Freight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("freight");

                entity.Property(e => e.GrnDeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("grnDeliveryDate");

                entity.Property(e => e.GrnDocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("grnDocumentDate");

                entity.Property(e => e.GrnNarration).HasColumnName("grnNarration");

                entity.Property(e => e.GrnNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grnNo");

                entity.Property(e => e.GrnPostingDate)
                    .HasColumnType("date")
                    .HasColumnName("grnPostingDate");

                entity.Property(e => e.GrnStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grnStatus");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.PurchaseInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseInvoiceId")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.ShipmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("shipmentId");

                entity.Property(e => e.ShippingAddress).HasColumnName("shippingAddress");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.SupplierId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("supplierId");

                entity.Property(e => e.SupplierRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplierRefNo");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.TotalDownPayment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDownPayment");

                entity.Property(e => e.Totaltax)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totaltax");

                entity.Property(e => e.VendorInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vendorInvoiceNo");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");

                entity.Property(e => e.WarehouseId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("warehouseId");
            });

            modelBuilder.Entity<TblGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("tbl_Group");

                entity.Property(e => e.GroupId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("groupId");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("groupName");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblGroupSm>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("tbl_GroupSMS");

                entity.Property(e => e.GroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("GroupID");

                entity.Property(e => e.ComposeSms).HasColumnName("ComposeSMS");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelectTemplate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblHoldWpfPosbillTaxesDatum>(entity =>
            {
                entity.HasKey(e => e.SaleBillTaxId);

                entity.ToTable("tbl_HoldWpfPOSBillTaxesData");

                entity.Property(e => e.SaleBillTaxId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("saleBillTaxId");

                entity.Property(e => e.DataTableNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceNo");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");
            });

            modelBuilder.Entity<TblHoldWpfPosdataMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_HoldWpfPOSDataMaster");

                entity.Property(e => e.Sajf)
                    .HasMaxLength(10)
                    .HasColumnName("sajf")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblHoldWpfPosdatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_HoldWpfPOSData");

                entity.Property(e => e.ActualQty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CookId).HasColumnName("cookId");

                entity.Property(e => e.CustomerName).HasColumnName("Customer_Name");

                entity.Property(e => e.DataTableNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DealId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrandTotal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Grand_Total");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsKotitem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("isKOTItem");

                entity.Property(e => e.Kot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KOT");

                entity.Property(e => e.Kotstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KOTStatus");

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Order_Type");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName).HasColumnName("Product_Name");

                entity.Property(e => e.Quantity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesmanId).HasColumnName("salesmanId");

                entity.Property(e => e.SalesmanName).HasColumnName("salesmanName");

                entity.Property(e => e.SubTotal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sub_Total");

                entity.Property(e => e.Table)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDiscount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Total_Discount");

                entity.Property(e => e.UnitPrice)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Unit_Price");

                entity.Property(e => e.Uomid).HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");

                entity.Property(e => e.WaiterName).HasColumnName("Waiter_Name");
            });

            modelBuilder.Entity<TblHoliday>(entity =>
            {
                entity.HasKey(e => e.HolidayId)
                    .HasName("PK__tbl_Holi__EB855CEF29221CFB");

                entity.ToTable("tbl_Holiday");

                entity.Property(e => e.HolidayId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("holidayId");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.HolidayName)
                    .IsUnicode(false)
                    .HasColumnName("holidayName");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Images");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("companyId");

                entity.Property(e => e.CompanyLogo)
                    .HasColumnType("image")
                    .HasColumnName("companyLogo");
            });

            modelBuilder.Entity<TblImagesPath>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_ImagesPaths");

                entity.Property(e => e.ImagesPath).IsUnicode(false);
            });

            modelBuilder.Entity<TblInstallment>(entity =>
            {
                entity.HasKey(e => e.InstallmentsId);

                entity.ToTable("tbl_Installments");

                entity.Property(e => e.InstallmentsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("installmentsId");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Installment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("installment");

                entity.Property(e => e.SalesInvoiceId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesInvoiceId");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TblInstallmentsDefinition>(entity =>
            {
                entity.HasKey(e => e.InstallmentDefinitionId);

                entity.ToTable("tbl_InstallmentsDefinition");

                entity.Property(e => e.InstallmentDefinitionId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Interest)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("interest");

                entity.Property(e => e.Period)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("period");

                entity.Property(e => e.PeriodType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("periodType");
            });

            modelBuilder.Entity<TblInstallmentsVoucherDetail>(entity =>
            {
                entity.HasKey(e => e.InstallmentsVoucherDetailsId);

                entity.ToTable("tbl_InstallmentsVoucherDetails");

                entity.Property(e => e.InstallmentsVoucherDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("installmentsVoucherDetailsId");

                entity.Property(e => e.CollectedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountAllowed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountAllowed");

                entity.Property(e => e.InstallmentAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InstallmentDate).HasColumnType("date");

                entity.Property(e => e.InstallmentsVoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("installmentsVoucherNo");

                entity.Property(e => e.ReceiptDate).HasColumnType("date");
            });

            modelBuilder.Entity<TblInstallmentsVoucherMaster>(entity =>
            {
                entity.HasKey(e => e.InstallmentsVoucherMasterId)
                    .HasName("PK_tbl_InstallmentsVoucher");

                entity.ToTable("tbl_InstallmentsVoucherMaster");

                entity.Property(e => e.InstallmentsVoucherMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("installmentsVoucherMasterId");

                entity.Property(e => e.CashBank)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CustomerMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InstallmentsMasterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("installmentsMasterDate");

                entity.Property(e => e.InstallmentsVoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("installmentsVoucherNo");

                entity.Property(e => e.SaleInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaleInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesmanId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotalAmtPaid).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalInstallments).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotalPaidInstallments).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotalReceivableAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalReceivableInstallments).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VoucherAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("voucherAmount");
            });

            modelBuilder.Entity<TblInvestigation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Investigations");

                entity.Property(e => e.InvestigationsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("investigationsId");

                entity.Property(e => e.PrescriptionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("prescriptionId");
            });

            modelBuilder.Entity<TblInvoiceGenerationStatus>(entity =>
            {
                entity.HasKey(e => e.PrescriptionId);

                entity.ToTable("tbl_InvoiceGenerationStatus");

                entity.Property(e => e.PrescriptionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("prescriptionId");

                entity.Property(e => e.InvoiceGenerated).HasColumnName("invoiceGenerated");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.LabInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("labInvoiceNo");

                entity.Property(e => e.LabInvoiceStatus).HasColumnName("labInvoiceStatus");
            });

            modelBuilder.Entity<TblInvoiceWiseReceiptVoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_InvoiceWiseReceiptVoucher");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voucherNo");
            });

            modelBuilder.Entity<TblIssueStockDetail>(entity =>
            {
                entity.HasKey(e => e.IssueStockDetailsId);

                entity.ToTable("tbl_IssueStockDetails");

                entity.Property(e => e.IssueStockDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("issueStockDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.IssueStockMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("issueStockMasterId");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.PurchasePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchasePrice");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("quantity");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblIssueStockMaster>(entity =>
            {
                entity.HasKey(e => e.IssueStockMasterId);

                entity.ToTable("tbl_IssueStockMaster");

                entity.Property(e => e.IssueStockMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("issueStockMasterId");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("departmentId");

                entity.Property(e => e.IngredientsCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ingredientsCost");

                entity.Property(e => e.IsApproved).HasColumnName("isApproved");

                entity.Property(e => e.IssueStockNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("issueStockNo");

                entity.Property(e => e.Memo).HasColumnName("memo");

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reference");

                entity.Property(e => e.SalesStaffId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesStaffId");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TblJobStatus>(entity =>
            {
                entity.HasKey(e => e.JobStatusId);

                entity.ToTable("tbl_JobStatus");

                entity.Property(e => e.JobStatusId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("jobStatusId");

                entity.Property(e => e.JobStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("jobStatus");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblJournalDetail>(entity =>
            {
                entity.HasKey(e => e.JournalDetailsId);

                entity.ToTable("tbl_JournalDetails");

                entity.Property(e => e.JournalDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("journalDetailsId");

                entity.Property(e => e.ChequeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("chequeDate");

                entity.Property(e => e.ChequeNo)
                    .IsUnicode(false)
                    .HasColumnName("chequeNo");

                entity.Property(e => e.Credit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("credit");

                entity.Property(e => e.Debit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("debit");

                entity.Property(e => e.DebitCredit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRateId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("exchangeRateId");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.JournalMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("journalMasterId");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.Narration).HasColumnName("narration");
            });

            modelBuilder.Entity<TblJournalMaster>(entity =>
            {
                entity.HasKey(e => e.JournalMasterId);

                entity.ToTable("tbl_JournalMaster");

                entity.Property(e => e.JournalMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("journalMasterId");

                entity.Property(e => e.CashierId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cashierId");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.FinancialYearId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("financialYearId");

                entity.Property(e => e.InvoiceNo)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMethodId");

                entity.Property(e => e.SuffixPrefixId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("suffixPrefixId");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalAmount");

                entity.Property(e => e.UserId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("userId");

                entity.Property(e => e.VoucherNo)
                    .IsUnicode(false)
                    .HasColumnName("voucherNo");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblKitchenOrder>(entity =>
            {
                entity.HasKey(e => e.KitchenOrderId);

                entity.ToTable("tbl_KitchenOrders");

                entity.Property(e => e.KitchenOrderId).HasColumnName("kitchenOrderId");

                entity.Property(e => e.ActualQty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CookId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cookId");

                entity.Property(e => e.CustomerAddress).IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CustomerName).HasColumnName("Customer_Name");

                entity.Property(e => e.DataTableNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DealId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrandTotal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Grand_Total");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsKotitem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("isKOTItem");

                entity.Property(e => e.Kot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KOT");

                entity.Property(e => e.Kotstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KOTStatus");

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Order_Type");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName).HasColumnName("Product_Name");

                entity.Property(e => e.Quantity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RiderId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.SalesmanName).HasColumnName("salesmanName");

                entity.Property(e => e.SubTotal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sub_Total");

                entity.Property(e => e.Table)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Time)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDiscount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Total_Discount");

                entity.Property(e => e.UnitPrice)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Unit_Price");

                entity.Property(e => e.Uomid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");

                entity.Property(e => e.WaiterId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.WaiterName).HasColumnName("Waiter_Name");
            });

            modelBuilder.Entity<TblKot>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_KOT");

                entity.Property(e => e.Kot).HasColumnName("KOT");
            });

            modelBuilder.Entity<TblLead>(entity =>
            {
                entity.HasKey(e => e.LeadId);

                entity.ToTable("tbl_Leads");

                entity.Property(e => e.LeadId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("leadId");

                entity.Property(e => e.AccountGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("accountGroupId");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.AreaId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("areaId");

                entity.Property(e => e.BankAccountNumber)
                    .IsUnicode(false)
                    .HasColumnName("bankAccountNumber");

                entity.Property(e => e.BillByBill).HasColumnName("billByBill");

                entity.Property(e => e.BranchCode)
                    .IsUnicode(false)
                    .HasColumnName("branchCode");

                entity.Property(e => e.BranchName)
                    .IsUnicode(false)
                    .HasColumnName("branchName");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNIC");

                entity.Property(e => e.CompanyName).HasColumnName("companyName");

                entity.Property(e => e.CrOrDr)
                    .IsUnicode(false)
                    .HasColumnName("crOrDr");

                entity.Property(e => e.CreditLimit)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("creditLimit");

                entity.Property(e => e.CreditPeriod).HasColumnName("creditPeriod");

                entity.Property(e => e.Cst)
                    .IsUnicode(false)
                    .HasColumnName("cst");

                entity.Property(e => e.Customercode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customercode");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.FathersName).HasColumnName("fathersName");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.LeadCode)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("leadCode");

                entity.Property(e => e.LeadName).HasColumnName("leadName");

                entity.Property(e => e.MailingName).HasColumnName("mailingName");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobile");

                entity.Property(e => e.MobileNo2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobileNo2");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.OpeningBalance)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("openingBalance");

                entity.Property(e => e.Pan)
                    .IsUnicode(false)
                    .HasColumnName("pan");

                entity.Property(e => e.PartyGroup).HasColumnName("partyGroup");

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("passportNo");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.PricinglevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricinglevelId");

                entity.Property(e => e.RouteId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("routeId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Tin)
                    .IsUnicode(false)
                    .HasColumnName("tin");
            });

            modelBuilder.Entity<TblLedgerPosting>(entity =>
            {
                entity.HasKey(e => e.LedgerPostingId)
                    .HasName("PK__tbl_Ledg__730FE2D769FBBC1F");

                entity.ToTable("tbl_LedgerPosting");

                entity.Property(e => e.LedgerPostingId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerPostingId");

                entity.Property(e => e.ChequeDate)
                    .HasColumnType("date")
                    .HasColumnName("chequeDate");

                entity.Property(e => e.ChequeNo)
                    .IsUnicode(false)
                    .HasColumnName("chequeNo");

                entity.Property(e => e.Credit)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("credit");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Debit)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("debit");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("departmentId")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("detailsId");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.SalesStaffId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesStaffId");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.VoucherNo)
                    .IsUnicode(false)
                    .HasColumnName("voucherNo");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");

                entity.Property(e => e.YearId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("yearId");
            });

            modelBuilder.Entity<TblLedgerRegisterDataColumn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_LedgerRegisterDataColumns");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Formname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("formname");
            });

            modelBuilder.Entity<TblLedgerRegisterFiltersList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_LedgerRegisterFiltersList");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.Filter1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("filter1");

                entity.Property(e => e.Filter2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("filter2");

                entity.Property(e => e.Filter3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("filter3");

                entity.Property(e => e.Filter4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("filter4");

                entity.Property(e => e.Filter5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("filter5");
            });

            modelBuilder.Entity<TblLetterDelivery>(entity =>
            {
                entity.HasKey(e => e.LetterDeliveryId);

                entity.ToTable("tbl_LetterDelivery");

                entity.Property(e => e.LetterDeliveryId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.LetterDeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("letterDeliveryDate");

                entity.Property(e => e.LetterId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReceivedBy).HasColumnName("receivedBy");

                entity.Property(e => e.Remarks).HasColumnName("remarks");
            });

            modelBuilder.Entity<TblLetterReceiving>(entity =>
            {
                entity.HasKey(e => e.LetterId);

                entity.ToTable("tbl_LetterReceiving");

                entity.Property(e => e.LetterId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ChasisNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chasisNo");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.LetterNo).HasMaxLength(50);

                entity.Property(e => e.LetterReceivingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("letterReceivingDate");
            });

            modelBuilder.Entity<TblLicensePlan>(entity =>
            {
                entity.ToTable("tbl_LicensePlan");

                entity.Property(e => e.Application).HasMaxLength(50);

                entity.Property(e => e.PlanName).HasMaxLength(50);

                entity.Property(e => e.PlanType).HasMaxLength(50);
            });

            modelBuilder.Entity<TblLiscenseStatus>(entity =>
            {
                entity.ToTable("tbl_LiscenseStatus");

                entity.Property(e => e.LiscenseStatus).HasMaxLength(50);
            });

            modelBuilder.Entity<TblLiscenseType>(entity =>
            {
                entity.ToTable("tbl_LiscenseType");

                entity.Property(e => e.LiscenseType).HasMaxLength(50);
            });

            modelBuilder.Entity<TblLocation>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("tbl_Location");

                entity.Property(e => e.LocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("locationId");

                entity.Property(e => e.LocationName)
                    .IsUnicode(false)
                    .HasColumnName("locationName");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblLogOperation>(entity =>
            {
                entity.ToTable("tbl_LogOperations");

                entity.Property(e => e.OperationDate).HasColumnType("date");

                entity.Property(e => e.OperationTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OperationType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecordType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblMEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("tbl_M_Employees");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.BasisValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bloodGroup");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cnic");

                entity.Property(e => e.Commission).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CommissionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrOrDr)
                    .HasMaxLength(50)
                    .HasColumnName("crOrDr");

                entity.Property(e => e.DateOfJoining)
                    .HasColumnType("date")
                    .HasColumnName("dateOfJoining");

                entity.Property(e => e.DepartmentId)
                    .IsUnicode(false)
                    .HasColumnName("departmentId");

                entity.Property(e => e.DesignationId)
                    .IsUnicode(false)
                    .HasColumnName("designationId");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmpRegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empRegNo");

                entity.Property(e => e.FatherName).HasColumnName("fatherName");

                entity.Property(e => e.FirtName).HasColumnName("firtName");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.IncrementBasis).HasMaxLength(50);

                entity.Property(e => e.IncrementPeriod).HasMaxLength(50);

                entity.Property(e => e.IncrementType).HasMaxLength(50);

                entity.Property(e => e.IncrementValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LastName).HasColumnName("lastName");

                entity.Property(e => e.LedgerCode)
                    .HasMaxLength(50)
                    .HasColumnName("ledgerCode");

                entity.Property(e => e.Ledgerid).HasColumnName("ledgerid");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("maritalStatus");

                entity.Property(e => e.MiddleName).HasColumnName("middleName");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobileNo");

                entity.Property(e => e.MotherName).HasColumnName("motherName");

                entity.Property(e => e.OpeningBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayScaleId)
                    .IsUnicode(false)
                    .HasColumnName("payScaleId");

                entity.Property(e => e.PermanentAddress).HasColumnName("permanentAddress");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phoneNo");

                entity.Property(e => e.PresentAddress).HasColumnName("presentAddress");

                entity.Property(e => e.SaleTarget)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saleTarget");

                entity.Property(e => e.WageType).HasMaxLength(50);
            });

            modelBuilder.Entity<TblMEmployeeAttachmentsDetail>(entity =>
            {
                entity.HasKey(e => e.AttachmentsDetailsId);

                entity.ToTable("tbl_M_EmployeeAttachmentsDetails");

                entity.Property(e => e.AttachmentsDetailsId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.IssuedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IssuedBY");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<TblMEmployeeBankDetail>(entity =>
            {
                entity.HasKey(e => e.BankDetailsId);

                entity.ToTable("tbl_M_EmployeeBankDetails");

                entity.Property(e => e.BankDetailsId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BankAcNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bankAcNo");

                entity.Property(e => e.BankBranch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bankBranch");

                entity.Property(e => e.BankBranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bankBranchCode");

                entity.Property(e => e.BankIbanno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bankIBANNo");

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bankName");

                entity.Property(e => e.BankSwiftcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bankSWIFTCode");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("employeeId");
            });

            modelBuilder.Entity<TblMEmployeeContractDetail>(entity =>
            {
                entity.HasKey(e => e.ContractDetailsId);

                entity.ToTable("tbl_M_EmployeeContractDetails");

                entity.Property(e => e.ContractDetailsId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ContractEndDate).HasColumnType("date");

                entity.Property(e => e.ContractStartDate).HasColumnType("date");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.WorkPermitNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMEmployeeDocumentsDetail>(entity =>
            {
                entity.HasKey(e => e.DocumentDetailsId);

                entity.ToTable("tbl_M_EmployeeDocumentsDetails");

                entity.Property(e => e.DocumentDetailsId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.Extension)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Narration).IsUnicode(false);
            });

            modelBuilder.Entity<TblMEmployeeEducationDetail>(entity =>
            {
                entity.HasKey(e => e.EducationDetailsId);

                entity.ToTable("tbl_M_EmployeeEducationDetails");

                entity.Property(e => e.EducationDetailsId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DegreeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("degreeName");

                entity.Property(e => e.Distinction)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("distinction");

                entity.Property(e => e.EducationLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("educationLevel");

                entity.Property(e => e.EmpGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empGroup");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("endDate");

                entity.Property(e => e.EvaluationType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("evaluationType");

                entity.Property(e => e.MarksPercentage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("marksPercentage");

                entity.Property(e => e.Result)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("result");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("startDate");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TblMEmployeeExperienceDetail>(entity =>
            {
                entity.HasKey(e => e.ExperienceDetailsId);

                entity.ToTable("tbl_M_EmployeeExperienceDetails");

                entity.Property(e => e.ExperienceDetailsId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.JobFrom)
                    .HasColumnType("date")
                    .HasColumnName("jobFrom");

                entity.Property(e => e.JobStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("jobStatus");

                entity.Property(e => e.JobTo)
                    .HasColumnType("date")
                    .HasColumnName("jobTo");

                entity.Property(e => e.Pay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pay");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role");
            });

            modelBuilder.Entity<TblMEmployeeExpiredAttachmentsDetail>(entity =>
            {
                entity.HasKey(e => e.ExpiredAttachmentsDetailsId);

                entity.ToTable("tbl_M_EmployeeExpiredAttachmentsDetails");

                entity.Property(e => e.ExpiredAttachmentsDetailsId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IssuedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IssuedBY");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<TblMEmployeeFamilyDetail>(entity =>
            {
                entity.HasKey(e => e.FamilyDetailsId);

                entity.ToTable("tbl_M_EmployeeFamilyDetails");

                entity.Property(e => e.FamilyDetailsId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Relation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("relation");
            });

            modelBuilder.Entity<TblMEmployeeImage>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("tbl_M_EmployeeImages");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.EmpImage)
                    .HasColumnType("image")
                    .HasColumnName("empImage");
            });

            modelBuilder.Entity<TblMEmployeeIncrementDetail>(entity =>
            {
                entity.HasKey(e => e.IncrementDetailsId);

                entity.ToTable("tbl_M_EmployeeIncrementDetails");

                entity.Property(e => e.IncrementDetailsId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CurrentBasicPay)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CurrentBasicPAY");

                entity.Property(e => e.DocumentDate).HasColumnType("date");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IncrementBasis).HasMaxLength(50);

                entity.Property(e => e.IncrementBasisValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IncrementDate).HasColumnType("date");

                entity.Property(e => e.IncrementPeriod).HasMaxLength(50);

                entity.Property(e => e.IncrementType).HasMaxLength(50);

                entity.Property(e => e.IncrementValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IncrementedValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.UpdatedBasicPay)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("UpdatedBasicPAY");
            });

            modelBuilder.Entity<TblMEmployeePassportDetail>(entity =>
            {
                entity.HasKey(e => e.PassportDetailsId);

                entity.ToTable("tbl_M_EmployeePassportDetails");

                entity.Property(e => e.PassportDetailsId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CountryOfIssue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.PassportExpiryDate).HasColumnType("date");

                entity.Property(e => e.PassportNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisaExpiryDate).HasColumnType("date");

                entity.Property(e => e.VisaNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMEmployeeSalaryStructureDetail>(entity =>
            {
                entity.HasKey(e => e.SalaryStructureDetailId);

                entity.ToTable("tbl_M_EmployeeSalaryStructureDetails");

                entity.Property(e => e.SalaryStructureDetailId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CalculationBasis).HasMaxLength(50);

                entity.Property(e => e.EffectedFrom).HasColumnType("date");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.PayHeadId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("payHeadId");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblMEmployeeStatutoryDetail>(entity =>
            {
                entity.HasKey(e => e.StatutoryDetailsId);

                entity.ToTable("tbl_M_EmployeeStatutoryDetails");

                entity.Property(e => e.StatutoryDetailsId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.EpsaccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPSAccountNumber");

                entity.Property(e => e.EsidispensaryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ESIDispensaryName");

                entity.Property(e => e.Esinumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ESINumber");

                entity.Property(e => e.IncomeTaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PfaccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFAccountNo");

                entity.Property(e => e.PfdateOfJoining)
                    .HasColumnType("date")
                    .HasColumnName("PFDateOfJoining");
            });

            modelBuilder.Entity<TblMarketPlace>(entity =>
            {
                entity.HasKey(e => e.MarketPlaceId);

                entity.ToTable("tbl_MarketPlace");

                entity.Property(e => e.MarketPlaceId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MarketPlaceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblMaterialReceiptDetail>(entity =>
            {
                entity.HasKey(e => e.MaterialReceiptDetailsId);

                entity.ToTable("tbl_MaterialReceiptDetails");

                entity.Property(e => e.MaterialReceiptDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("materialReceiptDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.MaterialReceiptMasterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("materialReceiptMasterId");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblMaterialReceiptDocument>(entity =>
            {
                entity.HasKey(e => e.MaterialReceiptDocId)
                    .HasName("PK_tbl_MaterialReceipt");

                entity.ToTable("tbl_MaterialReceiptDocuments");

                entity.Property(e => e.MaterialReceiptDocId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("materialReceiptDocId");

                entity.Property(e => e.DataFile).HasColumnType("image");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.MaterialReceiptMasterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("materialReceiptMasterId");

                entity.Property(e => e.Path).IsUnicode(false);
            });

            modelBuilder.Entity<TblMaterialReceiptMaster>(entity =>
            {
                entity.HasKey(e => e.MaterialReceiptMasterId);

                entity.ToTable("tbl_MaterialReceiptMaster");

                entity.Property(e => e.MaterialReceiptMasterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("materialReceiptMasterId");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("currencyId");

                entity.Property(e => e.DocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("documentDate");

                entity.Property(e => e.MaterialReceiptNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("materialReceiptNo");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("date")
                    .HasColumnName("postingDate");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.SupplierId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("supplierId");

                entity.Property(e => e.SupplierRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplierRefNo");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.TotalDownPayment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDownPayment");

                entity.Property(e => e.WarehouseId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("warehouseId");
            });

            modelBuilder.Entity<TblMcustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("tbl_MCustomers");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerId");

                entity.Property(e => e.Address)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.AreaId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("areaId");

                entity.Property(e => e.BankAccountNumber)
                    .IsUnicode(false)
                    .HasColumnName("bankAccountNumber");

                entity.Property(e => e.BillByBill)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("billByBill");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("branchCode");

                entity.Property(e => e.BranchName)
                    .IsUnicode(false)
                    .HasColumnName("branchName");

                entity.Property(e => e.CreditLimit)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("creditLimit");

                entity.Property(e => e.CreditPeriod)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("creditPeriod");

                entity.Property(e => e.Cst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cst");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerCode");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerName");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.MailingName)
                    .IsUnicode(false)
                    .HasColumnName("mailingName");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobile");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.Pan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pan");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.PricinglevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricinglevelId");

                entity.Property(e => e.RouteId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("routeId");

                entity.Property(e => e.Tin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tin");
            });

            modelBuilder.Entity<TblMembership>(entity =>
            {
                entity.HasKey(e => e.MembershipId);

                entity.ToTable("tbl_Membership");

                entity.Property(e => e.MembershipId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("membershipId");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.DueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dueDate");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("invoiceDate");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.MembershipStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NextInvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("nextInvoiceDate");

                entity.Property(e => e.RecurrenceStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("recurrenceStartDate");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.SalesInvoiceId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesInvoiceId");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serviceCode");
            });

            modelBuilder.Entity<TblMobileBarcode>(entity =>
            {
                entity.HasKey(e => e.Barcode);

                entity.ToTable("tbl_MobileBarcodes");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMobileStock>(entity =>
            {
                entity.ToTable("tbl_MobileStock");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.DetailsId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Extra1).HasMaxLength(50);

                entity.Property(e => e.Extra2).HasMaxLength(50);

                entity.Property(e => e.Imei)
                    .HasMaxLength(50)
                    .HasColumnName("IMEI");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.Make).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uomid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOMId");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblModelNo>(entity =>
            {
                entity.HasKey(e => e.ModelNoId)
                    .HasName("PK__tbl_Mode__8458D8C94DB4832C");

                entity.ToTable("tbl_ModelNo");

                entity.Property(e => e.ModelNoId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("modelNoId");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.ModelNo)
                    .IsUnicode(false)
                    .HasColumnName("modelNo");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblModule>(entity =>
            {
                entity.ToTable("tbl_Modules");

                entity.Property(e => e.ModuleName).IsUnicode(false);

                entity.Property(e => e.ModuleUnder).IsUnicode(false);
            });

            modelBuilder.Entity<TblMultiLanguageControl>(entity =>
            {
                entity.HasKey(e => e.FormId);

                entity.ToTable("tbl_MultiLanguageControls");

                entity.Property(e => e.FormId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblMultipleBillCollectionDetail>(entity =>
            {
                entity.HasKey(e => e.MultipleBillCollectionDetailsId);

                entity.ToTable("tbl_MultipleBillCollectionDetails");

                entity.Property(e => e.MultipleBillCollectionDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("multipleBillCollectionDetailsId");

                entity.Property(e => e.AfterDueDate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("afterDueDate");

                entity.Property(e => e.BillMonth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("billMonth");

                entity.Property(e => e.DueBill)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("dueBill");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .HasColumnName("dueDate");

                entity.Property(e => e.MultipleBillCollectionMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("multipleBillCollectionMasterId");

                entity.Property(e => e.ReferenceNo).HasColumnName("referenceNo");
            });

            modelBuilder.Entity<TblMultipleBillCollectionMaster>(entity =>
            {
                entity.HasKey(e => e.MultipleBillCollectionMasterId);

                entity.ToTable("tbl_MultipleBillCollectionMaster");

                entity.Property(e => e.MultipleBillCollectionMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("multipleBillCollectionMasterId");

                entity.Property(e => e.BillCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("billCompany");

                entity.Property(e => e.BillType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("billType");

                entity.Property(e => e.CashPaid)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cashPaid");

                entity.Property(e => e.Change)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("change");

                entity.Property(e => e.DueBill)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("dueBill");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("date")
                    .HasColumnName("invoiceDate");

                entity.Property(e => e.InvoiceTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceTime");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.SmsNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("smsNo");
            });

            modelBuilder.Entity<TblMultipleImage>(entity =>
            {
                entity.HasKey(e => e.VoucherAttachmentId)
                    .HasName("PK_tbl_MultipleImages_1");

                entity.ToTable("tbl_MultipleImages");

                entity.Property(e => e.VoucherAttachmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherAttachmentId");

                entity.Property(e => e.Extenstion)
                    .HasMaxLength(50)
                    .HasColumnName("extenstion");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.FileName).HasColumnName("fileName");

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fileType");

                entity.Property(e => e.Path).HasColumnName("path");

                entity.Property(e => e.ProductId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voucherNo");
            });

            modelBuilder.Entity<TblMultiresult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Multiresult");

                entity.Property(e => e.Caseid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("caseid");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descp");

                entity.Property(e => e.Narration).IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("result");

                entity.Property(e => e.TestName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("testName");

                entity.Property(e => e.TestUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("testUnit");
            });

            modelBuilder.Entity<TblNewTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_NewTest");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("price");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("qty");
            });

            modelBuilder.Entity<TblNewTicketDetail>(entity =>
            {
                entity.HasKey(e => e.NewTicketDetailsId);

                entity.ToTable("tbl_NewTicketDetails");

                entity.Property(e => e.NewTicketDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("newTicketDetailsId");

                entity.Property(e => e.CommisionAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("commisionAmount");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("deliveryDate");

                entity.Property(e => e.DeliveryTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("deliveryTime");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employeeName");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.Quantity)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("quantity");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("rate");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.SaleInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleInvoiceId");

                entity.Property(e => e.SaleInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleInvoiceNo");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serviceCode");

                entity.Property(e => e.ServiceName).HasColumnName("serviceName");

                entity.Property(e => e.Stage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stage");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TicketAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ticketAmount");

                entity.Property(e => e.TicketMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ticketMasterId");

                entity.Property(e => e.TicketNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ticketNo");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblOpdRefundDetail>(entity =>
            {
                entity.HasKey(e => e.RefundDetailsId);

                entity.ToTable("tbl_OpdRefundDetails");

                entity.Property(e => e.RefundDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("refundDetailsId");

                entity.Property(e => e.ConsultantId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("consultantId");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.OpdTicketDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("opdTicketDetailsId");

                entity.Property(e => e.OpdTicketId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("opdTicketId");

                entity.Property(e => e.RefundMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("refundMasterId");

                entity.Property(e => e.ServiceAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("serviceAmount");

                entity.Property(e => e.ServiceId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("serviceId");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalAmount");
            });

            modelBuilder.Entity<TblOpdRefundMaster>(entity =>
            {
                entity.HasKey(e => e.RefundMasterId)
                    .HasName("PK__tbl_OpdRefundMaster");

                entity.ToTable("tbl_OpdRefundMaster");

                entity.Property(e => e.RefundMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("refundMasterId");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("companyId");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.DoctorId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("doctorId");

                entity.Property(e => e.OpdTicketId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("opdTicketId");

                entity.Property(e => e.PatientId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("patientId");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMethodId");

                entity.Property(e => e.RefundDate)
                    .HasColumnType("datetime")
                    .HasColumnName("refundDate");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.TicketNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ticketNo");

                entity.Property(e => e.TokenNo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("tokenNo");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("totalAmount");
            });

            modelBuilder.Entity<TblOpdService>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK__tbl_opdS__3E0DB8AF28317197");

                entity.ToTable("tbl_opdServices");

                entity.Property(e => e.ServiceId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("service_id");

                entity.Property(e => e.ServiceAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("service_amount");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .HasColumnName("serviceName");

                entity.Property(e => e.ServiceNarration)
                    .HasMaxLength(50)
                    .HasColumnName("service_narration");
            });

            modelBuilder.Entity<TblOpdTicketDetail>(entity =>
            {
                entity.HasKey(e => e.OpdTicketDetailsId);

                entity.ToTable("tbl_OpdTicketDetails");

                entity.Property(e => e.OpdTicketDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("opdTicketDetailsId");

                entity.Property(e => e.ConsultantId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("consultantId");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.OpdTicketId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("opdTicketId");

                entity.Property(e => e.ServiceAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("serviceAmount");

                entity.Property(e => e.ServiceId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("serviceId");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalAmount");
            });

            modelBuilder.Entity<TblOpdTicketMaster>(entity =>
            {
                entity.HasKey(e => e.OpdTicketId)
                    .HasName("PK__tbl_OpdT__CDAD7D48F056D7B0");

                entity.ToTable("tbl_OpdTicketMaster");

                entity.Property(e => e.OpdTicketId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("opdTicketId");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("companyId");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.DoctorId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("doctorId");

                entity.Property(e => e.PatientId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("patientId");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMethodId");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.TicketNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ticketNo");

                entity.Property(e => e.TokenNo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("tokenNo");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("totalAmount");
            });

            modelBuilder.Entity<TblPackage>(entity =>
            {
                entity.HasKey(e => e.PackageId)
                    .HasName("PK_tbl_MealPackage");

                entity.ToTable("tbl_Package");

                entity.Property(e => e.PackageId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("packageId");

                entity.Property(e => e.Duration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.PackageName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("packageName");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<TblPackageDetail>(entity =>
            {
                entity.HasKey(e => e.PackagesDetailId);

                entity.ToTable("tbl_PackageDetails");

                entity.Property(e => e.PackagesDetailId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PackageId).HasColumnName("packageId");

                entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");
            });

            modelBuilder.Entity<TblPatientAllergy>(entity =>
            {
                entity.HasKey(e => e.PatientallergyId);

                entity.ToTable("tbl_PatientAllergy");

                entity.Property(e => e.PatientallergyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("patientallergyId");

                entity.Property(e => e.AllergyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("allergyId");

                entity.Property(e => e.OpdTicketId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("opdTicketId");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.Serverity)
                    .HasMaxLength(50)
                    .HasColumnName("serverity");
            });

            modelBuilder.Entity<TblPatientDetailsInfo>(entity =>
            {
                entity.HasKey(e => e.PatientDetailsInfoId);

                entity.ToTable("tbl_PatientDetailsInfo");

                entity.Property(e => e.PatientDetailsInfoId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("patientDetailsInfoId");

                entity.Property(e => e.DepartmentType)
                    .HasMaxLength(50)
                    .HasColumnName("departmentType");

                entity.Property(e => e.DifferentialDiagnosis)
                    .HasMaxLength(50)
                    .HasColumnName("differentialDiagnosis");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.ProcedureType)
                    .HasMaxLength(50)
                    .HasColumnName("procedureType");

                entity.Property(e => e.RefferedDepartmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("refferedDepartmentId");

                entity.Property(e => e.SpecialityGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("specialityGroupId");

                entity.Property(e => e.SpecialityId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("specialityId");

                entity.Property(e => e.SpecialityProcedureId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("specialityProcedureId");

                entity.Property(e => e.SpecialityUnitId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("specialityUnitId");

                entity.Property(e => e.SpecialityWardId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("specialityWardId");
            });

            modelBuilder.Entity<TblPatientVital>(entity =>
            {
                entity.HasKey(e => e.OpdTicketId);

                entity.ToTable("tbl_PatientVitals");

                entity.Property(e => e.OpdTicketId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("opdTicketId");

                entity.Property(e => e.BmiObesityStatus)
                    .HasMaxLength(50)
                    .HasColumnName("bmiObesityStatus");

                entity.Property(e => e.Bp)
                    .HasMaxLength(50)
                    .HasColumnName("BP");

                entity.Property(e => e.Height)
                    .HasMaxLength(50)
                    .HasColumnName("height");

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .HasColumnName("note");

                entity.Property(e => e.Pulse)
                    .HasMaxLength(50)
                    .HasColumnName("pulse");

                entity.Property(e => e.Respiration)
                    .HasMaxLength(50)
                    .HasColumnName("respiration");

                entity.Property(e => e.Symptoms)
                    .HasMaxLength(50)
                    .HasColumnName("symptoms");

                entity.Property(e => e.Temperature)
                    .HasMaxLength(50)
                    .HasColumnName("temperature");

                entity.Property(e => e.Weight)
                    .HasMaxLength(50)
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<TblPayHead>(entity =>
            {
                entity.HasKey(e => e.PayHeadId)
                    .HasName("PK__tbl_PayH__1BAC6FBD2CF2ADDF");

                entity.ToTable("tbl_PayHead");

                entity.Property(e => e.PayHeadId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("payHeadId");

                entity.Property(e => e.AffectNetSalary).HasColumnName("affectNetSalary");

                entity.Property(e => e.AttendanceProductionTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("attendanceProductionTypeId");

                entity.Property(e => e.CalculationBasis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("calculationBasis");

                entity.Property(e => e.CalculationPeriod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("calculationPeriod");

                entity.Property(e => e.CalculationType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("calculationType");

                entity.Property(e => e.CalculationValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ComputationOn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("incomeType");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsAllowance).HasColumnName("isAllowance");

                entity.Property(e => e.Ledgerid)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ledgerid");

                entity.Property(e => e.NameInPaySlip)
                    .IsUnicode(false)
                    .HasColumnName("nameInPaySlip");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.PayHeadCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayHeadName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("payHeadName");

                entity.Property(e => e.PayHeadType).HasColumnName("payHeadType");

                entity.Property(e => e.RoundingLimit).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RoundingMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("roundingMethod");

                entity.Property(e => e.SetAlterIncomeTaxDetails).HasColumnName("setAlterIncomeTaxDetails");

                entity.Property(e => e.StatutoryType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Under)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("under");

                entity.Property(e => e.UseForGratuity).HasColumnName("useForGratuity");

                entity.Property(e => e.WorkUnitId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("workUnitId");
            });

            modelBuilder.Entity<TblPayHeadDetail>(entity =>
            {
                entity.HasKey(e => e.PayHeadDetailsId);

                entity.ToTable("tbl_PayHeadDetails");

                entity.Property(e => e.PayHeadDetailsId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("payHeadDetailsId");

                entity.Property(e => e.EffectiveFrom).HasColumnType("date");

                entity.Property(e => e.PayHeadId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("payHeadId");

                entity.Property(e => e.PayHeadMasterId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("payHeadMasterId");
            });

            modelBuilder.Entity<TblPayHeadFormulaDetail>(entity =>
            {
                entity.HasKey(e => e.PayHeadFormulaDetailId)
                    .HasName("PK_tbl_PayHeadFormulaDetailID");

                entity.ToTable("tbl_PayHeadFormulaDetails");

                entity.Property(e => e.PayHeadFormulaDetailId).ValueGeneratedNever();

                entity.Property(e => e.EffectiveFrom).HasColumnType("date");

                entity.Property(e => e.PayHeadMasterId).HasColumnName("payHeadMasterId");

                entity.Property(e => e.SlabType).HasMaxLength(50);

                entity.Property(e => e.ValueBasis).HasMaxLength(50);
            });

            modelBuilder.Entity<TblPayHeadFormulaMaster>(entity =>
            {
                entity.HasKey(e => e.PayHeadFormulaMasterId);

                entity.ToTable("tbl_PayHeadFormulaMaster");

                entity.Property(e => e.PayHeadFormulaMasterId)
                    .ValueGeneratedNever()
                    .HasColumnName("payHeadFormulaMasterID");

                entity.Property(e => e.PayHeadId).HasColumnName("payHeadId");

                entity.Property(e => e.PayHeadMasterId).HasColumnName("payHeadMasterId");
            });

            modelBuilder.Entity<TblPayHeadType>(entity =>
            {
                entity.HasKey(e => e.PayHeadTypeId);

                entity.ToTable("tbl_PayHeadType");

                entity.Property(e => e.PayHeadTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("payHeadTypeId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.PayHeadName)
                    .IsUnicode(false)
                    .HasColumnName("payHeadName");
            });

            modelBuilder.Entity<TblPayRollGeneration>(entity =>
            {
                entity.HasKey(e => e.PayRollGenerationId);

                entity.ToTable("tbl_PayRollGeneration");

                entity.Property(e => e.PayRollGenerationId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .HasColumnName("departmentId");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GrandTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayRollGenerationNo).HasMaxLength(50);

                entity.Property(e => e.PayRollGenerationStatus).HasMaxLength(50);

                entity.Property(e => e.PayRollGenerationType).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPayRollGenerationDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_PayRollGenerationDetails");

                entity.Property(e => e.ActualDays).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApproveDays).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BasicPayAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayRollGenerationDetailId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PayRollGenerationId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalAllowanceAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDeductionAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalEarningAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFullDays).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalHalfDays).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalHours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalLoanAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalMinutes).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblPayRollVoucher>(entity =>
            {
                entity.HasKey(e => e.PayRollVoucherId);

                entity.ToTable("tbl_PayRollVoucher");

                entity.Property(e => e.PayRollVoucherId).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DocumentDate).HasColumnType("date");

                entity.Property(e => e.Employee).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.PayRollVoucherNo).HasMaxLength(50);

                entity.Property(e => e.PayRollVoucherType).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<TblPayRollVoucherDetail>(entity =>
            {
                entity.HasKey(e => e.PayRollVoucherDetailId);

                entity.ToTable("tbl_PayRollVoucherDetails");

                entity.Property(e => e.PayRollVoucherDetailId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Days).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Minutes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayHeadId).HasColumnName("PayHeadID");

                entity.Property(e => e.PayRollVoucherId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Seconds).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAttendance).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblPayScale>(entity =>
            {
                entity.HasKey(e => e.PayScaleId);

                entity.ToTable("tbl_PayScale");

                entity.Property(e => e.PayScaleId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("payScaleId");

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.PayScaleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("payScaleName");
            });

            modelBuilder.Entity<TblPaymentDetail>(entity =>
            {
                entity.HasKey(e => e.PaymentDetailsId);

                entity.ToTable("tbl_PaymentDetails");

                entity.Property(e => e.PaymentDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.BorrowedFromTo)
                    .HasMaxLength(50)
                    .HasColumnName("borrowedFromTo");

                entity.Property(e => e.ChequeDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chequeDate");

                entity.Property(e => e.ChequeNo)
                    .IsUnicode(false)
                    .HasColumnName("chequeNo");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.InvoicePertainsTo).HasColumnName("invoicePertainsTo");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("date")
                    .HasColumnName("issueDate");

                entity.Property(e => e.LedgerBalance)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.Paid)
                    .HasMaxLength(50)
                    .HasColumnName("paid");

                entity.Property(e => e.PaymentMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMasterId");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("projectId");

                entity.Property(e => e.PurchaseInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseInvoiceNo");

                entity.Property(e => e.RemainingBalance)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPaymentMaster>(entity =>
            {
                entity.HasKey(e => e.PaymentMasterId);

                entity.ToTable("tbl_PaymentMaster");

                entity.Property(e => e.PaymentMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMasterId");

                entity.Property(e => e.CashierId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cashierId");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("departmentId")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMethodId");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("totalAmount");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voucherNo");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblPaymentMethod>(entity =>
            {
                entity.HasKey(e => e.PaymentMethodId);

                entity.ToTable("tbl_PaymentMethods");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMethodId");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("paymentMethod");
            });

            modelBuilder.Entity<TblPaymentMethodMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_PaymentMethodMapping");

                entity.Property(e => e.BranchId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("branchId");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.MappingId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("mappingId");

                entity.Property(e => e.MotherboardId).HasColumnName("motherboardId");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMethodId");
            });

            modelBuilder.Entity<TblPaymentVoucherDoubleDetail>(entity =>
            {
                entity.HasKey(e => e.JournalDetailsId);

                entity.ToTable("tbl_PaymentVoucherDoubleDetails");

                entity.Property(e => e.JournalDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("journalDetailsId");

                entity.Property(e => e.ChequeDate)
                    .HasColumnType("date")
                    .HasColumnName("chequeDate");

                entity.Property(e => e.ChequeNo)
                    .IsUnicode(false)
                    .HasColumnName("chequeNo");

                entity.Property(e => e.Credit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("credit");

                entity.Property(e => e.Debit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("debit");

                entity.Property(e => e.DebitCredit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRateId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("exchangeRateId");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("date")
                    .HasColumnName("extraDate");

                entity.Property(e => e.JournalMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("journalMasterId");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblPaymentVoucherDoubleMaster>(entity =>
            {
                entity.HasKey(e => e.JournalMasterId)
                    .HasName("PK_[tbl_PaymentVoucherDoubleMaster");

                entity.ToTable("tbl_PaymentVoucherDoubleMaster");

                entity.Property(e => e.JournalMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("journalMasterId");

                entity.Property(e => e.CashierId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cashierId");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.FinancialYearId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("financialYearId");

                entity.Property(e => e.InvoiceNo)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMethodId");

                entity.Property(e => e.SuffixPrefixId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("suffixPrefixId");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalAmount");

                entity.Property(e => e.UserId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("userId");

                entity.Property(e => e.VoucherNo)
                    .IsUnicode(false)
                    .HasColumnName("voucherNo");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblPhysicalExamination>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_PhysicalExaminations");

                entity.Property(e => e.PhysicalExaminationId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("physicalExaminationId");

                entity.Property(e => e.PrescriptionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("prescriptionId");
            });

            modelBuilder.Entity<TblPolicy>(entity =>
            {
                entity.HasKey(e => e.PolicyId);

                entity.ToTable("tbl_Policy");

                entity.Property(e => e.PolicyId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ApplicableFrom).HasColumnType("date");

                entity.Property(e => e.ApplicableTo).HasColumnType("date");

                entity.Property(e => e.DocumentDate).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeId");

                entity.Property(e => e.FullDayUnit).HasMaxLength(50);

                entity.Property(e => e.HalfDayUnit).HasMaxLength(50);

                entity.Property(e => e.MonthlyUnit).HasMaxLength(50);

                entity.Property(e => e.PolicyCode).HasMaxLength(50);

                entity.Property(e => e.TimingMonth).HasColumnType("date");

                entity.Property(e => e.WeeklyUnit).HasMaxLength(50);
            });

            modelBuilder.Entity<TblPolicyDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_PolicyDetail");

                entity.Property(e => e.DayOfWeek).HasMaxLength(50);

                entity.Property(e => e.InTimeGraceType).HasMaxLength(50);

                entity.Property(e => e.OutTimeGraceType).HasMaxLength(50);

                entity.Property(e => e.PolicyDetailId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PolicyId).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblPosOpeningStock>(entity =>
            {
                entity.ToTable("tbl_pos_openingStock");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("itemCode");

                entity.Property(e => e.Masterid).HasColumnName("masterid");

                entity.Property(e => e.PreviousQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PreviousQTY");

                entity.Property(e => e.ReceivedQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("receivedQTY");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<TblPosuser>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("tbl_POSUsers");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bloodGroup");

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cnic");

                entity.Property(e => e.DesignationId).HasColumnName("designationId");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmpRegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empRegNo");

                entity.Property(e => e.FatherName).HasColumnName("fatherName");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("maritalStatus");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobileNo");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PermanentAddress).HasColumnName("permanentAddress");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phoneNo");

                entity.Property(e => e.PresentAddress).HasColumnName("presentAddress");
            });

            modelBuilder.Entity<TblPosuserPasswordsAndRole>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("tbl_POSUserPasswordsAndRoles");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("departmentId");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.Password)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Shiftid).HasColumnName("shiftid");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.Property(e => e.UserRoleId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("userRoleId");
            });

            modelBuilder.Entity<TblPosusersImage>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("tbl_POSUsersImages");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.EmpImage)
                    .HasColumnType("image")
                    .HasColumnName("empImage");
            });

            modelBuilder.Entity<TblPrescription>(entity =>
            {
                entity.HasKey(e => e.PrescriptionId);

                entity.ToTable("tbl_Prescription");

                entity.Property(e => e.PrescriptionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("prescriptionId");

                entity.Property(e => e.AdmitPatient).HasColumnName("admitPatient");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("departmentId");

                entity.Property(e => e.FollowUpDate)
                    .HasColumnType("date")
                    .HasColumnName("followUpDate");

                entity.Property(e => e.OpdTicketId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("opdTicketId");

                entity.Property(e => e.Other).HasMaxLength(50);

                entity.Property(e => e.OtherInvestigations).HasColumnName("otherInvestigations");

                entity.Property(e => e.OtherPrespiringComplaint).HasColumnName("otherPrespiringComplaint");

                entity.Property(e => e.PrescriptionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("prescriptionDate");

                entity.Property(e => e.ProvisionalDiagnosis).HasColumnName("provisionalDiagnosis");

                entity.Property(e => e.ReferPatient).HasColumnName("referPatient");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.TimeIn).HasColumnName("timeIn");

                entity.Property(e => e.TimeOut).HasColumnName("timeOut");
            });

            modelBuilder.Entity<TblPrescriptionMedicine>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_PrescriptionMedicine");

                entity.Property(e => e.AfterMeal).HasColumnName("afterMeal");

                entity.Property(e => e.Days)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("days");

                entity.Property(e => e.Dosage)
                    .HasMaxLength(50)
                    .HasColumnName("dosage");

                entity.Property(e => e.Intake)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("intake");

                entity.Property(e => e.PrescriptionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("prescriptionId");

                entity.Property(e => e.ProductId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productId");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .HasColumnName("remarks");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");
            });

            modelBuilder.Entity<TblPrescriptionTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_PrescriptionTests");

                entity.Property(e => e.PrescriptionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("prescriptionId");

                entity.Property(e => e.SentToLab).HasColumnName("sentToLab");

                entity.Property(e => e.TestId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("testId");
            });

            modelBuilder.Entity<TblPresentingComplaint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_PresentingComplaints");

                entity.Property(e => e.PrescriptionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("prescriptionId");

                entity.Property(e => e.PresentingComplaintId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("presentingComplaintId");
            });

            modelBuilder.Entity<TblPricingLevel>(entity =>
            {
                entity.HasKey(e => e.PricinglevelId)
                    .HasName("PK__tbl_Pric__84E896EA23BE4960");

                entity.ToTable("tbl_PricingLevel");

                entity.Property(e => e.PricinglevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricinglevelId");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.PricinglevelName)
                    .IsUnicode(false)
                    .HasColumnName("pricinglevelName");
            });

            modelBuilder.Entity<TblProdCategoryWithUser>(entity =>
            {
                entity.HasKey(e => e.CategoryUserId);

                entity.ToTable("tbl_ProdCategoryWithUser");

                entity.Property(e => e.CategoryUserId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("categoryUserId");

                entity.Property(e => e.GroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("groupId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.UserId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("userId");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("tbl_Product");

                entity.HasIndex(e => e.BrandId, "IX_tbl_Product_brandId");

                entity.HasIndex(e => e.GroupId, "IX_tbl_Product_groupId");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("productId");

                entity.Property(e => e.AccountGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("accountGroupId");

                entity.Property(e => e.Barcode)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.BrandId).HasColumnName("brandId");

                entity.Property(e => e.ColorId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("colorId");

                entity.Property(e => e.DefaultUomid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("defaultUOMId");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("departmentId");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.EnableBatch).HasColumnName("enableBatch");

                entity.Property(e => e.EnableExpiry).HasColumnName("enableExpiry");

                entity.Property(e => e.EnableWaranty).HasColumnName("enableWaranty");

                entity.Property(e => e.Extra1).HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.Extra3).HasColumnName("extra3");

                entity.Property(e => e.Extra4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra4");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("date")
                    .HasColumnName("extraDate");

                entity.Property(e => e.GodownId).HasColumnName("godownId");

                entity.Property(e => e.GroupId).HasColumnName("groupId");

                entity.Property(e => e.HorsePower)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("horsePower");

                entity.Property(e => e.ISalesItem).HasColumnName("iSalesItem");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsBom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("isBom");

                entity.Property(e => e.IsFixedAseet).HasColumnName("isFixedAseet");

                entity.Property(e => e.IsInventoryItem).HasColumnName("isInventoryItem");

                entity.Property(e => e.IsKotitem).HasColumnName("isKOTItem");

                entity.Property(e => e.IsPksize).HasColumnName("isPKSize");

                entity.Property(e => e.IsPriceBySize).HasColumnName("isPriceBySize");

                entity.Property(e => e.IsPurchasesItem).HasColumnName("isPurchasesItem");

                entity.Property(e => e.IsRentalItem).HasColumnName("isRentalItem");

                entity.Property(e => e.IsSaleItem).HasColumnName("isSaleItem");

                entity.Property(e => e.IsShowInReminder).HasColumnName("isShowInReminder");

                entity.Property(e => e.IsStockable).HasColumnName("isStockable");

                entity.Property(e => e.IsTaxable).HasColumnName("isTaxable");

                entity.Property(e => e.IsallowBatch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("isallowBatch");

                entity.Property(e => e.Ismultipleunit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ismultipleunit");

                entity.Property(e => e.Isopeningstock)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("isopeningstock");

                entity.Property(e => e.Ispurchase).HasColumnName("ispurchase");

                entity.Property(e => e.IsshowRemember).HasColumnName("isshowRemember");

                entity.Property(e => e.LiftTimeTokenFee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("liftTimeTokenFee");

                entity.Property(e => e.MaximumStock)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("maximumStock");

                entity.Property(e => e.MinimumStock)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("minimumStock");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("model");

                entity.Property(e => e.ModelNoId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("modelNoId");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("mrp");

                entity.Property(e => e.MultiBarcodes).HasColumnName("multiBarcodes");

                entity.Property(e => e.MultiUomtype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("multiUOMType");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.NextPurchasePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("nextPurchasePrice");

                entity.Property(e => e.NoOfClaims).HasColumnName("noOfClaims");

                entity.Property(e => e.NumberPlateFee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("numberPlateFee");

                entity.Property(e => e.Openingstock)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("openingstock");

                entity.Property(e => e.PartNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("partNo");

                entity.Property(e => e.PharmacyForeignKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pksize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PKSize");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prefix");

                entity.Property(e => e.PrintName).HasColumnName("printName");

                entity.Property(e => e.ProductCode)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasePricePercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PurchaseRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchaseRate");

                entity.Property(e => e.RackId).HasColumnName("rackId");

                entity.Property(e => e.RegistrationBookFee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("registrationBookFee");

                entity.Property(e => e.RegistrationFee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("registrationFee");

                entity.Property(e => e.ReorderLevel)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("reorderLevel");

                entity.Property(e => e.ResturantForeignKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalePricePercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("salesRate");

                entity.Property(e => e.ShiftWiseStockManage).HasColumnName("shiftWiseStockManage");

                entity.Property(e => e.Size).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SizeId).HasColumnName("sizeId");

                entity.Property(e => e.SupplierId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("supplierId");

                entity.Property(e => e.TaxId).HasColumnName("taxId");

                entity.Property(e => e.TaxapplicableOn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("taxapplicableOn");

                entity.Property(e => e.TradePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnladenWeight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("unladenWeight");

                entity.Property(e => e.UomgroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMGroupId");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.WarantyTypes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("warantyTypes");

                entity.Property(e => e.WholesaleRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("wholesaleRate");
            });

            modelBuilder.Entity<TblProductAdditionInfoMaster>(entity =>
            {
                entity.HasKey(e => e.ProductAdditioninfoMasterId);

                entity.ToTable("tbl_ProductAdditionInfoMaster");

                entity.Property(e => e.ProductAdditioninfoMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productAdditioninfoMasterId");

                entity.Property(e => e.ChkActivateOnSaleInvoiceReport).HasColumnName("chkActivateOnSaleInvoiceReport");

                entity.Property(e => e.ChkInvoiceDef).HasColumnName("chkInvoiceDef");

                entity.Property(e => e.ChkProductDef).HasColumnName("chkProductDef");

                entity.Property(e => e.ChkSaleInvoiceDef).HasColumnName("chkSaleInvoiceDef");

                entity.Property(e => e.ChkenableOnStockBarcode).HasColumnName("chkenableOnStockBarcode");

                entity.Property(e => e.FieldName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fieldName");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");
            });

            modelBuilder.Entity<TblProductAdditionalInfo>(entity =>
            {
                entity.ToTable("tbl_ProductAdditionalInfo");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Batch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Expiry)
                    .HasColumnType("date")
                    .HasColumnName("expiry");

                entity.Property(e => e.Hello)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hello");

                entity.Property(e => e.Imei)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IMEI");

                entity.Property(e => e.InvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOdel");

                entity.Property(e => e.New)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("new");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.Quantity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Uom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOM");

                entity.Property(e => e.Uomid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOMId");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblProductAdditionalInfoClone1>(entity =>
            {
                entity.HasKey(e => e.Clone1Id);

                entity.ToTable("tbl_ProductAdditionalInfoClone1");

                entity.Property(e => e.Clone1Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Batch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Expiry)
                    .HasColumnType("date")
                    .HasColumnName("expiry");

                entity.Property(e => e.Hello)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hello");

                entity.Property(e => e.Imei)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IMEI");

                entity.Property(e => e.InvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOdel");

                entity.Property(e => e.New)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("new");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.StockId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("stockId");

                entity.Property(e => e.Uom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOM");

                entity.Property(e => e.Uomid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOMId");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblProductAdditionalInfoClone2>(entity =>
            {
                entity.HasKey(e => e.Clone2Id);

                entity.ToTable("tbl_ProductAdditionalInfoClone2");

                entity.Property(e => e.Clone2Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Batch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Expiry)
                    .HasColumnType("date")
                    .HasColumnName("expiry");

                entity.Property(e => e.Hello)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hello");

                entity.Property(e => e.Imei)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IMEI");

                entity.Property(e => e.InvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOdel");

                entity.Property(e => e.New)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("new");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.Quantity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Uom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOM");

                entity.Property(e => e.Uomid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOMId");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblProductBarcode>(entity =>
            {
                entity.HasKey(e => e.ProductBarcodeId);

                entity.ToTable("tbl_ProductBarcodes");

                entity.Property(e => e.ProductBarcodeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productBarcodeId");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.BaseQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.ProductCode)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productId");

                entity.Property(e => e.PurchaseRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaleRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UomgroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMGroupId");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");
            });

            modelBuilder.Entity<TblProductGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK__tbl_Prod__88C1034D10AB74EC");

                entity.ToTable("tbl_ProductGroup");

                entity.Property(e => e.GroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("groupId");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.GroupName).HasColumnName("groupName");

                entity.Property(e => e.GroupUnder)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("groupUnder");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.PostCogs).HasColumnName("PostCOGS");
            });

            modelBuilder.Entity<TblProductGroupNumber>(entity =>
            {
                entity.HasKey(e => e.GroupNumberId);

                entity.ToTable("tbl_ProductGroupNumbers");

                entity.Property(e => e.GroupNumberId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("groupNumberId");

                entity.Property(e => e.GroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("groupId");

                entity.Property(e => e.MobNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobNumber");
            });

            modelBuilder.Entity<TblProductImage>(entity =>
            {
                entity.HasKey(e => e.ProductImageId);

                entity.ToTable("tbl_ProductImages");

                entity.Property(e => e.ProductImageId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productImageId");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Path).IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productId");

                entity.Property(e => e.ProductImage)
                    .HasColumnType("image")
                    .HasColumnName("productImage");
            });

            modelBuilder.Entity<TblProductLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Product_Log");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.BrandId).HasColumnName("brandId");

                entity.Property(e => e.DefaultUomid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("defaultUOMId");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.GodownId).HasColumnName("godownId");

                entity.Property(e => e.GroupId).HasColumnName("groupId");

                entity.Property(e => e.ISalesItem).HasColumnName("iSalesItem");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsBom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("isBom");

                entity.Property(e => e.IsFixedAseet).HasColumnName("isFixedAseet");

                entity.Property(e => e.IsInventoryItem).HasColumnName("isInventoryItem");

                entity.Property(e => e.IsPurchasesItem).HasColumnName("isPurchasesItem");

                entity.Property(e => e.IsShowInReminder).HasColumnName("isShowInReminder");

                entity.Property(e => e.IsallowBatch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("isallowBatch");

                entity.Property(e => e.Ismultipleunit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ismultipleunit");

                entity.Property(e => e.Isopeningstock)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("isopeningstock");

                entity.Property(e => e.IsshowRemember).HasColumnName("isshowRemember");

                entity.Property(e => e.MaximumStock)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("maximumStock");

                entity.Property(e => e.MinimumStock)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("minimumStock");

                entity.Property(e => e.ModelNoId).HasColumnName("modelNoId");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("mrp");

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.Openingstock)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("openingstock");

                entity.Property(e => e.PartNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("partNo");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("productName");

                entity.Property(e => e.PurchaseRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchaseRate");

                entity.Property(e => e.RackId).HasColumnName("rackId");

                entity.Property(e => e.ReorderLevel)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("reorderLevel");

                entity.Property(e => e.SalesRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("salesRate");

                entity.Property(e => e.SizeId).HasColumnName("sizeId");

                entity.Property(e => e.TaxId).HasColumnName("taxId");

                entity.Property(e => e.TaxapplicableOn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("taxapplicableOn");

                entity.Property(e => e.UomgroupId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("UOMGroupId");

                entity.Property(e => e.Uomid).HasColumnName("UOMId");

                entity.Property(e => e.UpdaterDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdaterEmployeeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UpdaterEmployeeID");

                entity.Property(e => e.UpdaterEmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdaterTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblProductLog1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Product_Logs");

                entity.Property(e => e.Barcode)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.BrandId).HasColumnName("brandId");

                entity.Property(e => e.ColorId).HasColumnName("colorId");

                entity.Property(e => e.DefaultUomid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("defaultUOMId");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("date")
                    .HasColumnName("extraDate");

                entity.Property(e => e.GodownId).HasColumnName("godownId");

                entity.Property(e => e.GroupId).HasColumnName("groupId");

                entity.Property(e => e.ISalesItem).HasColumnName("iSalesItem");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsBom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("isBom");

                entity.Property(e => e.IsFixedAseet).HasColumnName("isFixedAseet");

                entity.Property(e => e.IsInventoryItem).HasColumnName("isInventoryItem");

                entity.Property(e => e.IsPurchasesItem).HasColumnName("isPurchasesItem");

                entity.Property(e => e.IsShowInReminder).HasColumnName("isShowInReminder");

                entity.Property(e => e.IsallowBatch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("isallowBatch");

                entity.Property(e => e.Ismultipleunit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ismultipleunit");

                entity.Property(e => e.Isopeningstock)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("isopeningstock");

                entity.Property(e => e.Ispurchase).HasColumnName("ispurchase");

                entity.Property(e => e.IsshowRemember).HasColumnName("isshowRemember");

                entity.Property(e => e.MaximumStock)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("maximumStock");

                entity.Property(e => e.MinimumStock)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("minimumStock");

                entity.Property(e => e.ModelNoId).HasColumnName("modelNoId");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("mrp");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.Openingstock)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("openingstock");

                entity.Property(e => e.PartNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("partNo");

                entity.Property(e => e.PharmacyForeignKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prefix");

                entity.Property(e => e.ProductCode)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productName");

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseRate)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("purchaseRate");

                entity.Property(e => e.RackId).HasColumnName("rackId");

                entity.Property(e => e.ReorderLevel)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("reorderLevel");

                entity.Property(e => e.ResturantForeignKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesRate)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("salesRate");

                entity.Property(e => e.SizeId).HasColumnName("sizeId");

                entity.Property(e => e.TaxId).HasColumnName("taxId");

                entity.Property(e => e.TaxapplicableOn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("taxapplicableOn");

                entity.Property(e => e.UomgroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMGroupId");

                entity.Property(e => e.Uomid).HasColumnName("UOMId");

                entity.Property(e => e.UpdaterDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdaterEmployeeId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("UpdaterEmployeeID");

                entity.Property(e => e.UpdaterEmployeeName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdaterTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblProductRegisterFiltersList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_productRegisterFiltersList");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.Filter1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("filter1");

                entity.Property(e => e.Filter2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("filter2");

                entity.Property(e => e.Filter3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("filter3");

                entity.Property(e => e.Filter4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("filter4");

                entity.Property(e => e.Filter5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("filter5");
            });

            modelBuilder.Entity<TblProductionDetail>(entity =>
            {
                entity.HasKey(e => e.ProductionDetailsId);

                entity.ToTable("tbl_ProductionDetails");

                entity.Property(e => e.ProductionDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productionDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.ProductionMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productionMasterId");

                entity.Property(e => e.PurchasePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchasePrice");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("quantity");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblProductionMaster>(entity =>
            {
                entity.HasKey(e => e.ProductionMasterId);

                entity.ToTable("tbl_ProductionMaster");

                entity.Property(e => e.ProductionMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productionMasterId");

                entity.Property(e => e.AverageCostPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageCostPrice");

                entity.Property(e => e.AverageUnitPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageUnitPrice");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Expenses)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("expenses");

                entity.Property(e => e.IngredientsCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ingredientsCost");

                entity.Property(e => e.ProducedQty)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("producedQty");

                entity.Property(e => e.ProductId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productId");

                entity.Property(e => e.ProductionNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productionNo");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");
            });

            modelBuilder.Entity<TblProfitAnalysisReport>(entity =>
            {
                entity.HasKey(e => e.ProfitReportId);

                entity.ToTable("tbl_ProfitAnalysisReport");

                entity.Property(e => e.ProfitReportId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("profitReportId");

                entity.Property(e => e.ActualSoldStockValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("actualSoldStockValue");

                entity.Property(e => e.ActualUnitCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("actualUnitCost");

                entity.Property(e => e.AvgUnitDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("avgUnitDiscount");

                entity.Property(e => e.AvgUnitFreight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("avgUnitFreight");

                entity.Property(e => e.AvgUnitOtherExpense)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("avgUnitOtherExpense");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batchNo");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.ReturnQty)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("returnQty");

                entity.Property(e => e.ReturnValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("returnValue");

                entity.Property(e => e.RowTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rowTotal");

                entity.Property(e => e.SaleProfit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saleProfit");

                entity.Property(e => e.SoldStockValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("soldStockValue");

                entity.Property(e => e.Time)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("time");

                entity.Property(e => e.UnitPurchasePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("unitPurchasePrice");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOMName");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblProject>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.ToTable("tbl_Projects");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("projectId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .HasColumnName("narration");

                entity.Property(e => e.Project).HasColumnName("project");
            });

            modelBuilder.Entity<TblPromotion>(entity =>
            {
                entity.HasKey(e => e.PromotionId);

                entity.ToTable("tbl_Promotions");

                entity.Property(e => e.PromotionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("promotionId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.PromotionDetails)
                    .IsUnicode(false)
                    .HasColumnName("promotionDetails");

                entity.Property(e => e.PromotionName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("promotionName");
            });

            modelBuilder.Entity<TblPurchaseAcLedger>(entity =>
            {
                entity.HasKey(e => e.PurchaseAcLedgerId);

                entity.ToTable("tbl_PurchaseAcLedger");

                entity.Property(e => e.PurchaseAcLedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("purchaseAcLedgerId");

                entity.Property(e => e.Credit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("credit");

                entity.Property(e => e.Debit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("debit");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voucherNo");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblPurchaseBillTax>(entity =>
            {
                entity.HasKey(e => e.PurchaseBillTaxId)
                    .HasName("PK__tbl_Purc__1B87331A27D9BE5E");

                entity.ToTable("tbl_PurchaseBillTax");

                entity.Property(e => e.PurchaseBillTaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("purchaseBillTaxId");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");
            });

            modelBuilder.Entity<TblPurchaseImportAcLedger>(entity =>
            {
                entity.HasKey(e => e.PurchaseImpAcLedgerId);

                entity.ToTable("tbl_PurchaseImportAcLedger");

                entity.Property(e => e.PurchaseImpAcLedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("purchaseImpAcLedgerId");

                entity.Property(e => e.Credit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("credit");

                entity.Property(e => e.Debit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("debit");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voucherNo");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblPurchaseInvoiceDetail>(entity =>
            {
                entity.HasKey(e => e.PurchaseInvoiceDetailsId);

                entity.ToTable("tbl_PurchaseInvoiceDetails");

                entity.Property(e => e.PurchaseInvoiceDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("purchaseInvoiceDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.BorrowedFromTo)
                    .HasMaxLength(50)
                    .HasColumnName("borrowedFromTo");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.InvoicePertainsTo).HasColumnName("invoicePertainsTo");

                entity.Property(e => e.Paid)
                    .HasMaxLength(50)
                    .HasColumnName("paid");

                entity.Property(e => e.Prate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PRate");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("projectId");

                entity.Property(e => e.PurchaseInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseInvoiceId");

                entity.Property(e => e.PurchaseOrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseOrderNo");

                entity.Property(e => e.PurchasePricePercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");

                entity.Property(e => e.TradePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblPurchaseInvoiceImportDetail>(entity =>
            {
                entity.HasKey(e => e.PurchaseImpInvoiceDetailsId);

                entity.ToTable("tbl_PurchaseInvoiceImportDetails");

                entity.Property(e => e.PurchaseImpInvoiceDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("purchaseImpInvoiceDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.BorrowedFromTo)
                    .HasMaxLength(50)
                    .HasColumnName("borrowedFromTo");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.InvoicePertainsTo).HasColumnName("invoicePertainsTo");

                entity.Property(e => e.Paid)
                    .HasMaxLength(50)
                    .HasColumnName("paid");

                entity.Property(e => e.Prate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PRate");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("projectId");

                entity.Property(e => e.PurchaseImpInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseImpInvoiceId");

                entity.Property(e => e.PurchaseOrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseOrderNo");

                entity.Property(e => e.PurchasePricePercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");

                entity.Property(e => e.TradePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblPurchaseInvoiceImportMaster>(entity =>
            {
                entity.HasKey(e => e.PurchaseImpInvoiceId)
                    .HasName("PK_tbl_PurchaseInvoiceImpoprtMaster");

                entity.ToTable("tbl_PurchaseInvoiceImportMaster");

                entity.Property(e => e.PurchaseImpInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseImpInvoiceId");

                entity.Property(e => e.BalanceDue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("balanceDue");

                entity.Property(e => e.Batch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batch");

                entity.Property(e => e.ChkBatchOnAll).HasColumnName("chkBatchOnAll");

                entity.Property(e => e.ChkExpiryOnAll).HasColumnName("chkExpiryOnAll");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("currencyId");

                entity.Property(e => e.DiscountAllowed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountAllowed");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .HasColumnName("dueDate");

                entity.Property(e => e.Expiry)
                    .HasColumnType("date")
                    .HasColumnName("expiry");

                entity.Property(e => e.Freight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("freight");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.PurchaseImpDeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("purchaseImpDeliveryDate");

                entity.Property(e => e.PurchaseImpDocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("purchaseImpDocumentDate");

                entity.Property(e => e.PurchaseImpInvoiceNarration).HasColumnName("purchaseImpInvoiceNarration");

                entity.Property(e => e.PurchaseImpInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseImpInvoiceNo");

                entity.Property(e => e.PurchaseImpInvoiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseImpInvoiceStatus");

                entity.Property(e => e.PurchaseImpPostingDate)
                    .HasColumnType("date")
                    .HasColumnName("purchaseImpPostingDate");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.ShipmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("shipmentId");

                entity.Property(e => e.ShippingAddress).HasColumnName("shippingAddress");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.SupplierId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("supplierId");

                entity.Property(e => e.SupplierRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplierRefNo");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.TotalDownPayment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDownPayment");

                entity.Property(e => e.Totaltax)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totaltax");

                entity.Property(e => e.VendorInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vendorInvoiceNo");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");

                entity.Property(e => e.WarehouseId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("warehouseId");
            });

            modelBuilder.Entity<TblPurchaseInvoiceInstallment>(entity =>
            {
                entity.HasKey(e => e.PurchaseInstallmentsId);

                entity.ToTable("tbl_PurchaseInvoiceInstallments");

                entity.Property(e => e.PurchaseInstallmentsId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Installment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("installment");

                entity.Property(e => e.PurchaseInvoiceId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("purchaseInvoiceId");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TblPurchaseInvoiceMaster>(entity =>
            {
                entity.HasKey(e => e.PurchaseInvoiceId);

                entity.ToTable("tbl_PurchaseInvoiceMaster");

                entity.Property(e => e.PurchaseInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseInvoiceId");

                entity.Property(e => e.BalanceDue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("balanceDue");

                entity.Property(e => e.Batch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batch");

                entity.Property(e => e.ChkBatchOnAll).HasColumnName("chkBatchOnAll");

                entity.Property(e => e.ChkExpiryOnAll).HasColumnName("chkExpiryOnAll");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("currencyId");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("departmentId")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscountAllowed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountAllowed");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .HasColumnName("dueDate");

                entity.Property(e => e.Expiry)
                    .HasColumnType("date")
                    .HasColumnName("expiry");

                entity.Property(e => e.Freight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("freight");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.PurchaseDeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("purchaseDeliveryDate");

                entity.Property(e => e.PurchaseDocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("purchaseDocumentDate");

                entity.Property(e => e.PurchaseInvoiceNarration).HasColumnName("purchaseInvoiceNarration");

                entity.Property(e => e.PurchaseInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseInvoiceNo");

                entity.Property(e => e.PurchaseInvoiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseInvoiceStatus");

                entity.Property(e => e.PurchasePostingDate)
                    .HasColumnType("date")
                    .HasColumnName("purchasePostingDate");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.ShipmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("shipmentId");

                entity.Property(e => e.ShippingAddress).HasColumnName("shippingAddress");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.SupplierId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("supplierId");

                entity.Property(e => e.SupplierRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplierRefNo");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.TotalDownPayment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDownPayment");

                entity.Property(e => e.Totaltax)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totaltax");

                entity.Property(e => e.VendorInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vendorInvoiceNo");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");

                entity.Property(e => e.WarehouseId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("warehouseId");
            });

            modelBuilder.Entity<TblPurchaseOrderDetail>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrderDetailsId);

                entity.ToTable("tbl_PurchaseOrderDetails");

                entity.Property(e => e.PurchaseOrderDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("purchaseOrderDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.PurchaseOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseOrderId");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblPurchaseOrderMaster>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrderId);

                entity.ToTable("tbl_PurchaseOrderMaster");

                entity.Property(e => e.PurchaseOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseOrderId");

                entity.Property(e => e.CurrencyId).HasColumnName("currencyId");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("deliveryDate");

                entity.Property(e => e.DiscountAllowed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountAllowed");

                entity.Property(e => e.DocumentDate)
                    .HasColumnType("date")
                    .HasColumnName("documentDate");

                entity.Property(e => e.Freight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("freight");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("date")
                    .HasColumnName("postingDate");

                entity.Property(e => e.PricingLevelId).HasColumnName("pricingLevelId");

                entity.Property(e => e.PurchaseOrderNarration).HasColumnName("purchaseOrderNarration");

                entity.Property(e => e.PurchaseOrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseOrderNo");

                entity.Property(e => e.PurchaseOrderisApproved).HasColumnName("purchaseOrderisApproved");

                entity.Property(e => e.PurchaseOrderstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseOrderstatus");

                entity.Property(e => e.SalesmanId).HasColumnName("salesmanId");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.SupplierId).HasColumnName("supplierId");

                entity.Property(e => e.SupplierReferenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplierReferenceNo");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<TblPurchasePriceListDetail>(entity =>
            {
                entity.HasKey(e => e.PurchasePriceListId);

                entity.ToTable("tbl_PurchasePriceListDetails");

                entity.Property(e => e.PurchasePriceListId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("purchasePriceListId");

                entity.Property(e => e.PricingLevelId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productId");

                entity.Property(e => e.PurchaseRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchaseRate");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");
            });

            modelBuilder.Entity<TblPurchasePriceListDetailsLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_PurchasePriceListDetails_Log");

                entity.Property(e => e.PricingLevelId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productId");

                entity.Property(e => e.PurchasePriceListId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("purchasePriceListId");

                entity.Property(e => e.PurchaseRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchaseRate");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.UpdaterDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdaterEmployeeId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("UpdaterEmployeeID");

                entity.Property(e => e.UpdaterEmployeeName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdaterTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPurchasePriceListMaster>(entity =>
            {
                entity.HasKey(e => e.PurchasePriceListId)
                    .HasName("PK_tbl_PriceListMaster");

                entity.ToTable("tbl_PurchasePriceListMaster");

                entity.Property(e => e.PurchasePriceListId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("purchasePriceListId");

                entity.Property(e => e.ApplicableFrom)
                    .HasColumnType("date")
                    .HasColumnName("applicableFrom");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");
            });

            modelBuilder.Entity<TblPurchaseQoutationDetail>(entity =>
            {
                entity.HasKey(e => e.PurchaseQoutationDetailsId);

                entity.ToTable("tbl_PurchaseQoutationDetails");

                entity.Property(e => e.PurchaseQoutationDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("purchaseQoutationDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.QoutationId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QoutationNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("qoutationNo");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblPurchaseQoutationMaster>(entity =>
            {
                entity.HasKey(e => e.QoutationId)
                    .HasName("PK_tbl_PurchaseQoutation");

                entity.ToTable("tbl_PurchaseQoutationMaster");

                entity.Property(e => e.QoutationId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("currencyId");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("deliveryDate");

                entity.Property(e => e.DiscountAllowed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountAllowed");

                entity.Property(e => e.DocumentDate)
                    .HasColumnType("date")
                    .HasColumnName("documentDate");

                entity.Property(e => e.Freight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("freight");

                entity.Property(e => e.IsApproved).HasColumnName("isApproved");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("date")
                    .HasColumnName("postingDate");

                entity.Property(e => e.PricingLevelId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.QoutationNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("qoutationNo");

                entity.Property(e => e.SalesmanId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesmanId");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.SupplierId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplierId");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<TblPurchaseReturnBillTax>(entity =>
            {
                entity.HasKey(e => e.PurchaseReturnBillTaxId);

                entity.ToTable("tbl_PurchaseReturnBillTax");

                entity.Property(e => e.PurchaseReturnBillTaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("purchaseReturnBillTaxId");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.PurchaseReturnMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("purchaseReturnMasterId");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");
            });

            modelBuilder.Entity<TblPurchaseReturnDetail>(entity =>
            {
                entity.HasKey(e => e.PurchaseReturnDetailsId);

                entity.ToTable("tbl_PurchaseReturnDetails");

                entity.Property(e => e.PurchaseReturnDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("purchaseReturnDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.PurchaseBonusQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchaseBonusQty");

                entity.Property(e => e.PurchaseDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchaseDiscount");

                entity.Property(e => e.PurchaseInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseInvoiceId");

                entity.Property(e => e.PurchaseQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchaseQty");

                entity.Property(e => e.PurchaseReturnMasterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseReturnMasterId");

                entity.Property(e => e.PurchaseUom).HasColumnName("purchaseUOM");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.ReturnBonusQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("returnBonusQty");

                entity.Property(e => e.ReturnQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("returnQty");

                entity.Property(e => e.ReturnUomid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("returnUOMId");

                entity.Property(e => e.ReturnUomname).HasColumnName("returnUOMName");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");
            });

            modelBuilder.Entity<TblPurchaseReturnMaster>(entity =>
            {
                entity.HasKey(e => e.PurchaseReturnMasterId);

                entity.ToTable("tbl_PurchaseReturnMaster");

                entity.Property(e => e.PurchaseReturnMasterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseReturnMasterId");

                entity.Property(e => e.BalanceDue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("balanceDue");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("currencyId");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("departmentId")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscountAllowed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountAllowed");

                entity.Property(e => e.Freight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("freight");

                entity.Property(e => e.InvoiceBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceDownPayment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceFreight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceSubtotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.PurchaseInvoiceDeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("purchaseInvoiceDeliveryDate");

                entity.Property(e => e.PurchaseInvoiceDocumentDate)
                    .HasColumnType("date")
                    .HasColumnName("purchaseInvoiceDocumentDate");

                entity.Property(e => e.PurchaseInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseInvoiceId");

                entity.Property(e => e.PurchaseInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseInvoiceNo");

                entity.Property(e => e.PurchaseInvoicePostingDate)
                    .HasColumnType("date")
                    .HasColumnName("purchaseInvoicePostingDate");

                entity.Property(e => e.PurchaseReturnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("purchaseReturnDate");

                entity.Property(e => e.PurchaseReturnNarration).HasColumnName("purchaseReturnNarration");

                entity.Property(e => e.PurchaseReturnNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseReturnNo");

                entity.Property(e => e.ReturnAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("returnAmount");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.SupplierId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("supplierId");

                entity.Property(e => e.SupplierRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplierRefNo");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.WarehouseId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("warehouseId");
            });

            modelBuilder.Entity<TblRack>(entity =>
            {
                entity.HasKey(e => e.RackId)
                    .HasName("PK__tbl_Rack__B34912495555A4F4");

                entity.ToTable("tbl_Rack");

                entity.Property(e => e.RackId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rackId");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.GodownId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("godownId");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.RackName)
                    .IsUnicode(false)
                    .HasColumnName("rackName");
            });

            modelBuilder.Entity<TblRange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Ranges");

                entity.Property(e => e.Descp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descp");

                entity.Property(e => e.Range)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestId).HasColumnName("Test_ID");
            });

            modelBuilder.Entity<TblRateType>(entity =>
            {
                entity.HasKey(e => e.RateTypeId);

                entity.ToTable("tbl_RateType");

                entity.Property(e => e.RateTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("rateTypeId");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.PlanType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("planType");

                entity.Property(e => e.PlanTypeValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RateTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rateTypeName");
            });

            modelBuilder.Entity<TblReOrderLevel>(entity =>
            {
                entity.HasKey(e => e.ReOrderLevelId);

                entity.ToTable("tbl_ReOrderLevel");

                entity.Property(e => e.ReOrderLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("reOrderLevelId");

                entity.Property(e => e.ProductId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productId");

                entity.Property(e => e.ReOrderLevel)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("reOrderLevel");

                entity.Property(e => e.UomId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("uomId");

                entity.Property(e => e.UomIdName).HasColumnName("uomIdName");
            });

            modelBuilder.Entity<TblReceiptDetail>(entity =>
            {
                entity.HasKey(e => e.ReceiptDetailsId)
                    .HasName("PK__tbl_Rece__C0FF33FB6EA14102");

                entity.ToTable("tbl_ReceiptDetails");

                entity.Property(e => e.ReceiptDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("receiptDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.BorrowedFromTo)
                    .HasMaxLength(50)
                    .HasColumnName("borrowedFromTo");

                entity.Property(e => e.ChequeDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chequeDate");

                entity.Property(e => e.ChequeNo)
                    .IsUnicode(false)
                    .HasColumnName("chequeNo");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.InvoicePertainsTo).HasColumnName("invoicePertainsTo");

                entity.Property(e => e.LedgerBalance).HasMaxLength(50);

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.Paid)
                    .HasMaxLength(50)
                    .HasColumnName("paid");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("projectId");

                entity.Property(e => e.ReceiptMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("receiptMasterId");

                entity.Property(e => e.RemainingBalance).HasMaxLength(50);

                entity.Property(e => e.SaleInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleInvoiceNo");
            });

            modelBuilder.Entity<TblReceiptMaster>(entity =>
            {
                entity.HasKey(e => e.ReceiptMasterId)
                    .HasName("PK__tbl_Rece__B974C2984925A390");

                entity.ToTable("tbl_ReceiptMaster");

                entity.Property(e => e.ReceiptMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("receiptMasterId");

                entity.Property(e => e.CashierId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cashierId");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("departmentId")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.Mop)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mop");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMethodId");

                entity.Property(e => e.SalesStaffId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesStaffId");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalAmount");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voucherNo");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblReconcileChequeDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_ReconcileChequeDetails");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accountId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.BankCharges)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bankCharges");

                entity.Property(e => e.ChequeDate)
                    .HasColumnType("date")
                    .HasColumnName("chequeDate");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chequeNo");

                entity.Property(e => e.ChequeSeries)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chequeSeries");

                entity.Property(e => e.ClearanceDate)
                    .HasColumnType("date")
                    .HasColumnName("clearanceDate");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("date")
                    .HasColumnName("issueDate");

                entity.Property(e => e.IssuerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("issuerId");

                entity.Property(e => e.PayeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("payeeId");

                entity.Property(e => e.PaymentMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMasterId");

                entity.Property(e => e.ReconcileDetailsId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TblRegisteratationDeliveryAttachment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_RegisteratationDeliveryAttachments");

                entity.Property(e => e.AttachmentId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Extenstion).HasColumnName("extenstion");

                entity.Property(e => e.FileName).HasColumnName("fileName");

                entity.Property(e => e.FileType).HasColumnName("fileType");

                entity.Property(e => e.LetterNo).HasMaxLength(50);

                entity.Property(e => e.Path).HasColumnName("path");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<TblRegisteration>(entity =>
            {
                entity.ToTable("tbl_Registeration");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.ApplicationId).HasMaxLength(50);

                entity.Property(e => e.ApplicationKey).IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Crm).HasColumnName("CRM");

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.EndingDate).HasColumnType("date");

                entity.Property(e => e.Hrmadvance).HasColumnName("HRMAdvance");

                entity.Property(e => e.Hrmsimple).HasColumnName("HRMSimple");

                entity.Property(e => e.LicensePlan).HasMaxLength(50);

                entity.Property(e => e.LiscenseNo).HasMaxLength(50);

                entity.Property(e => e.LiscenseStatus).HasMaxLength(50);

                entity.Property(e => e.LiscenseType).HasMaxLength(50);

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.Package).HasMaxLength(50);

                entity.Property(e => e.Panno)
                    .HasMaxLength(50)
                    .HasColumnName("PANNo");

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.RegisterationKey).IsUnicode(false);

                entity.Property(e => e.ServerUrl)
                    .HasMaxLength(50)
                    .HasColumnName("ServerURL");

                entity.Property(e => e.StartingDate).HasColumnType("date");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Tinno)
                    .HasMaxLength(50)
                    .HasColumnName("TINNo");

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Website).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRegisterationDetail>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("tbl_RegisterationDetail");

                entity.Property(e => e.InstallationDate).HasColumnType("date");

                entity.Property(e => e.MachineType).HasMaxLength(50);

                entity.Property(e => e.Macid)
                    .HasMaxLength(50)
                    .HasColumnName("MACID");

                entity.Property(e => e.Message).HasMaxLength(50);

                entity.Property(e => e.OperatingSystem).HasMaxLength(50);

                entity.Property(e => e.SubModuleId).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRegisterationDetailLog>(entity =>
            {
                entity.HasKey(e => e.DetailId)
                    .HasName("PK_tbl_RegisterationDetailLog_1");

                entity.ToTable("tbl_RegisterationDetailLog");

                entity.Property(e => e.InstallationDate).HasColumnType("date");

                entity.Property(e => e.MachineType).HasMaxLength(50);

                entity.Property(e => e.Macid)
                    .HasMaxLength(50)
                    .HasColumnName("MACID");

                entity.Property(e => e.Message).HasMaxLength(50);

                entity.Property(e => e.OperatingSystem).HasMaxLength(50);

                entity.Property(e => e.SubModuleId).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRegisterationLog>(entity =>
            {
                entity.ToTable("tbl_RegisterationLog");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.ApplicationKey).IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Crm).HasColumnName("CRM");

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.EndingDate).HasColumnType("date");

                entity.Property(e => e.Hrmadvance).HasColumnName("HRMAdvance");

                entity.Property(e => e.Hrmsimple).HasColumnName("HRMSimple");

                entity.Property(e => e.LicensePlan).HasMaxLength(50);

                entity.Property(e => e.LiscenseNo).HasMaxLength(50);

                entity.Property(e => e.LiscenseStatus).HasMaxLength(50);

                entity.Property(e => e.LiscenseType).HasMaxLength(50);

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.Package).HasMaxLength(50);

                entity.Property(e => e.Panno)
                    .HasMaxLength(50)
                    .HasColumnName("PANNo");

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.RegisterationKey).IsUnicode(false);

                entity.Property(e => e.ServerUrl)
                    .HasMaxLength(50)
                    .HasColumnName("ServerURL");

                entity.Property(e => e.StartingDate).HasColumnType("date");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Tinno)
                    .HasMaxLength(50)
                    .HasColumnName("TINNo");

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.Website).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRegisterationLogAttempt>(entity =>
            {
                entity.ToTable("tbl_RegisterationLogAttempt");

                entity.Property(e => e.InstallationDate).HasColumnType("date");

                entity.Property(e => e.MachineType).HasMaxLength(50);

                entity.Property(e => e.Macid).HasColumnName("MACID");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.SubModuleId).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRegisterationSubModuleDetail>(entity =>
            {
                entity.HasKey(e => e.SubModuleDetailId);

                entity.ToTable("tbl_RegisterationSubModuleDetail");

                entity.Property(e => e.NoOfMachines).HasMaxLength(50);

                entity.Property(e => e.SubModuleName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRegistrationFeeDeposit>(entity =>
            {
                entity.HasKey(e => e.RegistrationFeeDespositId);

                entity.ToTable("tbl_RegistrationFeeDeposits");

                entity.Property(e => e.RegistrationFeeDespositId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("registrationFeeDespositId");

                entity.Property(e => e.BalanceDue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("balanceDue");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerId");

                entity.Property(e => e.DepositDate)
                    .HasColumnType("datetime")
                    .HasColumnName("depositDate");

                entity.Property(e => e.DownPayment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("downPayment");

                entity.Property(e => e.ExtraFee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("extraFee");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.LetterId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LiftTimeTokenFee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("liftTimeTokenFee");

                entity.Property(e => e.NumberPlateFee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("numberPlateFee");

                entity.Property(e => e.RegistrationBookFee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("registrationBookFee");

                entity.Property(e => e.RegistrationFee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("registrationFee");

                entity.Property(e => e.RegistrationFeeDespositNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("registrationFeeDespositNo");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<TblReminder>(entity =>
            {
                entity.HasKey(e => e.ReminderId);

                entity.ToTable("tbl_Reminders");

                entity.Property(e => e.ReminderId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("reminderId");

                entity.Property(e => e.Details)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.Reminder)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reminder");

                entity.Property(e => e.ReminderDate)
                    .HasColumnType("date")
                    .HasColumnName("reminderDate");

                entity.Property(e => e.ReminderTime).HasColumnName("reminderTime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<TblRentalUnitValue>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("tbl_RentalUnitValue");

                entity.Property(e => e.UnitId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValueToMinus)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("valueToMinus");
            });

            modelBuilder.Entity<TblReportSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblReportSetting");

                entity.Property(e => e.Rowindex).HasColumnName("rowindex");

                entity.Property(e => e.TestCat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRestaurantSaleDetail>(entity =>
            {
                entity.HasKey(e => e.SalesInvoiceDetailsId);

                entity.ToTable("tbl_RestaurantSaleDetails");

                entity.Property(e => e.SalesInvoiceDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesInvoiceDetailsId");

                entity.Property(e => e.ActualUnitCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("actualUnitCost");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.BorrowedFromTo)
                    .HasMaxLength(50)
                    .HasColumnName("borrowedFromTo");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.DealId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("dealId");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.InvoicePertainsTo).HasColumnName("invoicePertainsTo");

                entity.Property(e => e.Paid)
                    .HasMaxLength(50)
                    .HasColumnName("paid");

                entity.Property(e => e.PriceInPkr)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("priceInPkr");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("projectId");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("salePrice");

                entity.Property(e => e.SalePricePercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceId");

                entity.Property(e => e.SalesInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceNo");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");

                entity.Property(e => e.TradePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblRestaurantTokenNo>(entity =>
            {
                entity.HasKey(e => e.TokenNo);

                entity.ToTable("tbl_RestaurantTokenNo");

                entity.Property(e => e.TokenNo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("tokenNo");
            });

            modelBuilder.Entity<TblRestaurantTransaction>(entity =>
            {
                entity.HasKey(e => e.RestaurantTransactionsId);

                entity.ToTable("tbl_RestaurantTransactions");

                entity.Property(e => e.RestaurantTransactionsId).HasColumnName("restaurantTransactionsId");

                entity.Property(e => e.ActualQty).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kotstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KOTStatus");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Unit_Price");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblRestaurantTransactionsMaster>(entity =>
            {
                entity.HasKey(e => e.RestaurantTransactionsMasterId);

                entity.ToTable("tbl_RestaurantTransactionsMaster");

                entity.Property(e => e.RestaurantTransactionsMasterId).HasColumnName("restaurantTransactionsMasterId");

                entity.Property(e => e.BalanceDue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CookId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cookId");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CustomerMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_Name");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DownPayment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Freight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrandTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Grand_Total");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KOT");

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Order_Type");

                entity.Property(e => e.RiderId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.SubTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Sub_Total");

                entity.Property(e => e.Table)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Time)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Total_Discount");

                entity.Property(e => e.WaiterId).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TblReturnIssueStockDetail>(entity =>
            {
                entity.HasKey(e => e.ReturnIssueStockDetailsId);

                entity.ToTable("tbl_ReturnIssueStockDetails");

                entity.Property(e => e.ReturnIssueStockDetailsId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.PurchasePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchasePrice");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("quantity");

                entity.Property(e => e.ReturnIssueStockMasterId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReturnQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblReturnIssueStockMaster>(entity =>
            {
                entity.HasKey(e => e.ReturnIssueStockMasterId)
                    .HasName("PK_tbl_ReturnIssueStockMaster_1");

                entity.ToTable("tbl_ReturnIssueStockMaster");

                entity.Property(e => e.ReturnIssueStockMasterId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("departmentId");

                entity.Property(e => e.DocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("documentDate");

                entity.Property(e => e.IngredientsCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ingredientsCost");

                entity.Property(e => e.IssueStockMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("issueStockMasterId");

                entity.Property(e => e.IssueStockNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("issueStockNo");

                entity.Property(e => e.Memo).HasColumnName("memo");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.ReturnIssueStockNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesStaffId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesStaffId");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("tbl_Role");

                entity.Property(e => e.RoleId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("roleId");

                entity.Property(e => e.Narration)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("roleName");
            });

            modelBuilder.Entity<TblRoom>(entity =>
            {
                entity.HasKey(e => e.RoomId);

                entity.ToTable("tbl_Room");

                entity.Property(e => e.RoomId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("roomId");

                entity.Property(e => e.ExtensioNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extensioNo");

                entity.Property(e => e.FloorId).HasColumnName("floorId");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.RoomName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("roomName");

                entity.Property(e => e.RoomTypeId).HasColumnName("roomTypeId");
            });

            modelBuilder.Entity<TblRoomBookingCancel>(entity =>
            {
                entity.HasKey(e => e.CancellationId);

                entity.ToTable("tbl_RoomBookingCancel");

                entity.Property(e => e.CancellationId).ValueGeneratedNever();

                entity.Property(e => e.AmountPercentage).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CancellationFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CancelledDate).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReservationNo).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRoomBookingCancelMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_RoomBookingCancelMaster");

                entity.Property(e => e.ArrivalDate).HasColumnType("date");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.CityId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cityId")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .HasColumnName("CNIC");

                entity.Property(e => e.DepartureDate).HasColumnType("date");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FathersName)
                    .HasMaxLength(50)
                    .HasColumnName("fathersName");

                entity.Property(e => e.FolioNo).HasMaxLength(50);

                entity.Property(e => e.GrandTotal).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LedgerCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ledgerCode");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.LedgerName)
                    .HasMaxLength(50)
                    .HasColumnName("ledgerName");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .HasColumnName("mobile");

                entity.Property(e => e.NoOfAdults).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NoOfChilds).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NoOfHours).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NoOfMonths).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NoOfNights).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("paymentMethodId");

                entity.Property(e => e.RateTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("rateTypeId");

                entity.Property(e => e.ReservationDate).HasColumnType("date");

                entity.Property(e => e.ReservationId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReservationNo).HasMaxLength(50);

                entity.Property(e => e.ReservationStatus).HasMaxLength(50);

                entity.Property(e => e.RoomId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("roomId");

                entity.Property(e => e.RoomTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("roomTypeId");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.SeasonId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("seasonId");

                entity.Property(e => e.SeasonTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("seasonTypeId");

                entity.Property(e => e.ShiftUserid).HasColumnName("shiftUserid");

                entity.Property(e => e.Shiftid).HasColumnName("shiftid");

                entity.Property(e => e.StayType).HasMaxLength(50);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblRoomBookingCancelScheduleDetail>(entity =>
            {
                entity.HasKey(e => e.ScheduleDetailId);

                entity.ToTable("tbl_RoomBookingCancelScheduleDetails");

                entity.Property(e => e.ScheduleDetailId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReservationDate).HasMaxLength(50);

                entity.Property(e => e.ReservationId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReservationStatus).HasMaxLength(50);

                entity.Property(e => e.ReservationType).HasMaxLength(50);

                entity.Property(e => e.ReservationValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RoomId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("roomId");

                entity.Property(e => e.ScheduleDate).HasColumnType("date");

                entity.Property(e => e.ScheduleEndDate).HasMaxLength(50);

                entity.Property(e => e.ScheduleStartDate).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRoomBookingMaster>(entity =>
            {
                entity.HasKey(e => e.ReservationId);

                entity.ToTable("tbl_RoomBookingMaster");

                entity.Property(e => e.ReservationId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ArrivalDate).HasColumnType("date");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.CityId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cityId")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .HasColumnName("CNIC");

                entity.Property(e => e.DepartureDate).HasColumnType("date");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FathersName)
                    .HasMaxLength(50)
                    .HasColumnName("fathersName");

                entity.Property(e => e.FolioNo).HasMaxLength(50);

                entity.Property(e => e.GrandTotal).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LedgerCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ledgerCode");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.LedgerName)
                    .HasMaxLength(50)
                    .HasColumnName("ledgerName");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .HasColumnName("mobile");

                entity.Property(e => e.NoOfAdults).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NoOfChilds).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NoOfHours).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NoOfMonths).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NoOfNights).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("paymentMethodId");

                entity.Property(e => e.RateTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("rateTypeId");

                entity.Property(e => e.ReservationDate).HasColumnType("date");

                entity.Property(e => e.ReservationNo).HasMaxLength(50);

                entity.Property(e => e.ReservationStatus).HasMaxLength(50);

                entity.Property(e => e.RoomId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("roomId");

                entity.Property(e => e.RoomTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("roomTypeId");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.SeasonId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("seasonId");

                entity.Property(e => e.SeasonTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("seasonTypeId");

                entity.Property(e => e.ShiftUserid).HasColumnName("shiftUserid");

                entity.Property(e => e.Shiftid).HasColumnName("shiftid");

                entity.Property(e => e.StayType).HasMaxLength(50);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblRoomBookingScheduleDetail>(entity =>
            {
                entity.HasKey(e => e.ScheduleDetailId);

                entity.ToTable("tbl_RoomBookingScheduleDetails");

                entity.Property(e => e.ScheduleDetailId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReservationDate).HasMaxLength(50);

                entity.Property(e => e.ReservationId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReservationStatus).HasMaxLength(50);

                entity.Property(e => e.ReservationType).HasMaxLength(50);

                entity.Property(e => e.ReservationValue).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RoomId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("roomId");

                entity.Property(e => e.ScheduleDate).HasColumnType("date");

                entity.Property(e => e.ScheduleEndDate).HasMaxLength(50);

                entity.Property(e => e.ScheduleStartDate).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRoomBookingTimelineDetail>(entity =>
            {
                entity.HasKey(e => e.TimelineDetailId);

                entity.ToTable("tbl_RoomBookingTimelineDetails");

                entity.Property(e => e.TimelineDetailId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Credit)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("credit");

                entity.Property(e => e.Debit)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("debit");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.DocumentDate).HasColumnType("date");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.Refrence).HasMaxLength(50);

                entity.Property(e => e.ReservationId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(50)
                    .HasColumnName("voucherNo");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("voucherTypeId");

                entity.Property(e => e.YearId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("yearId");
            });

            modelBuilder.Entity<TblRoomImage>(entity =>
            {
                entity.HasKey(e => e.RoomImageDetailId);

                entity.ToTable("tbl_RoomImages");

                entity.Property(e => e.RoomImageDetailId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("RoomImageDetailID");

                entity.Property(e => e.Extension)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoomId).HasColumnName("roomId");
            });
           

            modelBuilder.Entity<TblRoomTariff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_RoomTariff");

                entity.Property(e => e.BuisnessSourceId).HasColumnName("BuisnessSourceID");

                entity.Property(e => e.ExtraAdult).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ExtraChild).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RateTypeId).HasColumnName("RateTypeID");

                entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

                entity.Property(e => e.Tariff).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TariffId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TariffType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRoomTypeAmentiesDetail>(entity =>
            {
                entity.HasKey(e => e.RoomTypeAmentiesId)
                    .HasName("PK_tbl_RoomTypeDetails");

                entity.ToTable("tbl_RoomTypeAmentiesDetails");

                entity.Property(e => e.RoomTypeAmentiesId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("roomTypeAmentiesId");

                entity.Property(e => e.AmentiesId).HasColumnName("AmentiesID");

                entity.Property(e => e.RoomTypeId).HasColumnName("roomTypeId");
            });

            modelBuilder.Entity<TblRoomTypeHouseKeepingDetail>(entity =>
            {
                entity.HasKey(e => e.RoomTypeHouseKeepingId);

                entity.ToTable("tbl_RoomTypeHouseKeepingDetails");

                entity.Property(e => e.RoomTypeHouseKeepingId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("roomTypeHouseKeepingId");

                entity.Property(e => e.RoomTypeId).HasColumnName("roomTypeId");

                entity.Property(e => e.WeekDayValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRoomTypeImage>(entity =>
            {
                entity.HasKey(e => e.RoomTypeId);

                entity.ToTable("tbl_RoomTypeImages");

                entity.Property(e => e.RoomTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("roomTypeId");

                entity.Property(e => e.RoomTypeImage)
                    .HasColumnType("image")
                    .HasColumnName("roomTypeImage");
            });
            modelBuilder.Entity<TblAmentiesImage>(entity =>
            {
                entity.HasKey(e => e.amentiesId);

                entity.ToTable("tbl_AmentiesImage");

                entity.Property(e => e.amentiesId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amentiesId");

                entity.Property(e => e.amentiesImage)
                    .HasColumnType("image")
                    .HasColumnName("amentiesImage");
            });
            modelBuilder.Entity<TblRoomTypeMaster>(entity =>
            {
                entity.HasKey(e => e.RoomTypeId);

                entity.ToTable("tbl_RoomTypeMaster");

                entity.Property(e => e.RoomTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("roomTypeId");

                entity.Property(e => e.BackColor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraAdultPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ExtraChildPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RoomTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("roomTypeName");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRoute>(entity =>
            {
                entity.HasKey(e => e.RouteId);

                entity.ToTable("tbl_Route");

                entity.Property(e => e.RouteId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("routeId");

                entity.Property(e => e.AreaId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("areaId");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.RouteName).HasColumnName("routeName");
            });

            modelBuilder.Entity<TblSalaryChequeDetail>(entity =>
            {
                entity.HasKey(e => e.SalarychequeDetailsId);

                entity.ToTable("tbl_SalaryChequeDetails");

                entity.Property(e => e.SalarychequeDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salarychequeDetailsId");

                entity.Property(e => e.AccountId)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("accountId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.BankCharges)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bankCharges");

                entity.Property(e => e.ChequeDate)
                    .HasColumnType("date")
                    .HasColumnName("chequeDate");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chequeNo");

                entity.Property(e => e.ChequeSeries)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chequeSeries");

                entity.Property(e => e.ClearanceDate)
                    .HasColumnType("date")
                    .HasColumnName("clearanceDate");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("date")
                    .HasColumnName("issueDate");

                entity.Property(e => e.IssuerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("issuerId");

                entity.Property(e => e.PayeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("payeeId");

                entity.Property(e => e.SalarypaymentMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salarypaymentMasterId");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TblSalaryPaymentDetail>(entity =>
            {
                entity.HasKey(e => e.SalarypaymentDetailsId)
                    .HasName("PK_tbl_SalaryPaymentDetails_1");

                entity.ToTable("tbl_SalaryPaymentDetails");

                entity.Property(e => e.SalarypaymentDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salarypaymentDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.BorrowedFromTo)
                    .HasMaxLength(50)
                    .HasColumnName("borrowedFromTo");

                entity.Property(e => e.ChequeDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chequeDate");

                entity.Property(e => e.ChequeNo)
                    .IsUnicode(false)
                    .HasColumnName("chequeNo");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.InvoicePertainsTo).HasColumnName("invoicePertainsTo");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("date")
                    .HasColumnName("issueDate");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.Paid)
                    .HasMaxLength(50)
                    .HasColumnName("paid");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("projectId");

                entity.Property(e => e.SalarypaymentMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salarypaymentMasterId");
            });

            modelBuilder.Entity<TblSalaryPaymentMaster>(entity =>
            {
                entity.HasKey(e => e.SalarypaymentMasterId);

                entity.ToTable("tbl_SalaryPaymentMaster");

                entity.Property(e => e.SalarypaymentMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salarypaymentMasterId");

                entity.Property(e => e.CashierId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cashierId");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departmentId");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("endDate");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMethodId");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("startDate");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("totalAmount");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voucherNo");

                entity.Property(e => e.VoucherType)
                    .HasMaxLength(50)
                    .HasColumnName("voucherType");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblSalaryStructureDetail>(entity =>
            {
                entity.HasKey(e => e.SalaryStructureDetailId);

                entity.ToTable("tbl_SalaryStructureDetails");

                entity.Property(e => e.SalaryStructureDetailId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CalculationBasis).HasMaxLength(50);

                entity.Property(e => e.EffectedFrom).HasColumnType("date");

                entity.Property(e => e.PayHeadId).HasColumnName("payHeadId");
            });

            modelBuilder.Entity<TblSalaryStructureMaster>(entity =>
            {
                entity.HasKey(e => e.SalaryStructureId);

                entity.ToTable("tbl_SalaryStructureMaster");

                entity.Property(e => e.SalaryStructureId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employeeId");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.SalryCreationType)
                    .HasMaxLength(50)
                    .HasColumnName("salryCreationType");
            });

            modelBuilder.Entity<TblSaleAcLedger>(entity =>
            {
                entity.HasKey(e => e.SaleAcLedgerId);

                entity.ToTable("tbl_SaleAcLedger");

                entity.Property(e => e.SaleAcLedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("saleAcLedgerId");

                entity.Property(e => e.Credit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("credit");

                entity.Property(e => e.Debit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("debit");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voucherNo");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblSaleAcLedgerDuplicate>(entity =>
            {
                entity.HasKey(e => e.SaleAcLedgerId);

                entity.ToTable("tbl_SaleAcLedgerDuplicate");

                entity.Property(e => e.SaleAcLedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("saleAcLedgerId");

                entity.Property(e => e.Credit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("credit");

                entity.Property(e => e.Debit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("debit");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voucherNo");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblSaleBillTax>(entity =>
            {
                entity.HasKey(e => e.SaleBillTaxId);

                entity.ToTable("tbl_SaleBillTax");

                entity.Property(e => e.SaleBillTaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("saleBillTaxId");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");
            });

            modelBuilder.Entity<TblSaleBillTaxDuplicate>(entity =>
            {
                entity.HasKey(e => e.SaleBillTaxId);

                entity.ToTable("tbl_SaleBillTaxDuplicate");

                entity.Property(e => e.SaleBillTaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("saleBillTaxId");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");
            });

            modelBuilder.Entity<TblSaleDeliveryOrderDetail>(entity =>
            {
                entity.HasKey(e => e.SaleDodetailsId);

                entity.ToTable("tbl_SaleDeliveryOrderDetails");

                entity.Property(e => e.SaleDodetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("saleDODetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.DeliveredQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("deliveredQty");

                entity.Property(e => e.DeliveryUomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("deliveryUOMId");

                entity.Property(e => e.DeliveryUomname).HasColumnName("deliveryUOMName");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.PurchaseBonusQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchaseBonusQty");

                entity.Property(e => e.PurchaseDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchaseDiscount");

                entity.Property(e => e.PurchaseQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchaseQty");

                entity.Property(e => e.PurchaseUom).HasColumnName("purchaseUOM");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.ReturnBonusQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("returnBonusQty");

                entity.Property(e => e.ReturnQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("returnQty");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.SaleDomasterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleDOMasterId");

                entity.Property(e => e.SalesInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceId");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");
            });

            modelBuilder.Entity<TblSaleDeliveryOrderMaster>(entity =>
            {
                entity.HasKey(e => e.SaleDomasterId);

                entity.ToTable("tbl_SaleDeliveryOrderMaster");

                entity.Property(e => e.SaleDomasterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleDOMasterId");

                entity.Property(e => e.BalanceDue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("balanceDue");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("currencyId");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerId");

                entity.Property(e => e.CustomerRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerRefNo");

                entity.Property(e => e.DiscountAllowed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountAllowed");

                entity.Property(e => e.DocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("documentDate");

                entity.Property(e => e.Freight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("freight");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.ReturnAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("returnAmount");

                entity.Property(e => e.SaleDodate)
                    .HasColumnType("datetime")
                    .HasColumnName("saleDODate");

                entity.Property(e => e.SaleDonarration)
                    .IsUnicode(false)
                    .HasColumnName("saleDONarration");

                entity.Property(e => e.SaleDono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleDONo");

                entity.Property(e => e.SaleInvoiceBalance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saleInvoiceBalance");

                entity.Property(e => e.SaleInvoiceDeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("saleInvoiceDeliveryDate");

                entity.Property(e => e.SaleInvoiceDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saleInvoiceDiscount");

                entity.Property(e => e.SaleInvoiceDownPayment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saleInvoiceDownPayment");

                entity.Property(e => e.SaleInvoiceFreight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saleInvoiceFreight");

                entity.Property(e => e.SaleInvoicePostingDate)
                    .HasColumnType("date")
                    .HasColumnName("saleInvoicePostingDate");

                entity.Property(e => e.SaleInvoiceSubtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saleInvoiceSubtotal");

                entity.Property(e => e.SaleInvoiceTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saleInvoiceTotal");

                entity.Property(e => e.SalesInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceId");

                entity.Property(e => e.SalesInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceNo");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.ShiftUserid).HasColumnName("shiftUserid");

                entity.Property(e => e.Shiftid).HasColumnName("shiftid");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<TblSaleInstallmentsHistory>(entity =>
            {
                entity.HasKey(e => e.SaleInvoiceHistoryId);

                entity.ToTable("tbl_SaleInstallmentsHistory");

                entity.Property(e => e.SaleInvoiceHistoryId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("saleInvoiceHistoryId");

                entity.Property(e => e.CollectedAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("collectedAmount");

                entity.Property(e => e.DiscountAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountAmount");

                entity.Property(e => e.InstallmentAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("installmentAmount");

                entity.Property(e => e.InstallmentDate)
                    .HasColumnType("date")
                    .HasColumnName("installmentDate");

                entity.Property(e => e.InstallmentsVoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("installmentsVoucherNo");

                entity.Property(e => e.ReceiptDate)
                    .HasColumnType("date")
                    .HasColumnName("receiptDate");

                entity.Property(e => e.SaleInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleInvoiceId");

                entity.Property(e => e.SaleinvoiceInstallmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("saleinvoiceInstallmentId");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TblSaleInvoiceInstallment>(entity =>
            {
                entity.HasKey(e => e.SaleinvoiceInstallmentId);

                entity.ToTable("tbl_SaleInvoiceInstallments");

                entity.Property(e => e.SaleinvoiceInstallmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("saleinvoiceInstallmentId");

                entity.Property(e => e.CashierId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cashierId");

                entity.Property(e => e.CollectedAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("collectedAmount");

                entity.Property(e => e.DiscountAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountAmount");

                entity.Property(e => e.InstallmentAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("installmentAmount");

                entity.Property(e => e.InstallmentDate)
                    .HasColumnType("date")
                    .HasColumnName("installmentDate");

                entity.Property(e => e.ReceiptDate)
                    .HasColumnType("date")
                    .HasColumnName("receiptDate");

                entity.Property(e => e.SaleInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleInvoiceId");

                entity.Property(e => e.SmsStatus).HasColumnName("smsStatus");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TblSaleOrderDetail>(entity =>
            {
                entity.HasKey(e => e.SaleOrderDetailsId);

                entity.ToTable("tbl_SaleOrderDetails");

                entity.Property(e => e.SaleOrderDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("saleOrderDetailsId");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaleOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleOrderId");

                entity.Property(e => e.SaleOrderNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("saleOrderNo");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("salePrice");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblSaleOrderMaster>(entity =>
            {
                entity.HasKey(e => e.SaleOrderId);

                entity.ToTable("tbl_SaleOrderMaster");

                entity.Property(e => e.SaleOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleOrderId");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("currencyId");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerId");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("deliveryDate");

                entity.Property(e => e.DiscountAllowed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountAllowed");

                entity.Property(e => e.DocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("documentDate");

                entity.Property(e => e.Freight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("freight");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("date")
                    .HasColumnName("postingDate");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.SaleOrderStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleOrderStatus");

                entity.Property(e => e.SaleorderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleorderNo");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<TblSalePriceListDetail>(entity =>
            {
                entity.HasKey(e => e.SalePriceListId);

                entity.ToTable("tbl_SalePriceListDetails");

                entity.Property(e => e.SalePriceListId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salePriceListId");

                entity.Property(e => e.PricingLevelId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productId");

                entity.Property(e => e.SaleRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saleRate");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");
            });

            modelBuilder.Entity<TblSalePriceListDetailsLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_SalePriceListDetails_Log");

                entity.Property(e => e.PricingLevelId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productId");

                entity.Property(e => e.SalePriceListId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salePriceListId");

                entity.Property(e => e.SaleRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saleRate");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.UpdaterDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdaterEmployeeId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("UpdaterEmployeeID");

                entity.Property(e => e.UpdaterEmployeeName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdaterTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSalePriceListMaster>(entity =>
            {
                entity.HasKey(e => e.SalePriceListId);

                entity.ToTable("tbl_SalePriceListMaster");

                entity.Property(e => e.SalePriceListId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salePriceListId");

                entity.Property(e => e.ApplicableFrom)
                    .HasColumnType("date")
                    .HasColumnName("applicableFrom");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");
            });

            modelBuilder.Entity<TblSaleQoutationDetail>(entity =>
            {
                entity.HasKey(e => e.SaleQoutationDetailsId);

                entity.ToTable("tbl_SaleQoutationDetails");

                entity.Property(e => e.SaleQoutationDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("saleQoutationDetailsId");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.PriceInPkr)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("priceInPkr");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QoutationId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QuotationNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("salePrice");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxId");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblSaleQoutationMaster>(entity =>
            {
                entity.HasKey(e => e.QoutationId)
                    .HasName("PK_tbl_SaleQoutation");

                entity.ToTable("tbl_SaleQoutationMaster");

                entity.Property(e => e.QoutationId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("currencyId");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerId");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("deliveryDate");

                entity.Property(e => e.DiscountAllowed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountAllowed");

                entity.Property(e => e.DocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("documentDate");

                entity.Property(e => e.Freight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("freight");

                entity.Property(e => e.IsApproved).HasColumnName("isApproved");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("date")
                    .HasColumnName("postingDate");

                entity.Property(e => e.PricingLevelId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.QoutationNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("qoutationNo");

                entity.Property(e => e.SalesmanId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesmanId");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<TblSaleReturnDetail>(entity =>
            {
                entity.HasKey(e => e.SaleReturnDetailsId);

                entity.ToTable("tbl_SaleReturnDetails");

                entity.Property(e => e.SaleReturnDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("saleReturnDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.PurchaseBonusQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchaseBonusQty");

                entity.Property(e => e.PurchaseDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchaseDiscount");

                entity.Property(e => e.PurchaseQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("purchaseQty");

                entity.Property(e => e.PurchaseUom).HasColumnName("purchaseUOM");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.ReturnBonusQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("returnBonusQty");

                entity.Property(e => e.ReturnQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("returnQty");

                entity.Property(e => e.ReturnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnUomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("returnUOMId");

                entity.Property(e => e.ReturnUomname).HasColumnName("returnUOMName");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.SaleReturnMasterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleReturnMasterId");

                entity.Property(e => e.SalesInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceId");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");
            });

            modelBuilder.Entity<TblSaleReturnMaster>(entity =>
            {
                entity.HasKey(e => e.SaleReturnMasterId);

                entity.ToTable("tbl_SaleReturnMaster");

                entity.Property(e => e.SaleReturnMasterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleReturnMasterId");

                entity.Property(e => e.BalanceDue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("balanceDue");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("currencyId");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerId");

                entity.Property(e => e.CustomerRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerRefNo");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("departmentId")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscountAllowed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountAllowed");

                entity.Property(e => e.DocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("documentDate");

                entity.Property(e => e.Freight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("freight");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.ReturnAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("returnAmount");

                entity.Property(e => e.SaleInvoiceBalance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saleInvoiceBalance");

                entity.Property(e => e.SaleInvoiceDeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("saleInvoiceDeliveryDate");

                entity.Property(e => e.SaleInvoiceDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saleInvoiceDiscount");

                entity.Property(e => e.SaleInvoiceDownPayment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saleInvoiceDownPayment");

                entity.Property(e => e.SaleInvoiceFreight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saleInvoiceFreight");

                entity.Property(e => e.SaleInvoicePostingDate)
                    .HasColumnType("date")
                    .HasColumnName("saleInvoicePostingDate");

                entity.Property(e => e.SaleInvoiceSubtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saleInvoiceSubtotal");

                entity.Property(e => e.SaleInvoiceTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("saleInvoiceTotal");

                entity.Property(e => e.SaleReturnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("saleReturnDate");

                entity.Property(e => e.SaleReturnNarration)
                    .IsUnicode(false)
                    .HasColumnName("saleReturnNarration");

                entity.Property(e => e.SaleReturnNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleReturnNo");

                entity.Property(e => e.SalesInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceId");

                entity.Property(e => e.SalesInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceNo");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.ShiftUserid).HasColumnName("shiftUserid");

                entity.Property(e => e.Shiftid).HasColumnName("shiftid");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.WarehouseId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("warehouseId");
            });

            modelBuilder.Entity<TblSaleTemplateDetail>(entity =>
            {
                entity.HasKey(e => e.SaleTemplateDetailsId);

                entity.ToTable("tbl_SaleTemplateDetails");

                entity.Property(e => e.SaleTemplateDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("saleTemplateDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.SaleTemplateMasterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleTemplateMasterId");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblSaleTemplateMaster>(entity =>
            {
                entity.HasKey(e => e.SaleTemplateMasterId);

                entity.ToTable("tbl_SaleTemplateMaster");

                entity.Property(e => e.SaleTemplateMasterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleTemplateMasterId");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("currencyId");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerId");

                entity.Property(e => e.CustomerRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerRefNo");

                entity.Property(e => e.DocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("documentDate");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("date")
                    .HasColumnName("postingDate");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.SaleTemplateNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleTemplateNo");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.TotalDownPayment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDownPayment");
            });

            modelBuilder.Entity<TblSalesCustomer>(entity =>
            {
                entity.HasKey(e => e.SaleInvoiceId);

                entity.ToTable("tbl_SalesCustomers");

                entity.Property(e => e.SaleInvoiceId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Address).HasColumnName("_Address");

                entity.Property(e => e.City).HasColumnName("_City");

                entity.Property(e => e.LedgerId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Number1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("_Number1");
            });

            modelBuilder.Entity<TblSalesInvoiceDetail>(entity =>
            {
                entity.HasKey(e => e.SalesInvoiceDetailsId);

                entity.ToTable("tbl_SalesInvoiceDetails");

                entity.HasIndex(e => e.ProductCode, "IX_ProductCode");

                entity.Property(e => e.SalesInvoiceDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesInvoiceDetailsId");

                entity.Property(e => e.ActualUnitCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("actualUnitCost");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.BorrowedFromTo)
                    .HasMaxLength(50)
                    .HasColumnName("borrowedFromTo");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.DealId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.HsCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.InvoicePertainsTo).HasColumnName("invoicePertainsTo");

                entity.Property(e => e.Paid)
                    .HasMaxLength(50)
                    .HasColumnName("paid");

                entity.Property(e => e.PriceInPkr)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("priceInPkr");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("projectId");

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("salePrice");

                entity.Property(e => e.SalePricePercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceId");

                entity.Property(e => e.SalesInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceNo");

                entity.Property(e => e.Srate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SRate");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");

                entity.Property(e => e.TradePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblSalesInvoiceDetailsCalc>(entity =>
            {
                entity.HasKey(e => e.SalesInvoiceDetailsId);

                entity.ToTable("tbl_SalesInvoiceDetailsCalc");

                entity.Property(e => e.SalesInvoiceDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesInvoiceDetailsId");

                entity.Property(e => e.ActualUnitCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("actualUnitCost");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.BorrowedFromTo)
                    .HasMaxLength(50)
                    .HasColumnName("borrowedFromTo");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.InvoicePertainsTo).HasColumnName("invoicePertainsTo");

                entity.Property(e => e.Paid)
                    .HasMaxLength(50)
                    .HasColumnName("paid");

                entity.Property(e => e.PriceInPkr)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("priceInPkr");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("projectId");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("salePrice");

                entity.Property(e => e.SalePricePercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceId");

                entity.Property(e => e.SalesInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceNo");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");

                entity.Property(e => e.TradePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblSalesInvoiceDetailsDuplicate>(entity =>
            {
                entity.HasKey(e => e.SalesInvoiceDetailsId);

                entity.ToTable("tbl_SalesInvoiceDetailsDuplicate");

                entity.Property(e => e.SalesInvoiceDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesInvoiceDetailsId");

                entity.Property(e => e.ActualUnitCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("actualUnitCost");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.BorrowedFromTo)
                    .HasMaxLength(50)
                    .HasColumnName("borrowedFromTo");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.DealId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.InvoicePertainsTo).HasColumnName("invoicePertainsTo");

                entity.Property(e => e.Paid)
                    .HasMaxLength(50)
                    .HasColumnName("paid");

                entity.Property(e => e.PriceInPkr)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("priceInPkr");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("projectId");

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("salePrice");

                entity.Property(e => e.SalePricePercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceId");

                entity.Property(e => e.SalesInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceNo");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");

                entity.Property(e => e.TradePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblSalesInvoiceMaster>(entity =>
            {
                entity.HasKey(e => e.SalesInvoiceId);

                entity.ToTable("tbl_SalesInvoiceMaster");

                entity.HasIndex(e => e.CustomerId, "IX_tbl_SalesInvoiceMaster_customerId");

                entity.HasIndex(e => e.DocumentDate, "IX_tbl_SalesInvoiceMaster_documentDate");

                entity.HasIndex(e => e.PricingLevelId, "IX_tbl_SalesInvoiceMaster_pricingLevelId");

                entity.HasIndex(e => e.SalesmanId, "IX_tbl_SalesInvoiceMaster_salesmanId");

                entity.Property(e => e.SalesInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceId");

                entity.Property(e => e.BalanceDue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("balanceDue");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("currencyId");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerId");

                entity.Property(e => e.CustomerLedgerBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerRefNo");

                entity.Property(e => e.CustomerSubAccountId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerSubAccountId");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("deliveryDate");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("departmentId")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscountAllowed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountAllowed");

                entity.Property(e => e.DocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("documentDate");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("date")
                    .HasColumnName("extraDate");

                entity.Property(e => e.Freight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("freight");

                entity.Property(e => e.Interest)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("interest");

                entity.Property(e => e.LeadId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("leadId");

                entity.Property(e => e.LedgerCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ledgerCode");

                entity.Property(e => e.LedgerIdForAutoMobile).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMethodId");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("date")
                    .HasColumnName("postingDate");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.SalesInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceNo");

                entity.Property(e => e.SalesInvoiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceStatus");

                entity.Property(e => e.SalesStaffId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesStaffId");

                entity.Property(e => e.SalesTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesTime");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.ShiftUserid).HasColumnName("shiftUserid");

                entity.Property(e => e.Shiftid).HasColumnName("shiftid");

                entity.Property(e => e.ShipmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("shipmentId");

                entity.Property(e => e.ShippingAddress)
                    .IsUnicode(false)
                    .HasColumnName("shippingAddress");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.TotalDownPayment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDownPayment");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");

                entity.Property(e => e.WarehouseId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("warehouseId");
            });

            modelBuilder.Entity<TblSalesInvoiceMasterCalc>(entity =>
            {
                entity.HasKey(e => e.SalesInvoiceId);

                entity.ToTable("tbl_SalesInvoiceMasterCalc");

                entity.Property(e => e.SalesInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceId");

                entity.Property(e => e.BalanceDue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("balanceDue");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("currencyId");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerId");

                entity.Property(e => e.CustomerLedgerBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerRefNo");

                entity.Property(e => e.CustomerSubAccountId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerSubAccountId");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("deliveryDate");

                entity.Property(e => e.DiscountAllowed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountAllowed");

                entity.Property(e => e.DocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("documentDate");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("date")
                    .HasColumnName("extraDate");

                entity.Property(e => e.Freight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("freight");

                entity.Property(e => e.Interest)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("interest");

                entity.Property(e => e.LeadId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("leadId");

                entity.Property(e => e.LedgerCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ledgerCode");

                entity.Property(e => e.LedgerIdForAutoMobile).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMethodId");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("date")
                    .HasColumnName("postingDate");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.SalesInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceNo");

                entity.Property(e => e.SalesInvoiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceStatus");

                entity.Property(e => e.SalesStaffId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesStaffId");

                entity.Property(e => e.SalesTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesTime");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.ShiftUserid).HasColumnName("shiftUserid");

                entity.Property(e => e.Shiftid).HasColumnName("shiftid");

                entity.Property(e => e.ShipmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("shipmentId");

                entity.Property(e => e.ShippingAddress)
                    .IsUnicode(false)
                    .HasColumnName("shippingAddress");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.TotalDownPayment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDownPayment");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblSalesInvoiceMasterDuplicate>(entity =>
            {
                entity.HasKey(e => e.SalesInvoiceId);

                entity.ToTable("tbl_SalesInvoiceMasterDuplicate");

                entity.Property(e => e.SalesInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceId");

                entity.Property(e => e.BalanceDue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("balanceDue");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("currencyId");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerId");

                entity.Property(e => e.CustomerLedgerBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerRefNo");

                entity.Property(e => e.CustomerSubAccountId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerSubAccountId");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("deliveryDate");

                entity.Property(e => e.DiscountAllowed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountAllowed");

                entity.Property(e => e.DocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("documentDate");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("date")
                    .HasColumnName("extraDate");

                entity.Property(e => e.Freight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("freight");

                entity.Property(e => e.IdentifierName)
                    .HasMaxLength(50)
                    .HasColumnName("identifierName");

                entity.Property(e => e.Interest)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("interest");

                entity.Property(e => e.LeadId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("leadId");

                entity.Property(e => e.LedgerCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ledgerCode");

                entity.Property(e => e.LedgerIdForAutoMobile).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMethodId");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("date")
                    .HasColumnName("postingDate");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.SalesInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceNo");

                entity.Property(e => e.SalesInvoiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceStatus");

                entity.Property(e => e.SalesStaffId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesStaffId");

                entity.Property(e => e.SalesTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesTime");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.ShiftUserid).HasColumnName("shiftUserid");

                entity.Property(e => e.Shiftid).HasColumnName("shiftid");

                entity.Property(e => e.ShipmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("shipmentId");

                entity.Property(e => e.ShippingAddress)
                    .IsUnicode(false)
                    .HasColumnName("shippingAddress");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.TotalDownPayment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDownPayment");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblSalesMaster>(entity =>
            {
                entity.HasKey(e => e.SalesMasterId)
                    .HasName("PK__tbl_Sale__036BDC222F7AE026");

                entity.ToTable("tbl_SalesMaster");

                entity.Property(e => e.SalesMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesMasterId");

                entity.Property(e => e.AdditionalCost)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("additionalCost");

                entity.Property(e => e.BillDiscount)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("billDiscount");

                entity.Property(e => e.CounterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("counterId");

                entity.Property(e => e.CreditPeriod).HasColumnName("creditPeriod");

                entity.Property(e => e.CustomerName)
                    .IsUnicode(false)
                    .HasColumnName("customerName");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.DeliveryNoteMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("deliveryNoteMasterId");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.ExchangeRateId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("exchangeRateId");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.FinancialYearId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("financialYearId");

                entity.Property(e => e.GrandTotal)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("grandTotal");

                entity.Property(e => e.InvoiceNo)
                    .IsUnicode(false)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.LrNo)
                    .IsUnicode(false)
                    .HasColumnName("lrNo");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.OrderMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("orderMasterId");

                entity.Property(e => e.Pos).HasColumnName("POS");

                entity.Property(e => e.PricinglevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricinglevelId");

                entity.Property(e => e.QuotationMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("quotationMasterId");

                entity.Property(e => e.SalesAccount)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesAccount");

                entity.Property(e => e.SuffixPrefixId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("suffixPrefixId");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("totalAmount");

                entity.Property(e => e.TransportationCompany)
                    .IsUnicode(false)
                    .HasColumnName("transportationCompany");

                entity.Property(e => e.UserId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("userId");

                entity.Property(e => e.VoucherNo)
                    .IsUnicode(false)
                    .HasColumnName("voucherNo");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblSalesReturnWithoutInvDetail>(entity =>
            {
                entity.HasKey(e => e.SalesInvoiceDetailsId);

                entity.ToTable("tbl_SalesReturnWithoutInvDetails");

                entity.Property(e => e.SalesInvoiceDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesInvoiceDetailsId");

                entity.Property(e => e.ActualUnitCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("actualUnitCost");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.BorrowedFromTo)
                    .HasMaxLength(50)
                    .HasColumnName("borrowedFromTo");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.DealId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .HasColumnName("invoiceNo");

                entity.Property(e => e.InvoicePertainsTo).HasColumnName("invoicePertainsTo");

                entity.Property(e => e.Paid)
                    .HasMaxLength(50)
                    .HasColumnName("paid");

                entity.Property(e => e.PriceInPkr)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("priceInPkr");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.ProjectId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("projectId");

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("salePrice");

                entity.Property(e => e.SalePricePercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceId");

                entity.Property(e => e.SalesInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceNo");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");

                entity.Property(e => e.TradePrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblSalesReturnWithoutInvMaster>(entity =>
            {
                entity.HasKey(e => e.SalesInvoiceId);

                entity.ToTable("tbl_SalesReturnWithoutInvMaster");

                entity.Property(e => e.SalesInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceId");

                entity.Property(e => e.BalanceDue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("balanceDue");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("currencyId");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerId");

                entity.Property(e => e.CustomerLedgerBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customerRefNo");

                entity.Property(e => e.CustomerSubAccountId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerSubAccountId");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("deliveryDate");

                entity.Property(e => e.DiscountAllowed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discountAllowed");

                entity.Property(e => e.DocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("documentDate");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("date")
                    .HasColumnName("extraDate");

                entity.Property(e => e.Freight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("freight");

                entity.Property(e => e.Interest)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("interest");

                entity.Property(e => e.LeadId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("leadId");

                entity.Property(e => e.LedgerCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ledgerCode");

                entity.Property(e => e.LedgerIdForAutoMobile).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("paymentMethodId");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("date")
                    .HasColumnName("postingDate");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.SalesInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceNo");

                entity.Property(e => e.SalesInvoiceStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceStatus");

                entity.Property(e => e.SalesStaffId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesStaffId");

                entity.Property(e => e.SalesTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesTime");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.ShiftUserid).HasColumnName("shiftUserid");

                entity.Property(e => e.Shiftid).HasColumnName("shiftid");

                entity.Property(e => e.ShipmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("shipmentId");

                entity.Property(e => e.ShippingAddress)
                    .IsUnicode(false)
                    .HasColumnName("shippingAddress");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.TotalDownPayment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDownPayment");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblSeason>(entity =>
            {
                entity.HasKey(e => e.SeasonId);

                entity.ToTable("tbl_Season");

                entity.Property(e => e.SeasonId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("seasonId");

                entity.Property(e => e.Duration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.FromDay)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromMonth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.SeasonName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("seasonName");

                entity.Property(e => e.SeasonTypeId).HasColumnName("seasonTypeId");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.ToDay)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToMonth)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSeasonRate>(entity =>
            {
                entity.HasKey(e => e.SeaonRateId);

                entity.ToTable("tbl_SeasonRate");

                entity.Property(e => e.SeaonRateId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("seaonRateId");

                entity.Property(e => e.BaseOccupancy)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("baseOccupancy");

                entity.Property(e => e.BasePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ExtraBedPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.HighPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.HigherOccupancy)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("higherOccupancy");

                entity.Property(e => e.RoomTypeId).HasColumnName("roomTypeId");

                entity.Property(e => e.SeasonId).HasColumnName("seasonId");

                entity.Property(e => e.SeasonRateName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("seasonRateName");
            });

            modelBuilder.Entity<TblSeasonType>(entity =>
            {
                entity.HasKey(e => e.SeasonTypeId)
                    .HasName("PK_tbl_SeasonAttribute");

                entity.ToTable("tbl_SeasonType");

                entity.Property(e => e.SeasonTypeId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("seasonTypeId");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.SeasonTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("seasonTypeName");
            });

            modelBuilder.Entity<TblServer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Server");

                entity.Property(e => e.Sx)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SX");
            });

            modelBuilder.Entity<TblService>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK__tbl_Serv__455070DF70099B30");

                entity.ToTable("tbl_Service");

                entity.Property(e => e.ServiceId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("serviceId");

                entity.Property(e => e.ChkisPkr).HasColumnName("chkisPKR");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cost");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.InfoReq).HasColumnName("infoReq");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsTaxable).HasColumnName("isTaxable");

                entity.Property(e => e.IsTicketable).HasColumnName("isTicketable");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.PrintName).HasColumnName("printName");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.ServiceCategoryId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("serviceCategoryId");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serviceCode");

                entity.Property(e => e.ServiceName).HasColumnName("serviceName");
            });

            modelBuilder.Entity<TblServiceCategory>(entity =>
            {
                entity.HasKey(e => e.ServiceCategoryId)
                    .HasName("PK__tbl_Serv__77EC43563AA1AEB8");

                entity.ToTable("tbl_ServiceCategory");

                entity.Property(e => e.ServiceCategoryId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("serviceCategoryId");

                entity.Property(e => e.CategoryName).HasColumnName("categoryName");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblServiceDoctorMapping>(entity =>
            {
                entity.HasKey(e => e.ServiceDoctorMappingId)
                    .HasName("PK__tbl_Serv__9DEF2F7DB99AC1E4");

                entity.ToTable("tbl_ServiceDoctorMapping");

                entity.Property(e => e.ServiceDoctorMappingId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("serviceDoctorMappingId");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.ServiceAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("serviceAmount");

                entity.Property(e => e.ServiceId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("serviceId");
            });

            modelBuilder.Entity<TblServiceLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Service_Log");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.ServiceCategoryId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("serviceCategoryId");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serviceCode");

                entity.Property(e => e.ServiceId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("serviceId");

                entity.Property(e => e.ServiceName).HasColumnName("serviceName");

                entity.Property(e => e.UpdaterDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdaterEmployeeId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("UpdaterEmployeeID");

                entity.Property(e => e.UpdaterEmployeeName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdaterTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblServiceMembership>(entity =>
            {
                entity.HasKey(e => e.ServiceCode)
                    .HasName("PK_tbl_ServiceMembership_1");

                entity.ToTable("tbl_ServiceMembership");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serviceCode");

                entity.Property(e => e.EnableReccurency).HasColumnName("enableReccurency");

                entity.Property(e => e.RecurrencesType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("recurrencesType");
            });

            modelBuilder.Entity<TblServiceStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("tblServiceStatuses");

                entity.Property(e => e.StatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("StatusID");

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.ServiceStatus).HasMaxLength(50);
            });

            modelBuilder.Entity<TblServicesAddOnField>(entity =>
            {
                entity.HasKey(e => e.ServicesAddOnFieldsId);

                entity.ToTable("tbl_ServicesAddOnFields");

                entity.Property(e => e.ServicesAddOnFieldsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("servicesAddOnFieldsId");

                entity.Property(e => e.AddOnName).HasColumnName("addOnName");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.IsOptional).HasColumnName("isOptional");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serviceCode");
            });

            modelBuilder.Entity<TblServicesAddOnFieldsLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_ServicesAddOnFields_Log");

                entity.Property(e => e.AddOnName).HasColumnName("addOnName");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.IsOptional).HasColumnName("isOptional");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serviceCode");

                entity.Property(e => e.ServicesAddOnFieldsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("servicesAddOnFieldsId");

                entity.Property(e => e.UpdaterDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdaterEmployeeId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("UpdaterEmployeeID");

                entity.Property(e => e.UpdaterEmployeeName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdaterTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblServicesAddOnsDatum>(entity =>
            {
                entity.HasKey(e => e.ServicesAddOnsDataId);

                entity.ToTable("tbl_ServicesAddOnsData");

                entity.Property(e => e.ServicesAddOnsDataId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("servicesAddOnsDataId");

                entity.Property(e => e.AddOnName).HasColumnName("addOnName");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerId");

                entity.Property(e => e.IsOptional).HasColumnName("isOptional");

                entity.Property(e => e.IsSelected).HasColumnName("isSelected");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.SaleInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleInvoiceId");

                entity.Property(e => e.Service)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("service");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serviceCode");

                entity.Property(e => e.ServicesAddOnFieldsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("servicesAddOnFieldsId");
            });

            modelBuilder.Entity<TblServicesCustomField>(entity =>
            {
                entity.HasKey(e => e.ServicesCustomFieldsId);

                entity.ToTable("tbl_ServicesCustomFields");

                entity.Property(e => e.ServicesCustomFieldsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("servicesCustomFieldsId");

                entity.Property(e => e.FieldName).HasColumnName("fieldName");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serviceCode");
            });

            modelBuilder.Entity<TblServicesCustomFieldsDatum>(entity =>
            {
                entity.HasKey(e => e.ServicesCustomFieldsDataId);

                entity.ToTable("tbl_ServicesCustomFieldsData");

                entity.Property(e => e.ServicesCustomFieldsDataId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("servicesCustomFieldsDataId");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerId");

                entity.Property(e => e.FieldName).HasColumnName("fieldName");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.SaleInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleInvoiceId");

                entity.Property(e => e.Service).HasColumnName("service");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serviceCode");

                entity.Property(e => e.ServicesCustomFieldsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("servicesCustomFieldsId");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<TblServicesCustomerDatum>(entity =>
            {
                entity.HasKey(e => e.ServicesCustomerDataId);

                entity.ToTable("tbl_ServicesCustomerData");

                entity.Property(e => e.ServicesCustomerDataId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("servicesCustomerDataId");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("customerId");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ServiceId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("serviceId");

                entity.Property(e => e.ServicesCustomFieldsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("servicesCustomFieldsId");

                entity.Property(e => e.Value)
                    .HasMaxLength(200)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<TblSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Settings");

                entity.Property(e => e.AutoKotreset).HasColumnName("autoKOTReset");

                entity.Property(e => e.DefaultImagePath)
                    .IsUnicode(false)
                    .HasColumnName("defaultImagePath");

                entity.Property(e => e.InvoicePrinting).HasColumnName("Invoice_Printing");

                entity.Property(e => e.KotPrint).HasColumnName("Kot_Print");

                entity.Property(e => e.KotPrintOnCheckOut).HasColumnName("Kot_Print_OnCheckOut");

                entity.Property(e => e.Kotpreview).HasColumnName("KOTPreview");

                entity.Property(e => e.MacAddress)
                    .IsUnicode(false)
                    .HasColumnName("macAddress");

                entity.Property(e => e.NoOfPrints)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("No_Of_Prints");

                entity.Property(e => e.OrderReadyTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Order_Ready_Time");

                entity.Property(e => e.PricingSetup)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSheduleSm>(entity =>
            {
                entity.HasKey(e => e.SheduleSmsId);

                entity.ToTable("tbl_SheduleSMS");

                entity.Property(e => e.SheduleSmsId)
                    .ValueGeneratedNever()
                    .HasColumnName("SheduleSmsID");

                entity.Property(e => e.ComposeSms).HasColumnName("Compose_SMS");

                entity.Property(e => e.Receipient)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelectTemplte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Select_Templte");

                entity.Property(e => e.Send)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SheduleDate).HasColumnType("datetime");

                entity.Property(e => e.Smsgroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SMSGroup");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblShipmentType>(entity =>
            {
                entity.HasKey(e => e.ShipmentId);

                entity.ToTable("tbl_ShipmentType");

                entity.Property(e => e.ShipmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("shipmentId");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.ShipmentTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("shipmentTypeName");
            });

            modelBuilder.Entity<TblShortPrevilidgeDetail>(entity =>
            {
                entity.ToTable("tbl_ShortPrevilidgeDetails");

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<TblShortPrevilidgeMaster>(entity =>
            {
                entity.ToTable("tbl_ShortPrevilidgeMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<TblSiadvanceSearch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_SIAdvanceSearch");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSingleBillCollection>(entity =>
            {
                entity.HasKey(e => e.SingleBillCollectionId);

                entity.ToTable("tbl_SingleBillCollection");

                entity.Property(e => e.SingleBillCollectionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("singleBillCollectionId");

                entity.Property(e => e.AfterDueDate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("afterDueDate");

                entity.Property(e => e.BillCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("billCompany");

                entity.Property(e => e.BillMonth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("billMonth");

                entity.Property(e => e.BillType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("billType");

                entity.Property(e => e.CashPaid)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cashPaid");

                entity.Property(e => e.Change)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("change");

                entity.Property(e => e.DueBill)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("dueBill");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .HasColumnName("dueDate");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("date")
                    .HasColumnName("invoiceDate");

                entity.Property(e => e.InvoiceTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoiceTime");

                entity.Property(e => e.ReferenceNo).HasColumnName("referenceNo");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.SmsNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("smsNo");
            });

            modelBuilder.Entity<TblSingleSm>(entity =>
            {
                entity.HasKey(e => e.SingleSmsId);

                entity.ToTable("tbl_SingleSMS");

                entity.Property(e => e.SingleSmsId)
                    .ValueGeneratedNever()
                    .HasColumnName("SingleSmsID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.SalesInstallmentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInstallmentId");

                entity.Property(e => e.SalesInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceId");

                entity.Property(e => e.SelectTemplete)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SingleContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SingleSmscompose).HasColumnName("SingleSMSCompose");

                entity.Property(e => e.Smsgroup)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SMSGroup");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Time).HasColumnName("time");
            });

            modelBuilder.Entity<TblSize>(entity =>
            {
                entity.HasKey(e => e.SizeId)
                    .HasName("PK__tbl_Size__55B1E55749E3F248");

                entity.ToTable("tbl_Size");

                entity.Property(e => e.SizeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("sizeId");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.Size)
                    .IsUnicode(false)
                    .HasColumnName("size");
            });

            modelBuilder.Entity<TblSkinnedcash>(entity =>
            {
                entity.ToTable("tbl_skinnedcash");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Currencyid).HasColumnName("currencyid");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime");

                entity.Property(e => e.Masterid).HasColumnName("masterid");

                entity.Property(e => e.Touser).HasColumnName("touser");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<TblSmsapiSetting>(entity =>
            {
                entity.HasKey(e => e.Apiid);

                entity.ToTable("tbl_SMSApiSetting");

                entity.Property(e => e.Apiid)
                    .ValueGeneratedNever()
                    .HasColumnName("APIid");

                entity.Property(e => e.ApIurl)
                    .IsUnicode(false)
                    .HasColumnName("ApIUrl");

                entity.Property(e => e.Apikey).HasColumnName("APIKey");

                entity.Property(e => e.ApikeyVariable).HasColumnName("APIKeyVariable");

                entity.Property(e => e.Apiname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APIName");

                entity.Property(e => e.DestinationVariable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MessageVariable).IsUnicode(false);

                entity.Property(e => e.PasswordValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordVariable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuccessCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsernameValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsernameVariable)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSmssetting>(entity =>
            {
                entity.HasKey(e => e.SmsSettingId);

                entity.ToTable("tbl_SMSSettings");

                entity.Property(e => e.SmsSettingId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("smsSettingId");

                entity.Property(e => e.DefaultAfterDueDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultMobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultReminderTemplate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DelayTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("delayTime");

                entity.Property(e => e.NoOfRemindAfterDueDate)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("noOfRemindAfterDueDate");

                entity.Property(e => e.PortNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("portNo");

                entity.Property(e => e.ReminderBeforeDays)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("reminderBeforeDays");
            });

            modelBuilder.Entity<TblSmstemplate>(entity =>
            {
                entity.HasKey(e => e.TamplateId)
                    .HasName("PK_tbl_SMSTemplate_1");

                entity.ToTable("tbl_SMSTemplate");

                entity.Property(e => e.TamplateId)
                    .ValueGeneratedNever()
                    .HasColumnName("TamplateID");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.TemplateCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblSmtp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_SMTP");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Email_ID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSmtpemail>(entity =>
            {
                entity.HasKey(e => e.SmtpuserId);

                entity.ToTable("tbl_SMTPEmail");

                entity.Property(e => e.SmtpuserId)
                    .ValueGeneratedNever()
                    .HasColumnName("SMTPUserID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Smtphost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SMTPHost");

                entity.Property(e => e.Smtpport)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SMTPPort");

                entity.Property(e => e.Smtpuser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SMTPUser");
            });

            modelBuilder.Entity<TblSplitBill>(entity =>
            {
                entity.HasKey(e => e.SplitBillId);

                entity.ToTable("tbl_SplitBill");

                entity.Property(e => e.SplitBillId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("splitBillId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.PaymnetMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("paymnetMethod");

                entity.Property(e => e.SaleInvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleInvoiceNo");
            });

            modelBuilder.Entity<TblStandardRate>(entity =>
            {
                entity.HasKey(e => e.StandardRateId)
                    .HasName("PK__tbl_Stan__F75A1E8460C757A0");

                entity.ToTable("tbl_StandardRate");

                entity.Property(e => e.StandardRateId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("standardRateId");

                entity.Property(e => e.ApplicableFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("applicableFrom");

                entity.Property(e => e.ApplicableTo)
                    .HasColumnType("datetime")
                    .HasColumnName("applicableTo");

                entity.Property(e => e.BatchId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("batchId");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.ProductId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productId");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("rate");

                entity.Property(e => e.UnitId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("unitId");
            });

            modelBuilder.Entity<TblStockAlert>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_StockAlert");

                entity.Property(e => e.ProductId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("productId");

                entity.Property(e => e.StockAlterQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stockAlterQty");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");
            });

            modelBuilder.Entity<TblStockBatchLedger>(entity =>
            {
                entity.ToTable("tblStockBatchLedger");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AddedQty).HasColumnName("AddedQTY");

                entity.Property(e => e.Batch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.DetailsId).HasColumnName("DetailsID");

                entity.Property(e => e.InvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceID");

                entity.Property(e => e.Method)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NewQty).HasColumnName("NewQTY");

                entity.Property(e => e.PreviousQty).HasColumnName("PreviousQTY");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProductID");

                entity.Property(e => e.Uomid).HasColumnName("UOMID");
            });

            modelBuilder.Entity<TblStockDetail>(entity =>
            {
                entity.HasKey(e => e.StockDetailId);

                entity.ToTable("tbl_StockDetails");

                entity.Property(e => e.StockDetailId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("stockDetailId");

                entity.Property(e => e.ProductBarcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productBarcode");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.StockMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("stockMasterId");

                entity.Property(e => e.Uomid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");

                entity.Property(e => e.WarehouseId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("warehouseId");
            });

            modelBuilder.Entity<TblStockMaster>(entity =>
            {
                entity.HasKey(e => e.StockMasterId);

                entity.ToTable("tbl_StockMaster");

                entity.Property(e => e.StockMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("stockMasterId");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.PurchaseInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchaseInvoiceId");
            });

            modelBuilder.Entity<TblStockReturnDetail>(entity =>
            {
                entity.HasKey(e => e.StockReturnDetailsId);

                entity.ToTable("tbl_StockReturnDetails");

                entity.Property(e => e.StockReturnDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("stockReturnDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.Deduction)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("deduction");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.ReturnQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("returnQty");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.StockReturnId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stockReturnId");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblStockReturnMaster>(entity =>
            {
                entity.HasKey(e => e.StockReturnId);

                entity.ToTable("tbl_StockReturnMaster");

                entity.Property(e => e.StockReturnId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stockReturnId");

                entity.Property(e => e.BalanceDue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("balanceDue");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DownPayment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("downPayment");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.StockReturnNarration).HasColumnName("stockReturnNarration");

                entity.Property(e => e.StockReturnNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stockReturnNo");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.SupplierId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("supplierId");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<TblStockTransferDetail>(entity =>
            {
                entity.HasKey(e => e.StockTransferDetailsId);

                entity.ToTable("tbl_StockTransferDetails");

                entity.Property(e => e.StockTransferDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("stockTransferDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.Batch)
                    .HasMaxLength(50)
                    .HasColumnName("batch");

                entity.Property(e => e.BonusQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bonusQty");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.Expiry)
                    .HasColumnType("date")
                    .HasColumnName("expiry");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName).HasColumnName("productName");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.StockTransferMasterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stockTransferMasterId");

                entity.Property(e => e.TaxAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("taxAmount");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblStockTransferMaster>(entity =>
            {
                entity.HasKey(e => e.StockTransferMasterId);

                entity.ToTable("tbl_StockTransferMaster");

                entity.Property(e => e.StockTransferMasterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stockTransferMasterId");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("currencyId");

                entity.Property(e => e.FromWarehouseId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("fromWarehouseId");

                entity.Property(e => e.PricingLevelId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pricingLevelId");

                entity.Property(e => e.PurchaseDocumentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("purchaseDocumentDate");

                entity.Property(e => e.SalesmanId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salesmanId");

                entity.Property(e => e.StockTransferNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stockTransferNo");

                entity.Property(e => e.ToWarehouseId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("toWarehouseId");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<TblSubCategoryMapping>(entity =>
            {
                entity.HasKey(e => e.SubCategoryTypeValueId);

                entity.ToTable("tbl_SubCategoryMapping");

                entity.Property(e => e.SubCategoryTypeValueId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("subCategoryTypeValueId");

                entity.Property(e => e.CategoryType).HasColumnName("categoryType");

                entity.Property(e => e.SubCategoryType).HasColumnName("subCategoryType");

                entity.Property(e => e.SubScreenType).HasColumnName("subScreenType");

                entity.Property(e => e.SubValue).HasColumnName("subValue");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<TblSuffixPrefix>(entity =>
            {
                entity.HasKey(e => e.SuffixprefixId);

                entity.ToTable("tbl_SuffixPrefix");

                entity.Property(e => e.SuffixprefixId).ValueGeneratedNever();

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.Narattion).IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartIndex).IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.VocherType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WidthNumericalPart).IsUnicode(false);
            });

            modelBuilder.Entity<TblSystemDepartment>(entity =>
            {
                entity.HasKey(e => e.SystemDepartmentId);

                entity.ToTable("tbl_SystemDepartment");

                entity.Property(e => e.SystemDepartmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("systemDepartmentId");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .HasColumnName("departmentName");

                entity.Property(e => e.EmployeeCategoryId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeCategoryId");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .HasColumnName("narration");
            });

            modelBuilder.Entity<TblTabbedView>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_TabbedView");

                entity.Property(e => e.TabbedView).HasColumnName("tabbedView");
            });

            modelBuilder.Entity<TblTable>(entity =>
            {
                entity.ToTable("tbl_Tables");

                entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AdminId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Admin_Id");

                entity.Property(e => e.TableName).HasColumnName("Table_Name");
            });

            modelBuilder.Entity<TblTax>(entity =>
            {
                entity.HasKey(e => e.TaxId)
                    .HasName("PK__tbl_Tax__24D2883933008CF0");

                entity.ToTable("tbl_Tax");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");

                entity.Property(e => e.ApplicableOn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("applicableOn");

                entity.Property(e => e.CalculatingMode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("calculatingMode");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LedgerId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ledgerId");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.TaxName).HasColumnName("taxName");
            });

            modelBuilder.Entity<TblTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Test");

                entity.Property(e => e.ChkRange).HasColumnName("chkRange");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Report)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("report");

                entity.Property(e => e.ReportDays)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Report_Days");

                entity.Property(e => e.ShowinTest).HasColumnName("showinTest");

                entity.Property(e => e.TestId).HasColumnName("Test_ID");

                entity.Property(e => e.TestName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Test_Name");

                entity.Property(e => e.TestType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Test_Type");

                entity.Property(e => e.Under)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTestBookingDetail>(entity =>
            {
                entity.ToTable("tbl_TestBookingDetails");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CaseId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CaseID");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TaxPercent).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TestId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TestID");

                entity.Property(e => e.TestName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTestBookingMaster>(entity =>
            {
                entity.ToTable("tbl_TestBookingMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CaseId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CaseID");

                entity.Property(e => e.Concession).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.HomeCollection).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ManualDiscount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Paid).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PatientNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDate).HasColumnType("date");

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TestAmount).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblTestBookingpatient>(entity =>
            {
                entity.ToTable("tbl_TestBookingpatient");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefferedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTicketDetail>(entity =>
            {
                entity.HasKey(e => e.TicketDetailsId)
                    .HasName("PK_tbl_TicketDetails_1");

                entity.ToTable("tbl_TicketDetails");

                entity.Property(e => e.TicketDetailsId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ticketDetailsId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.CommisionAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("commisionAmount");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("deliveryDate");

                entity.Property(e => e.DeliveryTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("deliveryTime");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("employeeId");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .HasColumnName("employeeName");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.Quantity)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("quantity");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("rowId");

                entity.Property(e => e.SaleInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("saleInvoiceId");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serviceCode");

                entity.Property(e => e.ServiceName).HasColumnName("serviceName");

                entity.Property(e => e.Stage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stage");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TicketMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ticketMasterId");

                entity.Property(e => e.TicketNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ticketNo");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Uomname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblTicketMaster>(entity =>
            {
                entity.HasKey(e => e.TicketMasterId);

                entity.ToTable("tbl_TicketMaster");

                entity.Property(e => e.TicketMasterId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ticketMasterId");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.SalesInvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("salesInvoiceId");
            });

            modelBuilder.Entity<TblTiming>(entity =>
            {
                entity.HasKey(e => e.TimingId);

                entity.ToTable("tbl_Timing");

                entity.Property(e => e.TimingId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ApplicableFrom).HasColumnType("date");

                entity.Property(e => e.ApplicableTo).HasColumnType("date");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");

                entity.Property(e => e.DesignationId).HasColumnName("designationId");

                entity.Property(e => e.DocumentDate).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeId");

                entity.Property(e => e.TimingBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimingType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimingUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTimingDetail>(entity =>
            {
                entity.HasKey(e => e.TimingDetailId);

                entity.ToTable("tbl_TimingDetail");

                entity.Property(e => e.TimingDetailId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DayOfWeek)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GraceTimeType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUnitsOfMeasurementGroup>(entity =>
            {
                entity.HasKey(e => e.MeasurementGroupsId);

                entity.ToTable("tbl_UnitsOfMeasurementGroups");

                entity.Property(e => e.MeasurementGroupsId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupsIname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GroupsIName");
            });

            modelBuilder.Entity<TblUom>(entity =>
            {
                entity.HasKey(e => e.Uomid)
                    .HasName("PK__tbl_Unit__55D792354242D080");

                entity.ToTable("tbl_UOM");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.PrintName)
                    .HasMaxLength(50)
                    .HasColumnName("printName");

                entity.Property(e => e.Uomname).HasColumnName("UOMName");
            });

            modelBuilder.Entity<TblUomWithUomgroup>(entity =>
            {
                entity.HasKey(e => e.UomWithUomgroupId);

                entity.ToTable("tbl_UOM_With_UOMGroup");

                entity.Property(e => e.UomWithUomgroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOM_With_UOMGroupId");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.UomgroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMGroupId");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");
            });

            modelBuilder.Entity<TblUomdefination>(entity =>
            {
                entity.HasKey(e => e.UomdefinitionId);

                entity.ToTable("tbl_UOMDefination");

                entity.Property(e => e.UomdefinitionId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMDefinitionId");

                entity.Property(e => e.BaseQty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("baseQty");

                entity.Property(e => e.BaseUomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("baseUOMId");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.UomgroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMGroupId");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");
            });

            modelBuilder.Entity<TblUomgroup>(entity =>
            {
                entity.HasKey(e => e.UomgroupId);

                entity.ToTable("tbl_UOMGroup");

                entity.Property(e => e.UomgroupId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMGroupId");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.UomgroupName).HasColumnName("UOMGroupName");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.ToTable("Tbl_User");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_Name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserPrevilige>(entity =>
            {
                entity.ToTable("tbl_UserPreviliges");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleForm)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblValidation>(entity =>
            {
                entity.HasKey(e => new { e.FormName, e.ControlName });

                entity.ToTable("tbl_Validation");

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVariablePricing>(entity =>
            {
                entity.HasKey(e => e.VariablePricingId);

                entity.ToTable("tbl_VariablePricing");

                entity.Property(e => e.VariablePricingId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("variablePricingId");

                entity.Property(e => e.FromQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ToQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Uomid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UOMId");
            });

            modelBuilder.Entity<TblVoucherAttachment>(entity =>
            {
                entity.HasKey(e => e.VoucherAttachmentId);

                entity.ToTable("tbl_VoucherAttachments");

                entity.Property(e => e.VoucherAttachmentId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherAttachmentId");

                entity.Property(e => e.Extenstion)
                    .HasMaxLength(50)
                    .HasColumnName("extenstion");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.FileName).HasColumnName("fileName");

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fileType");

                entity.Property(e => e.Path).HasColumnName("path");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("voucherNo");
            });

            modelBuilder.Entity<TblVoucherType>(entity =>
            {
                entity.HasKey(e => e.VoucherTypeId);

                entity.ToTable("tbl_VoucherType");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");

                entity.Property(e => e.Declaration)
                    .IsUnicode(false)
                    .HasColumnName("declaration");

                entity.Property(e => e.Extra1)
                    .IsUnicode(false)
                    .HasColumnName("extra1");

                entity.Property(e => e.Extra2)
                    .IsUnicode(false)
                    .HasColumnName("extra2");

                entity.Property(e => e.ExtraDate)
                    .HasColumnType("datetime")
                    .HasColumnName("extraDate");

                entity.Property(e => e.Heading1)
                    .IsUnicode(false)
                    .HasColumnName("heading1");

                entity.Property(e => e.Heading2)
                    .IsUnicode(false)
                    .HasColumnName("heading2");

                entity.Property(e => e.Heading3)
                    .IsUnicode(false)
                    .HasColumnName("heading3");

                entity.Property(e => e.Heading4)
                    .IsUnicode(false)
                    .HasColumnName("heading4");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.IsTaxApplicable).HasColumnName("isTaxApplicable");

                entity.Property(e => e.MasterId).HasColumnName("masterId");

                entity.Property(e => e.MethodOfVoucherNumbering)
                    .IsUnicode(false)
                    .HasColumnName("methodOfVoucherNumbering");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.TypeOfVoucher)
                    .IsUnicode(false)
                    .HasColumnName("typeOfVoucher");

                entity.Property(e => e.VoucherTypeName)
                    .IsUnicode(false)
                    .HasColumnName("voucherTypeName");
            });

            modelBuilder.Entity<TblVoucherTypeTax>(entity =>
            {
                entity.HasKey(e => e.VoucherTypeTaxId)
                    .HasName("PK_tbl_TaxWithVoucherType");

                entity.ToTable("tbl_VoucherTypeTax");

                entity.Property(e => e.VoucherTypeTaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeTaxId");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");

                entity.Property(e => e.VoucherTypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("voucherTypeId");
            });

            modelBuilder.Entity<TblWarranty>(entity =>
            {
                entity.HasKey(e => e.WarrantyId);

                entity.ToTable("tbl_Warranty");

                entity.Property(e => e.WarrantyId).HasColumnName("warrantyId");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productCode");

                entity.Property(e => e.Uomid).HasColumnName("UOMId");

                entity.Property(e => e.VoucherTypeId).HasColumnName("voucherTypeId");

                entity.Property(e => e.WarrantyNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("warrantyNo");
            });

            modelBuilder.Entity<TblWarrantyDetail>(entity =>
            {
                entity.HasKey(e => e.WarrantyDetailsId)
                    .HasName("PK_tbl_WanretyDetails");

                entity.ToTable("tbl_WarrantyDetails");

                entity.Property(e => e.WarrantyDetailsId).HasColumnName("warrantyDetailsId");

                entity.Property(e => e.Claimed).HasColumnName("claimed");

                entity.Property(e => e.Condition).HasColumnName("condition");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsSold).HasColumnName("isSold");

                entity.Property(e => e.Narration)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.NoOfClaims).HasColumnName("noOfClaims");

                entity.Property(e => e.NoOfTerm).HasColumnName("noOfTerm");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uomid).HasColumnName("UOMId");

                entity.Property(e => e.VoucherTypeId).HasColumnName("voucherTypeId");

                entity.Property(e => e.WEnd)
                    .HasColumnType("date")
                    .HasColumnName("wEnd");

                entity.Property(e => e.WStart)
                    .HasColumnType("date")
                    .HasColumnName("wStart");

                entity.Property(e => e.WarrantyNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("warrantyNo");

                entity.Property(e => e.WarrantyTerm).HasColumnName("warrantyTerm");

                entity.Property(e => e.WarrantyType).HasColumnName("warrantyType");
            });

            modelBuilder.Entity<TblWorkUnit>(entity =>
            {
                entity.HasKey(e => e.WorkUnitId);

                entity.ToTable("tbl_WorkUnit");

                entity.Property(e => e.WorkUnitId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("workUnitId");

                entity.Property(e => e.FormalName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("formalName");

                entity.Property(e => e.Narration)
                    .IsUnicode(false)
                    .HasColumnName("narration");

                entity.Property(e => e.NoOfDecimalPlaces)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("noOfDecimalPlaces");

                entity.Property(e => e.WorkUnitSymbol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("workUnitSymbol");

                entity.Property(e => e.WorkUnitType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("workUnitType");
            });

            modelBuilder.Entity<TblWpftaxis>(entity =>
            {
                entity.HasKey(e => e.TaxId);

                entity.ToTable("tbl_WPFTaxes");

                entity.Property(e => e.TaxId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("taxId");

                entity.Property(e => e.ApplicableOn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("applicableOn");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rate");

                entity.Property(e => e.TaxName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("taxName");
            });

            modelBuilder.Entity<TblZakatPosting>(entity =>
            {
                entity.HasKey(e => e.ZakatPostingId);

                entity.ToTable("tbl_ZakatPosting");

                entity.Property(e => e.ZakatPostingId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("zakatPostingId");

                entity.Property(e => e.AccountPayables)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accountPayables");

                entity.Property(e => e.AccountReceivables)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accountReceivables");

                entity.Property(e => e.Balance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("balance");

                entity.Property(e => e.BankAccountsSum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bankAccountsSum");

                entity.Property(e => e.CashInHand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cashInHand");

                entity.Property(e => e.DatFrom)
                    .HasColumnType("date")
                    .HasColumnName("datFrom");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("dateTo");

                entity.Property(e => e.DeductionAcId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LedgerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ledgerId");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("date")
                    .HasColumnName("postingDate");

                entity.Property(e => e.Previouszakat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("previouszakat");

                entity.Property(e => e.Total)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("total");

                entity.Property(e => e.TotalStockValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("totalStockValue");

                entity.Property(e => e.TotalWealth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("totalWealth");

                entity.Property(e => e.ZakatCalculation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("zakatCalculation");

                entity.Property(e => e.ZakatPostingNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("zakatPostingNo");
            });

            modelBuilder.Entity<TbldummyAdditional>(entity =>
            {
                entity.HasKey(e => e.Stockid);

                entity.ToTable("tbldummyAdditional");

                entity.Property(e => e.Stockid)
                    .ValueGeneratedNever()
                    .HasColumnName("stockid");

                entity.Property(e => e.Color).HasColumnName("color");

                entity.Property(e => e.Extrakey1).HasColumnName("extrakey1");

                entity.Property(e => e.Extrakey2).HasColumnName("extrakey2");

                entity.Property(e => e.Imei).HasColumnName("imei");

                entity.Property(e => e.Model).HasColumnName("model");

                entity.Property(e => e.Productid).HasColumnName("productid");

                entity.Property(e => e.Qty).HasColumnName("qty");
            });

            modelBuilder.Entity<ViewAttaBookingReportDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_AttaBookingReportData");

                entity.Property(e => e.AdvanceFlour).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AttaBookingId).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DeductFlour).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeductKhout)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsClean)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Paid)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("PAID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TokenDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TokenNo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
