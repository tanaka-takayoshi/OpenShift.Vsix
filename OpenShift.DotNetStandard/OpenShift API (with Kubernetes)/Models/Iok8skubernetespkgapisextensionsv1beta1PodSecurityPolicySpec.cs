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
    /// Pod Security Policy Spec defines the policy enforced.
    /// </summary>
    public partial class Iok8skubernetespkgapisextensionsv1beta1PodSecurityPolicySpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisextensionsv1beta1PodSecurityPolicySpec
        /// class.
        /// </summary>
        public Iok8skubernetespkgapisextensionsv1beta1PodSecurityPolicySpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisextensionsv1beta1PodSecurityPolicySpec
        /// class.
        /// </summary>
        public Iok8skubernetespkgapisextensionsv1beta1PodSecurityPolicySpec(Iok8skubernetespkgapisextensionsv1beta1FSGroupStrategyOptions fsGroup, Iok8skubernetespkgapisextensionsv1beta1RunAsUserStrategyOptions runAsUser, Iok8skubernetespkgapisextensionsv1beta1SELinuxStrategyOptions seLinux, Iok8skubernetespkgapisextensionsv1beta1SupplementalGroupsStrategyOptions supplementalGroups, IList<string> allowedCapabilities = default(IList<string>), IList<string> defaultAddCapabilities = default(IList<string>), bool? hostIPC = default(bool?), bool? hostNetwork = default(bool?), bool? hostPID = default(bool?), IList<Iok8skubernetespkgapisextensionsv1beta1HostPortRange> hostPorts = default(IList<Iok8skubernetespkgapisextensionsv1beta1HostPortRange>), bool? privileged = default(bool?), bool? readOnlyRootFilesystem = default(bool?), IList<string> requiredDropCapabilities = default(IList<string>), IList<string> volumes = default(IList<string>))
        {
            AllowedCapabilities = allowedCapabilities;
            DefaultAddCapabilities = defaultAddCapabilities;
            FsGroup = fsGroup;
            HostIPC = hostIPC;
            HostNetwork = hostNetwork;
            HostPID = hostPID;
            HostPorts = hostPorts;
            Privileged = privileged;
            ReadOnlyRootFilesystem = readOnlyRootFilesystem;
            RequiredDropCapabilities = requiredDropCapabilities;
            RunAsUser = runAsUser;
            SeLinux = seLinux;
            SupplementalGroups = supplementalGroups;
            Volumes = volumes;
        }

        /// <summary>
        /// AllowedCapabilities is a list of capabilities that can be
        /// requested to add to the container. Capabilities in this field may
        /// be added at the pod author's discretion. You must not list a
        /// capability in both AllowedCapabilities and
        /// RequiredDropCapabilities.
        /// </summary>
        [JsonProperty(PropertyName = "allowedCapabilities")]
        public IList<string> AllowedCapabilities { get; set; }

        /// <summary>
        /// DefaultAddCapabilities is the default set of capabilities that
        /// will be added to the container unless the pod spec specifically
        /// drops the capability.  You may not list a capabiility in both
        /// DefaultAddCapabilities and RequiredDropCapabilities.
        /// </summary>
        [JsonProperty(PropertyName = "defaultAddCapabilities")]
        public IList<string> DefaultAddCapabilities { get; set; }

        /// <summary>
        /// FSGroup is the strategy that will dictate what fs group is used by
        /// the SecurityContext.
        /// </summary>
        [JsonProperty(PropertyName = "fsGroup")]
        public Iok8skubernetespkgapisextensionsv1beta1FSGroupStrategyOptions FsGroup { get; set; }

        /// <summary>
        /// hostIPC determines if the policy allows the use of HostIPC in the
        /// pod spec.
        /// </summary>
        [JsonProperty(PropertyName = "hostIPC")]
        public bool? HostIPC { get; set; }

        /// <summary>
        /// hostNetwork determines if the policy allows the use of HostNetwork
        /// in the pod spec.
        /// </summary>
        [JsonProperty(PropertyName = "hostNetwork")]
        public bool? HostNetwork { get; set; }

        /// <summary>
        /// hostPID determines if the policy allows the use of HostPID in the
        /// pod spec.
        /// </summary>
        [JsonProperty(PropertyName = "hostPID")]
        public bool? HostPID { get; set; }

        /// <summary>
        /// hostPorts determines which host port ranges are allowed to be
        /// exposed.
        /// </summary>
        [JsonProperty(PropertyName = "hostPorts")]
        public IList<Iok8skubernetespkgapisextensionsv1beta1HostPortRange> HostPorts { get; set; }

        /// <summary>
        /// privileged determines if a pod can request to be run as privileged.
        /// </summary>
        [JsonProperty(PropertyName = "privileged")]
        public bool? Privileged { get; set; }

        /// <summary>
        /// ReadOnlyRootFilesystem when set to true will force containers to
        /// run with a read only root file system.  If the container
        /// specifically requests to run with a non-read only root file
        /// system the PSP should deny the pod. If set to false the container
        /// may run with a read only root file system if it wishes but it
        /// will not be forced to.
        /// </summary>
        [JsonProperty(PropertyName = "readOnlyRootFilesystem")]
        public bool? ReadOnlyRootFilesystem { get; set; }

        /// <summary>
        /// RequiredDropCapabilities are the capabilities that will be dropped
        /// from the container.  These are required to be dropped and cannot
        /// be added.
        /// </summary>
        [JsonProperty(PropertyName = "requiredDropCapabilities")]
        public IList<string> RequiredDropCapabilities { get; set; }

        /// <summary>
        /// runAsUser is the strategy that will dictate the allowable
        /// RunAsUser values that may be set.
        /// </summary>
        [JsonProperty(PropertyName = "runAsUser")]
        public Iok8skubernetespkgapisextensionsv1beta1RunAsUserStrategyOptions RunAsUser { get; set; }

        /// <summary>
        /// seLinux is the strategy that will dictate the allowable labels
        /// that may be set.
        /// </summary>
        [JsonProperty(PropertyName = "seLinux")]
        public Iok8skubernetespkgapisextensionsv1beta1SELinuxStrategyOptions SeLinux { get; set; }

        /// <summary>
        /// SupplementalGroups is the strategy that will dictate what
        /// supplemental groups are used by the SecurityContext.
        /// </summary>
        [JsonProperty(PropertyName = "supplementalGroups")]
        public Iok8skubernetespkgapisextensionsv1beta1SupplementalGroupsStrategyOptions SupplementalGroups { get; set; }

        /// <summary>
        /// volumes is a white list of allowed volume plugins.  Empty
        /// indicates that all plugins may be used.
        /// </summary>
        [JsonProperty(PropertyName = "volumes")]
        public IList<string> Volumes { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (FsGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FsGroup");
            }
            if (RunAsUser == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RunAsUser");
            }
            if (SeLinux == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SeLinux");
            }
            if (SupplementalGroups == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SupplementalGroups");
            }
            if (this.HostPorts != null)
            {
                foreach (var element in this.HostPorts)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.RunAsUser != null)
            {
                this.RunAsUser.Validate();
            }
            if (this.SeLinux != null)
            {
                this.SeLinux.Validate();
            }
        }
    }
}