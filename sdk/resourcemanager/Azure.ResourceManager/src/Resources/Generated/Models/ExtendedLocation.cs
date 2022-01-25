// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Resource extended location. </summary>
    public partial class ExtendedLocation
    {
        /// <summary> Initializes a new instance of ExtendedLocation. </summary>
        public ExtendedLocation()
        {
        }

        /// <summary> Initializes a new instance of ExtendedLocation. </summary>
        /// <param name="type"> The extended location type. </param>
        /// <param name="name"> The extended location name. </param>
        internal ExtendedLocation(ExtendedLocationType? type, string name)
        {
            Type = type;
            Name = name;
        }

        /// <summary> The extended location type. </summary>
        public ExtendedLocationType? Type { get; set; }
        /// <summary> The extended location name. </summary>
        public string Name { get; set; }
    }
}
