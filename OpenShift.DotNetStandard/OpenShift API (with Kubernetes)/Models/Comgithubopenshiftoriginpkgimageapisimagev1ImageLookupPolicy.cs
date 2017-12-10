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
    /// ImageLookupPolicy describes how an image stream can be used to
    /// override the image references used by pods, builds, and other
    /// resources in a namespace.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgimageapisimagev1ImageLookupPolicy
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgimageapisimagev1ImageLookupPolicy
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgimageapisimagev1ImageLookupPolicy() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgimageapisimagev1ImageLookupPolicy
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgimageapisimagev1ImageLookupPolicy(bool local)
        {
            Local = local;
        }

        /// <summary>
        /// local will change the docker short image references (like "mysql"
        /// or "php:latest") on objects in this namespace to the image ID
        /// whenever they match this image stream, instead of reaching out to
        /// a remote registry. The name will be fully qualified to an image
        /// ID if found. The tag's referencePolicy is taken into account on
        /// the replaced value. Only works within the current namespace.
        /// </summary>
        [JsonProperty(PropertyName = "local")]
        public bool Local { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
