// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class CustomIPPrefixData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation");
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones");
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Cidr))
            {
                writer.WritePropertyName("cidr");
                writer.WriteStringValue(Cidr);
            }
            if (Optional.IsDefined(SignedMessage))
            {
                writer.WritePropertyName("signedMessage");
                writer.WriteStringValue(SignedMessage);
            }
            if (Optional.IsDefined(AuthorizationMessage))
            {
                writer.WritePropertyName("authorizationMessage");
                writer.WriteStringValue(AuthorizationMessage);
            }
            if (Optional.IsDefined(CustomIPPrefixParent))
            {
                writer.WritePropertyName("customIpPrefixParent");
                writer.WriteObjectValue(CustomIPPrefixParent);
            }
            if (Optional.IsDefined(CommissionedState))
            {
                writer.WritePropertyName("commissionedState");
                writer.WriteStringValue(CommissionedState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CustomIPPrefixData DeserializeCustomIPPrefixData(JsonElement element)
        {
            Optional<ExtendedLocation> extendedLocation = default;
            Optional<ETag> etag = default;
            Optional<IList<string>> zones = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> cidr = default;
            Optional<string> signedMessage = default;
            Optional<string> authorizationMessage = default;
            Optional<CustomIPPrefixData> customIpPrefixParent = default;
            Optional<IReadOnlyList<CustomIPPrefixData>> childCustomIpPrefixes = default;
            Optional<CommissionedState> commissionedState = default;
            Optional<IReadOnlyList<WritableSubResource>> publicIpPrefixes = default;
            Optional<Guid> resourceGuid = default;
            Optional<string> failedReason = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("zones"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("cidr"))
                        {
                            cidr = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("signedMessage"))
                        {
                            signedMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authorizationMessage"))
                        {
                            authorizationMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customIpPrefixParent"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            customIpPrefixParent = DeserializeCustomIPPrefixData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("childCustomIpPrefixes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<CustomIPPrefixData> array = new List<CustomIPPrefixData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeCustomIPPrefixData(item));
                            }
                            childCustomIpPrefixes = array;
                            continue;
                        }
                        if (property0.NameEquals("commissionedState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            commissionedState = new CommissionedState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicIpPrefixes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.ToString()));
                            }
                            publicIpPrefixes = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceGuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("failedReason"))
                        {
                            failedReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CustomIPPrefixData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(location), Optional.ToDictionary(tags), extendedLocation, Optional.ToNullable(etag), Optional.ToList(zones), cidr.Value, signedMessage.Value, authorizationMessage.Value, customIpPrefixParent.Value, Optional.ToList(childCustomIpPrefixes), Optional.ToNullable(commissionedState), Optional.ToList(publicIpPrefixes), Optional.ToNullable(resourceGuid), failedReason.Value, Optional.ToNullable(provisioningState));
        }
    }
}
