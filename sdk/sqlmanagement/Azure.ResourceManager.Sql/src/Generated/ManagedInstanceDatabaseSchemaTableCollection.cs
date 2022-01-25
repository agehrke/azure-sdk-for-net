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
    /// <summary> A class representing collection of DatabaseTable and their operations over its parent. </summary>
    public partial class ManagedInstanceDatabaseSchemaTableCollection : ArmCollection, IEnumerable<ManagedInstanceDatabaseSchemaTable>, IAsyncEnumerable<ManagedInstanceDatabaseSchemaTable>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ManagedDatabaseTablesRestOperations _managedDatabaseTablesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTableCollection"/> class for mocking. </summary>
        protected ManagedInstanceDatabaseSchemaTableCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTableCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ManagedInstanceDatabaseSchemaTableCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ManagedInstanceDatabaseSchemaTable.ResourceType, out string apiVersion);
            _managedDatabaseTablesRestClient = new ManagedDatabaseTablesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstanceDatabaseSchema.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstanceDatabaseSchema.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}
        /// OperationId: ManagedDatabaseTables_Get
        /// <summary> Get managed database table. </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<ManagedInstanceDatabaseSchemaTable> Get(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.Get");
            scope.Start();
            try
            {
                var response = _managedDatabaseTablesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTable(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}
        /// OperationId: ManagedDatabaseTables_Get
        /// <summary> Get managed database table. </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public async virtual Task<Response<ManagedInstanceDatabaseSchemaTable>> GetAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedDatabaseTablesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTable(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<ManagedInstanceDatabaseSchemaTable> GetIfExists(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedDatabaseTablesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceDatabaseSchemaTable>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTable(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public async virtual Task<Response<ManagedInstanceDatabaseSchemaTable>> GetIfExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedDatabaseTablesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceDatabaseSchemaTable>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTable(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<bool> Exists(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(tableName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}
        /// OperationId: ManagedDatabaseTables_ListBySchema
        /// <summary> List managed database tables. </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceDatabaseSchemaTable" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceDatabaseSchemaTable> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<ManagedInstanceDatabaseSchemaTable> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedDatabaseTablesRestClient.ListBySchema(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseSchemaTable(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstanceDatabaseSchemaTable> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedDatabaseTablesRestClient.ListBySchemaNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseSchemaTable(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}
        /// OperationId: ManagedDatabaseTables_ListBySchema
        /// <summary> List managed database tables. </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceDatabaseSchemaTable" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceDatabaseSchemaTable> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedInstanceDatabaseSchemaTable>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedDatabaseTablesRestClient.ListBySchemaAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseSchemaTable(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstanceDatabaseSchemaTable>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedDatabaseTablesRestClient.ListBySchemaNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseSchemaTable(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ManagedInstanceDatabaseSchemaTable> IEnumerable<ManagedInstanceDatabaseSchemaTable>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceDatabaseSchemaTable> IAsyncEnumerable<ManagedInstanceDatabaseSchemaTable>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ManagedInstanceDatabaseSchemaTable, DatabaseTableData> Construct() { }
    }
}
