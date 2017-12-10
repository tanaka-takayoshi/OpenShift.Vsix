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
    /// DeploymentDetails captures information about the causes of a
    /// deployment.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgappsapisappsv1DeploymentDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgappsapisappsv1DeploymentDetails class.
        /// </summary>
        public Comgithubopenshiftoriginpkgappsapisappsv1DeploymentDetails() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgappsapisappsv1DeploymentDetails class.
        /// </summary>
        public Comgithubopenshiftoriginpkgappsapisappsv1DeploymentDetails(IList<Comgithubopenshiftoriginpkgappsapisappsv1DeploymentCause> causes, string message = default(string))
        {
            Causes = causes;
            Message = message;
        }

        /// <summary>
        /// Causes are extended data associated with all the causes for
        /// creating a new deployment
        /// </summary>
        [JsonProperty(PropertyName = "causes")]
        public IList<Comgithubopenshiftoriginpkgappsapisappsv1DeploymentCause> Causes { get; set; }

        /// <summary>
        /// Message is the user specified change message, if this deployment
        /// was triggered manually by the user
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Causes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Causes");
            }
            if (this.Causes != null)
            {
                foreach (var element in this.Causes)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}