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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A Class representing a RestorePointGroup along with the instance operations that can be performed on it. </summary>
    public partial class RestorePointGroup : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RestorePointGroup"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string restorePointCollectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _restorePointGroupRestorePointCollectionsClientDiagnostics;
        private readonly RestorePointCollectionsRestOperations _restorePointGroupRestorePointCollectionsRestClient;
        private readonly RestorePointGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="RestorePointGroup"/> class for mocking. </summary>
        protected RestorePointGroup()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RestorePointGroup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RestorePointGroup(ArmClient client, RestorePointGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RestorePointGroup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RestorePointGroup(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _restorePointGroupRestorePointCollectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string restorePointGroupRestorePointCollectionsApiVersion);
            _restorePointGroupRestorePointCollectionsRestClient = new RestorePointCollectionsRestOperations(_restorePointGroupRestorePointCollectionsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, restorePointGroupRestorePointCollectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/restorePointCollections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RestorePointGroupData Data
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

        /// <summary> Gets a collection of RestorePoints in the RestorePoint. </summary>
        /// <returns> An object representing collection of RestorePoints and their operations over a RestorePoint. </returns>
        public virtual RestorePointCollection GetRestorePoints()
        {
            return new RestorePointCollection(Client, Id);
        }

        /// <summary>
        /// The operation to get the restore point collection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Get
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<RestorePointGroup>> GetAsync(RestorePointCollectionExpandOptions? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroup.Get");
            scope.Start();
            try
            {
                var response = await _restorePointGroupRestorePointCollectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RestorePointGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the restore point collection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Get
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. If expand=restorePoints, server will return all contained restore points in the restorePointCollection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RestorePointGroup> Get(RestorePointCollectionExpandOptions? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroup.Get");
            scope.Start();
            try
            {
                var response = _restorePointGroupRestorePointCollectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorePointGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to delete the restore point collection. This operation will also delete all the contained restore points.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroup.Delete");
            scope.Start();
            try
            {
                var response = await _restorePointGroupRestorePointCollectionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation(_restorePointGroupRestorePointCollectionsClientDiagnostics, Pipeline, _restorePointGroupRestorePointCollectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to delete the restore point collection. This operation will also delete all the contained restore points.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroup.Delete");
            scope.Start();
            try
            {
                var response = _restorePointGroupRestorePointCollectionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new ComputeArmOperation(_restorePointGroupRestorePointCollectionsClientDiagnostics, Pipeline, _restorePointGroupRestorePointCollectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to update the restore point collection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Update
        /// </summary>
        /// <param name="options"> Parameters supplied to the Update restore point collection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public async virtual Task<Response<RestorePointGroup>> UpdateAsync(RestorePointGroupUpdateOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(options, nameof(options));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroup.Update");
            scope.Start();
            try
            {
                var response = await _restorePointGroupRestorePointCollectionsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new RestorePointGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to update the restore point collection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Update
        /// </summary>
        /// <param name="options"> Parameters supplied to the Update restore point collection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public virtual Response<RestorePointGroup> Update(RestorePointGroupUpdateOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(options, nameof(options));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroup.Update");
            scope.Start();
            try
            {
                var response = _restorePointGroupRestorePointCollectionsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options, cancellationToken);
                return Response.FromValue(new RestorePointGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<RestorePointGroup>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroup.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restorePointGroupRestorePointCollectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new RestorePointGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<RestorePointGroup> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroup.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _restorePointGroupRestorePointCollectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new RestorePointGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<RestorePointGroup>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroup.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restorePointGroupRestorePointCollectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new RestorePointGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<RestorePointGroup> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroup.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _restorePointGroupRestorePointCollectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new RestorePointGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<RestorePointGroup>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroup.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _restorePointGroupRestorePointCollectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new RestorePointGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}
        /// Operation Id: RestorePointCollections_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<RestorePointGroup> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _restorePointGroupRestorePointCollectionsClientDiagnostics.CreateScope("RestorePointGroup.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _restorePointGroupRestorePointCollectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new RestorePointGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
