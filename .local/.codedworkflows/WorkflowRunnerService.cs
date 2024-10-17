using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using AuxisReFramework;

[assembly: WorkflowRunnerServiceAttribute(typeof(AuxisReFramework.WorkflowRunnerService))]
namespace AuxisReFramework
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Tests/InitAllApplicationsTestCase.xaml
        /// </summary>
        public void InitAllApplicationsTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllApplicationsTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Misc/Misc_FinalizeTransaction.xaml
        /// </summary>
        public System.Data.DataTable Misc_FinalizeTransaction(int in_TransactionNumber, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.BusinessRuleException in_BusinessException, System.Exception in_SystemException, UiPath.Core.QueueItem in_TransactionItem, int in_RetryNumber, System.Data.DataTable io_dt_TransactionData)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Misc\Misc_FinalizeTransaction.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_Config", in_Config}, {"in_BusinessException", in_BusinessException}, {"in_SystemException", in_SystemException}, {"in_TransactionItem", in_TransactionItem}, {"in_RetryNumber", in_RetryNumber}, {"io_dt_TransactionData", io_dt_TransactionData}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dt_TransactionData"];
        }

        /// <summary>
        /// Invokes the Misc/Misc_AddCustomColumnTransactionData.xaml
        /// </summary>
        public System.Data.DataTable Misc_AddCustomColumnTransactionData(string in_TransactionDataColumns, string in_CustomColumnStartingIndex, System.Data.DataTable io_dt_TransactionData)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Misc\Misc_AddCustomColumnTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionDataColumns", in_TransactionDataColumns}, {"in_CustomColumnStartingIndex", in_CustomColumnStartingIndex}, {"io_dt_TransactionData", io_dt_TransactionData}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["io_dt_TransactionData"];
        }

        /// <summary>
        /// Invokes the Tests/MainTestCase.xaml
        /// </summary>
        public void MainTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\MainTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Misc/Misc_InitializeTransactionData.xaml
        /// </summary>
        public (System.Collections.Generic.Dictionary<string, object> out_QueueItemDictionary, System.Data.DataTable io_dt_TransactionData) Misc_InitializeTransactionData(System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable io_dt_TransactionData)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Misc\Misc_InitializeTransactionData.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"io_dt_TransactionData", io_dt_TransactionData}}, default, default, default, GetAssemblyName());
            return ((System.Collections.Generic.Dictionary<string, object>)result["out_QueueItemDictionary"], (System.Data.DataTable)result["io_dt_TransactionData"]);
        }

        /// <summary>
        /// Invokes the Misc/Misc_CleanupFiles.xaml
        /// </summary>
        public void Misc_CleanupFiles(System.IO.DirectoryInfo in_Directory, System.DateTime in_DateDifference)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Misc\Misc_CleanupFiles.xaml", new Dictionary<string, object>{{"in_Directory", in_Directory}, {"in_DateDifference", in_DateDifference}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main(string in_OrchestratorQueueName, int in_MaxNumberOfTransactions, string in_OrchestratorQueueFolder)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{{"in_OrchestratorQueueName", in_OrchestratorQueueName}, {"in_MaxNumberOfTransactions", in_MaxNumberOfTransactions}, {"in_OrchestratorQueueFolder", in_OrchestratorQueueFolder}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/GetTransactionDataTestCase.xaml
        /// </summary>
        public void GetTransactionDataTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\GetTransactionDataTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Misc/Misc_CleanupQueue.xaml
        /// </summary>
        public void Misc_CleanupQueue(string in_QueueName)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Misc\Misc_CleanupQueue.xaml", new Dictionary<string, object>{{"in_QueueName", in_QueueName}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Generate WFs/BuildWorkflowArguments.xaml
        /// </summary>
        public string BuildWorkflowArguments(string in_InputArguments, string in_OutputArguments, string io_WorkflowText)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Generate WFs\BuildWorkflowArguments.xaml", new Dictionary<string, object>{{"in_InputArguments", in_InputArguments}, {"in_OutputArguments", in_OutputArguments}, {"io_WorkflowText", io_WorkflowText}}, default, default, default, GetAssemblyName());
            return (string)result["io_WorkflowText"];
        }

        /// <summary>
        /// Invokes the Framework/Email/Send Results.xaml
        /// </summary>
        public string Send_Results(string[] in_AttachmentFolders, string[] in_Attachments, string[] in_SubjectValues, string[] in_BodyValues, string in_ToAddress, string in_CCAddress, string in_OutlookAccount, string in_OutlookOnBehalfOf, System.Data.DataTable in_dt_Notifications, System.Data.DataTable in_dt_TransactionData, bool in_UseOffice365, string in_AzureTenantID, string in_AzureAssetFolder, string in_AzureAssetAppIDAndSecret, string io_ResultsFile)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Email\Send Results.xaml", new Dictionary<string, object>{{"in_AttachmentFolders", in_AttachmentFolders}, {"in_Attachments", in_Attachments}, {"in_SubjectValues", in_SubjectValues}, {"in_BodyValues", in_BodyValues}, {"in_ToAddress", in_ToAddress}, {"in_CCAddress", in_CCAddress}, {"in_OutlookAccount", in_OutlookAccount}, {"in_OutlookOnBehalfOf", in_OutlookOnBehalfOf}, {"in_dt_Notifications", in_dt_Notifications}, {"in_dt_TransactionData", in_dt_TransactionData}, {"in_UseOffice365", in_UseOffice365}, {"in_AzureTenantID", in_AzureTenantID}, {"in_AzureAssetFolder", in_AzureAssetFolder}, {"in_AzureAssetAppIDAndSecret", in_AzureAssetAppIDAndSecret}, {"io_ResultsFile", io_ResultsFile}}, default, default, default, GetAssemblyName());
            return (string)result["io_ResultsFile"];
        }

        /// <summary>
        /// Invokes the Misc/Misc_SendResultsNotification.xaml
        /// </summary>
        public void Misc_SendResultsNotification(System.Data.DataTable in_dt_TransactionData, System.Data.DataTable in_dt_Notifications, System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Misc\Misc_SendResultsNotification.xaml", new Dictionary<string, object>{{"in_dt_TransactionData", in_dt_TransactionData}, {"in_dt_Notifications", in_dt_Notifications}, {"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Generate WFs/BuildWorkflows.xaml
        /// </summary>
        public void BuildWorkflows()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Generate WFs\BuildWorkflows.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Generate WFs/BaseWorkflow.xaml
        /// </summary>
        public void BaseWorkflow(string in_Test)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Generate WFs\BaseWorkflow.xaml", new Dictionary<string, object>{{"in_Test", in_Test}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/Email/Send Notification.xaml
        /// </summary>
        public void Send_Notification(string[] in_BodyValues, string[] in_SubjectValues, string in_NotificationID, string[] in_AttachmentFolders, string[] in_Attachments, string in_ToAddress, string in_CCAddress, string in_OutlookAccount, string in_OutlookOnBehalfOf, System.Data.DataTable in_dt_Notifications, bool in_UseOffice365, string in_AzureTenantID, string in_AzureAssetFolder, string in_AzureAssetAppIDAndSecret)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Email\Send Notification.xaml", new Dictionary<string, object>{{"in_BodyValues", in_BodyValues}, {"in_SubjectValues", in_SubjectValues}, {"in_NotificationID", in_NotificationID}, {"in_AttachmentFolders", in_AttachmentFolders}, {"in_Attachments", in_Attachments}, {"in_ToAddress", in_ToAddress}, {"in_CCAddress", in_CCAddress}, {"in_OutlookAccount", in_OutlookAccount}, {"in_OutlookOnBehalfOf", in_OutlookOnBehalfOf}, {"in_dt_Notifications", in_dt_Notifications}, {"in_UseOffice365", in_UseOffice365}, {"in_AzureTenantID", in_AzureTenantID}, {"in_AzureAssetFolder", in_AzureAssetFolder}, {"in_AzureAssetAppIDAndSecret", in_AzureAssetAppIDAndSecret}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/InitAllSettingsTestCase.xaml
        /// </summary>
        public void InitAllSettingsTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\InitAllSettingsTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/Monitoring/Database/SP_Execution.xaml
        /// </summary>
        public void SP_Execution(System.Data.DataTable in_dt_Summary, UiPath.Database.DatabaseConnection in_DBConnection)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Monitoring\Database\SP_Execution.xaml", new Dictionary<string, object>{{"in_dt_Summary", in_dt_Summary}, {"in_DBConnection", in_DBConnection}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
        public string TakeScreenshot(string in_Folder, string io_FilePath)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, default, default, GetAssemblyName());
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
        public (UiPath.Core.QueueItem out_TransactionItem, string out_TransactionField1, string out_TransactionField2, string out_TransactionID, System.Data.DataRow out_drTransactionItem, System.Data.DataTable io_dt_TransactionData) GetTransactionData(int in_TransactionNumber, System.Collections.Generic.Dictionary<string, object> in_Config, System.Collections.Generic.Dictionary<string, object> in_QueueItemDictionary, System.Data.DataTable io_dt_TransactionData)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_Config", in_Config}, {"in_QueueItemDictionary", in_QueueItemDictionary}, {"io_dt_TransactionData", io_dt_TransactionData}}, default, default, default, GetAssemblyName());
            return ((UiPath.Core.QueueItem)result["out_TransactionItem"], (string)result["out_TransactionField1"], (string)result["out_TransactionField2"], (string)result["out_TransactionID"], (System.Data.DataRow)result["out_drTransactionItem"], (System.Data.DataTable)result["io_dt_TransactionData"]);
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
        public void CloseAllApplications()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the BuildMessage.xaml
        /// </summary>
        public string BuildMessage(UiPath.CommunicationsMining.Activities.Predictions.Models.PredictResponse in_record_response)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"BuildMessage.xaml", new Dictionary<string, object>{{"in_record_response", in_record_response}}, default, default, default, GetAssemblyName());
            return (string)result["out_responseMessage"];
        }

        /// <summary>
        /// Invokes the Tests/WorkflowTestCaseTemplate.xaml
        /// </summary>
        public void WorkflowTestCaseTemplate()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\WorkflowTestCaseTemplate.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/GeneralTestCase.xaml
        /// </summary>
        public void GeneralTestCase(string in_WorkflowFile, string in_ExpectedResult)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\GeneralTestCase.xaml", new Dictionary<string, object>{{"in_WorkflowFile", in_WorkflowFile}, {"in_ExpectedResult", in_ExpectedResult}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Misc/Misc_CleanupFolder.xaml
        /// </summary>
        public void Misc_CleanupFolder(string[] in_FolderList, int in_RetentionDays)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Misc\Misc_CleanupFolder.xaml", new Dictionary<string, object>{{"in_FolderList", in_FolderList}, {"in_RetentionDays", in_RetentionDays}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/Monitoring/Summary/Get_SummaryInfo.xaml
        /// </summary>
        public System.Data.DataTable Get_SummaryInfo(string in_ProcessFolder, System.Data.DataTable in_dt_TransactionData, string in_ProcessName, string in_MachineName, string in_UserName)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Monitoring\Summary\Get_SummaryInfo.xaml", new Dictionary<string, object>{{"in_ProcessFolder", in_ProcessFolder}, {"in_dt_TransactionData", in_dt_TransactionData}, {"in_ProcessName", in_ProcessName}, {"in_MachineName", in_MachineName}, {"in_UserName", in_UserName}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["out_dt_Summary"];
        }

        /// <summary>
        /// Invokes the Framework/Monitoring/Database/DB_Connection.xaml
        /// </summary>
        public (UiPath.Database.DatabaseConnection out_DBConnection, bool out_ConnectionState) DB_Connection(string in_ConnectionAssetName, string in_DBCredentialsAssetName)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Monitoring\Database\DB_Connection.xaml", new Dictionary<string, object>{{"in_ConnectionAssetName", in_ConnectionAssetName}, {"in_DBCredentialsAssetName", in_DBCredentialsAssetName}}, default, default, default, GetAssemblyName());
            return ((UiPath.Database.DatabaseConnection)result["out_DBConnection"], (bool)result["out_ConnectionState"]);
        }

        /// <summary>
        /// Invokes the Framework/Monitoring/Insert_Summary.xaml
        /// </summary>
        public void Insert_Summary(string in_ProcessName, string in_ProcessFolder, System.Data.DataTable in_dt_TransactionData, string in_DBCredentialsAssetName, string in_ConnectionAssetName, System.Data.DataTable in_dt_Notifications, bool in_UseOffice365, string in_AzureTenantID, string in_AzureAssetFolder, string in_AzureAssetAppIDAndSecret)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Monitoring\Insert_Summary.xaml", new Dictionary<string, object>{{"in_ProcessName", in_ProcessName}, {"in_ProcessFolder", in_ProcessFolder}, {"in_dt_TransactionData", in_dt_TransactionData}, {"in_DBCredentialsAssetName", in_DBCredentialsAssetName}, {"in_ConnectionAssetName", in_ConnectionAssetName}, {"in_dt_Notifications", in_dt_Notifications}, {"in_UseOffice365", in_UseOffice365}, {"in_AzureTenantID", in_AzureTenantID}, {"in_AzureAssetFolder", in_AzureAssetFolder}, {"in_AzureAssetAppIDAndSecret", in_AzureAssetAppIDAndSecret}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Collections.Generic.Dictionary<string, object> in_Config, System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
        public void KillAllProcesses()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
        public void InitAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Exceptions/Misc_HandleExceptionRegex.xaml
        /// </summary>
        public System.Data.DataRow Misc_HandleExceptionRegex(System.Data.DataTable in_dt_Exceptions, string in_ExceptionMessage)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Exceptions\Misc_HandleExceptionRegex.xaml", new Dictionary<string, object>{{"in_dt_Exceptions", in_dt_Exceptions}, {"in_ExceptionMessage", in_ExceptionMessage}}, default, default, default, GetAssemblyName());
            return (System.Data.DataRow)result["out_ExceptionRow"];
        }

        /// <summary>
        /// Invokes the GetPrediction.xaml
        /// </summary>
        public UiPath.CommunicationsMining.Activities.Predictions.Models.PredictResponse GetPrediction(System.Data.DataRow in_dr_Item)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GetPrediction.xaml", new Dictionary<string, object>{{"in_dr_Item", in_dr_Item}}, default, default, default, GetAssemblyName());
            return (UiPath.CommunicationsMining.Activities.Predictions.Models.PredictResponse)result["out_record_prediction"];
        }

        /// <summary>
        /// Invokes the Tests/ProcessTestCase.xaml
        /// </summary>
        public void ProcessTestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\ProcessTestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Misc/Misc_SaveExcel.xaml
        /// </summary>
        public void Misc_SaveExcel(string in_ExcelFilename, string in_SheetName, System.Data.DataTable in_dt_Data, bool in_ReportError)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Misc\Misc_SaveExcel.xaml", new Dictionary<string, object>{{"in_ExcelFilename", in_ExcelFilename}, {"in_SheetName", in_SheetName}, {"in_dt_Data", in_dt_Data}, {"in_ReportError", in_ReportError}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions) SetTransactionStatus(System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, string in_TransactionField1, string in_TransactionField2, string in_TransactionID, System.Exception in_SystemException, UiPath.Core.BusinessRuleException in_BusinessException, int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_TransactionItem", in_TransactionItem}, {"in_TransactionField1", in_TransactionField1}, {"in_TransactionField2", in_TransactionField2}, {"in_TransactionID", in_TransactionID}, {"in_SystemException", in_SystemException}, {"in_BusinessException", in_BusinessException}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}, {"io_ConsecutiveSystemExceptions", io_ConsecutiveSystemExceptions}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (int)result["io_ConsecutiveSystemExceptions"]);
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
        public System.Collections.Generic.Dictionary<string, object> InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_ConfigFile", in_ConfigFile}, {"in_ConfigSheets", in_ConfigSheets}}, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, object>)result["out_Config"];
        }

        /// <summary>
        /// Invokes the Exceptions/Misc_HandleExceptionFrequency.xaml
        /// </summary>
        public (string out_SendEmail, System.Data.DataTable io_dt_ExceptionsControl) Misc_HandleExceptionFrequency(System.Data.DataRow in_ExceptionRow, System.Data.DataTable io_dt_ExceptionsControl)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Exceptions\Misc_HandleExceptionFrequency.xaml", new Dictionary<string, object>{{"in_ExceptionRow", in_ExceptionRow}, {"io_dt_ExceptionsControl", io_dt_ExceptionsControl}}, default, default, default, GetAssemblyName());
            return ((string)result["out_SendEmail"], (System.Data.DataTable)result["io_dt_ExceptionsControl"]);
        }

        /// <summary>
        /// Invokes the Process.xaml
        /// </summary>
        public System.Data.DataRow Process(UiPath.Core.QueueItem in_TransactionItem, System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataRow io_drTransactionItem)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process.xaml", new Dictionary<string, object>{{"in_TransactionItem", in_TransactionItem}, {"in_Config", in_Config}, {"io_drTransactionItem", io_drTransactionItem}}, default, default, default, GetAssemblyName());
            return (System.Data.DataRow)result["io_drTransactionItem"];
        }

        /// <summary>
        /// Invokes the Misc/Misc_LoadFiles.xaml
        /// </summary>
        public System.Data.DataTable Misc_LoadFiles(string in_NotificationsFile, string in_ProcessName)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Misc\Misc_LoadFiles.xaml", new Dictionary<string, object>{{"in_NotificationsFile", in_NotificationsFile}, {"in_ProcessName", in_ProcessName}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["out_dt_Notifications"];
        }

        /// <summary>
        /// Invokes the Framework/Monitoring/Send Notification.xaml
        /// </summary>
        public void Framework_Monitoring_Send_Notification(string[] in_BodyValues, string[] in_SubjectValues, string in_NotificationID, string[] in_AttachmentFolders, string[] in_Attachments, string in_ToAddress, string in_CCAddress, string in_OutlookAccount, string in_OutlookOnBehalfOf, System.Data.DataTable in_dt_Notifications, bool in_UseOffice365, string in_AzureTenantID, string in_AzureAssetFolder, string in_AzureAssetAppIDAndSecret)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Monitoring\Send Notification.xaml", new Dictionary<string, object>{{"in_BodyValues", in_BodyValues}, {"in_SubjectValues", in_SubjectValues}, {"in_NotificationID", in_NotificationID}, {"in_AttachmentFolders", in_AttachmentFolders}, {"in_Attachments", in_Attachments}, {"in_ToAddress", in_ToAddress}, {"in_CCAddress", in_CCAddress}, {"in_OutlookAccount", in_OutlookAccount}, {"in_OutlookOnBehalfOf", in_OutlookOnBehalfOf}, {"in_dt_Notifications", in_dt_Notifications}, {"in_UseOffice365", in_UseOffice365}, {"in_AzureTenantID", in_AzureTenantID}, {"in_AzureAssetFolder", in_AzureAssetFolder}, {"in_AzureAssetAppIDAndSecret", in_AzureAssetAppIDAndSecret}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/Email/Send Error.xaml
        /// </summary>
        public void Send_Error(string in_NotificationID, string[] in_BodyValues, string[] in_SubjectValues, string in_ToAddress, string in_CCAddress, string in_OutlookAccount, string in_OutlookOnBehalfOf, System.Data.DataTable in_dt_Notifications, bool in_UseOffice365, string in_AzureTenantID, string in_AzureAssetFolder, string in_AzureAssetAppIDAndSecret)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Email\Send Error.xaml", new Dictionary<string, object>{{"in_NotificationID", in_NotificationID}, {"in_BodyValues", in_BodyValues}, {"in_SubjectValues", in_SubjectValues}, {"in_ToAddress", in_ToAddress}, {"in_CCAddress", in_CCAddress}, {"in_OutlookAccount", in_OutlookAccount}, {"in_OutlookOnBehalfOf", in_OutlookOnBehalfOf}, {"in_dt_Notifications", in_dt_Notifications}, {"in_UseOffice365", in_UseOffice365}, {"in_AzureTenantID", in_AzureTenantID}, {"in_AzureAssetFolder", in_AzureAssetFolder}, {"in_AzureAssetAppIDAndSecret", in_AzureAssetAppIDAndSecret}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Exceptions/Misc_HandleException.xaml
        /// </summary>
        public (bool out_ExceptionFound, System.Data.DataTable io_dt_ExceptionsControl) Misc_HandleException(System.Exception in_Exception, System.Data.DataTable in_dt_Notifications, string in_NotificationsFile, System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable io_dt_ExceptionsControl)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Exceptions\Misc_HandleException.xaml", new Dictionary<string, object>{{"in_Exception", in_Exception}, {"in_dt_Notifications", in_dt_Notifications}, {"in_NotificationsFile", in_NotificationsFile}, {"in_Config", in_Config}, {"io_dt_ExceptionsControl", io_dt_ExceptionsControl}}, default, default, default, GetAssemblyName());
            return ((bool)result["out_ExceptionFound"], (System.Data.DataTable)result["io_dt_ExceptionsControl"]);
        }

        /// <summary>
        /// Invokes the SendResponse.xaml
        /// </summary>
        public void SendResponse(string in_to, string in_message)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"SendResponse.xaml", new Dictionary<string, object>{{"in_to", in_to}, {"in_message", in_message}}, default, default, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}