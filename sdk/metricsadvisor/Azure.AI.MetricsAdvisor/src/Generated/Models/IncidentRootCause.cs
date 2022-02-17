// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The RootCause. </summary>
    public partial class IncidentRootCause
    {
        /// <summary> Initializes a new instance of IncidentRootCause. </summary>
        /// <param name="seriesKey"></param>
        /// <param name="paths"> drilling down path from query anomaly to root cause. </param>
        /// <param name="contributionScore"> score of the root cause. </param>
        /// <param name="description"> description of the root cause. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="seriesKey"/>, <paramref name="paths"/> or <paramref name="description"/> is null. </exception>
        internal IncidentRootCause(DimensionKey seriesKey, IEnumerable<string> paths, double contributionScore, string description)
        {
            if (seriesKey == null)
            {
                throw new ArgumentNullException(nameof(seriesKey));
            }
            if (paths == null)
            {
                throw new ArgumentNullException(nameof(paths));
            }
            if (description == null)
            {
                throw new ArgumentNullException(nameof(description));
            }

            SeriesKey = seriesKey;
            Paths = paths.ToList();
            ContributionScore = contributionScore;
            Description = description;
        }

        /// <summary> Initializes a new instance of IncidentRootCause. </summary>
        /// <param name="seriesKey"></param>
        /// <param name="paths"> drilling down path from query anomaly to root cause. </param>
        /// <param name="contributionScore"> score of the root cause. </param>
        /// <param name="description"> description of the root cause. </param>
        internal IncidentRootCause(DimensionKey seriesKey, IReadOnlyList<string> paths, double contributionScore, string description)
        {
            SeriesKey = seriesKey;
            Paths = paths;
            ContributionScore = contributionScore;
            Description = description;
        }
    }
}
