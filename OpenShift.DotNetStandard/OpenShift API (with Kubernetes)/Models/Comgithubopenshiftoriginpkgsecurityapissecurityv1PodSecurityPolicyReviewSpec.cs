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
    /// PodSecurityPolicyReviewSpec defines specification for
    /// PodSecurityPolicyReview
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgsecurityapissecurityv1PodSecurityPolicyReviewSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgsecurityapissecurityv1PodSecurityPolicyReviewSpec
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgsecurityapissecurityv1PodSecurityPolicyReviewSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgsecurityapissecurityv1PodSecurityPolicyReviewSpec
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgsecurityapissecurityv1PodSecurityPolicyReviewSpec(Iok8skubernetespkgapiv1PodTemplateSpec template, IList<string> serviceAccountNames = default(IList<string>))
        {
            ServiceAccountNames = serviceAccountNames;
            Template = template;
        }

        /// <summary>
        /// serviceAccountNames is an optional set of ServiceAccounts to run
        /// the check with. If serviceAccountNames is empty, the
        /// template.spec.serviceAccountName is used, unless it's empty, in
        /// which case "default" is used instead. If serviceAccountNames is
        /// specified, template.spec.serviceAccountName is ignored.
        /// </summary>
        [JsonProperty(PropertyName = "serviceAccountNames")]
        public IList<string> ServiceAccountNames { get; set; }

        /// <summary>
        /// template is the PodTemplateSpec to check. The
        /// template.spec.serviceAccountName field is used if
        /// serviceAccountNames is empty, unless the
        /// template.spec.serviceAccountName is empty, in which case
        /// "default" is used. If serviceAccountNames is specified,
        /// template.spec.serviceAccountName is ignored.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public Iok8skubernetespkgapiv1PodTemplateSpec Template { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Template == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Template");
            }
            if (this.Template != null)
            {
                this.Template.Validate();
            }
        }
    }
}
