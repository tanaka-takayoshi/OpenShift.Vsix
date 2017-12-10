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
    /// FSGroupStrategyOptions defines the strategy type and options used to
    /// create the strategy.
    /// </summary>
    public partial class Iok8skubernetespkgapisextensionsv1beta1FSGroupStrategyOptions
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisextensionsv1beta1FSGroupStrategyOptions
        /// class.
        /// </summary>
        public Iok8skubernetespkgapisextensionsv1beta1FSGroupStrategyOptions() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisextensionsv1beta1FSGroupStrategyOptions
        /// class.
        /// </summary>
        public Iok8skubernetespkgapisextensionsv1beta1FSGroupStrategyOptions(IList<Iok8skubernetespkgapisextensionsv1beta1IDRange> ranges = default(IList<Iok8skubernetespkgapisextensionsv1beta1IDRange>), string rule = default(string))
        {
            Ranges = ranges;
            Rule = rule;
        }

        /// <summary>
        /// Ranges are the allowed ranges of fs groups.  If you would like to
        /// force a single fs group then supply a single range with the same
        /// start and end.
        /// </summary>
        [JsonProperty(PropertyName = "ranges")]
        public IList<Iok8skubernetespkgapisextensionsv1beta1IDRange> Ranges { get; set; }

        /// <summary>
        /// Rule is the strategy that will dictate what FSGroup is used in the
        /// SecurityContext.
        /// </summary>
        [JsonProperty(PropertyName = "rule")]
        public string Rule { get; set; }

    }
}
