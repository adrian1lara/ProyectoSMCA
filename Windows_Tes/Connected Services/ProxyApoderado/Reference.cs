﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProxyApoderado
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ApoderadoDC", Namespace="http://schemas.datacontract.org/2004/07/WCF_ESCUELA")]
    public partial class ApoderadoDC : object
    {
        
        private string APE_APOField;
        
        private string ApellNom_APOField;
        
        private string CORREO_APOField;
        
        private int DNI_APOField;
        
        private string DepartamentoField;
        
        private string DistritoField;
        
        private short EstadoField;
        
        private byte[] FOTO_APOField;
        
        private System.DateTime Fec_RegistroField;
        
        private System.DateTime Fec_Ult_ModField;
        
        private int ID_UBIGEOField;
        
        private string NOM_APOField;
        
        private string ProvinciaField;
        
        private string SEXO_APOField;
        
        private string TEL_APOField;
        
        private string Usu_RegistroField;
        
        private string Usu_Ult_ModField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string APE_APO
        {
            get
            {
                return this.APE_APOField;
            }
            set
            {
                this.APE_APOField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellNom_APO
        {
            get
            {
                return this.ApellNom_APOField;
            }
            set
            {
                this.ApellNom_APOField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CORREO_APO
        {
            get
            {
                return this.CORREO_APOField;
            }
            set
            {
                this.CORREO_APOField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DNI_APO
        {
            get
            {
                return this.DNI_APOField;
            }
            set
            {
                this.DNI_APOField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Departamento
        {
            get
            {
                return this.DepartamentoField;
            }
            set
            {
                this.DepartamentoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Distrito
        {
            get
            {
                return this.DistritoField;
            }
            set
            {
                this.DistritoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Estado
        {
            get
            {
                return this.EstadoField;
            }
            set
            {
                this.EstadoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] FOTO_APO
        {
            get
            {
                return this.FOTO_APOField;
            }
            set
            {
                this.FOTO_APOField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fec_Registro
        {
            get
            {
                return this.Fec_RegistroField;
            }
            set
            {
                this.Fec_RegistroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fec_Ult_Mod
        {
            get
            {
                return this.Fec_Ult_ModField;
            }
            set
            {
                this.Fec_Ult_ModField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_UBIGEO
        {
            get
            {
                return this.ID_UBIGEOField;
            }
            set
            {
                this.ID_UBIGEOField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NOM_APO
        {
            get
            {
                return this.NOM_APOField;
            }
            set
            {
                this.NOM_APOField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Provincia
        {
            get
            {
                return this.ProvinciaField;
            }
            set
            {
                this.ProvinciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SEXO_APO
        {
            get
            {
                return this.SEXO_APOField;
            }
            set
            {
                this.SEXO_APOField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TEL_APO
        {
            get
            {
                return this.TEL_APOField;
            }
            set
            {
                this.TEL_APOField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usu_Registro
        {
            get
            {
                return this.Usu_RegistroField;
            }
            set
            {
                this.Usu_RegistroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usu_Ult_Mod
        {
            get
            {
                return this.Usu_Ult_ModField;
            }
            set
            {
                this.Usu_Ult_ModField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyApoderado.IServicioApoderado")]
    public interface IServicioApoderado
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioApoderado/ListarApoderado", ReplyAction="http://tempuri.org/IServicioApoderado/ListarApoderadoResponse")]
        System.Collections.Generic.List<ProxyApoderado.ApoderadoDC> ListarApoderado();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioApoderado/ListarApoderado", ReplyAction="http://tempuri.org/IServicioApoderado/ListarApoderadoResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ProxyApoderado.ApoderadoDC>> ListarApoderadoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface IServicioApoderadoChannel : ProxyApoderado.IServicioApoderado, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class ServicioApoderadoClient : System.ServiceModel.ClientBase<ProxyApoderado.IServicioApoderado>, ProxyApoderado.IServicioApoderado
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServicioApoderadoClient() : 
                base(ServicioApoderadoClient.GetDefaultBinding(), ServicioApoderadoClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IServicioApoderado.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioApoderadoClient(EndpointConfiguration endpointConfiguration) : 
                base(ServicioApoderadoClient.GetBindingForEndpoint(endpointConfiguration), ServicioApoderadoClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioApoderadoClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServicioApoderadoClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioApoderadoClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServicioApoderadoClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioApoderadoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Collections.Generic.List<ProxyApoderado.ApoderadoDC> ListarApoderado()
        {
            return base.Channel.ListarApoderado();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ProxyApoderado.ApoderadoDC>> ListarApoderadoAsync()
        {
            return base.Channel.ListarApoderadoAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServicioApoderado))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServicioApoderado))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/WCF_ESCUELA/ServicioApoderado/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServicioApoderadoClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IServicioApoderado);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServicioApoderadoClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IServicioApoderado);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IServicioApoderado,
        }
    }
}