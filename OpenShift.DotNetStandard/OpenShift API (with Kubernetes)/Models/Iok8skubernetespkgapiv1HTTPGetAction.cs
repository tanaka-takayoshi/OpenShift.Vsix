﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace OpenShift.DotNet.Service.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// HTTPGetAction describes an action based on HTTP Get requests.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1HTTPGetAction
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1HTTPGetAction class.
        /// </summary>
        public Iok8skubernetespkgapiv1HTTPGetAction() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1HTTPGetAction class.
        /// </summary>
        public Iok8skubernetespkgapiv1HTTPGetAction(string port, string host = default(string), IList<Iok8skubernetespkgapiv1HTTPHeader> httpHeaders = default(IList<Iok8skubernetespkgapiv1HTTPHeader>), string path = default(string), string scheme = default(string))
        {
            Host = host;
            HttpHeaders = httpHeaders;
            Path = path;
            Port = port;
            Scheme = scheme;
        }

        /// <summary>
        /// Host name to connect to, defaults to the pod IP. You probably want
        /// to set "Host" in httpHeaders instead.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }

        /// <summary>
        /// Custom headers to set in the request. HTTP allows repeated headers.
        /// </summary>
        [JsonProperty(PropertyName = "httpHeaders")]
        public IList<Iok8skubernetespkgapiv1HTTPHeader> HttpHeaders { get; set; }

        /// <summary>
        /// Path to access on the HTTP server.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Name or number of the port to access on the container. Number must
        /// be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public string Port { get; set; }

        /// <summary>
        /// Scheme to use for connecting to the host. Defaults to HTTP.
        /// </summary>
        [JsonProperty(PropertyName = "scheme")]
        public string Scheme { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Port == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Port");
            }
            if (this.HttpHeaders != null)
            {
                foreach (var element in this.HttpHeaders)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
