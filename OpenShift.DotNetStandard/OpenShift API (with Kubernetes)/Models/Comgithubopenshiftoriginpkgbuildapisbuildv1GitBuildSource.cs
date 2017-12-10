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
    /// GitBuildSource defines the parameters of a Git SCM
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgbuildapisbuildv1GitBuildSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1GitBuildSource class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1GitBuildSource() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1GitBuildSource class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1GitBuildSource(string uri, string httpProxy = default(string), string httpsProxy = default(string), string noProxy = default(string), string refProperty = default(string))
        {
            HttpProxy = httpProxy;
            HttpsProxy = httpsProxy;
            NoProxy = noProxy;
            RefProperty = refProperty;
            Uri = uri;
        }

        /// <summary>
        /// httpProxy is a proxy used to reach the git repository over http
        /// </summary>
        [JsonProperty(PropertyName = "httpProxy")]
        public string HttpProxy { get; set; }

        /// <summary>
        /// httpsProxy is a proxy used to reach the git repository over https
        /// </summary>
        [JsonProperty(PropertyName = "httpsProxy")]
        public string HttpsProxy { get; set; }

        /// <summary>
        /// noProxy is the list of domains for which the proxy should not be
        /// used
        /// </summary>
        [JsonProperty(PropertyName = "noProxy")]
        public string NoProxy { get; set; }

        /// <summary>
        /// ref is the branch/tag/ref to build.
        /// </summary>
        [JsonProperty(PropertyName = "ref")]
        public string RefProperty { get; set; }

        /// <summary>
        /// uri points to the source that will be built. The structure of the
        /// source will depend on the type of build to run
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Uri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Uri");
            }
        }
    }
}
