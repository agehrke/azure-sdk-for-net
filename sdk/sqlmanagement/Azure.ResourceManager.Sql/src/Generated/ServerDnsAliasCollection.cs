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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ServerDnsAlias and their operations over its parent. </summary>
    public partial class ServerDnsAliasCollection : ArmCollection, IEnumerable<ServerDnsAlias>, IAsyncEnumerable<ServerDnsAlias>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ServerDnsAliasesRestOperations _serverDnsAliasesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerDnsAliasCollection"/> class for mocking. </summary>
        protected ServerDnsAliasCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerDnsAliasCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServerDnsAliasCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ServerDnsAlias.ResourceType, out string apiVersion);
            _serverDnsAliasesRestClient = new ServerDnsAliasesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServer.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases/{dnsAliasName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDnsAliases_CreateOrUpdate
        /// <summary> Creates a server DNS alias. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual ServerDnsAliasCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverDnsAliasesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken);
                var operation = new ServerDnsAliasCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _serverDnsAliasesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases/{dnsAliasName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDnsAliases_CreateOrUpdate
        /// <summary> Creates a server DNS alias. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public async virtual Task<ServerDnsAliasCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverDnsAliasesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken).ConfigureAwait(false);
                var operation = new ServerDnsAliasCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _serverDnsAliasesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases/{dnsAliasName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDnsAliases_Get
        /// <summary> Gets a server DNS alias. </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual Response<ServerDnsAlias> Get(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.Get");
            scope.Start();
            try
            {
                var response = _serverDnsAliasesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDnsAlias(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases/{dnsAliasName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDnsAliases_Get
        /// <summary> Gets a server DNS alias. </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public async virtual Task<Response<ServerDnsAlias>> GetAsync(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverDnsAliasesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerDnsAlias(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual Response<ServerDnsAlias> GetIfExists(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverDnsAliasesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerDnsAlias>(null, response.GetRawResponse());
                return Response.FromValue(new ServerDnsAlias(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public async virtual Task<Response<ServerDnsAlias>> GetIfExistsAsync(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverDnsAliasesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerDnsAlias>(null, response.GetRawResponse());
                return Response.FromValue(new ServerDnsAlias(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual Response<bool> Exists(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(dnsAliasName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(dnsAliasName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDnsAliases_ListByServer
        /// <summary> Gets a list of server DNS aliases for a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerDnsAlias" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerDnsAlias> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerDnsAlias> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverDnsAliasesRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDnsAlias(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerDnsAlias> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverDnsAliasesRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDnsAlias(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDnsAliases_ListByServer
        /// <summary> Gets a list of server DNS aliases for a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerDnsAlias" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerDnsAlias> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerDnsAlias>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverDnsAliasesRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDnsAlias(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerDnsAlias>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverDnsAliasesRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDnsAlias(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ServerDnsAlias> IEnumerable<ServerDnsAlias>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerDnsAlias> IAsyncEnumerable<ServerDnsAlias>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ServerDnsAlias, ServerDnsAliasData> Construct() { }
    }
}
