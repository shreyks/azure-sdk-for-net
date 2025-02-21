// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes a blob input data source that contains stream data. </summary>
    public partial class BlobStreamInputDataSource : StreamInputDataSource
    {
        /// <summary> Initializes a new instance of BlobStreamInputDataSource. </summary>
        public BlobStreamInputDataSource()
        {
            StorageAccounts = new ChangeTrackingList<StorageAccount>();
            StreamInputDataSourceType = "Microsoft.Storage/Blob";
        }

        /// <summary> Initializes a new instance of BlobStreamInputDataSource. </summary>
        /// <param name="streamInputDataSourceType"> Indicates the type of input data source containing stream data. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="storageAccounts"> A list of one or more Azure Storage accounts. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="container"> The name of a container within the associated Storage account. This container contains either the blob(s) to be read from or written to. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="pathPattern"> The blob path pattern. Not a regular expression. It represents a pattern against which blob names will be matched to determine whether or not they should be included as input or output to the job. See https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-input or https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-output for a more detailed explanation and example. </param>
        /// <param name="dateFormat"> The date format. Wherever {date} appears in pathPattern, the value of this property is used as the date format instead. </param>
        /// <param name="timeFormat"> The time format. Wherever {time} appears in pathPattern, the value of this property is used as the time format instead. </param>
        /// <param name="authenticationMode"> Authentication Mode. </param>
        /// <param name="sourcePartitionCount"> The partition count of the blob input data source. Range 1 - 1024. </param>
        internal BlobStreamInputDataSource(string streamInputDataSourceType, IList<StorageAccount> storageAccounts, string container, string pathPattern, string dateFormat, string timeFormat, AuthenticationMode? authenticationMode, int? sourcePartitionCount) : base(streamInputDataSourceType)
        {
            StorageAccounts = storageAccounts;
            Container = container;
            PathPattern = pathPattern;
            DateFormat = dateFormat;
            TimeFormat = timeFormat;
            AuthenticationMode = authenticationMode;
            SourcePartitionCount = sourcePartitionCount;
            StreamInputDataSourceType = streamInputDataSourceType ?? "Microsoft.Storage/Blob";
        }

        /// <summary> A list of one or more Azure Storage accounts. Required on PUT (CreateOrReplace) requests. </summary>
        public IList<StorageAccount> StorageAccounts { get; }
        /// <summary> The name of a container within the associated Storage account. This container contains either the blob(s) to be read from or written to. Required on PUT (CreateOrReplace) requests. </summary>
        public string Container { get; set; }
        /// <summary> The blob path pattern. Not a regular expression. It represents a pattern against which blob names will be matched to determine whether or not they should be included as input or output to the job. See https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-input or https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-output for a more detailed explanation and example. </summary>
        public string PathPattern { get; set; }
        /// <summary> The date format. Wherever {date} appears in pathPattern, the value of this property is used as the date format instead. </summary>
        public string DateFormat { get; set; }
        /// <summary> The time format. Wherever {time} appears in pathPattern, the value of this property is used as the time format instead. </summary>
        public string TimeFormat { get; set; }
        /// <summary> Authentication Mode. </summary>
        public AuthenticationMode? AuthenticationMode { get; set; }
        /// <summary> The partition count of the blob input data source. Range 1 - 1024. </summary>
        public int? SourcePartitionCount { get; set; }
    }
}
