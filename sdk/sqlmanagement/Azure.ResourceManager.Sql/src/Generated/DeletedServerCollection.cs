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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of DeletedServer and their operations over its parent. </summary>
    public partial class DeletedServerCollection : ArmCollection, IEnumerable<DeletedServer>, IAsyncEnumerable<DeletedServer>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DeletedServersRestOperations _deletedServersRestClient;
        private readonly string _locationName;

        /// <summary> Initializes a new instance of the <see cref="DeletedServerCollection"/> class for mocking. </summary>
        protected DeletedServerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedServerCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        internal DeletedServerCollection(ArmResource parent, string locationName) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(DeletedServer.ResourceType, out string apiVersion);
            _deletedServersRestClient = new DeletedServersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _locationName = locationName;
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers/{deletedServerName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: DeletedServers_Get
        /// <summary> Gets a deleted server. </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public virtual Response<DeletedServer> Get(string deletedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deletedServerName, nameof(deletedServerName));

            using var scope = _clientDiagnostics.CreateScope("DeletedServerCollection.Get");
            scope.Start();
            try
            {
                var response = _deletedServersRestClient.Get(Id.SubscriptionId, _locationName, deletedServerName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedServer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers/{deletedServerName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: DeletedServers_Get
        /// <summary> Gets a deleted server. </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public async virtual Task<Response<DeletedServer>> GetAsync(string deletedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deletedServerName, nameof(deletedServerName));

            using var scope = _clientDiagnostics.CreateScope("DeletedServerCollection.Get");
            scope.Start();
            try
            {
                var response = await _deletedServersRestClient.GetAsync(Id.SubscriptionId, _locationName, deletedServerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DeletedServer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public virtual Response<DeletedServer> GetIfExists(string deletedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deletedServerName, nameof(deletedServerName));

            using var scope = _clientDiagnostics.CreateScope("DeletedServerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deletedServersRestClient.Get(Id.SubscriptionId, _locationName, deletedServerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DeletedServer>(null, response.GetRawResponse());
                return Response.FromValue(new DeletedServer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public async virtual Task<Response<DeletedServer>> GetIfExistsAsync(string deletedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deletedServerName, nameof(deletedServerName));

            using var scope = _clientDiagnostics.CreateScope("DeletedServerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deletedServersRestClient.GetAsync(Id.SubscriptionId, _locationName, deletedServerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DeletedServer>(null, response.GetRawResponse());
                return Response.FromValue(new DeletedServer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public virtual Response<bool> Exists(string deletedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deletedServerName, nameof(deletedServerName));

            using var scope = _clientDiagnostics.CreateScope("DeletedServerCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(deletedServerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string deletedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deletedServerName, nameof(deletedServerName));

            using var scope = _clientDiagnostics.CreateScope("DeletedServerCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(deletedServerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: DeletedServers_ListByLocation
        /// <summary> Gets a list of deleted servers for a location. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedServer" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedServer> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DeletedServer> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeletedServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deletedServersRestClient.ListByLocation(Id.SubscriptionId, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedServer(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeletedServer> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeletedServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deletedServersRestClient.ListByLocationNextPage(nextLink, Id.SubscriptionId, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedServer(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: DeletedServers_ListByLocation
        /// <summary> Gets a list of deleted servers for a location. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedServer" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedServer> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeletedServer>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeletedServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deletedServersRestClient.ListByLocationAsync(Id.SubscriptionId, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedServer(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeletedServer>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeletedServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deletedServersRestClient.ListByLocationNextPageAsync(nextLink, Id.SubscriptionId, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedServer(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="DeletedServer" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedServerCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DeletedServer.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DeletedServer" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedServerCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DeletedServer.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeletedServer> IEnumerable<DeletedServer>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeletedServer> IAsyncEnumerable<DeletedServer>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, DeletedServer, DeletedServerData> Construct() { }
    }
}
