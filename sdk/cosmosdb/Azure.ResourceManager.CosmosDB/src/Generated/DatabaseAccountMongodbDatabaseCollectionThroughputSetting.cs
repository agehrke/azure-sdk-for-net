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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A Class representing a DatabaseAccountMongodbDatabaseCollectionThroughputSetting along with the instance operations that can be performed on it. </summary>
    public partial class DatabaseAccountMongodbDatabaseCollectionThroughputSetting : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DatabaseAccountMongodbDatabaseCollectionThroughputSetting"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string databaseName, string collectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}/throughputSettings/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics;
        private readonly MongoDBResourcesRestOperations _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient;
        private readonly ThroughputSettingsData _data;

        /// <summary> Initializes a new instance of the <see cref="DatabaseAccountMongodbDatabaseCollectionThroughputSetting"/> class for mocking. </summary>
        protected DatabaseAccountMongodbDatabaseCollectionThroughputSetting()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DatabaseAccountMongodbDatabaseCollectionThroughputSetting"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DatabaseAccountMongodbDatabaseCollectionThroughputSetting(ArmClient client, ThroughputSettingsData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DatabaseAccountMongodbDatabaseCollectionThroughputSetting"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DatabaseAccountMongodbDatabaseCollectionThroughputSetting(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesApiVersion);
            _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient = new MongoDBResourcesRestOperations(_databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/databaseAccounts/mongodbDatabases/collections/throughputSettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ThroughputSettingsData Data
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

        /// <summary>
        /// Gets the RUs per second of the MongoDB collection under an existing Azure Cosmos DB database account with the provided name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}/throughputSettings/default
        /// Operation Id: MongoDBResources_GetMongoDBCollectionThroughput
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DatabaseAccountMongodbDatabaseCollectionThroughputSetting>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseCollectionThroughputSetting.Get");
            scope.Start();
            try
            {
                var response = await _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.GetMongoDBCollectionThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountMongodbDatabaseCollectionThroughputSetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the RUs per second of the MongoDB collection under an existing Azure Cosmos DB database account with the provided name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}/throughputSettings/default
        /// Operation Id: MongoDBResources_GetMongoDBCollectionThroughput
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DatabaseAccountMongodbDatabaseCollectionThroughputSetting> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseCollectionThroughputSetting.Get");
            scope.Start();
            try
            {
                var response = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.GetMongoDBCollectionThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseAccountMongodbDatabaseCollectionThroughputSetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the RUs per second of an Azure Cosmos DB MongoDB collection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}/throughputSettings/default
        /// Operation Id: MongoDBResources_UpdateMongoDBCollectionThroughput
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="updateThroughputParameters"> The RUs per second of the parameters to provide for the current MongoDB collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateThroughputParameters"/> is null. </exception>
        public async virtual Task<ArmOperation<DatabaseAccountMongodbDatabaseCollectionThroughputSetting>> CreateOrUpdateAsync(bool waitForCompletion, ThroughputSettingsUpdateOptions updateThroughputParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(updateThroughputParameters, nameof(updateThroughputParameters));

            using var scope = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseCollectionThroughputSetting.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.UpdateMongoDBCollectionThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<DatabaseAccountMongodbDatabaseCollectionThroughputSetting>(new DatabaseAccountMongodbDatabaseCollectionThroughputSettingOperationSource(Client), _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics, Pipeline, _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.CreateUpdateMongoDBCollectionThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Update the RUs per second of an Azure Cosmos DB MongoDB collection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}/throughputSettings/default
        /// Operation Id: MongoDBResources_UpdateMongoDBCollectionThroughput
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="updateThroughputParameters"> The RUs per second of the parameters to provide for the current MongoDB collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateThroughputParameters"/> is null. </exception>
        public virtual ArmOperation<DatabaseAccountMongodbDatabaseCollectionThroughputSetting> CreateOrUpdate(bool waitForCompletion, ThroughputSettingsUpdateOptions updateThroughputParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(updateThroughputParameters, nameof(updateThroughputParameters));

            using var scope = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseCollectionThroughputSetting.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.UpdateMongoDBCollectionThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters, cancellationToken);
                var operation = new CosmosDBArmOperation<DatabaseAccountMongodbDatabaseCollectionThroughputSetting>(new DatabaseAccountMongodbDatabaseCollectionThroughputSettingOperationSource(Client), _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics, Pipeline, _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.CreateUpdateMongoDBCollectionThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Migrate an Azure Cosmos DB MongoDB collection from manual throughput to autoscale
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}/throughputSettings/default/migrateToAutoscale
        /// Operation Id: MongoDBResources_MigrateMongoDBCollectionToAutoscale
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation<DatabaseAccountMongodbDatabaseCollectionThroughputSetting>> MigrateMongoDBCollectionToAutoscaleAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseCollectionThroughputSetting.MigrateMongoDBCollectionToAutoscale");
            scope.Start();
            try
            {
                var response = await _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.MigrateMongoDBCollectionToAutoscaleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<DatabaseAccountMongodbDatabaseCollectionThroughputSetting>(new DatabaseAccountMongodbDatabaseCollectionThroughputSettingOperationSource(Client), _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics, Pipeline, _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.CreateMigrateMongoDBCollectionToAutoscaleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Migrate an Azure Cosmos DB MongoDB collection from manual throughput to autoscale
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}/throughputSettings/default/migrateToAutoscale
        /// Operation Id: MongoDBResources_MigrateMongoDBCollectionToAutoscale
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<DatabaseAccountMongodbDatabaseCollectionThroughputSetting> MigrateMongoDBCollectionToAutoscale(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseCollectionThroughputSetting.MigrateMongoDBCollectionToAutoscale");
            scope.Start();
            try
            {
                var response = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.MigrateMongoDBCollectionToAutoscale(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                var operation = new CosmosDBArmOperation<DatabaseAccountMongodbDatabaseCollectionThroughputSetting>(new DatabaseAccountMongodbDatabaseCollectionThroughputSettingOperationSource(Client), _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics, Pipeline, _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.CreateMigrateMongoDBCollectionToAutoscaleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Migrate an Azure Cosmos DB MongoDB collection from autoscale to manual throughput
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}/throughputSettings/default/migrateToManualThroughput
        /// Operation Id: MongoDBResources_MigrateMongoDBCollectionToManualThroughput
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation<DatabaseAccountMongodbDatabaseCollectionThroughputSetting>> MigrateMongoDBCollectionToManualThroughputAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseCollectionThroughputSetting.MigrateMongoDBCollectionToManualThroughput");
            scope.Start();
            try
            {
                var response = await _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.MigrateMongoDBCollectionToManualThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<DatabaseAccountMongodbDatabaseCollectionThroughputSetting>(new DatabaseAccountMongodbDatabaseCollectionThroughputSettingOperationSource(Client), _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics, Pipeline, _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.CreateMigrateMongoDBCollectionToManualThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Migrate an Azure Cosmos DB MongoDB collection from autoscale to manual throughput
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}/throughputSettings/default/migrateToManualThroughput
        /// Operation Id: MongoDBResources_MigrateMongoDBCollectionToManualThroughput
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<DatabaseAccountMongodbDatabaseCollectionThroughputSetting> MigrateMongoDBCollectionToManualThroughput(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseCollectionThroughputSetting.MigrateMongoDBCollectionToManualThroughput");
            scope.Start();
            try
            {
                var response = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.MigrateMongoDBCollectionToManualThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                var operation = new CosmosDBArmOperation<DatabaseAccountMongodbDatabaseCollectionThroughputSetting>(new DatabaseAccountMongodbDatabaseCollectionThroughputSettingOperationSource(Client), _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics, Pipeline, _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.CreateMigrateMongoDBCollectionToManualThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}/throughputSettings/default
        /// Operation Id: MongoDBResources_GetMongoDBCollectionThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<DatabaseAccountMongodbDatabaseCollectionThroughputSetting>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseCollectionThroughputSetting.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.GetMongoDBCollectionThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountMongodbDatabaseCollectionThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}/throughputSettings/default
        /// Operation Id: MongoDBResources_GetMongoDBCollectionThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<DatabaseAccountMongodbDatabaseCollectionThroughputSetting> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseCollectionThroughputSetting.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.GetMongoDBCollectionThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountMongodbDatabaseCollectionThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}/throughputSettings/default
        /// Operation Id: MongoDBResources_GetMongoDBCollectionThroughput
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<DatabaseAccountMongodbDatabaseCollectionThroughputSetting>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseCollectionThroughputSetting.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.GetMongoDBCollectionThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountMongodbDatabaseCollectionThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}/throughputSettings/default
        /// Operation Id: MongoDBResources_GetMongoDBCollectionThroughput
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<DatabaseAccountMongodbDatabaseCollectionThroughputSetting> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseCollectionThroughputSetting.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.GetMongoDBCollectionThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountMongodbDatabaseCollectionThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}/throughputSettings/default
        /// Operation Id: MongoDBResources_GetMongoDBCollectionThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<DatabaseAccountMongodbDatabaseCollectionThroughputSetting>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseCollectionThroughputSetting.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.GetMongoDBCollectionThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountMongodbDatabaseCollectionThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}/throughputSettings/default
        /// Operation Id: MongoDBResources_GetMongoDBCollectionThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<DatabaseAccountMongodbDatabaseCollectionThroughputSetting> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseCollectionThroughputSetting.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountMongodbDatabaseCollectionThroughputSettingMongoDBResourcesRestClient.GetMongoDBCollectionThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountMongodbDatabaseCollectionThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
