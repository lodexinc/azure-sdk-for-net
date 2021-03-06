// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Http logs to file system configuration.
    /// </summary>
    public partial class FileSystemHttpLogsConfig
    {
        /// <summary>
        /// Initializes a new instance of the FileSystemHttpLogsConfig class.
        /// </summary>
        public FileSystemHttpLogsConfig() { }

        /// <summary>
        /// Initializes a new instance of the FileSystemHttpLogsConfig class.
        /// </summary>
        /// <param name="retentionInMb">Maximum size in megabytes that http log
        /// files can use.
        /// When reached old log files will be removed to make space for new
        /// ones.
        /// Value can range between 25 and 100.</param>
        /// <param name="retentionInDays">Retention in days.
        /// Remove files older than X days.
        /// 0 or lower means no retention.</param>
        /// <param name="enabled">Enabled.</param>
        public FileSystemHttpLogsConfig(int? retentionInMb = default(int?), int? retentionInDays = default(int?), bool? enabled = default(bool?))
        {
            RetentionInMb = retentionInMb;
            RetentionInDays = retentionInDays;
            Enabled = enabled;
        }

        /// <summary>
        /// Gets or sets maximum size in megabytes that http log files can use.
        /// When reached old log files will be removed to make space for new
        /// ones.
        /// Value can range between 25 and 100.
        /// </summary>
        [JsonProperty(PropertyName = "retentionInMb")]
        public int? RetentionInMb { get; set; }

        /// <summary>
        /// Gets or sets retention in days.
        /// Remove files older than X days.
        /// 0 or lower means no retention.
        /// </summary>
        [JsonProperty(PropertyName = "retentionInDays")]
        public int? RetentionInDays { get; set; }

        /// <summary>
        /// Gets or sets enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RetentionInMb > 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "RetentionInMb", 100);
            }
            if (RetentionInMb < 25)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "RetentionInMb", 25);
            }
        }
    }
}

