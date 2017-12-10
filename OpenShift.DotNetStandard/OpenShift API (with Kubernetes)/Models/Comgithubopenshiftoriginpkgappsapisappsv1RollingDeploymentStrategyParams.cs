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
    /// RollingDeploymentStrategyParams are the input to the Rolling
    /// deployment strategy.
    /// </summary>
    public partial class Comgithubopenshiftoriginpkgappsapisappsv1RollingDeploymentStrategyParams
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgappsapisappsv1RollingDeploymentStrategyParams
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgappsapisappsv1RollingDeploymentStrategyParams() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftoriginpkgappsapisappsv1RollingDeploymentStrategyParams
        /// class.
        /// </summary>
        public Comgithubopenshiftoriginpkgappsapisappsv1RollingDeploymentStrategyParams(long? intervalSeconds = default(long?), string maxSurge = default(string), string maxUnavailable = default(string), Comgithubopenshiftoriginpkgappsapisappsv1LifecycleHook post = default(Comgithubopenshiftoriginpkgappsapisappsv1LifecycleHook), Comgithubopenshiftoriginpkgappsapisappsv1LifecycleHook pre = default(Comgithubopenshiftoriginpkgappsapisappsv1LifecycleHook), long? timeoutSeconds = default(long?), long? updatePeriodSeconds = default(long?))
        {
            IntervalSeconds = intervalSeconds;
            MaxSurge = maxSurge;
            MaxUnavailable = maxUnavailable;
            Post = post;
            Pre = pre;
            TimeoutSeconds = timeoutSeconds;
            UpdatePeriodSeconds = updatePeriodSeconds;
        }

        /// <summary>
        /// IntervalSeconds is the time to wait between polling deployment
        /// status after update. If the value is nil, a default will be used.
        /// </summary>
        [JsonProperty(PropertyName = "intervalSeconds")]
        public long? IntervalSeconds { get; set; }

        /// <summary>
        /// MaxSurge is the maximum number of pods that can be scheduled above
        /// the original number of pods. Value can be an absolute number (ex:
        /// 5) or a percentage of total pods at the start of the update (ex:
        /// 10%). Absolute number is calculated from percentage by rounding
        /// up.
        /// 
        /// This cannot be 0 if MaxUnavailable is 0. By default, 25% is used.
        /// 
        /// Example: when this is set to 30%, the new RC can be scaled up by
        /// 30% immediately when the rolling update starts. Once old pods
        /// have been killed, new RC can be scaled up further, ensuring that
        /// total number of pods running at any time during the update is
        /// atmost 130% of original pods.
        /// </summary>
        [JsonProperty(PropertyName = "maxSurge")]
        public string MaxSurge { get; set; }

        /// <summary>
        /// MaxUnavailable is the maximum number of pods that can be
        /// unavailable during the update. Value can be an absolute number
        /// (ex: 5) or a percentage of total pods at the start of update (ex:
        /// 10%). Absolute number is calculated from percentage by rounding
        /// down.
        /// 
        /// This cannot be 0 if MaxSurge is 0. By default, 25% is used.
        /// 
        /// Example: when this is set to 30%, the old RC can be scaled down by
        /// 30% immediately when the rolling update starts. Once new pods are
        /// ready, old RC can be scaled down further, followed by scaling up
        /// the new RC, ensuring that at least 70% of original number of pods
        /// are available at all times during the update.
        /// </summary>
        [JsonProperty(PropertyName = "maxUnavailable")]
        public string MaxUnavailable { get; set; }

        /// <summary>
        /// Post is a lifecycle hook which is executed after the strategy has
        /// finished all deployment logic. All LifecycleHookFailurePolicy
        /// values are supported.
        /// </summary>
        [JsonProperty(PropertyName = "post")]
        public Comgithubopenshiftoriginpkgappsapisappsv1LifecycleHook Post { get; set; }

        /// <summary>
        /// Pre is a lifecycle hook which is executed before the deployment
        /// process begins. All LifecycleHookFailurePolicy values are
        /// supported.
        /// </summary>
        [JsonProperty(PropertyName = "pre")]
        public Comgithubopenshiftoriginpkgappsapisappsv1LifecycleHook Pre { get; set; }

        /// <summary>
        /// TimeoutSeconds is the time to wait for updates before giving up.
        /// If the value is nil, a default will be used.
        /// </summary>
        [JsonProperty(PropertyName = "timeoutSeconds")]
        public long? TimeoutSeconds { get; set; }

        /// <summary>
        /// UpdatePeriodSeconds is the time to wait between individual pod
        /// updates. If the value is nil, a default will be used.
        /// </summary>
        [JsonProperty(PropertyName = "updatePeriodSeconds")]
        public long? UpdatePeriodSeconds { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Post != null)
            {
                this.Post.Validate();
            }
            if (this.Pre != null)
            {
                this.Pre.Validate();
            }
        }
    }
}
