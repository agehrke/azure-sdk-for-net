// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.Chat
{
    /// <summary> Chat message. </summary>
    internal partial class ChatMessageInternal
    {
        /// <summary> Initializes a new instance of ChatMessageInternal. </summary>
        /// <param name="id"> The id of the chat message. This id is server generated. </param>
        /// <param name="type"> The chat message type. </param>
        /// <param name="sequenceId"> Sequence of the chat message in the conversation. </param>
        /// <param name="version"> Version of the chat message. </param>
        /// <param name="createdOn"> The timestamp when the chat message arrived at the server. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="sequenceId"/> or <paramref name="version"/> is null. </exception>
        internal ChatMessageInternal(string id, ChatMessageType type, string sequenceId, string version, DateTimeOffset createdOn)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(sequenceId, nameof(sequenceId));
            Argument.AssertNotNull(version, nameof(version));

            Id = id;
            Type = type;
            SequenceId = sequenceId;
            Version = version;
            CreatedOn = createdOn;
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ChatMessageInternal. </summary>
        /// <param name="id"> The id of the chat message. This id is server generated. </param>
        /// <param name="type"> The chat message type. </param>
        /// <param name="sequenceId"> Sequence of the chat message in the conversation. </param>
        /// <param name="version"> Version of the chat message. </param>
        /// <param name="content"> Content of a chat message. </param>
        /// <param name="senderDisplayName"> The display name of the chat message sender. This property is used to populate sender name for push notifications. </param>
        /// <param name="createdOn"> The timestamp when the chat message arrived at the server. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="senderCommunicationIdentifier"> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model is polymorphic: Apart from kind and rawId, at most one further property may be set which must match the kind enum value. </param>
        /// <param name="deletedOn"> The timestamp (if applicable) when the message was deleted. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="editedOn"> The last timestamp (if applicable) when the message was edited. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="metadata"> Message metadata. </param>
        internal ChatMessageInternal(string id, ChatMessageType type, string sequenceId, string version, ChatMessageContentInternal content, string senderDisplayName, DateTimeOffset createdOn, CommunicationIdentifierModel senderCommunicationIdentifier, DateTimeOffset? deletedOn, DateTimeOffset? editedOn, IReadOnlyDictionary<string, string> metadata)
        {
            Id = id;
            Type = type;
            SequenceId = sequenceId;
            Version = version;
            Content = content;
            SenderDisplayName = senderDisplayName;
            CreatedOn = createdOn;
            SenderCommunicationIdentifier = senderCommunicationIdentifier;
            DeletedOn = deletedOn;
            EditedOn = editedOn;
            Metadata = metadata;
        }

        /// <summary> The id of the chat message. This id is server generated. </summary>
        public string Id { get; }
        /// <summary> The chat message type. </summary>
        public ChatMessageType Type { get; }
        /// <summary> Sequence of the chat message in the conversation. </summary>
        public string SequenceId { get; }
        /// <summary> Version of the chat message. </summary>
        public string Version { get; }
        /// <summary> Content of a chat message. </summary>
        public ChatMessageContentInternal Content { get; }
        /// <summary> The display name of the chat message sender. This property is used to populate sender name for push notifications. </summary>
        public string SenderDisplayName { get; }
        /// <summary> The timestamp when the chat message arrived at the server. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </summary>
        public DateTimeOffset CreatedOn { get; }
        /// <summary> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model is polymorphic: Apart from kind and rawId, at most one further property may be set which must match the kind enum value. </summary>
        public CommunicationIdentifierModel SenderCommunicationIdentifier { get; }
        /// <summary> The timestamp (if applicable) when the message was deleted. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </summary>
        public DateTimeOffset? DeletedOn { get; }
        /// <summary> The last timestamp (if applicable) when the message was edited. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </summary>
        public DateTimeOffset? EditedOn { get; }
        /// <summary> Message metadata. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
    }
}
