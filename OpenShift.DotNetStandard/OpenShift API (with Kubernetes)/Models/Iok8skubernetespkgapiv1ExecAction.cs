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
    /// ExecAction describes a "run in container" action.
    /// </summary>
    public partial class Iok8skubernetespkgapiv1ExecAction
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1ExecAction class.
        /// </summary>
        public Iok8skubernetespkgapiv1ExecAction() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1ExecAction class.
        /// </summary>
        public Iok8skubernetespkgapiv1ExecAction(IList<string> command = default(IList<string>))
        {
            Command = command;
        }

        /// <summary>
        /// Command is the command line to execute inside the container, the
        /// working directory for the command  is root ('/') in the
        /// container's filesystem. The command is simply exec'd, it is not
        /// run inside a shell, so traditional shell instructions ('|', etc)
        /// won't work. To use a shell, you need to explicitly call out to
        /// that shell. Exit status of 0 is treated as live/healthy and
        /// non-zero is unhealthy.
        /// </summary>
        [JsonProperty(PropertyName = "command")]
        public IList<string> Command { get; set; }

    }
}
