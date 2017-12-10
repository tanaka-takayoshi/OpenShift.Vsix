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
    /// AzureDisk represents an Azure Data Disk mount on the host and bind
    /// mount to the pod.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1AzureDiskVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1AzureDiskVolumeSource class.
        /// </summary>
        public Iok8skubernetespkgapiv1AzureDiskVolumeSource() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1AzureDiskVolumeSource class.
        /// </summary>
        public Iok8skubernetespkgapiv1AzureDiskVolumeSource(string diskName, string diskURI, string cachingMode = default(string), string fsType = default(string), string kind = default(string), bool? readOnlyProperty = default(bool?))
        {
            CachingMode = cachingMode;
            DiskName = diskName;
            DiskURI = diskURI;
            FsType = fsType;
            Kind = kind;
            ReadOnlyProperty = readOnlyProperty;
        }

        /// <summary>
        /// Host Caching mode: None, Read Only, Read Write.
        /// </summary>
        [JsonProperty(PropertyName = "cachingMode")]
        public string CachingMode { get; set; }

        /// <summary>
        /// The Name of the data disk in the blob storage
        /// </summary>
        [JsonProperty(PropertyName = "diskName")]
        public string DiskName { get; set; }

        /// <summary>
        /// The URI the data disk in the blob storage
        /// </summary>
        [JsonProperty(PropertyName = "diskURI")]
        public string DiskURI { get; set; }

        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by
        /// the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly
        /// inferred to be "ext4" if unspecified.
        /// </summary>
        [JsonProperty(PropertyName = "fsType")]
        public string FsType { get; set; }

        /// <summary>
        /// Expected values Shared: mulitple blob disks per storage account
        /// Dedicated: single blob disk per storage account  Managed: azure
        /// managed data disk (only in managed availability set). defaults to
        /// shared
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Defaults to false (read/write). ReadOnly here will force the
        /// ReadOnly setting in VolumeMounts.
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (DiskName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DiskName");
            }
            if (DiskURI == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DiskURI");
            }
        }
    }
}
