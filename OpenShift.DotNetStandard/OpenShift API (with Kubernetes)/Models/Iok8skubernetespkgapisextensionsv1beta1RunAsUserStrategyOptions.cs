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
    /// Run A sUser Strategy Options defines the strategy type and any options
    /// used to create the strategy.
    /// </summary>
    public partial class Iok8skubernetespkgapisextensionsv1beta1RunAsUserStrategyOptions
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisextensionsv1beta1RunAsUserStrategyOptions
        /// class.
        /// </summary>
        public Iok8skubernetespkgapisextensionsv1beta1RunAsUserStrategyOptions() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisextensionsv1beta1RunAsUserStrategyOptions
        /// class.
        /// </summary>
        public Iok8skubernetespkgapisextensionsv1beta1RunAsUserStrategyOptions(string rule, IList<Iok8skubernetespkgapisextensionsv1beta1IDRange> ranges = default(IList<Iok8skubernetespkgapisextensionsv1beta1IDRange>))
        {
            Ranges = ranges;
            Rule = rule;
        }

        /// <summary>
        /// Ranges are the allowed ranges of uids that may be used.
        /// </summary>
        [JsonProperty(PropertyName = "ranges")]
        public IList<Iok8skubernetespkgapisextensionsv1beta1IDRange> Ranges { get; set; }

        /// <summary>
        /// Rule is the strategy that will dictate the allowable RunAsUser
        /// values that may be set.
        /// </summary>
        [JsonProperty(PropertyName = "rule")]
        public string Rule { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Rule == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Rule");
            }
            if (this.Ranges != null)
            {
                foreach (var element in this.Ranges)
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
