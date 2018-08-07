// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of the source control sync job.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SourceControlSyncJob
    {
        /// <summary>
        /// Initializes a new instance of the SourceControlSyncJob class.
        /// </summary>
        public SourceControlSyncJob()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SourceControlSyncJob class.
        /// </summary>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="id">Resource id.</param>
        /// <param name="sourceControlSyncJobId">The source control sync job
        /// id.</param>
        /// <param name="creationTime">The creation time of the job.</param>
        /// <param name="provisioningState">The provisioning state of the job.
        /// Possible values include: 'Completed', 'Failed', 'Running'</param>
        /// <param name="startTime">The start time of the job.</param>
        /// <param name="endTime">The end time of the job.</param>
        /// <param name="startType">The type of start for the sync job.
        /// Possible values include: 'AutoSync', 'ManualSync'</param>
        public SourceControlSyncJob(string name = default(string), string type = default(string), string id = default(string), string sourceControlSyncJobId = default(string), System.DateTimeOffset creationTime = default(System.DateTimeOffset), string provisioningState = default(string), System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), string startType = default(string))
        {
            Name = name;
            Type = type;
            Id = id;
            SourceControlSyncJobId = sourceControlSyncJobId;
            CreationTime = creationTime;
            ProvisioningState = provisioningState;
            StartTime = startTime;
            EndTime = endTime;
            StartType = startType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets resource id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the source control sync job id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceControlSyncJobId")]
        public string SourceControlSyncJobId { get; set; }

        /// <summary>
        /// Gets the creation time of the job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTimeOffset CreationTime { get; private set; }

        /// <summary>
        /// Gets or sets the provisioning state of the job. Possible values
        /// include: 'Completed', 'Failed', 'Running'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets the start time of the job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTimeOffset? StartTime { get; private set; }

        /// <summary>
        /// Gets the end time of the job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTimeOffset? EndTime { get; private set; }

        /// <summary>
        /// Gets or sets the type of start for the sync job. Possible values
        /// include: 'AutoSync', 'ManualSync'
        /// </summary>
        [JsonProperty(PropertyName = "properties.startType")]
        public string StartType { get; set; }

    }
}
