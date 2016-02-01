﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Carubbi.ComponentClient.GSACaptchaBreakerServiceProxy {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CaptchaConfig", Namespace="http://schemas.datacontract.org/2004/07/Carubbi.CaptchaBreaker.DTOs")]
    [System.SerializableAttribute()]
    public partial class CaptchaConfig : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CaseSensitiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ExecutarCalculoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumeroDePalavrasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TamanhoMaximoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TamanhoMinimoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Carubbi.ComponentClient.GSACaptchaBreakerServiceProxy.TipoCaptcha TipoField;
        
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
        public bool CaseSensitive {
            get {
                return this.CaseSensitiveField;
            }
            set {
                if ((this.CaseSensitiveField.Equals(value) != true)) {
                    this.CaseSensitiveField = value;
                    this.RaisePropertyChanged("CaseSensitive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ExecutarCalculo {
            get {
                return this.ExecutarCalculoField;
            }
            set {
                if ((this.ExecutarCalculoField.Equals(value) != true)) {
                    this.ExecutarCalculoField = value;
                    this.RaisePropertyChanged("ExecutarCalculo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumeroDePalavras {
            get {
                return this.NumeroDePalavrasField;
            }
            set {
                if ((this.NumeroDePalavrasField.Equals(value) != true)) {
                    this.NumeroDePalavrasField = value;
                    this.RaisePropertyChanged("NumeroDePalavras");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TamanhoMaximo {
            get {
                return this.TamanhoMaximoField;
            }
            set {
                if ((this.TamanhoMaximoField.Equals(value) != true)) {
                    this.TamanhoMaximoField = value;
                    this.RaisePropertyChanged("TamanhoMaximo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TamanhoMinimo {
            get {
                return this.TamanhoMinimoField;
            }
            set {
                if ((this.TamanhoMinimoField.Equals(value) != true)) {
                    this.TamanhoMinimoField = value;
                    this.RaisePropertyChanged("TamanhoMinimo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Carubbi.ComponentClient.GSACaptchaBreakerServiceProxy.TipoCaptcha Tipo {
            get {
                return this.TipoField;
            }
            set {
                if ((this.TipoField.Equals(value) != true)) {
                    this.TipoField = value;
                    this.RaisePropertyChanged("Tipo");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TipoCaptcha", Namespace="http://schemas.datacontract.org/2004/07/Carubbi.CaptchaBreaker.DTOs")]
    public enum TipoCaptcha : byte {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ApenasLetras = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ApenasNumeros = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Alfanumerico = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GSACaptchaBreakerServiceProxy.ICaptchaBreaker")]
    public interface ICaptchaBreaker {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICaptchaBreaker/Break", ReplyAction="http://tempuri.org/ICaptchaBreaker/BreakResponse")]
        string Break(byte[] image, Carubbi.ComponentClient.GSACaptchaBreakerServiceProxy.CaptchaConfig config);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICaptchaBreaker/Break", ReplyAction="http://tempuri.org/ICaptchaBreaker/BreakResponse")]
        System.Threading.Tasks.Task<string> BreakAsync(byte[] image, Carubbi.ComponentClient.GSACaptchaBreakerServiceProxy.CaptchaConfig config);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICaptchaBreakerChannel : Carubbi.ComponentClient.GSACaptchaBreakerServiceProxy.ICaptchaBreaker, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CaptchaBreakerClient : System.ServiceModel.ClientBase<Carubbi.ComponentClient.GSACaptchaBreakerServiceProxy.ICaptchaBreaker>, Carubbi.ComponentClient.GSACaptchaBreakerServiceProxy.ICaptchaBreaker {
        
        public CaptchaBreakerClient() {
        }
        
        public CaptchaBreakerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CaptchaBreakerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CaptchaBreakerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CaptchaBreakerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Break(byte[] image, Carubbi.ComponentClient.GSACaptchaBreakerServiceProxy.CaptchaConfig config) {
            return base.Channel.Break(image, config);
        }
        
        public System.Threading.Tasks.Task<string> BreakAsync(byte[] image, Carubbi.ComponentClient.GSACaptchaBreakerServiceProxy.CaptchaConfig config) {
            return base.Channel.BreakAsync(image, config);
        }
    }
}
