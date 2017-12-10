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
    /// DeploymentCondition describes the state of a deployment at a certain
    /// point.
    /// </summary>
    public partial class Iok8skubernetespkgapisappsv1beta1DeploymentCondition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisappsv1beta1DeploymentCondition class.
        /// </summary>
        public Iok8skubernetespkgapisappsv1beta1DeploymentCondition() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisappsv1beta1DeploymentCondition class.
        /// </summary>
        public Iok8skubernetespkgapisappsv1beta1DeploymentCondition(string status, string type, DateTime? lastTransitionTime = default(DateTime?), DateTime? lastUpdateTime = default(DateTime?), string message = default(string), string reason = default(string))
        {
            LastTransitionTime = lastTransitionTime;
            LastUpdateTime = lastUpdateTime;
            Message = message;
            Reason = reason;
            Status = status;
            Type = type;
        }

        /// <summary>
        /// Last time the condition transitioned from one status to another.
        /// </summary>
        [JsonProperty(PropertyName = "lastTransitionTime")]
        public DateTime? LastTransitionTime { get; set; }

        /// <summary>
        /// The last time this condition was updated.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateTime")]
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// A human readable message indicating details about the transition.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// The reason for the condition's last transition.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Status of the condition, one of True, False, Unknown.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Type of deployment condition.
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
