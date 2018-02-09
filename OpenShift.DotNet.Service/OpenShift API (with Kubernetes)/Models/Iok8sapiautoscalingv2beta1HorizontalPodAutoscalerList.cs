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
    /// HorizontalPodAutoscaler is a list of horizontal pod autoscaler objects.
    /// </summary>
    public partial class Iok8sapiautoscalingv2beta1HorizontalPodAutoscalerList
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiautoscalingv2beta1HorizontalPodAutoscalerList class.
        /// </summary>
        public Iok8sapiautoscalingv2beta1HorizontalPodAutoscalerList() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiautoscalingv2beta1HorizontalPodAutoscalerList class.
        /// </summary>
        public Iok8sapiautoscalingv2beta1HorizontalPodAutoscalerList(IList<Iok8sapiautoscalingv2beta1HorizontalPodAutoscaler> items, string apiVersion = default(string), string kind = default(string), Iok8sapimachinerypkgapismetav1ListMeta metadata = default(Iok8sapimachinerypkgapismetav1ListMeta))
        {
            ApiVersion = apiVersion;
            Items = items;
            Kind = kind;
            Metadata = metadata;
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
        /// items is the list of horizontal pod autoscaler objects.
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<Iok8sapiautoscalingv2beta1HorizontalPodAutoscaler> Items { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object
        /// represents. Servers may infer this from the endpoint the client
        /// submits requests to. Cannot be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// metadata is the standard list metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ListMeta Metadata { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Items == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Items");
            }
            if (this.Items != null)
            {
                foreach (var element in this.Items)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}