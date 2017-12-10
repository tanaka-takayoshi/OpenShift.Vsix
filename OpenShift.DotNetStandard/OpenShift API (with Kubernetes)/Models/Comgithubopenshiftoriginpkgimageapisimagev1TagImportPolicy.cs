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
    /// TagImportPolicy controls how images related to this tag will be
    /// imported.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgimageapisimagev1TagImportPolicy
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgimageapisimagev1TagImportPolicy class.
        /// </summary>
        public Comgithubopenshiftoriginpkgimageapisimagev1TagImportPolicy() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgimageapisimagev1TagImportPolicy class.
        /// </summary>
        public Comgithubopenshiftoriginpkgimageapisimagev1TagImportPolicy(bool? insecure = default(bool?), bool? scheduled = default(bool?))
        {
            Insecure = insecure;
            Scheduled = scheduled;
        }

        /// <summary>
        /// Insecure is true if the server may bypass certificate verification
        /// or connect directly over HTTP during image import.
        /// </summary>
        [JsonProperty(PropertyName = "insecure")]
        public bool? Insecure { get; set; }

        /// <summary>
        /// Scheduled indicates to the server that this tag should be
        /// periodically checked to ensure it is up to date, and imported
        /// </summary>
        [JsonProperty(PropertyName = "scheduled")]
        public bool? Scheduled { get; set; }

    }
}
