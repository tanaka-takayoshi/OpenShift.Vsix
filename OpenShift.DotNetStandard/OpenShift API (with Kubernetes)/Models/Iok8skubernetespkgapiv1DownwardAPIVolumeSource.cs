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
    /// DownwardAPIVolumeSource represents a volume containing downward API
    /// info. Downward API volumes support ownership management and SELinux
    /// relabeling.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1DownwardAPIVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1DownwardAPIVolumeSource class.
        /// </summary>
        public Iok8skubernetespkgapiv1DownwardAPIVolumeSource() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1DownwardAPIVolumeSource class.
        /// </summary>
        public Iok8skubernetespkgapiv1DownwardAPIVolumeSource(int? defaultMode = default(int?), IList<Iok8skubernetespkgapiv1DownwardAPIVolumeFile> items = default(IList<Iok8skubernetespkgapiv1DownwardAPIVolumeFile>))
        {
            DefaultMode = defaultMode;
            Items = items;
        }

        /// <summary>
        /// Optional: mode bits to use on created files by default. Must be a
        /// value between 0 and 0777. Defaults to 0644. Directories within
        /// the path are not affected by this setting. This might be in
        /// conflict with other options that affect the file mode, like
        /// fsGroup, and the result can be other mode bits set.
        /// </summary>
        [JsonProperty(PropertyName = "defaultMode")]
        public int? DefaultMode { get; set; }

        /// <summary>
        /// Items is a list of downward API volume file
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<Iok8skubernetespkgapiv1DownwardAPIVolumeFile> Items { get; set; }

    }
}
