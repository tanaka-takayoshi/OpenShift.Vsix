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
    /// PersistentVolumeSpec is the specification of a persistent volume.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1PersistentVolumeSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1PersistentVolumeSpec class.
        /// </summary>
        public Iok8skubernetespkgapiv1PersistentVolumeSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1PersistentVolumeSpec class.
        /// </summary>
        public Iok8skubernetespkgapiv1PersistentVolumeSpec(IList<string> accessModes = default(IList<string>), Iok8skubernetespkgapiv1AWSElasticBlockStoreVolumeSource awsElasticBlockStore = default(Iok8skubernetespkgapiv1AWSElasticBlockStoreVolumeSource), Iok8skubernetespkgapiv1AzureDiskVolumeSource azureDisk = default(Iok8skubernetespkgapiv1AzureDiskVolumeSource), Iok8skubernetespkgapiv1AzureFileVolumeSource azureFile = default(Iok8skubernetespkgapiv1AzureFileVolumeSource), IDictionary<string, string> capacity = default(IDictionary<string, string>), Iok8skubernetespkgapiv1CephFSVolumeSource cephfs = default(Iok8skubernetespkgapiv1CephFSVolumeSource), Iok8skubernetespkgapiv1CinderVolumeSource cinder = default(Iok8skubernetespkgapiv1CinderVolumeSource), Iok8skubernetespkgapiv1ObjectReference claimRef = default(Iok8skubernetespkgapiv1ObjectReference), Iok8skubernetespkgapiv1FCVolumeSource fc = default(Iok8skubernetespkgapiv1FCVolumeSource), Iok8skubernetespkgapiv1FlexVolumeSource flexVolume = default(Iok8skubernetespkgapiv1FlexVolumeSource), Iok8skubernetespkgapiv1FlockerVolumeSource flocker = default(Iok8skubernetespkgapiv1FlockerVolumeSource), Iok8skubernetespkgapiv1GCEPersistentDiskVolumeSource gcePersistentDisk = default(Iok8skubernetespkgapiv1GCEPersistentDiskVolumeSource), Iok8skubernetespkgapiv1GlusterfsVolumeSource glusterfs = default(Iok8skubernetespkgapiv1GlusterfsVolumeSource), Iok8skubernetespkgapiv1HostPathVolumeSource hostPath = default(Iok8skubernetespkgapiv1HostPathVolumeSource), Iok8skubernetespkgapiv1ISCSIVolumeSource iscsi = default(Iok8skubernetespkgapiv1ISCSIVolumeSource), Iok8skubernetespkgapiv1LocalVolumeSource local = default(Iok8skubernetespkgapiv1LocalVolumeSource), Iok8skubernetespkgapiv1NFSVolumeSource nfs = default(Iok8skubernetespkgapiv1NFSVolumeSource), string persistentVolumeReclaimPolicy = default(string), Iok8skubernetespkgapiv1PhotonPersistentDiskVolumeSource photonPersistentDisk = default(Iok8skubernetespkgapiv1PhotonPersistentDiskVolumeSource), Iok8skubernetespkgapiv1PortworxVolumeSource portworxVolume = default(Iok8skubernetespkgapiv1PortworxVolumeSource), Iok8skubernetespkgapiv1QuobyteVolumeSource quobyte = default(Iok8skubernetespkgapiv1QuobyteVolumeSource), Iok8skubernetespkgapiv1RBDVolumeSource rbd = default(Iok8skubernetespkgapiv1RBDVolumeSource), Iok8skubernetespkgapiv1ScaleIOVolumeSource scaleIO = default(Iok8skubernetespkgapiv1ScaleIOVolumeSource), string storageClassName = default(string), Iok8skubernetespkgapiv1StorageOSPersistentVolumeSource storageos = default(Iok8skubernetespkgapiv1StorageOSPersistentVolumeSource), Iok8skubernetespkgapiv1VsphereVirtualDiskVolumeSource vsphereVolume = default(Iok8skubernetespkgapiv1VsphereVirtualDiskVolumeSource))
        {
            AccessModes = accessModes;
            AwsElasticBlockStore = awsElasticBlockStore;
            AzureDisk = azureDisk;
            AzureFile = azureFile;
            Capacity = capacity;
            Cephfs = cephfs;
            Cinder = cinder;
            ClaimRef = claimRef;
            Fc = fc;
            FlexVolume = flexVolume;
            Flocker = flocker;
            GcePersistentDisk = gcePersistentDisk;
            Glusterfs = glusterfs;
            HostPath = hostPath;
            Iscsi = iscsi;
            Local = local;
            Nfs = nfs;
            PersistentVolumeReclaimPolicy = persistentVolumeReclaimPolicy;
            PhotonPersistentDisk = photonPersistentDisk;
            PortworxVolume = portworxVolume;
            Quobyte = quobyte;
            Rbd = rbd;
            ScaleIO = scaleIO;
            StorageClassName = storageClassName;
            Storageos = storageos;
            VsphereVolume = vsphereVolume;
        }

        /// <summary>
        /// AccessModes contains all ways the volume can be mounted. More
        /// info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes
        /// </summary>
        [JsonProperty(PropertyName = "accessModes")]
        public IList<string> AccessModes { get; set; }

        /// <summary>
        /// AWSElasticBlockStore represents an AWS Disk resource that is
        /// attached to a kubelet's host machine and then exposed to the pod.
        /// More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        /// </summary>
        [JsonProperty(PropertyName = "awsElasticBlockStore")]
        public Iok8skubernetespkgapiv1AWSElasticBlockStoreVolumeSource AwsElasticBlockStore { get; set; }

        /// <summary>
        /// AzureDisk represents an Azure Data Disk mount on the host and bind
        /// mount to the pod.
        /// </summary>
        [JsonProperty(PropertyName = "azureDisk")]
        public Iok8skubernetespkgapiv1AzureDiskVolumeSource AzureDisk { get; set; }

        /// <summary>
        /// AzureFile represents an Azure File Service mount on the host and
        /// bind mount to the pod.
        /// </summary>
        [JsonProperty(PropertyName = "azureFile")]
        public Iok8skubernetespkgapiv1AzureFileVolumeSource AzureFile { get; set; }

        /// <summary>
        /// A description of the persistent volume's resources and capacity.
        /// More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public IDictionary<string, string> Capacity { get; set; }

        /// <summary>
        /// CephFS represents a Ceph FS mount on the host that shares a pod's
        /// lifetime
        /// </summary>
        [JsonProperty(PropertyName = "cephfs")]
        public Iok8skubernetespkgapiv1CephFSVolumeSource Cephfs { get; set; }

        /// <summary>
        /// Cinder represents a cinder volume attached and mounted on kubelets
        /// host machine More info:
        /// https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
        /// </summary>
        [JsonProperty(PropertyName = "cinder")]
        public Iok8skubernetespkgapiv1CinderVolumeSource Cinder { get; set; }

        /// <summary>
        /// ClaimRef is part of a bi-directional binding between
        /// PersistentVolume and PersistentVolumeClaim. Expected to be
        /// non-nil when bound. claim.VolumeName is the authoritative bind
        /// between PV and PVC. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#binding
        /// </summary>
        [JsonProperty(PropertyName = "claimRef")]
        public Iok8skubernetespkgapiv1ObjectReference ClaimRef { get; set; }

        /// <summary>
        /// FC represents a Fibre Channel resource that is attached to a
        /// kubelet's host machine and then exposed to the pod.
        /// </summary>
        [JsonProperty(PropertyName = "fc")]
        public Iok8skubernetespkgapiv1FCVolumeSource Fc { get; set; }

        /// <summary>
        /// FlexVolume represents a generic volume resource that is
        /// provisioned/attached using an exec based plugin. This is an alpha
        /// feature and may change in future.
        /// </summary>
        [JsonProperty(PropertyName = "flexVolume")]
        public Iok8skubernetespkgapiv1FlexVolumeSource FlexVolume { get; set; }

        /// <summary>
        /// Flocker represents a Flocker volume attached to a kubelet's host
        /// machine and exposed to the pod for its usage. This depends on the
        /// Flocker control service being running
        /// </summary>
        [JsonProperty(PropertyName = "flocker")]
        public Iok8skubernetespkgapiv1FlockerVolumeSource Flocker { get; set; }

        /// <summary>
        /// GCEPersistentDisk represents a GCE Disk resource that is attached
        /// to a kubelet's host machine and then exposed to the pod.
        /// Provisioned by an admin. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        [JsonProperty(PropertyName = "gcePersistentDisk")]
        public Iok8skubernetespkgapiv1GCEPersistentDiskVolumeSource GcePersistentDisk { get; set; }

        /// <summary>
        /// Glusterfs represents a Glusterfs volume that is attached to a host
        /// and exposed to the pod. Provisioned by an admin. More info:
        /// https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md
        /// </summary>
        [JsonProperty(PropertyName = "glusterfs")]
        public Iok8skubernetespkgapiv1GlusterfsVolumeSource Glusterfs { get; set; }

        /// <summary>
        /// HostPath represents a directory on the host. Provisioned by a
        /// developer or tester. This is useful for single-node development
        /// and testing only! On-host storage is not supported in any way and
        /// WILL NOT WORK in a multi-node cluster. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        /// </summary>
        [JsonProperty(PropertyName = "hostPath")]
        public Iok8skubernetespkgapiv1HostPathVolumeSource HostPath { get; set; }

        /// <summary>
        /// ISCSI represents an ISCSI Disk resource that is attached to a
        /// kubelet's host machine and then exposed to the pod. Provisioned
        /// by an admin.
        /// </summary>
        [JsonProperty(PropertyName = "iscsi")]
        public Iok8skubernetespkgapiv1ISCSIVolumeSource Iscsi { get; set; }

        /// <summary>
        /// Local represents directly-attached storage with node affinity
        /// </summary>
        [JsonProperty(PropertyName = "local")]
        public Iok8skubernetespkgapiv1LocalVolumeSource Local { get; set; }

        /// <summary>
        /// NFS represents an NFS mount on the host. Provisioned by an admin.
        /// More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
        /// </summary>
        [JsonProperty(PropertyName = "nfs")]
        public Iok8skubernetespkgapiv1NFSVolumeSource Nfs { get; set; }

        /// <summary>
        /// What happens to a persistent volume when released from its claim.
        /// Valid options are Retain (default) and Recycle. Recycling must be
        /// supported by the volume plugin underlying this persistent volume.
        /// More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#reclaiming
        /// </summary>
        [JsonProperty(PropertyName = "persistentVolumeReclaimPolicy")]
        public string PersistentVolumeReclaimPolicy { get; set; }

        /// <summary>
        /// PhotonPersistentDisk represents a PhotonController persistent disk
        /// attached and mounted on kubelets host machine
        /// </summary>
        [JsonProperty(PropertyName = "photonPersistentDisk")]
        public Iok8skubernetespkgapiv1PhotonPersistentDiskVolumeSource PhotonPersistentDisk { get; set; }

        /// <summary>
        /// PortworxVolume represents a portworx volume attached and mounted
        /// on kubelets host machine
        /// </summary>
        [JsonProperty(PropertyName = "portworxVolume")]
        public Iok8skubernetespkgapiv1PortworxVolumeSource PortworxVolume { get; set; }

        /// <summary>
        /// Quobyte represents a Quobyte mount on the host that shares a pod's
        /// lifetime
        /// </summary>
        [JsonProperty(PropertyName = "quobyte")]
        public Iok8skubernetespkgapiv1QuobyteVolumeSource Quobyte { get; set; }

        /// <summary>
        /// RBD represents a Rados Block Device mount on the host that shares
        /// a pod's lifetime. More info:
        /// https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md
        /// </summary>
        [JsonProperty(PropertyName = "rbd")]
        public Iok8skubernetespkgapiv1RBDVolumeSource Rbd { get; set; }

        /// <summary>
        /// ScaleIO represents a ScaleIO persistent volume attached and
        /// mounted on Kubernetes nodes.
        /// </summary>
        [JsonProperty(PropertyName = "scaleIO")]
        public Iok8skubernetespkgapiv1ScaleIOVolumeSource ScaleIO { get; set; }

        /// <summary>
        /// Name of StorageClass to which this persistent volume belongs.
        /// Empty value means that this volume does not belong to any
        /// StorageClass.
        /// </summary>
        [JsonProperty(PropertyName = "storageClassName")]
        public string StorageClassName { get; set; }

        /// <summary>
        /// StorageOS represents a StorageOS volume that is attached to the
        /// kubelet's host machine and mounted into the pod More info:
        /// https://releases.k8s.io/HEAD/examples/volumes/storageos/README.md
        /// </summary>
        [JsonProperty(PropertyName = "storageos")]
        public Iok8skubernetespkgapiv1StorageOSPersistentVolumeSource Storageos { get; set; }

        /// <summary>
        /// VsphereVolume represents a vSphere volume attached and mounted on
        /// kubelets host machine
        /// </summary>
        [JsonProperty(PropertyName = "vsphereVolume")]
        public Iok8skubernetespkgapiv1VsphereVirtualDiskVolumeSource VsphereVolume { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.AwsElasticBlockStore != null)
            {
                this.AwsElasticBlockStore.Validate();
            }
            if (this.AzureDisk != null)
            {
                this.AzureDisk.Validate();
            }
            if (this.AzureFile != null)
            {
                this.AzureFile.Validate();
            }
            if (this.Cephfs != null)
            {
                this.Cephfs.Validate();
            }
            if (this.Cinder != null)
            {
                this.Cinder.Validate();
            }
            if (this.Fc != null)
            {
                this.Fc.Validate();
            }
            if (this.FlexVolume != null)
            {
                this.FlexVolume.Validate();
            }
            if (this.GcePersistentDisk != null)
            {
                this.GcePersistentDisk.Validate();
            }
            if (this.Glusterfs != null)
            {
                this.Glusterfs.Validate();
            }
            if (this.HostPath != null)
            {
                this.HostPath.Validate();
            }
            if (this.Iscsi != null)
            {
                this.Iscsi.Validate();
            }
            if (this.Local != null)
            {
                this.Local.Validate();
            }
            if (this.Nfs != null)
            {
                this.Nfs.Validate();
            }
            if (this.PhotonPersistentDisk != null)
            {
                this.PhotonPersistentDisk.Validate();
            }
            if (this.PortworxVolume != null)
            {
                this.PortworxVolume.Validate();
            }
            if (this.Quobyte != null)
            {
                this.Quobyte.Validate();
            }
            if (this.Rbd != null)
            {
                this.Rbd.Validate();
            }
            if (this.ScaleIO != null)
            {
                this.ScaleIO.Validate();
            }
            if (this.VsphereVolume != null)
            {
                this.VsphereVolume.Validate();
            }
        }
    }
}