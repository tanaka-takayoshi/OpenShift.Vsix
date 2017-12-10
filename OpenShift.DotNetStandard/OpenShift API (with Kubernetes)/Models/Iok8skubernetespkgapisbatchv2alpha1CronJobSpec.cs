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
    /// CronJobSpec describes how the job execution will look like and when it
    /// will actually run.
    /// </summary>
    public partial class Iok8skubernetespkgapisbatchv2alpha1CronJobSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisbatchv2alpha1CronJobSpec class.
        /// </summary>
        public Iok8skubernetespkgapisbatchv2alpha1CronJobSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8skubernetespkgapisbatchv2alpha1CronJobSpec class.
        /// </summary>
        public Iok8skubernetespkgapisbatchv2alpha1CronJobSpec(Iok8skubernetespkgapisbatchv2alpha1JobTemplateSpec jobTemplate, string schedule, string concurrencyPolicy = default(string), int? failedJobsHistoryLimit = default(int?), long? startingDeadlineSeconds = default(long?), int? successfulJobsHistoryLimit = default(int?), bool? suspend = default(bool?))
        {
            ConcurrencyPolicy = concurrencyPolicy;
            FailedJobsHistoryLimit = failedJobsHistoryLimit;
            JobTemplate = jobTemplate;
            Schedule = schedule;
            StartingDeadlineSeconds = startingDeadlineSeconds;
            SuccessfulJobsHistoryLimit = successfulJobsHistoryLimit;
            Suspend = suspend;
        }

        /// <summary>
        /// Specifies how to treat concurrent executions of a Job. Defaults to
        /// Allow.
        /// </summary>
        [JsonProperty(PropertyName = "concurrencyPolicy")]
        public string ConcurrencyPolicy { get; set; }

        /// <summary>
        /// The number of failed finished jobs to retain. This is a pointer to
        /// distinguish between explicit zero and not specified.
        /// </summary>
        [JsonProperty(PropertyName = "failedJobsHistoryLimit")]
        public int? FailedJobsHistoryLimit { get; set; }

        /// <summary>
        /// Specifies the job that will be created when executing a CronJob.
        /// </summary>
        [JsonProperty(PropertyName = "jobTemplate")]
        public Iok8skubernetespkgapisbatchv2alpha1JobTemplateSpec JobTemplate { get; set; }

        /// <summary>
        /// The schedule in Cron format, see
        /// https://en.wikipedia.org/wiki/Cron.
        /// </summary>
        [JsonProperty(PropertyName = "schedule")]
        public string Schedule { get; set; }

        /// <summary>
        /// Optional deadline in seconds for starting the job if it misses
        /// scheduled time for any reason.  Missed jobs executions will be
        /// counted as failed ones.
        /// </summary>
        [JsonProperty(PropertyName = "startingDeadlineSeconds")]
        public long? StartingDeadlineSeconds { get; set; }

        /// <summary>
        /// The number of successful finished jobs to retain. This is a
        /// pointer to distinguish between explicit zero and not specified.
        /// </summary>
        [JsonProperty(PropertyName = "successfulJobsHistoryLimit")]
        public int? SuccessfulJobsHistoryLimit { get; set; }

        /// <summary>
        /// This flag tells the controller to suspend subsequent executions,
        /// it does not apply to already started executions.  Defaults to
        /// false.
        /// </summary>
        [JsonProperty(PropertyName = "suspend")]
        public bool? Suspend { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (JobTemplate == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "JobTemplate");
            }
            if (Schedule == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Schedule");
            }
            if (this.JobTemplate != null)
            {
                this.JobTemplate.Validate();
            }
        }
    }
}
