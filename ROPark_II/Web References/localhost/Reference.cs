﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace ROPark_II.localhost {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://tempuri.org/")]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getAllCitesOperationCompleted;
        
        private System.Threading.SendOrPostCallback getCityByIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback getRegionByCityIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback checkUserNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback checkUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback getUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback checkParkingPlaceOperationCompleted;
        
        private System.Threading.SendOrPostCallback addUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback checkCityDBOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::ROPark_II.Properties.Settings.Default.ROPark_II_localhost_WebService1;
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
        public event getAllCitesCompletedEventHandler getAllCitesCompleted;
        
        /// <remarks/>
        public event getCityByIdCompletedEventHandler getCityByIdCompleted;
        
        /// <remarks/>
        public event getRegionByCityIdCompletedEventHandler getRegionByCityIdCompleted;
        
        /// <remarks/>
        public event checkUserNameCompletedEventHandler checkUserNameCompleted;
        
        /// <remarks/>
        public event checkUserCompletedEventHandler checkUserCompleted;
        
        /// <remarks/>
        public event getUserCompletedEventHandler getUserCompleted;
        
        /// <remarks/>
        public event checkParkingPlaceCompletedEventHandler checkParkingPlaceCompleted;
        
        /// <remarks/>
        public event addUserCompletedEventHandler addUserCompleted;
        
        /// <remarks/>
        public event checkCityDBCompletedEventHandler checkCityDBCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getAllCites", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public City[] getAllCites() {
            object[] results = this.Invoke("getAllCites", new object[0]);
            return ((City[])(results[0]));
        }
        
        /// <remarks/>
        public void getAllCitesAsync() {
            this.getAllCitesAsync(null);
        }
        
        /// <remarks/>
        public void getAllCitesAsync(object userState) {
            if ((this.getAllCitesOperationCompleted == null)) {
                this.getAllCitesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllCitesOperationCompleted);
            }
            this.InvokeAsync("getAllCites", new object[0], this.getAllCitesOperationCompleted, userState);
        }
        
        private void OngetAllCitesOperationCompleted(object arg) {
            if ((this.getAllCitesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllCitesCompleted(this, new getAllCitesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getCityById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getCityById(int id) {
            object[] results = this.Invoke("getCityById", new object[] {
                        id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getCityByIdAsync(int id) {
            this.getCityByIdAsync(id, null);
        }
        
        /// <remarks/>
        public void getCityByIdAsync(int id, object userState) {
            if ((this.getCityByIdOperationCompleted == null)) {
                this.getCityByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCityByIdOperationCompleted);
            }
            this.InvokeAsync("getCityById", new object[] {
                        id}, this.getCityByIdOperationCompleted, userState);
        }
        
        private void OngetCityByIdOperationCompleted(object arg) {
            if ((this.getCityByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCityByIdCompleted(this, new getCityByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getRegionByCityId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] getRegionByCityId(int idCity) {
            object[] results = this.Invoke("getRegionByCityId", new object[] {
                        idCity});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void getRegionByCityIdAsync(int idCity) {
            this.getRegionByCityIdAsync(idCity, null);
        }
        
        /// <remarks/>
        public void getRegionByCityIdAsync(int idCity, object userState) {
            if ((this.getRegionByCityIdOperationCompleted == null)) {
                this.getRegionByCityIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetRegionByCityIdOperationCompleted);
            }
            this.InvokeAsync("getRegionByCityId", new object[] {
                        idCity}, this.getRegionByCityIdOperationCompleted, userState);
        }
        
        private void OngetRegionByCityIdOperationCompleted(object arg) {
            if ((this.getRegionByCityIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getRegionByCityIdCompleted(this, new getRegionByCityIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/checkUserName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool checkUserName(string name) {
            object[] results = this.Invoke("checkUserName", new object[] {
                        name});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void checkUserNameAsync(string name) {
            this.checkUserNameAsync(name, null);
        }
        
        /// <remarks/>
        public void checkUserNameAsync(string name, object userState) {
            if ((this.checkUserNameOperationCompleted == null)) {
                this.checkUserNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckUserNameOperationCompleted);
            }
            this.InvokeAsync("checkUserName", new object[] {
                        name}, this.checkUserNameOperationCompleted, userState);
        }
        
        private void OncheckUserNameOperationCompleted(object arg) {
            if ((this.checkUserNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkUserNameCompleted(this, new checkUserNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/checkUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool checkUser(string name, string password) {
            object[] results = this.Invoke("checkUser", new object[] {
                        name,
                        password});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void checkUserAsync(string name, string password) {
            this.checkUserAsync(name, password, null);
        }
        
        /// <remarks/>
        public void checkUserAsync(string name, string password, object userState) {
            if ((this.checkUserOperationCompleted == null)) {
                this.checkUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckUserOperationCompleted);
            }
            this.InvokeAsync("checkUser", new object[] {
                        name,
                        password}, this.checkUserOperationCompleted, userState);
        }
        
        private void OncheckUserOperationCompleted(object arg) {
            if ((this.checkUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkUserCompleted(this, new checkUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] getUser(string name) {
            object[] results = this.Invoke("getUser", new object[] {
                        name});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void getUserAsync(string name) {
            this.getUserAsync(name, null);
        }
        
        /// <remarks/>
        public void getUserAsync(string name, object userState) {
            if ((this.getUserOperationCompleted == null)) {
                this.getUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUserOperationCompleted);
            }
            this.InvokeAsync("getUser", new object[] {
                        name}, this.getUserOperationCompleted, userState);
        }
        
        private void OngetUserOperationCompleted(object arg) {
            if ((this.getUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUserCompleted(this, new getUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/checkParkingPlace", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool checkParkingPlace(string parkingPlaceName) {
            object[] results = this.Invoke("checkParkingPlace", new object[] {
                        parkingPlaceName});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void checkParkingPlaceAsync(string parkingPlaceName) {
            this.checkParkingPlaceAsync(parkingPlaceName, null);
        }
        
        /// <remarks/>
        public void checkParkingPlaceAsync(string parkingPlaceName, object userState) {
            if ((this.checkParkingPlaceOperationCompleted == null)) {
                this.checkParkingPlaceOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckParkingPlaceOperationCompleted);
            }
            this.InvokeAsync("checkParkingPlace", new object[] {
                        parkingPlaceName}, this.checkParkingPlaceOperationCompleted, userState);
        }
        
        private void OncheckParkingPlaceOperationCompleted(object arg) {
            if ((this.checkParkingPlaceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkParkingPlaceCompleted(this, new checkParkingPlaceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/addUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void addUser(string userName, string firstName, string lastName, string email, string phoneNr, string password) {
            this.Invoke("addUser", new object[] {
                        userName,
                        firstName,
                        lastName,
                        email,
                        phoneNr,
                        password});
        }
        
        /// <remarks/>
        public void addUserAsync(string userName, string firstName, string lastName, string email, string phoneNr, string password) {
            this.addUserAsync(userName, firstName, lastName, email, phoneNr, password, null);
        }
        
        /// <remarks/>
        public void addUserAsync(string userName, string firstName, string lastName, string email, string phoneNr, string password, object userState) {
            if ((this.addUserOperationCompleted == null)) {
                this.addUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddUserOperationCompleted);
            }
            this.InvokeAsync("addUser", new object[] {
                        userName,
                        firstName,
                        lastName,
                        email,
                        phoneNr,
                        password}, this.addUserOperationCompleted, userState);
        }
        
        private void OnaddUserOperationCompleted(object arg) {
            if ((this.addUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/checkCityDB", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool checkCityDB(string name) {
            object[] results = this.Invoke("checkCityDB", new object[] {
                        name});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void checkCityDBAsync(string name) {
            this.checkCityDBAsync(name, null);
        }
        
        /// <remarks/>
        public void checkCityDBAsync(string name, object userState) {
            if ((this.checkCityDBOperationCompleted == null)) {
                this.checkCityDBOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckCityDBOperationCompleted);
            }
            this.InvokeAsync("checkCityDB", new object[] {
                        name}, this.checkCityDBOperationCompleted, userState);
        }
        
        private void OncheckCityDBOperationCompleted(object arg) {
            if ((this.checkCityDBCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkCityDBCompleted(this, new checkCityDBCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class City {
        
        private int idField;
        
        private string nameField;
        
        private int mapXField;
        
        private int mapYField;
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public int mapX {
            get {
                return this.mapXField;
            }
            set {
                this.mapXField = value;
            }
        }
        
        /// <remarks/>
        public int mapY {
            get {
                return this.mapYField;
            }
            set {
                this.mapYField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void getAllCitesCompletedEventHandler(object sender, getAllCitesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllCitesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllCitesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public City[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((City[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void getCityByIdCompletedEventHandler(object sender, getCityByIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getCityByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getCityByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void getRegionByCityIdCompletedEventHandler(object sender, getRegionByCityIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getRegionByCityIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getRegionByCityIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void checkUserNameCompletedEventHandler(object sender, checkUserNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkUserNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal checkUserNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void checkUserCompletedEventHandler(object sender, checkUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal checkUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void getUserCompletedEventHandler(object sender, getUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void checkParkingPlaceCompletedEventHandler(object sender, checkParkingPlaceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkParkingPlaceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal checkParkingPlaceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void addUserCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void checkCityDBCompletedEventHandler(object sender, checkCityDBCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkCityDBCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal checkCityDBCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591