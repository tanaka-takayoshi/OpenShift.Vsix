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
    /// JobTemplateSpec describes the data a Job should have when created from
    /// a template
    /// </summary>
    public partial class Iok8skubernetespkgapisbatchv2alpha1JobTemplateSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisbatchv2alpha1JobTemplateSpec class.
        /// </summary>
        public Iok8skubernetespkgapisbatchv2alpha1JobTemplateSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisbatchv2alpha1JobTemplateSpec class.
        /// </summary>
        public Iok8skubernetespkgapisbatchv2alpha1JobTemplateSpec(Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta), Iok8skubernetespkgapisbatchv1JobSpec spec = default(Iok8skubernetespkgapisbatchv1JobSpec))
        {
            Metadata = metadata;
            Spec = spec;
        }

        /// <summary>
        /// Standard object's metadata of the jobs created from this template.
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Specification of the desired behavior of the job. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public Iok8skubernetespkgapisbatchv1JobSpec Spec { get; set; }

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
