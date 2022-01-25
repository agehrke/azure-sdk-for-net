// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of Feature and their operations over its parent. </summary>
    [CodeGenSuppress("FeatureCollection", typeof(ArmResource))]
    public partial class FeatureCollection : ArmCollection, IEnumerable<Feature>, IAsyncEnumerable<Feature>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureCollection"/> class.
        /// </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
       internal FeatureCollection(Provider parent)
            : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(Feature.ResourceType, out var version);
            _featuresRestClient = new FeaturesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, version);
#if DEBUG
            ValidateResourceId(Id);
#endif
        }

        /// <summary>
        /// Gets the parent resource of this resource.
        /// </summary>
        protected new Provider Parent { get {return base.Parent as Provider;} }

    }
}
