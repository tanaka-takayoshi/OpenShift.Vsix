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
    /// Information about the condition of a component.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1ComponentCondition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1ComponentCondition class.
        /// </summary>
        public Iok8skubernetespkgapiv1ComponentCondition() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1ComponentCondition class.
        /// </summary>
        public Iok8skubernetespkgapiv1ComponentCondition(string status, string type, string error = default(string), string message = default(string))
        {
            Error = error;
            Message = message;
            Status = status;
            Type = type;
        }

        /// <summary>
        /// Condition error code for a component. For example, a health check
        /// error code.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        /// <summary>
        /// Message about the condition for a component. For example,
        /// information about a health check.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Status of the condition for a component. Valid values for
        /// "Healthy": "True", "False", or "Unknown".
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Type of condition for a component. Valid value: "Healthy"
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
