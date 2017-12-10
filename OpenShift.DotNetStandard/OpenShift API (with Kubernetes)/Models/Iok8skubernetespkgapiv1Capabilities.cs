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
    /// Adds and removes POSIX capabilities from running containers.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1Capabilities
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1Capabilities class.
        /// </summary>
        public Iok8skubernetespkgapiv1Capabilities() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1Capabilities class.
        /// </summary>
        public Iok8skubernetespkgapiv1Capabilities(IList<string> add = default(IList<string>), IList<string> drop = default(IList<string>))
        {
            Add = add;
            Drop = drop;
        }

        /// <summary>
        /// Added capabilities
        /// </summary>
        [JsonProperty(PropertyName = "add")]
        public IList<string> Add { get; set; }

        /// <summary>
        /// Removed capabilities
        /// </summary>
        [JsonProperty(PropertyName = "drop")]
        public IList<string> Drop { get; set; }

    }
}
