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
    /// ProjectSpec describes the attributes on a Project
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgprojectapisprojectv1ProjectSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgprojectapisprojectv1ProjectSpec class.
        /// </summary>
        public Comgithubopenshiftoriginpkgprojectapisprojectv1ProjectSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgprojectapisprojectv1ProjectSpec class.
        /// </summary>
        public Comgithubopenshiftoriginpkgprojectapisprojectv1ProjectSpec(IList<string> finalizers = default(IList<string>))
        {
            Finalizers = finalizers;
        }

        /// <summary>
        /// Finalizers is an opaque list of values that must be empty to
        /// permanently remove object from storage
        /// </summary>
        [JsonProperty(PropertyName = "finalizers")]
        public IList<string> Finalizers { get; set; }

    }
}
