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
    /// Describe a container image
    /// </summary>
    public partial class Iok8skubernetespkgapiv1ContainerImage
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1ContainerImage class.
        /// </summary>
        public Iok8skubernetespkgapiv1ContainerImage() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1ContainerImage class.
        /// </summary>
        public Iok8skubernetespkgapiv1ContainerImage(IList<string> names, long? sizeBytes = default(long?))
        {
            Names = names;
            SizeBytes = sizeBytes;
        }

        /// <summary>
        /// Names by which this image is known. e.g.
        /// ["gcr.io/google_containers/hyperkube:v1.0.7",
        /// "dockerhub.io/google_containers/hyperkube:v1.0.7"]
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public IList<string> Names { get; set; }

        /// <summary>
        /// The size of the image in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "sizeBytes")]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Names == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Names");
            }
        }
    }
}
