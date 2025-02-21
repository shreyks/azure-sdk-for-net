// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The validation operation result for a linker. </summary>
    public partial class ValidateOperationResult
    {
        /// <summary> Initializes a new instance of ValidateOperationResult. </summary>
        internal ValidateOperationResult()
        {
            ValidationDetail = new ChangeTrackingList<ValidationResultItemData>();
        }

        /// <summary> Initializes a new instance of ValidateOperationResult. </summary>
        /// <param name="resourceId"> Validated linker id. </param>
        /// <param name="status"> Validation operation status. </param>
        /// <param name="linkerName"> The linker name. </param>
        /// <param name="isConnectionAvailable"> A boolean value indicating whether the connection is available or not. </param>
        /// <param name="reportStartOn"> The start time of the validation report. </param>
        /// <param name="reportEndOn"> The end time of the validation report. </param>
        /// <param name="sourceId"> The resource id of the linker source application. </param>
        /// <param name="targetId"> The resource Id of target service. </param>
        /// <param name="authType"> The authentication type. </param>
        /// <param name="validationDetail"> The detail of validation result. </param>
        internal ValidateOperationResult(ResourceIdentifier resourceId, string status, string linkerName, bool? isConnectionAvailable, DateTimeOffset? reportStartOn, DateTimeOffset? reportEndOn, ResourceIdentifier sourceId, ResourceIdentifier targetId, LinkerAuthType? authType, IReadOnlyList<ValidationResultItemData> validationDetail)
        {
            ResourceId = resourceId;
            Status = status;
            LinkerName = linkerName;
            IsConnectionAvailable = isConnectionAvailable;
            ReportStartOn = reportStartOn;
            ReportEndOn = reportEndOn;
            SourceId = sourceId;
            TargetId = targetId;
            AuthType = authType;
            ValidationDetail = validationDetail;
        }

        /// <summary> Validated linker id. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> Validation operation status. </summary>
        public string Status { get; }
        /// <summary> The linker name. </summary>
        public string LinkerName { get; }
        /// <summary> A boolean value indicating whether the connection is available or not. </summary>
        public bool? IsConnectionAvailable { get; }
        /// <summary> The start time of the validation report. </summary>
        public DateTimeOffset? ReportStartOn { get; }
        /// <summary> The end time of the validation report. </summary>
        public DateTimeOffset? ReportEndOn { get; }
        /// <summary> The resource id of the linker source application. </summary>
        public ResourceIdentifier SourceId { get; }
        /// <summary> The resource Id of target service. </summary>
        public ResourceIdentifier TargetId { get; }
        /// <summary> The authentication type. </summary>
        public LinkerAuthType? AuthType { get; }
        /// <summary> The detail of validation result. </summary>
        public IReadOnlyList<ValidationResultItemData> ValidationDetail { get; }
    }
}
