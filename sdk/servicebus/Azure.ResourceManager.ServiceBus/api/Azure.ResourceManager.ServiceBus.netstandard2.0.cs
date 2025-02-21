namespace Azure.ResourceManager.ServiceBus
{
    public partial class MigrationConfigurationCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource>, System.Collections.IEnumerable
    {
        protected MigrationConfigurationCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.Models.MigrationConfigurationName configName, Azure.ResourceManager.ServiceBus.MigrationConfigurationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.Models.MigrationConfigurationName configName, Azure.ResourceManager.ServiceBus.MigrationConfigurationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(Azure.ResourceManager.ServiceBus.Models.MigrationConfigurationName configName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(Azure.ResourceManager.ServiceBus.Models.MigrationConfigurationName configName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource> Get(Azure.ResourceManager.ServiceBus.Models.MigrationConfigurationName configName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource>> GetAsync(Azure.ResourceManager.ServiceBus.Models.MigrationConfigurationName configName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class MigrationConfigurationData : Azure.ResourceManager.Models.ResourceData
    {
        public MigrationConfigurationData() { }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public string MigrationState { get { throw null; } }
        public long? PendingReplicationOperationsCount { get { throw null; } }
        public string PostMigrationName { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public Azure.Core.ResourceIdentifier TargetServiceBusNamespace { get { throw null; } set { } }
    }
    public partial class MigrationConfigurationResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected MigrationConfigurationResource() { }
        public virtual Azure.ResourceManager.ServiceBus.MigrationConfigurationData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response CompleteMigration(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CompleteMigrationAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, Azure.ResourceManager.ServiceBus.Models.MigrationConfigurationName configName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Revert(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RevertAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.MigrationConfigurationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.MigrationConfigurationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ServiceBusAuthorizationRuleData : Azure.ResourceManager.Models.ResourceData
    {
        public ServiceBusAuthorizationRuleData() { }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ServiceBus.Models.ServiceBusAccessRight> Rights { get { throw null; } }
    }
    public partial class ServiceBusDisasterRecoveryAuthorizationRuleCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryAuthorizationRuleResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryAuthorizationRuleResource>, System.Collections.IEnumerable
    {
        protected ServiceBusDisasterRecoveryAuthorizationRuleCollection() { }
        public virtual Azure.Response<bool> Exists(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryAuthorizationRuleResource> Get(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryAuthorizationRuleResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryAuthorizationRuleResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryAuthorizationRuleResource>> GetAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryAuthorizationRuleResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryAuthorizationRuleResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryAuthorizationRuleResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryAuthorizationRuleResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ServiceBusDisasterRecoveryAuthorizationRuleResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ServiceBusDisasterRecoveryAuthorizationRuleResource() { }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusAuthorizationRuleData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string alias, string authorizationRuleName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryAuthorizationRuleResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryAuthorizationRuleResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusAccessKeys> GetKeys(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusAccessKeys>> GetKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ServiceBusDisasterRecoveryCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource>, System.Collections.IEnumerable
    {
        protected ServiceBusDisasterRecoveryCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string alias, Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string alias, Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource> Get(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource>> GetAsync(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ServiceBusDisasterRecoveryData : Azure.ResourceManager.Models.ResourceData
    {
        public ServiceBusDisasterRecoveryData() { }
        public string AlternateName { get { throw null; } set { } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public string PartnerNamespace { get { throw null; } set { } }
        public long? PendingReplicationOperationsCount { get { throw null; } }
        public Azure.ResourceManager.ServiceBus.Models.ServiceBusDisasterRecoveryProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ServiceBus.Models.ServiceBusDisasterRecoveryRole? Role { get { throw null; } }
    }
    public partial class ServiceBusDisasterRecoveryResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ServiceBusDisasterRecoveryResource() { }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response BreakPairing(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> BreakPairingAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string alias) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response FailOver(Azure.ResourceManager.ServiceBus.Models.FailoverProperties failoverProperties = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> FailOverAsync(Azure.ResourceManager.ServiceBus.Models.FailoverProperties failoverProperties = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryAuthorizationRuleResource> GetServiceBusDisasterRecoveryAuthorizationRule(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryAuthorizationRuleResource>> GetServiceBusDisasterRecoveryAuthorizationRuleAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryAuthorizationRuleCollection GetServiceBusDisasterRecoveryAuthorizationRules() { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class ServiceBusExtensions
    {
        public static Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusNameAvailabilityResult> CheckServiceBusNamespaceNameAvailability(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.ServiceBus.Models.ServiceBusNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusNameAvailabilityResult>> CheckServiceBusNamespaceNameAvailabilityAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.ServiceBus.Models.ServiceBusNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ServiceBus.MigrationConfigurationResource GetMigrationConfigurationResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryAuthorizationRuleResource GetServiceBusDisasterRecoveryAuthorizationRuleResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource GetServiceBusDisasterRecoveryResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource> GetServiceBusNamespace(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource>> GetServiceBusNamespaceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource GetServiceBusNamespaceAuthorizationRuleResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource GetServiceBusNamespaceResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ServiceBus.ServiceBusNamespaceCollection GetServiceBusNamespaces(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource> GetServiceBusNamespaces(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource> GetServiceBusNamespacesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ServiceBus.ServiceBusNetworkRuleSetResource GetServiceBusNetworkRuleSetResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource GetServiceBusPrivateEndpointConnectionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource GetServiceBusQueueAuthorizationRuleResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ServiceBus.ServiceBusQueueResource GetServiceBusQueueResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ServiceBus.ServiceBusRuleResource GetServiceBusRuleResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource GetServiceBusSubscriptionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource GetServiceBusTopicAuthorizationRuleResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ServiceBus.ServiceBusTopicResource GetServiceBusTopicResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class ServiceBusNamespaceAuthorizationRuleCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource>, System.Collections.IEnumerable
    {
        protected ServiceBusNamespaceAuthorizationRuleCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string authorizationRuleName, Azure.ResourceManager.ServiceBus.ServiceBusAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string authorizationRuleName, Azure.ResourceManager.ServiceBus.ServiceBusAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource> Get(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource>> GetAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ServiceBusNamespaceAuthorizationRuleResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ServiceBusNamespaceAuthorizationRuleResource() { }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusAuthorizationRuleData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string authorizationRuleName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusAccessKeys> GetKeys(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusAccessKeys>> GetKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusAccessKeys> RegenerateKeys(Azure.ResourceManager.ServiceBus.Models.ServiceBusRegenerateAccessKeyContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusAccessKeys>> RegenerateKeysAsync(Azure.ResourceManager.ServiceBus.Models.ServiceBusRegenerateAccessKeyContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ServiceBusNamespaceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource>, System.Collections.IEnumerable
    {
        protected ServiceBusNamespaceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string namespaceName, Azure.ResourceManager.ServiceBus.ServiceBusNamespaceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string namespaceName, Azure.ResourceManager.ServiceBus.ServiceBusNamespaceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource> Get(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource>> GetAsync(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ServiceBusNamespaceData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public ServiceBusNamespaceData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string AlternateName { get { throw null; } set { } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public bool? DisableLocalAuth { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceBus.Models.ServiceBusEncryption Encryption { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public string MetricId { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionData> PrivateEndpointConnections { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public string ServiceBusEndpoint { get { throw null; } }
        public Azure.ResourceManager.ServiceBus.Models.ServiceBusSku Sku { get { throw null; } set { } }
        public string Status { get { throw null; } }
        public System.DateTimeOffset? UpdatedOn { get { throw null; } }
        public bool? ZoneRedundant { get { throw null; } set { } }
    }
    public partial class ServiceBusNamespaceResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ServiceBusNamespaceResource() { }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusNamespaceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusNameAvailabilityResult> CheckServiceBusDisasterRecoveryNameAvailability(Azure.ResourceManager.ServiceBus.Models.ServiceBusNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusNameAvailabilityResult>> CheckServiceBusDisasterRecoveryNameAvailabilityAsync(Azure.ResourceManager.ServiceBus.Models.ServiceBusNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource> GetMigrationConfiguration(Azure.ResourceManager.ServiceBus.Models.MigrationConfigurationName configName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.MigrationConfigurationResource>> GetMigrationConfigurationAsync(Azure.ResourceManager.ServiceBus.Models.MigrationConfigurationName configName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ServiceBus.MigrationConfigurationCollection GetMigrationConfigurations() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateLinkResource> GetPrivateLinkResources(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateLinkResource> GetPrivateLinkResourcesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryCollection GetServiceBusDisasterRecoveries() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource> GetServiceBusDisasterRecovery(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusDisasterRecoveryResource>> GetServiceBusDisasterRecoveryAsync(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource> GetServiceBusNamespaceAuthorizationRule(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleResource>> GetServiceBusNamespaceAuthorizationRuleAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusNamespaceAuthorizationRuleCollection GetServiceBusNamespaceAuthorizationRules() { throw null; }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusNetworkRuleSetResource GetServiceBusNetworkRuleSet() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource> GetServiceBusPrivateEndpointConnection(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource>> GetServiceBusPrivateEndpointConnectionAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionCollection GetServiceBusPrivateEndpointConnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource> GetServiceBusQueue(string queueName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource>> GetServiceBusQueueAsync(string queueName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusQueueCollection GetServiceBusQueues() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource> GetServiceBusTopic(string topicName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource>> GetServiceBusTopicAsync(string topicName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusTopicCollection GetServiceBusTopics() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource> Update(Azure.ResourceManager.ServiceBus.Models.ServiceBusNamespacePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNamespaceResource>> UpdateAsync(Azure.ResourceManager.ServiceBus.Models.ServiceBusNamespacePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ServiceBusNetworkRuleSetData : Azure.ResourceManager.Models.ResourceData
    {
        public ServiceBusNetworkRuleSetData() { }
        public Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleSetDefaultAction? DefaultAction { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleSetIPRules> IPRules { get { throw null; } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public Azure.ResourceManager.ServiceBus.Models.ServiceBusPublicNetworkAccessFlag? PublicNetworkAccess { get { throw null; } set { } }
        public bool? TrustedServiceAccessEnabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleSetVirtualNetworkRules> VirtualNetworkRules { get { throw null; } }
    }
    public partial class ServiceBusNetworkRuleSetResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ServiceBusNetworkRuleSetResource() { }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusNetworkRuleSetData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusNetworkRuleSetResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusNetworkRuleSetData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusNetworkRuleSetResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusNetworkRuleSetData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNetworkRuleSetResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusNetworkRuleSetResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ServiceBusPrivateEndpointConnectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource>, System.Collections.IEnumerable
    {
        protected ServiceBusPrivateEndpointConnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ServiceBusPrivateEndpointConnectionData : Azure.ResourceManager.Models.ResourceData
    {
        public ServiceBusPrivateEndpointConnectionData() { }
        public Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateLinkServiceConnectionState ConnectionState { get { throw null; } set { } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public Azure.Core.ResourceIdentifier PrivateEndpointId { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateEndpointConnectionProvisioningState? ProvisioningState { get { throw null; } set { } }
    }
    public partial class ServiceBusPrivateEndpointConnectionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ServiceBusPrivateEndpointConnectionResource() { }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string privateEndpointConnectionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ServiceBusQueueAuthorizationRuleCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource>, System.Collections.IEnumerable
    {
        protected ServiceBusQueueAuthorizationRuleCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string authorizationRuleName, Azure.ResourceManager.ServiceBus.ServiceBusAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string authorizationRuleName, Azure.ResourceManager.ServiceBus.ServiceBusAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource> Get(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource>> GetAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ServiceBusQueueAuthorizationRuleResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ServiceBusQueueAuthorizationRuleResource() { }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusAuthorizationRuleData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusAccessKeys> GetKeys(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusAccessKeys>> GetKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusAccessKeys> RegenerateKeys(Azure.ResourceManager.ServiceBus.Models.ServiceBusRegenerateAccessKeyContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusAccessKeys>> RegenerateKeysAsync(Azure.ResourceManager.ServiceBus.Models.ServiceBusRegenerateAccessKeyContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ServiceBusQueueCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource>, System.Collections.IEnumerable
    {
        protected ServiceBusQueueCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string queueName, Azure.ResourceManager.ServiceBus.ServiceBusQueueData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string queueName, Azure.ResourceManager.ServiceBus.ServiceBusQueueData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string queueName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string queueName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource> Get(string queueName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource> GetAll(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource> GetAllAsync(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource>> GetAsync(string queueName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ServiceBusQueueData : Azure.ResourceManager.Models.ResourceData
    {
        public ServiceBusQueueData() { }
        public System.DateTimeOffset? AccessedOn { get { throw null; } }
        public System.TimeSpan? AutoDeleteOnIdle { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceBus.Models.MessageCountDetails CountDetails { get { throw null; } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public bool? DeadLetteringOnMessageExpiration { get { throw null; } set { } }
        public System.TimeSpan? DefaultMessageTimeToLive { get { throw null; } set { } }
        public System.TimeSpan? DuplicateDetectionHistoryTimeWindow { get { throw null; } set { } }
        public bool? EnableBatchedOperations { get { throw null; } set { } }
        public bool? EnableExpress { get { throw null; } set { } }
        public bool? EnablePartitioning { get { throw null; } set { } }
        public string ForwardDeadLetteredMessagesTo { get { throw null; } set { } }
        public string ForwardTo { get { throw null; } set { } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public System.TimeSpan? LockDuration { get { throw null; } set { } }
        public int? MaxDeliveryCount { get { throw null; } set { } }
        public long? MaxMessageSizeInKilobytes { get { throw null; } set { } }
        public int? MaxSizeInMegabytes { get { throw null; } set { } }
        public long? MessageCount { get { throw null; } }
        public bool? RequiresDuplicateDetection { get { throw null; } set { } }
        public bool? RequiresSession { get { throw null; } set { } }
        public long? SizeInBytes { get { throw null; } }
        public Azure.ResourceManager.ServiceBus.Models.EntityStatus? Status { get { throw null; } set { } }
        public System.DateTimeOffset? UpdatedOn { get { throw null; } }
    }
    public partial class ServiceBusQueueResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ServiceBusQueueResource() { }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusQueueData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string queueName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource> GetServiceBusQueueAuthorizationRule(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleResource>> GetServiceBusQueueAuthorizationRuleAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusQueueAuthorizationRuleCollection GetServiceBusQueueAuthorizationRules() { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusQueueData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusQueueResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusQueueData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ServiceBusRuleCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource>, System.Collections.IEnumerable
    {
        protected ServiceBusRuleCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string ruleName, Azure.ResourceManager.ServiceBus.ServiceBusRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string ruleName, Azure.ResourceManager.ServiceBus.ServiceBusRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string ruleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string ruleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource> Get(string ruleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource> GetAll(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource> GetAllAsync(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource>> GetAsync(string ruleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ServiceBusRuleData : Azure.ResourceManager.Models.ResourceData
    {
        public ServiceBusRuleData() { }
        public Azure.ResourceManager.ServiceBus.Models.FilterAction Action { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceBus.Models.CorrelationFilter CorrelationFilter { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceBus.Models.FilterType? FilterType { get { throw null; } set { } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public Azure.ResourceManager.ServiceBus.Models.SqlFilter SqlFilter { get { throw null; } set { } }
    }
    public partial class ServiceBusRuleResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ServiceBusRuleResource() { }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusRuleData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string topicName, string subscriptionName, string ruleName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ServiceBusSubscriptionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource>, System.Collections.IEnumerable
    {
        protected ServiceBusSubscriptionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string subscriptionName, Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string subscriptionName, Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string subscriptionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string subscriptionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource> Get(string subscriptionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource> GetAll(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource> GetAllAsync(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource>> GetAsync(string subscriptionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ServiceBusSubscriptionData : Azure.ResourceManager.Models.ResourceData
    {
        public ServiceBusSubscriptionData() { }
        public System.DateTimeOffset? AccessedOn { get { throw null; } }
        public System.TimeSpan? AutoDeleteOnIdle { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceBus.Models.ServiceBusClientAffineProperties ClientAffineProperties { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceBus.Models.MessageCountDetails CountDetails { get { throw null; } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public bool? DeadLetteringOnFilterEvaluationExceptions { get { throw null; } set { } }
        public bool? DeadLetteringOnMessageExpiration { get { throw null; } set { } }
        public System.TimeSpan? DefaultMessageTimeToLive { get { throw null; } set { } }
        public System.TimeSpan? DuplicateDetectionHistoryTimeWindow { get { throw null; } set { } }
        public bool? EnableBatchedOperations { get { throw null; } set { } }
        public string ForwardDeadLetteredMessagesTo { get { throw null; } set { } }
        public string ForwardTo { get { throw null; } set { } }
        public bool? IsClientAffine { get { throw null; } set { } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public System.TimeSpan? LockDuration { get { throw null; } set { } }
        public int? MaxDeliveryCount { get { throw null; } set { } }
        public long? MessageCount { get { throw null; } }
        public bool? RequiresSession { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceBus.Models.EntityStatus? Status { get { throw null; } set { } }
        public System.DateTimeOffset? UpdatedOn { get { throw null; } }
    }
    public partial class ServiceBusSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ServiceBusSubscriptionResource() { }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string topicName, string subscriptionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource> GetServiceBusRule(string ruleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusRuleResource>> GetServiceBusRuleAsync(string ruleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusRuleCollection GetServiceBusRules() { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ServiceBusTopicAuthorizationRuleCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource>, System.Collections.IEnumerable
    {
        protected ServiceBusTopicAuthorizationRuleCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string authorizationRuleName, Azure.ResourceManager.ServiceBus.ServiceBusAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string authorizationRuleName, Azure.ResourceManager.ServiceBus.ServiceBusAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource> Get(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource>> GetAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ServiceBusTopicAuthorizationRuleResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ServiceBusTopicAuthorizationRuleResource() { }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusAuthorizationRuleData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string topicName, string authorizationRuleName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusAccessKeys> GetKeys(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusAccessKeys>> GetKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusAccessKeys> RegenerateKeys(Azure.ResourceManager.ServiceBus.Models.ServiceBusRegenerateAccessKeyContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.Models.ServiceBusAccessKeys>> RegenerateKeysAsync(Azure.ResourceManager.ServiceBus.Models.ServiceBusRegenerateAccessKeyContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusAuthorizationRuleData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ServiceBusTopicCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource>, System.Collections.IEnumerable
    {
        protected ServiceBusTopicCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string topicName, Azure.ResourceManager.ServiceBus.ServiceBusTopicData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string topicName, Azure.ResourceManager.ServiceBus.ServiceBusTopicData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string topicName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string topicName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource> Get(string topicName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource> GetAll(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource> GetAllAsync(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource>> GetAsync(string topicName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ServiceBusTopicData : Azure.ResourceManager.Models.ResourceData
    {
        public ServiceBusTopicData() { }
        public System.DateTimeOffset? AccessedOn { get { throw null; } }
        public System.TimeSpan? AutoDeleteOnIdle { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceBus.Models.MessageCountDetails CountDetails { get { throw null; } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public System.TimeSpan? DefaultMessageTimeToLive { get { throw null; } set { } }
        public System.TimeSpan? DuplicateDetectionHistoryTimeWindow { get { throw null; } set { } }
        public bool? EnableBatchedOperations { get { throw null; } set { } }
        public bool? EnableExpress { get { throw null; } set { } }
        public bool? EnablePartitioning { get { throw null; } set { } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public long? MaxMessageSizeInKilobytes { get { throw null; } set { } }
        public int? MaxSizeInMegabytes { get { throw null; } set { } }
        public bool? RequiresDuplicateDetection { get { throw null; } set { } }
        public long? SizeInBytes { get { throw null; } }
        public Azure.ResourceManager.ServiceBus.Models.EntityStatus? Status { get { throw null; } set { } }
        public int? SubscriptionCount { get { throw null; } }
        public bool? SupportOrdering { get { throw null; } set { } }
        public System.DateTimeOffset? UpdatedOn { get { throw null; } }
    }
    public partial class ServiceBusTopicResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ServiceBusTopicResource() { }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusTopicData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string topicName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource> GetServiceBusSubscription(string subscriptionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionResource>> GetServiceBusSubscriptionAsync(string subscriptionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusSubscriptionCollection GetServiceBusSubscriptions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource> GetServiceBusTopicAuthorizationRule(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleResource>> GetServiceBusTopicAuthorizationRuleAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ServiceBus.ServiceBusTopicAuthorizationRuleCollection GetServiceBusTopicAuthorizationRules() { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusTopicData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ServiceBus.ServiceBusTopicResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ServiceBus.ServiceBusTopicData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.ServiceBus.Models
{
    public partial class CorrelationFilter
    {
        public CorrelationFilter() { }
        public string ContentType { get { throw null; } set { } }
        public string CorrelationId { get { throw null; } set { } }
        public string Label { get { throw null; } set { } }
        public string MessageId { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Properties { get { throw null; } }
        public string ReplyTo { get { throw null; } set { } }
        public string ReplyToSessionId { get { throw null; } set { } }
        public bool? RequiresPreprocessing { get { throw null; } set { } }
        public string SendTo { get { throw null; } set { } }
        public string SessionId { get { throw null; } set { } }
    }
    public enum EntityStatus
    {
        Unknown = 0,
        Active = 1,
        Disabled = 2,
        Restoring = 3,
        SendDisabled = 4,
        ReceiveDisabled = 5,
        Creating = 6,
        Deleting = 7,
        Renaming = 8,
    }
    public partial class FailoverProperties
    {
        public FailoverProperties() { }
        public bool? IsSafeFailover { get { throw null; } set { } }
    }
    public partial class FilterAction
    {
        public FilterAction() { }
        public int? CompatibilityLevel { get { throw null; } set { } }
        public bool? RequiresPreprocessing { get { throw null; } set { } }
        public string SqlExpression { get { throw null; } set { } }
    }
    public enum FilterType
    {
        SqlFilter = 0,
        CorrelationFilter = 1,
    }
    public partial class MessageCountDetails
    {
        internal MessageCountDetails() { }
        public long? ActiveMessageCount { get { throw null; } }
        public long? DeadLetterMessageCount { get { throw null; } }
        public long? ScheduledMessageCount { get { throw null; } }
        public long? TransferDeadLetterMessageCount { get { throw null; } }
        public long? TransferMessageCount { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MigrationConfigurationName : System.IEquatable<Azure.ResourceManager.ServiceBus.Models.MigrationConfigurationName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MigrationConfigurationName(string value) { throw null; }
        public static Azure.ResourceManager.ServiceBus.Models.MigrationConfigurationName Default { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceBus.Models.MigrationConfigurationName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceBus.Models.MigrationConfigurationName left, Azure.ResourceManager.ServiceBus.Models.MigrationConfigurationName right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceBus.Models.MigrationConfigurationName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceBus.Models.MigrationConfigurationName left, Azure.ResourceManager.ServiceBus.Models.MigrationConfigurationName right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ServiceBusAccessKeys
    {
        internal ServiceBusAccessKeys() { }
        public string AliasPrimaryConnectionString { get { throw null; } }
        public string AliasSecondaryConnectionString { get { throw null; } }
        public string KeyName { get { throw null; } }
        public string PrimaryConnectionString { get { throw null; } }
        public string PrimaryKey { get { throw null; } }
        public string SecondaryConnectionString { get { throw null; } }
        public string SecondaryKey { get { throw null; } }
    }
    public enum ServiceBusAccessKeyType
    {
        PrimaryKey = 0,
        SecondaryKey = 1,
    }
    public enum ServiceBusAccessRight
    {
        Manage = 0,
        Send = 1,
        Listen = 2,
    }
    public partial class ServiceBusClientAffineProperties
    {
        public ServiceBusClientAffineProperties() { }
        public string ClientId { get { throw null; } set { } }
        public bool? IsDurable { get { throw null; } set { } }
        public bool? IsShared { get { throw null; } set { } }
    }
    public enum ServiceBusDisasterRecoveryProvisioningState
    {
        Accepted = 0,
        Succeeded = 1,
        Failed = 2,
    }
    public enum ServiceBusDisasterRecoveryRole
    {
        Primary = 0,
        PrimaryNotReplicating = 1,
        Secondary = 2,
    }
    public partial class ServiceBusEncryption
    {
        public ServiceBusEncryption() { }
        public Azure.ResourceManager.ServiceBus.Models.ServiceBusEncryptionKeySource? KeySource { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ServiceBus.Models.ServiceBusKeyVaultProperties> KeyVaultProperties { get { throw null; } }
        public bool? RequireInfrastructureEncryption { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ServiceBusEncryptionKeySource : System.IEquatable<Azure.ResourceManager.ServiceBus.Models.ServiceBusEncryptionKeySource>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ServiceBusEncryptionKeySource(string value) { throw null; }
        public static Azure.ResourceManager.ServiceBus.Models.ServiceBusEncryptionKeySource MicrosoftKeyVault { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceBus.Models.ServiceBusEncryptionKeySource other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceBus.Models.ServiceBusEncryptionKeySource left, Azure.ResourceManager.ServiceBus.Models.ServiceBusEncryptionKeySource right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceBus.Models.ServiceBusEncryptionKeySource (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceBus.Models.ServiceBusEncryptionKeySource left, Azure.ResourceManager.ServiceBus.Models.ServiceBusEncryptionKeySource right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ServiceBusKeyVaultProperties
    {
        public ServiceBusKeyVaultProperties() { }
        public string KeyName { get { throw null; } set { } }
        public System.Uri KeyVaultUri { get { throw null; } set { } }
        public string KeyVersion { get { throw null; } set { } }
        public string UserAssignedIdentity { get { throw null; } set { } }
    }
    public partial class ServiceBusNameAvailabilityContent
    {
        public ServiceBusNameAvailabilityContent(string name) { }
        public string Name { get { throw null; } }
    }
    public partial class ServiceBusNameAvailabilityResult
    {
        internal ServiceBusNameAvailabilityResult() { }
        public string Message { get { throw null; } }
        public bool? NameAvailable { get { throw null; } }
        public Azure.ResourceManager.ServiceBus.Models.UnavailableReason? Reason { get { throw null; } }
    }
    public partial class ServiceBusNamespacePatch : Azure.ResourceManager.Models.TrackedResourceData
    {
        public ServiceBusNamespacePatch(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string AlternateName { get { throw null; } set { } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public bool? DisableLocalAuth { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceBus.Models.ServiceBusEncryption Encryption { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public string MetricId { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ServiceBus.ServiceBusPrivateEndpointConnectionData> PrivateEndpointConnections { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public string ServiceBusEndpoint { get { throw null; } }
        public Azure.ResourceManager.ServiceBus.Models.ServiceBusSku Sku { get { throw null; } set { } }
        public string Status { get { throw null; } }
        public System.DateTimeOffset? UpdatedOn { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ServiceBusNetworkRuleIPAction : System.IEquatable<Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleIPAction>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ServiceBusNetworkRuleIPAction(string value) { throw null; }
        public static Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleIPAction Allow { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleIPAction other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleIPAction left, Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleIPAction right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleIPAction (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleIPAction left, Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleIPAction right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ServiceBusNetworkRuleSetDefaultAction : System.IEquatable<Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleSetDefaultAction>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ServiceBusNetworkRuleSetDefaultAction(string value) { throw null; }
        public static Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleSetDefaultAction Allow { get { throw null; } }
        public static Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleSetDefaultAction Deny { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleSetDefaultAction other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleSetDefaultAction left, Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleSetDefaultAction right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleSetDefaultAction (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleSetDefaultAction left, Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleSetDefaultAction right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ServiceBusNetworkRuleSetIPRules
    {
        public ServiceBusNetworkRuleSetIPRules() { }
        public Azure.ResourceManager.ServiceBus.Models.ServiceBusNetworkRuleIPAction? Action { get { throw null; } set { } }
        public string IPMask { get { throw null; } set { } }
    }
    public partial class ServiceBusNetworkRuleSetVirtualNetworkRules
    {
        public ServiceBusNetworkRuleSetVirtualNetworkRules() { }
        public bool? IgnoreMissingVnetServiceEndpoint { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier SubnetId { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ServiceBusPrivateEndpointConnectionProvisioningState : System.IEquatable<Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateEndpointConnectionProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ServiceBusPrivateEndpointConnectionProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateEndpointConnectionProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateEndpointConnectionProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateEndpointConnectionProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateEndpointConnectionProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateEndpointConnectionProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateEndpointConnectionProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateEndpointConnectionProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateEndpointConnectionProvisioningState left, Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateEndpointConnectionProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateEndpointConnectionProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateEndpointConnectionProvisioningState left, Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateEndpointConnectionProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ServiceBusPrivateLinkConnectionStatus : System.IEquatable<Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateLinkConnectionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ServiceBusPrivateLinkConnectionStatus(string value) { throw null; }
        public static Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateLinkConnectionStatus Approved { get { throw null; } }
        public static Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateLinkConnectionStatus Disconnected { get { throw null; } }
        public static Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateLinkConnectionStatus Pending { get { throw null; } }
        public static Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateLinkConnectionStatus Rejected { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateLinkConnectionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateLinkConnectionStatus left, Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateLinkConnectionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateLinkConnectionStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateLinkConnectionStatus left, Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateLinkConnectionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ServiceBusPrivateLinkResource : Azure.ResourceManager.Models.ResourceData
    {
        internal ServiceBusPrivateLinkResource() { }
        public string GroupId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredMembers { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredZoneNames { get { throw null; } }
    }
    public partial class ServiceBusPrivateLinkServiceConnectionState
    {
        public ServiceBusPrivateLinkServiceConnectionState() { }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceBus.Models.ServiceBusPrivateLinkConnectionStatus? Status { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ServiceBusPublicNetworkAccessFlag : System.IEquatable<Azure.ResourceManager.ServiceBus.Models.ServiceBusPublicNetworkAccessFlag>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ServiceBusPublicNetworkAccessFlag(string value) { throw null; }
        public static Azure.ResourceManager.ServiceBus.Models.ServiceBusPublicNetworkAccessFlag Disabled { get { throw null; } }
        public static Azure.ResourceManager.ServiceBus.Models.ServiceBusPublicNetworkAccessFlag Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ServiceBus.Models.ServiceBusPublicNetworkAccessFlag other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ServiceBus.Models.ServiceBusPublicNetworkAccessFlag left, Azure.ResourceManager.ServiceBus.Models.ServiceBusPublicNetworkAccessFlag right) { throw null; }
        public static implicit operator Azure.ResourceManager.ServiceBus.Models.ServiceBusPublicNetworkAccessFlag (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ServiceBus.Models.ServiceBusPublicNetworkAccessFlag left, Azure.ResourceManager.ServiceBus.Models.ServiceBusPublicNetworkAccessFlag right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ServiceBusRegenerateAccessKeyContent
    {
        public ServiceBusRegenerateAccessKeyContent(Azure.ResourceManager.ServiceBus.Models.ServiceBusAccessKeyType keyType) { }
        public string Key { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceBus.Models.ServiceBusAccessKeyType KeyType { get { throw null; } }
    }
    public partial class ServiceBusSku
    {
        public ServiceBusSku(Azure.ResourceManager.ServiceBus.Models.ServiceBusSkuName name) { }
        public int? Capacity { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceBus.Models.ServiceBusSkuName Name { get { throw null; } set { } }
        public Azure.ResourceManager.ServiceBus.Models.ServiceBusSkuTier? Tier { get { throw null; } set { } }
    }
    public enum ServiceBusSkuName
    {
        Basic = 0,
        Standard = 1,
        Premium = 2,
    }
    public enum ServiceBusSkuTier
    {
        Basic = 0,
        Standard = 1,
        Premium = 2,
    }
    public partial class SqlFilter
    {
        public SqlFilter() { }
        public int? CompatibilityLevel { get { throw null; } set { } }
        public bool? RequiresPreprocessing { get { throw null; } set { } }
        public string SqlExpression { get { throw null; } set { } }
    }
    public enum UnavailableReason
    {
        None = 0,
        InvalidName = 1,
        SubscriptionIsDisabled = 2,
        NameInUse = 3,
        NameInLockdown = 4,
        TooManyNamespaceInCurrentSubscription = 5,
    }
}
