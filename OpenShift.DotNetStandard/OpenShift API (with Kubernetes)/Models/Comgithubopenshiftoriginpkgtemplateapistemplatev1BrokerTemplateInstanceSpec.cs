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
    /// BrokerTemplateInstanceSpec describes the state of a
    /// BrokerTemplateInstance.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgtemplateapistemplatev1BrokerTemplateInstanceSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgtemplateapistemplatev1BrokerTemplateInstanceSpec
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgtemplateapistemplatev1BrokerTemplateInstanceSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgtemplateapistemplatev1BrokerTemplateInstanceSpec
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgtemplateapistemplatev1BrokerTemplateInstanceSpec(Iok8skubernetespkgapiv1ObjectReference secret, Iok8skubernetespkgapiv1ObjectReference templateInstance, IList<string> bindingIDs = default(IList<string>))
        {
            BindingIDs = bindingIDs;
            Secret = secret;
            TemplateInstance = templateInstance;
        }

        /// <summary>
        /// bindingids is a list of 'binding_id's provided during successive
        /// bind calls to the template service broker.
        /// </summary>
        [JsonProperty(PropertyName = "bindingIDs")]
        public IList<string> BindingIDs { get; set; }

        /// <summary>
        /// secret is a reference to a Secret object residing in a namespace,
        /// containing the necessary template parameters.
        /// </summary>
        [JsonProperty(PropertyName = "secret")]
        public Iok8skubernetespkgapiv1ObjectReference Secret { get; set; }

        /// <summary>
        /// templateinstance is a reference to a TemplateInstance object
        /// residing in a namespace.
        /// </summary>
        [JsonProperty(PropertyName = "templateInstance")]
        public Iok8skubernetespkgapiv1ObjectReference TemplateInstance { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Secret == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Secret");
            }
            if (TemplateInstance == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TemplateInstance");
            }
        }
    }
}
