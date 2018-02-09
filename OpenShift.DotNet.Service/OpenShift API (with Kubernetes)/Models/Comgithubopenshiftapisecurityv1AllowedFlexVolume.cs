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
    /// AllowedFlexVolume represents a single Flexvolume that is allowed to be
    /// used.
    /// </summary>
    public partial class Comgithubopenshiftapisecurityv1AllowedFlexVolume
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapisecurityv1AllowedFlexVolume class.
        /// </summary>
        public Comgithubopenshiftapisecurityv1AllowedFlexVolume() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapisecurityv1AllowedFlexVolume class.
        /// </summary>
        public Comgithubopenshiftapisecurityv1AllowedFlexVolume(string driver = default(string))
        {
            Driver = driver;
        }

        /// <summary>
        /// Driver is the name of the Flexvolume driver.
        /// </summary>
        [JsonProperty(PropertyName = "driver")]
        public string Driver { get; set; }

    }
}