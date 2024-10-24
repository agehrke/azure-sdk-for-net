// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Communication;

/// <summary>
/// EmailService.
/// </summary>
public partial class EmailService : ProvisionableResource
{
    /// <summary>
    /// The name of the EmailService resource.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The location where the email service stores its data at rest.
    /// </summary>
    public BicepValue<string> DataLocation { get => _dataLocation; set => _dataLocation.Assign(value); }
    private readonly BicepValue<string> _dataLocation;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Provisioning state of the resource.
    /// </summary>
    public BicepValue<EmailServicesProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<EmailServicesProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new EmailService.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EmailService resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EmailService.</param>
    public EmailService(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Communication/emailServices", resourceVersion ?? "2023-04-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _dataLocation = BicepValue<string>.DefineProperty(this, "DataLocation", ["properties", "dataLocation"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _provisioningState = BicepValue<EmailServicesProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported EmailService resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2023-03-31.
        /// </summary>
        public static readonly string V2023_03_31 = "2023-03-31";
    }

    /// <summary>
    /// Creates a reference to an existing EmailService.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EmailService resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EmailService.</param>
    /// <returns>The existing EmailService resource.</returns>
    public static EmailService FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
