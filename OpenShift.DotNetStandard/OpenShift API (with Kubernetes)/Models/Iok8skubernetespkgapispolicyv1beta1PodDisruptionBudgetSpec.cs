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
    /// PodDisruptionBudgetSpec is a description of a PodDisruptionBudget.
    /// </summary>
    public partial class Iok8skubernetespkgapispolicyv1beta1PodDisruptionBudgetSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapispolicyv1beta1PodDisruptionBudgetSpec class.
        /// </summary>
        public Iok8skubernetespkgapispolicyv1beta1PodDisruptionBudgetSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapispolicyv1beta1PodDisruptionBudgetSpec class.
        /// </summary>
        public Iok8skubernetespkgapispolicyv1beta1PodDisruptionBudgetSpec(string maxUnavailable = default(string), string minAvailable = default(string), Iok8sapimachinerypkgapismetav1LabelSelector selector = default(Iok8sapimachinerypkgapismetav1LabelSelector))
        {
            MaxUnavailable = maxUnavailable;
            MinAvailable = minAvailable;
            Selector = selector;
        }

        /// <summary>
        /// An eviction is allowed if at most "maxUnavailable" pods selected
        /// by "selector" are unavailable after the eviction, i.e. even in
        /// absence of the evicted pod. For example, one can prevent all
        /// voluntary evictions by specifying 0. This is a mutually exclusive
        /// setting with "minAvailable".
        /// </summary>
        [JsonProperty(PropertyName = "maxUnavailable")]
        public string MaxUnavailable { get; set; }

        /// <summary>
        /// An eviction is allowed if at least "minAvailable" pods selected by
        /// "selector" will still be available after the eviction, i.e. even
        /// in the absence of the evicted pod.  So for example you can
        /// prevent all voluntary evictions by specifying "100%".
        /// </summary>
        [JsonProperty(PropertyName = "minAvailable")]
        public string MinAvailable { get; set; }

        /// <summary>
        /// Label query over pods whose evictions are managed by the
        /// disruption budget.
        /// </summary>
        [JsonProperty(PropertyName = "selector")]
        public Iok8sapimachinerypkgapismetav1LabelSelector Selector { get; set; }

    }
}
