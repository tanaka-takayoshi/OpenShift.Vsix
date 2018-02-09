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
    /// OAuthAuthorizeToken describes an OAuth authorization token
    /// </summary>
    public partial class Comgithubopenshiftapioauthv1OAuthAuthorizeToken
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapioauthv1OAuthAuthorizeToken class.
        /// </summary>
        public Comgithubopenshiftapioauthv1OAuthAuthorizeToken() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapioauthv1OAuthAuthorizeToken class.
        /// </summary>
        public Comgithubopenshiftapioauthv1OAuthAuthorizeToken(string apiVersion = default(string), string clientName = default(string), string codeChallenge = default(string), string codeChallengeMethod = default(string), long? expiresIn = default(long?), string kind = default(string), Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta), string redirectURI = default(string), IList<string> scopes = default(IList<string>), string state = default(string), string userName = default(string), string userUID = default(string))
        {
            ApiVersion = apiVersion;
            ClientName = clientName;
            CodeChallenge = codeChallenge;
            CodeChallengeMethod = codeChallengeMethod;
            ExpiresIn = expiresIn;
            Kind = kind;
            Metadata = metadata;
            RedirectURI = redirectURI;
            Scopes = scopes;
            State = state;
            UserName = userName;
            UserUID = userUID;
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
        /// ClientName references the client that created this token.
        /// </summary>
        [JsonProperty(PropertyName = "clientName")]
        public string ClientName { get; set; }

        /// <summary>
        /// CodeChallenge is the optional code_challenge associated with this
        /// authorization code, as described in rfc7636
        /// </summary>
        [JsonProperty(PropertyName = "codeChallenge")]
        public string CodeChallenge { get; set; }

        /// <summary>
        /// CodeChallengeMethod is the optional code_challenge_method
        /// associated with this authorization code, as described in rfc7636
        /// </summary>
        [JsonProperty(PropertyName = "codeChallengeMethod")]
        public string CodeChallengeMethod { get; set; }

        /// <summary>
        /// ExpiresIn is the seconds from CreationTime before this token
        /// expires.
        /// </summary>
        [JsonProperty(PropertyName = "expiresIn")]
        public long? ExpiresIn { get; set; }

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
        /// RedirectURI is the redirection associated with the token.
        /// </summary>
        [JsonProperty(PropertyName = "redirectURI")]
        public string RedirectURI { get; set; }

        /// <summary>
        /// Scopes is an array of the requested scopes.
        /// </summary>
        [JsonProperty(PropertyName = "scopes")]
        public IList<string> Scopes { get; set; }

        /// <summary>
        /// State data from request
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// UserName is the user name associated with this token
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// UserUID is the unique UID associated with this token. UserUID and
        /// UserName must both match for this token to be valid.
        /// </summary>
        [JsonProperty(PropertyName = "userUID")]
        public string UserUID { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Metadata != null)
            {
                this.Metadata.Validate();
            }
        }
    }
}