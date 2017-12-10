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
    /// ReplicaSetSpec is the specification of a ReplicaSet.
    /// </summary>
    public partial class Iok8skubernetespkgapisextensionsv1beta1ReplicaSetSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisextensionsv1beta1ReplicaSetSpec class.
        /// </summary>
        public Iok8skubernetespkgapisextensionsv1beta1ReplicaSetSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisextensionsv1beta1ReplicaSetSpec class.
        /// </summary>
        public Iok8skubernetespkgapisextensionsv1beta1ReplicaSetSpec(int? minReadySeconds = default(int?), int? replicas = default(int?), Iok8sapimachinerypkgapismetav1LabelSelector selector = default(Iok8sapimachinerypkgapismetav1LabelSelector), Iok8skubernetespkgapiv1PodTemplateSpec template = default(Iok8skubernetespkgapiv1PodTemplateSpec))
        {
            MinReadySeconds = minReadySeconds;
            Replicas = replicas;
            Selector = selector;
            Template = template;
        }

        /// <summary>
        /// Minimum number of seconds for which a newly created pod should be
        /// ready without any of its container crashing, for it to be
        /// considered available. Defaults to 0 (pod will be considered
        /// available as soon as it is ready)
        /// </summary>
        [JsonProperty(PropertyName = "minReadySeconds")]
        public int? MinReadySeconds { get; set; }

        /// <summary>
        /// Replicas is the number of desired replicas. This is a pointer to
        /// distinguish between explicit zero and unspecified. Defaults to 1.
        /// More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller
        /// </summary>
        [JsonProperty(PropertyName = "replicas")]
        public int? Replicas { get; set; }

        /// <summary>
        /// Selector is a label query over pods that should match the replica
        /// count. If the selector is empty, it is defaulted to the labels
        /// present on the pod template. Label keys and values that must
        /// match in order to be controlled by this replica set. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
        /// </summary>
        [JsonProperty(PropertyName = "selector")]
        public Iok8sapimachinerypkgapismetav1LabelSelector Selector { get; set; }

        /// <summary>
        /// Template is the object that describes the pod that will be created
        /// if insufficient replicas are detected. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public Iok8skubernetespkgapiv1PodTemplateSpec Template { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Template != null)
            {
                this.Template.Validate();
            }
        }
    }
}
