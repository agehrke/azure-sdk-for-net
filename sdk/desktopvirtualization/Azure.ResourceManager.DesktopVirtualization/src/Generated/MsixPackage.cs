// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary> A Class representing a MsixPackage along with the instance operations that can be performed on it. </summary>
    public partial class MsixPackage : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MsixPackage"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string hostPoolName, string msixPackageFullName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/msixPackages/{msixPackageFullName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _msixPackageMSIXPackagesClientDiagnostics;
        private readonly MsixPackagesRestOperations _msixPackageMSIXPackagesRestClient;
        private readonly MsixPackageData _data;

        /// <summary> Initializes a new instance of the <see cref="MsixPackage"/> class for mocking. </summary>
        protected MsixPackage()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MsixPackage"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MsixPackage(ArmClient client, MsixPackageData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MsixPackage"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MsixPackage(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _msixPackageMSIXPackagesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string msixPackageMSIXPackagesApiVersion);
            _msixPackageMSIXPackagesRestClient = new MsixPackagesRestOperations(_msixPackageMSIXPackagesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, msixPackageMSIXPackagesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DesktopVirtualization/hostPools/msixPackages";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MsixPackageData Data
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
        /// Get a msixpackage.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/msixPackages/{msixPackageFullName}
        /// Operation Id: MSIXPackages_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<MsixPackage>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _msixPackageMSIXPackagesClientDiagnostics.CreateScope("MsixPackage.Get");
            scope.Start();
            try
            {
                var response = await _msixPackageMSIXPackagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _msixPackageMSIXPackagesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new MsixPackage(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a msixpackage.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/msixPackages/{msixPackageFullName}
        /// Operation Id: MSIXPackages_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MsixPackage> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _msixPackageMSIXPackagesClientDiagnostics.CreateScope("MsixPackage.Get");
            scope.Start();
            try
            {
                var response = _msixPackageMSIXPackagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _msixPackageMSIXPackagesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MsixPackage(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Remove an MSIX Package.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/msixPackages/{msixPackageFullName}
        /// Operation Id: MSIXPackages_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _msixPackageMSIXPackagesClientDiagnostics.CreateScope("MsixPackage.Delete");
            scope.Start();
            try
            {
                var response = await _msixPackageMSIXPackagesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DesktopVirtualizationArmOperation(response);
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
        /// Remove an MSIX Package.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/msixPackages/{msixPackageFullName}
        /// Operation Id: MSIXPackages_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _msixPackageMSIXPackagesClientDiagnostics.CreateScope("MsixPackage.Delete");
            scope.Start();
            try
            {
                var response = _msixPackageMSIXPackagesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DesktopVirtualizationArmOperation(response);
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
        /// Update an  MSIX Package.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/msixPackages/{msixPackageFullName}
        /// Operation Id: MSIXPackages_Update
        /// </summary>
        /// <param name="data"> Object containing MSIX Package definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public async virtual Task<Response<MsixPackage>> UpdateAsync(PatchableMsixPackageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _msixPackageMSIXPackagesClientDiagnostics.CreateScope("MsixPackage.Update");
            scope.Start();
            try
            {
                var response = await _msixPackageMSIXPackagesRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new MsixPackage(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update an  MSIX Package.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/msixPackages/{msixPackageFullName}
        /// Operation Id: MSIXPackages_Update
        /// </summary>
        /// <param name="data"> Object containing MSIX Package definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<MsixPackage> Update(PatchableMsixPackageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _msixPackageMSIXPackagesClientDiagnostics.CreateScope("MsixPackage.Update");
            scope.Start();
            try
            {
                var response = _msixPackageMSIXPackagesRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                return Response.FromValue(new MsixPackage(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
