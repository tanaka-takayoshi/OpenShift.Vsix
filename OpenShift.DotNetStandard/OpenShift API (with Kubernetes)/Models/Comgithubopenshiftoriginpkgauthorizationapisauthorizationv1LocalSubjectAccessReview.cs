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
    /// LocalSubjectAccessReview is an object for requesting information about
    /// whether a user or group can perform an action in a particular
    /// namespace
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgauthorizationapisauthorizationv1LocalSubjectAccessReview
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgauthorizationapisauthorizationv1LocalSubjectAccessReview
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgauthorizationapisauthorizationv1LocalSubjectAccessReview() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgauthorizationapisauthorizationv1LocalSubjectAccessReview
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgauthorizationapisauthorizationv1LocalSubjectAccessReview(IList<string> groups, bool isNonResourceURL, string namespaceProperty, string path, string resource, string resourceAPIGroup, string resourceAPIVersion, string resourceName, IList<string> scopes, string user, string verb, string apiVersion = default(string), Iok8sapimachinerypkgruntimeRawExtension content = default(Iok8sapimachinerypkgruntimeRawExtension), string kind = default(string))
        {
            ApiVersion = apiVersion;
            Content = content;
            Groups = groups;
            IsNonResourceURL = isNonResourceURL;
            Kind = kind;
            NamespaceProperty = namespaceProperty;
            Path = path;
            Resource = resource;
            ResourceAPIGroup = resourceAPIGroup;
            ResourceAPIVersion = resourceAPIVersion;
            ResourceName = resourceName;
            Scopes = scopes;
            User = user;
            Verb = verb;
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
        /// Content is the actual content of the request for create and update
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public Iok8sapimachinerypkgruntimeRawExtension Content { get; set; }

        /// <summary>
        /// Groups is optional.  Groups is the list of groups to which the
        /// User belongs.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<string> Groups { get; set; }

        /// <summary>
        /// IsNonResourceURL is true if this is a request for a non-resource
        /// URL (outside of the resource hieraarchy)
        /// </summary>
        [JsonProperty(PropertyName = "isNonResourceURL")]
        public bool IsNonResourceURL { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object
        /// represents. Servers may infer this from the endpoint the client
        /// submits requests to. Cannot be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Namespace is the namespace of the action being requested.
        /// Currently, there is no distinction between no namespace and all
        /// namespaces
        /// </summary>
        [JsonProperty(PropertyName = "namespace")]
        public string NamespaceProperty { get; set; }

        /// <summary>
        /// Path is the path of a non resource URL
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Resource is one of the existing resource types
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Group is the API group of the resource Serialized as
        /// resourceAPIGroup to avoid confusion with the 'groups' field when
        /// inlined
        /// </summary>
        [JsonProperty(PropertyName = "resourceAPIGroup")]
        public string ResourceAPIGroup { get; set; }

        /// <summary>
        /// Version is the API version of the resource Serialized as
        /// resourceAPIVersion to avoid confusion with TypeMeta.apiVersion
        /// and ObjectMeta.resourceVersion when inlined
        /// </summary>
        [JsonProperty(PropertyName = "resourceAPIVersion")]
        public string ResourceAPIVersion { get; set; }

        /// <summary>
        /// ResourceName is the name of the resource being requested for a
        /// "get" or deleted for a "delete"
        /// </summary>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }

        /// <summary>
        /// Scopes to use for the evaluation.  Empty means "use the unscoped
        /// (full) permissions of the user/groups". Nil for a self-SAR, means
        /// "use the scopes on this request". Nil for a regular SAR, means
        /// the same as empty.
        /// </summary>
        [JsonProperty(PropertyName = "scopes")]
        public IList<string> Scopes { get; set; }

        /// <summary>
        /// User is optional.  If both User and Groups are empty, the current
        /// authenticated user is used.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        /// <summary>
        /// Verb is one of: get, list, watch, create, update, delete
        /// </summary>
        [JsonProperty(PropertyName = "verb")]
        public string Verb { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Groups == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Groups");
            }
            if (NamespaceProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NamespaceProperty");
            }
            if (Path == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Path");
            }
            if (Resource == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Resource");
            }
            if (ResourceAPIGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceAPIGroup");
            }
            if (ResourceAPIVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceAPIVersion");
            }
            if (ResourceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceName");
            }
            if (Scopes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Scopes");
            }
            if (User == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "User");
            }
            if (Verb == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Verb");
            }
            if (this.Content != null)
            {
                this.Content.Validate();
            }
        }
    }
}
