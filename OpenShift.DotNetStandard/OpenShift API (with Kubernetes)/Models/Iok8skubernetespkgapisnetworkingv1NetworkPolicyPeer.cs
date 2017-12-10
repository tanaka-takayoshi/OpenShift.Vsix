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
    /// NetworkPolicyPeer describes a peer to allow traffic from. Exactly one
    /// of its fields must be specified.
    /// </summary>
    public partial class Iok8skubernetespkgapisnetworkingv1NetworkPolicyPeer
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisnetworkingv1NetworkPolicyPeer class.
        /// </summary>
        public Iok8skubernetespkgapisnetworkingv1NetworkPolicyPeer() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisnetworkingv1NetworkPolicyPeer class.
        /// </summary>
        public Iok8skubernetespkgapisnetworkingv1NetworkPolicyPeer(Iok8sapimachinerypkgapismetav1LabelSelector namespaceSelector = default(Iok8sapimachinerypkgapismetav1LabelSelector), Iok8sapimachinerypkgapismetav1LabelSelector podSelector = default(Iok8sapimachinerypkgapismetav1LabelSelector))
        {
            NamespaceSelector = namespaceSelector;
            PodSelector = podSelector;
        }

        /// <summary>
        /// Selects Namespaces using cluster scoped-labels. This matches all
        /// pods in all namespaces selected by this label selector. This
        /// field follows standard label selector semantics. If present but
        /// empty, this selector selects all namespaces.
        /// </summary>
        [JsonProperty(PropertyName = "namespaceSelector")]
        public Iok8sapimachinerypkgapismetav1LabelSelector NamespaceSelector { get; set; }

        /// <summary>
        /// This is a label selector which selects Pods in this namespace.
        /// This field follows standard label selector semantics. If present
        /// but empty, this selector selects all pods in this namespace.
        /// </summary>
        [JsonProperty(PropertyName = "podSelector")]
        public Iok8sapimachinerypkgapismetav1LabelSelector PodSelector { get; set; }

    }
}
