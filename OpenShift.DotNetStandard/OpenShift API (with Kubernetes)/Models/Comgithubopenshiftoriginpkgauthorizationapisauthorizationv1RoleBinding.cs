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
    /// RoleBinding references a Role, but not contain it.  It can reference
    /// any Role in the same namespace or in the global namespace. It adds
    /// who information via (Users and Groups) OR Subjects and namespace
    /// information by which namespace it exists in. RoleBindings in a given
    /// namespace only have effect in that namespace (excepting the master
    /// namespace which has power in all namespaces).
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgauthorizationapisauthorizationv1RoleBinding
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgauthorizationapisauthorizationv1RoleBinding
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgauthorizationapisauthorizationv1RoleBinding() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgauthorizationapisauthorizationv1RoleBinding
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgauthorizationapisauthorizationv1RoleBinding(IList<string> groupNames, Iok8skubernetespkgapiv1ObjectReference roleRef, IList<Iok8skubernetespkgapiv1ObjectReference> subjects, IList<string> userNames, string apiVersion = default(string), string kind = default(string), Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta))
        {
            ApiVersion = apiVersion;
            GroupNames = groupNames;
            Kind = kind;
            Metadata = metadata;
            RoleRef = roleRef;
            Subjects = subjects;
            UserNames = userNames;
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
        /// GroupNames holds all the groups directly bound to the role. This
        /// field should only be specified when supporting legacy clients and
        /// servers. See Subjects for further details.
        /// </summary>
        [JsonProperty(PropertyName = "groupNames")]
        public IList<string> GroupNames { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object
        /// represents. Servers may infer this from the endpoint the client
        /// submits requests to. Cannot be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Standard object's metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// RoleRef can only reference the current namespace and the global
        /// namespace. If the RoleRef cannot be resolved, the Authorizer must
        /// return an error. Since Policy is a singleton, this is sufficient
        /// knowledge to locate a role.
        /// </summary>
        [JsonProperty(PropertyName = "roleRef")]
        public Iok8skubernetespkgapiv1ObjectReference RoleRef { get; set; }

        /// <summary>
        /// Subjects hold object references to authorize with this rule. This
        /// field is ignored if UserNames or GroupNames are specified to
        /// support legacy clients and servers. Thus newer clients that do
        /// not need to support backwards compatibility should send only
        /// fully qualified Subjects and should omit the UserNames and
        /// GroupNames fields. Clients that need to support backwards
        /// compatibility can use this field to build the UserNames and
        /// GroupNames.
        /// </summary>
        [JsonProperty(PropertyName = "subjects")]
        public IList<Iok8skubernetespkgapiv1ObjectReference> Subjects { get; set; }

        /// <summary>
        /// UserNames holds all the usernames directly bound to the role. This
        /// field should only be specified when supporting legacy clients and
        /// servers. See Subjects for further details.
        /// </summary>
        [JsonProperty(PropertyName = "userNames")]
        public IList<string> UserNames { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (GroupNames == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GroupNames");
            }
            if (RoleRef == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RoleRef");
            }
            if (Subjects == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Subjects");
            }
            if (UserNames == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UserNames");
            }
            if (this.Metadata != null)
            {
                this.Metadata.Validate();
            }
        }
    }
}
