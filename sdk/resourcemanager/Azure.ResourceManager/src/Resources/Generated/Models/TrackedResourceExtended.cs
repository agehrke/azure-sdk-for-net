// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Specified resource. </summary>
    public partial class TrackedResourceExtended : TrackedResource
    {
        /// <summary> Initializes a new instance of TrackedResourceExtended. </summary>
        /// <param name="location"> The location. </param>
        public TrackedResourceExtended(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of TrackedResourceExtended. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> Resource extended location. </param>
        internal TrackedResourceExtended(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation) : base(id, name, type, tags, location)
        {
            ExtendedLocation = extendedLocation;
        }

        /// <summary> Resource extended location. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
    }
}
