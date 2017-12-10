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
    /// Represents a Persistent Disk resource in Google Compute Engine.
    /// 
    /// A GCE PD must exist before mounting to a container. The disk must also
    /// be in the same GCE project and zone as the kubelet. A GCE PD can only
    /// be mounted as read/write once or read-only many times. GCE PDs
    /// support ownership management and SELinux relabeling.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1GCEPersistentDiskVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1GCEPersistentDiskVolumeSource class.
        /// </summary>
        public Iok8skubernetespkgapiv1GCEPersistentDiskVolumeSource() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1GCEPersistentDiskVolumeSource class.
        /// </summary>
        public Iok8skubernetespkgapiv1GCEPersistentDiskVolumeSource(string pdName, string fsType = default(string), int? partition = default(int?), bool? readOnlyProperty = default(bool?))
        {
            FsType = fsType;
            Partition = partition;
            PdName = pdName;
            ReadOnlyProperty = readOnlyProperty;
        }

        /// <summary>
        /// Filesystem type of the volume that you want to mount. Tip: Ensure
        /// that the filesystem type is supported by the host operating
        /// system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to
        /// be "ext4" if unspecified. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        [JsonProperty(PropertyName = "fsType")]
        public string FsType { get; set; }

        /// <summary>
        /// The partition in the volume that you want to mount. If omitted,
        /// the default is to mount by volume name. Examples: For volume
        /// /dev/sda1, you specify the partition as "1". Similarly, the
        /// volume partition for /dev/sda is "0" (or you can leave the
        /// property empty). More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        [JsonProperty(PropertyName = "partition")]
        public int? Partition { get; set; }

        /// <summary>
        /// Unique name of the PD resource in GCE. Used to identify the disk
        /// in GCE. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        [JsonProperty(PropertyName = "pdName")]
        public string PdName { get; set; }

        /// <summary>
        /// ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// Defaults to false. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (PdName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PdName");
            }
        }
    }
}
