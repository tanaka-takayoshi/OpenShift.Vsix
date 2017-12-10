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
    /// ObjectFieldSelector selects an APIVersioned field of an object.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1ObjectFieldSelector
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1ObjectFieldSelector class.
        /// </summary>
        public Iok8skubernetespkgapiv1ObjectFieldSelector() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1ObjectFieldSelector class.
        /// </summary>
        public Iok8skubernetespkgapiv1ObjectFieldSelector(string fieldPath, string apiVersion = default(string))
        {
            ApiVersion = apiVersion;
            FieldPath = fieldPath;
        }

        /// <summary>
        /// Version of the schema the FieldPath is written in terms of,
        /// defaults to "v1".
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Path of the field to select in the specified API version.
        /// </summary>
        [JsonProperty(PropertyName = "fieldPath")]
        public string FieldPath { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (FieldPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FieldPath");
            }
        }
    }
}
