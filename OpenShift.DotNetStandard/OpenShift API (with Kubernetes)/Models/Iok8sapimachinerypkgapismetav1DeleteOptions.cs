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
    /// DeleteOptions may be provided when deleting an API object.
    /// </summary>
    public partial class Iok8sapimachinerypkgapismetav1DeleteOptions
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapimachinerypkgapismetav1DeleteOptions class.
        /// </summary>
        public Iok8sapimachinerypkgapismetav1DeleteOptions() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapimachinerypkgapismetav1DeleteOptions class.
        /// </summary>
        public Iok8sapimachinerypkgapismetav1DeleteOptions(string apiVersion = default(string), long? gracePeriodSeconds = default(long?), string kind = default(string), bool? orphanDependents = default(bool?), Iok8sapimachinerypkgapismetav1Preconditions preconditions = default(Iok8sapimachinerypkgapismetav1Preconditions), string propagationPolicy = default(string))
        {
            ApiVersion = apiVersion;
            GracePeriodSeconds = gracePeriodSeconds;
            Kind = kind;
            OrphanDependents = orphanDependents;
            Preconditions = preconditions;
            PropagationPolicy = propagationPolicy;
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
        /// The duration in seconds before the object should be deleted. Value
        /// must be non-negative integer. The value zero indicates delete
        /// immediately. If this value is nil, the default grace period for
        /// the specified type will be used. Defaults to a per object value
        /// if not specified. zero means delete immediately.
        /// </summary>
        [JsonProperty(PropertyName = "gracePeriodSeconds")]
        public long? GracePeriodSeconds { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object
        /// represents. Servers may infer this from the endpoint the client
        /// submits requests to. Cannot be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Deprecated: please use the PropagationPolicy, this field will be
        /// deprecated in 1.7. Should the dependent objects be orphaned. If
        /// true/false, the "orphan" finalizer will be added to/removed from
        /// the object's finalizers list. Either this field or
        /// PropagationPolicy may be set, but not both.
        /// </summary>
        [JsonProperty(PropertyName = "orphanDependents")]
        public bool? OrphanDependents { get; set; }

        /// <summary>
        /// Must be fulfilled before a deletion is carried out. If not
        /// possible, a 409 Conflict status will be returned.
        /// </summary>
        [JsonProperty(PropertyName = "preconditions")]
        public Iok8sapimachinerypkgapismetav1Preconditions Preconditions { get; set; }

        /// <summary>
        /// Whether and how garbage collection will be performed. Either this
        /// field or OrphanDependents may be set, but not both. The default
        /// policy is decided by the existing finalizer set in the
        /// metadata.finalizers and the resource-specific default policy.
        /// </summary>
        [JsonProperty(PropertyName = "propagationPolicy")]
        public string PropagationPolicy { get; set; }

    }
}
