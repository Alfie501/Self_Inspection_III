﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Self_Inspection_III.MesSvc {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MesSvc.Service1Soap")]
    public interface Service1Soap {
        
        // CODEGEN: 參數 'Params' 需要無法以參數模式來擷取的其他架構資訊。特定屬性為 'System.Xml.Serialization.XmlArrayItemAttribute'。
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteSQL", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        Self_Inspection_III.MesSvc.ExecuteSQLResponse ExecuteSQL(Self_Inspection_III.MesSvc.ExecuteSQLRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteSQL", ReplyAction="*")]
        System.Threading.Tasks.Task<Self_Inspection_III.MesSvc.ExecuteSQLResponse> ExecuteSQLAsync(Self_Inspection_III.MesSvc.ExecuteSQLRequest request);
        
        // CODEGEN: 參數 'Params' 需要無法以參數模式來擷取的其他架構資訊。特定屬性為 'System.Xml.Serialization.XmlArrayItemAttribute'。
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteProc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        Self_Inspection_III.MesSvc.ExecuteProcResponse ExecuteProc(Self_Inspection_III.MesSvc.ExecuteProcRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ExecuteProc", ReplyAction="*")]
        System.Threading.Tasks.Task<Self_Inspection_III.MesSvc.ExecuteProcResponse> ExecuteProcAsync(Self_Inspection_III.MesSvc.ExecuteProcRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CaseNumberUpload", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        string CaseNumberUpload(string sApprove);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CaseNumberUpload", ReplyAction="*")]
        System.Threading.Tasks.Task<string> CaseNumberUploadAsync(string sApprove);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CaseNumberUploadAll", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        void CaseNumberUploadAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CaseNumberUploadAll", ReplyAction="*")]
        System.Threading.Tasks.Task CaseNumberUploadAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ApproveUpload", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        string ApproveUpload(string sApprove, string sApply, string sDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ApproveUpload", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ApproveUploadAsync(string sApprove, string sApply, string sDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_SN_Info", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        System.Data.DataSet Get_SN_Info(string sSN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_SN_Info", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> Get_SN_InfoAsync(string sSN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_SN_KP_Info", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        System.Data.DataSet Get_SN_KP_Info(string sSN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_SN_KP_Info", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> Get_SN_KP_InfoAsync(string sSN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_Data_String", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        string Get_Data_String(string sType, string sValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_Data_String", ReplyAction="*")]
        System.Threading.Tasks.Task<string> Get_Data_StringAsync(string sType, string sValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_Data", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        System.Data.DataSet Get_Data(string sType, string sValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_Data", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> Get_DataAsync(string sType, string sValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_MySQL_Data", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        System.Data.DataSet Get_MySQL_Data(string sType, string sValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_MySQL_Data", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> Get_MySQL_DataAsync(string sType, string sValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insert_MySQL_Data", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        System.Data.DataSet Insert_MySQL_Data(string sType, string sValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insert_MySQL_Data", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> Insert_MySQL_DataAsync(string sType, string sValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Convert_To_Big5", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        string Convert_To_Big5(string SourceString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Convert_To_Big5", ReplyAction="*")]
        System.Threading.Tasks.Task<string> Convert_To_Big5Async(string SourceString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Convert_To_GB2312", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        string Convert_To_GB2312(string SourceString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Convert_To_GB2312", ReplyAction="*")]
        System.Threading.Tasks.Task<string> Convert_To_GB2312Async(string SourceString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Check_Data", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        string Check_Data(string sProc, string sData, string sSplit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Check_Data", ReplyAction="*")]
        System.Threading.Tasks.Task<string> Check_DataAsync(string sProc, string sData, string sSplit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Check_Data_DataSet", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        System.Data.DataSet Check_Data_DataSet(string sProc, string sData, string sSplit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Check_Data_DataSet", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> Check_Data_DataSetAsync(string sProc, string sData, string sSplit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Check_File", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        string Check_File(string sType, string sFileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Check_File", ReplyAction="*")]
        System.Threading.Tasks.Task<string> Check_FileAsync(string sType, string sFileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RunExe", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[][]))]
        void RunExe(string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RunExe", ReplyAction="*")]
        System.Threading.Tasks.Task RunExeAsync(string fileName);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteSQL", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteSQLRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string sSQL;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ArrayOfAnyType")]
        [System.Xml.Serialization.XmlArrayItemAttribute(NestingLevel=1)]
        public object[][] Params;
        
        public ExecuteSQLRequest() {
        }
        
        public ExecuteSQLRequest(string sSQL, object[][] Params) {
            this.sSQL = sSQL;
            this.Params = Params;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteSQLResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteSQLResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Data.DataSet ExecuteSQLResult;
        
        public ExecuteSQLResponse() {
        }
        
        public ExecuteSQLResponse(System.Data.DataSet ExecuteSQLResult) {
            this.ExecuteSQLResult = ExecuteSQLResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteProc", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteProcRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string sProcName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ArrayOfAnyType")]
        [System.Xml.Serialization.XmlArrayItemAttribute(NestingLevel=1)]
        public object[][] Params;
        
        public ExecuteProcRequest() {
        }
        
        public ExecuteProcRequest(string sProcName, object[][] Params) {
            this.sProcName = sProcName;
            this.Params = Params;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteProcResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteProcResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Data.DataSet ExecuteProcResult;
        
        public ExecuteProcResponse() {
        }
        
        public ExecuteProcResponse(System.Data.DataSet ExecuteProcResult) {
            this.ExecuteProcResult = ExecuteProcResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service1SoapChannel : Self_Inspection_III.MesSvc.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<Self_Inspection_III.MesSvc.Service1Soap>, Self_Inspection_III.MesSvc.Service1Soap {
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Self_Inspection_III.MesSvc.ExecuteSQLResponse Self_Inspection_III.MesSvc.Service1Soap.ExecuteSQL(Self_Inspection_III.MesSvc.ExecuteSQLRequest request) {
            return base.Channel.ExecuteSQL(request);
        }
        
        public System.Data.DataSet ExecuteSQL(string sSQL, object[][] Params) {
            Self_Inspection_III.MesSvc.ExecuteSQLRequest inValue = new Self_Inspection_III.MesSvc.ExecuteSQLRequest();
            inValue.sSQL = sSQL;
            inValue.Params = Params;
            Self_Inspection_III.MesSvc.ExecuteSQLResponse retVal = ((Self_Inspection_III.MesSvc.Service1Soap)(this)).ExecuteSQL(inValue);
            return retVal.ExecuteSQLResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Self_Inspection_III.MesSvc.ExecuteSQLResponse> Self_Inspection_III.MesSvc.Service1Soap.ExecuteSQLAsync(Self_Inspection_III.MesSvc.ExecuteSQLRequest request) {
            return base.Channel.ExecuteSQLAsync(request);
        }
        
        public System.Threading.Tasks.Task<Self_Inspection_III.MesSvc.ExecuteSQLResponse> ExecuteSQLAsync(string sSQL, object[][] Params) {
            Self_Inspection_III.MesSvc.ExecuteSQLRequest inValue = new Self_Inspection_III.MesSvc.ExecuteSQLRequest();
            inValue.sSQL = sSQL;
            inValue.Params = Params;
            return ((Self_Inspection_III.MesSvc.Service1Soap)(this)).ExecuteSQLAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Self_Inspection_III.MesSvc.ExecuteProcResponse Self_Inspection_III.MesSvc.Service1Soap.ExecuteProc(Self_Inspection_III.MesSvc.ExecuteProcRequest request) {
            return base.Channel.ExecuteProc(request);
        }
        
        public System.Data.DataSet ExecuteProc(string sProcName, object[][] Params) {
            Self_Inspection_III.MesSvc.ExecuteProcRequest inValue = new Self_Inspection_III.MesSvc.ExecuteProcRequest();
            inValue.sProcName = sProcName;
            inValue.Params = Params;
            Self_Inspection_III.MesSvc.ExecuteProcResponse retVal = ((Self_Inspection_III.MesSvc.Service1Soap)(this)).ExecuteProc(inValue);
            return retVal.ExecuteProcResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Self_Inspection_III.MesSvc.ExecuteProcResponse> Self_Inspection_III.MesSvc.Service1Soap.ExecuteProcAsync(Self_Inspection_III.MesSvc.ExecuteProcRequest request) {
            return base.Channel.ExecuteProcAsync(request);
        }
        
        public System.Threading.Tasks.Task<Self_Inspection_III.MesSvc.ExecuteProcResponse> ExecuteProcAsync(string sProcName, object[][] Params) {
            Self_Inspection_III.MesSvc.ExecuteProcRequest inValue = new Self_Inspection_III.MesSvc.ExecuteProcRequest();
            inValue.sProcName = sProcName;
            inValue.Params = Params;
            return ((Self_Inspection_III.MesSvc.Service1Soap)(this)).ExecuteProcAsync(inValue);
        }
        
        public string CaseNumberUpload(string sApprove) {
            return base.Channel.CaseNumberUpload(sApprove);
        }
        
        public System.Threading.Tasks.Task<string> CaseNumberUploadAsync(string sApprove) {
            return base.Channel.CaseNumberUploadAsync(sApprove);
        }
        
        public void CaseNumberUploadAll() {
            base.Channel.CaseNumberUploadAll();
        }
        
        public System.Threading.Tasks.Task CaseNumberUploadAllAsync() {
            return base.Channel.CaseNumberUploadAllAsync();
        }
        
        public string ApproveUpload(string sApprove, string sApply, string sDate) {
            return base.Channel.ApproveUpload(sApprove, sApply, sDate);
        }
        
        public System.Threading.Tasks.Task<string> ApproveUploadAsync(string sApprove, string sApply, string sDate) {
            return base.Channel.ApproveUploadAsync(sApprove, sApply, sDate);
        }
        
        public System.Data.DataSet Get_SN_Info(string sSN) {
            return base.Channel.Get_SN_Info(sSN);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> Get_SN_InfoAsync(string sSN) {
            return base.Channel.Get_SN_InfoAsync(sSN);
        }
        
        public System.Data.DataSet Get_SN_KP_Info(string sSN) {
            return base.Channel.Get_SN_KP_Info(sSN);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> Get_SN_KP_InfoAsync(string sSN) {
            return base.Channel.Get_SN_KP_InfoAsync(sSN);
        }
        
        public string Get_Data_String(string sType, string sValue) {
            return base.Channel.Get_Data_String(sType, sValue);
        }
        
        public System.Threading.Tasks.Task<string> Get_Data_StringAsync(string sType, string sValue) {
            return base.Channel.Get_Data_StringAsync(sType, sValue);
        }
        
        public System.Data.DataSet Get_Data(string sType, string sValue) {
            return base.Channel.Get_Data(sType, sValue);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> Get_DataAsync(string sType, string sValue) {
            return base.Channel.Get_DataAsync(sType, sValue);
        }
        
        public System.Data.DataSet Get_MySQL_Data(string sType, string sValue) {
            return base.Channel.Get_MySQL_Data(sType, sValue);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> Get_MySQL_DataAsync(string sType, string sValue) {
            return base.Channel.Get_MySQL_DataAsync(sType, sValue);
        }
        
        public System.Data.DataSet Insert_MySQL_Data(string sType, string sValue) {
            return base.Channel.Insert_MySQL_Data(sType, sValue);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> Insert_MySQL_DataAsync(string sType, string sValue) {
            return base.Channel.Insert_MySQL_DataAsync(sType, sValue);
        }
        
        public string Convert_To_Big5(string SourceString) {
            return base.Channel.Convert_To_Big5(SourceString);
        }
        
        public System.Threading.Tasks.Task<string> Convert_To_Big5Async(string SourceString) {
            return base.Channel.Convert_To_Big5Async(SourceString);
        }
        
        public string Convert_To_GB2312(string SourceString) {
            return base.Channel.Convert_To_GB2312(SourceString);
        }
        
        public System.Threading.Tasks.Task<string> Convert_To_GB2312Async(string SourceString) {
            return base.Channel.Convert_To_GB2312Async(SourceString);
        }
        
        public string Check_Data(string sProc, string sData, string sSplit) {
            return base.Channel.Check_Data(sProc, sData, sSplit);
        }
        
        public System.Threading.Tasks.Task<string> Check_DataAsync(string sProc, string sData, string sSplit) {
            return base.Channel.Check_DataAsync(sProc, sData, sSplit);
        }
        
        public System.Data.DataSet Check_Data_DataSet(string sProc, string sData, string sSplit) {
            return base.Channel.Check_Data_DataSet(sProc, sData, sSplit);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> Check_Data_DataSetAsync(string sProc, string sData, string sSplit) {
            return base.Channel.Check_Data_DataSetAsync(sProc, sData, sSplit);
        }
        
        public string Check_File(string sType, string sFileName) {
            return base.Channel.Check_File(sType, sFileName);
        }
        
        public System.Threading.Tasks.Task<string> Check_FileAsync(string sType, string sFileName) {
            return base.Channel.Check_FileAsync(sType, sFileName);
        }
        
        public void RunExe(string fileName) {
            base.Channel.RunExe(fileName);
        }
        
        public System.Threading.Tasks.Task RunExeAsync(string fileName) {
            return base.Channel.RunExeAsync(fileName);
        }
    }
}