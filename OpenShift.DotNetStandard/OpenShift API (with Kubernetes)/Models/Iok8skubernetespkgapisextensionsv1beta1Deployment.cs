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
    /// Deployment enables declarative updates for Pods and ReplicaSets.
    /// </summary>
    public partial class Iok8skubernetespkgapisextensionsv1beta1Deployment
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisextensionsv1beta1Deployment class.
        /// </summary>
        public Iok8skubernetespkgapisextensionsv1beta1Deployment() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisextensionsv1beta1Deployment class.
        /// </summary>
        public Iok8skubernetespkgapisextensionsv1beta1Deployment(string apiVersion = default(string), string kind = default(string), Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta), Iok8skubernetespkgapisextensionsv1beta1DeploymentSpec spec = default(Iok8skubernetespkgapisextensionsv1beta1DeploymentSpec), Iok8skubernetespkgapisextensionsv1beta1DeploymentStatus status = default(Iok8skubernetespkgapisextensionsv1beta1DeploymentStatus))
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
        /// Standard object metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Specification of the desired behavior of the Deployment.
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public Iok8skubernetespkgapisextensionsv1beta1DeploymentSpec Spec { get; set; }

        /// <summary>
        /// Most recently observed status of the Deployment.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Iok8skubernetespkgapisextensionsv1beta1DeploymentStatus Status { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Metadata != null)
            {
                this.Metadata.Validate();
            }
            if (this.Spec != null)
            {
                this.Spec.Validate();
            }
        }
    }
}
