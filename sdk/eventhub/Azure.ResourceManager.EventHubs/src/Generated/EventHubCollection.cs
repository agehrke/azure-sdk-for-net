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

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class representing collection of EventHub and their operations over its parent. </summary>
    public partial class EventHubCollection : ArmCollection, IEnumerable<EventHub>, IAsyncEnumerable<EventHub>
    {
        private readonly ClientDiagnostics _eventHubClientDiagnostics;
        private readonly EventHubsRestOperations _eventHubRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventHubCollection"/> class for mocking. </summary>
        protected EventHubCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EventHubCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventHubClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHub.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(EventHub.ResourceType, out string eventHubApiVersion);
            _eventHubRestClient = new EventHubsRestOperations(_eventHubClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, eventHubApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventHubNamespace.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventHubNamespace.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a new Event Hub as a nested resource within a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}
        /// Operation Id: EventHubs_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="eventHubName"> The Event Hub name. </param>
        /// <param name="parameters"> Parameters supplied to create an Event Hub resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventHubName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<EventHub>> CreateOrUpdateAsync(bool waitForCompletion, string eventHubName, EventHubData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventHubName, nameof(eventHubName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventHubRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventHubName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new EventHubsArmOperation<EventHub>(Response.FromValue(new EventHub(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a new Event Hub as a nested resource within a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}
        /// Operation Id: EventHubs_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="eventHubName"> The Event Hub name. </param>
        /// <param name="parameters"> Parameters supplied to create an Event Hub resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventHubName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<EventHub> CreateOrUpdate(bool waitForCompletion, string eventHubName, EventHubData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventHubName, nameof(eventHubName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventHubRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventHubName, parameters, cancellationToken);
                var operation = new EventHubsArmOperation<EventHub>(Response.FromValue(new EventHub(Client, response), response.GetRawResponse()));
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
        /// Gets an Event Hubs description for the specified Event Hub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}
        /// Operation Id: EventHubs_Get
        /// </summary>
        /// <param name="eventHubName"> The Event Hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventHubName"/> is null. </exception>
        public async virtual Task<Response<EventHub>> GetAsync(string eventHubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventHubName, nameof(eventHubName));

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventHubName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _eventHubClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new EventHub(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an Event Hubs description for the specified Event Hub.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}
        /// Operation Id: EventHubs_Get
        /// </summary>
        /// <param name="eventHubName"> The Event Hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventHubName"/> is null. </exception>
        public virtual Response<EventHub> Get(string eventHubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventHubName, nameof(eventHubName));

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.Get");
            scope.Start();
            try
            {
                var response = _eventHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventHubName, cancellationToken);
                if (response.Value == null)
                    throw _eventHubClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHub(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the Event Hubs in a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs
        /// Operation Id: EventHubs_ListByNamespace
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHub" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHub> GetAllAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<EventHub>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _eventHubRestClient.ListByNamespaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHub(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EventHub>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _eventHubRestClient.ListByNamespaceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHub(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all the Event Hubs in a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs
        /// Operation Id: EventHubs_ListByNamespace
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHub" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHub> GetAll(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<EventHub> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _eventHubRestClient.ListByNamespace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHub(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EventHub> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _eventHubRestClient.ListByNamespaceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHub(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}
        /// Operation Id: EventHubs_Get
        /// </summary>
        /// <param name="eventHubName"> The Event Hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventHubName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string eventHubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventHubName, nameof(eventHubName));

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(eventHubName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}
        /// Operation Id: EventHubs_Get
        /// </summary>
        /// <param name="eventHubName"> The Event Hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventHubName"/> is null. </exception>
        public virtual Response<bool> Exists(string eventHubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventHubName, nameof(eventHubName));

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(eventHubName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}
        /// Operation Id: EventHubs_Get
        /// </summary>
        /// <param name="eventHubName"> The Event Hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventHubName"/> is null. </exception>
        public async virtual Task<Response<EventHub>> GetIfExistsAsync(string eventHubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventHubName, nameof(eventHubName));

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _eventHubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventHubName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<EventHub>(null, response.GetRawResponse());
                return Response.FromValue(new EventHub(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}
        /// Operation Id: EventHubs_Get
        /// </summary>
        /// <param name="eventHubName"> The Event Hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventHubName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventHubName"/> is null. </exception>
        public virtual Response<EventHub> GetIfExists(string eventHubName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventHubName, nameof(eventHubName));

            using var scope = _eventHubClientDiagnostics.CreateScope("EventHubCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _eventHubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, eventHubName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<EventHub>(null, response.GetRawResponse());
                return Response.FromValue(new EventHub(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventHub> IEnumerable<EventHub>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventHub> IAsyncEnumerable<EventHub>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
