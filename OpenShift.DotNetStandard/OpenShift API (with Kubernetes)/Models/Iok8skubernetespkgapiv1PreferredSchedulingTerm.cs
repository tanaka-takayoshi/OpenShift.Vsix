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
    /// An empty preferred scheduling term matches all objects with implicit
    /// weight 0 (i.e. it's a no-op). A null preferred scheduling term
    /// matches no objects (i.e. is also a no-op).
    /// </summary>
    public partial class Iok8skubernetespkgapiv1PreferredSchedulingTerm
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1PreferredSchedulingTerm class.
        /// </summary>
        public Iok8skubernetespkgapiv1PreferredSchedulingTerm() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapiv1PreferredSchedulingTerm class.
        /// </summary>
        public Iok8skubernetespkgapiv1PreferredSchedulingTerm(Iok8skubernetespkgapiv1NodeSelectorTerm preference, int weight)
        {
            Preference = preference;
            Weight = weight;
        }

        /// <summary>
        /// A node selector term, associated with the corresponding weight.
        /// </summary>
        [JsonProperty(PropertyName = "preference")]
        public Iok8skubernetespkgapiv1NodeSelectorTerm Preference { get; set; }

        /// <summary>
        /// Weight associated with matching the corresponding
        /// nodeSelectorTerm, in the range 1-100.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int Weight { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Preference == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Preference");
            }
            if (this.Preference != null)
            {
                this.Preference.Validate();
            }
        }
    }
}
