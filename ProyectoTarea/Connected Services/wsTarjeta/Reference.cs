﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoTarea.wsTarjeta {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseObtenerLLave", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ResponseObtenerLLave : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] IVField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public byte[] Key {
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public byte[] IV {
            get {
                return this.IVField;
            }
            set {
                if ((object.ReferenceEquals(this.IVField, value) != true)) {
                    this.IVField = value;
                    this.RaisePropertyChanged("IV");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsTarjeta.TarjetasSoap")]
    public interface TarjetasSoap {
        
        // CODEGEN: Generating message contract since element name NumeroTarjeta from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NumeroTarjetaValido", ReplyAction="*")]
        ProyectoTarea.wsTarjeta.NumeroTarjetaValidoResponse NumeroTarjetaValido(ProyectoTarea.wsTarjeta.NumeroTarjetaValidoRequest request);
        
        // CODEGEN: Generating message contract since element name ObtenerLlaveIVResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerLlaveIV", ReplyAction="*")]
        ProyectoTarea.wsTarjeta.ObtenerLlaveIVResponse ObtenerLlaveIV(ProyectoTarea.wsTarjeta.ObtenerLlaveIVRequest request);
        
        // CODEGEN: Generating message contract since element name NumeroTarjeta from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Hashing", ReplyAction="*")]
        ProyectoTarea.wsTarjeta.HashingResponse Hashing(ProyectoTarea.wsTarjeta.HashingRequest request);
        
        // CODEGEN: Generating message contract since element name Tarjeta from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EncriptarTarjeta", ReplyAction="*")]
        ProyectoTarea.wsTarjeta.EncriptarTarjetaResponse EncriptarTarjeta(ProyectoTarea.wsTarjeta.EncriptarTarjetaRequest request);
        
        // CODEGEN: Generating message contract since element name Tarjeta from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DesencriptarTarjeta", ReplyAction="*")]
        ProyectoTarea.wsTarjeta.DesencriptarTarjetaResponse DesencriptarTarjeta(ProyectoTarea.wsTarjeta.DesencriptarTarjetaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NumeroTarjetaValidoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NumeroTarjetaValido", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTarea.wsTarjeta.NumeroTarjetaValidoRequestBody Body;
        
        public NumeroTarjetaValidoRequest() {
        }
        
        public NumeroTarjetaValidoRequest(ProyectoTarea.wsTarjeta.NumeroTarjetaValidoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class NumeroTarjetaValidoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string NumeroTarjeta;
        
        public NumeroTarjetaValidoRequestBody() {
        }
        
        public NumeroTarjetaValidoRequestBody(string NumeroTarjeta) {
            this.NumeroTarjeta = NumeroTarjeta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NumeroTarjetaValidoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NumeroTarjetaValidoResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTarea.wsTarjeta.NumeroTarjetaValidoResponseBody Body;
        
        public NumeroTarjetaValidoResponse() {
        }
        
        public NumeroTarjetaValidoResponse(ProyectoTarea.wsTarjeta.NumeroTarjetaValidoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class NumeroTarjetaValidoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string NumeroTarjetaValidoResult;
        
        public NumeroTarjetaValidoResponseBody() {
        }
        
        public NumeroTarjetaValidoResponseBody(string NumeroTarjetaValidoResult) {
            this.NumeroTarjetaValidoResult = NumeroTarjetaValidoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerLlaveIVRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerLlaveIV", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTarea.wsTarjeta.ObtenerLlaveIVRequestBody Body;
        
        public ObtenerLlaveIVRequest() {
        }
        
        public ObtenerLlaveIVRequest(ProyectoTarea.wsTarjeta.ObtenerLlaveIVRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ObtenerLlaveIVRequestBody {
        
        public ObtenerLlaveIVRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerLlaveIVResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerLlaveIVResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTarea.wsTarjeta.ObtenerLlaveIVResponseBody Body;
        
        public ObtenerLlaveIVResponse() {
        }
        
        public ObtenerLlaveIVResponse(ProyectoTarea.wsTarjeta.ObtenerLlaveIVResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerLlaveIVResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoTarea.wsTarjeta.ResponseObtenerLLave ObtenerLlaveIVResult;
        
        public ObtenerLlaveIVResponseBody() {
        }
        
        public ObtenerLlaveIVResponseBody(ProyectoTarea.wsTarjeta.ResponseObtenerLLave ObtenerLlaveIVResult) {
            this.ObtenerLlaveIVResult = ObtenerLlaveIVResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HashingRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Hashing", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTarea.wsTarjeta.HashingRequestBody Body;
        
        public HashingRequest() {
        }
        
        public HashingRequest(ProyectoTarea.wsTarjeta.HashingRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HashingRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string NumeroTarjeta;
        
        public HashingRequestBody() {
        }
        
        public HashingRequestBody(string NumeroTarjeta) {
            this.NumeroTarjeta = NumeroTarjeta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HashingResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HashingResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTarea.wsTarjeta.HashingResponseBody Body;
        
        public HashingResponse() {
        }
        
        public HashingResponse(ProyectoTarea.wsTarjeta.HashingResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HashingResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] HashingResult;
        
        public HashingResponseBody() {
        }
        
        public HashingResponseBody(byte[] HashingResult) {
            this.HashingResult = HashingResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EncriptarTarjetaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EncriptarTarjeta", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTarea.wsTarjeta.EncriptarTarjetaRequestBody Body;
        
        public EncriptarTarjetaRequest() {
        }
        
        public EncriptarTarjetaRequest(ProyectoTarea.wsTarjeta.EncriptarTarjetaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EncriptarTarjetaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Tarjeta;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public byte[] llave;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public byte[] IV;
        
        public EncriptarTarjetaRequestBody() {
        }
        
        public EncriptarTarjetaRequestBody(string Tarjeta, byte[] llave, byte[] IV) {
            this.Tarjeta = Tarjeta;
            this.llave = llave;
            this.IV = IV;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EncriptarTarjetaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EncriptarTarjetaResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTarea.wsTarjeta.EncriptarTarjetaResponseBody Body;
        
        public EncriptarTarjetaResponse() {
        }
        
        public EncriptarTarjetaResponse(ProyectoTarea.wsTarjeta.EncriptarTarjetaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EncriptarTarjetaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] EncriptarTarjetaResult;
        
        public EncriptarTarjetaResponseBody() {
        }
        
        public EncriptarTarjetaResponseBody(byte[] EncriptarTarjetaResult) {
            this.EncriptarTarjetaResult = EncriptarTarjetaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DesencriptarTarjetaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DesencriptarTarjeta", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTarea.wsTarjeta.DesencriptarTarjetaRequestBody Body;
        
        public DesencriptarTarjetaRequest() {
        }
        
        public DesencriptarTarjetaRequest(ProyectoTarea.wsTarjeta.DesencriptarTarjetaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DesencriptarTarjetaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] Tarjeta;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public byte[] llave;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public byte[] IV;
        
        public DesencriptarTarjetaRequestBody() {
        }
        
        public DesencriptarTarjetaRequestBody(byte[] Tarjeta, byte[] llave, byte[] IV) {
            this.Tarjeta = Tarjeta;
            this.llave = llave;
            this.IV = IV;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DesencriptarTarjetaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DesencriptarTarjetaResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoTarea.wsTarjeta.DesencriptarTarjetaResponseBody Body;
        
        public DesencriptarTarjetaResponse() {
        }
        
        public DesencriptarTarjetaResponse(ProyectoTarea.wsTarjeta.DesencriptarTarjetaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DesencriptarTarjetaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string DesencriptarTarjetaResult;
        
        public DesencriptarTarjetaResponseBody() {
        }
        
        public DesencriptarTarjetaResponseBody(string DesencriptarTarjetaResult) {
            this.DesencriptarTarjetaResult = DesencriptarTarjetaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TarjetasSoapChannel : ProyectoTarea.wsTarjeta.TarjetasSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TarjetasSoapClient : System.ServiceModel.ClientBase<ProyectoTarea.wsTarjeta.TarjetasSoap>, ProyectoTarea.wsTarjeta.TarjetasSoap {
        
        public TarjetasSoapClient() {
        }
        
        public TarjetasSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TarjetasSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TarjetasSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TarjetasSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTarea.wsTarjeta.NumeroTarjetaValidoResponse ProyectoTarea.wsTarjeta.TarjetasSoap.NumeroTarjetaValido(ProyectoTarea.wsTarjeta.NumeroTarjetaValidoRequest request) {
            return base.Channel.NumeroTarjetaValido(request);
        }
        
        public string NumeroTarjetaValido(string NumeroTarjeta) {
            ProyectoTarea.wsTarjeta.NumeroTarjetaValidoRequest inValue = new ProyectoTarea.wsTarjeta.NumeroTarjetaValidoRequest();
            inValue.Body = new ProyectoTarea.wsTarjeta.NumeroTarjetaValidoRequestBody();
            inValue.Body.NumeroTarjeta = NumeroTarjeta;
            ProyectoTarea.wsTarjeta.NumeroTarjetaValidoResponse retVal = ((ProyectoTarea.wsTarjeta.TarjetasSoap)(this)).NumeroTarjetaValido(inValue);
            return retVal.Body.NumeroTarjetaValidoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTarea.wsTarjeta.ObtenerLlaveIVResponse ProyectoTarea.wsTarjeta.TarjetasSoap.ObtenerLlaveIV(ProyectoTarea.wsTarjeta.ObtenerLlaveIVRequest request) {
            return base.Channel.ObtenerLlaveIV(request);
        }
        
        public ProyectoTarea.wsTarjeta.ResponseObtenerLLave ObtenerLlaveIV() {
            ProyectoTarea.wsTarjeta.ObtenerLlaveIVRequest inValue = new ProyectoTarea.wsTarjeta.ObtenerLlaveIVRequest();
            inValue.Body = new ProyectoTarea.wsTarjeta.ObtenerLlaveIVRequestBody();
            ProyectoTarea.wsTarjeta.ObtenerLlaveIVResponse retVal = ((ProyectoTarea.wsTarjeta.TarjetasSoap)(this)).ObtenerLlaveIV(inValue);
            return retVal.Body.ObtenerLlaveIVResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTarea.wsTarjeta.HashingResponse ProyectoTarea.wsTarjeta.TarjetasSoap.Hashing(ProyectoTarea.wsTarjeta.HashingRequest request) {
            return base.Channel.Hashing(request);
        }
        
        public byte[] Hashing(string NumeroTarjeta) {
            ProyectoTarea.wsTarjeta.HashingRequest inValue = new ProyectoTarea.wsTarjeta.HashingRequest();
            inValue.Body = new ProyectoTarea.wsTarjeta.HashingRequestBody();
            inValue.Body.NumeroTarjeta = NumeroTarjeta;
            ProyectoTarea.wsTarjeta.HashingResponse retVal = ((ProyectoTarea.wsTarjeta.TarjetasSoap)(this)).Hashing(inValue);
            return retVal.Body.HashingResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTarea.wsTarjeta.EncriptarTarjetaResponse ProyectoTarea.wsTarjeta.TarjetasSoap.EncriptarTarjeta(ProyectoTarea.wsTarjeta.EncriptarTarjetaRequest request) {
            return base.Channel.EncriptarTarjeta(request);
        }
        
        public byte[] EncriptarTarjeta(string Tarjeta, byte[] llave, byte[] IV) {
            ProyectoTarea.wsTarjeta.EncriptarTarjetaRequest inValue = new ProyectoTarea.wsTarjeta.EncriptarTarjetaRequest();
            inValue.Body = new ProyectoTarea.wsTarjeta.EncriptarTarjetaRequestBody();
            inValue.Body.Tarjeta = Tarjeta;
            inValue.Body.llave = llave;
            inValue.Body.IV = IV;
            ProyectoTarea.wsTarjeta.EncriptarTarjetaResponse retVal = ((ProyectoTarea.wsTarjeta.TarjetasSoap)(this)).EncriptarTarjeta(inValue);
            return retVal.Body.EncriptarTarjetaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoTarea.wsTarjeta.DesencriptarTarjetaResponse ProyectoTarea.wsTarjeta.TarjetasSoap.DesencriptarTarjeta(ProyectoTarea.wsTarjeta.DesencriptarTarjetaRequest request) {
            return base.Channel.DesencriptarTarjeta(request);
        }
        
        public string DesencriptarTarjeta(byte[] Tarjeta, byte[] llave, byte[] IV) {
            ProyectoTarea.wsTarjeta.DesencriptarTarjetaRequest inValue = new ProyectoTarea.wsTarjeta.DesencriptarTarjetaRequest();
            inValue.Body = new ProyectoTarea.wsTarjeta.DesencriptarTarjetaRequestBody();
            inValue.Body.Tarjeta = Tarjeta;
            inValue.Body.llave = llave;
            inValue.Body.IV = IV;
            ProyectoTarea.wsTarjeta.DesencriptarTarjetaResponse retVal = ((ProyectoTarea.wsTarjeta.TarjetasSoap)(this)).DesencriptarTarjeta(inValue);
            return retVal.Body.DesencriptarTarjetaResult;
        }
    }
}
