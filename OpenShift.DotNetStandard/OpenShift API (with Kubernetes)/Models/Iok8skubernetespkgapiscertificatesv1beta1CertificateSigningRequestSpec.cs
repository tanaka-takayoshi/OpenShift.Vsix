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
    /// This information is immutable after the request is created. Only the
    /// Request and Usages fields can be set on creation, other fields are
    /// derived by Kubernetes and cannot be modified by users.
    /// </summary>
    public partial class Iok8skubernetespkgapiscertificatesv1beta1CertificateSigningRequestSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiscertificatesv1beta1CertificateSigningRequestSpec
        /// class.
        /// </summary>
        public Iok8skubernetespkgapiscertificatesv1beta1CertificateSigningRequestSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiscertificatesv1beta1CertificateSigningRequestSpec
        /// class.
        /// </summary>
        public Iok8skubernetespkgapiscertificatesv1beta1CertificateSigningRequestSpec(byte[] request, IDictionary<string, IList<string>> extra = default(IDictionary<string, IList<string>>), IList<string> groups = default(IList<string>), string uid = default(string), IList<string> usages = default(IList<string>), string username = default(string))
        {
            Extra = extra;
            Groups = groups;
            Request = request;
            Uid = uid;
            Usages = usages;
            Username = username;
        }

        /// <summary>
        /// Extra information about the requesting user. See user.Info
        /// interface for details.
        /// </summary>
        [JsonProperty(PropertyName = "extra")]
        public IDictionary<string, IList<string>> Extra { get; set; }

        /// <summary>
        /// Group information about the requesting user. See user.Info
        /// interface for details.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<string> Groups { get; set; }

        /// <summary>
        /// Base64-encoded PKCS#10 CSR data
        /// </summary>
        [JsonProperty(PropertyName = "request")]
        public byte[] Request { get; set; }

        /// <summary>
        /// UID information about the requesting user. See user.Info interface
        /// for details.
        /// </summary>
        [JsonProperty(PropertyName = "uid")]
        public string Uid { get; set; }

        /// <summary>
        /// allowedUsages specifies a set of usage contexts the key will be
        /// valid for. See:
        /// https://tools.ietf.org/html/rfc5280#section-4.2.1.3
        /// https://tools.ietf.org/html/rfc5280#section-4.2.1.12
        /// </summary>
        [JsonProperty(PropertyName = "usages")]
        public IList<string> Usages { get; set; }

        /// <summary>
        /// Information about the requesting user. See user.Info interface for
        /// details.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Request == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Request");
            }
        }
    }
}
