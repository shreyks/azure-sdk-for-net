// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Dynatrace
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Dynatrace. </summary>
    public static partial class DynatraceExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// List all MonitorResource by subscriptionId
        /// Request Path: /subscriptions/{subscriptionId}/providers/Dynatrace.Observability/monitors
        /// Operation Id: Monitors_ListBySubscriptionId
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<MonitorResource> GetMonitorResourcesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetMonitorResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// List all MonitorResource by subscriptionId
        /// Request Path: /subscriptions/{subscriptionId}/providers/Dynatrace.Observability/monitors
        /// Operation Id: Monitors_ListBySubscriptionId
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<MonitorResource> GetMonitorResources(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetMonitorResources(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of MonitorResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of MonitorResources and their operations over a MonitorResource. </returns>
        public static MonitorResourceCollection GetMonitorResources(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetMonitorResources();
        }

        /// <summary>
        /// Get a MonitorResource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}
        /// Operation Id: Monitors_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<MonitorResource>> GetMonitorResourceAsync(this ResourceGroupResource resourceGroupResource, string monitorName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetMonitorResources().GetAsync(monitorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a MonitorResource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}
        /// Operation Id: Monitors_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<MonitorResource> GetMonitorResource(this ResourceGroupResource resourceGroupResource, string monitorName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetMonitorResources().Get(monitorName, cancellationToken);
        }

        #region MonitorResource
        /// <summary>
        /// Gets an object representing a <see cref="MonitorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MonitorResource.CreateResourceIdentifier" /> to create a <see cref="MonitorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MonitorResource" /> object. </returns>
        public static MonitorResource GetMonitorResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MonitorResource.ValidateResourceId(id);
                return new MonitorResource(client, id);
            }
            );
        }
        #endregion

        #region TagRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="TagRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TagRuleResource.CreateResourceIdentifier" /> to create a <see cref="TagRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TagRuleResource" /> object. </returns>
        public static TagRuleResource GetTagRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                TagRuleResource.ValidateResourceId(id);
                return new TagRuleResource(client, id);
            }
            );
        }
        #endregion

        #region DynatraceSingleSignOnResource
        /// <summary>
        /// Gets an object representing a <see cref="DynatraceSingleSignOnResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DynatraceSingleSignOnResource.CreateResourceIdentifier" /> to create a <see cref="DynatraceSingleSignOnResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DynatraceSingleSignOnResource" /> object. </returns>
        public static DynatraceSingleSignOnResource GetDynatraceSingleSignOnResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DynatraceSingleSignOnResource.ValidateResourceId(id);
                return new DynatraceSingleSignOnResource(client, id);
            }
            );
        }
        #endregion
    }
}
