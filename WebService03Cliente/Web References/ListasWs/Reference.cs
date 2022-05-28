﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebService03Cliente.ListasWs {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebServiceListasSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[][]))]
    public partial class WebServiceListas : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ListaSimpleOperationCompleted;
        
        private System.Threading.SendOrPostCallback ListaDeArreglosOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebServiceListas() {
            this.Url = global::WebService03Cliente.Properties.Settings.Default.WebService03Cliente_ListasWs_WebServiceListas;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ListaSimpleCompletedEventHandler ListaSimpleCompleted;
        
        /// <remarks/>
        public event ListaDeArreglosCompletedEventHandler ListaDeArreglosCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListaSimple", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int[] ListaSimple() {
            object[] results = this.Invoke("ListaSimple", new object[0]);
            return ((int[])(results[0]));
        }
        
        /// <remarks/>
        public void ListaSimpleAsync() {
            this.ListaSimpleAsync(null);
        }
        
        /// <remarks/>
        public void ListaSimpleAsync(object userState) {
            if ((this.ListaSimpleOperationCompleted == null)) {
                this.ListaSimpleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListaSimpleOperationCompleted);
            }
            this.InvokeAsync("ListaSimple", new object[0], this.ListaSimpleOperationCompleted, userState);
        }
        
        private void OnListaSimpleOperationCompleted(object arg) {
            if ((this.ListaSimpleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListaSimpleCompleted(this, new ListaSimpleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListaDeArreglos", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("ArrayOfAnyType")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(NestingLevel=1)]
        public object[][] ListaDeArreglos() {
            object[] results = this.Invoke("ListaDeArreglos", new object[0]);
            return ((object[][])(results[0]));
        }
        
        /// <remarks/>
        public void ListaDeArreglosAsync() {
            this.ListaDeArreglosAsync(null);
        }
        
        /// <remarks/>
        public void ListaDeArreglosAsync(object userState) {
            if ((this.ListaDeArreglosOperationCompleted == null)) {
                this.ListaDeArreglosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListaDeArreglosOperationCompleted);
            }
            this.InvokeAsync("ListaDeArreglos", new object[0], this.ListaDeArreglosOperationCompleted, userState);
        }
        
        private void OnListaDeArreglosOperationCompleted(object arg) {
            if ((this.ListaDeArreglosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListaDeArreglosCompleted(this, new ListaDeArreglosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ListaSimpleCompletedEventHandler(object sender, ListaSimpleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListaSimpleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ListaSimpleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ListaDeArreglosCompletedEventHandler(object sender, ListaDeArreglosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListaDeArreglosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ListaDeArreglosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object[][] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object[][])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591