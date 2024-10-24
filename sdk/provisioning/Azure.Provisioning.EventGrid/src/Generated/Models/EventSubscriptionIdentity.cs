// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// The identity information with the event subscription.
/// </summary>
public partial class EventSubscriptionIdentity : ProvisionableConstruct
{
    /// <summary>
    /// The type of managed identity used. Can be either
    /// &apos;SystemAssigned&apos; or &apos;UserAssigned&apos;.
    /// </summary>
    public BicepValue<EventSubscriptionIdentityType> IdentityType { get => _identityType; set => _identityType.Assign(value); }
    private readonly BicepValue<EventSubscriptionIdentityType> _identityType;

    /// <summary>
    /// The user identity associated with the resource.
    /// </summary>
    public BicepValue<string> UserAssignedIdentity { get => _userAssignedIdentity; set => _userAssignedIdentity.Assign(value); }
    private readonly BicepValue<string> _userAssignedIdentity;

    /// <summary>
    /// Creates a new EventSubscriptionIdentity.
    /// </summary>
    public EventSubscriptionIdentity()
    {
        _identityType = BicepValue<EventSubscriptionIdentityType>.DefineProperty(this, "IdentityType", ["type"]);
        _userAssignedIdentity = BicepValue<string>.DefineProperty(this, "UserAssignedIdentity", ["userAssignedIdentity"]);
    }
}
