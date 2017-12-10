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
    /// RoleBindingRestriction is an object that can be matched against a
    /// subject (user, group, or service account) to determine whether
    /// rolebindings on that subject are allowed in the namespace to which
    /// the RoleBindingRestriction belongs.  If any one of those
    /// RoleBindingRestriction objects matches a subject, rolebindings on
    /// that subject in the namespace are allowed.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgauthorizationapisauthorizationv1RoleBindingRestriction
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgauthorizationapisauthorizationv1RoleBindingRestriction
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgauthorizationapisauthorizationv1RoleBindingRestriction() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgauthorizationapisauthorizationv1RoleBindingRestriction
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgauthorizationapisauthorizationv1RoleBindingRestriction(Iok8sapimachinerypkgapismetav1ObjectMeta metadata, Comgithubopenshiftoriginpkgauthorizationapisauthorizationv1RoleBindingRestrictionSpec spec, string apiVersion = default(string), string kind = default(string))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Spec = spec;
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
        /// Standard object's metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Spec defines the matcher.
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public Comgithubopenshiftoriginpkgauthorizationapisauthorizationv1RoleBindingRestrictionSpec Spec { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Metadata == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Metadata");
            }
            if (Spec == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Spec");
            }
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
