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
    /// SourceBuildStrategy defines input parameters specific to an Source
    /// build.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgbuildapisbuildv1SourceBuildStrategy
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1SourceBuildStrategy
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1SourceBuildStrategy() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1SourceBuildStrategy
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1SourceBuildStrategy(Iok8skubernetespkgapiv1ObjectReference fromProperty, IList<Iok8skubernetespkgapiv1EnvVar> env = default(IList<Iok8skubernetespkgapiv1EnvVar>), bool? forcePull = default(bool?), bool? incremental = default(bool?), Iok8skubernetespkgapiv1LocalObjectReference pullSecret = default(Iok8skubernetespkgapiv1LocalObjectReference), string scripts = default(string))
        {
            Env = env;
            ForcePull = forcePull;
            FromProperty = fromProperty;
            Incremental = incremental;
            PullSecret = pullSecret;
            Scripts = scripts;
        }

        /// <summary>
        /// env contains additional environment variables you want to pass
        /// into a builder container.
        /// </summary>
        [JsonProperty(PropertyName = "env")]
        public IList<Iok8skubernetespkgapiv1EnvVar> Env { get; set; }

        /// <summary>
        /// forcePull describes if the builder should pull the images from
        /// registry prior to building.
        /// </summary>
        [JsonProperty(PropertyName = "forcePull")]
        public bool? ForcePull { get; set; }

        /// <summary>
        /// from is reference to an DockerImage, ImageStreamTag, or
        /// ImageStreamImage from which the docker image should be pulled
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public Iok8skubernetespkgapiv1ObjectReference FromProperty { get; set; }

        /// <summary>
        /// incremental flag forces the Source build to do incremental builds
        /// if true.
        /// </summary>
        [JsonProperty(PropertyName = "incremental")]
        public bool? Incremental { get; set; }

        /// <summary>
        /// pullSecret is the name of a Secret that would be used for setting
        /// up the authentication for pulling the Docker images from the
        /// private Docker registries
        /// </summary>
        [JsonProperty(PropertyName = "pullSecret")]
        public Iok8skubernetespkgapiv1LocalObjectReference PullSecret { get; set; }

        /// <summary>
        /// scripts is the location of Source scripts
        /// </summary>
        [JsonProperty(PropertyName = "scripts")]
        public string Scripts { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (FromProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FromProperty");
            }
            if (this.Env != null)
            {
                foreach (var element in this.Env)
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
