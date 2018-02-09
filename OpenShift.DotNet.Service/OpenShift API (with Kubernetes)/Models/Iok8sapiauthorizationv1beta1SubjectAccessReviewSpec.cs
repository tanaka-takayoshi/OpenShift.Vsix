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
    /// SubjectAccessReviewSpec is a description of the access request.
    /// Exactly one of ResourceAuthorizationAttributes and
    /// NonResourceAuthorizationAttributes must be set
    /// </summary>
    public partial class Iok8sapiauthorizationv1beta1SubjectAccessReviewSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiauthorizationv1beta1SubjectAccessReviewSpec class.
        /// </summary>
        public Iok8sapiauthorizationv1beta1SubjectAccessReviewSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiauthorizationv1beta1SubjectAccessReviewSpec class.
        /// </summary>
        public Iok8sapiauthorizationv1beta1SubjectAccessReviewSpec(IDictionary<string, IList<string>> extra = default(IDictionary<string, IList<string>>), IList<string> group = default(IList<string>), Iok8sapiauthorizationv1beta1NonResourceAttributes nonResourceAttributes = default(Iok8sapiauthorizationv1beta1NonResourceAttributes), Iok8sapiauthorizationv1beta1ResourceAttributes resourceAttributes = default(Iok8sapiauthorizationv1beta1ResourceAttributes), string uid = default(string), string user = default(string))
        {
            Extra = extra;
            Group = group;
            NonResourceAttributes = nonResourceAttributes;
            ResourceAttributes = resourceAttributes;
            Uid = uid;
            User = user;
        }

        /// <summary>
        /// Extra corresponds to the user.Info.GetExtra() method from the
        /// authenticator.  Since that is input to the authorizer it needs a
        /// reflection here.
        /// </summary>
        [JsonProperty(PropertyName = "extra")]
        public IDictionary<string, IList<string>> Extra { get; set; }

        /// <summary>
        /// Groups is the groups you're testing for.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public IList<string> Group { get; set; }

        /// <summary>
        /// NonResourceAttributes describes information for a non-resource
        /// access request
        /// </summary>
        [JsonProperty(PropertyName = "nonResourceAttributes")]
        public Iok8sapiauthorizationv1beta1NonResourceAttributes NonResourceAttributes { get; set; }

        /// <summary>
        /// ResourceAuthorizationAttributes describes information for a
        /// resource access request
        /// </summary>
        [JsonProperty(PropertyName = "resourceAttributes")]
        public Iok8sapiauthorizationv1beta1ResourceAttributes ResourceAttributes { get; set; }

        /// <summary>
        /// UID information about the requesting user.
        /// </summary>
        [JsonProperty(PropertyName = "uid")]
        public string Uid { get; set; }

        /// <summary>
        /// User is the user you're testing for. If you specify "User" but not
        /// "Group", then is it interpreted as "What if User were not a
        /// member of any groups
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

    }
}