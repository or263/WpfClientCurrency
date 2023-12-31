﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfClientCurrency.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="CurrencyList", Namespace="http://schemas.datacontract.org/2004/07/CurrencyModel", ItemName="Currency")]
    [System.SerializableAttribute()]
    public class CurrencyList : System.Collections.Generic.List<WpfClientCurrency.ServiceReference1.Currency> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Currency", Namespace="http://schemas.datacontract.org/2004/07/CurrencyModel")]
    [System.SerializableAttribute()]
    public partial class Currency : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ChangeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double RateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UnitField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Change {
            get {
                return this.ChangeField;
            }
            set {
                if ((this.ChangeField.Equals(value) != true)) {
                    this.ChangeField = value;
                    this.RaisePropertyChanged("Change");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Rate {
            get {
                return this.RateField;
            }
            set {
                if ((this.RateField.Equals(value) != true)) {
                    this.RateField = value;
                    this.RaisePropertyChanged("Rate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Unit {
            get {
                return this.UnitField;
            }
            set {
                if ((this.UnitField.Equals(value) != true)) {
                    this.UnitField = value;
                    this.RaisePropertyChanged("Unit");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICurrencyService")]
    public interface ICurrencyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyService/GetAllCurrencies", ReplyAction="http://tempuri.org/ICurrencyService/GetAllCurrenciesResponse")]
        WpfClientCurrency.ServiceReference1.CurrencyList GetAllCurrencies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyService/GetAllCurrencies", ReplyAction="http://tempuri.org/ICurrencyService/GetAllCurrenciesResponse")]
        System.Threading.Tasks.Task<WpfClientCurrency.ServiceReference1.CurrencyList> GetAllCurrenciesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyService/Convert", ReplyAction="http://tempuri.org/ICurrencyService/ConvertResponse")]
        double Convert(WpfClientCurrency.ServiceReference1.Currency source, WpfClientCurrency.ServiceReference1.Currency target, double amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyService/Convert", ReplyAction="http://tempuri.org/ICurrencyService/ConvertResponse")]
        System.Threading.Tasks.Task<double> ConvertAsync(WpfClientCurrency.ServiceReference1.Currency source, WpfClientCurrency.ServiceReference1.Currency target, double amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICurrencyServiceChannel : WpfClientCurrency.ServiceReference1.ICurrencyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CurrencyServiceClient : System.ServiceModel.ClientBase<WpfClientCurrency.ServiceReference1.ICurrencyService>, WpfClientCurrency.ServiceReference1.ICurrencyService {
        
        public CurrencyServiceClient() {
        }
        
        public CurrencyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CurrencyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CurrencyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CurrencyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WpfClientCurrency.ServiceReference1.CurrencyList GetAllCurrencies() {
            return base.Channel.GetAllCurrencies();
        }
        
        public System.Threading.Tasks.Task<WpfClientCurrency.ServiceReference1.CurrencyList> GetAllCurrenciesAsync() {
            return base.Channel.GetAllCurrenciesAsync();
        }
        
        public double Convert(WpfClientCurrency.ServiceReference1.Currency source, WpfClientCurrency.ServiceReference1.Currency target, double amount) {
            return base.Channel.Convert(source, target, amount);
        }
        
        public System.Threading.Tasks.Task<double> ConvertAsync(WpfClientCurrency.ServiceReference1.Currency source, WpfClientCurrency.ServiceReference1.Currency target, double amount) {
            return base.Channel.ConvertAsync(source, target, amount);
        }
    }
}
