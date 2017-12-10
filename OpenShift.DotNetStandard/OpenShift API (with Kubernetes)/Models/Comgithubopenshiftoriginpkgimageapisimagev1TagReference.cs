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
    /// TagReference specifies optional annotations for images using this tag
    /// and an optional reference to an ImageStreamTag, ImageStreamImage, or
    /// DockerImage this tag should track.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgimageapisimagev1TagReference
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgimageapisimagev1TagReference class.
        /// </summary>
        public Comgithubopenshiftoriginpkgimageapisimagev1TagReference() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgimageapisimagev1TagReference class.
        /// </summary>
        public Comgithubopenshiftoriginpkgimageapisimagev1TagReference(string name, IDictionary<string, string> annotations = default(IDictionary<string, string>), Iok8skubernetespkgapiv1ObjectReference fromProperty = default(Iok8skubernetespkgapiv1ObjectReference), long? generation = default(long?), Comgithubopenshiftoriginpkgimageapisimagev1TagImportPolicy importPolicy = default(Comgithubopenshiftoriginpkgimageapisimagev1TagImportPolicy), bool? reference = default(bool?), Comgithubopenshiftoriginpkgimageapisimagev1TagReferencePolicy referencePolicy = default(Comgithubopenshiftoriginpkgimageapisimagev1TagReferencePolicy))
        {
            Annotations = annotations;
            FromProperty = fromProperty;
            Generation = generation;
            ImportPolicy = importPolicy;
            Name = name;
            Reference = reference;
            ReferencePolicy = referencePolicy;
        }

        /// <summary>
        /// Optional; if specified, annotations that are applied to images
        /// retrieved via ImageStreamTags.
        /// </summary>
        [JsonProperty(PropertyName = "annotations")]
        public IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Optional; if specified, a reference to another image that this tag
        /// should point to. Valid values are ImageStreamTag,
        /// ImageStreamImage, and DockerImage.
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public Iok8skubernetespkgapiv1ObjectReference FromProperty { get; set; }

        /// <summary>
        /// Generation is a counter that tracks mutations to the spec tag
        /// (user intent). When a tag reference is changed the generation is
        /// set to match the current stream generation (which is incremented
        /// every time spec is changed). Other processes in the system like
        /// the image importer observe that the generation of spec tag is
        /// newer than the generation recorded in the status and use that as
        /// a trigger to import the newest remote tag. To trigger a new
        /// import, clients may set this value to zero which will reset the
        /// generation to the latest stream generation. Legacy clients will
        /// send this value as nil which will be merged with the current tag
        /// generation.
        /// </summary>
        [JsonProperty(PropertyName = "generation")]
        public long? Generation { get; set; }

        /// <summary>
        /// ImportPolicy is information that controls how images may be
        /// imported by the server.
        /// </summary>
        [JsonProperty(PropertyName = "importPolicy")]
        public Comgithubopenshiftoriginpkgimageapisimagev1TagImportPolicy ImportPolicy { get; set; }

        /// <summary>
        /// Name of the tag
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Reference states if the tag will be imported. Default value is
        /// false, which means the tag will be imported.
        /// </summary>
        [JsonProperty(PropertyName = "reference")]
        public bool? Reference { get; set; }

        /// <summary>
        /// ReferencePolicy defines how other components should consume the
        /// image.
        /// </summary>
        [JsonProperty(PropertyName = "referencePolicy")]
        public Comgithubopenshiftoriginpkgimageapisimagev1TagReferencePolicy ReferencePolicy { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (this.ReferencePolicy != null)
            {
                this.ReferencePolicy.Validate();
            }
        }
    }
}
