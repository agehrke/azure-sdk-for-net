// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Describes the connection monitor test group. </summary>
    public partial class ConnectionMonitorTestGroup
    {
        /// <summary> Initializes a new instance of ConnectionMonitorTestGroup. </summary>
        /// <param name="name"> The name of the connection monitor test group. </param>
        /// <param name="testConfigurations"> List of test configuration names. </param>
        /// <param name="sources"> List of source endpoint names. </param>
        /// <param name="destinations"> List of destination endpoint names. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="testConfigurations"/>, <paramref name="sources"/> or <paramref name="destinations"/> is null. </exception>
        public ConnectionMonitorTestGroup(string name, IEnumerable<string> testConfigurations, IEnumerable<string> sources, IEnumerable<string> destinations)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (testConfigurations == null)
            {
                throw new ArgumentNullException(nameof(testConfigurations));
            }
            if (sources == null)
            {
                throw new ArgumentNullException(nameof(sources));
            }
            if (destinations == null)
            {
                throw new ArgumentNullException(nameof(destinations));
            }

            Name = name;
            TestConfigurations = testConfigurations.ToList();
            Sources = sources.ToList();
            Destinations = destinations.ToList();
        }

        /// <summary> Initializes a new instance of ConnectionMonitorTestGroup. </summary>
        /// <param name="name"> The name of the connection monitor test group. </param>
        /// <param name="disable"> Value indicating whether test group is disabled. </param>
        /// <param name="testConfigurations"> List of test configuration names. </param>
        /// <param name="sources"> List of source endpoint names. </param>
        /// <param name="destinations"> List of destination endpoint names. </param>
        internal ConnectionMonitorTestGroup(string name, bool? disable, IList<string> testConfigurations, IList<string> sources, IList<string> destinations)
        {
            Name = name;
            Disable = disable;
            TestConfigurations = testConfigurations;
            Sources = sources;
            Destinations = destinations;
        }

        /// <summary> The name of the connection monitor test group. </summary>
        public string Name { get; set; }
        /// <summary> Value indicating whether test group is disabled. </summary>
        public bool? Disable { get; set; }
        /// <summary> List of test configuration names. </summary>
        public IList<string> TestConfigurations { get; }
        /// <summary> List of source endpoint names. </summary>
        public IList<string> Sources { get; }
        /// <summary> List of destination endpoint names. </summary>
        public IList<string> Destinations { get; }
    }
}
