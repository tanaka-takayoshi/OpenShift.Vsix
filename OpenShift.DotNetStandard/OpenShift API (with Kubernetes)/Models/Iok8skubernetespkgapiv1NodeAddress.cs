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
    /// NodeAddress contains information for the node's address.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1NodeAddress
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1NodeAddress class.
        /// </summary>
        public Iok8skubernetespkgapiv1NodeAddress() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1NodeAddress class.
        /// </summary>
        public Iok8skubernetespkgapiv1NodeAddress(string address, string type)
        {
            Address = address;
            Type = type;
        }

        /// <summary>
        /// The node address.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Node address type, one of Hostname, ExternalIP or InternalIP.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Address == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Address");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
