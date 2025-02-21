// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Percentile Metric data. </summary>
    public partial class PercentileMetric
    {
        /// <summary> Initializes a new instance of PercentileMetric. </summary>
        internal PercentileMetric()
        {
            MetricValues = new ChangeTrackingList<PercentileMetricValue>();
        }

        /// <summary> Initializes a new instance of PercentileMetric. </summary>
        /// <param name="startOn"> The start time for the metric (ISO-8601 format). </param>
        /// <param name="endOn"> The end time for the metric (ISO-8601 format). </param>
        /// <param name="timeGrain"> The time grain to be used to summarize the metric values. </param>
        /// <param name="unit"> The unit of the metric. </param>
        /// <param name="name"> The name information for the metric. </param>
        /// <param name="metricValues"> The percentile metric values for the specified time window and timestep. </param>
        internal PercentileMetric(DateTimeOffset? startOn, DateTimeOffset? endOn, string timeGrain, CosmosDBMetricUnitType? unit, CosmosDBMetricName name, IReadOnlyList<PercentileMetricValue> metricValues)
        {
            StartOn = startOn;
            EndOn = endOn;
            TimeGrain = timeGrain;
            Unit = unit;
            Name = name;
            MetricValues = metricValues;
        }

        /// <summary> The start time for the metric (ISO-8601 format). </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The end time for the metric (ISO-8601 format). </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The time grain to be used to summarize the metric values. </summary>
        public string TimeGrain { get; }
        /// <summary> The unit of the metric. </summary>
        public CosmosDBMetricUnitType? Unit { get; }
        /// <summary> The name information for the metric. </summary>
        public CosmosDBMetricName Name { get; }
        /// <summary> The percentile metric values for the specified time window and timestep. </summary>
        public IReadOnlyList<PercentileMetricValue> MetricValues { get; }
    }
}
