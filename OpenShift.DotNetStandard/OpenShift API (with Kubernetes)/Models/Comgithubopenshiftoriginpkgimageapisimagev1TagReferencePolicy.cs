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
    /// TagReferencePolicy describes how pull-specs for images in this image
    /// stream tag are generated when image change triggers in deployment
    /// configs or builds are resolved. This allows the image stream author
    /// to control how images are accessed.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgimageapisimagev1TagReferencePolicy
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgimageapisimagev1TagReferencePolicy
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgimageapisimagev1TagReferencePolicy() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgimageapisimagev1TagReferencePolicy
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgimageapisimagev1TagReferencePolicy(string type)
        {
            Type = type;
        }

        /// <summary>
        /// Type determines how the image pull spec should be transformed when
        /// the image stream tag is used in deployment config triggers or new
        /// builds. The default value is `Source`, indicating the original
        /// location of the image should be used (if imported). The user may
        /// also specify `Local`, indicating that the pull spec should point
        /// to the integrated Docker registry and leverage the registry's
        /// ability to proxy the pull to an upstream registry. `Local` allows
        /// the credentials used to pull this image to be managed from the
        /// image stream's namespace, so others on the platform can access a
        /// remote image but have no access to the remote secret. It also
        /// allows the image layers to be mirrored into the local registry
        /// which the images can still be pulled even if the upstream
        /// registry is unavailable.
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
