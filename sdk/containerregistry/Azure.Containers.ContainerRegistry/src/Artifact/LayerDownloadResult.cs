﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary>
    /// </summary>
    public class LayerDownloadResult
    {
        /// <summary>
        /// </summary>
        /// <param name="digest"></param>
        /// <param name="content"></param>
        public LayerDownloadResult(string digest, Stream content)
        {
            Digest = digest;
            Content = content;
        }

        /// <summary>
        /// </summary>
        public string Digest { get; }

        /// <summary>
        /// </summary>
        public Stream Content { get; }
    }
}
