// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VirtualNetworkGatewayConnection and their operations over its parent. </summary>
    public partial class VirtualNetworkGatewayConnectionCollection : ArmCollection, IEnumerable<VirtualNetworkGatewayConnection>, IAsyncEnumerable<VirtualNetworkGatewayConnection>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualNetworkGatewayConnectionsRestOperations _virtualNetworkGatewayConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayConnectionCollection"/> class for mocking. </summary>
        protected VirtualNetworkGatewayConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayConnectionCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualNetworkGatewayConnectionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(VirtualNetworkGatewayConnection.ResourceType, out string apiVersion);
            _virtualNetworkGatewayConnectionsRestClient = new VirtualNetworkGatewayConnectionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates a virtual network gateway connection in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network gateway connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayConnectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VirtualNetworkGatewayConnectionCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string virtualNetworkGatewayConnectionName, VirtualNetworkGatewayConnectionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayConnectionName, nameof(virtualNetworkGatewayConnectionName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayConnectionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, parameters, cancellationToken);
                var operation = new VirtualNetworkGatewayConnectionCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _virtualNetworkGatewayConnectionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, parameters).Request, response);
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

        /// <summary> Creates or updates a virtual network gateway connection in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network gateway connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayConnectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualNetworkGatewayConnectionCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string virtualNetworkGatewayConnectionName, VirtualNetworkGatewayConnectionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayConnectionName, nameof(virtualNetworkGatewayConnectionName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayConnectionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualNetworkGatewayConnectionCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _virtualNetworkGatewayConnectionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, parameters).Request, response);
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

        /// <summary> Gets the specified virtual network gateway connection by resource group. </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayConnectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> is null. </exception>
        public virtual Response<VirtualNetworkGatewayConnection> Get(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayConnectionName, nameof(virtualNetworkGatewayConnectionName));

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified virtual network gateway connection by resource group. </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayConnectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkGatewayConnection>> GetAsync(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayConnectionName, nameof(virtualNetworkGatewayConnectionName));

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualNetworkGatewayConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayConnectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> is null. </exception>
        public virtual Response<VirtualNetworkGatewayConnection> GetIfExists(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayConnectionName, nameof(virtualNetworkGatewayConnectionName));

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualNetworkGatewayConnection>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayConnectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkGatewayConnection>> GetIfExistsAsync(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayConnectionName, nameof(virtualNetworkGatewayConnectionName));

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualNetworkGatewayConnection>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayConnectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayConnectionName, nameof(virtualNetworkGatewayConnectionName));

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(virtualNetworkGatewayConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayConnectionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayConnectionName, nameof(virtualNetworkGatewayConnectionName));

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(virtualNetworkGatewayConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The List VirtualNetworkGatewayConnections operation retrieves all the virtual network gateways connections created. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkGatewayConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkGatewayConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualNetworkGatewayConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkGatewayConnectionsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayConnection(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualNetworkGatewayConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkGatewayConnectionsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayConnection(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The List VirtualNetworkGatewayConnections operation retrieves all the virtual network gateways connections created. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkGatewayConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkGatewayConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualNetworkGatewayConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkGatewayConnectionsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayConnection(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualNetworkGatewayConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkGatewayConnectionsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayConnection(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualNetworkGatewayConnection" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetworkGatewayConnection.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualNetworkGatewayConnection" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetworkGatewayConnection.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualNetworkGatewayConnection> IEnumerable<VirtualNetworkGatewayConnection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualNetworkGatewayConnection> IAsyncEnumerable<VirtualNetworkGatewayConnection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VirtualNetworkGatewayConnection, VirtualNetworkGatewayConnectionData> Construct() { }
    }
}
