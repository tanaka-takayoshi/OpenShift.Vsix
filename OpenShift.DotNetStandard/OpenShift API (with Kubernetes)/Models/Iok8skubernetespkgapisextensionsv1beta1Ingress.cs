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
    /// Ingress is a collection of rules that allow inbound connections to
    /// reach the endpoints defined by a backend. An Ingress can be
    /// configured to give services externally-reachable urls, load balance
    /// traffic, terminate SSL, offer name based virtual hosting etc.
    /// </summary>
    public partial class Iok8skubernetespkgapisextensionsv1beta1Ingress
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisextensionsv1beta1Ingress class.
        /// </summary>
        public Iok8skubernetespkgapisextensionsv1beta1Ingress() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisextensionsv1beta1Ingress class.
        /// </summary>
        public Iok8skubernetespkgapisextensionsv1beta1Ingress(string apiVersion = default(string), string kind = default(string), Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta), Iok8skubernetespkgapisextensionsv1beta1IngressSpec spec = default(Iok8skubernetespkgapisextensionsv1beta1IngressSpec), Iok8skubernetespkgapisextensionsv1beta1IngressStatus status = default(Iok8skubernetespkgapisextensionsv1beta1IngressStatus))
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
        /// Standard object's metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Spec is the desired state of the Ingress. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public Iok8skubernetespkgapisextensionsv1beta1IngressSpec Spec { get; set; }

        /// <summary>
        /// Status is the current state of the Ingress. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Iok8skubernetespkgapisextensionsv1beta1IngressStatus Status { get; set; }

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
