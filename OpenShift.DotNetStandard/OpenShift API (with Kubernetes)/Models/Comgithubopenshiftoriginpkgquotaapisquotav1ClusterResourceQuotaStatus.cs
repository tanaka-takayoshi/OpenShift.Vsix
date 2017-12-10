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
    /// ClusterResourceQuotaStatus defines the actual enforced quota and its
    /// current usage
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgquotaapisquotav1ClusterResourceQuotaStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgquotaapisquotav1ClusterResourceQuotaStatus
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgquotaapisquotav1ClusterResourceQuotaStatus() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgquotaapisquotav1ClusterResourceQuotaStatus
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgquotaapisquotav1ClusterResourceQuotaStatus(IList<Comgithubopenshiftoriginpkgquotaapisquotav1ResourceQuotaStatusByNamespace> namespaces, Iok8skubernetespkgapiv1ResourceQuotaStatus total)
        {
            Namespaces = namespaces;
            Total = total;
        }

        /// <summary>
        /// Namespaces slices the usage by project.  This division allows for
        /// quick resolution of deletion reconciliation inside of a single
        /// project without requiring a recalculation across all projects.
        /// This can be used to pull the deltas for a given project.
        /// </summary>
        [JsonProperty(PropertyName = "namespaces")]
        public IList<Comgithubopenshiftoriginpkgquotaapisquotav1ResourceQuotaStatusByNamespace> Namespaces { get; set; }

        /// <summary>
        /// Total defines the actual enforced quota and its current usage
        /// across all projects
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public Iok8skubernetespkgapiv1ResourceQuotaStatus Total { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Namespaces == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Namespaces");
            }
            if (Total == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Total");
            }
            if (this.Namespaces != null)
            {
                foreach (var element in this.Namespaces)
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
