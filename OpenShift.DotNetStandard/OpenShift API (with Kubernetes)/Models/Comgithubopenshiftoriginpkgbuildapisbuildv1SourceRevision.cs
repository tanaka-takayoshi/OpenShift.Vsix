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
    /// SourceRevision is the revision or commit information from the source
    /// for the build
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgbuildapisbuildv1SourceRevision
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1SourceRevision class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1SourceRevision() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1SourceRevision class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1SourceRevision(string type, Comgithubopenshiftoriginpkgbuildapisbuildv1GitSourceRevision git = default(Comgithubopenshiftoriginpkgbuildapisbuildv1GitSourceRevision))
        {
            Git = git;
            Type = type;
        }

        /// <summary>
        /// Git contains information about git-based build source
        /// </summary>
        [JsonProperty(PropertyName = "git")]
        public Comgithubopenshiftoriginpkgbuildapisbuildv1GitSourceRevision Git { get; set; }

        /// <summary>
        /// type of the build source, may be one of 'Source', 'Dockerfile',
        /// 'Binary', or 'Images'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}