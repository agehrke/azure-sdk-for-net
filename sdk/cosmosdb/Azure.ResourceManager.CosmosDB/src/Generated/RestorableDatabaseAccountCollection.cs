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
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of RestorableDatabaseAccount and their operations over its parent. </summary>
    public partial class RestorableDatabaseAccountCollection : ArmCollection, IEnumerable<RestorableDatabaseAccount>, IAsyncEnumerable<RestorableDatabaseAccount>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly RestorableDatabaseAccountsRestOperations _restorableDatabaseAccountsRestClient;
        private readonly string _location;

        /// <summary> Initializes a new instance of the <see cref="RestorableDatabaseAccountCollection"/> class for mocking. </summary>
        protected RestorableDatabaseAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RestorableDatabaseAccountCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        internal RestorableDatabaseAccountCollection(ArmResource parent, string location) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(RestorableDatabaseAccount.ResourceType, out string apiVersion);
            _restorableDatabaseAccountsRestClient = new RestorableDatabaseAccountsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _location = location;
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

        /// <summary> Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*&apos; permission. </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<RestorableDatabaseAccount> Get(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _restorableDatabaseAccountsRestClient.GetByLocation(Id.SubscriptionId, _location, instanceId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableDatabaseAccount(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*&apos; permission. </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<RestorableDatabaseAccount>> GetAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _restorableDatabaseAccountsRestClient.GetByLocationAsync(Id.SubscriptionId, _location, instanceId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RestorableDatabaseAccount(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<RestorableDatabaseAccount> GetIfExists(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _restorableDatabaseAccountsRestClient.GetByLocation(Id.SubscriptionId, _location, instanceId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<RestorableDatabaseAccount>(null, response.GetRawResponse());
                return Response.FromValue(new RestorableDatabaseAccount(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<RestorableDatabaseAccount>> GetIfExistsAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _restorableDatabaseAccountsRestClient.GetByLocationAsync(Id.SubscriptionId, _location, instanceId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<RestorableDatabaseAccount>(null, response.GetRawResponse());
                return Response.FromValue(new RestorableDatabaseAccount(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<bool> Exists(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(instanceId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(instanceId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the restorable Azure Cosmos DB database accounts available under the subscription and in a region.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read&apos; permission. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableDatabaseAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableDatabaseAccount> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RestorableDatabaseAccount> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restorableDatabaseAccountsRestClient.ListByLocation(Id.SubscriptionId, _location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorableDatabaseAccount(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists all the restorable Azure Cosmos DB database accounts available under the subscription and in a region.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read&apos; permission. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableDatabaseAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableDatabaseAccount> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RestorableDatabaseAccount>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restorableDatabaseAccountsRestClient.ListByLocationAsync(Id.SubscriptionId, _location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorableDatabaseAccount(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Filters the list of <see cref="RestorableDatabaseAccount" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(RestorableDatabaseAccount.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="RestorableDatabaseAccount" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RestorableDatabaseAccountCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(RestorableDatabaseAccount.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RestorableDatabaseAccount> IEnumerable<RestorableDatabaseAccount>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RestorableDatabaseAccount> IAsyncEnumerable<RestorableDatabaseAccount>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, RestorableDatabaseAccount, RestorableDatabaseAccountData> Construct() { }
    }
}
