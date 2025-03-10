﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.example.org/ControlAccesos/", ConfigurationName="ServiceReference1.ControlAccesos")]
    public interface ControlAccesos
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.example.org/ControlAccesos/registrar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.registrarResponse> registrarAsync(ServiceReference1.registrarRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores devueltos.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.example.org/ControlAccesos/consultar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference1.consultarResponse> consultarAsync(ServiceReference1.consultarRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.example.org/ControlAccesos/")]
    public partial class RegistroAccesosType : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        private string nifnieField;
        
        private int codigoSalaField;
        
        private int codigoDispositivoField;
        
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int codigoDispositivo
        {
            get
            {
                return this.codigoDispositivoField;
            }
            set
            {
                this.codigoDispositivoField = value;
                this.RaisePropertyChanged("codigoDispositivo");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.example.org/ControlAccesos/")]
    public partial class InstanciaRegistroAccesosType : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        private int idField;
        
        private int idEmpleadoField;
        
        private int idSalaField;
        
        private int idDispositivoField;
        
        private System.DateTime fechaHoraField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int idEmpleado
        {
            get
            {
                return this.idEmpleadoField;
            }
            set
            {
                this.idEmpleadoField = value;
                this.RaisePropertyChanged("idEmpleado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int idSala
        {
            get
            {
                return this.idSalaField;
            }
            set
            {
                this.idSalaField = value;
                this.RaisePropertyChanged("idSala");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int idDispositivo
        {
            get
            {
                return this.idDispositivoField;
            }
            set
            {
                this.idDispositivoField = value;
                this.RaisePropertyChanged("idDispositivo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public System.DateTime fechaHora
        {
            get
            {
                return this.fechaHoraField;
            }
            set
            {
                this.fechaHoraField = value;
                this.RaisePropertyChanged("fechaHora");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.example.org/ControlAccesos/")]
    public partial class FechasRegistroAccesosType : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        private string nifnieField;
        
        private int codigoSalaField;
        
        private int codigoDispositivoField;
        
        private System.DateTime fechaDesdeField;
        
        private System.DateTime fechaHastaField;
        
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int codigoDispositivo
        {
            get
            {
                return this.codigoDispositivoField;
            }
            set
            {
                this.codigoDispositivoField = value;
                this.RaisePropertyChanged("codigoDispositivo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public System.DateTime fechaDesde
        {
            get
            {
                return this.fechaDesdeField;
            }
            set
            {
                this.fechaDesdeField = value;
                this.RaisePropertyChanged("fechaDesde");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public System.DateTime fechaHasta
        {
            get
            {
                return this.fechaHastaField;
            }
            set
            {
                this.fechaHastaField = value;
                this.RaisePropertyChanged("fechaHasta");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="registrar", WrapperNamespace="http://www.example.org/ControlAccesos/", IsWrapped=true)]
    public partial class registrarRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.example.org/ControlAccesos/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference1.RegistroAccesosType @in;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.example.org/ControlAccesos/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WSKey;
        
        public registrarRequest()
        {
        }
        
        public registrarRequest(ServiceReference1.RegistroAccesosType @in, string WSKey)
        {
            this.@in = @in;
            this.WSKey = WSKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="registrarResponse", WrapperNamespace="http://www.example.org/ControlAccesos/", IsWrapped=true)]
    public partial class registrarResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.example.org/ControlAccesos/", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="consultar", WrapperNamespace="http://www.example.org/ControlAccesos/", IsWrapped=true)]
    public partial class consultarRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.example.org/ControlAccesos/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference1.FechasRegistroAccesosType @in;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.example.org/ControlAccesos/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WSKey;
        
        public consultarRequest()
        {
        }
        
        public consultarRequest(ServiceReference1.FechasRegistroAccesosType @in, string WSKey)
        {
            this.@in = @in;
            this.WSKey = WSKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="consultarResponse", WrapperNamespace="http://www.example.org/ControlAccesos/", IsWrapped=true)]
    public partial class consultarResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.example.org/ControlAccesos/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("out", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference1.InstanciaRegistroAccesosType[] @out;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.example.org/ControlAccesos/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string mensajeSalida;
        
        public consultarResponse()
        {
        }
        
        public consultarResponse(ServiceReference1.InstanciaRegistroAccesosType[] @out, string mensajeSalida)
        {
            this.@out = @out;
            this.mensajeSalida = mensajeSalida;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface ControlAccesosChannel : ServiceReference1.ControlAccesos, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class ControlAccesosClient : System.ServiceModel.ClientBase<ServiceReference1.ControlAccesos>, ServiceReference1.ControlAccesos
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ControlAccesosClient() : 
                base(ControlAccesosClient.GetDefaultBinding(), ControlAccesosClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.ControlAccesosSOAP.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ControlAccesosClient(EndpointConfiguration endpointConfiguration) : 
                base(ControlAccesosClient.GetBindingForEndpoint(endpointConfiguration), ControlAccesosClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ControlAccesosClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ControlAccesosClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ControlAccesosClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ControlAccesosClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ControlAccesosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.registrarResponse> ServiceReference1.ControlAccesos.registrarAsync(ServiceReference1.registrarRequest request)
        {
            return base.Channel.registrarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.registrarResponse> registrarAsync(ServiceReference1.RegistroAccesosType @in, string WSKey)
        {
            ServiceReference1.registrarRequest inValue = new ServiceReference1.registrarRequest();
            inValue.@in = @in;
            inValue.WSKey = WSKey;
            return ((ServiceReference1.ControlAccesos)(this)).registrarAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.consultarResponse> consultarAsync(ServiceReference1.consultarRequest request)
        {
            return base.Channel.consultarAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ControlAccesosSOAP))
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
            if ((endpointConfiguration == EndpointConfiguration.ControlAccesosSOAP))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8080/Prac1-prueba-v2/services/ControlAccesos/");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ControlAccesosClient.GetBindingForEndpoint(EndpointConfiguration.ControlAccesosSOAP);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ControlAccesosClient.GetEndpointAddress(EndpointConfiguration.ControlAccesosSOAP);
        }
        
        public enum EndpointConfiguration
        {
            
            ControlAccesosSOAP,
        }
    }
}
