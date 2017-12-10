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

    public partial class Iok8skubernetespkgapisextensionsv1beta1NetworkPolicyPort
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisextensionsv1beta1NetworkPolicyPort class.
        /// </summary>
        public Iok8skubernetespkgapisextensionsv1beta1NetworkPolicyPort() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisextensionsv1beta1NetworkPolicyPort class.
        /// </summary>
        public Iok8skubernetespkgapisextensionsv1beta1NetworkPolicyPort(string port = default(string), string protocol = default(string))
        {
            Port = port;
            Protocol = protocol;
        }

        /// <summary>
        /// If specified, the port on the given protocol.  This can either be
        /// a numerical or named port on a pod.  If this field is not
        /// provided, this matches all port names and numbers. If present,
        /// only traffic on the specified protocol AND port will be matched.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public string Port { get; set; }

        /// <summary>
        /// Optional.  The protocol (TCP or UDP) which traffic must match. If
        /// not specified, this field defaults to TCP.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

    }
}
