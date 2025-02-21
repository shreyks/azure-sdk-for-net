// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary>
    /// The rule criteria that defines the conditions of the alert rule.
    /// Please note <see cref="MetricAlertCriteria"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MetricAlertMultipleResourceMultipleMetricCriteria"/>, <see cref="MetricAlertSingleResourceMultipleMetricCriteria"/> and <see cref="WebtestLocationAvailabilityCriteria"/>.
    /// </summary>
    public partial class MetricAlertCriteria
    {
        /// <summary> Initializes a new instance of MetricAlertCriteria. </summary>
        public MetricAlertCriteria()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of MetricAlertCriteria. </summary>
        /// <param name="odataType"> specifies the type of the alert criteria. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal MetricAlertCriteria(MonitorOdataType odataType, IDictionary<string, BinaryData> additionalProperties)
        {
            OdataType = odataType;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> specifies the type of the alert criteria. </summary>
        internal MonitorOdataType OdataType { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
