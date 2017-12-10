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
    /// ImageStreamTag represents an Image that is retrieved by tag name from
    /// an ImageStream.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgimageapisimagev1ImageStreamTag
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgimageapisimagev1ImageStreamTag class.
        /// </summary>
        public Comgithubopenshiftoriginpkgimageapisimagev1ImageStreamTag() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgimageapisimagev1ImageStreamTag class.
        /// </summary>
        public Comgithubopenshiftoriginpkgimageapisimagev1ImageStreamTag(long generation, Comgithubopenshiftoriginpkgimageapisimagev1Image image, Comgithubopenshiftoriginpkgimageapisimagev1ImageLookupPolicy lookupPolicy, Comgithubopenshiftoriginpkgimageapisimagev1TagReference tag, string apiVersion = default(string), IList<Comgithubopenshiftoriginpkgimageapisimagev1TagEventCondition> conditions = default(IList<Comgithubopenshiftoriginpkgimageapisimagev1TagEventCondition>), string kind = default(string), Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta))
        {
            ApiVersion = apiVersion;
            Conditions = conditions;
            Generation = generation;
            Image = image;
            Kind = kind;
            LookupPolicy = lookupPolicy;
            Metadata = metadata;
            Tag = tag;
        }

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of
        /// an object. Servers should convert recognized schemas to the
        /// latest internal value, and may reject unrecognized values. More
        /// info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// conditions is an array of conditions that apply to the image
        /// stream tag.
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<Comgithubopenshiftoriginpkgimageapisimagev1TagEventCondition> Conditions { get; set; }

        /// <summary>
        /// generation is the current generation of the tagged image - if tag
        /// is provided and this value is not equal to the tag generation, a
        /// user has requested an import that has not completed, or
        /// conditions will be filled out indicating any error.
        /// </summary>
        [JsonProperty(PropertyName = "generation")]
        public long Generation { get; set; }

        /// <summary>
        /// image associated with the ImageStream and tag.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public Comgithubopenshiftoriginpkgimageapisimagev1Image Image { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object
        /// represents. Servers may infer this from the endpoint the client
        /// submits requests to. Cannot be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// lookupPolicy indicates whether this tag will handle image
        /// references in this namespace.
        /// </summary>
        [JsonProperty(PropertyName = "lookupPolicy")]
        public Comgithubopenshiftoriginpkgimageapisimagev1ImageLookupPolicy LookupPolicy { get; set; }

        /// <summary>
        /// Standard object's metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// tag is the spec tag associated with this image stream tag, and it
        /// may be null if only pushes have occurred to this image stream.
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public Comgithubopenshiftoriginpkgimageapisimagev1TagReference Tag { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Image == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Image");
            }
            if (LookupPolicy == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LookupPolicy");
            }
            if (Tag == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tag");
            }
            if (this.Conditions != null)
            {
                foreach (var element in this.Conditions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.Image != null)
            {
                this.Image.Validate();
            }
            if (this.LookupPolicy != null)
            {
                this.LookupPolicy.Validate();
            }
            if (this.Metadata != null)
            {
                this.Metadata.Validate();
            }
            if (this.Tag != null)
            {
                this.Tag.Validate();
            }
        }
    }
}
