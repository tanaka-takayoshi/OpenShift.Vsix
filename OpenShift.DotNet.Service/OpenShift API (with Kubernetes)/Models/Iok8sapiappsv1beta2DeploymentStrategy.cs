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
    /// DeploymentStrategy describes how to replace existing pods with new
    /// ones.
    /// </summary>
    public partial class Iok8sapiappsv1beta2DeploymentStrategy
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiappsv1beta2DeploymentStrategy class.
        /// </summary>
        public Iok8sapiappsv1beta2DeploymentStrategy() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiappsv1beta2DeploymentStrategy class.
        /// </summary>
        public Iok8sapiappsv1beta2DeploymentStrategy(Iok8sapiappsv1beta2RollingUpdateDeployment rollingUpdate = default(Iok8sapiappsv1beta2RollingUpdateDeployment), string type = default(string))
        {
            RollingUpdate = rollingUpdate;
            Type = type;
        }

        /// <summary>
        /// Rolling update config params. Present only if
        /// DeploymentStrategyType = RollingUpdate.
        /// </summary>
        [JsonProperty(PropertyName = "rollingUpdate")]
        public Iok8sapiappsv1beta2RollingUpdateDeployment RollingUpdate { get; set; }

        /// <summary>
        /// Type of deployment. Can be "Recreate" or "RollingUpdate". Default
        /// is RollingUpdate.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
