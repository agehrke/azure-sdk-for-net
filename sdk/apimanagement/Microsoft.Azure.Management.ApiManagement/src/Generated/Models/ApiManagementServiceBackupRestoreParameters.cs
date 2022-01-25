// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Backup/Restore of an API Management service
    /// operation.
    /// </summary>
    public partial class ApiManagementServiceBackupRestoreParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApiManagementServiceBackupRestoreParameters class.
        /// </summary>
        public ApiManagementServiceBackupRestoreParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApiManagementServiceBackupRestoreParameters class.
        /// </summary>
        /// <param name="storageAccount">The name of the Azure storage account
        /// (used to place/retrieve the backup).</param>
        /// <param name="containerName">The name of the blob container (used to
        /// place/retrieve the backup).</param>
        /// <param name="backupName">The name of the backup file to
        /// create/retrieve.</param>
        /// <param name="accessType">The type of access to be used for the
        /// storage account. Possible values include: 'AccessKey',
        /// 'SystemAssignedManagedIdentity',
        /// 'UserAssignedManagedIdentity'</param>
        /// <param name="accessKey">Storage account access key. Required only
        /// if `accessType` is set to `AccessKey`.</param>
        /// <param name="clientId">The Client ID of user assigned managed
        /// identity. Required only if `accessType` is set to
        /// `UserAssignedManagedIdentity`.</param>
        public ApiManagementServiceBackupRestoreParameters(string storageAccount, string containerName, string backupName, string accessType = default(string), string accessKey = default(string), string clientId = default(string))
        {
            StorageAccount = storageAccount;
            ContainerName = containerName;
            BackupName = backupName;
            AccessType = accessType;
            AccessKey = accessKey;
            ClientId = clientId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the Azure storage account (used to
        /// place/retrieve the backup).
        /// </summary>
        [JsonProperty(PropertyName = "storageAccount")]
        public string StorageAccount { get; set; }

        /// <summary>
        /// Gets or sets the name of the blob container (used to place/retrieve
        /// the backup).
        /// </summary>
        [JsonProperty(PropertyName = "containerName")]
        public string ContainerName { get; set; }

        /// <summary>
        /// Gets or sets the name of the backup file to create/retrieve.
        /// </summary>
        [JsonProperty(PropertyName = "backupName")]
        public string BackupName { get; set; }

        /// <summary>
        /// Gets or sets the type of access to be used for the storage account.
        /// Possible values include: 'AccessKey',
        /// 'SystemAssignedManagedIdentity', 'UserAssignedManagedIdentity'
        /// </summary>
        [JsonProperty(PropertyName = "accessType")]
        public string AccessType { get; set; }

        /// <summary>
        /// Gets or sets storage account access key. Required only if
        /// `accessType` is set to `AccessKey`.
        /// </summary>
        [JsonProperty(PropertyName = "accessKey")]
        public string AccessKey { get; set; }

        /// <summary>
        /// Gets or sets the Client ID of user assigned managed identity.
        /// Required only if `accessType` is set to
        /// `UserAssignedManagedIdentity`.
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageAccount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccount");
            }
            if (ContainerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContainerName");
            }
            if (BackupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BackupName");
            }
        }
    }
}
