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
    /// ImageChangeTrigger allows builds to be triggered when an ImageStream
    /// changes
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgbuildapisbuildv1ImageChangeTrigger
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1ImageChangeTrigger
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1ImageChangeTrigger() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgbuildapisbuildv1ImageChangeTrigger
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgbuildapisbuildv1ImageChangeTrigger(Iok8skubernetespkgapiv1ObjectReference fromProperty = default(Iok8skubernetespkgapiv1ObjectReference), string lastTriggeredImageID = default(string))
        {
            FromProperty = fromProperty;
            LastTriggeredImageID = lastTriggeredImageID;
        }

        /// <summary>
        /// from is a reference to an ImageStreamTag that will trigger a build
        /// when updated It is optional. If no From is specified, the From
        /// image from the build strategy will be used. Only one
        /// ImageChangeTrigger with an empty From reference is allowed in a
        /// build configuration.
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public Iok8skubernetespkgapiv1ObjectReference FromProperty { get; set; }

        /// <summary>
        /// lastTriggeredImageID is used internally by the
        /// ImageChangeController to save last used image ID for build
        /// </summary>
        [JsonProperty(PropertyName = "lastTriggeredImageID")]
        public string LastTriggeredImageID { get; set; }

    }
}
