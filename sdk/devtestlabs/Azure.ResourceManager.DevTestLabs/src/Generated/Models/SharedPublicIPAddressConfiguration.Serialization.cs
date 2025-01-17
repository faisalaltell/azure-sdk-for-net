// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    internal partial class SharedPublicIPAddressConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(InboundNatRules))
            {
                writer.WritePropertyName("inboundNatRules"u8);
                writer.WriteStartArray();
                foreach (var item in InboundNatRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SharedPublicIPAddressConfiguration DeserializeSharedPublicIPAddressConfiguration(JsonElement element)
        {
            Optional<IList<DevTestLabInboundNatRule>> inboundNatRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inboundNatRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DevTestLabInboundNatRule> array = new List<DevTestLabInboundNatRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DevTestLabInboundNatRule.DeserializeDevTestLabInboundNatRule(item));
                    }
                    inboundNatRules = array;
                    continue;
                }
            }
            return new SharedPublicIPAddressConfiguration(Optional.ToList(inboundNatRules));
        }
    }
}
