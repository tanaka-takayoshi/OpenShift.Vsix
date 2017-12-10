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
    /// StatefulSetStatus represents the current state of a StatefulSet.
    /// </summary>
    public partial class Iok8skubernetespkgapisappsv1beta1StatefulSetStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisappsv1beta1StatefulSetStatus class.
        /// </summary>
        public Iok8skubernetespkgapisappsv1beta1StatefulSetStatus() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisappsv1beta1StatefulSetStatus class.
        /// </summary>
        public Iok8skubernetespkgapisappsv1beta1StatefulSetStatus(int replicas, int? currentReplicas = default(int?), string currentRevision = default(string), long? observedGeneration = default(long?), int? readyReplicas = default(int?), string updateRevision = default(string), int? updatedReplicas = default(int?))
        {
            CurrentReplicas = currentReplicas;
            CurrentRevision = currentRevision;
            ObservedGeneration = observedGeneration;
            ReadyReplicas = readyReplicas;
            Replicas = replicas;
            UpdateRevision = updateRevision;
            UpdatedReplicas = updatedReplicas;
        }

        /// <summary>
        /// currentReplicas is the number of Pods created by the StatefulSet
        /// controller from the StatefulSet version indicated by
        /// currentRevision.
        /// </summary>
        [JsonProperty(PropertyName = "currentReplicas")]
        public int? CurrentReplicas { get; set; }

        /// <summary>
        /// currentRevision, if not empty, indicates the version of the
        /// StatefulSet used to generate Pods in the sequence
        /// [0,currentReplicas).
        /// </summary>
        [JsonProperty(PropertyName = "currentRevision")]
        public string CurrentRevision { get; set; }

        /// <summary>
        /// observedGeneration is the most recent generation observed for this
        /// StatefulSet. It corresponds to the StatefulSet's generation,
        /// which is updated on mutation by the API Server.
        /// </summary>
        [JsonProperty(PropertyName = "observedGeneration")]
        public long? ObservedGeneration { get; set; }

        /// <summary>
        /// readyReplicas is the number of Pods created by the StatefulSet
        /// controller that have a Ready Condition.
        /// </summary>
        [JsonProperty(PropertyName = "readyReplicas")]
        public int? ReadyReplicas { get; set; }

        /// <summary>
        /// replicas is the number of Pods created by the StatefulSet
        /// controller.
        /// </summary>
        [JsonProperty(PropertyName = "replicas")]
        public int Replicas { get; set; }

        /// <summary>
        /// updateRevision, if not empty, indicates the version of the
        /// StatefulSet used to generate Pods in the sequence
        /// [replicas-updatedReplicas,replicas)
        /// </summary>
        [JsonProperty(PropertyName = "updateRevision")]
        public string UpdateRevision { get; set; }

        /// <summary>
        /// updatedReplicas is the number of Pods created by the StatefulSet
        /// controller from the StatefulSet version indicated by
        /// updateRevision.
        /// </summary>
        [JsonProperty(PropertyName = "updatedReplicas")]
        public int? UpdatedReplicas { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
