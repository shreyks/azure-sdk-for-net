// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.StreamAnalytics.Models;

namespace Azure.ResourceManager.StreamAnalytics
{
    /// <summary> A class representing the StreamingJob data model. </summary>
    public partial class StreamingJobData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of StreamingJobData. </summary>
        /// <param name="location"> The location. </param>
        public StreamingJobData(AzureLocation location) : base(location)
        {
            Inputs = new ChangeTrackingList<StreamingJobInputData>();
            Outputs = new ChangeTrackingList<StreamingJobOutputData>();
            Functions = new ChangeTrackingList<StreamingJobFunctionData>();
        }

        /// <summary> Initializes a new instance of StreamingJobData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Describes the managed identity assigned to this job that can be used to authenticate with inputs and outputs. </param>
        /// <param name="sku"> Describes the SKU of the streaming job. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="jobId"> A GUID uniquely identifying the streaming job. This GUID is generated upon creation of the streaming job. </param>
        /// <param name="provisioningState"> Describes the provisioning status of the streaming job. </param>
        /// <param name="jobState"> Describes the state of the streaming job. </param>
        /// <param name="jobType"> Describes the type of the job. Valid modes are `Cloud` and &apos;Edge&apos;. </param>
        /// <param name="outputStartMode"> This property should only be utilized when it is desired that the job be started immediately upon creation. Value may be JobStartTime, CustomTime, or LastOutputEventTime to indicate whether the starting point of the output event stream should start whenever the job is started, start at a custom user time stamp specified via the outputStartTime property, or start from the last event output time. </param>
        /// <param name="outputStartOn"> Value is either an ISO-8601 formatted time stamp that indicates the starting point of the output event stream, or null to indicate that the output event stream will start whenever the streaming job is started. This property must have a value if outputStartMode is set to CustomTime. </param>
        /// <param name="lastOutputEventOn"> Value is either an ISO-8601 formatted timestamp indicating the last output event time of the streaming job or null indicating that output has not yet been produced. In case of multiple outputs or multiple streams, this shows the latest value in that set. </param>
        /// <param name="eventsOutOfOrderPolicy"> Indicates the policy to apply to events that arrive out of order in the input event stream. </param>
        /// <param name="outputErrorPolicy"> Indicates the policy to apply to events that arrive at the output and cannot be written to the external storage due to being malformed (missing column values, column values of wrong type or size). </param>
        /// <param name="eventsOutOfOrderMaxDelayInSeconds"> The maximum tolerable delay in seconds where out-of-order events can be adjusted to be back in order. </param>
        /// <param name="eventsLateArrivalMaxDelayInSeconds"> The maximum tolerable delay in seconds where events arriving late could be included.  Supported range is -1 to 1814399 (20.23:59:59 days) and -1 is used to specify wait indefinitely. If the property is absent, it is interpreted to have a value of -1. </param>
        /// <param name="dataLocale"> The data locale of the stream analytics job. Value should be the name of a supported .NET Culture from the set https://msdn.microsoft.com/en-us/library/system.globalization.culturetypes(v=vs.110).aspx. Defaults to &apos;en-US&apos; if none specified. </param>
        /// <param name="compatibilityLevel"> Controls certain runtime behaviors of the streaming job. </param>
        /// <param name="createdOn"> Value is an ISO-8601 formatted UTC timestamp indicating when the streaming job was created. </param>
        /// <param name="inputs"> A list of one or more inputs to the streaming job. The name property for each input is required when specifying this property in a PUT request. This property cannot be modify via a PATCH operation. You must use the PATCH API available for the individual input. </param>
        /// <param name="transformation"> Indicates the query and the number of streaming units to use for the streaming job. The name property of the transformation is required when specifying this property in a PUT request. This property cannot be modify via a PATCH operation. You must use the PATCH API available for the individual transformation. </param>
        /// <param name="outputs"> A list of one or more outputs for the streaming job. The name property for each output is required when specifying this property in a PUT request. This property cannot be modify via a PATCH operation. You must use the PATCH API available for the individual output. </param>
        /// <param name="functions"> A list of one or more functions for the streaming job. The name property for each function is required when specifying this property in a PUT request. This property cannot be modify via a PATCH operation. You must use the PATCH API available for the individual transformation. </param>
        /// <param name="eTag"> The current entity tag for the streaming job. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency. </param>
        /// <param name="jobStorageAccount"> The properties that are associated with an Azure Storage account with MSI. </param>
        /// <param name="contentStoragePolicy"> Valid values are JobStorageAccount and SystemAccount. If set to JobStorageAccount, this requires the user to also specify jobStorageAccount property. . </param>
        /// <param name="externals"> The storage account where the custom code artifacts are located. </param>
        /// <param name="cluster"> The cluster which streaming jobs will run on. </param>
        internal StreamingJobData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedIdentity identity, StreamAnalyticsSku sku, string jobId, string provisioningState, string jobState, JobType? jobType, OutputStartMode? outputStartMode, DateTimeOffset? outputStartOn, DateTimeOffset? lastOutputEventOn, EventsOutOfOrderPolicy? eventsOutOfOrderPolicy, OutputErrorPolicy? outputErrorPolicy, int? eventsOutOfOrderMaxDelayInSeconds, int? eventsLateArrivalMaxDelayInSeconds, string dataLocale, CompatibilityLevel? compatibilityLevel, DateTimeOffset? createdOn, IList<StreamingJobInputData> inputs, StreamingJobTransformationData transformation, IList<StreamingJobOutputData> outputs, IList<StreamingJobFunctionData> functions, ETag? eTag, JobStorageAccount jobStorageAccount, ContentStoragePolicy? contentStoragePolicy, ExternalStorageAccount externals, WritableSubResource cluster) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Sku = sku;
            JobId = jobId;
            ProvisioningState = provisioningState;
            JobState = jobState;
            JobType = jobType;
            OutputStartMode = outputStartMode;
            OutputStartOn = outputStartOn;
            LastOutputEventOn = lastOutputEventOn;
            EventsOutOfOrderPolicy = eventsOutOfOrderPolicy;
            OutputErrorPolicy = outputErrorPolicy;
            EventsOutOfOrderMaxDelayInSeconds = eventsOutOfOrderMaxDelayInSeconds;
            EventsLateArrivalMaxDelayInSeconds = eventsLateArrivalMaxDelayInSeconds;
            DataLocale = dataLocale;
            CompatibilityLevel = compatibilityLevel;
            CreatedOn = createdOn;
            Inputs = inputs;
            Transformation = transformation;
            Outputs = outputs;
            Functions = functions;
            ETag = eTag;
            JobStorageAccount = jobStorageAccount;
            ContentStoragePolicy = contentStoragePolicy;
            Externals = externals;
            Cluster = cluster;
        }

        /// <summary> Describes the managed identity assigned to this job that can be used to authenticate with inputs and outputs. </summary>
        public ManagedIdentity Identity { get; set; }
        /// <summary> Describes the SKU of the streaming job. Required on PUT (CreateOrReplace) requests. </summary>
        internal StreamAnalyticsSku Sku { get; set; }
        /// <summary> The name of the SKU. Required on PUT (CreateOrReplace) requests. </summary>
        public StreamAnalyticsSkuName? SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new StreamAnalyticsSku();
                Sku.Name = value;
            }
        }

        /// <summary> A GUID uniquely identifying the streaming job. This GUID is generated upon creation of the streaming job. </summary>
        public string JobId { get; }
        /// <summary> Describes the provisioning status of the streaming job. </summary>
        public string ProvisioningState { get; }
        /// <summary> Describes the state of the streaming job. </summary>
        public string JobState { get; }
        /// <summary> Describes the type of the job. Valid modes are `Cloud` and &apos;Edge&apos;. </summary>
        public JobType? JobType { get; set; }
        /// <summary> This property should only be utilized when it is desired that the job be started immediately upon creation. Value may be JobStartTime, CustomTime, or LastOutputEventTime to indicate whether the starting point of the output event stream should start whenever the job is started, start at a custom user time stamp specified via the outputStartTime property, or start from the last event output time. </summary>
        public OutputStartMode? OutputStartMode { get; set; }
        /// <summary> Value is either an ISO-8601 formatted time stamp that indicates the starting point of the output event stream, or null to indicate that the output event stream will start whenever the streaming job is started. This property must have a value if outputStartMode is set to CustomTime. </summary>
        public DateTimeOffset? OutputStartOn { get; set; }
        /// <summary> Value is either an ISO-8601 formatted timestamp indicating the last output event time of the streaming job or null indicating that output has not yet been produced. In case of multiple outputs or multiple streams, this shows the latest value in that set. </summary>
        public DateTimeOffset? LastOutputEventOn { get; }
        /// <summary> Indicates the policy to apply to events that arrive out of order in the input event stream. </summary>
        public EventsOutOfOrderPolicy? EventsOutOfOrderPolicy { get; set; }
        /// <summary> Indicates the policy to apply to events that arrive at the output and cannot be written to the external storage due to being malformed (missing column values, column values of wrong type or size). </summary>
        public OutputErrorPolicy? OutputErrorPolicy { get; set; }
        /// <summary> The maximum tolerable delay in seconds where out-of-order events can be adjusted to be back in order. </summary>
        public int? EventsOutOfOrderMaxDelayInSeconds { get; set; }
        /// <summary> The maximum tolerable delay in seconds where events arriving late could be included.  Supported range is -1 to 1814399 (20.23:59:59 days) and -1 is used to specify wait indefinitely. If the property is absent, it is interpreted to have a value of -1. </summary>
        public int? EventsLateArrivalMaxDelayInSeconds { get; set; }
        /// <summary> The data locale of the stream analytics job. Value should be the name of a supported .NET Culture from the set https://msdn.microsoft.com/en-us/library/system.globalization.culturetypes(v=vs.110).aspx. Defaults to &apos;en-US&apos; if none specified. </summary>
        public string DataLocale { get; set; }
        /// <summary> Controls certain runtime behaviors of the streaming job. </summary>
        public CompatibilityLevel? CompatibilityLevel { get; set; }
        /// <summary> Value is an ISO-8601 formatted UTC timestamp indicating when the streaming job was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> A list of one or more inputs to the streaming job. The name property for each input is required when specifying this property in a PUT request. This property cannot be modify via a PATCH operation. You must use the PATCH API available for the individual input. </summary>
        public IList<StreamingJobInputData> Inputs { get; }
        /// <summary> Indicates the query and the number of streaming units to use for the streaming job. The name property of the transformation is required when specifying this property in a PUT request. This property cannot be modify via a PATCH operation. You must use the PATCH API available for the individual transformation. </summary>
        public StreamingJobTransformationData Transformation { get; set; }
        /// <summary> A list of one or more outputs for the streaming job. The name property for each output is required when specifying this property in a PUT request. This property cannot be modify via a PATCH operation. You must use the PATCH API available for the individual output. </summary>
        public IList<StreamingJobOutputData> Outputs { get; }
        /// <summary> A list of one or more functions for the streaming job. The name property for each function is required when specifying this property in a PUT request. This property cannot be modify via a PATCH operation. You must use the PATCH API available for the individual transformation. </summary>
        public IList<StreamingJobFunctionData> Functions { get; }
        /// <summary> The current entity tag for the streaming job. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency. </summary>
        public ETag? ETag { get; }
        /// <summary> The properties that are associated with an Azure Storage account with MSI. </summary>
        public JobStorageAccount JobStorageAccount { get; set; }
        /// <summary> Valid values are JobStorageAccount and SystemAccount. If set to JobStorageAccount, this requires the user to also specify jobStorageAccount property. . </summary>
        public ContentStoragePolicy? ContentStoragePolicy { get; set; }
        /// <summary> The storage account where the custom code artifacts are located. </summary>
        public ExternalStorageAccount Externals { get; set; }
        /// <summary> The cluster which streaming jobs will run on. </summary>
        internal WritableSubResource Cluster { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ClusterId
        {
            get => Cluster is null ? default : Cluster.Id;
            set
            {
                if (Cluster is null)
                    Cluster = new WritableSubResource();
                Cluster.Id = value;
            }
        }
    }
}
