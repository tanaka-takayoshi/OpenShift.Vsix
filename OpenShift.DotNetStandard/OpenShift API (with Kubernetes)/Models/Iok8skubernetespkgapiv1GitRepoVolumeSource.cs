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
    /// Represents a volume that is populated with the contents of a git
    /// repository. Git repo volumes do not support ownership management. Git
    /// repo volumes support SELinux relabeling.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1GitRepoVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1GitRepoVolumeSource class.
        /// </summary>
        public Iok8skubernetespkgapiv1GitRepoVolumeSource() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1GitRepoVolumeSource class.
        /// </summary>
        public Iok8skubernetespkgapiv1GitRepoVolumeSource(string repository, string directory = default(string), string revision = default(string))
        {
            Directory = directory;
            Repository = repository;
            Revision = revision;
        }

        /// <summary>
        /// Target directory name. Must not contain or start with '..'.  If
        /// '.' is supplied, the volume directory will be the git repository.
        /// Otherwise, if specified, the volume will contain the git
        /// repository in the subdirectory with the given name.
        /// </summary>
        [JsonProperty(PropertyName = "directory")]
        public string Directory { get; set; }

        /// <summary>
        /// Repository URL
        /// </summary>
        [JsonProperty(PropertyName = "repository")]
        public string Repository { get; set; }

        /// <summary>
        /// Commit hash for the specified revision.
        /// </summary>
        [JsonProperty(PropertyName = "revision")]
        public string Revision { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Repository == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Repository");
            }
        }
    }
}