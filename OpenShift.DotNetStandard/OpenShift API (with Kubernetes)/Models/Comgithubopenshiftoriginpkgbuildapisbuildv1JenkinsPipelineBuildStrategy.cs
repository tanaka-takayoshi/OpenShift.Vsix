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
    /// JenkinsPipelineBuildStrategy holds parameters specific to a Jenkins
    /// Pipeline build.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgbuildapisbuildv1JenkinsPipelineBuildStrategy
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1JenkinsPipelineBuildStrategy
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1JenkinsPipelineBuildStrategy() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1JenkinsPipelineBuildStrategy
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1JenkinsPipelineBuildStrategy(IList<Iok8skubernetespkgapiv1EnvVar> env = default(IList<Iok8skubernetespkgapiv1EnvVar>), string jenkinsfile = default(string), string jenkinsfilePath = default(string))
        {
            Env = env;
            Jenkinsfile = jenkinsfile;
            JenkinsfilePath = jenkinsfilePath;
        }

        /// <summary>
        /// env contains additional environment variables you want to pass
        /// into a build pipeline.
        /// </summary>
        [JsonProperty(PropertyName = "env")]
        public IList<Iok8skubernetespkgapiv1EnvVar> Env { get; set; }

        /// <summary>
        /// Jenkinsfile defines the optional raw contents of a Jenkinsfile
        /// which defines a Jenkins pipeline build.
        /// </summary>
        [JsonProperty(PropertyName = "jenkinsfile")]
        public string Jenkinsfile { get; set; }

        /// <summary>
        /// JenkinsfilePath is the optional path of the Jenkinsfile that will
        /// be used to configure the pipeline relative to the root of the
        /// context (contextDir). If both JenkinsfilePath &amp; Jenkinsfile
        /// are both not specified, this defaults to Jenkinsfile in the root
        /// of the specified contextDir.
        /// </summary>
        [JsonProperty(PropertyName = "jenkinsfilePath")]
        public string JenkinsfilePath { get; set; }

    }
}
