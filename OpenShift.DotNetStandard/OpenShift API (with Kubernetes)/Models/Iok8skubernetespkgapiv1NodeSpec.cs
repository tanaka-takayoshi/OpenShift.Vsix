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
    /// NodeSpec describes the attributes that a node is created with.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1NodeSpec
    {
        /// <summary>
        /// Initializes a new instance of the Iok8skubernetespkgapiv1NodeSpec
        /// class.
        /// </summary>
        public Iok8skubernetespkgapiv1NodeSpec() { }

        /// <summary>
        /// Initializes a new instance of the Iok8skubernetespkgapiv1NodeSpec
        /// class.
        /// </summary>
        public Iok8skubernetespkgapiv1NodeSpec(string externalID = default(string), string podCIDR = default(string), string providerID = default(string), IList<Iok8skubernetespkgapiv1Taint> taints = default(IList<Iok8skubernetespkgapiv1Taint>), bool? unschedulable = default(bool?))
        {
            ExternalID = externalID;
            PodCIDR = podCIDR;
            ProviderID = providerID;
            Taints = taints;
            Unschedulable = unschedulable;
        }

        /// <summary>
        /// External ID of the node assigned by some machine database (e.g. a
        /// cloud provider). Deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "externalID")]
        public string ExternalID { get; set; }

        /// <summary>
        /// PodCIDR represents the pod IP range assigned to the node.
        /// </summary>
        [JsonProperty(PropertyName = "podCIDR")]
        public string PodCIDR { get; set; }

        /// <summary>
        /// ID of the node assigned by the cloud provider in the format:
        /// &lt;ProviderName&gt;://&lt;ProviderSpecificNodeID&gt;
        /// </summary>
        [JsonProperty(PropertyName = "providerID")]
        public string ProviderID { get; set; }

        /// <summary>
        /// If specified, the node's taints.
        /// </summary>
        [JsonProperty(PropertyName = "taints")]
        public IList<Iok8skubernetespkgapiv1Taint> Taints { get; set; }

        /// <summary>
        /// Unschedulable controls node schedulability of new pods. By
        /// default, node is schedulable. More info:
        /// https://kubernetes.io/docs/concepts/nodes/node/#manual-node-administration
        /// </summary>
        [JsonProperty(PropertyName = "unschedulable")]
        public bool? Unschedulable { get; set; }

    }
}
