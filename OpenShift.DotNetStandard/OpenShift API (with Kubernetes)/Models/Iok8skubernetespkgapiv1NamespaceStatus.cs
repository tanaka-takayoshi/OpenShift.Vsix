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
    /// NamespaceStatus is information about the current status of a Namespace.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1NamespaceStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1NamespaceStatus class.
        /// </summary>
        public Iok8skubernetespkgapiv1NamespaceStatus() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1NamespaceStatus class.
        /// </summary>
        public Iok8skubernetespkgapiv1NamespaceStatus(string phase = default(string))
        {
            Phase = phase;
        }

        /// <summary>
        /// Phase is the current lifecycle phase of the namespace. More info:
        /// https://git.k8s.io/community/contributors/design-proposals/namespaces.md#phases
        /// </summary>
        [JsonProperty(PropertyName = "phase")]
        public string Phase { get; set; }

    }
}
