// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SlotConfigNamesResource along with the instance operations that can be performed on it. </summary>
    public partial class SlotConfigNamesResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SlotConfigNamesResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/slotConfigNames";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;
        private readonly SlotConfigNamesResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="SlotConfigNamesResource"/> class for mocking. </summary>
        protected SlotConfigNamesResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SlotConfigNamesResource"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SlotConfigNamesResource(ArmResource options, SlotConfigNamesResourceData data) : base(options, data.Id)
        {
            HasData = true;
            _data = data;
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SlotConfigNamesResource"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SlotConfigNamesResource(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SlotConfigNamesResource"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SlotConfigNamesResource(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/config";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SlotConfigNamesResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets the parent resource of this resource. </summary>
        public ArmResource Parent { get; }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/slotConfigNames
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/slotConfigNames
        /// OperationId: WebApps_ListSlotConfigurationNames
        /// <summary> Description for Gets the names of app settings and connection strings that stick to the slot (not swapped). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SlotConfigNamesResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SlotConfigNamesResource.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.ListSlotConfigurationNamesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SlotConfigNamesResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/slotConfigNames
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/slotConfigNames
        /// OperationId: WebApps_ListSlotConfigurationNames
        /// <summary> Description for Gets the names of app settings and connection strings that stick to the slot (not swapped). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SlotConfigNamesResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SlotConfigNamesResource.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.ListSlotConfigurationNames(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SlotConfigNamesResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SlotConfigNamesResource.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SlotConfigNamesResource.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/slotConfigNames
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/slotConfigNames
        /// OperationId: WebApps_UpdateSlotConfigurationNames
        /// <summary> Description for Updates the names of application settings and connection string that remain with the slot during swap operation. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="slotConfigNames"> Names of application settings and connection strings. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="slotConfigNames"/> is null. </exception>
        public async virtual Task<SlotConfigNamesResourceCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, SlotConfigNamesResourceData slotConfigNames, CancellationToken cancellationToken = default)
        {
            if (slotConfigNames == null)
            {
                throw new ArgumentNullException(nameof(slotConfigNames));
            }

            using var scope = _clientDiagnostics.CreateScope("SlotConfigNamesResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.UpdateSlotConfigurationNamesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, slotConfigNames, cancellationToken).ConfigureAwait(false);
                var operation = new SlotConfigNamesResourceCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/slotConfigNames
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/slotConfigNames
        /// OperationId: WebApps_UpdateSlotConfigurationNames
        /// <summary> Description for Updates the names of application settings and connection string that remain with the slot during swap operation. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="slotConfigNames"> Names of application settings and connection strings. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="slotConfigNames"/> is null. </exception>
        public virtual SlotConfigNamesResourceCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, SlotConfigNamesResourceData slotConfigNames, CancellationToken cancellationToken = default)
        {
            if (slotConfigNames == null)
            {
                throw new ArgumentNullException(nameof(slotConfigNames));
            }

            using var scope = _clientDiagnostics.CreateScope("SlotConfigNamesResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.UpdateSlotConfigurationNames(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, slotConfigNames, cancellationToken);
                var operation = new SlotConfigNamesResourceCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
