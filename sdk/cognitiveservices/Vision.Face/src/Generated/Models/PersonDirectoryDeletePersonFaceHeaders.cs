// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for DeletePersonFace operation.
    /// </summary>
    public partial class PersonDirectoryDeletePersonFaceHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PersonDirectoryDeletePersonFaceHeaders class.
        /// </summary>
        public PersonDirectoryDeletePersonFaceHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PersonDirectoryDeletePersonFaceHeaders class.
        /// </summary>
        /// <param name="operationLocation">Operation location with an
        /// operation id used to track the progress of person creation.</param>
        public PersonDirectoryDeletePersonFaceHeaders(string operationLocation = default(string))
        {
            OperationLocation = operationLocation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets operation location with an operation id used to track
        /// the progress of person creation.
        /// </summary>
        [JsonProperty(PropertyName = "Operation-Location")]
        public string OperationLocation { get; set; }

    }
}
