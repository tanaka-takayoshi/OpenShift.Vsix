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
    /// TagEventCondition contains condition information for a tag event.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgimageapisimagev1TagEventCondition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgimageapisimagev1TagEventCondition
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgimageapisimagev1TagEventCondition() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgimageapisimagev1TagEventCondition
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgimageapisimagev1TagEventCondition(long generation, string status, string type, DateTime? lastTransitionTime = default(DateTime?), string message = default(string), string reason = default(string))
        {
            Generation = generation;
            LastTransitionTime = lastTransitionTime;
            Message = message;
            Reason = reason;
            Status = status;
            Type = type;
        }

        /// <summary>
        /// Generation is the spec tag generation that this status corresponds
        /// to
        /// </summary>
        [JsonProperty(PropertyName = "generation")]
        public long Generation { get; set; }

        /// <summary>
        /// LastTransitionTIme is the time the condition transitioned from one
        /// status to another.
        /// </summary>
        [JsonProperty(PropertyName = "lastTransitionTime")]
        public DateTime? LastTransitionTime { get; set; }

        /// <summary>
        /// Message is a human readable description of the details about last
        /// transition, complementing reason.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Reason is a brief machine readable explanation for the condition's
        /// last transition.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Status of the condition, one of True, False, Unknown.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Type of tag event condition, currently only ImportSuccess
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
