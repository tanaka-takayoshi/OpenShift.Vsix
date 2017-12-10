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
    /// Event is a report of an event somewhere in the cluster.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1Event
    {
        /// <summary>
        /// Initializes a new instance of the Iok8skubernetespkgapiv1Event
        /// class.
        /// </summary>
        public Iok8skubernetespkgapiv1Event() { }

        /// <summary>
        /// Initializes a new instance of the Iok8skubernetespkgapiv1Event
        /// class.
        /// </summary>
        public Iok8skubernetespkgapiv1Event(Iok8skubernetespkgapiv1ObjectReference involvedObject, Iok8sapimachinerypkgapismetav1ObjectMeta metadata, string apiVersion = default(string), int? count = default(int?), DateTime? firstTimestamp = default(DateTime?), string kind = default(string), DateTime? lastTimestamp = default(DateTime?), string message = default(string), string reason = default(string), Iok8skubernetespkgapiv1EventSource source = default(Iok8skubernetespkgapiv1EventSource), string type = default(string))
        {
            ApiVersion = apiVersion;
            Count = count;
            FirstTimestamp = firstTimestamp;
            InvolvedObject = involvedObject;
            Kind = kind;
            LastTimestamp = lastTimestamp;
            Message = message;
            Metadata = metadata;
            Reason = reason;
            Source = source;
            Type = type;
        }

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of
        /// an object. Servers should convert recognized schemas to the
        /// latest internal value, and may reject unrecognized values. More
        /// info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// The number of times this event has occurred.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// The time at which the event was first recorded. (Time of server
        /// receipt is in TypeMeta.)
        /// </summary>
        [JsonProperty(PropertyName = "firstTimestamp")]
        public DateTime? FirstTimestamp { get; set; }

        /// <summary>
        /// The object that this event is about.
        /// </summary>
        [JsonProperty(PropertyName = "involvedObject")]
        public Iok8skubernetespkgapiv1ObjectReference InvolvedObject { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object
        /// represents. Servers may infer this from the endpoint the client
        /// submits requests to. Cannot be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// The time at which the most recent occurrence of this event was
        /// recorded.
        /// </summary>
        [JsonProperty(PropertyName = "lastTimestamp")]
        public DateTime? LastTimestamp { get; set; }

        /// <summary>
        /// A human-readable description of the status of this operation.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Standard object's metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// This should be a short, machine understandable string that gives
        /// the reason for the transition into the object's current status.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The component reporting this event. Should be a short machine
        /// understandable string.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public Iok8skubernetespkgapiv1EventSource Source { get; set; }

        /// <summary>
        /// Type of this event (Normal, Warning), new types could be added in
        /// the future
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (InvolvedObject == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InvolvedObject");
            }
            if (Metadata == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Metadata");
            }
            if (this.Metadata != null)
            {
                this.Metadata.Validate();
            }
        }
    }
}
