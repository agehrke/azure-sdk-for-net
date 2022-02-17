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

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of ServerfarmVirtualNetworkConnection and their operations over its parent. </summary>
    public partial class ServerfarmVirtualNetworkConnectionCollection : ArmCollection, IEnumerable<ServerfarmVirtualNetworkConnection>, IAsyncEnumerable<ServerfarmVirtualNetworkConnection>
    {
        private readonly ClientDiagnostics _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics;
        private readonly AppServicePlansRestOperations _serverfarmVirtualNetworkConnectionAppServicePlansRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnectionCollection"/> class for mocking. </summary>
        protected ServerfarmVirtualNetworkConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerfarmVirtualNetworkConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ServerfarmVirtualNetworkConnection.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ServerfarmVirtualNetworkConnection.ResourceType, out string serverfarmVirtualNetworkConnectionAppServicePlansApiVersion);
            _serverfarmVirtualNetworkConnectionAppServicePlansRestClient = new AppServicePlansRestOperations(_serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverfarmVirtualNetworkConnectionAppServicePlansApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppServicePlan.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppServicePlan.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get a Virtual Network associated with an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// Operation Id: AppServicePlans_GetVnetFromServerFarm
        /// </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public async virtual Task<Response<ServerfarmVirtualNetworkConnection>> GetAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.GetVnetFromServerFarmAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerfarmVirtualNetworkConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get a Virtual Network associated with an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// Operation Id: AppServicePlans_GetVnetFromServerFarm
        /// </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<ServerfarmVirtualNetworkConnection> Get(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.GetVnetFromServerFarm(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken);
                if (response.Value == null)
                    throw _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get all Virtual Networks associated with an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections
        /// Operation Id: AppServicePlans_ListVnets
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerfarmVirtualNetworkConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerfarmVirtualNetworkConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerfarmVirtualNetworkConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.ListVnetsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Select(value => new ServerfarmVirtualNetworkConnection(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Description for Get all Virtual Networks associated with an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections
        /// Operation Id: AppServicePlans_ListVnets
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerfarmVirtualNetworkConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerfarmVirtualNetworkConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerfarmVirtualNetworkConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.ListVnets(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Select(value => new ServerfarmVirtualNetworkConnection(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// Operation Id: AppServicePlans_GetVnetFromServerFarm
        /// </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(vnetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// Operation Id: AppServicePlans_GetVnetFromServerFarm
        /// </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<bool> Exists(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(vnetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// Operation Id: AppServicePlans_GetVnetFromServerFarm
        /// </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public async virtual Task<Response<ServerfarmVirtualNetworkConnection>> GetIfExistsAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.GetVnetFromServerFarmAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerfarmVirtualNetworkConnection>(null, response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// Operation Id: AppServicePlans_GetVnetFromServerFarm
        /// </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<ServerfarmVirtualNetworkConnection> GetIfExists(string vnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vnetName, nameof(vnetName));

            using var scope = _serverfarmVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverfarmVirtualNetworkConnectionAppServicePlansRestClient.GetVnetFromServerFarm(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerfarmVirtualNetworkConnection>(null, response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerfarmVirtualNetworkConnection> IEnumerable<ServerfarmVirtualNetworkConnection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerfarmVirtualNetworkConnection> IAsyncEnumerable<ServerfarmVirtualNetworkConnection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
