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
    /// Represents a vSphere volume resource.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1VsphereVirtualDiskVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1VsphereVirtualDiskVolumeSource class.
        /// </summary>
        public Iok8skubernetespkgapiv1VsphereVirtualDiskVolumeSource() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1VsphereVirtualDiskVolumeSource class.
        /// </summary>
        public Iok8skubernetespkgapiv1VsphereVirtualDiskVolumeSource(string volumePath, string fsType = default(string), string storagePolicyID = default(string), string storagePolicyName = default(string))
        {
            FsType = fsType;
            StoragePolicyID = storagePolicyID;
            StoragePolicyName = storagePolicyName;
            VolumePath = volumePath;
        }

        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by
        /// the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly
        /// inferred to be "ext4" if unspecified.
        /// </summary>
        [JsonProperty(PropertyName = "fsType")]
        public string FsType { get; set; }

        /// <summary>
        /// Storage Policy Based Management (SPBM) profile ID associated with
        /// the StoragePolicyName.
        /// </summary>
        [JsonProperty(PropertyName = "storagePolicyID")]
        public string StoragePolicyID { get; set; }

        /// <summary>
        /// Storage Policy Based Management (SPBM) profile name.
        /// </summary>
        [JsonProperty(PropertyName = "storagePolicyName")]
        public string StoragePolicyName { get; set; }

        /// <summary>
        /// Path that identifies vSphere volume vmdk
        /// </summary>
        [JsonProperty(PropertyName = "volumePath")]
        public string VolumePath { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (VolumePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VolumePath");
            }
        }
    }
}
