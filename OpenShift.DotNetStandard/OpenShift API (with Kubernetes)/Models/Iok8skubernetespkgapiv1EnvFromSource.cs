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
    /// EnvFromSource represents the source of a set of ConfigMaps
    /// </summary>
    public partial class Iok8skubernetespkgapiv1EnvFromSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1EnvFromSource class.
        /// </summary>
        public Iok8skubernetespkgapiv1EnvFromSource() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1EnvFromSource class.
        /// </summary>
        public Iok8skubernetespkgapiv1EnvFromSource(Iok8skubernetespkgapiv1ConfigMapEnvSource configMapRef = default(Iok8skubernetespkgapiv1ConfigMapEnvSource), string prefix = default(string), Iok8skubernetespkgapiv1SecretEnvSource secretRef = default(Iok8skubernetespkgapiv1SecretEnvSource))
        {
            ConfigMapRef = configMapRef;
            Prefix = prefix;
            SecretRef = secretRef;
        }

        /// <summary>
        /// The ConfigMap to select from
        /// </summary>
        [JsonProperty(PropertyName = "configMapRef")]
        public Iok8skubernetespkgapiv1ConfigMapEnvSource ConfigMapRef { get; set; }

        /// <summary>
        /// An optional identifer to prepend to each key in the ConfigMap.
        /// Must be a C_IDENTIFIER.
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// The Secret to select from
        /// </summary>
        [JsonProperty(PropertyName = "secretRef")]
        public Iok8skubernetespkgapiv1SecretEnvSource SecretRef { get; set; }

    }
}
