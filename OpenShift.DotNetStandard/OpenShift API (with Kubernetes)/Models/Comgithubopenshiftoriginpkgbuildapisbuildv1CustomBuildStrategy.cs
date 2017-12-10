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
    /// CustomBuildStrategy defines input parameters specific to Custom build.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgbuildapisbuildv1CustomBuildStrategy
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1CustomBuildStrategy
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1CustomBuildStrategy() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1CustomBuildStrategy
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1CustomBuildStrategy(Iok8skubernetespkgapiv1ObjectReference fromProperty, string buildAPIVersion = default(string), IList<Iok8skubernetespkgapiv1EnvVar> env = default(IList<Iok8skubernetespkgapiv1EnvVar>), bool? exposeDockerSocket = default(bool?), bool? forcePull = default(bool?), Iok8skubernetespkgapiv1LocalObjectReference pullSecret = default(Iok8skubernetespkgapiv1LocalObjectReference), IList<Comgithubopenshiftoriginpkgbuildapisbuildv1SecretSpec> secrets = default(IList<Comgithubopenshiftoriginpkgbuildapisbuildv1SecretSpec>))
        {
            BuildAPIVersion = buildAPIVersion;
            Env = env;
            ExposeDockerSocket = exposeDockerSocket;
            ForcePull = forcePull;
            FromProperty = fromProperty;
            PullSecret = pullSecret;
            Secrets = secrets;
        }

        /// <summary>
        /// buildAPIVersion is the requested API version for the Build object
        /// serialized and passed to the custom builder
        /// </summary>
        [JsonProperty(PropertyName = "buildAPIVersion")]
        public string BuildAPIVersion { get; set; }

        /// <summary>
        /// env contains additional environment variables you want to pass
        /// into a builder container.
        /// </summary>
        [JsonProperty(PropertyName = "env")]
        public IList<Iok8skubernetespkgapiv1EnvVar> Env { get; set; }

        /// <summary>
        /// exposeDockerSocket will allow running Docker commands (and build
        /// Docker images) from inside the Docker container.
        /// </summary>
        [JsonProperty(PropertyName = "exposeDockerSocket")]
        public bool? ExposeDockerSocket { get; set; }

        /// <summary>
        /// forcePull describes if the controller should configure the build
        /// pod to always pull the images for the builder or only pull if it
        /// is not present locally
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
        /// pullSecret is the name of a Secret that would be used for setting
        /// up the authentication for pulling the Docker images from the
        /// private Docker registries
        /// </summary>
        [JsonProperty(PropertyName = "pullSecret")]
        public Iok8skubernetespkgapiv1LocalObjectReference PullSecret { get; set; }

        /// <summary>
        /// secrets is a list of additional secrets that will be included in
        /// the build pod
        /// </summary>
        [JsonProperty(PropertyName = "secrets")]
        public IList<Comgithubopenshiftoriginpkgbuildapisbuildv1SecretSpec> Secrets { get; set; }

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
            if (this.Secrets != null)
            {
                foreach (var element1 in this.Secrets)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}