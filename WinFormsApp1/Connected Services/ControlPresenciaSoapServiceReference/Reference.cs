﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlPresenciaSoapServiceReference
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.example.org/ControlPresencia/", ConfigurationName="ControlPresenciaSoapServiceReference.ControlPresencia")]
    public interface ControlPresencia
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.example.org/ControlPresencia/registrar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ControlPresenciaSoapServiceReference.registrarResponse> registrarAsync(ControlPresenciaSoapServiceReference.registrarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.example.org/ControlPresencia/eliminar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ControlPresenciaSoapServiceReference.eliminarResponse> eliminarAsync(ControlPresenciaSoapServiceReference.eliminarRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores devueltos.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.example.org/ControlPresencia/controlEmpleadoSala", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ControlPresenciaSoapServiceReference.controlEmpleadoSalaResponse> controlEmpleadoSalaAsync(ControlPresenciaSoapServiceReference.controlEmpleadoSalaRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.example.org/ControlPresencia/")]
    public partial class ControlPresenciaOperationType : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        private string nifnieField;
        
        private int codigoSalaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string nifnie
        {
            get
            {
                return this.nifnieField;
            }
            set
            {
                this.nifnieField = value;
                this.RaisePropertyChanged("nifnie");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int codigoSala
        {
            get
            {
                return this.codigoSalaField;
            }
            set
            {
                this.codigoSalaField = value;
                this.RaisePropertyChanged("codigoSala");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.example.org/ControlPresencia/")]
    public partial class EmpleadosType : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        private string nifnieField;
        
        private string nombreApellidosField;
        
        private string emailField;
        
        private string nafField;
        
        private string ibanField;
        
        private int idNivelField;
        
        private string usuarioField;
        
        private string passwordField;
        
        private int validoField;
        
        private int idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string nifnie
        {
            get
            {
                return this.nifnieField;
            }
            set
            {
                this.nifnieField = value;
                this.RaisePropertyChanged("nifnie");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string nombreApellidos
        {
            get
            {
                return this.nombreApellidosField;
            }
            set
            {
                this.nombreApellidosField = value;
                this.RaisePropertyChanged("nombreApellidos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
                this.RaisePropertyChanged("email");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string naf
        {
            get
            {
                return this.nafField;
            }
            set
            {
                this.nafField = value;
                this.RaisePropertyChanged("naf");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string iban
        {
            get
            {
                return this.ibanField;
            }
            set
            {
                this.ibanField = value;
                this.RaisePropertyChanged("iban");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int idNivel
        {
            get
            {
                return this.idNivelField;
            }
            set
            {
                this.idNivelField = value;
                this.RaisePropertyChanged("idNivel");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string usuario
        {
            get
            {
                return this.usuarioField;
            }
            set
            {
                this.usuarioField = value;
                this.RaisePropertyChanged("usuario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public int valido
        {
            get
            {
                return this.validoField;
            }
            set
            {
                this.validoField = value;
                this.RaisePropertyChanged("valido");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="registrar", WrapperNamespace="http://www.example.org/ControlPresencia/", IsWrapped=true)]
    public partial class registrarRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.example.org/ControlPresencia/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ControlPresenciaSoapServiceReference.ControlPresenciaOperationType @in;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.example.org/ControlPresencia/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WSKey;
        
        public registrarRequest()
        {
        }
        
        public registrarRequest(ControlPresenciaSoapServiceReference.ControlPresenciaOperationType @in, string WSKey)
        {
            this.@in = @in;
            this.WSKey = WSKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="registrarResponse", WrapperNamespace="http://www.example.org/ControlPresencia/", IsWrapped=true)]
    public partial class registrarResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.example.org/ControlPresencia/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string mensajeSalida;
        
        public registrarResponse()
        {
        }
        
        public registrarResponse(string mensajeSalida)
        {
            this.mensajeSalida = mensajeSalida;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminar", WrapperNamespace="http://www.example.org/ControlPresencia/", IsWrapped=true)]
    public partial class eliminarRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.example.org/ControlPresencia/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ControlPresenciaSoapServiceReference.ControlPresenciaOperationType @in;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.example.org/ControlPresencia/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WSKey;
        
        public eliminarRequest()
        {
        }
        
        public eliminarRequest(ControlPresenciaSoapServiceReference.ControlPresenciaOperationType @in, string WSKey)
        {
            this.@in = @in;
            this.WSKey = WSKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarResponse", WrapperNamespace="http://www.example.org/ControlPresencia/", IsWrapped=true)]
    public partial class eliminarResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.example.org/ControlPresencia/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string mensajeSalida;
        
        public eliminarResponse()
        {
        }
        
        public eliminarResponse(string mensajeSalida)
        {
            this.mensajeSalida = mensajeSalida;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="controlEmpleadoSala", WrapperNamespace="http://www.example.org/ControlPresencia/", IsWrapped=true)]
    public partial class controlEmpleadoSalaRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.example.org/ControlPresencia/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int codigoSala;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.example.org/ControlPresencia/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WSKey;
        
        public controlEmpleadoSalaRequest()
        {
        }
        
        public controlEmpleadoSalaRequest(int codigoSala, string WSKey)
        {
            this.codigoSala = codigoSala;
            this.WSKey = WSKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="controlEmpleadoSalaResponse", WrapperNamespace="http://www.example.org/ControlPresencia/", IsWrapped=true)]
    public partial class controlEmpleadoSalaResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.example.org/ControlPresencia/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("empleadosOut", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ControlPresenciaSoapServiceReference.EmpleadosType[] empleadosOut;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.example.org/ControlPresencia/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string mensajeSalida;
        
        public controlEmpleadoSalaResponse()
        {
        }
        
        public controlEmpleadoSalaResponse(ControlPresenciaSoapServiceReference.EmpleadosType[] empleadosOut, string mensajeSalida)
        {
            this.empleadosOut = empleadosOut;
            this.mensajeSalida = mensajeSalida;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface ControlPresenciaChannel : ControlPresenciaSoapServiceReference.ControlPresencia, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class ControlPresenciaClient : System.ServiceModel.ClientBase<ControlPresenciaSoapServiceReference.ControlPresencia>, ControlPresenciaSoapServiceReference.ControlPresencia
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ControlPresenciaClient() : 
                base(ControlPresenciaClient.GetDefaultBinding(), ControlPresenciaClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.ControlPresenciaSOAP.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ControlPresenciaClient(EndpointConfiguration endpointConfiguration) : 
                base(ControlPresenciaClient.GetBindingForEndpoint(endpointConfiguration), ControlPresenciaClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ControlPresenciaClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ControlPresenciaClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ControlPresenciaClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ControlPresenciaClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ControlPresenciaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ControlPresenciaSoapServiceReference.registrarResponse> ControlPresenciaSoapServiceReference.ControlPresencia.registrarAsync(ControlPresenciaSoapServiceReference.registrarRequest request)
        {
            return base.Channel.registrarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ControlPresenciaSoapServiceReference.registrarResponse> registrarAsync(ControlPresenciaSoapServiceReference.ControlPresenciaOperationType @in, string WSKey)
        {
            ControlPresenciaSoapServiceReference.registrarRequest inValue = new ControlPresenciaSoapServiceReference.registrarRequest();
            inValue.@in = @in;
            inValue.WSKey = WSKey;
            return ((ControlPresenciaSoapServiceReference.ControlPresencia)(this)).registrarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ControlPresenciaSoapServiceReference.eliminarResponse> ControlPresenciaSoapServiceReference.ControlPresencia.eliminarAsync(ControlPresenciaSoapServiceReference.eliminarRequest request)
        {
            return base.Channel.eliminarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ControlPresenciaSoapServiceReference.eliminarResponse> eliminarAsync(ControlPresenciaSoapServiceReference.ControlPresenciaOperationType @in, string WSKey)
        {
            ControlPresenciaSoapServiceReference.eliminarRequest inValue = new ControlPresenciaSoapServiceReference.eliminarRequest();
            inValue.@in = @in;
            inValue.WSKey = WSKey;
            return ((ControlPresenciaSoapServiceReference.ControlPresencia)(this)).eliminarAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<ControlPresenciaSoapServiceReference.controlEmpleadoSalaResponse> controlEmpleadoSalaAsync(ControlPresenciaSoapServiceReference.controlEmpleadoSalaRequest request)
        {
            return base.Channel.controlEmpleadoSalaAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ControlPresenciaSOAP))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ControlPresenciaSOAP))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8080/Prac1-prueba-v2/services/ControlPresencia/");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ControlPresenciaClient.GetBindingForEndpoint(EndpointConfiguration.ControlPresenciaSOAP);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ControlPresenciaClient.GetEndpointAddress(EndpointConfiguration.ControlPresenciaSOAP);
        }
        
        public enum EndpointConfiguration
        {
            
            ControlPresenciaSOAP,
        }
    }
}
