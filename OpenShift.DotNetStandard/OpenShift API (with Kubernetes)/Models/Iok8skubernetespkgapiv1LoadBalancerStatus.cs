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
    /// LoadBalancerStatus represents the status of a load-balancer.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1LoadBalancerStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1LoadBalancerStatus class.
        /// </summary>
        public Iok8skubernetespkgapiv1LoadBalancerStatus() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1LoadBalancerStatus class.
        /// </summary>
        public Iok8skubernetespkgapiv1LoadBalancerStatus(IList<Iok8skubernetespkgapiv1LoadBalancerIngress> ingress = default(IList<Iok8skubernetespkgapiv1LoadBalancerIngress>))
        {
            Ingress = ingress;
        }

        /// <summary>
        /// Ingress is a list containing ingress points for the load-balancer.
        /// Traffic intended for the service should be sent to these ingress
        /// points.
        /// </summary>
        [JsonProperty(PropertyName = "ingress")]
        public IList<Iok8skubernetespkgapiv1LoadBalancerIngress> Ingress { get; set; }

    }
}