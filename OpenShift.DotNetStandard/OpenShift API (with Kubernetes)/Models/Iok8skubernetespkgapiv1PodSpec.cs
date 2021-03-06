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
    /// PodSpec is a description of a pod.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1PodSpec
    {
        /// <summary>
        /// Initializes a new instance of the Iok8skubernetespkgapiv1PodSpec
        /// class.
        /// </summary>
        public Iok8skubernetespkgapiv1PodSpec() { }

        /// <summary>
        /// Initializes a new instance of the Iok8skubernetespkgapiv1PodSpec
        /// class.
        /// </summary>
        public Iok8skubernetespkgapiv1PodSpec(IList<Iok8skubernetespkgapiv1Container> containers, long? activeDeadlineSeconds = default(long?), Iok8skubernetespkgapiv1Affinity affinity = default(Iok8skubernetespkgapiv1Affinity), bool? automountServiceAccountToken = default(bool?), string dnsPolicy = default(string), IList<Iok8skubernetespkgapiv1HostAlias> hostAliases = default(IList<Iok8skubernetespkgapiv1HostAlias>), bool? hostIPC = default(bool?), bool? hostNetwork = default(bool?), bool? hostPID = default(bool?), string hostname = default(string), IList<Iok8skubernetespkgapiv1LocalObjectReference> imagePullSecrets = default(IList<Iok8skubernetespkgapiv1LocalObjectReference>), IList<Iok8skubernetespkgapiv1Container> initContainers = default(IList<Iok8skubernetespkgapiv1Container>), string nodeName = default(string), IDictionary<string, string> nodeSelector = default(IDictionary<string, string>), string restartPolicy = default(string), string schedulerName = default(string), Iok8skubernetespkgapiv1PodSecurityContext securityContext = default(Iok8skubernetespkgapiv1PodSecurityContext), string serviceAccount = default(string), string serviceAccountName = default(string), string subdomain = default(string), long? terminationGracePeriodSeconds = default(long?), IList<Iok8skubernetespkgapiv1Toleration> tolerations = default(IList<Iok8skubernetespkgapiv1Toleration>), IList<Iok8skubernetespkgapiv1Volume> volumes = default(IList<Iok8skubernetespkgapiv1Volume>))
        {
            ActiveDeadlineSeconds = activeDeadlineSeconds;
            Affinity = affinity;
            AutomountServiceAccountToken = automountServiceAccountToken;
            Containers = containers;
            DnsPolicy = dnsPolicy;
            HostAliases = hostAliases;
            HostIPC = hostIPC;
            HostNetwork = hostNetwork;
            HostPID = hostPID;
            Hostname = hostname;
            ImagePullSecrets = imagePullSecrets;
            InitContainers = initContainers;
            NodeName = nodeName;
            NodeSelector = nodeSelector;
            RestartPolicy = restartPolicy;
            SchedulerName = schedulerName;
            SecurityContext = securityContext;
            ServiceAccount = serviceAccount;
            ServiceAccountName = serviceAccountName;
            Subdomain = subdomain;
            TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            Tolerations = tolerations;
            Volumes = volumes;
        }

        /// <summary>
        /// Optional duration in seconds the pod may be active on the node
        /// relative to StartTime before the system will actively try to mark
        /// it failed and kill associated containers. Value must be a
        /// positive integer.
        /// </summary>
        [JsonProperty(PropertyName = "activeDeadlineSeconds")]
        public long? ActiveDeadlineSeconds { get; set; }

        /// <summary>
        /// If specified, the pod's scheduling constraints
        /// </summary>
        [JsonProperty(PropertyName = "affinity")]
        public Iok8skubernetespkgapiv1Affinity Affinity { get; set; }

        /// <summary>
        /// AutomountServiceAccountToken indicates whether a service account
        /// token should be automatically mounted.
        /// </summary>
        [JsonProperty(PropertyName = "automountServiceAccountToken")]
        public bool? AutomountServiceAccountToken { get; set; }

        /// <summary>
        /// List of containers belonging to the pod. Containers cannot
        /// currently be added or removed. There must be at least one
        /// container in a Pod. Cannot be updated.
        /// </summary>
        [JsonProperty(PropertyName = "containers")]
        public IList<Iok8skubernetespkgapiv1Container> Containers { get; set; }

        /// <summary>
        /// Set DNS policy for containers within the pod. One of
        /// 'ClusterFirstWithHostNet', 'ClusterFirst' or 'Default'. Defaults
        /// to "ClusterFirst". To have DNS options set along with
        /// hostNetwork, you have to specify DNS policy explicitly to
        /// 'ClusterFirstWithHostNet'.
        /// </summary>
        [JsonProperty(PropertyName = "dnsPolicy")]
        public string DnsPolicy { get; set; }

        /// <summary>
        /// HostAliases is an optional list of hosts and IPs that will be
        /// injected into the pod's hosts file if specified. This is only
        /// valid for non-hostNetwork pods.
        /// </summary>
        [JsonProperty(PropertyName = "hostAliases")]
        public IList<Iok8skubernetespkgapiv1HostAlias> HostAliases { get; set; }

        /// <summary>
        /// Use the host's ipc namespace. Optional: Default to false.
        /// </summary>
        [JsonProperty(PropertyName = "hostIPC")]
        public bool? HostIPC { get; set; }

        /// <summary>
        /// Host networking requested for this pod. Use the host's network
        /// namespace. If this option is set, the ports that will be used
        /// must be specified. Default to false.
        /// </summary>
        [JsonProperty(PropertyName = "hostNetwork")]
        public bool? HostNetwork { get; set; }

        /// <summary>
        /// Use the host's pid namespace. Optional: Default to false.
        /// </summary>
        [JsonProperty(PropertyName = "hostPID")]
        public bool? HostPID { get; set; }

        /// <summary>
        /// Specifies the hostname of the Pod If not specified, the pod's
        /// hostname will be set to a system-defined value.
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// ImagePullSecrets is an optional list of references to secrets in
        /// the same namespace to use for pulling any of the images used by
        /// this PodSpec. If specified, these secrets will be passed to
        /// individual puller implementations for them to use. For example,
        /// in the case of docker, only DockerConfig type secrets are
        /// honored. More info:
        /// https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod
        /// </summary>
        [JsonProperty(PropertyName = "imagePullSecrets")]
        public IList<Iok8skubernetespkgapiv1LocalObjectReference> ImagePullSecrets { get; set; }

        /// <summary>
        /// List of initialization containers belonging to the pod. Init
        /// containers are executed in order prior to containers being
        /// started. If any init container fails, the pod is considered to
        /// have failed and is handled according to its restartPolicy. The
        /// name for an init container or normal container must be unique
        /// among all containers. Init containers may not have Lifecycle
        /// actions, Readiness probes, or Liveness probes. The
        /// resourceRequirements of an init container are taken into account
        /// during scheduling by finding the highest request/limit for each
        /// resource type, and then using the max of of that value or the sum
        /// of the normal containers. Limits are applied to init containers
        /// in a similar fashion. Init containers cannot currently be added
        /// or removed. Cannot be updated. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/init-containers/
        /// </summary>
        [JsonProperty(PropertyName = "initContainers")]
        public IList<Iok8skubernetespkgapiv1Container> InitContainers { get; set; }

        /// <summary>
        /// NodeName is a request to schedule this pod onto a specific node.
        /// If it is non-empty, the scheduler simply schedules this pod onto
        /// that node, assuming that it fits resource requirements.
        /// </summary>
        [JsonProperty(PropertyName = "nodeName")]
        public string NodeName { get; set; }

        /// <summary>
        /// NodeSelector is a selector which must be true for the pod to fit
        /// on a node. Selector which must match a node's labels for the pod
        /// to be scheduled on that node. More info:
        /// https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
        /// </summary>
        [JsonProperty(PropertyName = "nodeSelector")]
        public IDictionary<string, string> NodeSelector { get; set; }

        /// <summary>
        /// Restart policy for all containers within the pod. One of Always,
        /// OnFailure, Never. Default to Always. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#restart-policy
        /// </summary>
        [JsonProperty(PropertyName = "restartPolicy")]
        public string RestartPolicy { get; set; }

        /// <summary>
        /// If specified, the pod will be dispatched by specified scheduler.
        /// If not specified, the pod will be dispatched by default scheduler.
        /// </summary>
        [JsonProperty(PropertyName = "schedulerName")]
        public string SchedulerName { get; set; }

        /// <summary>
        /// SecurityContext holds pod-level security attributes and common
        /// container settings. Optional: Defaults to empty.  See type
        /// description for default values of each field.
        /// </summary>
        [JsonProperty(PropertyName = "securityContext")]
        public Iok8skubernetespkgapiv1PodSecurityContext SecurityContext { get; set; }

        /// <summary>
        /// DeprecatedServiceAccount is a depreciated alias for
        /// ServiceAccountName. Deprecated: Use serviceAccountName instead.
        /// </summary>
        [JsonProperty(PropertyName = "serviceAccount")]
        public string ServiceAccount { get; set; }

        /// <summary>
        /// ServiceAccountName is the name of the ServiceAccount to use to run
        /// this pod. More info:
        /// https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/
        /// </summary>
        [JsonProperty(PropertyName = "serviceAccountName")]
        public string ServiceAccountName { get; set; }

        /// <summary>
        /// If specified, the fully qualified Pod hostname will be
        /// "&lt;hostname&gt;.&lt;subdomain&gt;.&lt;pod
        /// namespace&gt;.svc.&lt;cluster domain&gt;". If not specified, the
        /// pod will not have a domainname at all.
        /// </summary>
        [JsonProperty(PropertyName = "subdomain")]
        public string Subdomain { get; set; }

        /// <summary>
        /// Optional duration in seconds the pod needs to terminate
        /// gracefully. May be decreased in delete request. Value must be
        /// non-negative integer. The value zero indicates delete
        /// immediately. If this value is nil, the default grace period will
        /// be used instead. The grace period is the duration in seconds
        /// after the processes running in the pod are sent a termination
        /// signal and the time when the processes are forcibly halted with a
        /// kill signal. Set this value longer than the expected cleanup time
        /// for your process. Defaults to 30 seconds.
        /// </summary>
        [JsonProperty(PropertyName = "terminationGracePeriodSeconds")]
        public long? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// If specified, the pod's tolerations.
        /// </summary>
        [JsonProperty(PropertyName = "tolerations")]
        public IList<Iok8skubernetespkgapiv1Toleration> Tolerations { get; set; }

        /// <summary>
        /// List of volumes that can be mounted by containers belonging to the
        /// pod. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes
        /// </summary>
        [JsonProperty(PropertyName = "volumes")]
        public IList<Iok8skubernetespkgapiv1Volume> Volumes { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Containers == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Containers");
            }
            if (this.Affinity != null)
            {
                this.Affinity.Validate();
            }
            if (this.Containers != null)
            {
                foreach (var element in this.Containers)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.InitContainers != null)
            {
                foreach (var element1 in this.InitContainers)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.Volumes != null)
            {
                foreach (var element2 in this.Volumes)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
