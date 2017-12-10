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
    /// RouteSpec describes the hostname or path the route exposes, any
    /// security information, and one to four backends (services) the route
    /// points to. Requests are distributed among the backends depending on
    /// the weights assigned to each backend. When using roundrobin
    /// scheduling the portion of requests that go to each backend is the
    /// backend weight divided by the sum of all of the backend weights. When
    /// the backend has more than one endpoint the requests that end up on
    /// the backend are roundrobin distributed among the endpoints. Weights
    /// are between 0 and 256 with default 1. Weight 0 causes no requests to
    /// the backend. If all weights are zero the route will be considered to
    /// have no backends and return a standard 503 response.
    /// 
    /// The `tls` field is optional and allows specific certificates or
    /// behavior for the route. Routers typically configure a default
    /// certificate on a wildcard domain to terminate routes without explicit
    /// certificates, but custom hostnames usually must choose passthrough
    /// (send traffic directly to the backend via the TLS Server-Name-
    /// Indication field) or provide a certificate.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgrouteapisroutev1RouteSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgrouteapisroutev1RouteSpec class.
        /// </summary>
        public Comgithubopenshiftoriginpkgrouteapisroutev1RouteSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgrouteapisroutev1RouteSpec class.
        /// </summary>
        public Comgithubopenshiftoriginpkgrouteapisroutev1RouteSpec(string host, Comgithubopenshiftoriginpkgrouteapisroutev1RouteTargetReference to, IList<Comgithubopenshiftoriginpkgrouteapisroutev1RouteTargetReference> alternateBackends = default(IList<Comgithubopenshiftoriginpkgrouteapisroutev1RouteTargetReference>), string path = default(string), Comgithubopenshiftoriginpkgrouteapisroutev1RoutePort port = default(Comgithubopenshiftoriginpkgrouteapisroutev1RoutePort), Comgithubopenshiftoriginpkgrouteapisroutev1TLSConfig tls = default(Comgithubopenshiftoriginpkgrouteapisroutev1TLSConfig), string wildcardPolicy = default(string))
        {
            AlternateBackends = alternateBackends;
            Host = host;
            Path = path;
            Port = port;
            Tls = tls;
            To = to;
            WildcardPolicy = wildcardPolicy;
        }

        /// <summary>
        /// alternateBackends allows up to 3 additional backends to be
        /// assigned to the route. Only the Service kind is allowed, and it
        /// will be defaulted to Service. Use the weight field in
        /// RouteTargetReference object to specify relative preference.
        /// </summary>
        [JsonProperty(PropertyName = "alternateBackends")]
        public IList<Comgithubopenshiftoriginpkgrouteapisroutev1RouteTargetReference> AlternateBackends { get; set; }

        /// <summary>
        /// host is an alias/DNS that points to the service. Optional. If not
        /// specified a route name will typically be automatically chosen.
        /// Must follow DNS952 subdomain conventions.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }

        /// <summary>
        /// Path that the router watches for, to route traffic for to the
        /// service. Optional
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// If specified, the port to be used by the router. Most routers will
        /// use all endpoints exposed by the service by default - set this
        /// value to instruct routers which port to use.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public Comgithubopenshiftoriginpkgrouteapisroutev1RoutePort Port { get; set; }

        /// <summary>
        /// The tls field provides the ability to configure certificates and
        /// termination for the route.
        /// </summary>
        [JsonProperty(PropertyName = "tls")]
        public Comgithubopenshiftoriginpkgrouteapisroutev1TLSConfig Tls { get; set; }

        /// <summary>
        /// to is an object the route should use as the primary backend. Only
        /// the Service kind is allowed, and it will be defaulted to Service.
        /// If the weight field (0-256 default 1) is set to zero, no traffic
        /// will be sent to this backend.
        /// </summary>
        [JsonProperty(PropertyName = "to")]
        public Comgithubopenshiftoriginpkgrouteapisroutev1RouteTargetReference To { get; set; }

        /// <summary>
        /// Wildcard policy if any for the route. Currently only 'Subdomain'
        /// or 'None' is allowed.
        /// </summary>
        [JsonProperty(PropertyName = "wildcardPolicy")]
        public string WildcardPolicy { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Host == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Host");
            }
            if (To == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "To");
            }
            if (this.AlternateBackends != null)
            {
                foreach (var element in this.AlternateBackends)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.Port != null)
            {
                this.Port.Validate();
            }
            if (this.Tls != null)
            {
                this.Tls.Validate();
            }
            if (this.To != null)
            {
                this.To.Validate();
            }
        }
    }
}
