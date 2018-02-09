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
    /// ClusterRoleBinding references a ClusterRole, but not contain it.  It
    /// can reference a ClusterRole in the global namespace, and adds who
    /// information via Subject.
    /// </summary>
    public partial class Iok8sapirbacv1beta1ClusterRoleBinding
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapirbacv1beta1ClusterRoleBinding class.
        /// </summary>
        public Iok8sapirbacv1beta1ClusterRoleBinding() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapirbacv1beta1ClusterRoleBinding class.
        /// </summary>
        public Iok8sapirbacv1beta1ClusterRoleBinding(Iok8sapirbacv1beta1RoleRef roleRef, IList<Iok8sapirbacv1beta1Subject> subjects, string apiVersion = default(string), string kind = default(string), Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            RoleRef = roleRef;
            Subjects = subjects;
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
        /// RoleRef can only reference a ClusterRole in the global namespace.
        /// If the RoleRef cannot be resolved, the Authorizer must return an
        /// error.
        /// </summary>
        [JsonProperty(PropertyName = "roleRef")]
        public Iok8sapirbacv1beta1RoleRef RoleRef { get; set; }

        /// <summary>
        /// Subjects holds references to the objects the role applies to.
        /// </summary>
        [JsonProperty(PropertyName = "subjects")]
        public IList<Iok8sapirbacv1beta1Subject> Subjects { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (RoleRef == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RoleRef");
            }
            if (Subjects == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Subjects");
            }
            if (this.Metadata != null)
            {
                this.Metadata.Validate();
            }
            if (this.RoleRef != null)
            {
                this.RoleRef.Validate();
            }
            if (this.Subjects != null)
            {
                foreach (var element in this.Subjects)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}