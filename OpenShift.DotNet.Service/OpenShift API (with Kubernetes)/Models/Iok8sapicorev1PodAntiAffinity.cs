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
    /// Pod anti affinity is a group of inter pod anti affinity scheduling
    /// rules.
    /// </summary>
    public partial class Iok8sapicorev1PodAntiAffinity
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1PodAntiAffinity
        /// class.
        /// </summary>
        public Iok8sapicorev1PodAntiAffinity() { }

        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1PodAntiAffinity
        /// class.
        /// </summary>
        public Iok8sapicorev1PodAntiAffinity(IList<Iok8sapicorev1WeightedPodAffinityTerm> preferredDuringSchedulingIgnoredDuringExecution = default(IList<Iok8sapicorev1WeightedPodAffinityTerm>), IList<Iok8sapicorev1PodAffinityTerm> requiredDuringSchedulingIgnoredDuringExecution = default(IList<Iok8sapicorev1PodAffinityTerm>))
        {
            PreferredDuringSchedulingIgnoredDuringExecution = preferredDuringSchedulingIgnoredDuringExecution;
            RequiredDuringSchedulingIgnoredDuringExecution = requiredDuringSchedulingIgnoredDuringExecution;
        }

        /// <summary>
        /// The scheduler will prefer to schedule pods to nodes that satisfy
        /// the anti-affinity expressions specified by this field, but it may
        /// choose a node that violates one or more of the expressions. The
        /// node that is most preferred is the one with the greatest sum of
        /// weights, i.e. for each node that meets all of the scheduling
        /// requirements (resource request, requiredDuringScheduling
        /// anti-affinity expressions, etc.), compute a sum by iterating
        /// through the elements of this field and adding "weight" to the sum
        /// if the node has pods which matches the corresponding
        /// podAffinityTerm; the node(s) with the highest sum are the most
        /// preferred.
        /// </summary>
        [JsonProperty(PropertyName = "preferredDuringSchedulingIgnoredDuringExecution")]
        public IList<Iok8sapicorev1WeightedPodAffinityTerm> PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

        /// <summary>
        /// If the anti-affinity requirements specified by this field are not
        /// met at scheduling time, the pod will not be scheduled onto the
        /// node. If the anti-affinity requirements specified by this field
        /// cease to be met at some point during pod execution (e.g. due to a
        /// pod label update), the system may or may not try to eventually
        /// evict the pod from its node. When there are multiple elements,
        /// the lists of nodes corresponding to each podAffinityTerm are
        /// intersected, i.e. all terms must be satisfied.
        /// </summary>
        [JsonProperty(PropertyName = "requiredDuringSchedulingIgnoredDuringExecution")]
        public IList<Iok8sapicorev1PodAffinityTerm> RequiredDuringSchedulingIgnoredDuringExecution { get; set; }

    }
}
