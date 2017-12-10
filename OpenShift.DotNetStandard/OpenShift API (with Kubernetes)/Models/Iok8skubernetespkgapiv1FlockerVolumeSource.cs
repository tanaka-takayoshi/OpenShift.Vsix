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
    /// Represents a Flocker volume mounted by the Flocker agent. One and only
    /// one of datasetName and datasetUUID should be set. Flocker volumes do
    /// not support ownership management or SELinux relabeling.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1FlockerVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1FlockerVolumeSource class.
        /// </summary>
        public Iok8skubernetespkgapiv1FlockerVolumeSource() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1FlockerVolumeSource class.
        /// </summary>
        public Iok8skubernetespkgapiv1FlockerVolumeSource(string datasetName = default(string), string datasetUUID = default(string))
        {
            DatasetName = datasetName;
            DatasetUUID = datasetUUID;
        }

        /// <summary>
        /// Name of the dataset stored as metadata -&gt; name on the dataset
        /// for Flocker should be considered as deprecated
        /// </summary>
        [JsonProperty(PropertyName = "datasetName")]
        public string DatasetName { get; set; }

        /// <summary>
        /// UUID of the dataset. This is unique identifier of a Flocker dataset
        /// </summary>
        [JsonProperty(PropertyName = "datasetUUID")]
        public string DatasetUUID { get; set; }

    }
}
