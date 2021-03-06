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
    /// SecretSpec specifies a secret to be included in a build pod and its
    /// corresponding mount point
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgbuildapisbuildv1SecretSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1SecretSpec class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1SecretSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1SecretSpec class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1SecretSpec(string mountPath, Iok8skubernetespkgapiv1LocalObjectReference secretSource)
        {
            MountPath = mountPath;
            SecretSource = secretSource;
        }

        /// <summary>
        /// mountPath is the path at which to mount the secret
        /// </summary>
        [JsonProperty(PropertyName = "mountPath")]
        public string MountPath { get; set; }

        /// <summary>
        /// secretSource is a reference to the secret
        /// </summary>
        [JsonProperty(PropertyName = "secretSource")]
        public Iok8skubernetespkgapiv1LocalObjectReference SecretSource { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (MountPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MountPath");
            }
            if (SecretSource == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SecretSource");
            }
        }
    }
}
