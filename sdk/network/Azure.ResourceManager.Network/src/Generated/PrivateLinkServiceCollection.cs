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
    /// <summary> A class representing collection of PrivateLinkService and their operations over its parent. </summary>
    public partial class PrivateLinkServiceCollection : ArmCollection, IEnumerable<PrivateLinkService>, IAsyncEnumerable<PrivateLinkService>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly PrivateLinkServicesRestOperations _privateLinkServicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PrivateLinkServiceCollection"/> class for mocking. </summary>
        protected PrivateLinkServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateLinkServiceCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PrivateLinkServiceCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(PrivateLinkService.ResourceType, out string apiVersion);
            _privateLinkServicesRestClient = new PrivateLinkServicesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
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

        /// <summary> Creates or updates an private link service in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="parameters"> Parameters supplied to the create or update private link service operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual PrivateLinkServiceCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string serviceName, PrivateLinkServiceData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _privateLinkServicesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, serviceName, parameters, cancellationToken);
                var operation = new PrivateLinkServiceCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _privateLinkServicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serviceName, parameters).Request, response);
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

        /// <summary> Creates or updates an private link service in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="parameters"> Parameters supplied to the create or update private link service operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<PrivateLinkServiceCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string serviceName, PrivateLinkServiceData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _privateLinkServicesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new PrivateLinkServiceCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _privateLinkServicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serviceName, parameters).Request, response);
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

        /// <summary> Gets the specified private link service by resource group. </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<PrivateLinkService> Get(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _privateLinkServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateLinkService(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified private link service by resource group. </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public async virtual Task<Response<PrivateLinkService>> GetAsync(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _privateLinkServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PrivateLinkService(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<PrivateLinkService> GetIfExists(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _privateLinkServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<PrivateLinkService>(null, response.GetRawResponse());
                return Response.FromValue(new PrivateLinkService(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public async virtual Task<Response<PrivateLinkService>> GetIfExistsAsync(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _privateLinkServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<PrivateLinkService>(null, response.GetRawResponse());
                return Response.FromValue(new PrivateLinkService(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<bool> Exists(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(serviceName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serviceName"> The name of the private link service. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string serviceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(serviceName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all private link services in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateLinkService" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateLinkService> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PrivateLinkService> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateLinkServicesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateLinkService(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PrivateLinkService> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateLinkServicesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateLinkService(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all private link services in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateLinkService" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateLinkService> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PrivateLinkService>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateLinkServicesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateLinkService(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PrivateLinkService>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateLinkServicesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateLinkService(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="PrivateLinkService" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PrivateLinkService.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="PrivateLinkService" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateLinkServiceCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PrivateLinkService.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PrivateLinkService> IEnumerable<PrivateLinkService>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PrivateLinkService> IAsyncEnumerable<PrivateLinkService>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, PrivateLinkService, PrivateLinkServiceData> Construct() { }
    }
}
