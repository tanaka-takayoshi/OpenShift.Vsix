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
    /// DeploymentTriggerPolicy describes a policy for a single trigger that
    /// results in a new deployment.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgappsapisappsv1DeploymentTriggerPolicy
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgappsapisappsv1DeploymentTriggerPolicy
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgappsapisappsv1DeploymentTriggerPolicy() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgappsapisappsv1DeploymentTriggerPolicy
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgappsapisappsv1DeploymentTriggerPolicy(Comgithubopenshiftoriginpkgappsapisappsv1DeploymentTriggerImageChangeParams imageChangeParams = default(Comgithubopenshiftoriginpkgappsapisappsv1DeploymentTriggerImageChangeParams), string type = default(string))
        {
            ImageChangeParams = imageChangeParams;
            Type = type;
        }

        /// <summary>
        /// ImageChangeParams represents the parameters for the ImageChange
        /// trigger.
        /// </summary>
        [JsonProperty(PropertyName = "imageChangeParams")]
        public Comgithubopenshiftoriginpkgappsapisappsv1DeploymentTriggerImageChangeParams ImageChangeParams { get; set; }

        /// <summary>
        /// Type of the trigger
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.ImageChangeParams != null)
            {
                this.ImageChangeParams.Validate();
            }
        }
    }
}
