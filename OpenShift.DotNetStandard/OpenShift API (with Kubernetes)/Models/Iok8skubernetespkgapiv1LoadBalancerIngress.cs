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
    /// LoadBalancerIngress represents the status of a load-balancer ingress
    /// point: traffic intended for the service should be sent to an ingress
    /// point.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1LoadBalancerIngress
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1LoadBalancerIngress class.
        /// </summary>
        public Iok8skubernetespkgapiv1LoadBalancerIngress() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1LoadBalancerIngress class.
        /// </summary>
        public Iok8skubernetespkgapiv1LoadBalancerIngress(string hostname = default(string), string ip = default(string))
        {
            Hostname = hostname;
            Ip = ip;
        }

        /// <summary>
        /// Hostname is set for load-balancer ingress points that are DNS
        /// based (typically AWS load-balancers)
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// IP is set for load-balancer ingress points that are IP based
        /// (typically GCE or OpenStack load-balancers)
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string Ip { get; set; }

    }
}
