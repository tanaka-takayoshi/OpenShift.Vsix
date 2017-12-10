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
    /// PodDisruptionBudget is an object to define the max disruption that can
    /// be caused to a collection of pods
    /// </summary>
    public partial class Iok8skubernetespkgapispolicyv1beta1PodDisruptionBudget
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapispolicyv1beta1PodDisruptionBudget class.
        /// </summary>
        public Iok8skubernetespkgapispolicyv1beta1PodDisruptionBudget() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapispolicyv1beta1PodDisruptionBudget class.
        /// </summary>
        public Iok8skubernetespkgapispolicyv1beta1PodDisruptionBudget(string apiVersion = default(string), string kind = default(string), Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta), Iok8skubernetespkgapispolicyv1beta1PodDisruptionBudgetSpec spec = default(Iok8skubernetespkgapispolicyv1beta1PodDisruptionBudgetSpec), Iok8skubernetespkgapispolicyv1beta1PodDisruptionBudgetStatus status = default(Iok8skubernetespkgapispolicyv1beta1PodDisruptionBudgetStatus))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Spec = spec;
            Status = status;
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
        /// Kind is a string value representing the REST resource this object
        /// represents. Servers may infer this from the endpoint the client
        /// submits requests to. Cannot be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Specification of the desired behavior of the PodDisruptionBudget.
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public Iok8skubernetespkgapispolicyv1beta1PodDisruptionBudgetSpec Spec { get; set; }

        /// <summary>
        /// Most recently observed status of the PodDisruptionBudget.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Iok8skubernetespkgapispolicyv1beta1PodDisruptionBudgetStatus Status { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Metadata != null)
            {
                this.Metadata.Validate();
            }
            if (this.Status != null)
            {
                this.Status.Validate();
            }
        }
    }
}
